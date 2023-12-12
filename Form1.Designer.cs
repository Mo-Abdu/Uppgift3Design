namespace InlämningsUppgift3Grafik
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
            personList = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            nameBox = new TextBox();
            livingBox = new TextBox();
            schoolBox = new TextBox();
            jobBox = new TextBox();
            addPersonButton = new Button();
            saveButton = new Button();
            loadButton = new Button();
            removeButton = new Button();
            openForm2Button = new Button();
            SuspendLayout();
            // 
            // personList
            // 
            personList.FormattingEnabled = true;
            personList.ItemHeight = 25;
            personList.Location = new Point(61, 38);
            personList.Name = "personList";
            personList.Size = new Size(180, 229);
            personList.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(416, 41);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(416, 88);
            label2.Name = "label2";
            label2.Size = new Size(58, 25);
            label2.TabIndex = 2;
            label2.Text = "Living";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(416, 137);
            label3.Name = "label3";
            label3.Size = new Size(66, 25);
            label3.TabIndex = 3;
            label3.Text = "School";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(416, 193);
            label4.Name = "label4";
            label4.Size = new Size(40, 25);
            label4.TabIndex = 4;
            label4.Text = "Job";
            // 
            // nameBox
            // 
            nameBox.Location = new Point(512, 38);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(150, 31);
            nameBox.TabIndex = 5;
            // 
            // livingBox
            // 
            livingBox.Location = new Point(512, 88);
            livingBox.Name = "livingBox";
            livingBox.Size = new Size(150, 31);
            livingBox.TabIndex = 6;
            // 
            // schoolBox
            // 
            schoolBox.Location = new Point(512, 137);
            schoolBox.Name = "schoolBox";
            schoolBox.Size = new Size(150, 31);
            schoolBox.TabIndex = 7;
            // 
            // jobBox
            // 
            jobBox.Location = new Point(512, 187);
            jobBox.Name = "jobBox";
            jobBox.Size = new Size(150, 31);
            jobBox.TabIndex = 8;
            // 
            // addPersonButton
            // 
            addPersonButton.Location = new Point(425, 269);
            addPersonButton.Name = "addPersonButton";
            addPersonButton.Size = new Size(112, 34);
            addPersonButton.TabIndex = 9;
            addPersonButton.Text = "Add";
            addPersonButton.UseVisualStyleBackColor = true;
            addPersonButton.Click += addPersonButton_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(588, 272);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(112, 34);
            saveButton.TabIndex = 10;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // loadButton
            // 
            loadButton.Location = new Point(425, 356);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(112, 34);
            loadButton.TabIndex = 11;
            loadButton.Text = "Load";
            loadButton.UseVisualStyleBackColor = true;
            loadButton.Click += loadButton_Click;
            // 
            // removeButton
            // 
            removeButton.Location = new Point(588, 356);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(112, 34);
            removeButton.TabIndex = 12;
            removeButton.Text = "Remove";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // openForm2Button
            // 
            openForm2Button.Location = new Point(189, 356);
            openForm2Button.Name = "openForm2Button";
            openForm2Button.Size = new Size(112, 34);
            openForm2Button.TabIndex = 13;
            openForm2Button.Text = "Go to Form2";
            openForm2Button.UseVisualStyleBackColor = true;
            openForm2Button.Click += openForm2Button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(openForm2Button);
            Controls.Add(removeButton);
            Controls.Add(loadButton);
            Controls.Add(saveButton);
            Controls.Add(addPersonButton);
            Controls.Add(jobBox);
            Controls.Add(schoolBox);
            Controls.Add(livingBox);
            Controls.Add(nameBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(personList);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox personList;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox nameBox;
        private TextBox livingBox;
        private TextBox schoolBox;
        private TextBox jobBox;
        private Button addPersonButton;
        private Button saveButton;
        private Button loadButton;
        private Button removeButton;
        private Button openForm2Button;
    }
}