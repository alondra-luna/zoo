using System;

namespace ReinoAnimal
{
    /// <summary>
    /// Subclase de Vertebrado y que heredara los atributos tanto de Vertebrado como de Animal.
    /// 
    /// En esta clase tendremos las caracteristicas de las aves.
    /// </summary>
    public class Aves : Vertebrado
    {
        #region [ Propiedades ]
        public string Pico { get; set; }
        public string Alas { get; set; }
        #endregion

        #region [ Constructor ]
        /// <summary>
        /// Constructor para los objetos de tipo Aves
        /// </summary>
        public Aves()
            : base()
        {
            this.Clase = "Aves";

            Console.WriteLine("Debido a que soy un ave tengo mi cuerpo cubierto de plumas");
        }
        #endregion

        #region [ Metodos  ]
        public override void Alimentacion()
        {
            Console.WriteLine("Dependiendo de la especie, somos carnivoras, hervívoras, insectívoras u omnívoras");
        }
        public override void Comunicacion()
        {
            Console.WriteLine("El sonido que emitimos las aves es demonimado Trinar.");
        }
        public override void Movimiento()
        {
            Console.WriteLine("Me desplazo sobre la tierra con mis 2 patas y también puedo volar con mis alas");
        }
        public override void Reproduccion()
        {
            Console.WriteLine("Ovípara");
        }
        public override void Respiracion()
        {
            base.Respiracion();
        }
        #endregion
    }
}