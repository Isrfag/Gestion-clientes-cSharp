namespace GestionClientes
{
    partial class Menu
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
            buttonMnuGest = new Button();
            SuspendLayout();
            // 
            // buttonMnuGest
            // 
            buttonMnuGest.Location = new Point(311, 121);
            buttonMnuGest.Name = "buttonMnuGest";
            buttonMnuGest.Size = new Size(150, 93);
            buttonMnuGest.TabIndex = 0;
            buttonMnuGest.Text = "Gestionar clientes";
            buttonMnuGest.UseVisualStyleBackColor = true;
            buttonMnuGest.Click += buttonMnuGest_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonMnuGest);
            Name = "Menu";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonMnuGest;
    }
}