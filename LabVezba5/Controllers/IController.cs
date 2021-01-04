using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabVezba5.Models;
using LabVezba5.View;

namespace LabVezba5.Controllers
{
    public interface IController
    {
        void Start();
        void GameOver();
        void NewGame();
        void Draw();
        //remove ulog?
    }
}
