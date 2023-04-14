using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHospClassLibrary
{
	// This is a good example if we only store information in lists within the app.
	public class RecordManager
	{
		#region Constructors
		public RecordManager()
		{
			// Create a new list of Pet objects
			PetRecords = new List<Pet>();
		}
		#endregion

		#region Properties

		public List<Pet> PetRecords { get; set; }

		#endregion

		#region Methods

		public void AddPet(Pet pet)
		{
			PetRecords.Add(pet);
		}

		public void RemovePet(Pet pet)
		{
			PetRecords.Remove(pet);
		}

		public void RemovePet(int index)
		{
			PetRecords.RemoveAt(index);
		}

		public void RemovePet(string name)
		{
			// Find the pet with the given name
			Pet pet = PetRecords.Find(p => p.Name == name);

			try
			{
				// Remove the pet from the list
				PetRecords.Remove(pet);
			}
			catch(ArgumentNullException ex)
			{
				throw new Exception(ex.Message);
			}
			catch (Exception ex)
			{
				throw new Exception("Something unexpected occured. Try again later");
			}
		}

		public Pet GetPet(int index)
		{
			return PetRecords[index];
		}

		public Pet GetPet(string name)
		{
			// Find the pet with the given name
			Pet pet = PetRecords.Find(p => p.Name == name);
			return pet;
		}

		public List<Pet> GetPets()
		{
			return PetRecords;
		}

		public List<Pet> GetPets(string animalType)
		{
			// Find all pets with the given animal type
			List<Pet> pets = PetRecords.FindAll(p => p.AnimalType == animalType);
			return pets;
		}
		public List<Pet> GetPets(int weight)
		{
			// Find all pets with the given weight
			List<Pet> pets = PetRecords.FindAll(p => p.Weight == weight);
			return pets;
		}
		public List<Pet> GetPets(DateTime dateOfBirth)
		{
			// Find all pets with the given date of birth
			List<Pet> pets = PetRecords.FindAll(p => p.DateOfBirth == dateOfBirth);
			return pets;
		}
		public List<Pet> GetPets(string animalType, int weight)
		{
			// Find all pets with the given animal type and weight
			List<Pet> pets = PetRecords.FindAll(p => p.AnimalType == animalType && p.Weight == weight);
			return pets;
		}

		#endregion
	}
}
