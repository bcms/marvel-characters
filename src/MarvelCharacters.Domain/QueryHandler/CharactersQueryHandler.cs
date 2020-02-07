﻿using Flunt.Notifications;
using MarvelCharacters.Domain.Queries.Inputs;
using MarvelCharacters.Domain.Queries.Outputs;
using MarvelCharacters.Domain.Queries.Results.Outputs;
using MarvelCharacters.Domain.Repositories;
using MarvelCharacters.Shared.Request;
using System.Threading.Tasks;

namespace MarvelCharacters.Domain.QueryHandler
{
    public class CharactersQueryHandler :
        Notifiable,
        IRequestHandler<GetPagedCharactersQuery, PagedQueryResult<CharacterQueryResult>>
    {
        private readonly ICharactersRepository _charactersRepository;

        public CharactersQueryHandler(ICharactersRepository charactersRepository)
        {
            _charactersRepository = charactersRepository;
        }

        public async Task<IRequestResult<PagedQueryResult<CharacterQueryResult>>> Handle(GetPagedCharactersQuery request)
        {
            if (!request.Validate())
            {
                AddNotifications(request);
                return new RequestResult<PagedQueryResult<CharacterQueryResult>> (false, "It was not possible to return the Characters");
            }

            return new RequestResult<PagedQueryResult<CharacterQueryResult>> (true, "Characters successfull returneds")
            {
                Data = await _charactersRepository.GetCharactersAsync(request)
            };
        }
    }
}
