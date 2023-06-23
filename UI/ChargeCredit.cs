using Domain.Interface;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.ExtenstionMethod;

namespace UI
{
    public partial class ChargeCredit : Form
    {
        ICreditUpdater _creditUpdater;
        User _user = new();
        public ChargeCredit(ICreditUpdater creditUpdater)
        {
            _creditUpdater = creditUpdater;
            InitializeComponent();
        }
        public void SetUserInfo(Domain.Model.User user)
          => _user = user;

        private void button1_Click(object sender, EventArgs e)
        {
            lblEmpty.Visible = txtbxAmount.Text != string.Empty ? false : true;

            if (lblEmpty.Visible == false)
            {
                decimal amount = Convert.ToDecimal(txtbxAmount.Text);

               _user.Credit = _creditUpdater.CreditIncreaser(_user.Username, amount);
            }

            this.Open("book shop", _user);
        }

        private void ChargeCredit_Load(object sender, EventArgs e)
        {
            lblCredit.Text = _user.Credit.ToString();
        }
    }
}
