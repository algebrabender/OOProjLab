using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabVezba5.Models
{
    interface IModel
    {
        void ShuffleDeck(List<Card> currentDeck);
        void NewDeck(Type type);
        List<Card> DrawCards(int numOfCards);
    }
}
