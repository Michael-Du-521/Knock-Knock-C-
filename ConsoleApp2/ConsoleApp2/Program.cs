using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2


{


    class Dog {
        // 声明事件的委托
        public delegate void AlarmEventHandler(object sender, EventArgs e);

        //声明事件
        public event AlarmEventHandler BiteAlarm;

        //引发该事件的函数
        public void OnAlarm()
        {
            if (this.BiteAlarm != null)
            {
                Console.WriteLine("\nWarning from doggie : this is a thief wolf wolf!");
                this.BiteAlarm(this, new EventArgs());
                //If there are subscribers, it invokes the event by calling the delegate that is currently assigned to the BiteAlarm event, and passing in two arguments
                //the EventArgs class is used as a placeholder to indicate that there are no additional arguments.
            }
        }
    
    }

    class Host { 
        //编写事件处理程序
    void HostHandleAlarm(object sender,EventArgs e)
        {
            Console.WriteLine("the host called 911");
        }
    //注册事件处理程序
        public Host(Dog dog)
        {
            dog.BiteAlarm += new Dog.AlarmEventHandler(HostHandleAlarm);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Host host = new Host(dog);

            DateTime now = new DateTime(2008, 12, 31, 23, 59, 50);
            DateTime midnight = new DateTime(2009, 1, 1, 0, 0, 0);
            Console.WriteLine("Time passes");
            //读秒输出
            while (now < midnight)
            {
                Console.WriteLine("currentTime: "+now);
                System.Threading.Thread.Sleep(1000);
                now = now.AddSeconds(1);
            }
            Console.WriteLine("\n it is a very dark midnight:"+now);
            Console.WriteLine("the thief sneaked into the house of the host");
            dog.OnAlarm();

        }
    }
}
