
namespace MovieSet
{
    partial class frmMovies
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgDatos_pelicula = new System.Windows.Forms.DataGridView();
            this.pb_image = new System.Windows.Forms.PictureBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_block = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_movieName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgDatos_pelicula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(12, 352);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(157, 50);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "&Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgDatos_pelicula
            // 
            this.dgDatos_pelicula.AllowUserToAddRows = false;
            this.dgDatos_pelicula.AllowUserToDeleteRows = false;
            this.dgDatos_pelicula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDatos_pelicula.Location = new System.Drawing.Point(12, 37);
            this.dgDatos_pelicula.Name = "dgDatos_pelicula";
            this.dgDatos_pelicula.ReadOnly = true;
            this.dgDatos_pelicula.RowHeadersVisible = false;
            this.dgDatos_pelicula.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.dgDatos_pelicula.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDatos_pelicula.Size = new System.Drawing.Size(595, 309);
            this.dgDatos_pelicula.TabIndex = 18;
            this.dgDatos_pelicula.Click += new System.EventHandler(this.dgDatos_pelicula_Click);
            // 
            // pb_image
            // 
            this.pb_image.Location = new System.Drawing.Point(639, 37);
            this.pb_image.Name = "pb_image";
            this.pb_image.Size = new System.Drawing.Size(242, 309);
            this.pb_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_image.TabIndex = 19;
            this.pb_image.TabStop = false;
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(175, 352);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(157, 50);
            this.btn_update.TabIndex = 20;
            this.btn_update.Text = "&Actualizar";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_block
            // 
            this.btn_block.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_block.Location = new System.Drawing.Point(338, 352);
            this.btn_block.Name = "btn_block";
            this.btn_block.Size = new System.Drawing.Size(170, 50);
            this.btn_block.TabIndex = 21;
            this.btn_block.Text = "&Habilitar/Deshabilitar";
            this.btn_block.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Usuarios";
            // 
            // lbl_movieName
            // 
            this.lbl_movieName.AutoSize = true;
            this.lbl_movieName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_movieName.Location = new System.Drawing.Point(636, 352);
            this.lbl_movieName.Name = "lbl_movieName";
            this.lbl_movieName.Size = new System.Drawing.Size(0, 17);
            this.lbl_movieName.TabIndex = 23;
            // 
            // frmMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 423);
            this.Controls.Add(this.lbl_movieName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_block);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.pb_image);
            this.Controls.Add(this.dgDatos_pelicula);
            this.Controls.Add(this.btnAdd);
            this.MaximumSize = new System.Drawing.Size(950, 462);
            this.MinimumSize = new System.Drawing.Size(950, 462);
            this.Name = "frmMovies";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movies";
            this.Load += new System.EventHandler(this.frmMovies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDatos_pelicula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgDatos_pelicula;
        private System.Windows.Forms.PictureBox pb_image;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_block;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_movieName;
    }
}