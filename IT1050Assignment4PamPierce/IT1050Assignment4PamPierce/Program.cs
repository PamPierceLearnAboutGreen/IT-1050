using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT1050Assignment4PamPierce
{
    class Program
    {
        static void Main(string[] args)
        {
            MovieTrip MovieEvent = new MovieTrip();

            MovieEvent.AskDetail();
            MovieEvent.CalcPrice();
            MovieEvent.PrintPrice();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
    }
}
