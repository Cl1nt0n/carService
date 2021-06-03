using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarService
{
    public partial class FormCarService : Form
    {
        private Service _service;
        private Detail[] _buyingDetails;

        private string _currentModel;
        private Detail _currentDetail;

        private int _cashBox;
        private string[] _availableModels;

        private Random random = new Random();

        public FormCarService()
        {
            InitializeComponent();
        }

        private void FormCarService_Load(object sender, EventArgs e)
        {
            _service = new Service();
            _availableModels = new string[] { "Toyota", "BMW", "Lexus", "Lada" };
            _buyingDetails = new Detail[] { new Accumulator(_availableModels), new Carburetor(_availableModels), new Transmission(_availableModels) };

            checkedListBoxAvailableDetails.Items.AddRange(_buyingDetails);
            checkedListBoxAvailableModels.Items.AddRange(_availableModels);

            checkedListBoxAvailableDetails.Visible = false;
            checkedListBoxAvailableModels.Visible = false;
            buttonOk.Visible = false;

            _cashBox = 10000;
            labelCash.Text = _cashBox.ToString();
            SetCurrentBreaking();
        }

        private void SetCurrentBreaking()
        {
            _currentModel = _availableModels[random.Next(0, 4)];
            richTextBoxCurrentCar.Text = _currentModel;

            _currentDetail = _buyingDetails[random.Next(0, 3)];
            richTextBoxCurrentBreaking.Text = _currentDetail.Type;
        }

        private void buttonFix_Click(object sender, EventArgs e)
        {
            _cashBox += _currentDetail.Price + _service.RepairPrice;
            SetCurrentBreaking();
        }

        private void buttonBuyDetails_Click(object sender, EventArgs e)
        {
            checkedListBoxAvailableDetails.Visible = true;
            checkedListBoxAvailableModels.Visible = true;
            buttonOk.Visible = true;
        }

        private void checkedListBoxAvailableDetails_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            listBoxDetails.Items.Add(checkedListBoxAvailableDetails.SelectedItems);
        }

        private void listBoxDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxDetails.SelectedItem.ToString() == _currentDetail.Type && listBoxDetails)
            {
                buttonFix.Enabled = true;
            }
        }
    }

    public class Service
    {
        public int RepairPrice { get; private set; }
        public List<Detail> Depot { get; private set; }

        public Service()
        {
            RepairPrice = 1000;
        }

        public void BuyDetails(Detail detail)
        {
            Depot.Add(detail);
        }
    }

    public class Detail
    {
        public string Type { get; protected set; }
        public string[] FitCarModels { get; protected set; }
        public int Price { get; protected set; }

        public Detail(int price)
        {
            Price = price;
        }
    }

    public class Carburetor : Detail
    {
        public Carburetor(string[] fitModelsArray) : base(fitModelsArray.Length * 1000)
        {
            FitCarModels = fitModelsArray;
            Type = "Карбюратор";
        }
    }

    public class Accumulator : Detail
    {
        public Accumulator(string[] fitModelsArray) : base(fitModelsArray.Length * 1000)
        {
            FitCarModels = fitModelsArray;
            Type = "Аккумулятор";
        }
    }

    public class Transmission : Detail
    {
        public Transmission(string[] fitModelsArray) : base(fitModelsArray.Length * 1000)
        {
            FitCarModels = fitModelsArray;
            Type = "Трансмиссия";
        }
    }
}
