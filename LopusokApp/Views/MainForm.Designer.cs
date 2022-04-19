namespace LopusokApp.Views
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.layoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.orderBy = new System.Windows.Forms.CheckBox();
            this.sortingCB = new System.Windows.Forms.ComboBox();
            this.filteringCB = new System.Windows.Forms.ComboBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.productTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutPanel
            // 
            this.layoutPanel.AutoScroll = true;
            this.layoutPanel.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.layoutPanel.Location = new System.Drawing.Point(0, 74);
            this.layoutPanel.Name = "layoutPanel";
            this.layoutPanel.Size = new System.Drawing.Size(1134, 564);
            this.layoutPanel.TabIndex = 0;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelTop.Controls.Add(this.orderBy);
            this.panelTop.Controls.Add(this.sortingCB);
            this.panelTop.Controls.Add(this.filteringCB);
            this.panelTop.Controls.Add(this.searchTextBox);
            this.panelTop.Controls.Add(this.pictureBox);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1134, 75);
            this.panelTop.TabIndex = 1;
            // 
            // orderBy
            // 
            this.orderBy.AutoSize = true;
            this.orderBy.Location = new System.Drawing.Point(605, 22);
            this.orderBy.Name = "orderBy";
            this.orderBy.Size = new System.Drawing.Size(160, 30);
            this.orderBy.TabIndex = 3;
            this.orderBy.Text = "По убыванию";
            this.orderBy.UseVisualStyleBackColor = true;
            this.orderBy.CheckedChanged += new System.EventHandler(this.orderBy_CheckedChanged);
            // 
            // sortingCB
            // 
            this.sortingCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortingCB.FormattingEnabled = true;
            this.sortingCB.Items.AddRange(new object[] {
            "Без сортировки",
            "Наименование",
            "Мин. стоимость"});
            this.sortingCB.Location = new System.Drawing.Point(375, 20);
            this.sortingCB.Name = "sortingCB";
            this.sortingCB.Size = new System.Drawing.Size(224, 34);
            this.sortingCB.TabIndex = 2;
            this.sortingCB.SelectedIndexChanged += new System.EventHandler(this.sortingCB_SelectedIndexChanged);
            // 
            // filteringCB
            // 
            this.filteringCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filteringCB.FormattingEnabled = true;
            this.filteringCB.Location = new System.Drawing.Point(771, 20);
            this.filteringCB.Name = "filteringCB";
            this.filteringCB.Size = new System.Drawing.Size(251, 34);
            this.filteringCB.TabIndex = 2;
            this.filteringCB.SelectedIndexChanged += new System.EventHandler(this.filteringCB_SelectedIndexChanged);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(80, 20);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(289, 34);
            this.searchTextBox.TabIndex = 1;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::LopusokApp.Properties.Resources.Logo;
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(50, 50);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelBottom.Controls.Add(this.buttonExit);
            this.panelBottom.Controls.Add(this.buttonAdd);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 636);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1134, 75);
            this.panelBottom.TabIndex = 2;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(935, 8);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(187, 55);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "Выйти";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 8);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(187, 55);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // productTypeBindingSource
            // 
            this.productTypeBindingSource.DataSource = typeof(LopusokApp.Model.ProductType);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1134, 711);
            this.Controls.Add(this.layoutPanel);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1150, 750);
            this.MinimumSize = new System.Drawing.Size(1150, 750);
            this.Name = "MainForm";
            this.Text = "Лопушок";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productTypeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel layoutPanel;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.ComboBox sortingCB;
        private System.Windows.Forms.ComboBox filteringCB;
        private System.Windows.Forms.CheckBox orderBy;
        private System.Windows.Forms.BindingSource productTypeBindingSource;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonExit;
    }
}