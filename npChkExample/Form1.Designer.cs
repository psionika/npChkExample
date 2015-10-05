namespace npChkExample
{
    partial class Form1
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
            this.bntCheckOne = new System.Windows.Forms.Button();
            this.btnCheckMulti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bntCheckOne
            // 
            this.bntCheckOne.Location = new System.Drawing.Point(13, 13);
            this.bntCheckOne.Name = "bntCheckOne";
            this.bntCheckOne.Size = new System.Drawing.Size(114, 23);
            this.bntCheckOne.TabIndex = 0;
            this.bntCheckOne.Text = "bntCheckOne";
            this.bntCheckOne.UseVisualStyleBackColor = true;
            this.bntCheckOne.Click += new System.EventHandler(this.bntCheckOne_Click);
            // 
            // btnCheckMulti
            // 
            this.btnCheckMulti.Location = new System.Drawing.Point(13, 45);
            this.btnCheckMulti.Name = "btnCheckMulti";
            this.btnCheckMulti.Size = new System.Drawing.Size(114, 23);
            this.btnCheckMulti.TabIndex = 1;
            this.btnCheckMulti.Text = "btnCheckMulti";
            this.btnCheckMulti.UseVisualStyleBackColor = true;
            this.btnCheckMulti.Click += new System.EventHandler(this.btnCheckMulti_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 80);
            this.Controls.Add(this.btnCheckMulti);
            this.Controls.Add(this.bntCheckOne);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bntCheckOne;
        private System.Windows.Forms.Button btnCheckMulti;
    }
}

