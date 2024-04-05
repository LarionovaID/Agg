namespace geo.Forms
{
	partial class ProjectForm
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
			label2 = new Label();
			comboBox1 = new ComboBox();
			label1 = new Label();
			btn_Save = new Button();
			dataGridView1 = new DataGridView();
			header1 = new Controls.Header();
			comboBox2 = new ComboBox();
			button1 = new Button();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
			label2.Location = new Point(12, 192);
			label2.Name = "label2";
			label2.Size = new Size(134, 20);
			label2.TabIndex = 20;
			label2.Text = "Площади проекта";
			label2.Click += label2_Click;
			// 
			// comboBox1
			// 
			comboBox1.FormattingEnabled = true;
			comboBox1.Location = new Point(12, 155);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(277, 23);
			comboBox1.TabIndex = 18;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
			label1.Location = new Point(12, 132);
			label1.Name = "label1";
			label1.Size = new Size(128, 20);
			label1.TabIndex = 17;
			label1.Text = "Список проектов";
			label1.Click += label1_Click;
			// 
			// btn_Save
			// 
			btn_Save.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
			btn_Save.Location = new Point(690, 87);
			btn_Save.Name = "btn_Save";
			btn_Save.Size = new Size(98, 36);
			btn_Save.TabIndex = 16;
			btn_Save.Text = "Сохранить";
			btn_Save.UseVisualStyleBackColor = true;
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(308, 127);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.Size = new Size(480, 314);
			dataGridView1.TabIndex = 15;
			// 
			// header1
			// 
			header1.BackColor = Color.DarkSlateGray;
			header1.Location = new Point(0, 9);
			header1.Name = "header1";
			header1.Size = new Size(800, 61);
			header1.TabIndex = 14;
			// 
			// comboBox2
			// 
			comboBox2.FormattingEnabled = true;
			comboBox2.Location = new Point(12, 215);
			comboBox2.Name = "comboBox2";
			comboBox2.Size = new Size(277, 23);
			comboBox2.TabIndex = 23;
			// 
			// button1
			// 
			button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
			button1.Location = new Point(12, 262);
			button1.Name = "button1";
			button1.Size = new Size(106, 38);
			button1.TabIndex = 24;
			button1.Text = "Измерения";
			button1.UseVisualStyleBackColor = true;
			// 
			// ProjectForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(button1);
			Controls.Add(comboBox2);
			Controls.Add(label2);
			Controls.Add(comboBox1);
			Controls.Add(label1);
			Controls.Add(btn_Save);
			Controls.Add(dataGridView1);
			Controls.Add(header1);
			Name = "ProjectForm";
			Text = "ProjectForm";
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Label label2;
		private ComboBox comboBox1;
		private Label label1;
		private Button btn_Save;
		private DataGridView dataGridView1;
		private Controls.Header header1;
		private ComboBox comboBox2;
		private Button button1;
	}
}