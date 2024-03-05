using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newProject
{
/*internal class DictionaryCrud
    {
      static Dictionary<int,(int id,string name,int age)> dobj=new  Dictionary<int, (int id, string name, int age)>();
      public void add()
        {
            int index = dobj.Count + 1;
            DictionaryCrud d=new DictionaryCrud();
            Console.WriteLine("enter id");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("enter name");
            string name = Console.ReadLine();
            Console.WriteLine("enter age");
            int age = int.Parse(Console.ReadLine());
            dobj.Add(index, (id, name, age));

            Console.WriteLine("do you want check another option:");
            string op1 = Console.ReadLine();
            if (op1.ToLower() == "yes")
            {
                MainDict.Main(new string[] { });


            }
        }

        public void Update()
        {
            //Console.WriteLine("updated");
            Console.WriteLine("enter key u want to be deleted");
            int k = int.Parse(Console.ReadLine());
            if (dobj.ContainsKey(k))
            {
                
                Console.WriteLine("enter field name");
                string field=Console.ReadLine();
                Console.WriteLine("enter updated field name");
                
                foreach (var item in dobj)
                {
                    if(item.Key == k) 
                    {
                        switch(field)
                        {
                            case "id":
                                int val = int.Parse(Console.ReadLine());
                                dobj[k] = (val, dobj[k].name, dobj[k].age);
                                
                                break;
                                
                              
                                break;
                            case "name":
                                string val1 = Console.ReadLine();
                                dobj[k] = (dobj[k].id, val1, dobj[k].age);
                                break;
                            case "age":
                                int val2 = int.Parse(Console.ReadLine());
                                dobj[k] = (dobj[k].id, dobj[k].name,val2);
                                break;
                        }
                    }
                }
            }

            Console.WriteLine("do you want check another option:");
            string op1 = Console.ReadLine();
            if (op1.ToLower() == "yes")
            {
                MainDict.Main(new string[] { });


            }
        }


        public void delete()
        {
            Console.WriteLine("enter key u want to be deleted");
            int k=int.Parse(Console.ReadLine());
            if(dobj.ContainsKey(k)) 
            { 
                dobj.Remove(k);
            }
            else
            {
                Console.WriteLine("key doesn't exist");
            }

            Console.WriteLine("do you want check another option:");
            string op1 = Console.ReadLine();
            if (op1.ToLower() == "yes")
            {
                MainDict.Main(new string[] { });


            }
        }

        public void display()
        {
            foreach (var i in dobj.Keys)
            {
                Console.WriteLine(i + " : " + dobj[i]);
            }
            Console.WriteLine("do you want check another option:");
            string op1 = Console.ReadLine();
            if (op1.ToLower() == "yes")
            {
                MainDict.Main(new string[] { });


            }
        }

        
    }
    class MainDict
    {
        public static void Main(string[] args)
        {
            DictionaryCrud l = new DictionaryCrud();

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
                    l.display();
                    break;
                default:
                    Console.WriteLine("invalid");
                    break;


            }

        }
    }*/
}
