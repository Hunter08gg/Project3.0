namespace PersonalFinanceTracker
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            label12 = new Label();
            dateTimePicker = new DateTimePicker();
            comboBoxCategory = new ComboBox();
            label3 = new Label();
            textBoxAmount = new TextBox();
            label2 = new Label();
            buttonAdd = new Button();
            comboBoxType = new ComboBox();
            label1 = new Label();
            label4 = new Label();
            textBoxBalance = new TextBox();
            dataGridViewOperations = new DataGridView();
            buttonUpdateBalance = new Button();
            buttonDelete = new Button();
            buttonManageCategories = new Button();
            groupBox2 = new GroupBox();
            label13 = new Label();
            label8 = new Label();
            comboBoxMonth = new ComboBox();
            label10 = new Label();
            label9 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            lblExpensesThisMonth = new Label();
            lblIncomeThisMonth = new Label();
            lblBalanceThisMonth = new Label();
            lblExpensesLastMonth = new Label();
            lblIncomeLastMonth = new Label();
            groupBox3 = new GroupBox();
            comboBoxChartType = new ComboBox();
            label11 = new Label();
            panelChart = new Panel();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOperations).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(dateTimePicker);
            groupBox1.Controls.Add(comboBoxCategory);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBoxAmount);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(buttonAdd);
            groupBox1.Controls.Add(comboBoxType);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(360, 150);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Добавление операции";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(0, 23);
            label12.Name = "label12";
            label12.Size = new Size(35, 15);
            label12.TabIndex = 8;
            label12.Text = "Дата:";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(48, 20);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(113, 23);
            dateTimePicker.TabIndex = 7;
            dateTimePicker.ValueChanged += dateTimePicker_ValueChanged;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(242, 64);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(100, 23);
            comboBoxCategory.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(164, 68);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 5;
            label3.Text = "Категория:";
            label3.Click += label3_Click;
            // 
            // textBoxAmount
            // 
            textBoxAmount.Location = new Point(242, 20);
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.Size = new Size(100, 23);
            textBoxAmount.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(182, 23);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 3;
            label2.Text = "Сумма:";
            label2.Click += label2_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(48, 102);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(294, 30);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // comboBoxType
            // 
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Location = new Point(48, 64);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(100, 23);
            comboBoxType.TabIndex = 2;
            comboBoxType.SelectedIndexChanged += comboBoxType_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 68);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 1;
            label1.Text = "Тип:";
            label1.Click += label1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(400, 30);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 1;
            label4.Text = "Доход:";
            // 
            // textBoxBalance
            // 
            textBoxBalance.Location = new Point(500, 27);
            textBoxBalance.Name = "textBoxBalance";
            textBoxBalance.ReadOnly = true;
            textBoxBalance.Size = new Size(100, 23);
            textBoxBalance.TabIndex = 2;
            textBoxBalance.Text = "0";
            // 
            // dataGridViewOperations
            // 
            dataGridViewOperations.AllowUserToAddRows = false;
            dataGridViewOperations.AllowUserToDeleteRows = false;
            dataGridViewOperations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOperations.Location = new Point(12, 180);
            dataGridViewOperations.Name = "dataGridViewOperations";
            dataGridViewOperations.ReadOnly = true;
            dataGridViewOperations.Size = new Size(600, 200);
            dataGridViewOperations.TabIndex = 3;
            // 
            // buttonUpdateBalance
            // 
            buttonUpdateBalance.Location = new Point(400, 60);
            buttonUpdateBalance.Name = "buttonUpdateBalance";
            buttonUpdateBalance.Size = new Size(200, 30);
            buttonUpdateBalance.TabIndex = 4;
            buttonUpdateBalance.Text = "Обновить баланс";
            buttonUpdateBalance.UseVisualStyleBackColor = true;
            buttonUpdateBalance.Click += buttonUpdateBalance_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(400, 100);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(200, 30);
            buttonDelete.TabIndex = 5;
            buttonDelete.Text = "Удалить запись";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonManageCategories
            // 
            buttonManageCategories.Location = new Point(400, 140);
            buttonManageCategories.Name = "buttonManageCategories";
            buttonManageCategories.Size = new Size(200, 30);
            buttonManageCategories.TabIndex = 6;
            buttonManageCategories.Text = "Категории";
            buttonManageCategories.UseVisualStyleBackColor = true;
            buttonManageCategories.Click += buttonManageCategories_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(comboBoxMonth);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(lblExpensesThisMonth);
            groupBox2.Controls.Add(lblIncomeThisMonth);
            groupBox2.Controls.Add(lblBalanceThisMonth);
            groupBox2.Controls.Add(lblExpensesLastMonth);
            groupBox2.Controls.Add(lblIncomeLastMonth);
            groupBox2.Location = new Point(12, 390);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(600, 120);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Статистика ";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(0, 60);
            label13.Name = "label13";
            label13.Size = new Size(96, 15);
            label13.TabIndex = 13;
            label13.Text = "Текущий месяц:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(0, 30);
            label8.Name = "label8";
            label8.Size = new Size(90, 15);
            label8.TabIndex = 12;
            label8.Text = "За все месяцы:";
            // 
            // comboBoxMonth
            // 
            comboBoxMonth.FormattingEnabled = true;
            comboBoxMonth.Location = new Point(52, 85);
            comboBoxMonth.Name = "comboBoxMonth";
            comboBoxMonth.Size = new Size(150, 23);
            comboBoxMonth.TabIndex = 11;
            comboBoxMonth.SelectedIndexChanged += comboBoxMonth_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(0, 88);
            label10.Name = "label10";
            label10.Size = new Size(46, 15);
            label10.TabIndex = 10;
            label10.Text = "Месяц:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(160, 60);
            label9.Name = "label9";
            label9.Size = new Size(44, 15);
            label9.TabIndex = 9;
            label9.Text = "Доход:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(333, 60);
            label7.Name = "label7";
            label7.Size = new Size(48, 15);
            label7.TabIndex = 7;
            label7.Text = "Расход:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(333, 30);
            label6.Name = "label6";
            label6.Size = new Size(59, 15);
            label6.TabIndex = 6;
            label6.Text = "Текущий:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(160, 30);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 5;
            label5.Text = "Текущий:";
            // 
            // lblExpensesThisMonth
            // 
            lblExpensesThisMonth.AutoSize = true;
            lblExpensesThisMonth.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblExpensesThisMonth.ForeColor = Color.Red;
            lblExpensesThisMonth.Location = new Point(435, 30);
            lblExpensesThisMonth.Name = "lblExpensesThisMonth";
            lblExpensesThisMonth.Size = new Size(24, 15);
            lblExpensesThisMonth.TabIndex = 4;
            lblExpensesThisMonth.Text = "0 ₽";
            // 
            // lblIncomeThisMonth
            // 
            lblIncomeThisMonth.AutoSize = true;
            lblIncomeThisMonth.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblIncomeThisMonth.ForeColor = Color.Green;
            lblIncomeThisMonth.Location = new Point(242, 30);
            lblIncomeThisMonth.Name = "lblIncomeThisMonth";
            lblIncomeThisMonth.Size = new Size(24, 15);
            lblIncomeThisMonth.TabIndex = 3;
            lblIncomeThisMonth.Text = "0 ₽";
            // 
            // lblBalanceThisMonth
            // 
            lblBalanceThisMonth.AutoSize = true;
            lblBalanceThisMonth.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblBalanceThisMonth.Location = new Point(87, 30);
            lblBalanceThisMonth.Name = "lblBalanceThisMonth";
            lblBalanceThisMonth.Size = new Size(24, 15);
            lblBalanceThisMonth.TabIndex = 2;
            lblBalanceThisMonth.Text = "0 ₽";
            // 
            // lblExpensesLastMonth
            // 
            lblExpensesLastMonth.AutoSize = true;
            lblExpensesLastMonth.ForeColor = Color.Red;
            lblExpensesLastMonth.Location = new Point(435, 60);
            lblExpensesLastMonth.Name = "lblExpensesLastMonth";
            lblExpensesLastMonth.Size = new Size(22, 15);
            lblExpensesLastMonth.TabIndex = 1;
            lblExpensesLastMonth.Text = "0 ₽";
            lblExpensesLastMonth.Click += lblExpensesLastMonth_Click;
            // 
            // lblIncomeLastMonth
            // 
            lblIncomeLastMonth.AutoSize = true;
            lblIncomeLastMonth.ForeColor = Color.Green;
            lblIncomeLastMonth.Location = new Point(244, 60);
            lblIncomeLastMonth.Name = "lblIncomeLastMonth";
            lblIncomeLastMonth.Size = new Size(22, 15);
            lblIncomeLastMonth.TabIndex = 0;
            lblIncomeLastMonth.Text = "0 ₽";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(comboBoxChartType);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(panelChart);
            groupBox3.Location = new Point(630, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(400, 498);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Диаграмма";
            // 
            // comboBoxChartType
            // 
            comboBoxChartType.FormattingEnabled = true;
            comboBoxChartType.Items.AddRange(new object[] { "Доходы по категориям", "Расходы по категориям", "Общая статистика" });
            comboBoxChartType.Location = new Point(95, 28);
            comboBoxChartType.Name = "comboBoxChartType";
            comboBoxChartType.Size = new Size(200, 23);
            comboBoxChartType.TabIndex = 2;
            comboBoxChartType.SelectedIndexChanged += comboBoxChartType_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(10, 28);
            label11.Name = "label11";
            label11.Size = new Size(79, 15);
            label11.TabIndex = 1;
            label11.Text = "Тип графика:";
            // 
            // panelChart
            // 
            panelChart.Location = new Point(10, 60);
            panelChart.Name = "panelChart";
            panelChart.Size = new Size(380, 430);
            panelChart.TabIndex = 0;
            panelChart.Paint += panelChart_Paint;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1042, 522);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(buttonManageCategories);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdateBalance);
            Controls.Add(dataGridViewOperations);
            Controls.Add(textBoxBalance);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Name = "MainForm";
            Text = "Учет личных финансов";
            Load += MainForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOperations).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private DateTimePicker dateTimePicker;
        private ComboBox comboBoxCategory;
        private Label label3;
        private TextBox textBoxAmount;
        private Label label2;
        private ComboBox comboBoxType;
        private Label label1;
        private Button buttonAdd;
        private Label label4;
        private TextBox textBoxBalance;
        private DataGridView dataGridViewOperations;
        private Button buttonUpdateBalance;
        private Button buttonDelete;
        private Button buttonManageCategories;
        private GroupBox groupBox2;
        private Label lblExpensesThisMonth;
        private Label lblIncomeThisMonth;
        private Label lblBalanceThisMonth;
        private Label lblExpensesLastMonth;
        private Label lblIncomeLastMonth;
        private Label label9;
        private Label label7;
        private Label label6;
        private Label label5;
        private ComboBox comboBoxMonth;
        private Label label10;
        private GroupBox groupBox3;
        private Panel panelChart;
        private ComboBox comboBoxChartType;
        private Label label11;
        private Label label8;
        private Label label12;
        private Label label13;
    }
}