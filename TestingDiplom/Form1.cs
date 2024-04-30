using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace TestingDiplom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string TxtCon = @"Data Source=213.155.192.79,3002;Initial Catalog=BDTesting;Persist Security Info=True;User ID=u21volod;Password=by4v";

        int SelectedTest = -1;
        int Count = 1;
        private void Form1_Load(object sender, EventArgs e)
        {
            BtnSave.Enabled = false;
            Count= 1;
            ClearTextBoxes();
            SelectedTest = -1;
            SqlConnection Con = new SqlConnection(TxtCon);
            SqlCommand Cmd = new SqlCommand("select * from Tests",Con);
            Con.Open();
            SqlDataReader Res = Cmd.ExecuteReader();
            PanelTests.Controls.Clear();
            if (Res.HasRows)
                while(Res.Read())
                {
                    RefreshPanel();
                }
            Con.Close();
        }

        void RefreshPanel()
        {
            int PosX = PanelTests.Controls.Count;
            Button Btn = new Button();
            Btn.BackColor = System.Drawing.Color.Gainsboro;
            Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            Btn.Location = new System.Drawing.Point(6 + PosX * 6 + PosX * 69, 3);
            Btn.Name = "Btn_" + Count;
            Btn.Size = new System.Drawing.Size(69, 59);
            Btn.TabIndex = 0;
            Btn.Text = $"{Count}";
            Btn.UseVisualStyleBackColor = false;
            Btn.Click += Btn_Click;
            PanelTests.Controls.Add(Btn);
            Count++;
        }

        private void ClearTextBoxes()
        {
            TbxNameOfTest.Clear();
            TbxQuestion.Clear();
            TbxAnswer1.Clear();
            TbxAnswer2.Clear();
            TbxAnswer3.Clear();
            NumBall.Value = 0;
            NumCurrentAnswer.Value = 0;
            CmbSubjArea.SelectedIndex = -1;
        }


        private void Btn_Click(object sender, EventArgs e)
        {
            CmbSubjArea.Enabled = false;
            Button clickedButton = sender as Button;
            string BtnText = clickedButton.Text;
            SqlConnection Con = new SqlConnection(TxtCon);
            SqlCommand Cmd = new SqlCommand($"select * from Tests where {BtnText} = NumOfTest", Con);
            Con.Open();
            SqlDataReader Res = Cmd.ExecuteReader();
            if (Res.HasRows)
            {
                Res.Read();
                try
                {
                    PbxPhoto.Image = Image.FromFile(Application.StartupPath +"\\Photo\\"+ Res["Photo"]);
                }
                catch { PbxPhoto.Image = Image.FromFile(Application.StartupPath + "\\Photo\\" + "Test.png"); };
                CmbSubjArea.SelectedIndex = int.Parse(Res["IdCategory"].ToString())-1;
                TbxNameOfTest.Text = Res["NameTest"].ToString();
                NumBall.Value = int.Parse(Res["BallForOne"].ToString());
                TbxQuestion.Text = Res["Question"].ToString();
                TbxAnswer1.Text = Res["AnswerOptions"].ToString().Split(' ')[0];    
                TbxAnswer2.Text = Res["AnswerOptions"].ToString().Split(' ')[1];    
                TbxAnswer3.Text = Res["AnswerOptions"].ToString().Split(' ')[2];
                NumCurrentAnswer.Value = int.Parse(Res["CurrentAnswer"].ToString());
            }
            Con.Close();
            SelectedTest = int.Parse(BtnText);

            BtnSave.Enabled = true;
            BtnSave.BackColor = Color.ForestGreen;
            BtnSave.ForeColor = Color.White;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {

        }

        private void TbxAnswer1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
                e.Handled = true;
        }

        private void BtnAddTest_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Желаете ли вы добавить новый вопрос для теста","Внимание!",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                this.Refresh();
                Form1_Load(null, null);
                BtnSave.Enabled = true;
                this.ActiveControl = null;
                BtnAddTest.Enabled = false;
                BtnDelTest.Enabled = false;
                CmbSubjArea.Enabled = true;
                PanelTests.Enabled = false;
                BtnSave.BackColor = Color.ForestGreen;
                BtnSave.ForeColor = Color.White;
            }


        }

        string PhotoName = "Test.png";
        private void BtnSave_Click(object sender, EventArgs e)
        {             
            if (!(CmbSubjArea.SelectedIndex == -1 || TbxNameOfTest.Text.Trim() == "" || TbxQuestion.Text.Trim() == "" || TbxAnswer1.Text.Trim() == "" || TbxAnswer2.Text.Trim() == "" || TbxAnswer3.Text.Trim() == "" || NumCurrentAnswer.Value == 0) && PanelTests.Enabled == false)
            {
                SqlConnection Con = new SqlConnection(TxtCon);
                SqlCommand Cmd = new SqlCommand($"insert into Tests (IdCategory, NameTest, NumOfTest, Question, AnswerOptions, CurrentAnswer, BallForOne, Photo) values ('{CmbSubjArea.SelectedIndex + 1}','{TbxNameOfTest.Text}', '{Count}','{TbxQuestion.Text}', '{TbxAnswer1.Text.Trim() + " " + TbxAnswer2.Text.Trim() + " " + TbxAnswer3.Text.Trim()}', '{NumCurrentAnswer.Value}', '{NumBall.Value}', '{PhotoName}')", Con);
                Con.Open();
                Cmd.ExecuteNonQuery();
                Con.Close();

                this.Refresh();
                Form1_Load(null, null);
                CmbSubjArea.Enabled = false;
                PanelTests.Enabled = true;
                BtnSave.BackColor = Color.Gainsboro;
                BtnSave.ForeColor = Color.Black;
                BtnAddTest.Enabled = true;
                BtnDelTest.Enabled = true;
            }
            else if (!(CmbSubjArea.SelectedIndex == -1 || TbxNameOfTest.Text.Trim() == "" || TbxQuestion.Text.Trim() == "" || TbxAnswer1.Text.Trim() == "" || TbxAnswer2.Text.Trim() == "" || TbxAnswer3.Text.Trim() == "" || NumCurrentAnswer.Value == 0) && PanelTests.Enabled == true)
            {
                SqlConnection Con = new SqlConnection(TxtCon);
                SqlCommand Cmd = new SqlCommand($"update Tests set IdCategory= '{CmbSubjArea.SelectedIndex + 1}', NameTest= '{TbxNameOfTest.Text}', Question= '{TbxQuestion.Text}', AnswerOptions ='{TbxAnswer1.Text.Trim() + " " + TbxAnswer2.Text.Trim() + " " + TbxAnswer3.Text.Trim()}', CurrentAnswer='{NumCurrentAnswer.Value}', BallForOne= '{NumBall.Value}', Photo ='{PhotoName}' where NumOfTest='{SelectedTest}'", Con);
                Con.Open();
                Cmd.ExecuteNonQuery();
                Con.Close();
                this.Refresh();
                Form1_Load(null, null);
                BtnSave.BackColor = Color.Gainsboro;
                BtnSave.ForeColor = Color.Black;
                BtnSave.Enabled = false;
                MessageBox.Show("Данные теста изменены");

            }
            else MessageBox.Show("Некорректный ввод данных");

        }

        private void BtnDelTest_Click(object sender, EventArgs e)
        {
            if (PanelTests.Enabled == false)
            {
                this.Refresh();
                Form1_Load(null, null);
                PanelTests.Enabled = true;
                ClearTextBoxes();
                BtnSave.BackColor = Color.Gainsboro;
                BtnSave.ForeColor = Color.Black;
            } 
            else
            {
                DialogResult rs = MessageBox.Show("Желаете ли вы удалить вопрос теста?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    Count--;
                    SqlConnection Con = new SqlConnection(TxtCon);
                    SqlCommand Cmd = new SqlCommand($"delete from Tests where NumOfTest={Count}", Con);
                    Con.Open();
                    Cmd.ExecuteNonQuery();
                    Con.Close();

                    this.Refresh();
                    Form1_Load(null, null);
                    CmbSubjArea.Enabled = false;
                    PanelTests.Enabled = true;
                }
            }
                
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CmbSubjArea_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape && BtnAddTest.Enabled==false)
            {
                DialogResult rs = MessageBox.Show("Отменить добавление вопроса теста?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    BtnSave.Enabled = false;
                    this.ActiveControl = null;
                    BtnAddTest.Enabled = true;
                    BtnDelTest.Enabled = true;
                    CmbSubjArea.Enabled = true;
                    PanelTests.Enabled = true;
                    BtnSave.BackColor = Color.Gainsboro;
                    BtnSave.ForeColor = Color.Black;
                }
            }
        }
        private void Form1_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void PbxPhoto_DoubleClick(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.png)|*.png";
                openFileDialog.Title = "Выберите изображение";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string selectedFile = openFileDialog.FileName;
                        PbxPhoto.Image = Image.FromFile(selectedFile);
                        PhotoName = selectedFile.Substring(selectedFile.LastIndexOf('\\')+1);

                        string debugFolderPath = Path.Combine(Application.StartupPath, "\\Photo");

                        string debugFilePath = Path.Combine(debugFolderPath, Path.GetFileName(selectedFile));

                        File.Copy(selectedFile, Application.StartupPath+debugFilePath, true);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при открытии файла: " + ex.Message);
                    }
                }
            }
        }

        private void TbxLoad_Click(object sender, EventArgs e)
        {

        }
    }
}
