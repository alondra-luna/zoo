
public class Program

	{
		public static void Main()
		{
			/*
			Animal exampleAnimal = new Animal();
			exampleAnimal.SetNewAnimal("Cojo","Gnu Gnu gnu", 0.5f, 0.9f, "Mamifero","Cuadrupedo");
			exampleAnimal.GetDataAnimal();
			exampleAnimal.Set_species("Conejo");
			exampleAnimal.GetDataAnimal();
			*/
			Animal[] arrayAnimal = new Animal[5];
			for (int i = 0; i < 5 ; i++)
			{
				arrayAnimal[i] = new Animal();
			}
			arrayAnimal[0].SetNewAnimal("Pollito","Pio pio pio", 0.05f, 0.1f, "Ave","Bipedo");
			arrayAnimal[1].SetNewAnimal("Pez dorado","Glu glu glup", 0.01f, 0.08f, "Pez","Nada");
			arrayAnimal[2].SetNewAnimal("Caballo","Clap clap ñiiiehh", 1f, 2.5f, "Mamifero","Cuadrupedo");
			arrayAnimal[3].SetNewAnimal("Vaca","Muuuh muuhh", 1f, 1.8f, "Mamifero","Cuadrupedo");
			arrayAnimal[4].SetNewAnimal("Perro","gua gua guauu", 1f, 1.5f, "Mamifero","Cuadrupedo");
			/*
			for (int i = 0; i < 5 ; i++)
			{
				arrayAnimal[i].GetDataAnimal();
			}
			*/
			/*
			int contador = 0;
			for (int i = 0; i < 5 ; i++)
			{
				Console.WriteLine(arrayAnimal[i].Get_onomatopoeia());
				if (arrayAnimal[i].GetformWalk() == "Cuadrupedo")
				{
						contador = contador + 1 ;
				}
			}
			Console.WriteLine("Hay "+ contador + " cuadrupedos");
			*/
			arrayAnimal[0].Set_minimum_size(-1F);
			arrayAnimal[0].GetDataAnimal();
			

		}
	}
	

