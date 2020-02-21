using AutoMapper;
using RecipeBook.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeBook.Business
{
    public class Service : IDisposable
    {
        protected IMapper mapper;
        protected IUnitOfWork unit;

        public Service(IMapper mapper, IUnitOfWork unit)
        {
            this.mapper = mapper;
            this.unit = unit;
        }

        public void Dispose()
        {
            unit.Dispose();
        }
    }
}
