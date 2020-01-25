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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        
        private void MainMenu_Load(object sender, EventArgs e)
        {

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

        private void ANQbtn_Click(object sender, EventArgs e)
        {
            AddQuote AQFORM = new AddQuote();
            AQFORM.Show();
            this.Hide();
        }

        private void VQbtn_Click(object sender, EventArgs e)
        {
            ViewAllQuotes VAQFORM = new ViewAllQuotes();
            VAQFORM.Show();
            this.Hide();
        }

        private void SQbtn_Click(object sender, EventArgs e)
        {
            SearchQuotes SQFrm = new SearchQuotes();
            SQFrm.Show();
            this.Hide();
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
