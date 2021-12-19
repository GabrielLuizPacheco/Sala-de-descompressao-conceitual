using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescompressaoTeste02.Model
{
    class Funcionario
    {
        private static int cpf;
        private static string nome;
        private static DateTime nascimento;
        private static string email;
        private static string usuario;
        private static string senha;

        public static int Cpf { get => cpf; set => cpf = value; }
        public static string Nome { get => nome; set => nome = value; }
        public static DateTime Nascimento { get => nascimento; set => nascimento = value; }
        public static string Email { get => email; set => email = value; }
        public static string Usuario { get => usuario; set => usuario = value; }
        public static string Senha { get => senha; set => senha = value; }
    }
}
