using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chatbot
{
    internal class Chatbot
    {
        public string Navn { get; set; }
        public List<string> Svar { get; set; }

        public Chatbot(string navn)
        {
            Navn = navn;
            Svar = new List<string>();
        }

        public string TilfeldigSvar()
        {
            
            Random random = new Random();
            int index = random.Next(Svar.Count);
            return Svar[index];
        }
    }
    
}
