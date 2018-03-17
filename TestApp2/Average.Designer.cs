namespace TestApp2
{
    partial class Average
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
            this.StartDZ = new System.Windows.Forms.Button();
            this.FinishDZ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartDZ
            // 
            this.StartDZ.Location = new System.Drawing.Point(32, 163);
            this.StartDZ.Name = "StartDZ";
            this.StartDZ.Size = new System.Drawing.Size(75, 23);
            this.StartDZ.TabIndex = 2;
            this.StartDZ.Text = "Запуск";
            this.StartDZ.UseVisualStyleBackColor = true;
            this.StartDZ.Click += new System.EventHandler(this.StartDZ_Click);
            // 
            // FinishDZ
            // 
            this.FinishDZ.Location = new System.Drawing.Point(192, 162);
            this.FinishDZ.Name = "FinishDZ";
            this.FinishDZ.Size = new System.Drawing.Size(75, 23);
            this.FinishDZ.TabIndex = 3;
            this.FinishDZ.Text = "Выход";
            this.FinishDZ.UseVisualStyleBackColor = true;
            this.FinishDZ.Click += new System.EventHandler(this.FinishDZ_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.FinishDZ);
            this.Controls.Add(this.StartDZ);
            this.Name = "Form1";
            this.Text = "Среднее значение";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartDZ;
        private System.Windows.Forms.Button FinishDZ;
    }
}

