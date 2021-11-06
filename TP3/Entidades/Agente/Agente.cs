using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Entidades
{
    [XmlInclude(typeof(Duelistas))]
    [XmlInclude(typeof(Controladores))]
    public abstract class Agente
    {
        private string nombre;
        private bool esRadiante;
        private int cantidadElegido;
        private int cantidadEnUSA;
        private int cantidadEnLATAM;
        private int cantidadEnEUROPA;
        private int cantidadPlata;
        private int cantidadOro;
        private int cantidadDiamante;
        private int sumaEdades;

        public Agente()
        {
        }

        
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
            set
            {
                this.nombre = value;
            }
        }

        public bool EsRadiante
        {
            get
            {
                return this.esRadiante;
            }
            set
            {
                this.esRadiante = value;
            }
        }

        [XmlIgnore]
        public int CE
        {
            get
            {
                return this.cantidadElegido;
            }
            set
            {
                this.cantidadElegido = value;
            }
        }

        [XmlIgnore]
        public int CEU
        {
            get
            {
               return this.cantidadEnUSA;
            }
            set
            {
                this.cantidadEnUSA = value;
            }
        }

        [XmlIgnore]
        public int CEL
        {
            get
            {
                return this.cantidadEnLATAM;
            }
            set
            {
                this.cantidadEnLATAM = value;
            }
        }

        [XmlIgnore]
        public int CEE
        {
            get
            {
                return this.cantidadEnEUROPA;
            }
            set
            {
                this.cantidadEnEUROPA = value;
            }
        }

        [XmlIgnore]
        public int CP
        {
            get
            {
                return this.cantidadPlata;
            }
            set
            {
                this.cantidadPlata = value;
            }
        }

        [XmlIgnore]
        public int CO
        {
            get
            {
                return this.cantidadOro;
            }
            set
            {
                this.cantidadOro = value;
            }
        }

        [XmlIgnore]
        public int CD
        {
            get
            {
                return this.cantidadDiamante;
            }
            set
            {
                this.cantidadDiamante = value;
            }
        }

        [XmlIgnore]
        public int SumaEdades
        {
            get
            {
                return this.sumaEdades;
            }
            set
            {
                this.sumaEdades = value;
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

        public int SacarPorcentaje(int cantidad, int cantidadTotal)
        {
            if(cantidadTotal == 0)
            {
                return 0;
            }

            return (cantidad * 100) / cantidadTotal;
        }

        public int SacarPromedio(int cantidad, int cantidadTotal)
        {
            if(cantidadTotal == 0)
            {
                return 0;
            }

            return cantidad / cantidadTotal;
        }

        public static List<Agente> CrearListaAgentes()
        {
            List<Agente> agentes = new List<Agente>();

            Agente due1 = new Duelistas("Phoenix");
            Agente due2 = new Duelistas("Jett", true, false);

            Agente con1 = new Controladores("Brimstone", false, true);
            Agente con2 = new Controladores("Omen");

            agentes.Add(due1);
            agentes.Add(due2);
            agentes.Add(con1);
            agentes.Add(con2);

            return agentes;
        }
    }
}
