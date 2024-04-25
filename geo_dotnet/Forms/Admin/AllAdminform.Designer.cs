namespace geo_dotnet.Forms.Admin
{
	partial class AllAdminform
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
			this.label1 = new System.Windows.Forms.Label();
			this.btn_Profiles = new System.Windows.Forms.Button();
			this.btn_Projects = new System.Windows.Forms.Button();
			this.dgv_Measurements = new System.Windows.Forms.DataGridView();
			this.dgv_Pickets = new System.Windows.Forms.DataGridView();
			this.dgv_Profiles = new System.Windows.Forms.DataGridView();
			this.dgv_Areas = new System.Windows.Forms.DataGridView();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.lbl_proId = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgv_Measurements)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv_Pickets)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv_Profiles)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv_Areas)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(-222, -29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(419, 13);
			this.label1.TabIndex = 54;
			this.label1.Text = "Надо сделать, чтобы высыечивались проекты только, относящиеся к заказчику";
			// 
			// btn_Profiles
			// 
			this.btn_Profiles.Location = new System.Drawing.Point(-222, 241);
			this.btn_Profiles.Name = "btn_Profiles";
			this.btn_Profiles.Size = new System.Drawing.Size(75, 23);
			this.btn_Profiles.TabIndex = 51;
			this.btn_Profiles.Text = "Профили";
			this.btn_Profiles.UseVisualStyleBackColor = true;
			// 
			// btn_Projects
			// 
			this.btn_Projects.Location = new System.Drawing.Point(-72, -16);
			this.btn_Projects.Name = "btn_Projects";
			this.btn_Projects.Size = new System.Drawing.Size(75, 23);
			this.btn_Projects.TabIndex = 49;
			this.btn_Projects.Text = "Проекты";
			this.btn_Projects.UseVisualStyleBackColor = true;
			// 
			// dgv_Measurements
			// 
			this.dgv_Measurements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_Measurements.Location = new System.Drawing.Point(375, 330);
			this.dgv_Measurements.Name = "dgv_Measurements";
			this.dgv_Measurements.Size = new System.Drawing.Size(545, 209);
			this.dgv_Measurements.TabIndex = 48;
			this.dgv_Measurements.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Measurements_CellClick);
			// 
			// dgv_Pickets
			// 
			this.dgv_Pickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_Pickets.Location = new System.Drawing.Point(15, 330);
			this.dgv_Pickets.Name = "dgv_Pickets";
			this.dgv_Pickets.Size = new System.Drawing.Size(344, 209);
			this.dgv_Pickets.TabIndex = 47;
			this.dgv_Pickets.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Pickets_CellClick);
			// 
			// dgv_Profiles
			// 
			this.dgv_Profiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_Profiles.Location = new System.Drawing.Point(477, 63);
			this.dgv_Profiles.Name = "dgv_Profiles";
			this.dgv_Profiles.Size = new System.Drawing.Size(443, 215);
			this.dgv_Profiles.TabIndex = 46;
			this.dgv_Profiles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Profiles_CellClick);
			// 
			// dgv_Areas
			// 
			this.dgv_Areas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_Areas.Location = new System.Drawing.Point(15, 63);
			this.dgv_Areas.Name = "dgv_Areas";
			this.dgv_Areas.Size = new System.Drawing.Size(446, 215);
			this.dgv_Areas.TabIndex = 45;
			this.dgv_Areas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Areas_CellClick);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 47);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 13);
			this.label2.TabIndex = 55;
			this.label2.Text = "Площади";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(372, 314);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(65, 13);
			this.label3.TabIndex = 56;
			this.label3.Text = "Измерения";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 314);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(46, 13);
			this.label4.TabIndex = 57;
			this.label4.Text = "Пикеты";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(474, 47);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(53, 13);
			this.label5.TabIndex = 58;
			this.label5.Text = "Профили";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(30, 9);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(216, 25);
			this.label6.TabIndex = 59;
			this.label6.Text = "Детали проекта №";
			// 
			// lbl_proId
			// 
			this.lbl_proId.AutoSize = true;
			this.lbl_proId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbl_proId.Location = new System.Drawing.Point(242, 9);
			this.lbl_proId.Name = "lbl_proId";
			this.lbl_proId.Size = new System.Drawing.Size(31, 25);
			this.lbl_proId.TabIndex = 60;
			this.lbl_proId.Text = "Id";
			// 
			// AllAdminform
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(936, 559);
			this.Controls.Add(this.lbl_proId);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btn_Profiles);
			this.Controls.Add(this.btn_Projects);
			this.Controls.Add(this.dgv_Measurements);
			this.Controls.Add(this.dgv_Pickets);
			this.Controls.Add(this.dgv_Profiles);
			this.Controls.Add(this.dgv_Areas);
			this.Name = "AllAdminform";
			this.Text = "AllAdminform";
			this.Load += new System.EventHandler(this.AllAdminform_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgv_Measurements)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv_Pickets)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv_Profiles)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv_Areas)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btn_Profiles;
		private System.Windows.Forms.Button btn_Projects;
		private System.Windows.Forms.DataGridView dgv_Measurements;
		private System.Windows.Forms.DataGridView dgv_Pickets;
		private System.Windows.Forms.DataGridView dgv_Profiles;
		private System.Windows.Forms.DataGridView dgv_Areas;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label lbl_proId;
	}
}