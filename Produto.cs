using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercadao
{
    public class Produto
{
    public string cod { get; set; }
    public string produto { get; set; }
    public string qtd { get; set; }
    public string valorTot { get; set; }

    public Produto(string cod, string produto, string qtd, string valorTot)
    {
        this.cod = cod;
        this.produto = produto;
        this.qtd = qtd;
        this.valorTot = valorTot;
    }
}
}
