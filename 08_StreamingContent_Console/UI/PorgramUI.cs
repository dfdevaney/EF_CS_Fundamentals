using _07_RepositoryPattern_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_StreamingContent_Console.UI
{
    class ProgramUI
    {
        private readonly StreamingRepository _streamingRepository = new StreamingRepository();
        public void Run()
        {
            SeedContent();
            RunMenu();
        }

        private void RunMenu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {   
                // Challenge: 
                // Get All Shows.
                // Get all Movies.
                // Get Show/Movie by Title.

                Console.Clear();
                Console.WriteLine(
                    "Enter the Number of the Desired Option: \n" + // \n Creates a New Line of text.
                    "1) Show all Streaming Content. \n" + 
                    "2) Find by Title.\n" + 
                    "3) Add New Content. \n" + 
                    "4) Remove Content. \n" + 
                    "5) Exit.");

                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1": //Show All
                        ShowAllContent();
                        break;
                    case "2": //Find by Title
                        ShowContentByTitle();
                        break;
                    case "3": // Add New
                        CreateNewContent();
                        break;
                    case "4": //Remove
                        RemoveContentFromList();
                        break;
                    case "5": // Exit
                        continueToRun = false;
                        break;
                    default: // If user enters something not between 1-5.
                        Console.WriteLine("Please Enter a Vaid Number Between 1-5.");
                        Console.ReadKey();
                        break;
                }
            }
        }
        private void CreateNewContent()
        {
            // New Content Object.
            StreamingContent content = new StreamingContent();

            // Ask user for Information.
            Console.WriteLine("Please Enter New Content Title: ");

            // Tile
            content.Title = Console.ReadLine();

            // Description
            Console.WriteLine($"Please Enter Description for {content.Title}: ");
            content.Description = Console.ReadLine();

            // Star Rating
            Console.WriteLine($"Please Enter Star Rating for {content.Title}: ");
            content.StarRating = float.Parse(Console.ReadLine());

            // Maturity Rating
            Console.WriteLine("Please Select a Maturity Rating: \n" + "1) G \n" + "2) PG \n" + "3) PG-13 \n" + "4) R \n" + "5) NC-17 \n" + "6) MA");
            string maturityResponse = Console.ReadLine();
            switch(maturityResponse)
            {
                case "1":
                    content.MaturityRating = MaturityRate.G;
                    break;
                case "2":
                    content.MaturityRating = MaturityRate.PG;
                    break;
                case "3":
                    content.MaturityRating = MaturityRate.PG_13;
                    break;
                case "4":
                    content.MaturityRating = MaturityRate.R;
                    break;
                case "5":
                    content.MaturityRating = MaturityRate.NC_17;
                    break;
                case "6":
                    content.MaturityRating = MaturityRate.MA;
                    break;
            }

            // TypeOfGenre: Horror = 1, RomCom, Fantasy, SciFi, Drama, Comedy, Action, Documentary, Suspence
            Console.WriteLine("Please Select a Genre: \n" + "1) Horror \n" + "2) Romantic Comedy \n" + "3) Science Fiction \n" + "4) Drama \n" + "5) Comedy \n" + "6) Action \n" + "7) Documentary \n" + "Suspence");
            string genreResponse = Console.ReadLine();
            int genreID = int.Parse(genreResponse);
            content.TypeOfGenre = (GenreType)genreID;

            // Need a New Content with Properties Filled out by user.
            // Then Pass that to the Add Method in our Repository.
            _streamingRepository.AddContenttoDirectory(content);
        }
        private void ShowAllContent()
        {
            Console.Clear();

            // Get Items from Database.
            List<StreamingContent> listOfContent = _streamingRepository.GetContents();

            // Take EACH Item & Display Property Values.
            foreach(StreamingContent content in listOfContent)
            {
                DisplaySimple(content);
            }

            // Pause the Program so the user can See the Printed Objects.
            Console.WriteLine("Press any key to continue ...");
            Console.ReadKey();

            // Goal: Show All Items in Database.
        }
        private void ShowContentByTitle()
        {
            Console.Clear();
            // Goal: Show Only One Object -> Found by Title.

            // Step 01: Get Title From user.
            Console.WriteLine("Please enter Title for Search: ");
            string title = Console.ReadLine();

            // Use Title to Find the One Object.
            StreamingContent foundContent = _streamingRepository.GetContentByTitle(title);

            // If Object Found, Display Data / If Not, Iform user that Input does not Exist.
            if(foundContent != null)
            {
                DisplayAllProps(foundContent);
            }
            else
            {
                Console.WriteLine("Title Input Does Not Exist. \n" + "Try Again.");
            }
            Console.WriteLine("Press Any Key to Continue ...");
            Console.ReadKey();
        }
        private void RemoveContentFromList()
        {
            // Prompt user Which Item to Remove from List.
            Console.WriteLine("Which Item Would You Like to Remove?");

            // Need a List of Items.
            List<StreamingContent> contentList = _streamingRepository.GetContents();
            int count = 0;
            foreach(var content in contentList)
            {
                count++;
                Console.WriteLine($"{count}) {content.Title}");
            }

            // Take in user Response.
            int targetContentID = int.Parse(Console.ReadLine());
            int correctIndex = targetContentID - 1;
            if(correctIndex >= 0 && correctIndex < contentList.Count)
            {
                StreamingContent desiredContent = contentList[correctIndex];
                if(_streamingRepository.DeleteExistingContent(desiredContent))
                {
                    Console.WriteLine($"{desiredContent.Title} Has Been Removed!");
                }
                else
                {
                    Console.WriteLine("I'm sorry, Dave. I'm afraid I can't do that ...");
                }
            }
            else
            {
                Console.WriteLine("Invalad Opiton!");
            }
            Console.WriteLine("Press Any Key to Continue ...");
            Console.ReadKey();

            // Goal: Remove Item.
        }
        private void DisplaySimple(StreamingContent content)
        {
            Console.WriteLine($"{ content.Title}) \n" + $"{content.Description} \n" + $"------------------");
        }
        private void DisplayAllProps(StreamingContent content)
        {
            Console.WriteLine($"Title: {content.Title} \n" +
                $"Description: {content.Description} \n" +
                $"Type of Genre: {content.TypeOfGenre} \n" +
                $"Star Rating: { content.StarRating} \n" +
                $"Content is Family Frindly: {content.FamilyFriendly} \n" +
                $"Maturity Rating: {content.MaturityRating}");
        }
        private void SeedContent()
        {
            var titleOne = new StreamingContent("Toy Story", "Toys go on an adventure.", 4, MaturityRate.PG, true, GenreType.Fantasy);
            var titleTwo = new StreamingContent("Star Wars", "War in the Stars", 5, MaturityRate.PG, true, GenreType.SciFi);
            _streamingRepository.AddContenttoDirectory(titleOne);
            _streamingRepository.AddContenttoDirectory(titleTwo);
        }
    }
}
