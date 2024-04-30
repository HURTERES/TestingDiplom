namespace TestingDiplom
{
    partial class Form1
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
            this.CmbSubjArea = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TbxNameOfTest = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PanelTests = new System.Windows.Forms.Panel();
            this.BtnAddTest = new System.Windows.Forms.Button();
            this.BtnDelTest = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.NumBall = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TbxQuestion = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.NumCurrentAnswer = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.TbxAnswer1 = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TbxAnswer2 = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TbxAnswer3 = new System.Windows.Forms.RichTextBox();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.TbxLoad = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PbxPhoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumCurrentAnswer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // CmbSubjArea
            // 
            this.CmbSubjArea.Enabled = false;
            this.CmbSubjArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CmbSubjArea.FormattingEnabled = true;
            this.CmbSubjArea.Items.AddRange(new object[] {
            "Математика",
            "Физика",
            "Биология"});
            this.CmbSubjArea.Location = new System.Drawing.Point(12, 78);
            this.CmbSubjArea.Name = "CmbSubjArea";
            this.CmbSubjArea.Size = new System.Drawing.Size(348, 33);
            this.CmbSubjArea.TabIndex = 0;
            this.CmbSubjArea.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CmbSubjArea_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Предметная область вопроса:";
            // 
            // TbxNameOfTest
            // 
            this.TbxNameOfTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxNameOfTest.Location = new System.Drawing.Point(12, 146);
            this.TbxNameOfTest.Name = "TbxNameOfTest";
            this.TbxNameOfTest.Size = new System.Drawing.Size(348, 31);
            this.TbxNameOfTest.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(13, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Название вопроса:";
            // 
            // PanelTests
            // 
            this.PanelTests.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelTests.Location = new System.Drawing.Point(12, 244);
            this.PanelTests.Name = "PanelTests";
            this.PanelTests.Size = new System.Drawing.Size(616, 69);
            this.PanelTests.TabIndex = 7;
            // 
            // BtnAddTest
            // 
            this.BtnAddTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnAddTest.Location = new System.Drawing.Point(634, 244);
            this.BtnAddTest.Name = "BtnAddTest";
            this.BtnAddTest.Size = new System.Drawing.Size(30, 30);
            this.BtnAddTest.TabIndex = 8;
            this.BtnAddTest.Text = "+";
            this.BtnAddTest.UseVisualStyleBackColor = true;
            this.BtnAddTest.Click += new System.EventHandler(this.BtnAddTest_Click);
            // 
            // BtnDelTest
            // 
            this.BtnDelTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnDelTest.Location = new System.Drawing.Point(634, 280);
            this.BtnDelTest.Name = "BtnDelTest";
            this.BtnDelTest.Size = new System.Drawing.Size(30, 29);
            this.BtnDelTest.TabIndex = 9;
            this.BtnDelTest.Text = "-";
            this.BtnDelTest.UseVisualStyleBackColor = true;
            this.BtnDelTest.Click += new System.EventHandler(this.BtnDelTest_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(13, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Номер вопроса:";
            // 
            // NumBall
            // 
            this.NumBall.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumBall.Location = new System.Drawing.Point(544, 319);
            this.NumBall.Name = "NumBall";
            this.NumBall.Size = new System.Drawing.Size(120, 31);
            this.NumBall.TabIndex = 11;
            this.NumBall.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(470, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Балл:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(13, 321);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "Вопрос:";
            // 
            // TbxQuestion
            // 
            this.TbxQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxQuestion.Location = new System.Drawing.Point(12, 356);
            this.TbxQuestion.Name = "TbxQuestion";
            this.TbxQuestion.Size = new System.Drawing.Size(652, 156);
            this.TbxQuestion.TabIndex = 14;
            this.TbxQuestion.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(461, 525);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(203, 25);
            this.label9.TabIndex = 15;
            this.label9.Text = "Правильный ответ:";
            // 
            // NumCurrentAnswer
            // 
            this.NumCurrentAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumCurrentAnswer.Location = new System.Drawing.Point(544, 553);
            this.NumCurrentAnswer.Name = "NumCurrentAnswer";
            this.NumCurrentAnswer.Size = new System.Drawing.Size(120, 31);
            this.NumCurrentAnswer.TabIndex = 16;
            this.NumCurrentAnswer.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(14, 525);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(201, 25);
            this.label10.TabIndex = 17;
            this.label10.Text = "Варианты ответов:";
            // 
            // TbxAnswer1
            // 
            this.TbxAnswer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxAnswer1.Location = new System.Drawing.Point(44, 553);
            this.TbxAnswer1.Name = "TbxAnswer1";
            this.TbxAnswer1.Size = new System.Drawing.Size(384, 58);
            this.TbxAnswer1.TabIndex = 18;
            this.TbxAnswer1.Text = "";
            this.TbxAnswer1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxAnswer1_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(7, 555);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 25);
            this.label11.TabIndex = 19;
            this.label11.Text = "1)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(7, 619);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 25);
            this.label12.TabIndex = 21;
            this.label12.Text = "2)";
            // 
            // TbxAnswer2
            // 
            this.TbxAnswer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxAnswer2.Location = new System.Drawing.Point(44, 617);
            this.TbxAnswer2.Name = "TbxAnswer2";
            this.TbxAnswer2.Size = new System.Drawing.Size(384, 58);
            this.TbxAnswer2.TabIndex = 20;
            this.TbxAnswer2.Text = "";
            this.TbxAnswer2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxAnswer1_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(7, 683);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 25);
            this.label13.TabIndex = 23;
            this.label13.Text = "3)";
            // 
            // TbxAnswer3
            // 
            this.TbxAnswer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxAnswer3.Location = new System.Drawing.Point(44, 681);
            this.TbxAnswer3.Name = "TbxAnswer3";
            this.TbxAnswer3.Size = new System.Drawing.Size(384, 58);
            this.TbxAnswer3.TabIndex = 22;
            this.TbxAnswer3.Text = "";
            this.TbxAnswer3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxAnswer1_KeyPress);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnExit.Location = new System.Drawing.Point(522, 744);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(142, 36);
            this.BtnExit.TabIndex = 10;
            this.BtnExit.Text = "Выход";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnSave.ForeColor = System.Drawing.Color.Black;
            this.BtnSave.Location = new System.Drawing.Point(374, 744);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(142, 36);
            this.BtnSave.TabIndex = 24;
            this.BtnSave.Text = "Сохранить";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // TbxLoad
            // 
            this.TbxLoad.BackColor = System.Drawing.Color.Gainsboro;
            this.TbxLoad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TbxLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxLoad.Location = new System.Drawing.Point(226, 745);
            this.TbxLoad.Name = "TbxLoad";
            this.TbxLoad.Size = new System.Drawing.Size(142, 36);
            this.TbxLoad.TabIndex = 25;
            this.TbxLoad.Text = "Загрузить";
            this.TbxLoad.UseVisualStyleBackColor = false;
            this.TbxLoad.Click += new System.EventHandler(this.TbxLoad_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(112, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(465, 33);
            this.label2.TabIndex = 26;
            this.label2.Text = "Централизованное тестирование";
            // 
            // PbxPhoto
            // 
            this.PbxPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbxPhoto.Location = new System.Drawing.Point(445, 50);
            this.PbxPhoto.Name = "PbxPhoto";
            this.PbxPhoto.Size = new System.Drawing.Size(183, 168);
            this.PbxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxPhoto.TabIndex = 27;
            this.PbxPhoto.TabStop = false;
            this.PbxPhoto.DoubleClick += new System.EventHandler(this.PbxPhoto_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 790);
            this.Controls.Add(this.PbxPhoto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TbxLoad);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.TbxAnswer3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TbxAnswer2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TbxAnswer1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.NumCurrentAnswer);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TbxQuestion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NumBall);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnDelTest);
            this.Controls.Add(this.BtnAddTest);
            this.Controls.Add(this.PanelTests);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TbxNameOfTest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbSubjArea);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.NumBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumCurrentAnswer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbSubjArea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbxNameOfTest;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel PanelTests;
        private System.Windows.Forms.Button BtnAddTest;
        private System.Windows.Forms.Button BtnDelTest;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown NumBall;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox TbxQuestion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown NumCurrentAnswer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox TbxAnswer1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox TbxAnswer2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox TbxAnswer3;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button TbxLoad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox PbxPhoto;
    }
}

