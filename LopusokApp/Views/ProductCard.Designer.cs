namespace LopusokApp.Views
{
    partial class ProductCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.materialsLabel = new System.Windows.Forms.Label();
            this.articleLabel = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.fullNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::LopusokApp.Properties.Resources.picture;
            this.pictureBox.Location = new System.Drawing.Point(5, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(192, 192);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // materialsLabel
            // 
            this.materialsLabel.AutoSize = true;
            this.materialsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.materialsLabel.Location = new System.Drawing.Point(201, 56);
            this.materialsLabel.Name = "materialsLabel";
            this.materialsLabel.Size = new System.Drawing.Size(456, 24);
            this.materialsLabel.TabIndex = 3;
            this.materialsLabel.Text = "Материал: Материал 1, Материал 2 ... Материал 3";
            // 
            // articleLabel
            // 
            this.articleLabel.AutoSize = true;
            this.articleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.articleLabel.Location = new System.Drawing.Point(203, 32);
            this.articleLabel.Name = "articleLabel";
            this.articleLabel.Size = new System.Drawing.Size(83, 24);
            this.articleLabel.TabIndex = 4;
            this.articleLabel.Text = "Артикул";
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.costLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costLabel.Location = new System.Drawing.Point(814, 8);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(110, 24);
            this.costLabel.TabIndex = 5;
            this.costLabel.Text = "Стоимость";
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullNameLabel.Location = new System.Drawing.Point(201, 8);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(368, 24);
            this.fullNameLabel.TabIndex = 6;
            this.fullNameLabel.Text = "Тип продукта | Наименование продукта";
            // 
            // ProductCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.materialsLabel);
            this.Controls.Add(this.articleLabel);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.fullNameLabel);
            this.Controls.Add(this.pictureBox);
            this.Name = "ProductCard";
            this.Size = new System.Drawing.Size(950, 198);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label materialsLabel;
        internal System.Windows.Forms.Label articleLabel;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label fullNameLabel;
    }
}
