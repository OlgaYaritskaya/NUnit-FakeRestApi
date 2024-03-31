using FakeRestApi.Requests;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace FakeRestApi.Tests
{
    public class BaseTest
    {
        public RestClient client;
        public RequestClass requestClass;
        private string _baseUrl = "https://fakerestapi.azurewebsites.net";

        [SetUp]
        public void SetUp()
        {
            //client = new RestClient(_baseUrl);
            requestClass = new RequestClass();
        }

        //[TearDown]
        //public void TearDown()
        //{
        //    client.Dispose();
        //}
    }
}
