using FakeRestApi.Tests;
using RestSharp;

namespace FakeRestApi.Requests
{
    public class RequestClass 
    {
        RestClient client = new RestClient("https://fakerestapi.azurewebsites.net");

        public RestResponse GetRequest()
        {
            var request = new RestRequest("/api/v1/Books", Method.Get);
            var response = client.Execute(request);  
            
            return response;    
        }
        public static FakeApiEntitiesDto BuildBodyRequest(int id, string title, int pageCount)
        {
            return new FakeApiEntitiesDto
            {
                Id = id,
                Title = title,
                Description = "description",
                Excerpt = "uem num gosta di mim que vai caçá sua turmis!",
                PageCount = pageCount,
                PublishDate = "2023-09-03T13:50:32.6884665+00:00"
            };
        }

        public RestResponse PostRequest(int id, string title, int pageCount)
        {
            var body = BuildBodyRequest(id, title, pageCount);
            var request = new RestRequest("/api/v1/Books", Method.Post);
            request.AddBody(body, ContentType.Json);

            var response = client.Execute(request);

            return response;
        }
    }
}
