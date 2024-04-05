namespace geo.Controls
{
	partial class Header
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
			cb = new ComboBox();
			btn_Profile = new Button();
			SuspendLayout();
			// 
			// cb
			// 
			cb.FormattingEnabled = true;
			cb.Location = new Point(14, 23);
			cb.Name = "cb";
			cb.Size = new Size(259, 23);
			cb.TabIndex = 0;
			// 
			// btn_Profile
			// 
			btn_Profile.Location = new Point(680, 23);
			btn_Profile.Name = "btn_Profile";
			btn_Profile.Size = new Size(88, 23);
			btn_Profile.TabIndex = 1;
			btn_Profile.Text = "Профиль";
			btn_Profile.UseVisualStyleBackColor = true;
			// 
			// Header
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.DarkSlateGray;
			Controls.Add(btn_Profile);
			Controls.Add(cb);
			Name = "Header";
			Size = new Size(800, 61);
			ResumeLayout(false);
		}

		#endregion

		private ComboBox cb;
		private Button btn_Profile;
	}
}
