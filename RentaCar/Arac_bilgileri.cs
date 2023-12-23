using RentaCar.Entities;
using RentaCar.Service;

namespace RentaCar
{
    public partial class Arac_bilgileri : Form
    {
        private readonly CarService _carService;
        public Arac_bilgileri(CarService carService)
        {
            InitializeComponent();
            _carService = carService;

            // Veritaban�ndan verileri al
            var cars = _carService.GetAllCars();

            // DataGridView'i temizle
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            // Verileri DataGridView'e ekle
            foreach (var car in cars)
            {
                // Her bir �zellik i�in bir s�tun olu�tur
                if (dataGridView1.Columns.Count == 0)
                {
                    foreach (var property in typeof(Cars).GetProperties())
                    {
                        dataGridView1.Columns.Add(property.Name, property.Name);
                    }
                }

                // Bir sat�r ekleyin ve de�erleri s�tunlara yerle�tirin
                int rowIndex = dataGridView1.Rows.Add();
                DataGridViewRow row = dataGridView1.Rows[rowIndex];

                foreach (var property in typeof(Cars).GetProperties())
                {
                    var value = property.GetValue(car);
                    row.Cells[property.Name].Value = value;
                }
            }
        }

        private void devamButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
