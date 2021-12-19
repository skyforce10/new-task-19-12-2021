/*
 * Created by Ranorex
 * User: skynete
 * Date: 19/12/2021
 * Time: 11:43 AM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;

using RestSharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ApiTest
{
	/// <summary>
	/// Description of Api_test_class.
	/// </summary>
	public class Api_test_class
	{
		public Api_test_class()
		{
		}
		
		//====get response from url
		public static IRestResponse Get(string url){
            //url for testing
            RestClient client = new RestClient(url);
            // Set the Request Type: GET/POST/DELETE/PUT
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            return response;
        }
		//=================parse json
		public static String ParseJson(IRestResponse response, string key){
            string responseJson = "";
            //Verifies if the response has data
            if (response != null) {
                responseJson = response.Content;
            }
            Console.WriteLine(responseJson);
            string keyValue = "";
            //Parses the Json object from the JSON response
            JObject jsonobject = JObject.Parse(responseJson);
            //Fetches the value of the key passed
            keyValue = jsonobject.GetValue(key).ToString();
            Console.WriteLine("KeyValue is: "+keyValue);
            return keyValue;
}
		
	}
}
