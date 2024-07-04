﻿using Microsoft.EntityFrameworkCore;
using PU5Pinacoteca.Models.Entities;

namespace PU5Pinacoteca.Repositories
{
    public class PintoresRepository : Repository<Pintor>
    {
        public PintoresRepository(PinacotecabdContext context) : base(context)
        {

        }

        //traer por pais de nacimiento
        public override IEnumerable<Pintor> GetAll()
        {
            return Context.Pintor.OrderBy(x => x.Pais);
        }
        public Pintor? GetByNombre(string nombre)
        {
            return Context.Pintor.FirstOrDefault(x => x.Nombre == nombre);
        }
    }
}

