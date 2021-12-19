using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DescompressaoTeste02.Model;
using System.Windows.Forms;

namespace DescompressaoTeste02.Control
{
    class ManipularReserva
    {
        public void calcularReserva1()
        {


            string[] nomes = { "08:00", "8:20", "8:40", "9:00" };


            for (int i = 0; i < 4; i++)
            {
                Reserva.HoraInicio = nomes[i];
                calcularReserva();
            }


        }

        public void calcularReserva()
        {
            SqlConnection cn = new SqlConnection(Conexao.conectar());
            SqlCommand cmd = new SqlCommand("pVisualizarHorario", cn);
            cmd.CommandType = CommandType.StoredProcedure;


            cmd.Parameters.AddWithValue("@data", Reserva.Data);
            cmd.Parameters.AddWithValue("@horaInicio", Reserva.HoraInicio);
            cn.Open();


            Reserva.Numero = (int)cmd.ExecuteScalar();


        }

        public static BindingSource visualizarTodasReservas()
        {
            SqlConnection cn = new SqlConnection(Conexao.conectar());
            SqlCommand cmd = new SqlCommand("pContador", cn);
            cmd.CommandType = CommandType.StoredProcedure;


            cmd.Parameters.AddWithValue("@data", Reserva.Data);

            cn.Open();

            cmd.ExecuteScalar();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);

            BindingSource dados = new BindingSource();
            dados.DataSource = dt;


            return dados;

        }

        public void fazerReserva()
        {
            SqlConnection cn = new SqlConnection(Conexao.conectar());
            SqlCommand cmd = new SqlCommand("pFazerReserva", cn);
            cmd.CommandType = CommandType.StoredProcedure;


            cmd.Parameters.AddWithValue("@data", Reserva.Data);
            cmd.Parameters.AddWithValue("@horaInicio", Reserva.HoraInicio);
            cmd.Parameters.AddWithValue("@horaFim", Reserva.HoraFim);
            cmd.Parameters.AddWithValue("@CPF", Funcionario.Cpf);


            SqlParameter nv = cmd.Parameters.AddWithValue("@idReserva", SqlDbType.Int);
            nv.Direction = ParameterDirection.Output;

            cn.Open();
            cmd.ExecuteNonQuery();

            MessageBox.Show("Agendamento realizado com sucesso!");



        }

        public void barrarAgendamento()
        {
            SqlConnection cn = new SqlConnection(Conexao.conectar());
            SqlCommand cmd = new SqlCommand("pBarrarAgendamento", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@CPF", Funcionario.Cpf);
                cmd.Parameters.AddWithValue("@data", Reserva.Data);
                cn.Open();

                var dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Reserva.DataBarrar = Convert.ToDateTime(dr["dataA"]);
                }
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void deletarReserva()
        {
            SqlConnection cn = new SqlConnection(Conexao.conectar());
            SqlCommand cmd = new SqlCommand("pDeletarReserva", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@CPF", Funcionario.Cpf);
                cmd.Parameters.AddWithValue("@data", Reserva.DataCancelar);

                cn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Reserva removida com sucesso");

            }
            catch (Exception)
            {

                throw;
            }
        }

        public static string barrarHorario()
        {
            SqlConnection cn = new SqlConnection(Conexao.conectar());
            SqlCommand cmd = new SqlCommand("pContador", cn);
            cmd.CommandType = CommandType.StoredProcedure;


            cmd.Parameters.AddWithValue("@data", Reserva.Data);

            cn.Open();

            return Convert.ToString(cmd.ExecuteScalar());
        }

    }
}
