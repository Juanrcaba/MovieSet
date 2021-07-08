
namespace MovieSet
{
    partial class frmAddDevices
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.txt_macaddress = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgDatos_Usuarios = new System.Windows.Forms.DataGridView();
            this.dgDatos_MacAddress = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgDatos_Usuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDatos_MacAddress)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "MacAddress";
            // 
            // txt_macaddress
            // 
            this.txt_macaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_macaddress.Location = new System.Drawing.Point(42, 290);
            this.txt_macaddress.Name = "txt_macaddress";
            this.txt_macaddress.Size = new System.Drawing.Size(285, 23);
            this.txt_macaddress.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(42, 331);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(157, 50);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "&Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(225, 331);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(157, 50);
            this.btnEliminar.TabIndex = 16;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgDatos_Usuarios
            // 
            this.dgDatos_Usuarios.AllowUserToAddRows = false;
            this.dgDatos_Usuarios.AllowUserToDeleteRows = false;
            this.dgDatos_Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDatos_Usuarios.Location = new System.Drawing.Point(42, 42);
            this.dgDatos_Usuarios.MultiSelect = false;
            this.dgDatos_Usuarios.Name = "dgDatos_Usuarios";
            this.dgDatos_Usuarios.ReadOnly = true;
            this.dgDatos_Usuarios.RowHeadersVisible = false;
            this.dgDatos_Usuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDatos_Usuarios.Size = new System.Drawing.Size(177, 206);
            this.dgDatos_Usuarios.TabIndex = 17;
            this.dgDatos_Usuarios.DoubleClick += new System.EventHandler(this.dgDatos_Usuarios_DoubleClick);
            // 
            // dgDatos_MacAddress
            // 
            this.dgDatos_MacAddress.AllowUserToAddRows = false;
            this.dgDatos_MacAddress.AllowUserToDeleteRows = false;
            this.dgDatos_MacAddress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDatos_MacAddress.Location = new System.Drawing.Point(261, 42);
            this.dgDatos_MacAddress.MultiSelect = false;
            this.dgDatos_MacAddress.Name = "dgDatos_MacAddress";
            this.dgDatos_MacAddress.ReadOnly = true;
            this.dgDatos_MacAddress.RowHeadersVisible = false;
            this.dgDatos_MacAddress.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDatos_MacAddress.Size = new System.Drawing.Size(177, 206);
            this.dgDatos_MacAddress.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Usuarios";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(258, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "MacAddress Listado";
            // 
            // frmAddDevices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 406);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgDatos_MacAddress);
            this.Controls.Add(this.dgDatos_Usuarios);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_macaddress);
            this.MaximumSize = new System.Drawing.Size(488, 445);
            this.MinimumSize = new System.Drawing.Size(488, 445);
            this.Name = "frmAddDevices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".::GESTION DE DISPOSITIVOS::.";
            this.Load += new System.EventHandler(this.frmAddDevices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDatos_Usuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDatos_MacAddress)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_macaddress;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgDatos_Usuarios;
        private System.Windows.Forms.DataGridView dgDatos_MacAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}