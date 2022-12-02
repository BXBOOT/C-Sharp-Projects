using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TwentyOneTogether
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck  { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First());
            string card = string.Format(Deck.Cards.First().ToString() + "\n");
            Console.WriteLine(card);
            using (StreamWriter File = new StreamWriter(@"C:etc\etc\etc\Logs\log.txt", true))
            {
                File.WriteLine(card);
            }
            Deck.Cards.RemoveAt(0);
        }
    }
}
