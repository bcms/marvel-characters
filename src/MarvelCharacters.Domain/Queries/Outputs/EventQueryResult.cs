﻿using Newtonsoft.Json;
using System;

namespace MarvelCharacters.Domain.Queries.Outputs
{
    public class EventQueryResult
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("modified")]
        public DateTime? Modified { get; set; }

        [JsonProperty("resourceURI")]
        public string ResourceURI { get; set; }

        [JsonProperty("start")]
        public DateTime? Start { get; set; }

        [JsonProperty("end")]
        public DateTime? End { get; set; }
    }
}
