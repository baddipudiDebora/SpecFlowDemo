using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;
using RestSharp.Authenticators;
using RestSharp.Serialization.Json;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = NUnit.Framework.Assert;

namespace NUnitTestSpecFlow.Features
{
    [TestClass]
    public class Class1
    {
        private string geturl = "https://tripadvisor1.p.rapidapi.com/attractions/list?&location_id=303890";
        [Test]
        public  void myTest()
        {
            IRestClient client = new RestClient();
            IRestRequest request = new RestRequest(geturl).AddQueryParameter("lang","en_US").AddQueryParameter("currency", "USD").AddHeader("x-rapidapi-host","tripadvisor1.p.rapidapi.com").AddHeader("x-rapidapi-key", "3e1b2b68d1msh65cbdf6a738bd92p1f119cjsn2d12e5e2fb9d");
            IRestResponse response = client.Get(request);
          
                Console.WriteLine("status code " + response.StatusCode);
                Console.WriteLine("status code " + response.Content);
      
         }
    }

}