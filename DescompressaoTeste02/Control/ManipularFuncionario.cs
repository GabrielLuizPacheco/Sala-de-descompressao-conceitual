using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DescompressaoTeste02.Model;
using DescompressaoTeste02.View;
using DescompressaoTeste02.Control;

namespace DescompressaoTeste02.Control
{
    class ManipularFuncionario
    {
        public void cadastrarFuncionario()
        {
            SqlConnection cn = new SqlConnection(Conexao.conectar());
            SqlCommand cmd = new SqlCommand("pCadastrarFuncionario", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@CPF", Funcionario.Cpf);
                cmd.Parameters.AddWithValue("@nome", Funcionario.Nome);
                cmd.Parameters.AddWithValue("@nascimento", Funcionario.Nascimento);
                cmd.Parameters.AddWithValue("@email", Funcionario.Email);
                cmd.Parameters.AddWithValue("@usuario", Funcionario.Usuario);
                cmd.Parameters.AddWithValue("@senha", Funcionario.Senha);


                cn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Cadastro realizado com sucesso!");
            }
            catch (Exception)
            {
                MessageBox.Show("Este CPF ja esta em uso.");
                
            }
        }

        public void loginFuncionario()
        {
            SqlConnection cn = new SqlConnection(Conexao.conectar());
            SqlCommand cmd = new SqlCommand("pLoginFuncionario", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@usuario", Funcionario.Usuario);
            cmd.Parameters.AddWithValue("@senha", Funcionario.Senha);

            cn.Open();
            int i = (int)cmd.ExecuteScalar();

            if (i > 0)
            {

                TelaMenu telaMenu = new TelaMenu();
                telaMenu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuário ou Senha incorreto");
            }


        }

        public void dadosFuncionario()
        {
            SqlConnection cn = new SqlConnection(Conexao.conectar());
            SqlCommand cmd = new SqlCommand("pDadosFuncionario", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@usuario", Funcionario.Usuario);
            cmd.Parameters.AddWithValue("@senha", Funcionario.Senha);
            cn.Open();

            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Funcionario.Cpf = Convert.ToInt32(dr["CPF"]);
                Funcionario.Nome = dr["nome"].ToString();
                Funcionario.Nascimento = Convert.ToDateTime(dr["nascimento"]);
                Funcionario.Email = dr["email"].ToString();
                Funcionario.Usuario = dr["usuario"].ToString();
                Funcionario.Senha = dr["senha"].ToString();

            }
            else
            {
                MessageBox.Show("Dados não encontrados!");
            }
        }

        public static BindingSource visuAgendamentosFuncionario()
        {
            SqlConnection cn = new SqlConnection(Conexao.conectar());
            SqlCommand cmd = new SqlCommand("pAgendamentosFuncionario", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@CPF", Funcionario.Cpf);

            cn.Open();

            cmd.ExecuteScalar();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);

            BindingSource dados = new BindingSource();
            dados.DataSource = dt;


            return dados;


        }

        public void alterarDadosFuncionario()
        {
            SqlConnection cn = new SqlConnection(Conexao.conectar());
            SqlCommand cmd = new SqlCommand("pAlterarDadosFuncionario", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@CPF", Funcionario.Cpf);
            cmd.Parameters.AddWithValue("@nome", Funcionario.Nome);
            cmd.Parameters.AddWithValue("@nascimento", Funcionario.Nascimento);
            cmd.Parameters.AddWithValue("@email", Funcionario.Email);
            cmd.Parameters.AddWithValue("@usuario", Funcionario.Usuario);
            cmd.Parameters.AddWithValue("@senha", Funcionario.Senha);

            cn.Open();
            cmd.ExecuteNonQuery();

            MessageBox.Show("Dados alterados com sucesso");
        }

        
        


        

    }

}



        
    

