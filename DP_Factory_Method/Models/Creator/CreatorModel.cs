using DP_Factory_Method.Models.Abstract;
using DP_Factory_Method.Models.Concrete;
using DP_Factory_Method.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Factory_Method.Models.Creator
{
    public class CreatorModel
    {
        public Screen ScreenFactory(ScreenModel screenModel)
        {
            Screen screen = null;

            switch (screenModel)
            {
                case ScreenModel.Windows:
                    screen = new WinScreen();
                    break;

                case ScreenModel.Web:
                    screen = new WebScreen();
                    break;

                case ScreenModel.Mobile:
                    screen = new MobileScreen();
                    break;

            }

            return screen;
        }
    }
}
