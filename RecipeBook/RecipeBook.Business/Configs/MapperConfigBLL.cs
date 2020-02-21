using AutoMapper;
using RecipeBook.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeBook.Business
{
    public class MapperConfigBLL : Profile
    {
        public MapperConfigBLL()
        {
            CreateMap<UserDTO, User>();
            CreateMap<User, UserDTO>();

            CreateMap<Ingredient, IngredientDTO>();
            CreateMap<IngredientDTO, Ingredient>();

            CreateMap<Recipe, RecipeDTO>();
            CreateMap<RecipeDTO, Recipe>();
        }
    }
}
