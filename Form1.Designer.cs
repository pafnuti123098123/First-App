namespace Test_App
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.FN = new System.Windows.Forms.Label();
			this.box1 = new System.Windows.Forms.TextBox();
			this.box2 = new System.Windows.Forms.TextBox();
			this.SN = new System.Windows.Forms.Label();
			this.calculate = new System.Windows.Forms.Button();
			this.Result = new System.Windows.Forms.Label();
			this.Box3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// FN
			// 
			this.FN.AutoSize = true;
			this.FN.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.FN.Location = new System.Drawing.Point(70, 56);
			this.FN.Name = "FN";
			this.FN.Size = new System.Drawing.Size(162, 31);
			this.FN.TabIndex = 0;
			this.FN.Text = "First Number:";
			// 
			// box1
			// 
			this.box1.Location = new System.Drawing.Point(238, 60);
			this.box1.Name = "box1";
			this.box1.Size = new System.Drawing.Size(535, 27);
			this.box1.TabIndex = 1;
			// 
			// box2
			// 
			this.box2.Location = new System.Drawing.Point(238, 112);
			this.box2.Name = "box2";
			this.box2.Size = new System.Drawing.Size(535, 27);
			this.box2.TabIndex = 1;
			// 
			// SN
			// 
			this.SN.AutoSize = true;
			this.SN.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.SN.Location = new System.Drawing.Point(39, 108);
			this.SN.Name = "SN";
			this.SN.Size = new System.Drawing.Size(193, 31);
			this.SN.TabIndex = 0;
			this.SN.Text = "Second Number:";
			// 
			// calculate
			// 
			this.calculate.Location = new System.Drawing.Point(300, 215);
			this.calculate.Name = "calculate";
			this.calculate.Size = new System.Drawing.Size(184, 44);
			this.calculate.TabIndex = 2;
			this.calculate.Text = "Calculate";
			this.calculate.UseVisualStyleBackColor = true;
			this.calculate.Click += new System.EventHandler(this.calculate_Click);
			// 
			// Result
			// 
			this.Result.AutoSize = true;
			this.Result.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.Result.Location = new System.Drawing.Point(39, 337);
			this.Result.Name = "Result";
			this.Result.Size = new System.Drawing.Size(86, 31);
			this.Result.TabIndex = 0;
			this.Result.Text = "Result:";
			// 
			// Box3
			// 
			this.Box3.AutoSize = true;
			this.Box3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Box3.Location = new System.Drawing.Point(118, 337);
			this.Box3.Name = "Box3";
			this.Box3.Size = new System.Drawing.Size(20, 31);
			this.Box3.TabIndex = 3;
			this.Box3.Text = " ";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Menu;
			this.ClientSize = new System.Drawing.Size(826, 458);
			this.Controls.Add(this.Box3);
			this.Controls.Add(this.Result);
			this.Controls.Add(this.calculate);
			this.Controls.Add(this.SN);
			this.Controls.Add(this.box2);
			this.Controls.Add(this.box1);
			this.Controls.Add(this.FN);
			this.Name = "Form1";
			this.Text = "Mini Calculator";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label FN;
		private System.Windows.Forms.TextBox box1;
		private System.Windows.Forms.TextBox box2;
		private System.Windows.Forms.Label SN;
		private System.Windows.Forms.Button calculate;
		private System.Windows.Forms.Label Result;
		private System.Windows.Forms.Label Box3;
	}
}

