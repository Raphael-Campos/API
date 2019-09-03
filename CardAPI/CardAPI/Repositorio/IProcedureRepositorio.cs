using CardAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CardAPI.Repositorio
{
    public interface IProcedureRepositorio
    {
        Procedure GetProcedures(int CodEmpresa, string CodEntidade, int CodProduto);
    }
}
