namespace zh_AIYA4A
{
    partial class UserControl3
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.peopleIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.terméknévDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.személyNévDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mennyiségDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.egységárDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peopleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.buttonHozzáadás = new System.Windows.Forms.Button();
            this.buttonTörlés = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(269, 23);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.peopleIdDataGridViewTextBoxColumn,
            this.productIdDataGridViewTextBoxColumn,
            this.terméknévDataGridViewTextBoxColumn,
            this.személyNévDataGridViewTextBoxColumn,
            this.mennyiségDataGridViewTextBoxColumn,
            this.egységárDataGridViewTextBoxColumn,
            this.peopleDataGridViewTextBoxColumn,
            this.productDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.orderBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(278, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(644, 460);
            this.dataGridView1.TabIndex = 4;
            // 
            // peopleIdDataGridViewTextBoxColumn
            // 
            this.peopleIdDataGridViewTextBoxColumn.DataPropertyName = "PeopleId";
            this.peopleIdDataGridViewTextBoxColumn.HeaderText = "PeopleId";
            this.peopleIdDataGridViewTextBoxColumn.Name = "peopleIdDataGridViewTextBoxColumn";
            this.peopleIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            this.productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            this.productIdDataGridViewTextBoxColumn.HeaderText = "ProductId";
            this.productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            this.productIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // terméknévDataGridViewTextBoxColumn
            // 
            this.terméknévDataGridViewTextBoxColumn.DataPropertyName = "Terméknév";
            this.terméknévDataGridViewTextBoxColumn.HeaderText = "Terméknév";
            this.terméknévDataGridViewTextBoxColumn.Name = "terméknévDataGridViewTextBoxColumn";
            this.terméknévDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // személyNévDataGridViewTextBoxColumn
            // 
            this.személyNévDataGridViewTextBoxColumn.DataPropertyName = "SzemélyNév";
            this.személyNévDataGridViewTextBoxColumn.HeaderText = "SzemélyNév";
            this.személyNévDataGridViewTextBoxColumn.Name = "személyNévDataGridViewTextBoxColumn";
            this.személyNévDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mennyiségDataGridViewTextBoxColumn
            // 
            this.mennyiségDataGridViewTextBoxColumn.DataPropertyName = "Mennyiség";
            this.mennyiségDataGridViewTextBoxColumn.HeaderText = "Mennyiség";
            this.mennyiségDataGridViewTextBoxColumn.Name = "mennyiségDataGridViewTextBoxColumn";
            this.mennyiségDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // egységárDataGridViewTextBoxColumn
            // 
            this.egységárDataGridViewTextBoxColumn.DataPropertyName = "Egységár";
            this.egységárDataGridViewTextBoxColumn.HeaderText = "Egységár";
            this.egységárDataGridViewTextBoxColumn.Name = "egységárDataGridViewTextBoxColumn";
            this.egységárDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // peopleDataGridViewTextBoxColumn
            // 
            this.peopleDataGridViewTextBoxColumn.DataPropertyName = "People";
            this.peopleDataGridViewTextBoxColumn.HeaderText = "People";
            this.peopleDataGridViewTextBoxColumn.Name = "peopleDataGridViewTextBoxColumn";
            this.peopleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productDataGridViewTextBoxColumn
            // 
            this.productDataGridViewTextBoxColumn.DataPropertyName = "Product";
            this.productDataGridViewTextBoxColumn.HeaderText = "Product";
            this.productDataGridViewTextBoxColumn.Name = "productDataGridViewTextBoxColumn";
            this.productDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(zh_AIYA4A.Models.Order);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(3, 56);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(269, 424);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(928, 30);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(268, 23);
            this.textBox2.TabIndex = 7;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // listBox2
            // 
            this.listBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(928, 59);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(268, 364);
            this.listBox2.TabIndex = 6;
            // 
            // buttonHozzáadás
            // 
            this.buttonHozzáadás.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHozzáadás.Location = new System.Drawing.Point(928, 433);
            this.buttonHozzáadás.Name = "buttonHozzáadás";
            this.buttonHozzáadás.Size = new System.Drawing.Size(114, 54);
            this.buttonHozzáadás.TabIndex = 8;
            this.buttonHozzáadás.Text = "Hozzáadás";
            this.buttonHozzáadás.UseVisualStyleBackColor = true;
            this.buttonHozzáadás.Click += new System.EventHandler(this.buttonHozzáadás_Click);
            // 
            // buttonTörlés
            // 
            this.buttonTörlés.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTörlés.Location = new System.Drawing.Point(1082, 429);
            this.buttonTörlés.Name = "buttonTörlés";
            this.buttonTörlés.Size = new System.Drawing.Size(114, 54);
            this.buttonTörlés.TabIndex = 9;
            this.buttonTörlés.Text = "Törlés";
            this.buttonTörlés.UseVisualStyleBackColor = true;
            this.buttonTörlés.Click += new System.EventHandler(this.buttonTörlés_Click);
            // 
            // UserControl3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.Controls.Add(this.buttonTörlés);
            this.Controls.Add(this.buttonHozzáadás);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listBox1);
            this.Name = "UserControl3";
            this.Size = new System.Drawing.Size(1199, 507);
            this.Load += new System.EventHandler(this.UserControl3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private DataGridView dataGridView1;
        private ListBox listBox1;
        private TextBox textBox2;
        private ListBox listBox2;
        private Button buttonHozzáadás;
        private Button buttonTörlés;
        private DataGridViewTextBoxColumn peopleIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn terméknévDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn személyNévDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mennyiségDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn egységárDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn peopleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private BindingSource orderBindingSource;
    }
}
