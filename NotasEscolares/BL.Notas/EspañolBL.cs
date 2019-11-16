using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Notas
{
    public class EspañolBL
    {
        public BindingList<Español> ListaEspañol { get; set; }
        public EspañolBL()
        {
            ListaEspañol = new BindingList<Español>();

            var español1 = new Español();
            español1.Id = 1;
            español1.Tarea = 5;
            español1.Examen = 25;
            español1.NotaFinal = 30;

            ListaEspañol.Add(español1);

            var español2 = new Español();
            español2.Id = 2;
            español2.Tarea = 4;
            español2.Examen = 23;
            español2.NotaFinal = 27;

            ListaEspañol.Add(español2);

            var español3 = new Español();
            español3.Id = 3;
            español3.Tarea = 5;
            español3.Examen = 20;
            español3.NotaFinal = 25;

            ListaEspañol.Add(español3);

            var español4 = new Español();
            español4.NotaTotal = español1.NotaFinal + español2.NotaFinal + español3.NotaFinal;

            ListaEspañol.Add(español4);
        }

        public BindingList<Español> ObtenerEspañol()
        {
            return ListaEspañol;
        }

        public Resultado GuardarNota(Español español)
        {
            var resultado=Validar(español);
            if(resultado.Exitoso==false)
            {
                return resultado;
            }

            if (español.Id == 0)
            {
                español.Id = ListaEspañol.Max(item => item.Id) + 1;
            }
            resultado.Exitoso = true;
            return resultado;
        }

        public void AgregarNota()
        {
            var nuevaNota = new Español();
            ListaEspañol.Add(nuevaNota);
        }

        public bool EliminarParcial(int id)
        {
            foreach (var parcial in ListaEspañol)
            {
                if (parcial.Id==id)
                {
                    ListaEspañol.Remove(parcial);
                    return true;
                }

            }
            return false;
        }

        private Resultado Validar(Español español)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if(español.Examen < 0)
            {
                resultado.Mensaje = "Ingrese una Nota de examen";
                resultado.Exitoso = false;
            }

            if (español.NotaFinal < 0)
            {
                resultado.Mensaje = "Ingrese una NotaFinal mayor a cero";
                resultado.Exitoso = false;
            }

            if (español.Tarea < 0)
            {
                resultado.Mensaje = "Ingrese una Nota de tarea mayor a cero";
                resultado.Exitoso = false;
            }

            if (español.NotaTotal < 0)
            {
                resultado.Mensaje = "Ingrese una NotaTotal mayor a cero";
                resultado.Exitoso = false;
            }

            return resultado;
        }
    }

    public class Español
    {
        public int Id { get; set; }
        public double Tarea { get; set; }
        
        public double Examen { get; set; }
        
        public double NotaFinal { get; set; }
        public double NotaTotal { get; set; }
    }

    public class Resultado
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }
    }
}
