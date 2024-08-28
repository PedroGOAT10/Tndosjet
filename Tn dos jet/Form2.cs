using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tn_dos_jet
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }

        private void BtnAcesso_Click(object sender, EventArgs e)
        {
            String User = "Pedro";
            String Password = "tn";
            String Email = "ph9160036@gmail.com";
            String Number = "+5512996345011";
            String Years = "17";
            String Localition = "São Paulo";

            if (txtUsuário.Text == User & txtSenha.Text == Password & txtEmail.Text == Email & txtTelefone.Text == Number & txtIdade.Text == Years & txtEstado.Text == Localition)
            {
                MessageBox.Show("Acesso Liberado!");
                Form1 ForMain = new Form1();
                ForMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário/Senha/Email/Telefone/Idade Incorretos !");
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void txtEstado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
