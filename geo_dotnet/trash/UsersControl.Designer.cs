namespace geo_dotnet.Controls.Admin
{
	partial class UsersControl
	{
		/// <summary> 
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором компонентов

		/// <summary> 
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.btn_Admin = new System.Windows.Forms.Button();
			this.btn_Director = new System.Windows.Forms.Button();
			this.btn_Employee = new System.Windows.Forms.Button();
			this.btn_Customer = new System.Windows.Forms.Button();
			this.flp_Users = new System.Windows.Forms.FlowLayoutPanel();
			this.btn_Add = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btn_Admin
			// 
			this.btn_Admin.Location = new System.Drawing.Point(42, 30);
			this.btn_Admin.Name = "btn_Admin";
			this.btn_Admin.Size = new System.Drawing.Size(114, 30);
			this.btn_Admin.TabIndex = 0;
			this.btn_Admin.Text = "Администраторы";
			this.btn_Admin.UseVisualStyleBackColor = true;
			// 
			// btn_Director
			// 
			this.btn_Director.Location = new System.Drawing.Point(162, 30);
			this.btn_Director.Name = "btn_Director";
			this.btn_Director.Size = new System.Drawing.Size(167, 30);
			this.btn_Director.TabIndex = 1;
			this.btn_Director.Text = "Руководители проектов";
			this.btn_Director.UseVisualStyleBackColor = true;
			// 
			// btn_Employee
			// 
			this.btn_Employee.Location = new System.Drawing.Point(336, 30);
			this.btn_Employee.Name = "btn_Employee";
			this.btn_Employee.Size = new System.Drawing.Size(114, 30);
			this.btn_Employee.TabIndex = 2;
			this.btn_Employee.Text = "Работники";
			this.btn_Employee.UseVisualStyleBackColor = true;
			// 
			// btn_Customer
			// 
			this.btn_Customer.Location = new System.Drawing.Point(456, 30);
			this.btn_Customer.Name = "btn_Customer";
			this.btn_Customer.Size = new System.Drawing.Size(114, 30);
			this.btn_Customer.TabIndex = 3;
			this.btn_Customer.Text = "Заказчики";
			this.btn_Customer.UseVisualStyleBackColor = true;
			// 
			// flp_Users
			// 
			this.flp_Users.AutoScroll = true;
			this.flp_Users.Location = new System.Drawing.Point(30, 76);
			this.flp_Users.Name = "flp_Users";
			this.flp_Users.Size = new System.Drawing.Size(754, 299);
			this.flp_Users.TabIndex = 4;
			// 
			// btn_Add
			// 
			this.btn_Add.Location = new System.Drawing.Point(680, 30);
			this.btn_Add.Name = "btn_Add";
			this.btn_Add.Size = new System.Drawing.Size(83, 30);
			this.btn_Add.TabIndex = 5;
			this.btn_Add.Text = "Добавить";
			this.btn_Add.UseVisualStyleBackColor = true;
			this.btn_Add.Click += new System.EventHandler(this.button5_Click);
			// 
			// UsersControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.btn_Add);
			this.Controls.Add(this.flp_Users);
			this.Controls.Add(this.btn_Customer);
			this.Controls.Add(this.btn_Employee);
			this.Controls.Add(this.btn_Director);
			this.Controls.Add(this.btn_Admin);
			this.Name = "UsersControl";
			this.Size = new System.Drawing.Size(810, 397);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btn_Admin;
		private System.Windows.Forms.Button btn_Director;
		private System.Windows.Forms.Button btn_Employee;
		private System.Windows.Forms.Button btn_Customer;
		private System.Windows.Forms.FlowLayoutPanel flp_Users;
		private System.Windows.Forms.Button btn_Add;
	}
}
