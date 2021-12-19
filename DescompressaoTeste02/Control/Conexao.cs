using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescompressaoTeste02.Control
{
    class Conexao
    {

        public static string conectar()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gabri\source\repos\solution_DescompressaoTeste02\DescompressaoTeste02\BancoSalaDeDescompressao.mdf;Integrated Security=True";
        }

    }


}