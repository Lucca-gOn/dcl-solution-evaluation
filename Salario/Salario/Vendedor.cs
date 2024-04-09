using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salario
{
    internal class Vendedor
    {
        public int NumeroDeCarrosVendidos { get; set; }
        public decimal ValorTotalDasVendas { get; set; }
        public decimal SalarioFixo { get; set; }
        public decimal ValorPorCarroVendido { get; set; }
        public decimal SalarioFinal { get; set; }

        public void CalcularSalario()
        {
            decimal comissaoTotalPorCarrosVendidos = NumeroDeCarrosVendidos * ValorPorCarroVendido;
            //5% valor das vendas
            decimal comissaoSobreVendas = ValorTotalDasVendas * 0.05m; 
            SalarioFinal = SalarioFixo + comissaoTotalPorCarrosVendidos + comissaoSobreVendas;
        }
    }
}
