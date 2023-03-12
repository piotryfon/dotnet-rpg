using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_rpg
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterResponseDto>(); // mapuje na dto przy get
            CreateMap<AddCharacterRequestDto, Character>(); // mapuje na character przy post
        }
    }
}