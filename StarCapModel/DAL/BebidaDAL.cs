using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace StarCapModel.DAL
{
    public class BebidaDAL
    {
        private static List<Bebida> bebidas = new List<Bebida>()
        {
            new Bebida()
            {
                Nombre = "Moca",
                Codigo = "M-01"
            },
            new Bebida()
            {
                Nombre = "Capuchino",
                Codigo = "F-01"
            },
            new Bebida()
            {
                Nombre = "Vainilla",
                Codigo = "V-01"
            },
            new Bebida()
            {
                Nombre = "Expresso",
                Codigo = "E-01"
            },
            new Bebida()
            {
                Nombre = "Americano",
                Codigo = "A-01"
            }
        };

        public List<Bebida> GetAll()
        {
            return bebidas;
        }
    }
}
