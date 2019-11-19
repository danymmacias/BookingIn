using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentalsof
{
    public class agenda
    {
        public String paciente;
        public String tratamiento;
        public String hora;
        public String telefono;
        public String dia;
        public String cost;
        private string p1;
        private string p2;
        private string p3;
        private string p4;
        private string p5;
        private string p6;
        private string p7;

        public agenda(String Paciente, String Tratamiento, String Hora, String Telefono, String Dia, String Costo)
        {
            this.paciente = Paciente;
            tratamiento = Tratamiento;
            hora = Hora;
            telefono = Telefono;
            dia = Dia;
            cost = Costo;
        }

        public agenda(string p1, string p2, string p3, string p4, string p5, string p6, string p7)
        {
            // TODO: Complete member initialization
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            this.p4 = p4;
            this.p5 = p5;
            this.p6 = p6;
            this.p7 = p7;
        }

        public object costo { get; set; }
    }
}
