

using AnimalHospClassLibrary;

namespace AnimalHospital
{
	public partial class MainForm : Form
	{
		private RecordsManager _recordsManager;

		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			_recordsManager = new RecordsManager();
			_recordsManager.ReadItemsFromFile();
			UpdateListBox();
		}

		private void lstRecords_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(lstRecords.SelectedIndex != -1)
			{
				Pet? pet = (Pet)lstRecords.SelectedItem;

				txtAnimal.Text = pet.AnimalType;
				txtPetName.Text = pet.Name;
				txtWeight.Text = pet.Weight.ToString();
				dtpDOB.Value = pet.DateOfBirth;
			}
			
		}

		private void btnNewRecord_Click(object sender, EventArgs e)
		{
			// Adding some variables required to work
			bool validationFlag = true;
			string errors = "";

			// Get the user input
			string animal = txtAnimal.Text.Trim();
			string name = txtPetName.Text.Trim();
			string weightStr = txtWeight.Text.Trim();
			double weight = 0;
			DateTime dob = dtpDOB.Value;

			// Validate it
			ValidationHelper.ValidateName(name, ref errors, ref validationFlag);
			ValidationHelper.ValidateAnimal(animal, ref errors, ref validationFlag);
			ValidationHelper.ValidateWeight(weightStr, ref errors, ref validationFlag, ref weight);
			ValidationHelper.ValidateDOB(dob, ref errors, ref validationFlag);

			// If validation is successful, create a new Pet object and add it to the list
			if (validationFlag)
			{
				try
				{
					// Create a new Pet object
					int newId = _recordsManager.GetNextPetRecordId();

					Pet pet = new Pet(newId, animal, name, weight, dob);
					// Add it to the list
					_recordsManager.AddPet(pet);
					// Add it to the file
					_recordsManager.WriteRecordsToFile();

					// Clear the form
					ResetForm();

					// Update the ListBox
					UpdateListBox();

					// Display a success message
					SuccessMessage("Pet added successfully");
				}
				catch(ArgumentException ex)
				{
					ErrorMessage(ex.Message);
				}
				
			}
			else
			{
				// Display the error message
				ErrorMessage(errors);
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			// Check if the user has selected a record from the ListBox
			int selectedIndex = lstRecords.SelectedIndex;

			if (selectedIndex != -1)
			{
				// If a record is selected, we retrieve the Pet object from the list and remove it.
				Pet petToBeRemoved = (Pet)lstRecords.Items[selectedIndex];

				// We use the pet object to remove the record from the Manager List 
				_recordsManager.RemovePet(petToBeRemoved);

				// We rewrite the file, using the updated list
				_recordsManager.WriteRecordsToFile();

				// We update the ListBox using the updated list
				UpdateListBox();

				SuccessMessage("Record successfully deleted");
			}
			else
			{
				ErrorMessage("Select a record from the list first");
			}
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			ResetForm();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			// Check if the user has selected a record from the ListBox
			int selectedIndex = lstRecords.SelectedIndex;

			if (selectedIndex != -1)
			{
				// Adding some variables required to work
				bool validationFlag = true;
				string errors = "";

				// Get the user input
				string animal = txtAnimal.Text.Trim();
				string name = txtPetName.Text.Trim();
				string weightStr = txtWeight.Text.Trim();
				double weight = 0;
				DateTime dob = dtpDOB.Value;

				// Validate it
				ValidationHelper.ValidateName(name, ref errors, ref validationFlag);
				ValidationHelper.ValidateAnimal(animal, ref errors, ref validationFlag);
				ValidationHelper.ValidateWeight(weightStr, ref errors, ref validationFlag, ref weight);
				ValidationHelper.ValidateDOB(dob, ref errors, ref validationFlag);

				// If validation is successful, create a new Pet object and add it to the list
				if (validationFlag)
				{
					// If a record is selected, we need the Id of the pet object to find it in the list
					Pet pet = (Pet)lstRecords.Items[selectedIndex];
					int petId = pet.Id;

					// Update the pet object with the new values
					_recordsManager.UpdatePetById(petId, animal, name, weight, dob);

					// Update the file
					_recordsManager.WriteRecordsToFile();

					// Clear the form
					ResetForm();

					// Update the ListBox
					UpdateListBox();

					// Display a success message
					SuccessMessage("Pet updated successfully");
				}
				else
				{
					// Display the error message
					ErrorMessage(errors);
				}
			}
			else
			{
				ErrorMessage("Select a record from the list first");
			}

		}

		#region Helper Methods
		public void UpdateListBox()
		{
			lstRecords.Items.Clear();

			var pets = _recordsManager.GetAllPets();

			foreach (Pet pet in pets)
			{
				lstRecords.Items.Add(pet);
			}
		}

		public void ResetForm()
		{
			txtAnimal.Text = "";
			txtPetName.Text = "";
			txtWeight.Text = "";
			dtpDOB.Value = DateTime.Now;
			lblMessages.Text = "";
			lstRecords.SelectedIndex = -1;
		}

		public void ErrorMessage(string message)
		{
			lblMessages.ForeColor = Color.Red;
			lblMessages.Text = message;
		}

		public void SuccessMessage(string message)
		{
			lblMessages.ForeColor = Color.Green;
			lblMessages.Text = message;
		}
		#endregion

	}
}