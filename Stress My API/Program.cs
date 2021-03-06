using RestSharp;

// For restSharp reference:
// https://github.com/CL0SeY/RestSharp
/*
 var client = new RestClient("http://example.com");
// client.Authenticator = new HttpBasicAuthenticator(username, password);

var request = new RestRequest("resource/{id}", Method.POST);
request.AddParameter("name", "value"); // adds to POST or URL querystring based on Method
request.AddUrlSegment("id", "123"); // replaces matching token in request.Resource

// add parameters for all properties on an object
request.AddObject(object);

// or just whitelisted properties
request.AddObject(object, "PersonId", "Name", ...);

// easily add HTTP Headers
request.AddHeader("header", "value");

// add files to upload (works with compatible verbs)
request.AddFile("file", path);

// execute the request
IRestResponse response = client.Execute(request);
var content = response.Content; // raw content as string

// or automatically deserialize result
// return content type is sniffed but can be explicitly set via RestClient.AddHandler();
IRestResponse<Person> response2 = client.Execute<Person>(request);
var name = response2.Data.Name;

// or download and save file to disk
client.DownloadData(request).SaveAs(path);

// easy async support
client.ExecuteAsync(request, response => {
    Console.WriteLine(response.Content);
});

// async with deserialization
var asyncHandle = client.ExecuteAsync<Person>(request, response => {
    Console.WriteLine(response.Data.Name);
});

// abort the request on demand
asyncHandle.Abort();
 */

namespace Stress_My_API
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var url = args[0];
            var resource = args[1];
            var hits = int.Parse(args[2]);

            var client = new RestClient(url);
            var request = new RestRequest(resource, Method.Get);

            for (int i = 0; i < hits; i++)
            {
                var response = client.Execute(request);
                var content = response.Content; // raw content as string

                Console.WriteLine(content);
            }

            Console.WriteLine("That's it!");
        }
    }
}