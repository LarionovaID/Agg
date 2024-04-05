namespace geo.Forms
{
	partial class AdminModelForm
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
			dataGridView1 = new DataGridView();
			btn_Save = new Button();
			btn_Delete = new Button();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(12, 120);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.Size = new Size(776, 318);
			dataGridView1.TabIndex = 1;
			// 
			// btn_Save
			// 
			btn_Save.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
			btn_Save.Location = new Point(12, 78);
			btn_Save.Name = "btn_Save";
			btn_Save.Size = new Size(98, 36);
			btn_Save.TabIndex = 2;
			btn_Save.Text = "Сохранить";
			btn_Save.UseVisualStyleBackColor = true;
			// 
			// btn_Delete
			// 
			btn_Delete.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
			btn_Delete.Location = new Point(690, 78);
			btn_Delete.Name = "btn_Delete";
			btn_Delete.Size = new Size(98, 36);
			btn_Delete.TabIndex = 3;
			btn_Delete.Text = "Удалить";
			btn_Delete.UseVisualStyleBackColor = true;
			// 
			// AdminModelForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(btn_Delete);
			Controls.Add(btn_Save);
			Controls.Add(dataGridView1);
			Controls.Add(header1);
			Name = "AdminModelForm";
			Text = "AdminModelForm";
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Controls.Header header1;
		private DataGridView dataGridView1;
		private Button btn_Save;
		private Button btn_Delete;
	}
}