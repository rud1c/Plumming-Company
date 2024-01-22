using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pluming_company
{
    class Program
    {
        static void Main(string[] args)
        {


            List<float> Deatils = new List<float>();
            string name;

            while (true)
            {

                Console.WriteLine("please enter customer name");
                name = (Console.ReadLine());

                if (name == "")
                {
                    Console.WriteLine("Enter valid Deatils");
                }

                break;
            }

            while (true)
            {

                Console.WriteLine("please enter days needed");
                Deatils.Add(float.Parse(Console.ReadLine()));

                if ((Deatils[0] == "")
                {
                    Console.WriteLine("Enter valid Deatils");
                }

                break;
            }

            while (true)
            {

                Console.WriteLine("please enter cost of materials");
                Deatils.Add(float.Parse(Console.ReadLine()));

                if (string.Format(Deatils[1]) == "")
                {
                    Console.WriteLine("Enter valid Deatils");
                }

                break;
            }

            while (true)
            {

                Console.WriteLine("please enter amount of special items");
                Deatils.Add(float.Parse(Console.ReadLine());

                if (Deatils[2] == "")
                {
                    Console.WriteLine("Enter valid Deatils");
                }

                break;
            }

            Console.Clear();
            Console.WriteLine("Deatils of customer:");

            for (int i = 0; i < Deatils.Count; i++)
            {
                Console.WriteLine("-" +
                    Deatils[i]);
            }

            double Labour = int.Parse(Deatils[0]) * 150;
            double Items = int.Parse(Deatils[2]) * 80.50;
            double TotalCost = (int.Parse(Deatils[1]) + Items + Labour);
            double Vat = (TotalCost * 0.2);
            double TotalCostVat = TotalCost + Vat;

            Console.WriteLine("Cost - £" + TotalCost);
            Console.WriteLine("Vat - £" + Vat);
            Console.WriteLine("Total - £" + TotalCostVat);

            Console.Clear();

            Console.WriteLine(name + "'s Bill");
            Console.WriteLine("----------------------");
            Console.WriteLine("Labour - £" + Labour);
            Console.WriteLine("Items - £" + Items);
            Console.WriteLine("Materials - £" + int.Parse(Deatils[1]));
            Console.WriteLine("Cost - £" + TotalCost);
            Console.WriteLine("Vat - £" + Vat);
            Console.WriteLine("Cost With Vat - £" + TotalCostVat);
            Console.WriteLine("Due in " + Deatils[1] + " days");
            Console.WriteLine("Babbers Plumbing LTD");

            Console.ReadLine();
        }
    }
}
