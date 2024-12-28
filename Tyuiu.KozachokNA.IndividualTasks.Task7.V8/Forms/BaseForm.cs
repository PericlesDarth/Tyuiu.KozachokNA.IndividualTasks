using Tyuiu.KozachokNA.IndividualTasks.Task7.V8.Forms;

namespace Tyuiu.KozachokNA.IndividualTasks.Task7.V8
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        private void CarsFormOpen_Click(object sender, EventArgs e)
        {
            Cars cars = new Cars();
            cars.Show();
        }

        private void RunsFormOpen_Click(object sender, EventArgs e)
        {
            Runs runs = new Runs();
            runs.Show();
        }

        private void DriversFormOpen_Click(object sender, EventArgs e)
        {
            Drivers drivers = new Drivers();
            drivers.Show();
        }

        private void HelpFormOpen_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.Show();
        }
    }
}
