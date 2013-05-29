using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;
using System.Configuration;

namespace TCPTrace
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIniciar_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.UseShellExecute = false;
            psi.FileName = ConfigurationManager.AppSettings["LocalTCPTrace"].ToString();// @"C:\DEV\Programas\tcpTrace081\tcptrace.exe";
            psi.WindowStyle = ProcessWindowStyle.Hidden;
            psi.UseShellExecute = false;
            psi.Arguments = @" /listen " + txbPortaEscuta.Text + @" /serverPort " + txbServidorPorta.Text + @" /serverName " + txbServidor.Text;
            try
            {
                using (Process exeProcess = Process.Start(psi))
                {
                    lblMsg.Text = "Túnel aberto com sucesso";
                }
            }
            catch (Exception exx)
            {
                lblMsg.Text = "Ocorreu um erro ao tentar abrir o túnel: " + exx.Message;
            }
        }

        protected void btnParar_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.UseShellExecute = false;
            psi.FileName = ConfigurationManager.AppSettings["LocalTCPTrace"].ToString();//@"C:\DEV\Programas\tcpTrace081\tcptrace.exe";
            psi.WindowStyle = ProcessWindowStyle.Hidden;
            psi.UseShellExecute = false;
            psi.Arguments = @" /kill ";

            try
            {
                using (Process exeProcess = Process.Start(psi))
                {
                    lblMsg.Text = "Todos os túneis foram fechados!";
                }
            }
            catch(Exception exx)
            {
                lblMsg.Text = "Ocorreu um erro ao tentar fechar os túneis: " + exx.Message;
            }
        }
    }
}