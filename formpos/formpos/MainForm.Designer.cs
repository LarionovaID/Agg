namespace formpos
{
	partial class Form2
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			header1 = new Controls.Header();
			btn_Projects = new Button();
			btn_Employees = new Button();
			SuspendLayout();
			// 
			// header1
			// 
			header1.BackColor = Color.DarkSlateGray;
			header1.Location = new Point(0, 0);
			header1.Name = "header1";
			header1.Size = new Size(800, 61);
			header1.TabIndex = 0;
			// 
			// btn_Projects
			// 
			btn_Projects.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
			btn_Projects.Location = new Point(276, 118);
			btn_Projects.Name = "btn_Projects";
			btn_Projects.Size = new Size(243, 103);
			btn_Projects.TabIndex = 1;
			btn_Projects.Text = "Проекты";
			btn_Projects.UseVisualStyleBackColor = true;
			// 
			// btn_Employees
			// 
			btn_Employees.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
			btn_Employees.Location = new Point(276, 250);
			btn_Employees.Name = "btn_Employees";
			btn_Employees.Size = new Size(243, 103);
			btn_Employees.TabIndex = 2;
			btn_Employees.Text = "Сотрудники";
			btn_Employees.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(btn_Employees);
			Controls.Add(btn_Projects);
			Controls.Add(header1);
			Name = "MainForm";
			Text = "MainForm";
			ResumeLayout(false);
		}

		#endregion

		private Controls.Header header1;
		private Button btn_Projects;
		private Button btn_Employees;
	}
}