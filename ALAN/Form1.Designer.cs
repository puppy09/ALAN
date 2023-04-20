namespace ALAN
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
            this.btnCal = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbxNewMas = new System.Windows.Forms.TextBox();
            this.tbxID = new System.Windows.Forms.TextBox();
            this.tbxHostPra = new System.Windows.Forms.TextBox();
            this.tbxSubTeo = new System.Windows.Forms.TextBox();
            this.tbxHostTeo = new System.Windows.Forms.TextBox();
            this.tbxSubPra = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbnSubredes = new System.Windows.Forms.RadioButton();
            this.rbnHost = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbxSubredes = new System.Windows.Forms.TextBox();
            this.tbxHost = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(140, 266);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(75, 23);
            this.btnCal.TabIndex = 0;
            this.btnCal.Text = "button1";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(115, 164);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 2;
            // 
            // tbxNewMas
            // 
            this.tbxNewMas.Location = new System.Drawing.Point(537, 282);
            this.tbxNewMas.Name = "tbxNewMas";
            this.tbxNewMas.Size = new System.Drawing.Size(207, 22);
            this.tbxNewMas.TabIndex = 3;
            // 
            // tbxID
            // 
            this.tbxID.Location = new System.Drawing.Point(79, 74);
            this.tbxID.Name = "tbxID";
            this.tbxID.Size = new System.Drawing.Size(200, 22);
            this.tbxID.TabIndex = 4;
            // 
            // tbxHostPra
            // 
            this.tbxHostPra.Location = new System.Drawing.Point(19, 117);
            this.tbxHostPra.Name = "tbxHostPra";
            this.tbxHostPra.Size = new System.Drawing.Size(100, 22);
            this.tbxHostPra.TabIndex = 5;
            // 
            // tbxSubTeo
            // 
            this.tbxSubTeo.Location = new System.Drawing.Point(19, 33);
            this.tbxSubTeo.Name = "tbxSubTeo";
            this.tbxSubTeo.Size = new System.Drawing.Size(100, 22);
            this.tbxSubTeo.TabIndex = 6;
            // 
            // tbxHostTeo
            // 
            this.tbxHostTeo.Location = new System.Drawing.Point(19, 89);
            this.tbxHostTeo.Name = "tbxHostTeo";
            this.tbxHostTeo.Size = new System.Drawing.Size(100, 22);
            this.tbxHostTeo.TabIndex = 7;
            // 
            // tbxSubPra
            // 
            this.tbxSubPra.Location = new System.Drawing.Point(19, 61);
            this.tbxSubPra.Name = "tbxSubPra";
            this.tbxSubPra.Size = new System.Drawing.Size(100, 22);
            this.tbxSubPra.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxHost);
            this.groupBox1.Controls.Add(this.tbxSubredes);
            this.groupBox1.Controls.Add(this.rbnSubredes);
            this.groupBox1.Controls.Add(this.rbnHost);
            this.groupBox1.Location = new System.Drawing.Point(79, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // rbnSubredes
            // 
            this.rbnSubredes.AutoSize = true;
            this.rbnSubredes.Location = new System.Drawing.Point(23, 34);
            this.rbnSubredes.Name = "rbnSubredes";
            this.rbnSubredes.Size = new System.Drawing.Size(103, 20);
            this.rbnSubredes.TabIndex = 1;
            this.rbnSubredes.TabStop = true;
            this.rbnSubredes.Text = "radioButton2";
            this.rbnSubredes.UseVisualStyleBackColor = true;
            this.rbnSubredes.CheckedChanged += new System.EventHandler(this.rbnSubredes_CheckedChanged);
            // 
            // rbnHost
            // 
            this.rbnHost.AutoSize = true;
            this.rbnHost.Location = new System.Drawing.Point(23, 62);
            this.rbnHost.Name = "rbnHost";
            this.rbnHost.Size = new System.Drawing.Size(103, 20);
            this.rbnHost.TabIndex = 0;
            this.rbnHost.TabStop = true;
            this.rbnHost.Text = "radioButton1";
            this.rbnHost.UseVisualStyleBackColor = true;
            this.rbnHost.CheckedChanged += new System.EventHandler(this.rbnHost_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbxHostPra);
            this.groupBox2.Controls.Add(this.tbxSubTeo);
            this.groupBox2.Controls.Add(this.tbxSubPra);
            this.groupBox2.Controls.Add(this.tbxHostTeo);
            this.groupBox2.Location = new System.Drawing.Point(518, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(226, 173);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // tbxSubredes
            // 
            this.tbxSubredes.Enabled = false;
            this.tbxSubredes.Location = new System.Drawing.Point(142, 34);
            this.tbxSubredes.Name = "tbxSubredes";
            this.tbxSubredes.Size = new System.Drawing.Size(194, 22);
            this.tbxSubredes.TabIndex = 7;
            // 
            // tbxHost
            // 
            this.tbxHost.Enabled = false;
            this.tbxHost.Location = new System.Drawing.Point(142, 62);
            this.tbxHost.Name = "tbxHost";
            this.tbxHost.Size = new System.Drawing.Size(194, 22);
            this.tbxHost.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbxID);
            this.Controls.Add(this.tbxNewMas);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tbxNewMas;
        private System.Windows.Forms.TextBox tbxID;
        private System.Windows.Forms.TextBox tbxHostPra;
        private System.Windows.Forms.TextBox tbxSubTeo;
        private System.Windows.Forms.TextBox tbxHostTeo;
        private System.Windows.Forms.TextBox tbxSubPra;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbnSubredes;
        private System.Windows.Forms.RadioButton rbnHost;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbxHost;
        private System.Windows.Forms.TextBox tbxSubredes;
    }
}

