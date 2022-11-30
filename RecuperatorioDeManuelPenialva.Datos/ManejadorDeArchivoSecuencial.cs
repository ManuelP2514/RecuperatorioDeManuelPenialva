using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecuperatorioDeManuelPenialva.Entidades;


namespace RecuperatorioDeManuelPenialva.Datos
{
    class ManejadorDeArchivoSecuencial
    {
        
        private static string archivo = "Elipses.txt";

        public static void GuardarArchivoSecuencial(List<Elipse> lista)
        {
            using (var escritor = new StreamWriter(archivo))
            {
                foreach (var elipse in lista)
                {
                    string linea = ConstuirLinea(elipse);
                    escritor.WriteLine(linea);
                }
            }
        }

        private static string ConstuirLinea(Elipse elipse)
        {
            return $"{elipse.Semiejemayor}|{elipse.Semiejemenor}|{(int)elipse.Trazo}";
        }

        public static List<Elipse> LeerArchivoSecuencial()
        {
            List<Elipse> lista = new List<Elipse>();
            using (var lector = new StreamReader(archivo))
            {
                while (!lector.EndOfStream)
                {
                    string linea = lector.ReadLine();
                    Elipse elipse = ConstruirElipse(linea);
                    lista.Add(elipse);
                }
            }

            return lista;
        }

        private static Elipse ConstruirElipse(string linea)
        {
            var campos = linea.Split('|');
            Elipse elipse = new Elipse()
            {
                Semiejemayor = int.Parse(campos[0]),
                Semiejemenor = int.Parse(campos[1]),
                Trazo = (Trazo)int.Parse(campos[2])
            };
            return elipse;
        }
    }
}
