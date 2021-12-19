using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescompressaoTeste02.Model
{
    class Reserva
    {
        private static DateTime data;
        private static String horaInicio;
        private static string horaFim;
        private static int numero;
        private static DateTime dataCancelar;
        private static DateTime dataBarrar;
        private static string[] horarioBarrar;

        public static DateTime Data { get => data; set => data = value; }
        public static string HoraInicio { get => horaInicio; set => horaInicio = value; }
        public static string HoraFim { get => horaFim; set => horaFim = value; }
        public static int Numero { get => numero; set => numero = value; }
        public static DateTime DataCancelar { get => dataCancelar; set => dataCancelar = value; }
        public static DateTime DataBarrar { get => dataBarrar; set => dataBarrar = value; }
        public static string[] HorarioBarrar { get => horarioBarrar; set => horarioBarrar = value; }
    }
}
