﻿using Book.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    public interface IView
    {
        void ItemLoad(string path);
        void ItemUnload();
        void Finish(TestResult result);
    }
}
