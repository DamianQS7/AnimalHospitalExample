namespace AnimalHospital
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			lblAnimal = new Label();
			lblPetName = new Label();
			lblWeight = new Label();
			lblDOB = new Label();
			txtAnimal = new TextBox();
			txtPetName = new TextBox();
			txtWeight = new TextBox();
			dtpDOB = new DateTimePicker();
			lstRecords = new ListBox();
			lblRecords = new Label();
			btnNewRecord = new Button();
			btnReset = new Button();
			lblMessages = new Label();
			btnDelete = new Button();
			btnUpdate = new Button();
			SuspendLayout();
			// 
			// lblAnimal
			// 
			lblAnimal.AutoSize = true;
			lblAnimal.Location = new Point(12, 19);
			lblAnimal.Name = "lblAnimal";
			lblAnimal.Size = new Size(166, 20);
			lblAnimal.TabIndex = 0;
			lblAnimal.Text = "What kind of Animal is?";
			// 
			// lblPetName
			// 
			lblPetName.AutoSize = true;
			lblPetName.Location = new Point(12, 97);
			lblPetName.Name = "lblPetName";
			lblPetName.Size = new Size(82, 20);
			lblPetName.TabIndex = 1;
			lblPetName.Text = "Pet's Name";
			// 
			// lblWeight
			// 
			lblWeight.AutoSize = true;
			lblWeight.Location = new Point(12, 184);
			lblWeight.Name = "lblWeight";
			lblWeight.Size = new Size(88, 20);
			lblWeight.TabIndex = 2;
			lblWeight.Text = "Weight (Kg)";
			// 
			// lblDOB
			// 
			lblDOB.AutoSize = true;
			lblDOB.Location = new Point(12, 265);
			lblDOB.Name = "lblDOB";
			lblDOB.Size = new Size(94, 20);
			lblDOB.TabIndex = 3;
			lblDOB.Text = "Date of Birth";
			// 
			// txtAnimal
			// 
			txtAnimal.Location = new Point(12, 42);
			txtAnimal.Name = "txtAnimal";
			txtAnimal.Size = new Size(250, 27);
			txtAnimal.TabIndex = 4;
			// 
			// txtPetName
			// 
			txtPetName.Location = new Point(12, 120);
			txtPetName.Name = "txtPetName";
			txtPetName.Size = new Size(250, 27);
			txtPetName.TabIndex = 5;
			// 
			// txtWeight
			// 
			txtWeight.Location = new Point(12, 207);
			txtWeight.Name = "txtWeight";
			txtWeight.Size = new Size(250, 27);
			txtWeight.TabIndex = 6;
			// 
			// dtpDOB
			// 
			dtpDOB.Location = new Point(12, 288);
			dtpDOB.Name = "dtpDOB";
			dtpDOB.Size = new Size(250, 27);
			dtpDOB.TabIndex = 7;
			// 
			// lstRecords
			// 
			lstRecords.FormattingEnabled = true;
			lstRecords.ItemHeight = 20;
			lstRecords.Location = new Point(427, 42);
			lstRecords.Name = "lstRecords";
			lstRecords.Size = new Size(393, 164);
			lstRecords.TabIndex = 8;
			lstRecords.SelectedIndexChanged += lstRecords_SelectedIndexChanged;
			// 
			// lblRecords
			// 
			lblRecords.AutoSize = true;
			lblRecords.Location = new Point(427, 19);
			lblRecords.Name = "lblRecords";
			lblRecords.Size = new Size(65, 20);
			lblRecords.TabIndex = 9;
			lblRecords.Text = "Records:";
			// 
			// btnNewRecord
			// 
			btnNewRecord.Location = new Point(427, 238);
			btnNewRecord.Name = "btnNewRecord";
			btnNewRecord.Size = new Size(171, 29);
			btnNewRecord.TabIndex = 10;
			btnNewRecord.Text = "Create New Record";
			btnNewRecord.UseVisualStyleBackColor = true;
			btnNewRecord.Click += btnNewRecord_Click;
			// 
			// btnReset
			// 
			btnReset.Location = new Point(644, 238);
			btnReset.Name = "btnReset";
			btnReset.Size = new Size(160, 29);
			btnReset.TabIndex = 11;
			btnReset.Text = "Reset";
			btnReset.UseVisualStyleBackColor = true;
			btnReset.Click += btnReset_Click;
			// 
			// lblMessages
			// 
			lblMessages.AutoSize = true;
			lblMessages.Location = new Point(12, 350);
			lblMessages.Name = "lblMessages";
			lblMessages.Size = new Size(0, 20);
			lblMessages.TabIndex = 12;
			// 
			// btnDelete
			// 
			btnDelete.Location = new Point(427, 286);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(171, 29);
			btnDelete.TabIndex = 13;
			btnDelete.Text = "Delete Record";
			btnDelete.UseVisualStyleBackColor = true;
			btnDelete.Click += btnDelete_Click;
			// 
			// btnUpdate
			// 
			btnUpdate.Location = new Point(644, 286);
			btnUpdate.Name = "btnUpdate";
			btnUpdate.Size = new Size(160, 29);
			btnUpdate.TabIndex = 14;
			btnUpdate.Text = "Update Record";
			btnUpdate.UseVisualStyleBackColor = true;
			btnUpdate.Click += btnUpdate_Click;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(862, 506);
			Controls.Add(btnUpdate);
			Controls.Add(btnDelete);
			Controls.Add(lblMessages);
			Controls.Add(btnReset);
			Controls.Add(btnNewRecord);
			Controls.Add(lblRecords);
			Controls.Add(lstRecords);
			Controls.Add(dtpDOB);
			Controls.Add(txtWeight);
			Controls.Add(txtPetName);
			Controls.Add(txtAnimal);
			Controls.Add(lblDOB);
			Controls.Add(lblWeight);
			Controls.Add(lblPetName);
			Controls.Add(lblAnimal);
			Name = "MainForm";
			Text = "Animal Hospital";
			Load += MainForm_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblAnimal;
		private Label lblPetName;
		private Label lblWeight;
		private Label lblDOB;
		private TextBox txtAnimal;
		private TextBox txtPetName;
		private TextBox txtWeight;
		private DateTimePicker dtpDOB;
		private ListBox lstRecords;
		private Label lblRecords;
		private Button btnNewRecord;
		private Button btnReset;
		private Label lblMessages;
		private Button btnDelete;
		private Button btnUpdate;
	}
}