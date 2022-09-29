
namespace Empleados
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
            this.components = new System.ComponentModel.Container();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelDUI = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDUI = new System.Windows.Forms.TextBox();
            this.btGuardar = new System.Windows.Forms.Button();
            this.labelRegistro = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtAFP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbDUI = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(118, 47);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "Nombre";
            // 
            // labelDUI
            // 
            this.labelDUI.AutoSize = true;
            this.labelDUI.Location = new System.Drawing.Point(118, 85);
            this.labelDUI.Name = "labelDUI";
            this.labelDUI.Size = new System.Drawing.Size(26, 13);
            this.labelDUI.TabIndex = 2;
            this.labelDUI.Text = "DUI";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(274, 44);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtDUI
            // 
            this.txtDUI.Location = new System.Drawing.Point(274, 82);
            this.txtDUI.Name = "txtDUI";
            this.txtDUI.Size = new System.Drawing.Size(100, 20);
            this.txtDUI.TabIndex = 5;
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(79, 206);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(75, 23);
            this.btGuardar.TabIndex = 6;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // labelRegistro
            // 
            this.labelRegistro.AutoSize = true;
            this.labelRegistro.Location = new System.Drawing.Point(544, 137);
            this.labelRegistro.Name = "labelRegistro";
            this.labelRegistro.Size = new System.Drawing.Size(0, 13);
            this.labelRegistro.TabIndex = 7;
            this.labelRegistro.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtAFP
            // 
            this.txtAFP.Location = new System.Drawing.Point(274, 159);
            this.txtAFP.Name = "txtAFP";
            this.txtAFP.Size = new System.Drawing.Size(100, 20);
            this.txtAFP.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Salario";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(274, 121);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 20);
            this.txtSalario.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "AFP";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(459, 206);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(116, 44);
            this.btnInsertar.TabIndex = 13;
            this.btnInsertar.Text = "Insertar Registro";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(628, 206);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 14;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(592, 162);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 20);
            this.textBox1.TabIndex = 15;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(595, 47);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(35, 13);
            this.lbNombre.TabIndex = 16;
            this.lbNombre.Text = "label3";
            // 
            // lbDUI
            // 
            this.lbDUI.AutoSize = true;
            this.lbDUI.Location = new System.Drawing.Point(595, 84);
            this.lbDUI.Name = "lbDUI";
            this.lbDUI.Size = new System.Drawing.Size(35, 13);
            this.lbDUI.TabIndex = 17;
            this.lbDUI.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 274);
            this.Controls.Add(this.lbDUI);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAFP);
            this.Controls.Add(this.labelRegistro);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.txtDUI);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.labelDUI);
            this.Controls.Add(this.labelNombre);
            this.Name = "Form1";
            this.Text = "Registro de empleados";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelDUI;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDUI;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Label labelRegistro;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAFP;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lbDUI;
        private System.Windows.Forms.Label lbNombre;
    }
}

