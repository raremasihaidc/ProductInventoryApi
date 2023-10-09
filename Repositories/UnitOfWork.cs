using AutoMapper;
using ProductsInventory.Data;
using ProductsInventory.Repositories.Interface;
using System;

namespace ProductsInventory.Repositories
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly ProductDbContext _dbContext;
        private readonly IMapper _mapper;
        public UnitOfWork(ProductDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public void Save()
        {
           _dbContext.SaveChanges();
        }
    }
}
