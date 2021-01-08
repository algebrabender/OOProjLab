using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using LabVezba5.Models;
using LabVezba5.View;

namespace LabVezba5.Controllers
{
    public interface IController
    {
        void Start();
        bool Draw();
        void SetPictures();
        void Replace(int numOfCards, List<Image> list);
        int GetPoints();
    }
}
