using AutoMapper;
using RecipeBook.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;

namespace RecipeBook.Business
{
    public class MapperConfigBLL : Profile
    {
        public MapperConfigBLL()
        {
            CreateMap<UserDTO, User>();
            CreateMap<User, UserDTO>();

            CreateMap<Ingredient, IngredientDTO>()
                .ForMember(p => p.Product, c => c.MapFrom(p => p.Product.Name));
            CreateMap<IngredientDTO, Ingredient>()
                .ForMember(p => p.Product, c => c.MapFrom(p => new Product { Name = p.Product }));

            CreateMap<Recipe, RecipeDTO>()
                .ForMember(p => p.Ingredients, c => c.Ignore());
            CreateMap<RecipeDTO, Recipe>()
                .ForMember(p => p.Ingredients, c => c.Ignore());
        }
    }
}
