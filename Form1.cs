using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
namespace DIPS3
{
    public partial class MainForm : Form
    {
        private HashSet<int> wrongRow;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            wrongRow = new HashSet<int>();
        }

        private void Tabel_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            CheckRow(e.RowIndex);
        }

        private void WordBtn_Click(object sender, EventArgs e)
        {
            Student a=GetStudentInf();
            if (a != null)
            {
                Word.Export(a);
                var currentDirectory = Directory.GetCurrentDirectory();
                System.Diagnostics.Process.Start(Path.Combine(currentDirectory, "Карточка студента.docx"));
            }
            else MessageBox.Show("Поля пустые","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);

            
        }

        private void ExcelBtn_Click(object sender, EventArgs e)
        {
            /*Student a = GetStudentInf();
            File.Open(Word.Export(a), FileMode.Append);*/
        }

        private bool CheckRow(int rowIndex)
        {
            bool subjectCorrect, gradeCorrect;
            if (String.IsNullOrEmpty(Tabel[0, rowIndex].Value?.ToString()))
            {
                Tabel[0, rowIndex].ErrorText = "пустое поле";
                subjectCorrect = false;
            }
            else
            {
                Tabel[0, rowIndex].ErrorText = "";
                subjectCorrect = true;
            }

            int grade;
            if (!int.TryParse(Tabel[1, rowIndex].FormattedValue.ToString(),
                out grade) || grade < 2 || grade > 5)
            {
                Tabel[1, rowIndex].ErrorText = "от 2 до 5";
                gradeCorrect = false;
            }
            else
            {
                Tabel[1, rowIndex].ErrorText = "";
                gradeCorrect = true;
            }

            if (subjectCorrect && gradeCorrect) { wrongRow.Remove(rowIndex); return true; }
            else if (subjectCorrect == false || gradeCorrect == false) { wrongRow.Add(rowIndex);  }
            return false;
        }
        private Student GetStudentInf()
        {
            if (String.IsNullOrEmpty(fioTextBox.Text) ||
                    String.IsNullOrEmpty(phoneTextBox.Text) ||
                    String.IsNullOrEmpty(addressTextBox.Text)
                )
            { return null; }
            Student result=new Student(fioTextBox.Text, phoneTextBox.Text, addressTextBox.Text);
            for (int i = 0; i < Tabel.RowCount; i++)
            {
                if (CheckRow(i)) result.Grades[Tabel[0, i].Value.ToString()] = int.Parse( Tabel[1, i].Value.ToString());
            }
            return result;

        }
    }
}
