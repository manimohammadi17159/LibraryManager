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
    public partial class Profile : Form
    {
        IUserBookRequest _bookRequest;
        User _user = new();
        public Profile(IUserBookRequest userBookRequest, User user)
        {
            _bookRequest = userBookRequest;
            _user = user;
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            lblName.Text = _user.Name;
            lblCredit.Text = _user.Credit.ToString();

            pictureBoxes = _bookRequest.SelectUserBooks(_user.Username).ConvertToPictureBoxProfile(30,30);
            panel1.ShowInPanel(pictureBoxes);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.BackToMain();
        }
    }
}
