using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace Exercises3
{

    public class CreateBill 
    {
        private int _index= 0;
        private int _amount;//Cantidad de tipos de comidas y bebidas a ingresar
        private Bill[] _bills= new Bill[10];
        
        public void AddBill(){
        	Bill bills= new Bill();
        	//Meals meal= new Meals();
        	
        	decimal pay, change=0;
        	
        	Console.Clear();
        	Console.WriteLine("					Crear ticket\n");
        	Console.Write("Numero de cuenta: ");
        	bills.BillNum= int.Parse(Console.ReadLine());
        	Console.Write("Numero de mesa: ");
        	bills.TableNum= int.Parse(Console.ReadLine());
        	Console.Write("Numero del mesero: ");
        	bills.WaiterNum= int.Parse(Console.ReadLine());
        	Console.Write("Numero de personas atendidas: ");
        	bills.PeopleNum= int.Parse(Console.ReadLine());
        	
        	//Agregar la comida
        	Console.WriteLine("\nIngrese la cantidad de tipos de comidas y bebidas ");
        	Console.Write("consumidos(pollo, carne, soda, etc.): ");
        	_amount= int.Parse(Console.ReadLine());
        	
        	for(int i=0; i< _amount; i++){
        		Meals meal= new Meals();
        		Console.Write("\nComida o bebida: ");
        		meal.Food= Console.ReadLine();
        		Console.Write("Precio: ");
        		meal.Price= decimal.Parse(Console.ReadLine());
        		Console.Write("Cantidad: ");
        		meal.Amount= int.Parse(Console.ReadLine());
        		//Sacar el total de cada comida o bebeida
        		meal.Total= meal.Amount * meal.Price;
        		bills.Subtotal += meal.Total;
        		//Agregar el arreglo de meals a _biils
        		bills.meals[i]= meal;
        		
        	}
        	//Pago y Propina
        	Console.WriteLine("\nTotal a pagar: {0:0.00}", bills.Subtotal);
        	Console.Write("Pago: ");
        	pay= decimal.Parse(Console.ReadLine());
        	if(pay > bills.Subtotal){
        		change= pay - bills.Subtotal;
        	}else{
        		change= 0;
        	}
        	Console.WriteLine("Cambio: {0:0.00}", change);
        	Console.Write("\nPropina: ");
        	bills.Tip= decimal.Parse(Console.ReadLine());
        	bills.FinalTotal= bills.Tip + bills.Subtotal;
        	//Total final
        	bills.FinalTotal= bills.Subtotal + bills.Tip;
        	_bills[_index]= bills;
        	_index++;
        }
        
        public void GenerateBill(){
        	Console.Clear();
        	Console.WriteLine("				ESTADO DE CUENTA");
        	Console.WriteLine("				EXIJA SU FACTURA\n");
        	Console.WriteLine("CUENTA		{0}			MESA			{1}", _bills[_index-1].BillNum, _bills[_index-1].TableNum);
        	Console.WriteLine("MESERO		{0}			PERSONAS		{1}\n", _bills[_index-1].WaiterNum, _bills[_index-1].PeopleNum);
        	for(int i=0; i< _amount; i++){
        		Console.WriteLine("{0} x		${1:0.00}", _bills[_index-1].meals[i].Amount, _bills[_index-1].meals[i].Price);
        		Console.WriteLine("{0}            ${1:0.00}", _bills[_index-1].meals[i].Food.ToUpper(), _bills[_index-1].meals[i].Total);
        	}
        	Console.WriteLine("				      -------------------");
        	Console.WriteLine("SUBTOTAL                ${0:0.00}", _bills[_index-1].Subtotal);
        	Console.WriteLine("PROPINA                 ${0:0.00}", _bills[_index-1].Tip);
        	Console.WriteLine("TOTAL                   ${0:0.00}", _bills[_index-1].FinalTotal);
        		
        	Console.ReadKey();
        }
    }
}
/*
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
        	return string.Format("
Titulo: {0}
Autor: {1}
Numeto de paginas: {2}
Calificacion: {3}", Tittle, Author, Pages, Qualification);
        }
    }
*/