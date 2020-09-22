using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using _07_RepositoryPattern_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _07_RepositoryPattern_Tests
{
    [TestClass]
    public class SteamingContentRepositoryTests
    {
        [TestMethod]
        public void AddToDirectory_ShouldGetCorrectBoolean()
        {
            // Arrange

            StreamingContent content = new StreamingContent();
            StreamingContentRepository repository = new StreamingContentRepository();

            // ACT

            bool addResult = repository.AddContenttoDirectory(content);

            // ASSERT

            Assert.IsTrue(addResult);
        }

        [TestMethod]
        public void GetDirectory_ShouldReturnCorrectCollection()
        {
            // Arrange

            StreamingContent newObject = new StreamingContent();
            StreamingContentRepository repo = new StreamingContentRepository();
            repo.AddContenttoDirectory(newObject);

            //ACT

            List<StreamingContent> listOfContents = repo.GetContents();

            // ASSERT

            bool directoryHasContent = listOfContents.Contains(newObject);
            Assert.IsTrue(directoryHasContent);
        }

        private StreamingContentRepository _repo;
        private StreamingContent _content;
        [TestInitialize]
        public void Arrange()
        {
            _repo = new StreamingContentRepository();
            _content = new StreamingContent("Ocean's Eight", "Heist", 88, MaturityRate.PG_13, true, GenreType.Comedy);
            _repo.AddContenttoDirectory(_content);
        }

        [TestMethod]
        public void GetByTitle_ShouldReturnCorrectContent()
        {
            // Arrange
            // ACT
            StreamingContent searchResult = _repo.GetContentByTitle("Ocean's Eight");

            // ASSERT
            Assert.AreEqual(_content, searchResult);
        }

        [TestMethod]
        public void UpdateExistingContent_ShouldReturnTrue()
        {
            // Arrange
            StreamingContent updatedContent = new StreamingContent("The Italian Job", "Still a Heist", 88, MaturityRate.PG_13, false, GenreType.Suspence);
            _repo.AddContenttoDirectory(_content);

            // ACT
            bool updateResult = _repo.UpdateExistingContnet("Ocean's Eight", updatedContent);

            // ASSERT
            Assert.IsTrue(updateResult);
        }

        [TestMethod]
        public void DeleteExistingContent_ShouldReturnTrue()
        {
            // Arrange
            StreamingContent foundContent = _repo.GetContentByTitle("Ocean's Eight");

            // ACT
            bool removeResult = _repo.DeleteExistingContent(foundContent);

            // ASSERT
            Assert.IsTrue(removeResult);
        }
    }
}
