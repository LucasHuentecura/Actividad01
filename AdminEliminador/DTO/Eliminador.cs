using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//NOTA : Para vincular la biblioteca con el proyecto se debe agregar referencia:
//Referencias del proyecto -> Seleccionar librería.
namespace DTO
{
    public struct TiposEliminadores
    {
        public char claveEliminador;

        public string nombreTipoEliminador
        {
            get
            {
                switch (claveEliminador)
                {
                    case 'a':
                        return "T-1";
                    case 'b':
                        return "T-800";
                    case 'c':
                        return "T-1000";
                    case 'd':
                        return "T-3000";
                    default:
                        return "*";
                }
            }
        }
    }

    public class Eliminador
    {
        //Variables.
        private string numeroDeSerie;
        private TiposEliminadores tipoEliminador;
        private int prioridadEliminacion;
        private string objetivo;
        private uint fechaDestino;

        //Getters and Setters.
        public string NumeroDeSerie { get => numeroDeSerie; set { if (contarCaracteres(value)) { numeroDeSerie = value; } else { numeroDeSerie = ""; } } }
        public string TipoEliminador { get => tipoEliminador.nombreTipoEliminador; set { if (value.Equals(string.Empty) || value.Length > 1) { tipoEliminador.claveEliminador = "*".ToCharArray()[0]; } else { tipoEliminador.claveEliminador = value.ToCharArray()[0]; } } }

        public int PrioridadEliminacion { get => prioridadEliminacion; set { if (value > 0 && value < 6 || value == 999) { prioridadEliminacion = value; } else { prioridadEliminacion = 0; } } }
        public string Objetivo { get => objetivo; set => objetivo = value; }
        public uint FechaDestino { get => fechaDestino; set => fechaDestino = value; }

        //Métodos.
        private bool contarCaracteres(string palabra)
        {
            return palabra.Length == 7 ? true : false;
        }

        public override string ToString()
        {
            return "--------------------------------------------------"+
                   "\nNúmero de Serie : " + numeroDeSerie +
                   "\nTipo Eliminador : " + TipoEliminador +
                   "\nObjetivo        : " + objetivo;
        }

    }
}
