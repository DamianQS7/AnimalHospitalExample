using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHospClassLibrary
{
	public class Pet
	{
		#region Constructors
		/*What is a constructor?
		A constructor is a special method that is used to initialize an object of a class. 
		When you create an instance of a class using the "new" keyword, a constructor is called 
		automatically to set the initial values of the object's fields or properties.

		A constructor has the same name as the class and can have parameters, which are used to 
		pass values to initialize the object. The constructor can also include code that performs additional 
		initialization logic, such as setting default values or validating input.*/

		public Pet(int newId, string animalType, string name, double weight, DateTime dateOfBirth)
		{
			Id = newId;
			AnimalType = animalType;
			Name = name;
			Weight = weight;
			DateOfBirth = dateOfBirth;
		}
		#endregion

		#region Properties
		public int Id { get; set; }
		public string AnimalType { get; set; }
		public string Name { get; set; }
		public double Weight
		{
			get
			{
				return Weight;
			}
			set
			{
				if(value < 0 || value > 50)
				{
					throw new ArgumentException("The pet's weight must be a value between 0 and 50");
				}
			}
		}
		public DateTime DateOfBirth { get; set; }
		#endregion

		#region Methods

		// We override the ToString method to get a string representation of the object
		public override string ToString()
		{
			return $"{Name}, the {AnimalType}";
		}

		#endregion
	}
}
