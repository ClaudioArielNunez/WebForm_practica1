
namespace WindowsFormsApp5
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimeNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBoxTipeDev = new System.Windows.Forms.CheckBox();
            this.radioBtnJAVA = new System.Windows.Forms.RadioButton();
            this.radioBtnPYTON = new System.Windows.Forms.RadioButton();
            this.radioBtnCPLUS = new System.Windows.Forms.RadioButton();
            this.radioBtnJS = new System.Windows.Forms.RadioButton();
            this.groupBoxTecnologia = new System.Windows.Forms.GroupBox();
            this.cboSeniority = new System.Windows.Forms.ComboBox();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.groupBoxTecnologia.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(210, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Formulario de Inscripción";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.Location = new System.Drawing.Point(128, 75);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(203, 35);
            this.textBoxNombre.TabIndex = 2;
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(480, 75);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(210, 35);
            this.textBoxApellido.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(394, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apellido";
            // 
            // dateTimeNacimiento
            // 
            this.dateTimeNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeNacimiento.Location = new System.Drawing.Point(215, 134);
            this.dateTimeNacimiento.Name = "dateTimeNacimiento";
            this.dateTimeNacimiento.Size = new System.Drawing.Size(200, 26);
            this.dateTimeNacimiento.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha de Nacimiento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(56, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Seniority";
            // 
            // checkBoxTipeDev
            // 
            this.checkBoxTipeDev.AutoSize = true;
            this.checkBoxTipeDev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxTipeDev.Location = new System.Drawing.Point(54, 183);
            this.checkBoxTipeDev.Name = "checkBoxTipeDev";
            this.checkBoxTipeDev.Size = new System.Drawing.Size(301, 24);
            this.checkBoxTipeDev.TabIndex = 9;
            this.checkBoxTipeDev.Text = "Te interesa la Programacion Backend?";
            this.checkBoxTipeDev.UseVisualStyleBackColor = true;
            // 
            // radioBtnJAVA
            // 
            this.radioBtnJAVA.AutoSize = true;
            this.radioBtnJAVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnJAVA.Location = new System.Drawing.Point(15, 25);
            this.radioBtnJAVA.Name = "radioBtnJAVA";
            this.radioBtnJAVA.Size = new System.Drawing.Size(60, 24);
            this.radioBtnJAVA.TabIndex = 10;
            this.radioBtnJAVA.TabStop = true;
            this.radioBtnJAVA.Text = "Java\r\n";
            this.radioBtnJAVA.UseVisualStyleBackColor = true;
            // 
            // radioBtnPYTON
            // 
            this.radioBtnPYTON.AutoSize = true;
            this.radioBtnPYTON.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnPYTON.Location = new System.Drawing.Point(404, 25);
            this.radioBtnPYTON.Name = "radioBtnPYTON";
            this.radioBtnPYTON.Size = new System.Drawing.Size(67, 24);
            this.radioBtnPYTON.TabIndex = 11;
            this.radioBtnPYTON.TabStop = true;
            this.radioBtnPYTON.Text = "Pyton\r\n";
            this.radioBtnPYTON.UseVisualStyleBackColor = true;
            // 
            // radioBtnCPLUS
            // 
            this.radioBtnCPLUS.AutoSize = true;
            this.radioBtnCPLUS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnCPLUS.Location = new System.Drawing.Point(304, 25);
            this.radioBtnCPLUS.Name = "radioBtnCPLUS";
            this.radioBtnCPLUS.Size = new System.Drawing.Size(47, 24);
            this.radioBtnCPLUS.TabIndex = 12;
            this.radioBtnCPLUS.TabStop = true;
            this.radioBtnCPLUS.Text = "C#";
            this.radioBtnCPLUS.UseVisualStyleBackColor = true;
            // 
            // radioBtnJS
            // 
            this.radioBtnJS.AutoSize = true;
            this.radioBtnJS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnJS.Location = new System.Drawing.Point(151, 25);
            this.radioBtnJS.Name = "radioBtnJS";
            this.radioBtnJS.Size = new System.Drawing.Size(101, 24);
            this.radioBtnJS.TabIndex = 13;
            this.radioBtnJS.TabStop = true;
            this.radioBtnJS.Text = "JavaScript";
            this.radioBtnJS.UseVisualStyleBackColor = true;
            // 
            // groupBoxTecnologia
            // 
            this.groupBoxTecnologia.Controls.Add(this.radioBtnJAVA);
            this.groupBoxTecnologia.Controls.Add(this.radioBtnPYTON);
            this.groupBoxTecnologia.Controls.Add(this.radioBtnCPLUS);
            this.groupBoxTecnologia.Controls.Add(this.radioBtnJS);
            this.groupBoxTecnologia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTecnologia.Location = new System.Drawing.Point(54, 219);
            this.groupBoxTecnologia.Name = "groupBoxTecnologia";
            this.groupBoxTecnologia.Size = new System.Drawing.Size(509, 57);
            this.groupBoxTecnologia.TabIndex = 14;
            this.groupBoxTecnologia.TabStop = false;
            this.groupBoxTecnologia.Text = "Elija lenguaje por aprender";
            // 
            // cboSeniority
            // 
            this.cboSeniority.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSeniority.FormattingEnabled = true;
            this.cboSeniority.Location = new System.Drawing.Point(128, 286);
            this.cboSeniority.Name = "cboSeniority";
            this.cboSeniority.Size = new System.Drawing.Size(209, 28);
            this.cboSeniority.TabIndex = 15;
            // 
            // btnPerfil
            // 
            this.btnPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPerfil.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPerfil.FlatAppearance.BorderSize = 5;
            this.btnPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerfil.Location = new System.Drawing.Point(562, 292);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(90, 45);
            this.btnPerfil.TabIndex = 16;
            this.btnPerfil.Text = "VerPerfil";
            this.btnPerfil.UseVisualStyleBackColor = true;
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 749);
            this.Controls.Add(this.btnPerfil);
            this.Controls.Add(this.cboSeniority);
            this.Controls.Add(this.groupBoxTecnologia);
            this.Controls.Add(this.checkBoxTipeDev);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimeNacimiento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxTecnologia.ResumeLayout(false);
            this.groupBoxTecnologia.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimeNacimiento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBoxTipeDev;
        private System.Windows.Forms.RadioButton radioBtnJAVA;
        private System.Windows.Forms.RadioButton radioBtnPYTON;
        private System.Windows.Forms.RadioButton radioBtnCPLUS;
        private System.Windows.Forms.RadioButton radioBtnJS;
        private System.Windows.Forms.GroupBox groupBoxTecnologia;
        private System.Windows.Forms.ComboBox cboSeniority;
        private System.Windows.Forms.Button btnPerfil;
    }
}

