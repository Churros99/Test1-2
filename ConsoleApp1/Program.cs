using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*
				Reverse the elements in the list "hello"
	   
				Output:
				 H
				e
				l
				l
				o
				-
				M
				T
				e
				c
				h
				!!

            string[] hello = new string[] { "!!", "h", "c", "e", "T", "M", "-", "o", "l", "l", "e", "H" };

			for (int i = hello.Length-1; i > -1; i--)
			{
				Console.WriteLine(hello[i]);
			}
			Console.ReadLine();

            
				Count matching elements in the list that contains 'ei'
				Expected Results: Count: 1
			
            var words = new List<string> { "believe", "relief", "receipt", "field" };

			Console.WriteLine( words.Count(d => d.Contains("ei")));
			Console.ReadLine();
			*/


			/*
			 1) 
			  Create new class 'TruckWeight' with the following properties
				> TruckID (string)
				> Capacity (decimal)	   
				> Active (bool)	
			  2) 
				Create a list/collection of truck weights
				| TruckID	     |	Capacity	|	Active	|
				----------------------------------------------
				| Fuel Truck      |   10000      |   True    |
				| Tanker          |   22000		|   True	|
				| Trailer		 |   50000		|   True	|
				| Car Transporter |   30000		|   False   |
				3)
				 Find the active trucks with capacity less than 50000
			*/

			/*
			List<TruckWeight> list = new List<TruckWeight>();
			list.Add(new TruckWeight { TruckID = "Fuel Truck", Capacity = 10000, Active = true });
            list.Add(new TruckWeight { TruckID = "Tanker", Capacity = 22000, Active = true });
            list.Add(new TruckWeight { TruckID = "Trailer", Capacity = 50000, Active = true });
            list.Add(new TruckWeight { TruckID = "Car Transporter", Capacity = 30000, Active = false });

			List<TruckWeight> truck = list.FindAll(d => d.Capacity < 50000 & d.Active == true).ToList();

			foreach(TruckWeight t in truck)
			{
                Console.WriteLine(t.TruckID);
            }
			Console.ReadLine();

			*/





        }

		public class TruckWeight
		{
			public string TruckID { get; set; }
			public decimal Capacity { get; set; }
			public bool Active { get; set; }
		}
			

    }
}
