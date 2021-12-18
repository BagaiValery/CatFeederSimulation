using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Enity;

namespace Model.Service
{
    interface ICatService
    {
        public void Eat(Feeder feeder);
        public void Meow(/*Feeder*/);
    }
}
