﻿using System;

namespace MarvelCharacters.Domain.Queries
{
    public class GetPagedCharactersQuery : GetPagedQuery
    {
        public string Name { get; set; }
        public string NameStartsWith { get; set; }
        public DateTime? ModifiedSince { get; set; }
    }
}
