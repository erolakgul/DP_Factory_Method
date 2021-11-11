using DP_Factory_Method.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Factory_Method.Models.Concrete
{
    public class WebScreen : Screen
    {
        public override void Draw()
        {
            Console.WriteLine("Web Ekranı");
        }
    }
}
