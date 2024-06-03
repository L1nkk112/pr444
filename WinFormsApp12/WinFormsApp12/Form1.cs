using System.Windows.Forms;

namespace WinFormsApp12
{
    public partial class Form1 : Form
    {
        List<Airplane<string, DateTime>> airplane = new List<Airplane<string, DateTime>>();
        ErrorProvider errorProvider = new ErrorProvider();
        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Short;
        }
        private async void AddApplication()
        {
            if (!string.IsNullOrEmpty(txtPassangerName.Text) &&
                !string.IsNullOrEmpty(txtFlightNumber.Text) &&
                !string.IsNullOrEmpty(txtDestination.Text))
            {
                if (dateTimePicker1.Value.Date == DateTime.Today)
                {
                    errorProvider.SetError(dateTimePicker1, "Дата вылета не может совпадать с сегодняшней датой.");
                    await Task.Delay(2000);
                    errorProvider.SetError(dateTimePicker1, "");
                    return;
                }
                else if (dateTimePicker1.Value.Date < DateTime.Today)
                {
                    MessageBox.Show("Ну вы же не можете в прошлое лететь =).");
                    await Task.Delay(2000);
                    errorProvider.SetError(dateTimePicker1, "");
                    return;
                }
                Airplane<string, DateTime> newAirplane = new Airplane<string, DateTime>(txtDestination.Text, txtPassangerName.Text, txtFlightNumber.Text, dateTimePicker1.Value.Date);
                airplane.Add(newAirplane);
                UpdateAirplaneInformation();
            }
            else
            {
                errorProvider.SetError(txtFlightNumber, "Введите корректный номер рейса.");
                await Task.Delay(2000);
                errorProvider.SetError(txtFlightNumber, "");
                errorProvider.SetError(txtPassangerName, "Введите корректное ФИО пассажира.");
                await Task.Delay(2000);
                errorProvider.SetError(txtPassangerName, "");
                errorProvider.SetError(txtDestination, "");
                errorProvider.SetError(txtDestination, "Введите корректное место назначения.");
                await Task.Delay(2000);
                errorProvider.SetError(txtDestination, "");
            }
        }
        private void UpdateAirplaneInformation()
        {
            txtApplications.Clear();
            foreach (Airplane<string, DateTime> b in airplane)
            {
                string ApplicationsInfo = $"Номер рейса: {b.FlightNumber}\r\nПассажир: {b.PassangerName}\r\nПункт назначения: {b.Destination}\r\nЖелаемая дата вылета: {b.DepartureDate}\r\n";
                txtApplications.AppendText(ApplicationsInfo + Environment.NewLine);
            }
        }
        private void UpdateAllApplicationsInformation()
        {
            if (txtAllApplications.Text.Length > 0)
            {
                txtAllApplications.AppendText(Environment.NewLine + "-------------------------------------" + Environment.NewLine);
            }
            foreach (Airplane<string, DateTime> b in airplane)
            {
                string ApplicationsInfo = $"Номер рейса: {b.FlightNumber}\r\nПассажир: {b.PassangerName}\r\nПункт назначения: {b.Destination}\r\nЖелаемая дата вылета: {b.DepartureDate}\r\n";
                txtAllApplications.AppendText(ApplicationsInfo + Environment.NewLine);
            }
        }
        private void btnAllApplications_Click_1(object sender, EventArgs e)
        {
            UpdateAllApplicationsInformation();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnAddAplication_Click(object sender, EventArgs e)
        {
            AddApplication();
        }
        private void btnRemoveApplication_Click(object sender, EventArgs e)
        {
            txtApplications.Clear();
            airplane.Clear();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtAllApplications.Clear();
            txtApplications.Clear();
            txtDestination.Clear();
            txtFlightNumber.Clear();
            txtPassangerName.Clear();
            airplane.Clear();
        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnClose_Click(sender, e);
        }
    }
}