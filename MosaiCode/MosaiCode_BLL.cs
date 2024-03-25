using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;
using System.Net;

namespace MosaiCode
{
    class MosaiCode_BLL // Validação do link colocado na textbox
    {
        public static void ValidaLink(string LinkQR)
        {
            if (string.IsNullOrEmpty(LinkQR))
            {
                MessageBox.Show("O campo da URL está nulo.");
                return;
            }
            if (!LinkQR.StartsWith("http"))
            {
                MessageBox.Show("A URL é inválida.");
                return;
            }
          
        }
    }
}

    

    
              


