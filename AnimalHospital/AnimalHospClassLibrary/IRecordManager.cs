using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHospClassLibrary
{
	public interface IRecordManager
	{
		Pet? GetPetById(int id);

		void AddPet(Pet pet);

		void RemovePet(Pet pet);

		void UpdatePetById(int id, string animal, string name, double weight, DateTime dob);

		List<Pet> GetAllPets();

		string CreatePetRecord(Pet pet);

		void WriteRecordsToFile();

		Pet? ParsePetFromFile(string recordsInFile);

		void ReadItemsFromFile();
	}
}
