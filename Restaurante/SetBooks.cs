using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace Exercises3
{

    public class SetBooks 
    {
        private int _index= 0;
        private Book[] _books= new Book[10];
        
        public void AddBooks(){
        	Book book= new Book();
        	if(_index > 10){
        		Console.WriteLine("No puede ingresar mas libros.");
        		return;
        	}
        	Console.Clear();
        	Console.WriteLine("			Ingresar libros\n");
        	Console.Write("Titulo: ");
        	book.Tittle= Console.ReadLine();
        	Console.Write("Autor: ");
        	book.Author= Console.ReadLine();
        	Console.Write("Numero de paginas: ");
        	book.Pages= int.Parse(Console.ReadLine());
        	Console.Write("Calificacion: ");
        	book.Qualification= int.Parse(Console.ReadLine());
        	_books[_index]= book;
        	_index++;
        	
        	Console.WriteLine("\nLibro ingresado exitosamente.\nPresione una tecla para continuar");
	        Console.ReadKey();
        }
        public void SeeBooks(){
	        Console.Clear();
	        if(_books[0] != null){
	        	for(int i=0; i<_index; i++){
	        		Console.WriteLine("\nLibro {0}", (i+1));
	        		Console.WriteLine(_books[i]);
	        	}
	        }else{
	        	Console.WriteLine("No hay libros registrados");
	        }
	        Console.WriteLine("\nPresione una tecla para continuar");
	        Console.ReadKey();
        }
    }
}