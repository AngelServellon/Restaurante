using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace Exercises3
{

    public class Book
    {
        public string Tittle { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        private int _quali;
        public int Qualification { 
        	get{
        		return _quali;
        	} set{
        		_quali = value >10 ? 10 : value;
        	}
        }
        public override string ToString(){
        	return string.Format("\nTitulo: {0}\nAutor: {1}\nNumero de paginas: {2}\nCalificacion: {3}", Tittle, Author, Pages, Qualification);
        }
    }
}