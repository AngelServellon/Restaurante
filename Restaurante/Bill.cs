using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace Exercises3
{

    public class Bill 
    {
        public int BillNum;
        public int TableNum;
        public int WaiterNum;
        public int PeopleNum;
        public decimal Tip;
        public decimal Subtotal= 0;
        public decimal FinalTotal;
        
        public Meals[] meals= new Meals[20];
        
    }
}