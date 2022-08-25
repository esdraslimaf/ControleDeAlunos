using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProjetoControleDeAlunos.Services
{
    internal class SalvarAlunosEmDocumento
    {
        public void SalvaArquivo() { 
        
        string path = @"C:\SavingDocs";
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                

                }
            }


        }
    }
}
