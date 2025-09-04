﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesApp.Model
{
    internal abstract class  AbstractPoint : IMovable
    {
        public int X { get; set; }
        public AbstractPoint() 
        { 
        }

        protected AbstractPoint(int x)
        {
            X = x;
        }

        public virtual void Move10()
        {
            Console.WriteLine("Moved by 10");
        }

        public virtual void Move15() 
        {
            Console.WriteLine("Moved by 15");
        }
    }
}
