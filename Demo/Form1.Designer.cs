namespace Demo
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
            this.btn_CreateCons = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_CreateCons
            // 
            this.btn_CreateCons.Location = new System.Drawing.Point(313, 59);
            this.btn_CreateCons.Name = "btn_CreateCons";
            this.btn_CreateCons.Size = new System.Drawing.Size(75, 23);
            this.btn_CreateCons.TabIndex = 0;
            this.btn_CreateCons.Text = "Create";
            this.btn_CreateCons.UseVisualStyleBackColor = true;
            this.btn_CreateCons.Click += new System.EventHandler(this.btn_CreateCons_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_CreateCons);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_CreateCons;
    }
}