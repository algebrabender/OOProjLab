using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace LabVezba5.Models
{
    interface IModel
    {
        void ShuffleDeck(List<Card> currentDeck);
        void NewDeck();
        List<Card> DrawCards(int numOfCards);
        List<Image> GetImages(List<Card> currentCards);
    }
}
