namespace Ping_Server_GV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rdtp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timetolive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dntfrg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.st = new System.Windows.Forms.DataGridViewImageColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtAdrs = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nme,
            this.Adr,
            this.rdtp,
            this.timetolive,
            this.dntfrg,
            this.bff,
            this.st});
            this.dataGridView1.Location = new System.Drawing.Point(9, 145);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridView1.Size = new System.Drawing.Size(927, 270);
            this.dataGridView1.TabIndex = 0;
            // 
            // Nme
            // 
            this.Nme.HeaderText = "Nombre";
            this.Nme.MinimumWidth = 6;
            this.Nme.Name = "Nme";
            this.Nme.ReadOnly = true;
            this.Nme.Width = 125;
            // 
            // Adr
            // 
            this.Adr.HeaderText = "Direccion";
            this.Adr.MinimumWidth = 6;
            this.Adr.Name = "Adr";
            this.Adr.ReadOnly = true;
            this.Adr.Width = 125;
            // 
            // rdtp
            // 
            this.rdtp.HeaderText = "Roundtrip";
            this.rdtp.MinimumWidth = 6;
            this.rdtp.Name = "rdtp";
            this.rdtp.ReadOnly = true;
            this.rdtp.Width = 125;
            // 
            // timetolive
            // 
            this.timetolive.HeaderText = "TimeToLive";
            this.timetolive.MinimumWidth = 6;
            this.timetolive.Name = "timetolive";
            this.timetolive.ReadOnly = true;
            this.timetolive.Width = 125;
            // 
            // dntfrg
            // 
            this.dntfrg.HeaderText = "Don\'tFragment";
            this.dntfrg.MinimumWidth = 6;
            this.dntfrg.Name = "dntfrg";
            this.dntfrg.ReadOnly = true;
            this.dntfrg.Width = 125;
            // 
            // bff
            // 
            this.bff.HeaderText = "Buffer";
            this.bff.MinimumWidth = 6;
            this.bff.Name = "bff";
            this.bff.ReadOnly = true;
            this.bff.Width = 125;
            // 
            // st
            // 
            this.st.HeaderText = "Status";
            this.st.MinimumWidth = 6;
            this.st.Name = "st";
            this.st.ReadOnly = true;
            this.st.Width = 125;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtAdrs
            // 
            this.txtAdrs.Location = new System.Drawing.Point(146, 117);
            this.txtAdrs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAdrs.Name = "txtAdrs";
            this.txtAdrs.Size = new System.Drawing.Size(134, 20);
            this.txtAdrs.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(284, 115);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(144, 24);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Agregar direccion";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(9, 117);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(134, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Dirección IP";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(808, 117);
            this.btnStop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(125, 24);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "Detener monitoreo";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(432, 115);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(144, 24);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Eliminar direccion";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 425);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAdrs);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Ping Monitor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nme;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adr;
        private System.Windows.Forms.DataGridViewTextBoxColumn rdtp;
        private System.Windows.Forms.DataGridViewTextBoxColumn timetolive;
        private System.Windows.Forms.DataGridViewTextBoxColumn dntfrg;
        private System.Windows.Forms.DataGridViewTextBoxColumn bff;
        private System.Windows.Forms.DataGridViewImageColumn st;
        private System.Windows.Forms.TextBox txtAdrs;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnDelete;
    }
}

