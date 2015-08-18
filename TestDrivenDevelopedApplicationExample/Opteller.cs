using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDrivenDevelopedApplicationExample
{
    /// <summary>
    /// Simpele class die verantwoordelijk is voor optellen van de getallen
    /// </summary>
    public class Opteller
    {
        /// <summary>
        /// Methode om getallen op te tellen
        /// </summary>
        /// <param name="getal1">Het eerste getal om op te tellen</param>
        /// <param name="getal2">Het tweede getal om op te tellen</param>
        /// <returns>Uitkomst van de opgetelde getallen</returns>
        public int getallenOptellen(int getal1, int getal2)
        {
            return getal1 + getal2;
        }
    }
}
