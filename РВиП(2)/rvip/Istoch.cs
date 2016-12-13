using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace rvip
{
    class Istoch //Источник сообщения
    {
        
        const int slep = 5;
        int s = 0;
        public int name;
       
        public Istoch(int _name)
        {
            name = _name;
        }            
  
        public void Send(Server sv)
        {
            Random r = new Random();
            s = r.Next(1, 10);
            Thread.Sleep(5);
            sv.Get_info();
        }
    }
}
