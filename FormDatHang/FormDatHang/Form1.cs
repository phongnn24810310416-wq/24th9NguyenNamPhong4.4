namespace FormDatHang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstMenu.Items.Add("Hamburger - 50000");
            lstMenu.Items.Add("Pizza - 120000");
            lstMenu.Items.Add("Gà Rán - 35000");
            lstMenu.Items.Add("Pepsi - 15000");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            List<object> selectedItems = new List<object>();

            foreach (var item in lstMenu.SelectedItems)
            {
                selectedItems.Add(item);
            }

            foreach (var item in selectedItems)
            {
                lstSelected.Items.Add(item);
                lstMenu.Items.Remove(item);
            }

            UpdateTotal();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            List<object> selectedItems = new List<object>();

            foreach (var item in lstSelected.SelectedItems)
            {
                selectedItems.Add(item);
            }

            foreach (var item in selectedItems)
            {
                lstMenu.Items.Add(item);
                lstSelected.Items.Remove(item);
            }

            UpdateTotal();
        }

        private void UpdateTotal()
        {
            double total = 0;

            foreach (var item in lstSelected.Items)
            {
                string[] parts = item.ToString().Split('-');

                double price = double.Parse(parts[1]);

                total += price;
            }

            lblTotal.Text = "Tổng tiền: " + total.ToString("N0") + " VNĐ";
        }
    }
}
