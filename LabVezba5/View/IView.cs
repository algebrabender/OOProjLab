using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabVezba5.Controllers;

namespace LabVezba5.View
{
    public interface IView
    {
        void AddListener(IController controller);
    }
}
