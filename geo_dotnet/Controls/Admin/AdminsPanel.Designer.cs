namespace geo_dotnet.Controls.Admin
{
	partial class AdminsPanel
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
			this.btn_Projects = new System.Windows.Forms.Button();
			this.btn_Users = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btn_Projects
			// 
			this.btn_Projects.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btn_Projects.Location = new System.Drawing.Point(246, 27);
			this.btn_Projects.Name = "btn_Projects";
			this.btn_Projects.Size = new System.Drawing.Size(98, 23);
			this.btn_Projects.TabIndex = 5;
			this.btn_Projects.Text = "Проекты";
			this.btn_Projects.UseVisualStyleBackColor = true;
			this.btn_Projects.Click += new System.EventHandler(this.btn_Projects_Click);
			// 
			// btn_Users
			// 
			this.btn_Users.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btn_Users.Location = new System.Drawing.Point(142, 27);
			this.btn_Users.Name = "btn_Users";
			this.btn_Users.Size = new System.Drawing.Size(98, 23);
			this.btn_Users.TabIndex = 4;
			this.btn_Users.Text = "Пользователи";
			this.btn_Users.UseVisualStyleBackColor = true;
			this.btn_Users.Click += new System.EventHandler(this.btn_Users_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label2.Location = new System.Drawing.Point(13, 21);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 35);
			this.label2.TabIndex = 7;
			this.label2.Text = "Admin";
			// 
			// UserControl1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkSlateGray;
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btn_Projects);
			this.Controls.Add(this.btn_Users);
			this.ForeColor = System.Drawing.SystemColors.Control;
			this.Name = "UserControl1";
			this.Size = new System.Drawing.Size(810, 72);
			this.Load += new System.EventHandler(this.UserControl1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_Projects;
		private System.Windows.Forms.Button btn_Users;
		private System.Windows.Forms.Label label2;
	}
}
