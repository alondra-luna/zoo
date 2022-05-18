using System;

namespace ReinoAnimal
{
    public class Anfibios:Vertebrado
    {
        #region [ Propiedades ]
        #endregion

        #region [ Constructor ]
        public Anfibios()
        {
            this.Clase = "Amphibia";

            Console.WriteLine("Mi temperatura corporal es variable, es decir, soy de sangre fría.");
        }
        #endregion

        #region [ Metodos ]
        public override void Comunicacion()
        {
            Console.WriteLine("Ribit! Ribbit!");
        }

        public override void Reproduccion()
        {
            Console.WriteLine("Somos ovíparos que nos reproducimos por huevos");
        }

        public override void Respiracion()
        {
            Console.WriteLine("La respiración se realiza por branquias (externas o internas) durante la fase larvaria, pero al llegar a la edad adulta aquéllas suelen sustituirse por unos pulmones muy rudimentarios, ya que la mayor parte del proceso respiratorio se efectúa a través de la piel");
        }
        #endregion
    }
}