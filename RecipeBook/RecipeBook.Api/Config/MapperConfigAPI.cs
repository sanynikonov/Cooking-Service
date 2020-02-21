using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RecipeBook.Api.Models;
using RecipeBook.Business;

namespace RecipeBook.Api
{
    public class MapperConfigAPI : Profile
    {
        public MapperConfigAPI()
        {
            CreateMap<RecipeModel, RecipeDTO>()
                .ForMember(p => p.Ingredients, c => c.Ignore())
                .ReverseMap();

            CreateMap<IngredientModel, IngredientDTO>()
                .ReverseMap();
        }
    }
}
