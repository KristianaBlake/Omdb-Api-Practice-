using System;
using OMDbApiNet;
using OMDbApiNet.Model;

namespace OmdbAPiPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            OmdbClient client = new OmdbClient("942af2e");
            Item userSearch = client.GetItemByTitle("Batman");
            Console.WriteLine(userSearch.Title);
            Console.WriteLine("Hello World!");
        }
    }
}
