namespace NippySoft.FaceDetect.Azure.Example.Net45
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
            this.pictureUsed = new System.Windows.Forms.PictureBox();
            this.dialogOpen = new System.Windows.Forms.OpenFileDialog();
            this.btnSelectImage = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataFaces = new System.Windows.Forms.DataGridView();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUsed)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataFaces)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureUsed
            // 
            this.pictureUsed.Location = new System.Drawing.Point(12, 12);
            this.pictureUsed.Name = "pictureUsed";
            this.pictureUsed.Size = new System.Drawing.Size(431, 325);
            this.pictureUsed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureUsed.TabIndex = 0;
            this.pictureUsed.TabStop = false;
            // 
            // dialogOpen
            // 
            this.dialogOpen.FileName = "openFileDialog1";
            this.dialogOpen.Filter = "jpg|*.jpg|jpeg|*.jpeg|png|*.png";
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.Location = new System.Drawing.Point(12, 343);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(133, 23);
            this.btnSelectImage.TabIndex = 1;
            this.btnSelectImage.Text = "Select Image";
            this.btnSelectImage.UseVisualStyleBackColor = true;
            this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataFaces);
            this.groupBox1.Location = new System.Drawing.Point(460, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 324);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // dataFaces
            // 
            this.dataFaces.AllowUserToAddRows = false;
            this.dataFaces.AllowUserToDeleteRows = false;
            this.dataFaces.AllowUserToOrderColumns = true;
            this.dataFaces.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataFaces.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Gender,
            this.Age});
            this.dataFaces.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataFaces.Location = new System.Drawing.Point(3, 16);
            this.dataFaces.Name = "dataFaces";
            this.dataFaces.ReadOnly = true;
            this.dataFaces.Size = new System.Drawing.Size(377, 305);
            this.dataFaces.TabIndex = 0;
            this.dataFaces.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Gender
            // 
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // Age
            // 
            this.Age.HeaderText = "Age";
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 433);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSelectImage);
            this.Controls.Add(this.pictureUsed);
            this.Name = "Form1";
            this.Text = "Example Face Detection";
            ((System.ComponentModel.ISupportInitialize)(this.pictureUsed)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataFaces)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureUsed;
        private System.Windows.Forms.OpenFileDialog dialogOpen;
        private System.Windows.Forms.Button btnSelectImage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataFaces;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
    }
}

