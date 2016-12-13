using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace rvip
{
    class Program
    {
        const int MaxCountist = 2;
        const int MaxCount = 3;
         static int q = 1;
        
         
        Server serv = new Server(q);
        static int cb = 0;
        static void Main(string[] args)
        {     
            Program p = new Program();
 
            //потоки
            for (int i = 0; i < MaxCountist; i++)
            {
                Thread myThread = new Thread(p.cam1);
                myThread.Start();
       
            }
                        
            Thread.Sleep(100);
            Console.ReadLine();

            
            Console.Read();
           
        }
        void cam1()
        {
            cb++;
            q++;
            Console.WriteLine(cb);
            Istoch cam = new Istoch(cb);
            Poluch p = new Poluch();

            for (int i = 0; i < MaxCount; i++)
            {               
                Console.WriteLine("Источник-" + cam.name.ToString() + " отправляет запрос на Сервер-"+q.ToString());
                cam.Send(serv);
                serv.Och();
                Console.WriteLine("Сервер-"+q.ToString()+" отправляет сообщение ");
                serv.Send(p);
            }
         }

    }
}
