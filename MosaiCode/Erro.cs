using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MosaiCode
{
    class Erro // Classe de Erro que será usada quando Links forem digitados incorretamente
    {
        public static bool AcheiErro {get; set;}

        private static string ValorMensagem;

        public static string Mensagem
        {
            get {return ValorMensagem; }
            set { AcheiErro = true; ValorMensagem = value;}
        }


    }
}
