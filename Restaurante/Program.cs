using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace Exercises3
{

    public class Program 
    {
        public static void Main()
        {
			int opt;
			SetBooks nBooks= new SetBooks();
			CreateBill clientBill= new CreateBill();
			do{
				Console.Clear();
				Console.WriteLine("					POO - Guia 3");
				Console.WriteLine("\n					  Opciones");
				Console.WriteLine("\n1.Libros\n2.Restaurante\n3.Salir\n");
				opt= int.Parse(Console.ReadLine());
				Console.Clear();
				switch(opt){
					case 1:
						Console.WriteLine("					Libros");
						Console.WriteLine("\n				 Opciones");
						Console.WriteLine("\n1.Ingresar un libro\n2.Ver los libros\n");
						opt= int.Parse(Console.ReadLine());
						switch(opt){
							case 1:
								nBooks.AddBooks();
								break;
							case 2:
								nBooks.SeeBooks();
								break;
						}
						break;
					case 2:
						Console.WriteLine("					Restaurante");
						clientBill.AddBill();
						clientBill.GenerateBill();
						break;
					case 3:
						Console.WriteLine("Programa terminado");
						Console.ReadKey();
						break;
					default:
						Console.WriteLine("Opcion no valida");
						Console.ReadKey();
						break;
				}
			}while(opt != 3);
        }
    }
}