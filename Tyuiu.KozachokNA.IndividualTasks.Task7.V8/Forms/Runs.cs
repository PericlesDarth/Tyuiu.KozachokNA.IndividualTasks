using Sprint7.Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KozachokNA.IndividualTasks.Task7.V8.Forms;

namespace Tyuiu.KozachokNA.IndividualTasks.Task7.V8
{
    public partial class Runs : Form
    {
        public CSV csv = new CSV();
        public List<string[]> data;
        FileIO fio = new FileIO();
        DataService ds = new DataService();
        DataGridView Table;
        TextBox AddRowField;
        TextBox DeleteRowField;
        TextBox SearchField;
        int m;
        public Runs()
        {
            InitializeComponent();
            data = new List<string[]>();
            Table = RunsTable;
            AddRowField = RunsAddRowField;
            DeleteRowField = RunsDeleteRowField;
            SearchField = RunsSearchField;
            m = 6; //5 для Drivers, 6 для Runs, 7 для Cars

            Table.RowCount = 1;
            Table.AllowUserToAddRows = true;
            Table.AllowUserToDeleteRows = true;
            Table.AllowUserToResizeColumns = true;
        }

        private void AddRow_Click(object sender, EventArgs e)
        {
            string newRow = AddRowField.Text;
            string[] foo = newRow.Split(';');
            csv.data.Add(newRow);
            data.Add(foo);

            RefreshTable();
        }

        private void DeleteRow_Click(object sender, EventArgs e)
        {
            int i;
            if (DeleteRowField.Text == "")
            {
                i = csv.data.Count - 1;
            }
            else
            {
                i = int.Parse(DeleteRowField.Text);
            }
            if (data.Count > 1)
            {
                csv.data.RemoveAt(i);
                data.RemoveAt(i);
            }
            else
            {
                string[] foo = new string[m];
                string bar = "";
                for (i = 0; i < m; i++)
                {
                    foo[i] = "";
                    if (i < m - 1)
                    {
                        bar += ";";
                    }
                }
                data.Clear();
                data.Add(foo);
                csv.data.Clear();
                csv.data.Add(bar);
            }
            RefreshTable();
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog tmp = new OpenFileDialog();
            tmp.ShowDialog();
            string path = tmp.FileName;
            csv = fio.FileInput(path);
            data = ParseCSV(csv.data);

            Table.Rows.Clear();
            Table.Columns.Clear();
            RefreshTable();
        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog tmp = new SaveFileDialog();
            tmp.ShowDialog();
            string path = tmp.FileName;
            fio.FileOutput(path, csv);
        }

        private List<string[]> ParseCSV(List<string> csv)
        {
            int n;
            n = csv.Count;
            string foo = "";
            int[] count = new int[n];

            List<string[]> res = new List<string[]>(n); //string[n, m];
            for (int i = 0; i < n; i++)
            {
                foo = csv[i];
                string[] bar = foo.Split(';');
                res.Add(bar);
            }
            return res;
        }

        private List<string> UnparseCSV(List<string[]> data)
        {
            int n;
            n = data.Count;
            //m = data[0].Length;
            List<string> csv = new List<string>(n);
            string foo = "";
            for (int i = 0; i < n; i++)
            {
                foo = "";
                for (int j = 0; j < m; j++)
                {
                    if (j < m - 1)
                    {
                        foo += data[i][j] + ";";
                    }
                    else
                    {
                        foo += data[i][j];
                    }
                }
                csv[i] = foo;
            }
            return csv;
        }

        private void FillDataGrid(DataGridView grid, List<string[]> data)
        {
            int n;
            n = data.Count;
            //m = data[0].Length;
            grid.Rows.Clear();
            grid.Columns.Clear();
            grid.RowCount = n + 1;
            grid.ColumnCount = m;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (i < n && j < data[i].Length)
                    {
                        grid.Rows[i].Cells[j].Value = data[i][j];
                    }
                    else
                    {
                        grid.Rows[i].Cells[j].Value = "";
                    }
                }
            }

        }

        public void RefreshTable()
        {
            FillDataGrid(Table, data);

            Table.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            Table.Update();
        }

        private void RunsSearch_Click(object sender, EventArgs e)
        {
            CSV newCSV = DataService.Search(csv, SearchField.Text);
            List<string[]> newData = ParseCSV(newCSV.data);
            Runs tmp = new Runs();
            tmp.csv = newCSV;
            tmp.data = newData;
            tmp.RefreshTable();

            tmp.ShowDialog();
        }

        private void RunsRefresh_Click(object sender, EventArgs e)
        {
            int count = csv.data.Count;
            Counter.Text = Convert.ToString(count);
            double range = Math.Round((double)DataService.Summator(csv, 2) / count, 3);
            AvrRange.Text = Convert.ToString(range);
        }
    }
}
