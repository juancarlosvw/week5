using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week5
{
    public partial class Form1 : Form
    {
        DataTable dtproduksimpan = new DataTable();
        DataTable dtprodukcategory = new DataTable();
        DataTable dtprodukfilter = new DataTable();
        List<string> productid = new List<string>();
        List<string> productname = new List<string>();
        List<string> harga = new List<string>();
        List<string> stock = new List<string>();
        List<string> categoryid1 = new List<string>();
        List<string> categoryid2 = new List<string>();
        List<string> categoryname = new List<string>();
        private string text;
        private int jalan = 0;
        int j = 0;
        int count = 5;
        string jalann = "";
        string simpanbrg = "";
        int counter = 0;
        int p = 0;
        string idnya = "";
        int simpanindex = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            timer1.Enabled = true;
            text = label_welkom.Text;
            label_welkom.Text = "";
            timer1.Start();
            dtproduksimpan.Columns.Add("ID PRODUCT");
            dtproduksimpan.Columns.Add("PRODUCT NAME");
            dtproduksimpan.Columns.Add("PRICE");
            dtproduksimpan.Columns.Add("STOCK");
            dtproduksimpan.Columns.Add("ID CATEGORY");

            dtprodukcategory.Columns.Add("ID CATEGORY");
            dtprodukcategory.Columns.Add("NAMA CATEGORY");
            dataGridView1.DataSource = dtproduksimpan;

            productid.Add("J001");
            productid.Add("T001");
            productid.Add("T002");
            productid.Add("R001");
            productid.Add("J002");
            productid.Add("C001");

            productname.Add("Jas Hitam");
            productname.Add("T-Shirt Dora");
            productname.Add("T-Shirt Oversize");
            productname.Add("Rok Pink");
            productname.Add("Jeans Hitam");
            productname.Add("Celana Pendek");

            harga.Add("150000");
            harga.Add("10000");
            harga.Add("50000");
            harga.Add("75000");
            harga.Add("35000");
            harga.Add("55000");

            stock.Add("100");
            stock.Add("150");
            stock.Add("50");
            stock.Add("70");
            stock.Add("140");
            stock.Add("30");

            categoryid1.Add("C1");
            categoryid1.Add("C2");
            categoryid1.Add("C2");
            categoryid1.Add("C3");
            categoryid1.Add("C4");
            categoryid1.Add("C5");

            categoryid2.Add("C1");
            categoryid2.Add("C2");
            categoryid2.Add("C3");
            categoryid2.Add("C4");
            categoryid2.Add("C5");

            categoryname.Add("Jas");
            categoryname.Add("T-Shirt");
            categoryname.Add("Rok");
            categoryname.Add("Jeans");
            categoryname.Add("Celana");

            combobox_categorydetail.Items.Add("Jas");
            combobox_categorydetail.Items.Add("T-Shirt");
            combobox_categorydetail.Items.Add("Rok");
            combobox_categorydetail.Items.Add("Jeans");
            combobox_categorydetail.Items.Add("Celana");

            combobox_filter.Items.Add("Jas");
            combobox_filter.Items.Add("T-Shirt");
            combobox_filter.Items.Add("Rok");
            combobox_filter.Items.Add("Jeans");
            combobox_filter.Items.Add("Celana");
            updateproduct();
            updatecategory();
            //dataGridView2.DataSource = dtprodukcategory;

            dtprodukfilter = dtproduksimpan.Copy();
        }

        private void updateproduct()
        {
            dtproduksimpan.Rows.Clear();
            for (int i = 0; i < productname.Count; i++)
            {
                dtproduksimpan.Rows.Add(productid[i], productname[i], harga[i], stock[i], categoryid1[i]);
            }
            dataGridView1.DataSource = dtproduksimpan;
        }

        private void updatecategory()
        {
            dtprodukcategory.Rows.Clear();
            for (int i = 0; i < categoryname.Count; i++)
            {
                dtprodukcategory.Rows.Add(categoryid2[i], categoryname[i]);
            }
            dataGridView2.DataSource = dtprodukcategory;
        }

        private void button_filter_Click(object sender, EventArgs e)
        {
            combobox_filter.Enabled = true;

        }


        private void combobox_filter_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dtprodukfilter.Rows.Clear();
            foreach (DataRow b in dtprodukcategory.Rows)
            {
                if (b[1] == combobox_filter.SelectedItem.ToString())
                {

                    for (int i = 0; i < dtproduksimpan.Rows.Count;i++)
                    {
                        if (b[0] == dtproduksimpan.Rows[i][4])
                        {
                            dtprodukfilter.Rows.Add(dtproduksimpan.Rows[i][0], dtproduksimpan.Rows[i][1], dtproduksimpan.Rows[i][2], dtproduksimpan.Rows[i][3], dtproduksimpan.Rows[i][4]);
                        }
                    }

                }
            }
            dataGridView1.DataSource = dtprodukfilter;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (jalan < text.Length)
            {
                label_welkom.Text = label_welkom.Text + text.ElementAt(jalan);
                jalan++;
            }
            else
            {

                timer1.Stop();
                timer2.Start();
            }
            
        }

        private void button_all_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dtproduksimpan;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Random randem = new Random();
            int color1 = randem.Next(0, 255);
            int color2 = randem.Next(0, 255);
            int color3 = randem.Next(0, 255);
            int color4 = randem.Next(0, 255);
           
            label_welkom.ForeColor = Color.FromArgb(color1, color2, color3, color4);
        }

        private void button_addcategory_Click(object sender, EventArgs e)
        {
           if (txtbox_namecategory.Text == "")
           {
                MessageBox.Show("ERROR");
           }
                for(int i = 0; i < dtprodukcategory.Rows.Count; i++)
                {
                    if (dtprodukcategory.Rows[i][1].ToString() == txtbox_namecategory.Text)
                    {
                        j = 1;
                    }
                }
                if (j == 1)
                {
                MessageBox.Show("ERROR");
                }
                else
                {
                count++;
                dtprodukcategory.Rows.Add(("C" + count) , txtbox_namecategory.Text);
                combobox_filter.Items.Add(txtbox_namecategory.Text);
                combobox_categorydetail.Items.Add(txtbox_namecategory.Text);
                }
               
        }

        private void button_removecategory_Click(object sender, EventArgs e)
        {

            combobox_filter.Items.Remove(dataGridView2.SelectedCells[1].Value.ToString());
            combobox_categorydetail.Items.Remove(dataGridView2.SelectedCells[1].Value.ToString());

            for (int x = dtproduksimpan.Rows.Count - 1; x >= 0; x--)
            {
                if (dtproduksimpan.Rows[x][4].ToString() == dataGridView2.SelectedCells[0].Value.ToString())
                {
                    dtproduksimpan.Rows.RemoveAt(x);
                }
            }
            if (dataGridView2.SelectedCells[0].Value.ToString().Substring(1) == count.ToString())
            {
                count--;
            }
            foreach (DataRow b in dtprodukcategory.Rows)
            {
                if (b[1].ToString() == jalann)
                {
                    dtprodukcategory.Rows.Remove(b);
                    break;
                }
            }
            
           
            
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            jalann = dataGridView2.SelectedCells[1].Value.ToString();
        }

        private void button_addproduct_Click(object sender, EventArgs e)
        {
            if (txtbox_namedetail.Text == "" || txtbox_price.Text == "" || txtbox_stock.Text == "" || combobox_categorydetail.Text == "")
            {
                MessageBox.Show("ERROR");
            }
            else 
            {
                foreach(DataRow a in dtprodukcategory.Rows)
                {
                    if (combobox_categorydetail.Text == a[1].ToString())
                    {
                        simpanbrg = a[0].ToString();
                    }
                }
            }
            foreach (DataRow a in dtproduksimpan.Rows)
            {
                if (txtbox_namedetail.Text[0].ToString().ToUpper() == a[0].ToString()[0].ToString())
                {
                    counter = Convert.ToInt32(a[0].ToString().Substring(1));
                    if (counter >= p)
                    {
                        p = counter;
                    }
                }
            }
            p += 1;
            idnya = txtbox_namedetail.Text[0].ToString().ToUpper();
            for (int i = p.ToString().Length; i <= 2; i++)
            {
                idnya += "0";
            }
            idnya += Convert.ToString(p);
            dtproduksimpan.Rows.Add(idnya,txtbox_namedetail.Text,txtbox_price.Text,txtbox_stock.Text,simpanbrg);
        }

        private void txtbox_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtbox_stock_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button_editproduct_Click(object sender, EventArgs e)
        {
            if (txtbox_stock.Text == "0")
            {
                dtproduksimpan.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
            else
            {
                p = 0;
                foreach (DataRow a in dtproduksimpan.Rows)
                {
                    if (txtbox_namedetail.Text[0].ToString().ToUpper() == a[0].ToString()[0].ToString())
                    {
                        counter = Convert.ToInt32(a[0].ToString().Substring(1));
                        if (counter >= p)
                        {
                            p = counter;
                        }
                    }
                }
                p += 1;
                idnya = txtbox_namedetail.Text[0].ToString().ToUpper();
                for (int i = p.ToString().Length; i <= 2; i++)
                {
                    idnya += "0";
                }
                idnya += Convert.ToString(p);
                dtproduksimpan.Rows[dataGridView1.SelectedRows[0].Index][0] = idnya;
                dtproduksimpan.Rows[dataGridView1.SelectedRows[0].Index][1] = txtbox_namedetail.Text;
                dtproduksimpan.Rows[dataGridView1.SelectedRows[0].Index][2] = txtbox_price.Text;
                dtproduksimpan.Rows[dataGridView1.SelectedRows[0].Index][3] = txtbox_stock.Text;
                foreach (DataRow b in dtprodukcategory.Rows)
                {
                    if (b[1].ToString() == combobox_categorydetail.Text)
                    {
                        dtproduksimpan.Rows[dataGridView1.SelectedRows[0].Index][4] = b[0].ToString();
                        break;
                    }
                }
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtbox_namedetail.Text = dataGridView1.SelectedCells[1].Value.ToString();
            txtbox_price.Text = dataGridView1.SelectedCells[2].Value.ToString();
            txtbox_stock.Text = dataGridView1.SelectedCells[3].Value.ToString();
            foreach (DataRow b in dtprodukcategory.Rows)
            {
                if (b[0].ToString() == dataGridView1.SelectedCells[4].Value.ToString())
                {
                    combobox_categorydetail.Text = b[1].ToString();
                    break;
                }
            }
            
        }

        private void button_removeproduct_Click(object sender, EventArgs e)
        {
            foreach(DataRow a in dtproduksimpan.Rows)
            {
                if(a[0].ToString() == dataGridView1.SelectedCells[0].Value.ToString())
                {
                    dtproduksimpan.Rows.Remove(a);
                    break;
                }
            }
        }
    }
}
