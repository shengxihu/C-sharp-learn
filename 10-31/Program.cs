
using System;

namespace InterfaceApplication
{
    interface Ibody {
       void Breath();
       void Eat();
    }
    class Animal:Ibody {
       public void Breath()//实现接口的方法
     	 {
              Console.WriteLine("动物吸收氧气，呼出二氧化碳.");
          }
        public void Eat()//实现接口的方法
     	 {
              Console.WriteLine("动物吸收氧气，呼出二氧化碳.");
          }
    }
    class Plants:Ibody {
       public void Breath()//实现接口的方法
     	 {
              Console.WriteLine("植物吸收二氧化碳，呼出氧气.");
          }
        public void Eat()//实现接口的方法
     	 {
              Console.WriteLine("植物是靠光合作用的.");
          }
    }
    class Test
   {
      static void Main()
        {
            Animal dog = new Animal();
            Plants tree = new Plants();
            dog.Breath();
            dog.Eat();
            tree.Breath();
            tree.Eat();
            Console.ReadKey();
        }
   }
}

