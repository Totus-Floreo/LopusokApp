namespace LopusokApp.Views
{
    partial class EditDeleteForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label articleNumberLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label minCostForAgentLabel;
            System.Windows.Forms.Label productionPersonCountLabel;
            System.Windows.Forms.Label productionWorkshopNumberLabel;
            System.Windows.Forms.Label productTypeIDLabel;
            System.Windows.Forms.Label titleLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditDeleteForm));
            System.Windows.Forms.Label label1;
            this.articleNumberTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.minCostForAgentTextBox = new System.Windows.Forms.TextBox();
            this.productionPersonCountTextBox = new System.Windows.Forms.TextBox();
            this.productionWorkshopNumberTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.buttonImageChange = new System.Windows.Forms.Button();
            this.productTypeIDComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.materialIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.materialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productMaterialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            articleNumberLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            minCostForAgentLabel = new System.Windows.Forms.Label();
            productionPersonCountLabel = new System.Windows.Forms.Label();
            productionWorkshopNumberLabel = new System.Windows.Forms.Label();
            productTypeIDLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productMaterialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // articleNumberLabel
            // 
            articleNumberLabel.AutoSize = true;
            articleNumberLabel.Location = new System.Drawing.Point(320, 67);
            articleNumberLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            articleNumberLabel.Name = "articleNumberLabel";
            articleNumberLabel.Size = new System.Drawing.Size(93, 26);
            articleNumberLabel.TabIndex = 1;
            articleNumberLabel.Text = "Артикул:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(320, 297);
            descriptionLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(110, 26);
            descriptionLabel.TabIndex = 3;
            descriptionLabel.Text = "Описание:";
            // 
            // minCostForAgentLabel
            // 
            minCostForAgentLabel.AutoSize = true;
            minCostForAgentLabel.Location = new System.Drawing.Point(320, 113);
            minCostForAgentLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            minCostForAgentLabel.Name = "minCostForAgentLabel";
            minCostForAgentLabel.Size = new System.Drawing.Size(215, 26);
            minCostForAgentLabel.TabIndex = 5;
            minCostForAgentLabel.Text = "Мин. цена для агента:";
            // 
            // productionPersonCountLabel
            // 
            productionPersonCountLabel.AutoSize = true;
            productionPersonCountLabel.Location = new System.Drawing.Point(320, 159);
            productionPersonCountLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            productionPersonCountLabel.Name = "productionPersonCountLabel";
            productionPersonCountLabel.Size = new System.Drawing.Size(272, 26);
            productionPersonCountLabel.TabIndex = 7;
            productionPersonCountLabel.Text = "Кол-во человек для произв.:";
            // 
            // productionWorkshopNumberLabel
            // 
            productionWorkshopNumberLabel.AutoSize = true;
            productionWorkshopNumberLabel.Location = new System.Drawing.Point(320, 205);
            productionWorkshopNumberLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            productionWorkshopNumberLabel.Name = "productionWorkshopNumberLabel";
            productionWorkshopNumberLabel.Size = new System.Drawing.Size(127, 26);
            productionWorkshopNumberLabel.TabIndex = 9;
            productionWorkshopNumberLabel.Text = "Номер цеха:";
            // 
            // productTypeIDLabel
            // 
            productTypeIDLabel.AutoSize = true;
            productTypeIDLabel.Location = new System.Drawing.Point(320, 251);
            productTypeIDLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            productTypeIDLabel.Name = "productTypeIDLabel";
            productTypeIDLabel.Size = new System.Drawing.Size(143, 26);
            productTypeIDLabel.TabIndex = 11;
            productTypeIDLabel.Text = "Тип продукта:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(320, 21);
            titleLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(154, 26);
            titleLabel.TabIndex = 13;
            titleLabel.Text = "Наименование:";
            // 
            // articleNumberTextBox
            // 
            this.articleNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ArticleNumber", true));
            this.articleNumberTextBox.Location = new System.Drawing.Point(608, 61);
            this.articleNumberTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.articleNumberTextBox.MaxLength = 10;
            this.articleNumberTextBox.Name = "articleNumberTextBox";
            this.articleNumberTextBox.Size = new System.Drawing.Size(268, 34);
            this.articleNumberTextBox.TabIndex = 2;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(608, 291);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(268, 171);
            this.descriptionTextBox.TabIndex = 4;
            // 
            // minCostForAgentTextBox
            // 
            this.minCostForAgentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "MinCostForAgent", true));
            this.minCostForAgentTextBox.Location = new System.Drawing.Point(608, 107);
            this.minCostForAgentTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.minCostForAgentTextBox.MaxLength = 500;
            this.minCostForAgentTextBox.Name = "minCostForAgentTextBox";
            this.minCostForAgentTextBox.Size = new System.Drawing.Size(268, 34);
            this.minCostForAgentTextBox.TabIndex = 6;
            // 
            // productionPersonCountTextBox
            // 
            this.productionPersonCountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductionPersonCount", true));
            this.productionPersonCountTextBox.Location = new System.Drawing.Point(608, 153);
            this.productionPersonCountTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.productionPersonCountTextBox.Name = "productionPersonCountTextBox";
            this.productionPersonCountTextBox.Size = new System.Drawing.Size(268, 34);
            this.productionPersonCountTextBox.TabIndex = 8;
            // 
            // productionWorkshopNumberTextBox
            // 
            this.productionWorkshopNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductionWorkshopNumber", true));
            this.productionWorkshopNumberTextBox.Location = new System.Drawing.Point(608, 199);
            this.productionWorkshopNumberTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.productionWorkshopNumberTextBox.Name = "productionWorkshopNumberTextBox";
            this.productionWorkshopNumberTextBox.Size = new System.Drawing.Size(268, 34);
            this.productionWorkshopNumberTextBox.TabIndex = 10;
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Title", true));
            this.titleTextBox.Location = new System.Drawing.Point(608, 15);
            this.titleTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.titleTextBox.MaxLength = 100;
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(268, 34);
            this.titleTextBox.TabIndex = 14;
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(12, 15);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(300, 300);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 15;
            this.pictureBox.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 471);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(131, 33);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(745, 471);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(131, 33);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(608, 471);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(131, 33);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // buttonImageChange
            // 
            this.buttonImageChange.Location = new System.Drawing.Point(12, 321);
            this.buttonImageChange.Name = "buttonImageChange";
            this.buttonImageChange.Size = new System.Drawing.Size(131, 33);
            this.buttonImageChange.TabIndex = 19;
            this.buttonImageChange.Text = "Изменить";
            this.buttonImageChange.UseVisualStyleBackColor = true;
            this.buttonImageChange.Click += new System.EventHandler(this.buttonImageChange_Click);
            // 
            // productTypeIDComboBox
            // 
            this.productTypeIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productTypeIDComboBox.FormattingEnabled = true;
            this.productTypeIDComboBox.Location = new System.Drawing.Point(608, 248);
            this.productTypeIDComboBox.Name = "productTypeIDComboBox";
            this.productTypeIDComboBox.Size = new System.Drawing.Size(268, 34);
            this.productTypeIDComboBox.TabIndex = 20;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.materialIDDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productMaterialBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(149, 347);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(443, 157);
            this.dataGridView1.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(152, 318);
            label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(123, 26);
            label1.TabIndex = 22;
            label1.Text = "Материалы:";
            // 
            // materialIDDataGridViewTextBoxColumn
            // 
            this.materialIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.materialIDDataGridViewTextBoxColumn.DataPropertyName = "MaterialID";
            this.materialIDDataGridViewTextBoxColumn.DataSource = this.materialBindingSource;
            this.materialIDDataGridViewTextBoxColumn.DisplayMember = "Title";
            this.materialIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.materialIDDataGridViewTextBoxColumn.HeaderText = "Материал";
            this.materialIDDataGridViewTextBoxColumn.Name = "materialIDDataGridViewTextBoxColumn";
            this.materialIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.materialIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.materialIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.materialIDDataGridViewTextBoxColumn.ValueMember = "ID";
            this.materialIDDataGridViewTextBoxColumn.Width = 127;
            // 
            // materialBindingSource
            // 
            this.materialBindingSource.DataSource = typeof(LopusokApp.Model.Material);
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "Count";
            this.countDataGridViewTextBoxColumn.HeaderText = "Кол-во";
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            this.countDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productMaterialBindingSource
            // 
            this.productMaterialBindingSource.DataSource = typeof(LopusokApp.Model.ProductMaterial);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(LopusokApp.Model.Product);
            // 
            // EditDeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 516);
            this.Controls.Add(label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.productTypeIDComboBox);
            this.Controls.Add(this.buttonImageChange);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(articleNumberLabel);
            this.Controls.Add(this.articleNumberTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(minCostForAgentLabel);
            this.Controls.Add(this.minCostForAgentTextBox);
            this.Controls.Add(productionPersonCountLabel);
            this.Controls.Add(this.productionPersonCountTextBox);
            this.Controls.Add(productionWorkshopNumberLabel);
            this.Controls.Add(this.productionWorkshopNumberTextBox);
            this.Controls.Add(productTypeIDLabel);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximumSize = new System.Drawing.Size(906, 555);
            this.MinimumSize = new System.Drawing.Size(906, 555);
            this.Name = "EditDeleteForm";
            this.Load += new System.EventHandler(this.EditDeleteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productMaterialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.TextBox articleNumberTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox minCostForAgentTextBox;
        private System.Windows.Forms.TextBox productionPersonCountTextBox;
        private System.Windows.Forms.TextBox productionWorkshopNumberTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button buttonImageChange;
        private System.Windows.Forms.ComboBox productTypeIDComboBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource productMaterialBindingSource;
        private System.Windows.Forms.BindingSource materialBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn materialIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
    }
}