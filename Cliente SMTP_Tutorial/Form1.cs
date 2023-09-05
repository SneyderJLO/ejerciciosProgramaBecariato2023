using System.Net;
using System.Net.Mail;
using System.Windows.Forms;


/*
smtp-mail.outlook.com
smtp.live.com

tenemriq@outlook.com

lojanito@tenemeac115!99

lojanoneysser@gmail.com

 */
namespace Cliente_SMTP_Tutorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                using (MailMessage mensaje = new MailMessage(txtDe.Text,
                txtPara.Text, txtAsunto.Text, txtContenido.Text))
                {
                    SmtpClient clienteSMTP = new SmtpClient(txtServidor.Text, 587);
                    clienteSMTP.Credentials = new NetworkCredential(
                        txtUsuario.Text, txtPassword.Text
                        );
                    clienteSMTP.EnableSsl = true;
                    clienteSMTP.Send(mensaje);

                }
                MessageBox.Show("mesaje enviado");
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex + "");
            }
            catch (SmtpException ex)
            {
                MessageBox.Show(ex + "");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
            }
        }
    }
}