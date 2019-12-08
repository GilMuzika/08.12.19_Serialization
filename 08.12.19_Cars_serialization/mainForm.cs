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

namespace _08._12._19_Cars_serialization
{
    public partial class mainForm : Form
    {
        private ColorDialog colorPicker = new ColorDialog();

        private Color _carColor = SystemColors.Control;
        private string[] _carBrandsToUsing = null;
        private Random _rnd = new Random();
        private FileDialog openFileDialog = new OpenFileDialog();

        public mainForm()
        {
            InitializeComponent();
            InitializeControls();
            ReadFromFile();
            InitializeCarValues();
            ReadAndRestoreSerializedObjects();
        }
        private void ReadAndRestoreSerializedObjects()
        {
            string[] filenames = Directory.GetFiles(Directory.GetCurrentDirectory()).Where(x => x.Contains("CarArr_")).ToArray();

            if (!File.Exists(filenames[filenames.Length - 1])) { MessageBox.Show("The file with the serialised data is missing, so no data can be restored"); return; }

            Car[] carArr =  Car.DeSerializeCarArray(filenames[filenames.Length - 1]);
            ComboItem<Car>[] carArrHolder = new ComboItem<Car>[carArr.Length];
            for (int i = 0; i < carArrHolder.Length; i++) carArrHolder[i] = new ComboItem<Car>(carArr[i]);

            cmbAllTheCars.Items.AddRange(carArrHolder);
            /*
            string str = string.Empty;
            foreach (var s in filenames) str += s + Environment.NewLine;

            MessageBox.Show(str);
            */


        }
        private void InitializeCarValues()
        {
            string brand = _carBrandsToUsing[_rnd.Next(_carBrandsToUsing.Length - 1)];
            txtBrand.Text = brand+"\n";
            txtModel.Text = brand +  " model " + _rnd.Next(1, 100) + "\n";
            dtpYear.Value = new DateTime(_rnd.Next(1753, 2019), _rnd.Next(1, 12), _rnd.Next(1, 28));
            _carColor = Color.FromArgb(_rnd.Next(255), _rnd.Next(255), _rnd.Next(255));
            btnPickAColor.BackColor = _carColor;
            numCodan.Value = _rnd.Next((int)numCodan.Minimum, (int)numCodan.Maximum);
            numNumberOfSeats.Value = _rnd.Next((int)numNumberOfSeats.Minimum, (int)numNumberOfSeats.Maximum);
        }
        private void ReadFromFile()
        {
            string names = string.Empty;
            try
            {
                names = File.ReadAllText("_car_brands.txt");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} \n\nSo the program will use the defult names");
                names = " Alfred Benny Connnor Daniel Eran ";
            }
            _carBrandsToUsing = names.Split(new char[] { '\n' }).Where(x => !String.IsNullOrEmpty(x)).ToArray();
        }
        private void InitializeControls()
        {
            this.Text = "Car XML serializer";

            dtpYear.Format = DateTimePickerFormat.Custom;
            dtpYear.CustomFormat = "yyyy";
            dtpYear.ShowUpDown = true;

            btnPickAColor.Click += (object sender, EventArgs e) => 
                {
                    if (colorPicker.ShowDialog() == DialogResult.OK) { _carColor = colorPicker.Color; btnPickAColor.BackColor = _carColor; }
                };

            btnDrserializeACarByCtor.Visible = false;

            ToolTip toolTip1 = new ToolTip();
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;
            toolTip1.IsBalloon = true;
            toolTip1.SetToolTip(btnDrserializeACarByCtor, "Serialize the selected car and remove it from the collection");

            ToolTip toolTip2 = new ToolTip();
            toolTip2.AutoPopDelay = 5000;
            toolTip2.InitialDelay = 1;
            toolTip2.ReshowDelay = 500;
            toolTip2.ShowAlways = true;
            toolTip2.IsBalloon = true;
            toolTip2.SetToolTip(btnDeserializeACar, "Pick an XML file, deserialize a car from it, add the car to the collection and delete the file");

            ToolTip toolTip3 = new ToolTip();
            toolTip3.AutoPopDelay = 5000;
            toolTip3.InitialDelay = 1;
            toolTip3.ReshowDelay = 500;
            toolTip3.ShowAlways = true;
            toolTip3.IsBalloon = true;
            toolTip3.SetToolTip(btnDrserializeACarByCtor_, "Deserialize a car by Constractor");

            openFileDialog.InitialDirectory = Directory.GetCurrentDirectory() + "\\" + Car.SAVING_DIR_NAME;
            openFileDialog.DefaultExt = "xml";
            openFileDialog.Filter = "xml files (*.xml)|*.xml";
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;

            Application.ApplicationExit += (object sender, EventArgs e) => 
                {
                    List<Car> allCars = new List<Car>();
                    foreach (var s in cmbAllTheCars.Items) allCars.Add((s as ComboItem<Car>).Item);

                    Car.SerializecarArray(allCars.ToArray());
                    MessageBox.Show($"All the persons are saved to the disk in the XML format as Array and will be restored on the next run of the applocation. \n\nThe path to the file is:\n{Directory.GetCurrentDirectory()}");
                };
        }

        private void btnCreateANewCar_Click(object sender, EventArgs e)
        {
            InitializeCarValues();
            cmbAllTheCars.Items.Add(new ComboItem<Car>(new Car(txtModel.Text, txtBrand.Text, dtpYear.Value.Year, _carColor, (int)numCodan.Value, (int)numNumberOfSeats.Value)));


        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        private void cmbAllTheCars_SelectedIndexChanged(object sender, EventArgs e)
        { 
            if(btnDrserializeACarByCtor.Visible == false) btnDrserializeACarByCtor.Visible = true;
            lblCurrentCar.Text = (cmbAllTheCars.SelectedItem as ComboItem<Car>).Item.ToString();            
            lblCurrentCar.drawBorder<Label>(3, Statics.colorFromString((cmbAllTheCars.SelectedItem as ComboItem<Car>).Item.Color));
        }

        private void btnSerializeTheCar_Click(object sender, EventArgs e)
        {
            try
            {
                Car.SerializeACar((cmbAllTheCars.SelectedItem as ComboItem<Car>).Item);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"{ex.Message}\n\nThe object can't be serialized because it's had been removed from the collection");
            }
            cmbAllTheCars.Items.Remove(cmbAllTheCars.SelectedItem);




        }

        private void btnDeserializeACar_Click(object sender, EventArgs e)
        {
            DialogResult dialogRez =  openFileDialog.ShowDialog();
            if(dialogRez == DialogResult.OK)
            {
                var car = Car.DeSerializeACar(openFileDialog.FileName);
                ComboItem<Car> currentcarHolder = new ComboItem<Car>(car);
                cmbAllTheCars.Items.Add(currentcarHolder);
                cmbAllTheCars.SelectedItem = currentcarHolder;
                File.Delete(openFileDialog.FileName);
            }
        }

        private void btnDrserializeACarByCtor__Click(object sender, EventArgs e)
        {
            DialogResult dialogRez = openFileDialog.ShowDialog();
            if (dialogRez == DialogResult.OK)
            {
                var car = new Car(openFileDialog.FileName);
                ComboItem<Car> currentcarHolder = new ComboItem<Car>(car);
                cmbAllTheCars.Items.Add(currentcarHolder);
                cmbAllTheCars.SelectedItem = currentcarHolder;
                File.Delete(openFileDialog.FileName);
            }
        }
    }
}
