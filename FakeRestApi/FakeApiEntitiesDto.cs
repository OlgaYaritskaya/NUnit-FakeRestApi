﻿using System.Text.Json.Serialization;

namespace FakeRestApi
{
    public class FakeApiEntitiesDto
    {
        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("pageCount")]
        public int PageCount { get; set; }

        [JsonPropertyName("excerpt")]
        public string Excerpt { get; set; }

        [JsonPropertyName("publishDate")]
        public string PublishDate { get; set; }
    }
}