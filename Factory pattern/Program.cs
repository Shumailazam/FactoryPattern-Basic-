using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_pattern
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Enter Your Object Type:");
            string type = Console.ReadLine();
           i1 obj = createobj.getobject(type);
            Console.WriteLine(obj.info());
            Console.ReadLine();

        }
    }

    interface i1
    {
        
        string info();
    }


     class createobj
    {
        public static i1 getobject(string typeofobj)
        {
            i1 obj = null;
            if(typeofobj.ToLower()=="weapon")
            {
                obj = new weapon();

            }   
            else
            {
                obj = new armour();
            }
            return obj;
        }
    }
    class weapon :i1
    {

        public Int32 id;
        public string name;
        public Int32 DamageRating;


        public string info()
        {
            return "Weapon ";
        }
    }
    class armour : i1
    {
        public Int32 id;
        public string name;
        public Int32 DamageRating;

        public string info()
        {
            return "weapon armour";
        }
    }



}
