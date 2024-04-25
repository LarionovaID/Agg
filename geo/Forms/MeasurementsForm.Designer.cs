namespace geo.Forms
{
	partial class MeasurementsForm
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
			btn_Save = new Button();
			dataGridView1 = new DataGridView();
			header1 = new Controls.Header();
			label1 = new Label();
			comboBox1 = new ComboBox();
			tb_MeasData = new TextBox();
			label2 = new Label();
			lbl = new Label();
			dateTimePicker1 = new DateTimePicker();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// btn_Save
			// 
			btn_Save.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
			btn_Save.Location = new Point(690, 84);
			btn_Save.Name = "btn_Save";
			btn_Save.Size = new Size(98, 36);
			btn_Save.TabIndex = 6;
			btn_Save.Text = "Сохранить";
			btn_Save.UseVisualStyleBackColor = true;
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(322, 124);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.Size = new Size(466, 314);
			dataGridView1.TabIndex = 5;
			// 
			// header1
			// 
			header1.BackColor = Color.DarkSlateGray;
			header1.Location = new Point(0, 6);
			header1.Name = "header1";
			header1.Size = new Size(800, 61);
			header1.TabIndex = 4;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
			label1.Location = new Point(21, 109);
			label1.Name = "label1";
			label1.Size = new Size(107, 20);
			label1.TabIndex = 7;
			label1.Text = "Выбор пикета";
			// 
			// comboBox1
			// 
			comboBox1.FormattingEnabled = true;
			comboBox1.Location = new Point(21, 132);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(277, 23);
			comboBox1.TabIndex = 8;
			// 
			// tb_MeasData
			// 
			tb_MeasData.Location = new Point(21, 192);
			tb_MeasData.Multiline = true;
			tb_MeasData.Name = "tb_MeasData";
			tb_MeasData.Size = new Size(277, 179);
			tb_MeasData.TabIndex = 9;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
			label2.Location = new Point(21, 169);
			label2.Name = "label2";
			label2.Size = new Size(146, 20);
			label2.TabIndex = 11;
			label2.Text = "Данные измерения";
			// 
			// lbl
			// 
			lbl.AutoSize = true;
			lbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
			lbl.Location = new Point(21, 382);
			lbl.Name = "lbl";
			lbl.Size = new Size(41, 20);
			lbl.TabIndex = 12;
			lbl.Text = "Дата";
			// 
			// dateTimePicker1
			// 
			dateTimePicker1.Location = new Point(21, 405);
			dateTimePicker1.Name = "dateTimePicker1";
			dateTimePicker1.Size = new Size(277, 23);
			dateTimePicker1.TabIndex = 13;
			// 
			// MeasurementsForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(dateTimePicker1);
			Controls.Add(lbl);
			Controls.Add(label2);
			Controls.Add(tb_MeasData);
			Controls.Add(comboBox1);
			Controls.Add(label1);
			Controls.Add(btn_Save);
			Controls.Add(dataGridView1);
			Controls.Add(header1);
			Name = "MeasurementsForm";
			Text = "Measurements";
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Button btn_Save;
		private DataGridView dataGridView1;
		private Controls.Header header1;
		private Label label1;
		private ComboBox comboBox1;
		private TextBox tb_MeasData;
		private Label label2;
		private Label lbl;
		private DateTimePicker dateTimePicker1;
	}
}