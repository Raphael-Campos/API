using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CardAPI.Models
{
    public class Procedure
    {
        public int CodProduto { get; set; }
        public string Descricao { get; set; }
        public string Marca { get; set; }
        public string NumFabricante { get; set; }
        public string NumOriginal { get; set; }
        public int SaldoEstoque { get; set; }
        public int QtdePreEstoque { get; set; }
        public int QtdeTransito { get; set; }
        public int QtdePendCompra { get; set; }
        public string DataCusto { get; set; }
        public decimal CustoAtual { get; set; }
        public decimal PrecoSugerido { get; set; }
        public string DataUltMovimento { get; set; }
        public int TipoMovimento { get; set; }
        public decimal CustoPraticado { get; set; }
        public decimal PrecoPraticado { get; set; }
        public decimal MargemPraticada { get; set; }
        public int Promocao { get; set; }
    }
}
