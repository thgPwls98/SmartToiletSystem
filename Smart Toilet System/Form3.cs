using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Toilet_System
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnNewAccount_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.Text == txtNewPassword2.Text)
            {
                //새로운 아이디 생성
                //생성되면 메시지박스로 확인!
                //창 닫히고 다시 로그인창 띄우기
            }
        }
    }
}
