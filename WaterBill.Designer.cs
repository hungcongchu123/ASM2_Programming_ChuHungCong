namespace WinFormsApp10
{
    partial class WaterBill
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
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtName = new TextBox();
            txtLastMonth = new TextBox();
            txtThisMonth = new TextBox();
            btnLogout = new Button();
            btnAdd = new Button();
            btnDelete = new Button();
            groupBox1 = new GroupBox();
            txtErase = new Button();
            txtWaterNumBer = new TextBox();
            label7 = new Label();
            txtPrices = new TextBox();
            label8 = new Label();
            BtnCaculate = new Button();
            btnClear = new Button();
            txtNumberFamily = new TextBox();
            label6 = new Label();
            comboboxtype = new ComboBox();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            txtFind = new TextBox();
            btnFind = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(242, -1);
            label1.Name = "label1";
            label1.Size = new Size(243, 30);
            label1.TabIndex = 0;
            label1.Text = "Welcome to Water Bill";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(0, 27);
            label2.Name = "label2";
            label2.Size = new Size(124, 20);
            label2.TabIndex = 2;
            label2.Text = "Customer name ";
            label2.Click += label2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 161);
            label4.Name = "label4";
            label4.Size = new Size(127, 19);
            label4.TabIndex = 4;
            label4.Text = "Water last month ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(0, 211);
            label5.Name = "label5";
            label5.Size = new Size(127, 19);
            label5.TabIndex = 5;
            label5.Text = "Water this month ";
            // 
            // txtName
            // 
            txtName.Location = new Point(145, 28);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(313, 26);
            txtName.TabIndex = 6;
            // 
            // txtLastMonth
            // 
            txtLastMonth.Location = new Point(145, 159);
            txtLastMonth.Margin = new Padding(3, 2, 3, 2);
            txtLastMonth.Name = "txtLastMonth";
            txtLastMonth.Size = new Size(313, 26);
            txtLastMonth.TabIndex = 8;
            // 
            // txtThisMonth
            // 
            txtThisMonth.Location = new Point(145, 206);
            txtThisMonth.Margin = new Padding(3, 2, 3, 2);
            txtThisMonth.Name = "txtThisMonth";
            txtThisMonth.Size = new Size(313, 26);
            txtThisMonth.TabIndex = 9;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(509, 27);
            btnLogout.Margin = new Padding(3, 2, 3, 2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(94, 34);
            btnLogout.TabIndex = 10;
            btnLogout.Text = "Logout ";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnAdd
            // 
            btnAdd.Enabled = false;
            btnAdd.Location = new Point(628, 28);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(116, 34);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(507, 106);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(107, 34);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete ";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtErase);
            groupBox1.Controls.Add(txtWaterNumBer);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtPrices);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(BtnCaculate);
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(txtNumberFamily);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(comboboxtype);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(btnLogout);
            groupBox1.Controls.Add(txtThisMonth);
            groupBox1.Controls.Add(txtLastMonth);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(10, 30);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(898, 267);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Calculate water bill";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtErase
            // 
            txtErase.Location = new Point(653, 106);
            txtErase.Margin = new Padding(3, 2, 3, 2);
            txtErase.Name = "txtErase";
            txtErase.Size = new Size(92, 34);
            txtErase.TabIndex = 23;
            txtErase.Text = "Clean";
            txtErase.UseVisualStyleBackColor = true;
            txtErase.Click += button1_Click;
            // 
            // txtWaterNumBer
            // 
            txtWaterNumBer.Location = new Point(780, 208);
            txtWaterNumBer.Margin = new Padding(3, 2, 3, 2);
            txtWaterNumBer.Multiline = true;
            txtWaterNumBer.Name = "txtWaterNumBer";
            txtWaterNumBer.Size = new Size(112, 31);
            txtWaterNumBer.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(780, 171);
            label7.Name = "label7";
            label7.Size = new Size(100, 19);
            label7.TabIndex = 21;
            label7.Text = "Water number";
            // 
            // txtPrices
            // 
            txtPrices.Location = new Point(619, 181);
            txtPrices.Margin = new Padding(3, 2, 3, 2);
            txtPrices.Multiline = true;
            txtPrices.Name = "txtPrices";
            txtPrices.Size = new Size(137, 73);
            txtPrices.TabIndex = 20;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(653, 161);
            label8.Name = "label8";
            label8.Size = new Size(45, 19);
            label8.TabIndex = 19;
            label8.Text = "Prices";
            // 
            // BtnCaculate
            // 
            BtnCaculate.Location = new Point(480, 201);
            BtnCaculate.Margin = new Padding(3, 2, 3, 2);
            BtnCaculate.Name = "BtnCaculate";
            BtnCaculate.Size = new Size(134, 36);
            BtnCaculate.TabIndex = 18;
            BtnCaculate.Text = "Caculate";
            BtnCaculate.UseVisualStyleBackColor = true;
            BtnCaculate.Click += BtnCaculate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(766, 28);
            btnClear.Margin = new Padding(3, 2, 3, 2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(97, 34);
            btnClear.TabIndex = 16;
            btnClear.Text = "Exit";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // txtNumberFamily
            // 
            txtNumberFamily.Enabled = false;
            txtNumberFamily.Location = new Point(199, 118);
            txtNumberFamily.Margin = new Padding(3, 2, 3, 2);
            txtNumberFamily.Name = "txtNumberFamily";
            txtNumberFamily.Size = new Size(260, 26);
            txtNumberFamily.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(3, 118);
            label6.Name = "label6";
            label6.Size = new Size(183, 19);
            label6.TabIndex = 14;
            label6.Text = "Number Family Members ";
            // 
            // comboboxtype
            // 
            comboboxtype.FormattingEnabled = true;
            comboboxtype.Items.AddRange(new object[] { "Household Customer", "Administrative Agency", "Prodution Units ", "Business Services " });
            comboboxtype.Location = new Point(145, 68);
            comboboxtype.Margin = new Padding(3, 2, 3, 2);
            comboboxtype.Name = "comboboxtype";
            comboboxtype.Size = new Size(313, 27);
            comboboxtype.TabIndex = 13;
            comboboxtype.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 68);
            label3.Name = "label3";
            label3.Size = new Size(107, 19);
            label3.TabIndex = 3;
            label3.Text = "Customer type";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.HighlightText;
            dataGridView1.Location = new Point(5, 336);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(849, 170);
            dataGridView1.TabIndex = 14;
            // 
            // txtFind
            // 
            txtFind.Location = new Point(5, 308);
            txtFind.Name = "txtFind";
            txtFind.Size = new Size(183, 23);
            txtFind.TabIndex = 15;
            // 
            // btnFind
            // 
            btnFind.Location = new Point(194, 307);
            btnFind.Margin = new Padding(3, 2, 3, 2);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(73, 23);
            btnFind.TabIndex = 24;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // WaterBill
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 514);
            Controls.Add(btnFind);
            Controls.Add(txtFind);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "WaterBill";
            Text = "WaterBill";
            Load += WaterBill_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private TextBox txtName;
        private TextBox txtLastMonth;
        private TextBox txtThisMonth;
        private Button btnLogout;
        private Button btnAdd;
        private Button btnDelete;
        private GroupBox groupBox1;
        private Label label3;
        private ComboBox comboboxtype;
        private Label label6;
        private TextBox txtNumberFamily;
        private Button btnClear;
        private Button BtnCaculate;
        private TextBox txtPrices;
        private Label label8;
        private Label label7;
        private TextBox txtWaterNumBer;
        private DataGridView dataGridView1;
        private Button txtErase;
        private TextBox txtFind;
        private Button btnFind;
    }
}