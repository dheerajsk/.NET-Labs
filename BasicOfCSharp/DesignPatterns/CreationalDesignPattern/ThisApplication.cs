using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalDesignPattern
{
    class ThisApplication
    {
        private static ThisApplication _instance;
        private string name = "ThisApplication";

        private ThisApplication()
        {

        }

        public static ThisApplication Instance()
        {
            if (_instance == null)
            {
                _instance = new ThisApplication();
            }
            return _instance;
        }

        public string getName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }
    }
}
