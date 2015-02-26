namespace Lector_Bascula
{
    partial class fmrMain
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmrMain));
            this.pictureBoxBascula = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripConectar = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeBASCULACOPEOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxLector = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBoxListoLeer = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.EPC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PESO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonReadings = new System.Windows.Forms.Button();
            this.pictureBoxEstado = new System.Windows.Forms.PictureBox();
            this.labelEstado = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelAvisos = new System.Windows.Forms.Label();
            this.radioButtonInitial = new System.Windows.Forms.RadioButton();
            this.radioButtonFinal = new System.Windows.Forms.RadioButton();
            this.groupBoxInventory = new System.Windows.Forms.GroupBox();
            this.radioButtonWeight = new System.Windows.Forms.RadioButton();
            this.radioButtonInventory = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBascula)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxListoLeer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEstado)).BeginInit();
            this.groupBoxInventory.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxBascula
            // 
            this.pictureBoxBascula.BackColor = System.Drawing.Color.Red;
            this.pictureBoxBascula.Location = new System.Drawing.Point(730, 95);
            this.pictureBoxBascula.Name = "pictureBoxBascula";
            this.pictureBoxBascula.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxBascula.TabIndex = 0;
            this.pictureBoxBascula.TabStop = false;
            this.pictureBoxBascula.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(786, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "LECTOR";
            this.label1.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.herramientasToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(592, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripConectar});
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.herramientasToolStripMenuItem.Text = "&Herramientas";
            // 
            // toolStripConectar
            // 
            this.toolStripConectar.Name = "toolStripConectar";
            this.toolStripConectar.Size = new System.Drawing.Size(122, 22);
            this.toolStripConectar.Text = "&Conectar";
            this.toolStripConectar.Click += new System.EventHandler(this.conectarToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.acercaDeBASCULACOPEOToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "A&yuda";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(224, 22);
            this.toolStripMenuItem2.Text = "&Ver la Ayuda";
            this.toolStripMenuItem2.ToolTipText = "Visualizar la ayuda del programa";
            // 
            // acercaDeBASCULACOPEOToolStripMenuItem
            // 
            this.acercaDeBASCULACOPEOToolStripMenuItem.Name = "acercaDeBASCULACOPEOToolStripMenuItem";
            this.acercaDeBASCULACOPEOToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.acercaDeBASCULACOPEOToolStripMenuItem.Text = "&Acerca de BASCULA-COPEO";
            this.acercaDeBASCULACOPEOToolStripMenuItem.ToolTipText = "Detalles del programa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(786, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "BÁSCULA";
            this.label2.Visible = false;
            // 
            // pictureBoxLector
            // 
            this.pictureBoxLector.BackColor = System.Drawing.Color.Red;
            this.pictureBoxLector.Location = new System.Drawing.Point(730, 131);
            this.pictureBoxLector.Name = "pictureBoxLector";
            this.pictureBoxLector.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxLector.TabIndex = 3;
            this.pictureBoxLector.TabStop = false;
            this.pictureBoxLector.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(786, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "LISTO PARA LEER";
            this.label4.Visible = false;
            // 
            // pictureBoxListoLeer
            // 
            this.pictureBoxListoLeer.BackColor = System.Drawing.Color.Red;
            this.pictureBoxListoLeer.Location = new System.Drawing.Point(730, 167);
            this.pictureBoxListoLeer.Name = "pictureBoxListoLeer";
            this.pictureBoxListoLeer.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxListoLeer.TabIndex = 7;
            this.pictureBoxListoLeer.TabStop = false;
            this.pictureBoxListoLeer.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(714, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "ESTADO";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(786, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "DESCRIPCIÓN";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(919, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "DETALLE DE LECTURAS";
            this.label7.Visible = false;
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EPC,
            this.PESO});
            this.dgvDatos.Location = new System.Drawing.Point(922, 91);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(353, 272);
            this.dgvDatos.TabIndex = 12;
            this.dgvDatos.Visible = false;
            // 
            // EPC
            // 
            this.EPC.HeaderText = "EPC";
            this.EPC.Name = "EPC";
            this.EPC.Width = 200;
            // 
            // PESO
            // 
            this.PESO.HeaderText = "PESO";
            this.PESO.Name = "PESO";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(717, 225);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(179, 40);
            this.buttonStart.TabIndex = 20;
            this.buttonStart.Text = "Realizar lectura";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Visible = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonReadings
            // 
            this.buttonReadings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(68)))), ((int)(((byte)(121)))));
            this.buttonReadings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReadings.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonReadings.FlatAppearance.BorderSize = 2;
            this.buttonReadings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(37)))), ((int)(((byte)(97)))));
            this.buttonReadings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReadings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReadings.Location = new System.Drawing.Point(413, 319);
            this.buttonReadings.Name = "buttonReadings";
            this.buttonReadings.Size = new System.Drawing.Size(170, 127);
            this.buttonReadings.TabIndex = 23;
            this.buttonReadings.Text = "Realizar Lectura (PRESS ENTER)";
            this.buttonReadings.UseVisualStyleBackColor = false;
            this.buttonReadings.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // pictureBoxEstado
            // 
            this.pictureBoxEstado.BackColor = System.Drawing.Color.Red;
            this.pictureBoxEstado.Location = new System.Drawing.Point(26, 60);
            this.pictureBoxEstado.Name = "pictureBoxEstado";
            this.pictureBoxEstado.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxEstado.TabIndex = 24;
            this.pictureBoxEstado.TabStop = false;
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstado.Location = new System.Drawing.Point(82, 79);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(155, 20);
            this.labelEstado.TabIndex = 25;
            this.labelEstado.Text = "DESCONECTADO";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 319);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(395, 127);
            this.textBox1.TabIndex = 26;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Área de mensajes importantes!";
            this.textBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
            // 
            // labelAvisos
            // 
            this.labelAvisos.AutoSize = true;
            this.labelAvisos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvisos.Location = new System.Drawing.Point(946, 214);
            this.labelAvisos.Name = "labelAvisos";
            this.labelAvisos.Size = new System.Drawing.Size(44, 13);
            this.labelAvisos.TabIndex = 27;
            this.labelAvisos.Text = "Avisos";
            this.labelAvisos.Visible = false;
            // 
            // radioButtonInitial
            // 
            this.radioButtonInitial.AutoSize = true;
            this.radioButtonInitial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonInitial.Location = new System.Drawing.Point(111, 37);
            this.radioButtonInitial.Name = "radioButtonInitial";
            this.radioButtonInitial.Size = new System.Drawing.Size(67, 20);
            this.radioButtonInitial.TabIndex = 31;
            this.radioButtonInitial.Text = "Inicial";
            this.radioButtonInitial.UseVisualStyleBackColor = true;
            this.radioButtonInitial.Click += new System.EventHandler(this.radioButtonInitial_Click);
            // 
            // radioButtonFinal
            // 
            this.radioButtonFinal.AutoSize = true;
            this.radioButtonFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFinal.Location = new System.Drawing.Point(316, 37);
            this.radioButtonFinal.Name = "radioButtonFinal";
            this.radioButtonFinal.Size = new System.Drawing.Size(60, 20);
            this.radioButtonFinal.TabIndex = 32;
            this.radioButtonFinal.TabStop = true;
            this.radioButtonFinal.Text = "Final";
            this.radioButtonFinal.UseVisualStyleBackColor = true;
            this.radioButtonFinal.Click += new System.EventHandler(this.radioButtonInitial_Click);
            // 
            // groupBoxInventory
            // 
            this.groupBoxInventory.Controls.Add(this.radioButtonFinal);
            this.groupBoxInventory.Controls.Add(this.radioButtonInitial);
            this.groupBoxInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInventory.Location = new System.Drawing.Point(12, 230);
            this.groupBoxInventory.Name = "groupBoxInventory";
            this.groupBoxInventory.Size = new System.Drawing.Size(571, 76);
            this.groupBoxInventory.TabIndex = 33;
            this.groupBoxInventory.TabStop = false;
            this.groupBoxInventory.Text = "Inventario";
            // 
            // radioButtonWeight
            // 
            this.radioButtonWeight.AutoSize = true;
            this.radioButtonWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonWeight.Location = new System.Drawing.Point(316, 40);
            this.radioButtonWeight.Name = "radioButtonWeight";
            this.radioButtonWeight.Size = new System.Drawing.Size(241, 20);
            this.radioButtonWeight.TabIndex = 35;
            this.radioButtonWeight.TabStop = true;
            this.radioButtonWeight.Text = "Registrar peso de botella llena";
            this.radioButtonWeight.UseVisualStyleBackColor = true;
            this.radioButtonWeight.CheckedChanged += new System.EventHandler(this.radioButtonWeight_CheckedChanged);
            // 
            // radioButtonInventory
            // 
            this.radioButtonInventory.AutoSize = true;
            this.radioButtonInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonInventory.Location = new System.Drawing.Point(111, 40);
            this.radioButtonInventory.Name = "radioButtonInventory";
            this.radioButtonInventory.Size = new System.Drawing.Size(94, 20);
            this.radioButtonInventory.TabIndex = 34;
            this.radioButtonInventory.Text = "Inventario";
            this.radioButtonInventory.UseVisualStyleBackColor = true;
            this.radioButtonInventory.CheckedChanged += new System.EventHandler(this.radioButtonInventory_CheckedChanged);
            this.radioButtonInventory.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButtonInventory_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonInventory);
            this.groupBox1.Controls.Add(this.radioButtonWeight);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(568, 76);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones de lecturas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(450, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 100);
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // fmrMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(178)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(592, 463);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxInventory);
            this.Controls.Add(this.labelAvisos);
            this.Controls.Add(this.buttonReadings);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.pictureBoxEstado);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBoxListoLeer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBoxLector);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxBascula);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fmrMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BASCULA-COPEO";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBascula)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxListoLeer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEstado)).EndInit();
            this.groupBoxInventory.ResumeLayout(false);
            this.groupBoxInventory.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBascula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem acercaDeBASCULACOPEOToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxLector;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBoxListoLeer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn EPC;
        private System.Windows.Forms.DataGridViewTextBoxColumn PESO;
        private System.Windows.Forms.Button buttonReadings;
        private System.Windows.Forms.PictureBox pictureBoxEstado;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelAvisos;
        private System.Windows.Forms.RadioButton radioButtonInitial;
        private System.Windows.Forms.RadioButton radioButtonFinal;
        private System.Windows.Forms.GroupBox groupBoxInventory;
        private System.Windows.Forms.RadioButton radioButtonWeight;
        private System.Windows.Forms.RadioButton radioButtonInventory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripConectar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

