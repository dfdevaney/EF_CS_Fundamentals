using System;
using _07_RepositoryPattern_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _07_RepositoryPattern_Tests
{
    [TestClass]
    public class StreamingContentTests
    {
        [TestMethod]
        public void StreamingContentNotes()
        {
            StreamingContent baseObject = new StreamingContent();
            Movie movieObject = new Movie();
            Show showObject = new Show();
            Episode episodeObject = new Episode();

            showObject.Episodes.Add(episodeObject);
            Movie newMovie = new Movie("Venom", "The Best RomCom of the Year!", 95, MaturityRate.PG_13, true, GenreType.RomCom, 132);
        }

        [DataTestMethod]
        [DataRow(MaturityRate.G, true)]
        [DataRow(MaturityRate.PG, true)]
        [DataRow(MaturityRate.PG_13, false)]
        [DataRow(MaturityRate.R, false)]
        public void SetMaturityRating_ShouldGetCorrectBool(MaturityRate rating, bool isFamFriendly)
        {
            StreamingContent content = new StreamingContent("Insert Title Here", "Description Here", 5, rating, true, GenreType.Documentary);

            bool actual = content.FamilyFriendly;
            bool expected = isFamFriendly;
            Assert.AreEqual(expected, actual);
        }
    }
}
