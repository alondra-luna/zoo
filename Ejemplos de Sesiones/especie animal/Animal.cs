using System;
					
namespace Kind_Of_Animals
{
	public class Animal
	{ 
		string species; //Especie 
		string onomatopoeia; //Onomatopeyas de animales
		float minimum_size; //Tamaño mínimo 
		float maximum_size; //Tamaño máximo 
		string subgroup;    //Según su tipo de cuerpo
		string formWalk;    //Según su tipo de caminado
		
		public void SetformWalk(string set_species)
		{
		   this.formWalk=set_species; 
		}

		public string GetformWalk()
		{
		   return this.formWalk; 
		}	
		public void Set_species(string set_species)
		{
		   this.species=set_species; 
		}

		public void Set_onomatopoeia(string set_onomatopoeia)
		{
		   this.species=set_onomatopoeia; 
		}	

		public void Set_minimum_size(float set_minimum_size)
		{
			if (set_minimum_size > 0)
			{
				this.minimum_size = set_minimum_size; 
			}
			else
			{
				Console.WriteLine("Valor incorrecto para el tamaño minimo");
			}
		   
		}	

		public void Set_maximum_size(string set_maximum_size)
		{
		   this.species=set_maximum_size; 
		}	

		public void Set_subgroup(string set_subgroup)
		{
		   this.species=set_subgroup; 
		}	

		public string Get_species()
		{
			return this.species;
		}

		public string Get_onomatopoeia()
		{
			return this.onomatopoeia;
		}

		public float Get_minimum_size()
		{
			return this.minimum_size;
		}	

		public float Get_maximum_size()
		{
			return this.maximum_size;
		}

		public string Get_subgroup()
		{
			return this.subgroup;
		}

		public void SetNewAnimal(string Nspecies, string Nonomatopoeia, float Nminimum_size, float Nmaximum_size, string Nsubgroup, string formWalkd)
		{
		   	this.species=Nspecies; 
		   	this.onomatopoeia=Nonomatopoeia;
		   	this.minimum_size=Nminimum_size;
		   	this.maximum_size=Nmaximum_size;
		   	this.subgroup=Nsubgroup;
			this.formWalk=formWalkd;	
		}
		
		public void GetDataAnimal()
		{
			Console.WriteLine(":::::DATOS ANIMAL::::::");
			Console.WriteLine("Especie: " + this.species);
			Console.WriteLine("Sonido: " + this.onomatopoeia);
			Console.WriteLine("Minimo tamaño: " + this.minimum_size);
			Console.WriteLine("Maximo tamaño: " + this.maximum_size);
			Console.WriteLine("Clasificacion: " + this.subgroup);
			Console.WriteLine("Forma de caminar: " + this.formWalk);
		}
		
	}
}    