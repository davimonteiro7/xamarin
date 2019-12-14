using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TesteDevXamarin.Core.Models.Data.JSONMapping
{
    public class ImportStates
    {
        const string URL_GET_STATES = "https://api.airtable.com/v0/app0RCW0xYP8RT3U9/Estados?api_key=keyhS9s7U3bGKSuml";
        public RootObject root;
        public async Task GetRecords() 
        {
            HttpClient client = new HttpClient();

            var result = await client.GetStringAsync(URL_GET_STATES);

            root = JsonConvert.DeserializeObject<RootObject>(result);
        }
            
       

    }
}
