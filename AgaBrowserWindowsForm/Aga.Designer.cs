namespace AgaBrowserWindowsForm
{
    partial class AgaForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgaForm));
            this.Go_Button = new System.Windows.Forms.Button();
            this.URL_Input = new System.Windows.Forms.TextBox();
            this.Main_Panel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Go_Button
            // 
            this.Go_Button.Location = new System.Drawing.Point(718, 12);
            this.Go_Button.Name = "Go_Button";
            this.Go_Button.Size = new System.Drawing.Size(75, 20);
            this.Go_Button.TabIndex = 0;
            this.Go_Button.Text = "Go";
            this.Go_Button.UseVisualStyleBackColor = true;
            this.Go_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // URL_Input
            // 
            this.URL_Input.Location = new System.Drawing.Point(12, 12);
            this.URL_Input.Name = "URL_Input";
            this.URL_Input.Size = new System.Drawing.Size(700, 20);
            this.URL_Input.TabIndex = 1;
            this.URL_Input.Text = "https://google.com/\r\n";
            this.URL_Input.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Main_Panel
            // 
            this.Main_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Main_Panel.Location = new System.Drawing.Point(12, 38);
            this.Main_Panel.Name = "Main_Panel";
            this.Main_Panel.Size = new System.Drawing.Size(769, 520);
            this.Main_Panel.TabIndex = 2;
            // 
            // AgaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.Main_Panel);
            this.Controls.Add(this.URL_Input);
            this.Controls.Add(this.Go_Button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AgaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aga Browser";
            this.TransparencyKey = System.Drawing.Color.Aquamarine;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Aga_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Go_Button;
        private System.Windows.Forms.TextBox URL_Input;
        private System.Windows.Forms.Panel Main_Panel;
    }
}

