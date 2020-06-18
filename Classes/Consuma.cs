using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Classes
{

    public class Consumo
    {
        public string Title { get; private set; }
        public int Percentage { get; private set; }

        public Consumo(string title, int percentage)
        {
            Title = title;
            Percentage = percentage;
        }
    }
}
