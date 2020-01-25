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
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
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

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu MenuFrm = new MainMenu();
            MenuFrm.Show();
            this.Hide();
        }

        private void ViewAllQuotes_Load(object sender, EventArgs e)
        {

        }
    }
}
