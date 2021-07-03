
namespace ejercicio5
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ejecutarbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NtextBox = new System.Windows.Forms.TextBox();
            this.MtextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.salirbutton = new System.Windows.Forms.Button();
            this.limpiarbutton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ejecutarbutton
            // 
            this.ejecutarbutton.Location = new System.Drawing.Point(158, 176);
            this.ejecutarbutton.Name = "ejecutarbutton";
            this.ejecutarbutton.Size = new System.Drawing.Size(91, 23);
            this.ejecutarbutton.TabIndex = 0;
            this.ejecutarbutton.Text = "Ejecutar";
            this.ejecutarbutton.UseVisualStyleBackColor = true;
            this.ejecutarbutton.Click += new System.EventHandler(this.ejecutarbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese N";
            // 
            // NtextBox
            // 
            this.NtextBox.Location = new System.Drawing.Point(188, 98);
            this.NtextBox.Name = "NtextBox";
            this.NtextBox.Size = new System.Drawing.Size(61, 20);
            this.NtextBox.TabIndex = 2;
            // 
            // MtextBox
            // 
            this.MtextBox.Location = new System.Drawing.Point(188, 136);
            this.MtextBox.Name = "MtextBox";
            this.MtextBox.Size = new System.Drawing.Size(61, 20);
            this.MtextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ingrese M";
            // 
            // salirbutton
            // 
            this.salirbutton.Location = new System.Drawing.Point(107, 239);
            this.salirbutton.Name = "salirbutton";
            this.salirbutton.Size = new System.Drawing.Size(75, 23);
            this.salirbutton.TabIndex = 6;
            this.salirbutton.Text = "Salir";
            this.salirbutton.UseVisualStyleBackColor = true;
            this.salirbutton.Click += new System.EventHandler(this.salirbutton_Click);
            // 
            // limpiarbutton
            // 
            this.limpiarbutton.Location = new System.Drawing.Point(219, 239);
            this.limpiarbutton.Name = "limpiarbutton";
            this.limpiarbutton.Size = new System.Drawing.Size(75, 23);
            this.limpiarbutton.TabIndex = 7;
            this.limpiarbutton.Text = "Limpiar";
            this.limpiarbutton.UseVisualStyleBackColor = true;
            this.limpiarbutton.Click += new System.EventHandler(this.limpiarbutton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(334, 89);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(293, 355);
            this.listBox1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 499);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.limpiarbutton);
            this.Controls.Add(this.salirbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MtextBox);
            this.Controls.Add(this.NtextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ejecutarbutton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ejecutarbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NtextBox;
        private System.Windows.Forms.TextBox MtextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button salirbutton;
        private System.Windows.Forms.Button limpiarbutton;
        private System.Windows.Forms.ListBox listBox1;
    }
}

