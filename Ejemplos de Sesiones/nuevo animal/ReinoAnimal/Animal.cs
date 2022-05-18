using System;

namespace ReinoAnimal
{
    /// <summary>
    /// Clase padre para todos las clases del Reino Animal.  Servirá como clase base para todas las clases que correspondan a un Animal. 
    /// Por ende, en esta clase se encontrarán todas los atributos en común en todos los animales.
    /// </summary>
    public abstract class Animal
    {
        /// <summary>
        /// Para nuestro ejemplo, todos los animales tienen una clasificación en específico.
        /// </summary>
        #region [ Propiedades ]
        public string Reino { get; set; }
        public string Filum { get; set; }
        public string Clase { get; set; }
        public string Orden { get; set; }
        public string Familia { get; set; }
        public string Genero { get; set; }
        public string Especie { get; set; }
        #endregion

        #region [ Constructor ]
        /// <summary>
        /// Constructor de la clase base para todos los seres vivos que pertenecen al Reino Animal.
        /// </summary>
        public Animal()
        {
            this.Reino = "Animalia";

            Console.WriteLine("Los animales pertenecen a uno de los 5 reinos de la naturaleza.");
        }
        #endregion

        /// <summary>
        /// Las acciones en común para todos los animales es comer, comunicarse entre ellos, desplazarse, reproducirse y respirar. 
        /// Para nuestro ejemplo, consideraremos estos metodos en común para todos los animales. Si encontramos otro comportamiento en común 
        /// para todos los animales, este sería el lugar indicado para agregarlo y que todas las subclases hereden este comportamiento.
        /// 
        /// Un ejemplo seria el Dormir.
        /// </summary>
        #region [ Metodos Abstractos ]
        public virtual void Alimentacion() { }
        public virtual void Comunicacion() { }
        public virtual void Movimiento() { }
        public virtual void Reproduccion() { }
        public virtual void Respiracion() { }
        #endregion
    }
}