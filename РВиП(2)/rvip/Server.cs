using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace rvip
{
    public class Server: CollectionBase
    {
        
        ConcurrentBag<string> cb_speed = new ConcurrentBag<string>();
        ConcurrentBag<string> cb_count = new ConcurrentBag<string>();
        int s = 0;
        public int name;
        public Server(int _name)
        {
            name = _name;
        }    
        public void Get_info()
        {
            Console.WriteLine("Сервер-"+name.ToString()+ " принимает запрос");           
        }
        public void Och()
        {
            Console.WriteLine("Постановка сообщения в очередь");
            Thread.Sleep(5);
        }
        public void Send(Poluch p)
        {
            Random r = new Random();
            s = r.Next(1, 10);
            Thread.Sleep(5);
            p.Get_info();
        }
       
        
    }
}
