using System;
using System.Data;
using System.Windows.Forms;

namespace UnlimitedFairytales.CsharpSamples.Forms
{
	public partial class Form05ComboBoxesAndListBoxes : Form
	{
		public Form05ComboBoxesAndListBoxes()
		{
			InitializeComponent();
		}

		private void Form05ComboBoxesAndListBoxes_Load(object sender, EventArgs e)
		{
			DataTable source = new DataTable();
			source.Columns.Add("key");
			source.Columns.Add("fruits");
			source.Columns.Add("animals");
			source.Rows.Add("1", "Apple", "Antelope");
			source.Rows.Add("2", "Banana", "Bird");
			source.Rows.Add("3", "Cherry", "Cat");
			source.Rows.Add("4", "Durian", "Dog");
			source.Rows.Add("5", "Eggplant", "Elephant");
			source.Rows.Add("6", "Fig", "Fish");
			source.Rows.Add("7", "Grapes", "Goat");
			source.Rows.Add("8", "Hazelnut", "Horse");
			source.Rows.Add("9", "Ilama", "Insect");
			source.Rows.Add("10", "Jackfruit", "Jerryfish");
			source.Rows.Add("11", "Kiwi", "Koala");
			source.Rows.Add("12", "Litchi", "Lizard");
			source.Rows.Add("13", "Melon", "Monkey");
			source.Rows.Add("14", "Nectarine", "Newt");
			source.Rows.Add("15", "Olive", "Octopus");
			source.Rows.Add("16", "Peach", "Pig");
			source.Rows.Add("17", "Quince", "Quoll");
			source.Rows.Add("18", "Raspberry", "Rat");
			source.Rows.Add("19", "Strawberry", "Shellfish");
			source.Rows.Add("20", "Tomato", "Toad");
			source.Rows.Add("21", "Uglifruit", "Urial");
			source.Rows.Add("22", "Valencia", "Viper");
			source.Rows.Add("23", "Walnut", "Whale");
			source.Rows.Add("24", "Xigua", "Xiphosuran");
			source.Rows.Add("25", "Yellowpassion", "Yak");
			source.Rows.Add("26", "Zuchinni", "Zebla");
			DataTable source2 = source.Copy();

			this.listBox1.DataSource = source;
			this.listBox1.ValueMember = "key";
			this.listBox1.DisplayMember = "animals";

			this.comboBox1.DataSource = source2;
			this.comboBox1.ValueMember = "key";
			this.comboBox1.DisplayMember = "fruits";
		}

		private void btn0_Click(object sender, EventArgs e)
		{
			this.listBox1.SelectedIndex = 0;
			this.comboBox1.SelectedIndex = 0;
			this.label2.Text = this.listBox1.SelectedIndex.ToString();
			this.label4.Text = this.comboBox1.SelectedIndex.ToString();
		}

		private void btn1_Click(object sender, EventArgs e)
		{
			this.listBox1.SelectedIndex = 1;
			this.comboBox1.SelectedIndex = 1;
			this.label2.Text = this.listBox1.SelectedIndex.ToString();
			this.label4.Text = this.comboBox1.SelectedIndex.ToString();
		}

		private void btnMinus1_Click(object sender, EventArgs e)
		{
			this.listBox1.SelectedIndex = -1;
			this.comboBox1.SelectedIndex = -1;
			this.label2.Text = this.listBox1.SelectedIndex.ToString();
			this.label4.Text = this.comboBox1.SelectedIndex.ToString();
		}
	}
}
