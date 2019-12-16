using MvvmCross;
using MvvmCross.Base;
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
        public RootObject root = new RootObject();
        public string GetJSONSRecordsAsync() 
        {
            using (HttpClient client = new HttpClient())
            {
                return client.GetStringAsync(URL_GET_STATES).Result;
            }      
        }
        public void GetRecords()
        {
            var jsonText = GetJSONSRecordsAsync();
            root = JsonConvert.DeserializeObject<RootObject>(jsonText);
        } 
    }
}
