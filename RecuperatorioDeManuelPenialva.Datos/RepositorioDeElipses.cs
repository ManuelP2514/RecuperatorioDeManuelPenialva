using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecuperatorioDeManuelPenialva.Entidades;


namespace RecuperatorioDeManuelPenialva.Datos
{
    public class RepositorioDeElipses
    {
        private bool HayCambios = false;
        private List<Elipse> listaElipses;

        public RepositorioDeElipses()
        {
            listaElipses = new List<Elipse>();
            listaElipses = ManejadorDeArchivoSecuencial.LeerArchivoSecuencial();


        }
        public void Agregar(Elipse elipse)
        {
            listaElipses.Add(elipse);
            HayCambios = true;
        }

        public int GetCantidad()
        {
            return listaElipses.Count;
        }

        public List<Elipse> GetLista()
        {
            return listaElipses;
        }
        public void Borrar(Elipse elipse)
        {
            listaElipses.Remove(elipse);
            HayCambios = true;
        }
        public void Editar(Elipse elipse)
        {
            HayCambios = true;
        }
        public void GuardarCambios()
        {
            if (HayCambios)
            {
                ManejadorDeArchivoSecuencial.GuardarArchivoSecuencial(listaElipses);
            }
        }
        public List<Elipse> GetListaOrdenadaAsc()
        {
            return listaElipses.OrderBy(e => e.GetPerimetro()).ToList();
        }

        public List<Elipse> GetListaOrdenadaDsc()
        {
            return listaElipses.OrderByDescending(e => e.GetPerimetro()).ToList();
        }
        public List<Elipse> FiltrarPorTrazo(Trazo trazoFiltrar)
        {
            return listaElipses.Where(e => e.Trazo == trazoFiltrar).ToList();
        }
    }
}
