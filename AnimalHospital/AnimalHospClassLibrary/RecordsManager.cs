using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHospClassLibrary
{
	public class RecordsManager : IRecordManager
	{
		public RecordsManager() 
		{ 
			if(!File.Exists(_fileName))
				File.Create(_fileName).Dispose();
		}

		public int GetNextPetRecordId()
		{
			if (_petRecords.Count == 0)
				return 1;
			else
			{
				Pet? nextAvailableId = _petRecords.MaxBy(a => a.Id);
				return nextAvailableId.Id + 1;
			}
		}

		public Pet? GetPetById(int id)
		{
			return _petRecords.FirstOrDefault(p => p.Id == id);
		}

		public void AddPet(Pet pet)
		{
			_petRecords.Add(pet);
		}

		public void RemovePet(Pet pet)
		{
			_petRecords.Remove(pet);
		}

		public void UpdatePetById(int id, string animal, string name, double weight, DateTime dob)
		{
			Pet petToBeUpdated = _petRecords.Find(p => p.Id == id);

			petToBeUpdated.AnimalType = animal;
			petToBeUpdated.Name = name;
			petToBeUpdated.Weight = weight;
			petToBeUpdated.DateOfBirth = dob;
		}

		public List<Pet> GetAllPets()
		{
			return _petRecords;
		}

		public string CreatePetRecord(Pet pet)
		{
			return $"{pet.Id}|{pet.AnimalType}|{pet.Name}|{pet.Weight}|{pet.DateOfBirth}";
		}

		public void WriteRecordsToFile()
		{
			using (StreamWriter writer = new StreamWriter(_fileName))
			{
				foreach (var pet in _petRecords)
				{
					writer.WriteLine(CreatePetRecord(pet));
				}
			}
		}

		public Pet? ParsePetFromFile(string recordsInFile)
		{
			string[] recordComponents = recordsInFile.Split('|');

			int id = int.Parse(recordComponents[0]);
			string animal = recordComponents[1];
			string name = recordComponents[2];
			double weight = double.Parse(recordComponents[3]);
			DateTime dob = DateTime.Parse(recordComponents[4]);

			Pet pet = new Pet(id, animal, name, weight, dob);

			return pet;
		}

		public void ReadItemsFromFile()
		{
			_petRecords.Clear();

			using (StreamReader reader = new StreamReader(_fileName))
			{
				while (!reader.EndOfStream)
				{
					string? petRecord = reader.ReadLine();
					if (petRecord != null)
					{
						Pet pet = ParsePetFromFile(petRecord);
						_petRecords.Add(pet);
					}
				}
			}
		}

		private List<Pet> _petRecords = new List<Pet>();
		private string _fileName = @"AnimalHospRecords.txt";
	}
}
