using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{

    public struct Customer
    {
        private int _id;
        private string _name;

        public int Id             // for automatic ---- 1.right click on properties
        {                         //2. refactoring
            get { return _id; }   //3. encapsualate field
            set { _id = value; }
        }

        public string Name 
        { 
            get => _name;
            set => _name = value; 
        }

        public Customer(int _id, string _name)
        {
            this._id = _id;
            this._name = _name;
        }

        public void printdetails()
        {
            Console.WriteLine("ID = {0} && Name = {1}",this._id, this.Name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer C1 = new Customer(101, "Nirav");
            C1.printdetails();

            Customer C2 = new Customer();
            C2.Id = 1;
            C2.Name = "tandel";
            C2.printdetails();
        }
    }
}
