using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHospClassLibrary
{
	public static class ValidationHelper
	{

		// The validation requirement for the animal type is to contain only characters (not numbers or punct)
		public static void ValidateAnimal(string animal, ref string error, ref bool validationFlag)
		{

			if (string.IsNullOrEmpty(animal))
			{
				validationFlag = false;
				error += "Animal type is required\n";
			}
			else
			{
				foreach (char c in animal)
				{
					if (char.IsNumber(c) || char.IsPunctuation(c))
					{
						validationFlag = false;
						error += "Can't contain digits or punctuation characters, only letters\n";
						break;
					}
				}
			}
		}

		// The validation requirement for the name is to be at least 2 characters long
		public static void ValidateName(string name, ref string error, ref bool validationFlag)
		{
			if (string.IsNullOrEmpty(name))
			{
				validationFlag = false;
				error += "Pet's name is required\n";
			}
			else
			{
				if (name.Length < 2)
				{
					validationFlag = false;
					error += "Must be at least two characters long\n";
				}
			}
		}

		// The validation requirement for the weight is to be a number and it is required.
		public static void ValidateWeight(string weightStr, ref string error, ref bool validationFlag, ref double weight)
		{
			if (string.IsNullOrEmpty(weightStr))
			{
				validationFlag = false;
				error += "Weight is required\n";
			}
			else
			{
				if (!double.TryParse(weightStr, out weight))
				{
					error += "Please enter a number for the pet's weight. \n";
					validationFlag = false;
				}

			}
		}

		// The validation requirement for the date of birth is that it can't be a future date.
		public static void ValidateDOB(DateTime dob, ref string error, ref bool validationFlag)
		{
			if (dob >= DateTime.Now)
			{
				error += "Date of birth can't be a future date. \n";
				validationFlag = false;
			}
		}

	}
}
