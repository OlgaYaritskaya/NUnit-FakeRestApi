using FakeRestApi.Requests;
using FluentAssertions;
using Newtonsoft.Json;
using RestSharp;
using System.Net;

namespace FakeRestApi.Tests
{
    public class FakeApiTests : BaseTest
    {
        [Test]
        public void SearchBooks()
        {
            var response = requestClass.GetRequest();
            response.Should().NotBeNull();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }
        [Test]
        public void CreateABook()
        {
            var bookTitle = "Three doors down";
            var id = 13;
            var countPages = 235;

            var response = requestClass.PostRequest(id, bookTitle, countPages);
            response.StatusCode.Should().Be(HttpStatusCode.OK); //it's better to use 201 code for creating
            response.Content.Should().NotBeNull();

            var bodyContent = JsonConvert.DeserializeObject<FakeApiEntitiesDto>(response.Content);

            Assert.AreEqual(bodyContent.Id, id);
            Assert.AreEqual(bodyContent.Title, bookTitle);
        }
    }
}