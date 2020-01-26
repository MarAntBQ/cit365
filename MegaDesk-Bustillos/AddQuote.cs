using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Bustillos
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }

        // DISABLE X BUTTON
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {

        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            MainMenu MenuFrm = new MainMenu();
            MenuFrm.Show();
            this.Hide();
        }

        static bool isNumber(string s)
        {
            for (int i = 0; i < s.Length; i++)
                if (char.IsDigit(s[i]) == false)
                    return false;

            return true;
        }
        private void WidthValidate(object sender, CancelEventArgs e)
        {

            int width;
            
            try
            {
                width = Convert.ToInt32(widthInput.Text);
                if (width >= 24 && width <= 96)
                {

                }
                else
                {
                    MessageBox.Show(width + " is not a integer valid, it should be between 24 and 96", "MegaDesk");
                    widthInput.Text = "";
                    widthInput.Focus();
                }
            } catch (Exception)
            {
                MessageBox.Show("Your number is not an integer", "MegaDesk");
                widthInput.Text = "";
                widthInput.Focus();
            }
            
            

            

        }

        private void IsInteger_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void DepthInput_Validating(object sender, CancelEventArgs e)
        {
            int depth;

            try
            {
                depth = Convert.ToInt32(DepthInput.Text);
                if (depth >= 12 && depth <= 48)
                {

                }
                else
                {
                    MessageBox.Show(depth + " is not a integer valid, it should be between 12 and 48", "MegaDesk");
                    DepthInput.Text = "";
                    DepthInput.Focus();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Your number is not an integer", "MegaDesk");
                DepthInput.Text = "";
                DepthInput.Focus();
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            DisplayQuote DQFrm = new DisplayQuote();
            DQFrm.label1.Text = "Customer Name: " + textBox1.Text;
            DQFrm.label3.Text = "Width: " + widthInput.Text;
            DQFrm.label4.Text = "Depth: " + DepthInput.Text;
            DQFrm.label5.Text = "Drawers: " + comboBox2.Text;
            DQFrm.label6.Text = "Material: " + comboBox1.Text;
            DQFrm.label7.Text = "Processing Time: " + comboBox3.Text + " Days";
            DQFrm.Show();
            this.Hide();
        }
    }
}
