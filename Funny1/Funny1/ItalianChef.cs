﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funny1
{
    internal class ItalianChef : Chef
    {
        public override void MakeSpecialDish()
        {
            Console.WriteLine("The Chef makes chicken parm");
        }

        public void MakePasta()
        {
            Console.Write("The Chef makes pasta");
        }
    }
}
