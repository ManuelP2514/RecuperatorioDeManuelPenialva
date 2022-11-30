using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuperatorioDeManuelPenialva.Entidades
{
    public class Elipse
    {

        public double Semiejemenor { get; set; }
        public double Semiejemayor { get; set; }
        public Trazo Trazo { get; set; }
        public Elipse()
        {

        }
        public Elipse(double SemiejeMayor, double SemiejeMenor)
        {
            Semiejemayor = SemiejeMayor;
            Semiejemenor = SemiejeMenor;
        }
        public double GetPerimetro()
        {
            return 2 * Math.PI * Math.Sqrt(Math.Pow(Semiejemayor, 2) + Math.Pow(Semiejemenor, 2) / 2);
        }
        public double GetArea()
        {
            return Math.PI * Semiejemayor * Semiejemenor;
        }
        public bool Validar() => Semiejemayor != Semiejemenor && Semiejemayor > 0 && Semiejemenor > 0;

    }
}
