namespace Ejercicios_III
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
            pbNave = new PictureBox();
            btnLanzamiento = new Button();
            lblCuentaRegresiva = new Label();
            ((System.ComponentModel.ISupportInitialize)pbNave).BeginInit();
            SuspendLayout();
            // 
            // pbNave
            // 
            pbNave.Image = Properties.Resources.nave;
            pbNave.Location = new Point(125, 375);
            pbNave.Name = "pbNave";
            pbNave.Size = new Size(152, 172);
            pbNave.SizeMode = PictureBoxSizeMode.StretchImage;
            pbNave.TabIndex = 0;
            pbNave.TabStop = false;
            // 
            // btnLanzamiento
            // 
            btnLanzamiento.Location = new Point(24, 477);
            btnLanzamiento.Name = "btnLanzamiento";
            btnLanzamiento.Size = new Size(86, 39);
            btnLanzamiento.TabIndex = 1;
            btnLanzamiento.Text = "Lanzamiento";
            btnLanzamiento.UseVisualStyleBackColor = true;
            btnLanzamiento.Click += button1_Click;
            // 
            // lblCuentaRegresiva
            // 
            lblCuentaRegresiva.AutoSize = true;
            lblCuentaRegresiva.BorderStyle = BorderStyle.Fixed3D;
            lblCuentaRegresiva.Location = new Point(331, 501);
            lblCuentaRegresiva.Name = "lblCuentaRegresiva";
            lblCuentaRegresiva.Size = new Size(24, 17);
            lblCuentaRegresiva.TabIndex = 2;
            lblCuentaRegresiva.Text = "---";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(412, 544);
            Controls.Add(lblCuentaRegresiva);
            Controls.Add(btnLanzamiento);
            Controls.Add(pbNave);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pbNave).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbNave;
        private Button btnLanzamiento;
        private Label lblCuentaRegresiva;
    }
}
