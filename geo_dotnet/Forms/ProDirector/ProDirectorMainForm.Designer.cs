namespace geo_dotnet.Forms.Admin
{
	partial class ProDirectorMainForm
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
			this.btn_Measurements = new System.Windows.Forms.Button();
			this.btn_Pickets = new System.Windows.Forms.Button();
			this.btn_Profiles = new System.Windows.Forms.Button();
			this.btn_Areas = new System.Windows.Forms.Button();
			this.btn_Projects = new System.Windows.Forms.Button();
			this.dgv_Measurements = new System.Windows.Forms.DataGridView();
			this.dgv_Pickets = new System.Windows.Forms.DataGridView();
			this.dgv_Profiles = new System.Windows.Forms.DataGridView();
			this.dgv_Areas = new System.Windows.Forms.DataGridView();
			this.dgv_Projects = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgv_Measurements)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv_Pickets)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv_Profiles)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv_Areas)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv_Projects)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(18, 97);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(118, 58);
			this.label1.TabIndex = 54;
			this.label1.Text = "Все \r\nпроекты";
			// 
			// btn_Measurements
			// 
			this.btn_Measurements.Location = new System.Drawing.Point(815, 275);
			this.btn_Measurements.Name = "btn_Measurements";
			this.btn_Measurements.Size = new System.Drawing.Size(113, 23);
			this.btn_Measurements.TabIndex = 53;
			this.btn_Measurements.Text = "Измерения";
			this.btn_Measurements.UseVisualStyleBackColor = true;
			// 
			// btn_Pickets
			// 
			this.btn_Pickets.Location = new System.Drawing.Point(465, 275);
			this.btn_Pickets.Name = "btn_Pickets";
			this.btn_Pickets.Size = new System.Drawing.Size(75, 23);
			this.btn_Pickets.TabIndex = 52;
			this.btn_Pickets.Text = "Пикеты";
			this.btn_Pickets.UseVisualStyleBackColor = true;
			// 
			// btn_Profiles
			// 
			this.btn_Profiles.Location = new System.Drawing.Point(16, 275);
			this.btn_Profiles.Name = "btn_Profiles";
			this.btn_Profiles.Size = new System.Drawing.Size(75, 23);
			this.btn_Profiles.TabIndex = 51;
			this.btn_Profiles.Text = "Профили";
			this.btn_Profiles.UseVisualStyleBackColor = true;
			// 
			// btn_Areas
			// 
			this.btn_Areas.Location = new System.Drawing.Point(815, 18);
			this.btn_Areas.Name = "btn_Areas";
			this.btn_Areas.Size = new System.Drawing.Size(104, 23);
			this.btn_Areas.TabIndex = 50;
			this.btn_Areas.Text = "Площади";
			this.btn_Areas.UseVisualStyleBackColor = true;
			// 
			// btn_Projects
			// 
			this.btn_Projects.Location = new System.Drawing.Point(166, 18);
			this.btn_Projects.Name = "btn_Projects";
			this.btn_Projects.Size = new System.Drawing.Size(75, 23);
			this.btn_Projects.TabIndex = 49;
			this.btn_Projects.Text = "Проекты";
			this.btn_Projects.UseVisualStyleBackColor = true;
			this.btn_Projects.Click += new System.EventHandler(this.btn_Projects_Click);
			// 
			// dgv_Measurements
			// 
			this.dgv_Measurements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_Measurements.Location = new System.Drawing.Point(815, 304);
			this.dgv_Measurements.Name = "dgv_Measurements";
			this.dgv_Measurements.Size = new System.Drawing.Size(446, 209);
			this.dgv_Measurements.TabIndex = 48;
			// 
			// dgv_Pickets
			// 
			this.dgv_Pickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_Pickets.Location = new System.Drawing.Point(465, 304);
			this.dgv_Pickets.Name = "dgv_Pickets";
			this.dgv_Pickets.Size = new System.Drawing.Size(344, 209);
			this.dgv_Pickets.TabIndex = 47;
			this.dgv_Pickets.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Pickets_CellClick_1);
			// 
			// dgv_Profiles
			// 
			this.dgv_Profiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_Profiles.Location = new System.Drawing.Point(16, 304);
			this.dgv_Profiles.Name = "dgv_Profiles";
			this.dgv_Profiles.Size = new System.Drawing.Size(443, 209);
			this.dgv_Profiles.TabIndex = 46;
			this.dgv_Profiles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Profiles_CellClick_1);
			// 
			// dgv_Areas
			// 
			this.dgv_Areas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_Areas.Location = new System.Drawing.Point(815, 44);
			this.dgv_Areas.Name = "dgv_Areas";
			this.dgv_Areas.Size = new System.Drawing.Size(446, 215);
			this.dgv_Areas.TabIndex = 45;
			this.dgv_Areas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Areas_CellClick_1);
			// 
			// dgv_Projects
			// 
			this.dgv_Projects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_Projects.Location = new System.Drawing.Point(166, 44);
			this.dgv_Projects.Name = "dgv_Projects";
			this.dgv_Projects.Size = new System.Drawing.Size(643, 215);
			this.dgv_Projects.TabIndex = 44;
			this.dgv_Projects.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Projects_CellClick_1);
			// 
			// ProDirectorMainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1276, 530);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btn_Measurements);
			this.Controls.Add(this.btn_Pickets);
			this.Controls.Add(this.btn_Profiles);
			this.Controls.Add(this.btn_Areas);
			this.Controls.Add(this.btn_Projects);
			this.Controls.Add(this.dgv_Measurements);
			this.Controls.Add(this.dgv_Pickets);
			this.Controls.Add(this.dgv_Profiles);
			this.Controls.Add(this.dgv_Areas);
			this.Controls.Add(this.dgv_Projects);
			this.Name = "ProDirectorMainForm";
			this.Text = "AllProgectsForm";
			this.Load += new System.EventHandler(this.ProDirectorMainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgv_Measurements)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv_Pickets)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv_Profiles)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv_Areas)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv_Projects)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btn_Measurements;
		private System.Windows.Forms.Button btn_Pickets;
		private System.Windows.Forms.Button btn_Profiles;
		private System.Windows.Forms.Button btn_Areas;
		private System.Windows.Forms.Button btn_Projects;
		private System.Windows.Forms.DataGridView dgv_Measurements;
		private System.Windows.Forms.DataGridView dgv_Pickets;
		private System.Windows.Forms.DataGridView dgv_Profiles;
		private System.Windows.Forms.DataGridView dgv_Areas;
		private System.Windows.Forms.DataGridView dgv_Projects;
	}
}