using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectSUDOKU
{
    public partial class FormGame : Form
    {
        int[,] field;
        int[,] field1;  //для проверки на пропавшее число
        int[,] field2; // игровое поле, которое заполняется
        int CellSize = 40;
        Random rnd = new Random();
        
        
        public FormGame()
        {
            InitializeComponent();
        }


        
        void CreateLevel()
        {
            dataGridViewLevel.RowTemplate.Height = CellSize;
            for (int i = 0; i < field.GetLength(1); i++)
            {
                dataGridViewLevel.Columns.Add("", "");
                dataGridViewLevel.Columns[i].Width = CellSize;
            }
            dataGridViewLevel.Rows.Add(field.GetLength(0));
            dataGridViewLevel.Width = field.GetLength(1) * (CellSize) + 3;
            dataGridViewLevel.Height = field.GetLength(0) * CellSize + 3;
        }


        void ShowLevel()
        {
            for(int i = 0; i < field.GetLength(0); i++)
            {
                for(int j = 0; j < field.GetLength(1); j++)
                {
                    field1[i, j] = field[i, j];
                    dataGridViewLevel.Rows[i].Cells[j].Value = field[i, j];
                    dataGridViewLevel.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(192, 192, 192);
                    dataGridViewLevel.Rows[i].Cells[j].Style.ForeColor = Color.Black;
                    
                }
            }
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int x = 0; x < 4; x++)
                {
                    int j = rnd.Next(0, 8);
                    dataGridViewLevel.Rows[i].Cells[j].Value = "";
                    dataGridViewLevel.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(220, 220, 220);
                    dataGridViewLevel.Rows[i].Cells[j].Style.ForeColor = Color.Orange;
                    field1[i, j] = 0;
                }
            }
            for (int j = 0; j < field.GetLength(1); j++)
            {
                for (int x = 0; x < 4; x++)
                {
                    int i = rnd.Next(0, 8);
                    dataGridViewLevel.Rows[i].Cells[j].Value = "";
                    dataGridViewLevel.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(220, 220, 220);
                    dataGridViewLevel.Rows[i].Cells[j].Style.ForeColor = Color.Orange;
                    field1[i, j] = 0;
                }
            }
        }
        
        

        
        void LoadLevel()
        {
            StreamReader str = new StreamReader("level.txt");
            string[] temp = str.ReadLine().Split();
            int n = Convert.ToInt32(temp[0]);
            int m = Convert.ToInt32(temp[1]);
            field = new int[n, m];
            field1 = new int[n, m];
            field2 = new int[n, m];
            for(int i = 0; i < n; i++)
            {
                string temp1 = str.ReadLine();
                for(int j = 0; j < m; j++)
                {
                    if (Char.IsDigit(temp1[j]))
                    {
                        field[i, j] = temp1[j] - 48;
                    }
                    field2[i, j] = field[i, j];
                }
            }
            str.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormGame_Load(object sender, EventArgs e)
        {
            LoadLevel();
            CreateLevel();
            ShowLevel();
        }

        private void dataGridViewLevel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int clickRow = e.RowIndex;
            int clickColumn = e.ColumnIndex;

            //UserEnter(clickRow, clickColumn);
        }

        

        /*private void dataGridViewLevel_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.NumPad3)
            {
                dataGridViewLevel.SelectedCells[0].Value = 3;
            }

        }*/

        private void dataGridViewLevel_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row = e.RowIndex;
            int column = e.ColumnIndex;
            if (field1[row, column] != 0)
            {
                dataGridViewLevel.CancelEdit();
            }
            else
            {

                if (Convert.ToString(dataGridViewLevel.Rows[row].Cells[column].Value) == "")
                {
                    dataGridViewLevel.Rows[row].Cells[column].Value = 1;
                    field2[row, column] = 1;
                }
                else
                {
                    int content = Convert.ToInt32(dataGridViewLevel.Rows[row].Cells[column].Value);
                    if (content == 9)
                    {
                        dataGridViewLevel.Rows[row].Cells[column].Value = 1;
                        field2[row, column] = 1;
                    }
                    else
                    {
                        dataGridViewLevel.Rows[row].Cells[column].Value = content + 1;
                        field2[row, column] = content + 1;
                    }
                }
            }
        }
    }
}
