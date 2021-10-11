using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;

namespace Negocio
{
    public class clsNegPerson
    {
        clsDAOPerson dAOPerson = new clsDAOPerson();

        public DataTable GetAll()
        {
            return dAOPerson.GetAll();
        }
    }
}
