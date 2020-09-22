using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositoryPattern_Repository
{
    public class StreamingRepository : StreamingContentRepository
    {
        public Show GetShowByTitle(string title)
        {
            foreach(StreamingContent content in _contentDirectory)
            {
                if(content.Title.ToLower() == title.ToLower() && content.GetType() == typeof(Show))
                {
                    return (Show)content;
                }
            }
            return null;
        }
        public Movie GetMovieByTitle(string title)
        {
            foreach(StreamingContent content in _contentDirectory)
            {
                if(content.Title.ToLower() == title.ToLower() && content.GetType() == typeof(Movie))
                {
                    return (Movie)content;
                }
            }
            return null;
        }

        public List<Show> GetAllShows()
        {
            // Make a Space to Save all Shows:

            List<Show> allShows = new List<Show>();

            // Want to Pull one Item & see if it is a Show:

            foreach(StreamingContent content in _contentDirectory)
            {
                if(content is Show)
                {
                    allShows.Add((Show)content); // This Casts the content into the Show.
                }
            }

            // Then Save it off to the Side:

            return allShows;

            // Return Saved Side List:

        }

            // Write GetAllMovies:

        public List<Movie> GetAllMovies()
        {
            List<Movie> allMovies = new List<Movie>();

            foreach(StreamingContent content in _contentDirectory)
            {
                if(content is Movie)
                {
                    allMovies.Add((Movie)content);
                }
            }
            return allMovies;
        }


        // GetByOtherParamters, ex: GetAllFamilyFriendlyMovies:

        public List<Movie> GetAllFamFriendlyMovies()
        {
            List<Movie> allFamFriendlyMovies = new List<Movie>();
            foreach(StreamingContent content in _contentDirectory)
            {
                if(content is Movie && content.FamilyFriendly)
                {
                    allFamFriendlyMovies.Add((Movie)content);
                }
            }
            return allFamFriendlyMovies;
        }

        // Get Shows with over (x) Episodes:

        // Going to Pass in value (x) that 
        // Single out all shows from my list (aka fake database):
        // Now I have a list of shows:
        // Use parameter Episodes to get episode count:
        // Using that Number compared to the Number Passed in, Add it to a List.
        // Return a List.

        public List<Show> GetAllShowsOverACertainEpisodeCount(int episodeCount)
        {
            List<Show> finalList = new List<Show>();
            var listOfAllShows = GetAllShows();     // var creates the context of what variable is already in place.
            foreach(var eachShow in listOfAllShows)
            {

                if (eachShow.Episodes.Count() >= episodeCount)
                {
                    finalList.Add((Show)eachShow);
                }
            }
            return finalList;
        }

    }
}
