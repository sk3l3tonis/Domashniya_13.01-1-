namespace ContactBook
{
    partial class ContactManagement
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            Add = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            pplname = new Label();
            mobilenumber = new Label();
            addbutton = new Button();
            pictureBox1 = new PictureBox();
            editbutton = new Button();
            idnumber = new Label();
            textBox3 = new TextBox();
            deletebutton = new Button();
            searchbutton = new Button();
            updatebutton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.Size = new Size(499, 426);
            dataGridView1.TabIndex = 0;
            // 
            // Add
            // 
            Add.AutoSize = true;
            Add.BackColor = SystemColors.ActiveCaption;
            Add.Font = new Font("Segoe UI", 10F);
            Add.Location = new Point(590, 21);
            Add.Name = "Add";
            Add.Size = new Size(266, 23);
            Add.TabIndex = 1;
            Add.Text = "Форма для работы с контактами";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Info;
            textBox1.Location = new Point(665, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(213, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Info;
            textBox2.Location = new Point(665, 87);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(213, 27);
            textBox2.TabIndex = 3;
            // 
            // pplname
            // 
            pplname.AutoSize = true;
            pplname.BackColor = SystemColors.ActiveCaption;
            pplname.Location = new Point(613, 57);
            pplname.Name = "pplname";
            pplname.Size = new Size(45, 20);
            pplname.TabIndex = 4;
            pplname.Text = "ФИО:";
            // 
            // mobilenumber
            // 
            mobilenumber.AutoSize = true;
            mobilenumber.BackColor = SystemColors.ActiveCaption;
            mobilenumber.Location = new Point(528, 90);
            mobilenumber.Name = "mobilenumber";
            mobilenumber.Size = new Size(130, 20);
            mobilenumber.TabIndex = 5;
            mobilenumber.Text = "Номер телефона:";
            // 
            // addbutton
            // 
            addbutton.Location = new Point(576, 165);
            addbutton.Name = "addbutton";
            addbutton.Size = new Size(291, 31);
            addbutton.TabIndex = 6;
            addbutton.Text = "Добавить";
            addbutton.UseVisualStyleBackColor = true;
            addbutton.Click += addbutton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(517, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(407, 426);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // editbutton
            // 
            editbutton.Location = new Point(576, 202);
            editbutton.Name = "editbutton";
            editbutton.Size = new Size(291, 31);
            editbutton.TabIndex = 8;
            editbutton.Text = "Редактировать";
            editbutton.UseVisualStyleBackColor = true;
            editbutton.Click += updatebutton_Click;
            // 
            // idnumber
            // 
            idnumber.AutoSize = true;
            idnumber.BackColor = SystemColors.ActiveCaption;
            idnumber.Location = new Point(579, 123);
            idnumber.Name = "idnumber";
            idnumber.Size = new Size(79, 20);
            idnumber.TabIndex = 9;
            idnumber.Text = "ID-номер:";
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.Info;
            textBox3.Location = new Point(665, 120);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(213, 27);
            textBox3.TabIndex = 10;
            // 
            // deletebutton
            // 
            deletebutton.Location = new Point(576, 239);
            deletebutton.Name = "deletebutton";
            deletebutton.Size = new Size(291, 31);
            deletebutton.TabIndex = 11;
            deletebutton.Text = "Удаление";
            deletebutton.UseVisualStyleBackColor = true;
            deletebutton.Click += deletebutton_Click;
            // 
            // searchbutton
            // 
            searchbutton.Location = new Point(576, 276);
            searchbutton.Name = "searchbutton";
            searchbutton.Size = new Size(291, 31);
            searchbutton.TabIndex = 12;
            searchbutton.Text = "Найти контакт";
            searchbutton.UseVisualStyleBackColor = true;
            searchbutton.Click += searchbutton_Click;
            // 
            // updatebutton
            // 
            updatebutton.Location = new Point(547, 400);
            updatebutton.Name = "updatebutton";
            updatebutton.Size = new Size(348, 31);
            updatebutton.TabIndex = 13;
            updatebutton.Text = "Обновление таблицы";
            updatebutton.UseVisualStyleBackColor = true;
            updatebutton.Click += updatebutton_Click_1;
            // 
            // ContactManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 450);
            Controls.Add(updatebutton);
            Controls.Add(searchbutton);
            Controls.Add(deletebutton);
            Controls.Add(textBox3);
            Controls.Add(idnumber);
            Controls.Add(editbutton);
            Controls.Add(addbutton);
            Controls.Add(mobilenumber);
            Controls.Add(pplname);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(Add);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "ContactManagement";
            Text = "Работа с контактами";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label Add;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label pplname;
        private Label mobilenumber;
        private Button addbutton;
        private PictureBox pictureBox1;
        private Button editbutton;
        private Label idnumber;
        private TextBox textBox3;
        private Button deletebutton;
        private Button searchbutton;
        private Button updatebutton;
    }
}
