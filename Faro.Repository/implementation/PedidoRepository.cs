using System;
using System.Collections.Generic;
using System.Linq;
using Faro.Domain;
using Faro.Repository.context;
using Faro.Repository.Dto;
using Microsoft.EntityFrameworkCore;

namespace Faro.Repository.implementation
{
    public class PedidoRepository
    {
        private ApplicationDbContext context;

        public PedidoRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Pedido Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Pedido> GetAll()
        {
            throw new System.NotImplementedException();
        }


        public bool Update(Pedido entity)
        {
            throw new System.NotImplementedException();
        }
    }
}