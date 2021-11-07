using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Entidades
{
    //Include utilizado para poder serializar las clases derivadas
    [XmlInclude(typeof(Duelistas))]
    [XmlInclude(typeof(Controladores))]
    public abstract class Agente
    {
        #region Atributos 

        private string nombre;
        private bool esRadiante;
        
        /*private int cantidadElegido;
        private int cantidadEnUSA;
        private int cantidadEnLATAM;
        private int cantidadEnEUROPA;
        private int cantidadPlata;
        private int cantidadOro;
        private int cantidadDiamante;
        private int sumaEdades;*/

        #endregion

        #region Constructores

        /// <summary>
        /// Constructor sin parametros necesitado por la serializacion
        /// </summary>
        public Agente()
        {
        }

        /// <summary>
        /// Constructor que recibe nombre y llama al contructor que recibe nombre y si es radiante
        /// Por defecto no es radiante
        /// </summary>
        /// <param name="nombre"></param>
        public Agente(string nombre) : this(nombre, false)
        {
        }

        /// <summary>
        /// Cosntructor que recibe el nombre y si es radiante, seteando los datos
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="esRadiante"></param>
        public Agente(string nombre, bool esRadiante)
        {
            this.nombre = nombre;
            this.esRadiante = esRadiante;
        }

        #endregion

        #region Propiedades

        /// <summary>
        /// Propiedad de lectura del nombre
        /// La escritura fue agregada para la serializacion del Agente
        /// </summary>
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

        /// <summary>
        /// Propiedad de lectura de si es radiante o no
        /// La escritura fue agregada para la serializacion del Agente
        /// </summary>
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

        /*
        /// <summary>
        /// Propiedad de lectura y escritura de la cantidad de veces elegido el agente
        /// Usando [XmlIgnore] para que no sea serializada
        /// </summary>
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

        /// <summary>
        /// Propiedad de lectura y escritura de la cantidad de veces elegido desde USA
        /// Usando [XmlIgnore] para que no sea serializada
        /// </summary>
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

        /// <summary>
        /// Propiedad de lectura y escritura de la cantidad de veces elegido desde LATAM
        /// Usando [XmlIgnore] para que no sea serializada
        /// </summary>
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

        /// <summary>
        /// Propiedad de lectura y escritura de la cantidad de veces elegido desde EUROPA
        /// Usando [XmlIgnore] para que no sea serializada
        /// </summary>
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

        /// <summary>
        /// Propiedad de lectura y escritura de la cantidad de veces elegido siendo rango PLATA
        /// Usando [XmlIgnore] para que no sea serializada
        /// </summary>
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

        /// <summary>
        /// Propiedad de lectura y escritura de la cantidad de veces elegido siendo rango ORO
        /// Usando [XmlIgnore] para que no sea serializada
        /// </summary>
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

        /// <summary>
        /// Propiedad de lectura y escritura de la cantidad de veces elegido siendo rango DIAMANTE
        /// Usando [XmlIgnore] para que no sea serializada
        /// </summary>
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

        /// <summary>
        /// Propiedad de lectura y escritura de la suma de todas las edades
        /// Usada despues para sacar un promedio
        /// Usando [XmlIgnore] para que no sea serializada
        /// </summary>
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
        }*/

        #endregion

        #region Metodos

        /// <summary>
        /// Metodo que muestra el agente
        /// Permitiendo sobreescribir y agregar datos
        /// </summary>
        /// <returns> Retorna un string con los datos del agente </returns>
        public virtual string MostrarAgente()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("---------------------");
            sb.AppendLine($"Nombre: {this.Nombre}");
            sb.AppendFormat("{0} es Radiante", this.EsRadiante ? "Si" : "No");

            return sb.ToString();
        }

        /// <summary>
        /// Override del metodo ToString()
        /// </summary>
        /// <returns> Expone los datos del metodo MostrarAgente() </returns>
        public override string ToString()
        {
            return this.MostrarAgente();
        }

        /// <summary>
        /// Este metodo recibe una cantidad X de jugadores
        /// Y la cantidad total de jugadores
        /// Asi realiza el porcentaje de los mismos
        /// </summary>
        /// <param name="cantidad"></param>
        /// <param name="cantidadTotal"></param>
        /// <returns> Retornara el porcentaje de la cantidad X de jugadores </returns>
        public int SacarPorcentaje(int cantidad, int cantidadTotal)
        {
            if(cantidadTotal == 0)
            {
                return 0;
            }

            return (cantidad * 100) / cantidadTotal;
        }

        /// <summary>
        /// Este metodo sacara el promedio de las edades de los jugadores
        /// Recibe una cantidad X de jugadores
        /// Y la cantidad total de jugadores
        /// Asi realizara el promedio de los mismos
        /// </summary>
        /// <param name="cantidad"></param>
        /// <param name="cantidadTotal"></param>
        /// <returns> Retornara el promedio de las edades </returns>
        public int SacarPromedio(int cantidad, int cantidadTotal)
        {
            if(cantidadTotal == 0)
            {
                return 0;
            }

            return cantidad / cantidadTotal;
        }

        /// <summary>
        /// Metodo que agrega los Agentes a una lista
        /// </summary>
        /// <returns> Retorna la lista de agentes </returns>
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

        #endregion

    }
}
