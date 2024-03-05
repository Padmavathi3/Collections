using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace newProject
{
    /*internal class ListCrud
    {
        public static List<ListCrud> listobj = new List<ListCrud>();
        private int id {  get; set; }
        private string name { get; set; }

        private int age { get; set; }
        public void add()
        {
            ListCrud l=new ListCrud();  
            Console.WriteLine("enter id");
            l.id=int.Parse(Console.ReadLine());
            int c1 = 0;
            if(listobj.Count>0 )
            {
                foreach(ListCrud c in listobj) 
                {
                    if(c.id.Equals(l.id))
                    {
                        c1++; 
                    }
                }
            }
            if (c1 > 0)
            {
                Console.WriteLine("name already exist");
            }
            else
            {
                Console.WriteLine("enter name");
                l.name = Console.ReadLine();
                Console.WriteLine("enter age");
                l.age = int.Parse(Console.ReadLine());
            }

            listobj.Add(l);
            Console.WriteLine("Do you want to check another option");
            string op = Console.ReadLine();
            if (op.ToLower() == "yes")
            {
                MainList.Main(new string[] { });
            }
        }
        public void Update() 
        {
            Console.WriteLine("enter name to be updated");
            string sname=Console.ReadLine();
           
            foreach (var item in listobj) 
            { 
                if(item.name.Equals(sname))
                {
                    Console.WriteLine("enter updated field");
                    var  field=Console.ReadLine();
                    Console.WriteLine("enter updated value");
                 
                    switch(field) 
                    {
                        case "id":
                            var value=int.Parse(Console.ReadLine());
                            item.id = value;
                            break;
                        case "name":
                            var nvalue = Console.ReadLine();
                            item.name = nvalue;
                            break;
                        case "age":
                            var avalue = int.Parse(Console.ReadLine());
                            item.age = avalue;
                            break;
                        default:
                            Console.WriteLine("this field is not available in list");
                            break;

                    }
                }
                else
                {
                    Console.WriteLine("name is not available");
                }
            }
            Console.WriteLine("Do you want to check another option");
            string op = Console.ReadLine();
            if (op.ToLower() == "yes")
            {
                MainList.Main(new string[] { });
            }

        }

        public void delete()
        {
            Console.WriteLine("enter name to be deleted");
            string sname = Console.ReadLine();
            ListCrud ab = null;
            foreach (var item in listobj)
            {
                if (item.name.Equals(sname))
                {
                    ab= item;
                    //int i=listobj.IndexOf(item);
                    //listobj.RemoveAt(i);
                    //Console.WriteLine("deletion done");
                }
            }
            if(ab != null) 
            {
                int i = listobj.IndexOf(ab);
                listobj.RemoveAt(i);
                Console.WriteLine("deletion done");
            }

            Console.WriteLine("Do you want to check another option");
            string op = Console.ReadLine();
            if (op.ToLower() == "yes")
            {
                MainList.Main(new string[] { });
            }
        }
        public void show()
        {
            foreach(ListCrud item in listobj)
            {
                Console.WriteLine("id  " + item.id);
                Console.WriteLine("name  " + item.name);
                Console.WriteLine("age  " + item.age);
            }
            Console.WriteLine("Do you want to check another option");
            string op = Console.ReadLine();
            if (op.ToLower() == "yes")
            {
                MainList.Main(new string[] { });
            }

        }
    }

    class MainList
    {
        public static void Main(string[] args) 
        {
            ListCrud l = new ListCrud();
            
            Console.WriteLine("1.add\n2.edit\n3.delete\n4.show");
            Console.WriteLine("enter choice");
            int ch = int.Parse(Console.ReadLine());
            switch (ch) 
            {
                case 1:
                    l.add();
                    break;
                case 2:
                    l.Update();
                    break;
                case 3:
                    l.delete();
                    break;
                case 4:
                    l.show();
                    break;
                default:
                    Console.WriteLine("invalid");
                    break;


            }

        }
    }*/
}
