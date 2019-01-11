using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Swp.Model
{
    public class Enumerations
    {
        public static Dictionary<int, string> StopnieSlownik = new Dictionary<int, string>()
        {

        {0,"szer." },
        {1,"st. szer." },
        {2,"kpr." },
        {3,"st. kpr." },
        {4,"plut." },
        {5,"sierż." },
        {6,"st. sierż." },
        {7,"mł. chor." },
        {8,"chor." },
        {9,"st. chor." },
        {10,"st. chor. sztab." },
        {11,"ppor." },
        {12,"por." },
        {13,"kpt." },
        
};



        public static Dictionary<int, string> WyjsciaSlownik = new Dictionary<int, string>()
        {

        {0,"PS" },
        {1, "PJ" },
        {2,"KU" },
        {3,"PSŁ" }


};
    }
}
