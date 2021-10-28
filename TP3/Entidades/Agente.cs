using System;
using System.Text;

namespace Entidades
{
    public abstract class Agente
    {
        string nombre;
        bool esRadiante;

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

        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {this.Nombre}");
            sb.AppendFormat("Es Radiante: {1}", this.esRadiante ? "Si" : "No");

            return sb.ToString();
        }


        public static bool operator ==(Agente agente1, Agente agente2)
        {
            if (agente1.Nombre == agente2.Nombre)
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(Agente agente1, Agente agente2)
        {
            return !(agente1 == agente2);
        }
    }
}
