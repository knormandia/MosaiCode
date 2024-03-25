using Microsoft.VisualBasic.ApplicationServices;
using QRCoder;
using System.Security.Policy;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MosaiCode
{
    public partial class MosaiCode : Form
    {
        public MosaiCode()
        {
        InitializeComponent();


        bt_Cola.Image = Image.FromFile("C:\\Users\\tcort\\Documents\\Projetos\\C# forms\\MosaiCode\\MosaiCode\\Resources\\bt_colar.png");

        }

        private void GerarQRCode() // Método gerador de QR Code
        {
            string payload = txtLink.Text;

            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(payload, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            pctQR.Image = qrCode.GetGraphic(7);

        }

        private void bt_Cola_Click(object sender, EventArgs e)
        {
            string Area_Transferencia = Clipboard.GetText();
            txtLink.Text = Area_Transferencia;

            MosaiCode_BLL.ValidaLink(Area_Transferencia); //Verifica se o item digitado possui propriedades de um Link
            if (Erro.AcheiErro)
            {
                MessageBox.Show(Erro.Mensagem);
                return;
            }
           
        }

        private void bt_CriarQR_Click(object sender, EventArgs e)
        {
            string LinkQR;
            LinkQR = txtLink.Text;

            MosaiCode_BLL.ValidaLink(LinkQR);
            if (Erro.AcheiErro)
            {
                MessageBox.Show(Erro.Mensagem);
                return;
            }
            GerarQRCode(); // Gera o QR Code


        }

       
    }
}
