using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behaviroal_Patterns.Observer
{
    interface Watcher
    {
        void Notify(StockType type);
    }
}
