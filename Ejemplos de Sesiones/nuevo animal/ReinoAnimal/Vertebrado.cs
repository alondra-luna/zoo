using System;

namespace ReinoAnimal
{
    /// <summary>
    /// Subclase perteneciente a la clase padre Animal y la cual hereda los metodos y atributos definidos en esta.
    /// 
    /// Esta clase sería donde tendriamos todas las características de los animales vertebrados.
    /// </summary>
    public class Vertebrado : Animal
    {
        #region [ Propiedades ]
        /// <summary>
        /// Para nuestros ejemplo, lo que hace único a los vertebrados es que cuentan con un esqueleto.
        /// </summary>
        public string Esqueleto { get; set; }
        /// <summary>
        /// Numero de vertebras que conforman su columna vertebral.
        /// </summary>
        public int Vertebras { get; set; }
        /// <summary>
        /// Hay individuos machos e individuos hembras, es decir, el sexo está diferenciado.
        /// </summary>
        public string Sexo { get; set; }

        public tSangre tSangre { get; set; }
        public tRespiracion tRespiracion { get; set; }
        #endregion

        #region [ Constructor ]
        /// <summary>
        /// Constructor de la clase y que a su vez hereda el de su clase padre.
        /// </summary>
        public Vertebrado()
            : base()
        {
            this.Filum = "Chordata";
            Console.WriteLine("Debido a que soy un animal vertebrado poseo un esqueleto y una columna vertebral");
        }
        #endregion
    }
}