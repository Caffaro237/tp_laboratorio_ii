using System;
using System.Text;

namespace Entidades
{
    public abstract class Agente
    {
        private string nombre;
        private bool esRadiante;

        public Agente(string nombre) : this(nombre, false)
        {
        }

        public Agente(string nombre, bool esRadiante)
        {
            this.nombre = nombre;
            this.esRadiante = esRadiante;
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public bool EsRadiante
        {
            get
            {
                return this.esRadiante;
            }
        }

        public virtual string MostrarAgente()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("---------------------");
            sb.AppendLine($"Nombre: {this.Nombre}");
            sb.AppendFormat("{0} es Radiante", this.EsRadiante ? "Si" : "No");

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.MostrarAgente();
        }
    }
}
