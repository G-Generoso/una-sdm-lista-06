using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ConsumerPokeApi.Models
{
    public class Pokemon
    {     

   
        [JsonPropertyName("id")]
        public int Id{get;set;}


        [JsonPropertyName("name")]
        public string Nome {get; set;}


        [JsonPropertyName("height")]
        public double Altura{get;set;}


        [JsonPropertyName("weight")]
        public double Peso{get;set;}


       
    }
}

    