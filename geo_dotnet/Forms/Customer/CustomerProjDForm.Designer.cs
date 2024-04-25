namespace geo_dotnet.Forms.Customer
{
	partial class CustomerProjDForm
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
			this.lbl_proId = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dgv_Measurements = new System.Windows.Forms.DataGridView();
			this.dgv_Pickets = new System.Windows.Forms.DataGridView();
			this.dgv_Profiles = new System.Windows.Forms.DataGridView();
			this.dgv_Areas = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgv_Measurements)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv_Pickets)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv_Profiles)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv_Areas)).BeginInit();
			this.SuspendLayout();
			// 
			// lbl_proId
			// 
			this.lbl_proId.AutoSize = true;
			this.lbl_proId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbl_proId.Location = new System.Drawing.Point(246, 15);
			this.lbl_proId.Name = "lbl_proId";
			this.lbl_proId.Size = new System.Drawing.Size(31, 25);
			this.lbl_proId.TabIndex = 70;
			this.lbl_proId.Text = "Id";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(34, 15);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(216, 25);
			this.label6.TabIndex = 69;
			this.label6.Text = "Детали проекта №";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(478, 53);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(53, 13);
			this.label5.TabIndex = 68;
			this.label5.Text = "Профили";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(16, 320);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(46, 13);
			this.label4.TabIndex = 67;
			this.label4.Text = "Пикеты";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(376, 320);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(65, 13);
			this.label3.TabIndex = 66;
			this.label3.Text = "Измерения";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(16, 53);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 13);
			this.label2.TabIndex = 65;
			this.label2.Text = "Площади";
			// 
			// dgv_Measurements
			// 
			this.dgv_Measurements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_Measurements.Location = new System.Drawing.Point(379, 336);
			this.dgv_Measurements.Name = "dgv_Measurements";
			this.dgv_Measurements.Size = new System.Drawing.Size(545, 209);
			this.dgv_Measurements.TabIndex = 64;
			this.dgv_Measurements.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Measurements_CellClick);
			// 
			// dgv_Pickets
			// 
			this.dgv_Pickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_Pickets.Location = new System.Drawing.Point(19, 336);
			this.dgv_Pickets.Name = "dgv_Pickets";
			this.dgv_Pickets.Size = new System.Drawing.Size(344, 209);
			this.dgv_Pickets.TabIndex = 63;
			this.dgv_Pickets.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Pickets_CellClick_1);
			// 
			// dgv_Profiles
			// 
			this.dgv_Profiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_Profiles.Location = new System.Drawing.Point(481, 69);
			this.dgv_Profiles.Name = "dgv_Profiles";
			this.dgv_Profiles.Size = new System.Drawing.Size(443, 215);
			this.dgv_Profiles.TabIndex = 62;
			this.dgv_Profiles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Profiles_CellClick_1);
			// 
			// dgv_Areas
			// 
			this.dgv_Areas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_Areas.Location = new System.Drawing.Point(19, 69);
			this.dgv_Areas.Name = "dgv_Areas";
			this.dgv_Areas.Size = new System.Drawing.Size(446, 215);
			this.dgv_Areas.TabIndex = 61;
			this.dgv_Areas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Areas_CellClick_1);
			// 
			// CustomerProjDForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(953, 566);
			this.Controls.Add(this.lbl_proId);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dgv_Measurements);
			this.Controls.Add(this.dgv_Pickets);
			this.Controls.Add(this.dgv_Profiles);
			this.Controls.Add(this.dgv_Areas);
			this.Name = "CustomerProjDForm";
			this.Text = "a";
			this.Load += new System.EventHandler(this.CustomerMainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgv_Measurements)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv_Pickets)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv_Profiles)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv_Areas)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbl_proId;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dgv_Measurements;
		private System.Windows.Forms.DataGridView dgv_Pickets;
		private System.Windows.Forms.DataGridView dgv_Profiles;
		private System.Windows.Forms.DataGridView dgv_Areas;
	}
}