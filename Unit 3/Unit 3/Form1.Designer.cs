namespace Unit_3
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NOM = new System.Windows.Forms.TextBox();
            this.APEP = new System.Windows.Forms.TextBox();
            this.APEM = new System.Windows.Forms.TextBox();
            this.FCH = new System.Windows.Forms.DateTimePicker();
            this.TEL = new System.Windows.Forms.TextBox();
            this.COE = new System.Windows.Forms.TextBox();
            this.TABLA = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUMERO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AGREGAR = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.TABLA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "APELLIDO PATERNO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "APELLIDO MATERNO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "FECHA DE NACIMIENTO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(366, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "TELEFONO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "NOMBRE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(377, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "CORREO";
            // 
            // NOM
            // 
            this.NOM.AccessibleName = "NOM";
            this.NOM.Location = new System.Drawing.Point(134, 20);
            this.NOM.Name = "NOM";
            this.NOM.Size = new System.Drawing.Size(100, 20);
            this.NOM.TabIndex = 7;
            // 
            // APEP
            // 
            this.APEP.Location = new System.Drawing.Point(163, 51);
            this.APEP.Name = "APEP";
            this.APEP.Size = new System.Drawing.Size(100, 20);
            this.APEP.TabIndex = 8;
            // 
            // APEM
            // 
            this.APEM.Location = new System.Drawing.Point(165, 81);
            this.APEM.Name = "APEM";
            this.APEM.Size = new System.Drawing.Size(100, 20);
            this.APEM.TabIndex = 9;
            // 
            // FCH
            // 
            this.FCH.Location = new System.Drawing.Point(179, 116);
            this.FCH.Name = "FCH";
            this.FCH.Size = new System.Drawing.Size(200, 20);
            this.FCH.TabIndex = 10;
            // 
            // TEL
            // 
            this.TEL.Location = new System.Drawing.Point(463, 47);
            this.TEL.Name = "TEL";
            this.TEL.Size = new System.Drawing.Size(100, 20);
            this.TEL.TabIndex = 11;
            // 
            // COE
            // 
            this.COE.Location = new System.Drawing.Point(463, 81);
            this.COE.Name = "COE";
            this.COE.Size = new System.Drawing.Size(100, 20);
            this.COE.TabIndex = 12;
            // 
            // TABLA
            // 
            this.TABLA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TABLA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TABLA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.NUMERO,
            this.Column6});
            this.TABLA.Location = new System.Drawing.Point(36, 171);
            this.TABLA.Name = "TABLA";
            this.TABLA.Size = new System.Drawing.Size(721, 171);
            this.TABLA.TabIndex = 13;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "NOMBRE";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "APELLIDO PATERNO";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "APELLIDO MATERNO";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "FECHA DE NACIMIENTO";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "EDAD";
            this.Column5.Name = "Column5";
            // 
            // NUMERO
            // 
            this.NUMERO.HeaderText = "NUMERO";
            this.NUMERO.Name = "NUMERO";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "CORREO";
            this.Column6.Name = "Column6";
            // 
            // AGREGAR
            // 
            this.AGREGAR.Location = new System.Drawing.Point(599, 122);
            this.AGREGAR.Name = "AGREGAR";
            this.AGREGAR.Size = new System.Drawing.Size(75, 23);
            this.AGREGAR.TabIndex = 14;
            this.AGREGAR.Text = "AGREGAR";
            this.AGREGAR.UseVisualStyleBackColor = true;
            this.AGREGAR.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(305, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "No. contactos";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(385, 20);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AGREGAR);
            this.Controls.Add(this.TABLA);
            this.Controls.Add(this.COE);
            this.Controls.Add(this.TEL);
            this.Controls.Add(this.FCH);
            this.Controls.Add(this.APEM);
            this.Controls.Add(this.APEP);
            this.Controls.Add(this.NOM);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.TABLA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NOM;
        private System.Windows.Forms.TextBox APEP;
        private System.Windows.Forms.TextBox APEM;
        private System.Windows.Forms.DateTimePicker FCH;
        private System.Windows.Forms.TextBox TEL;
        private System.Windows.Forms.TextBox COE;
        private System.Windows.Forms.DataGridView TABLA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMERO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button AGREGAR;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

