namespace DZ1_2
{
    partial class GuessNumber
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
            this.StartProg = new System.Windows.Forms.Button();
            this.FinishProg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartProg
            // 
            this.StartProg.Location = new System.Drawing.Point(77, 306);
            this.StartProg.Name = "StartProg";
            this.StartProg.Size = new System.Drawing.Size(75, 23);
            this.StartProg.TabIndex = 0;
            this.StartProg.Text = "Старт";
            this.StartProg.UseVisualStyleBackColor = true;
            this.StartProg.Click += new System.EventHandler(this.StartProg_Click);
            // 
            // FinishProg
            // 
            this.FinishProg.Location = new System.Drawing.Point(299, 306);
            this.FinishProg.Name = "FinishProg";
            this.FinishProg.Size = new System.Drawing.Size(75, 23);
            this.FinishProg.TabIndex = 1;
            this.FinishProg.Text = "Выход";
            this.FinishProg.UseVisualStyleBackColor = true;
            this.FinishProg.Click += new System.EventHandler(this.FinishProg_Click);
            // 
            // GuessNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.FinishProg);
            this.Controls.Add(this.StartProg);
            this.Name = "GuessNumber";
            this.Text = "Угадай Число";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartProg;
        private System.Windows.Forms.Button FinishProg;
    }
}

