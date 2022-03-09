using _06_StreamingContent_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _06_StreamingContent_Test
{
    [TestClass]
    public class StreamingContentRepositoryTest
    {
        [TestMethod]
        public void AddToDirectory_ShouldGetCorrectBoolean()
        {
            //Arrange
            StreamingContent content = new StreamingContent();
            StreamingContentRepository repository = new StreamingContentRepository();


            //Act

            bool addResult = repository.AddContentToDirecty(content);

            //Assert
            Assert.IsTrue(addResult);
            
        }

        [TestMethod]
        public void GetDirectry_ShouldReturnCorrectCollection()
        {
            //Arrange
            StreamingContent content = new StreamingContent();
            StreamingContentRepository repository = new StreamingContentRepository();

            repository.AddContentToDirecty(content);
            //Act

            List<StreamingContent> contents = repository.GetContents();

            bool directoryHasContent = contents.Contains(content);

            //assert

            Assert.IsTrue(directoryHasContent);

        }

        private StreamingContentRepository _repo;
        private StreamingContent _content;

        //aniotation
        [TestInitialize]
        public void Arrange()
        {
            _repo = new StreamingContentRepository();

            _content = new StreamingContent("Rubber", "A car tire comes to life with the power to make people explode.", 4.1, MaturityRating.R, GenreType.Horror);

            _repo.AddContentToDirecty(_content);

        }

        [TestMethod]
        public void GetByTitle_ShouldReturnCorrectContent()
        {
            //Arrage (happened above)

            //Test Initialized got me fam, It'll run before each test method

            //act 
            StreamingContent searchResult = _repo.GetContentByTitle("Rubber");

            //assert
            Assert.AreEqual(_content, searchResult);

        }

        [TestMethod]
        public void UpdateExistingContent_ShouldReturnTrue()
        {
            //Arrange
            StreamingContent updatedContent = new StreamingContent("Rubber", "A car tire comes to life with the power to make people explode.", 4.8, MaturityRating.R, GenreType.Romance);

            //Act

            bool updateResult = _repo.UpdatedExistingContent("Rubber", updatedContent);


            //assert

            Assert.IsTrue(updateResult);
        }

        [TestMethod]
        public void DeleteExistingConent_ShouldReturnTrue()
        {

            //Arrange
            StreamingContent content = _repo.GetContentByTitle("Rubber");

            //Act

            bool removeResult = _repo.DeleteExistingContent(content);

            //assert

            Assert.IsTrue(removeResult);

            //repository pattern and testing is what we reviewed here.

        }

    }
}
