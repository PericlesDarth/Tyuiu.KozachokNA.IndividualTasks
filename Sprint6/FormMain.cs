using Sprint6.Lib;

namespace Sprint6
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private int[,] matrix = { };
        private int errCode = 0;
        private DataService dataService = new DataService();

        private void StartCalculate_Click(object sender, EventArgs e)
        {
            int r = int.Parse(RowNumber.Text);
            int k = int.Parse(EnumFrom.Text);
            int l = int.Parse(EnumTo.Text);

            int res = 0;
            (res, errCode) = dataService.GetResult(matrix, r, k, l);
            ResultValue.Text = Convert.ToString(res);
        }

        private void CreateMatrix_Click(object sender, EventArgs e)
        {
            Rows.Update();
            Columns.Update();
            RNGFrom.Update();
            RNGTo.Update();

            int n = int.Parse(Rows.Text);
            int m = int.Parse(Columns.Text);
            int n1 = int.Parse(RNGFrom.Text);
            int n2 = int.Parse(RNGTo.Text);

            (matrix, errCode) = dataService.InitializeArray(n, m, n1, n2);
            if (errCode == 0 )
            {
                dataGridMatrix.RowCount = n;
                dataGridMatrix.ColumnCount = m;

                ErrorMessage.Text = "OK!";
                ErrorMessage.Update();

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        dataGridMatrix.Rows[i].Cells[j].Value = matrix[i, j];
                    }
                }
                dataGridMatrix.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dataGridMatrix.Update();
            }
            if (errCode == 1 )
            {
                ErrorMessage.Text = "Некорректные значения n1 и n2!";
            }
            if (errCode == 2 )
            {
                ErrorMessage.Text = "Слишком мало столбцов!";
            }
            if (errCode == 3 )
            {
                ErrorMessage.Text = "Слишком мало строк!";
            }
            ErrorMessage.Update();
        }

    }
}
