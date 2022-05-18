using System;

namespace ReinoAnimal
{
    /// <summary>
    /// Subclase de Vertebrado y que heredara los atributos tanto de Vertebrado como de Animal.
    /// 
    /// En esta clase tendremos las caracteristicas de un mamifero.
    /// </summary>
    public class Mamiferos : Vertebrado
    {
        #region [ Propiedades ]        
        public string Piel { get; set; }
        public int Extremedidades { get; set; }
        #endregion

        #region [ Constructor ]
        public Mamiferos()
            : base()
        {
            this.Clase = "Mammalia";

            Console.WriteLine("Debido a que soy un mamífero mi temperatura corporal es constante, es decir, soy de sangre caliente");
        }
        #endregion

        #region [ Metodos ]
        public override void Respiracion()
        {
            Console.WriteLine("Respiro por medio de mis pulmones");
        }

        public override void Reproduccion()
        {
            Console.WriteLine("La mayoría somos vivíparos");
        }
        #endregion

    }
}