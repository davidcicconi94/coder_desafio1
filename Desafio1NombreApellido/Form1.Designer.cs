namespace Desafio1NombreApellido
{
    partial class Form1
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
            student = new Label();
            button1 = new Button();
            name = new Label();
            lastname = new Label();
            dni = new Label();
            age = new Label();
            height = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            button2 = new Button();
            button3 = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // student
            // 
            student.AutoSize = true;
            student.BackColor = SystemColors.ActiveCaption;
            student.Location = new Point(131, 65);
            student.Margin = new Padding(4, 0, 4, 0);
            student.Name = "student";
            student.Size = new Size(69, 19);
            student.TabIndex = 0;
            student.Text = "Student ";
            student.Click += student1_Click;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(21, 378);
            button1.Name = "button1";
            button1.Size = new Size(108, 38);
            button1.TabIndex = 2;
            button1.Text = "Info";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(131, 115);
            name.Name = "name";
            name.Size = new Size(57, 19);
            name.TabIndex = 4;
            name.Text = "Name:";
            name.Click += name1_Click_1;
            // 
            // lastname
            // 
            lastname.AutoSize = true;
            lastname.Location = new Point(131, 153);
            lastname.Name = "lastname";
            lastname.Size = new Size(86, 19);
            lastname.TabIndex = 5;
            lastname.Text = "Lastname:";
            lastname.Click += lastname1_Click;
            // 
            // dni
            // 
            dni.AutoSize = true;
            dni.Location = new Point(131, 202);
            dni.Name = "dni";
            dni.Size = new Size(45, 19);
            dni.TabIndex = 6;
            dni.Text = "DNI:";
            dni.Click += dni1_Click;
            // 
            // age
            // 
            age.AutoSize = true;
            age.Location = new Point(131, 247);
            age.Name = "age";
            age.Size = new Size(43, 19);
            age.TabIndex = 7;
            age.Text = "Age:";
            // 
            // height
            // 
            height.AutoSize = true;
            height.Location = new Point(131, 295);
            height.Name = "height";
            height.Size = new Size(66, 19);
            height.TabIndex = 8;
            height.Text = "Height:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(566, 70);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 9;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(519, 73);
            label1.Name = "label1";
            label1.Size = new Size(41, 19);
            label1.TabIndex = 10;
            label1.Text = "N° 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(519, 118);
            label2.Name = "label2";
            label2.Size = new Size(41, 19);
            label2.TabIndex = 12;
            label2.Text = "N° 2";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(566, 115);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(505, 247);
            label3.Name = "label3";
            label3.Size = new Size(55, 19);
            label3.TabIndex = 14;
            label3.Text = "label3";
            label3.Visible = false;
            // 
            // button2
            // 
            button2.Location = new Point(566, 170);
            button2.Name = "button2";
            button2.Size = new Size(125, 29);
            button2.TabIndex = 15;
            button2.Text = "Sum";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(146, 378);
            button3.Name = "button3";
            button3.Size = new Size(109, 38);
            button3.TabIndex = 16;
            button3.Text = "Surname";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(276, 388);
            label4.Name = "label4";
            label4.Size = new Size(55, 19);
            label4.TabIndex = 17;
            label4.Text = "label4";
            label4.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 428);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(height);
            Controls.Add(age);
            Controls.Add(dni);
            Controls.Add(lastname);
            Controls.Add(name);
            Controls.Add(button1);
            Controls.Add(student);
            Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label student;
        private Button button1;
        private Label name;
        private Label lastname;
        private Label dni;
        private Label age;
        private Label height;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private Button button2;
        private Button button3;
        private Label label4;
    }
}
