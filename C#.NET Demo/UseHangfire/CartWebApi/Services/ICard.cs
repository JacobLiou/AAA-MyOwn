using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CartWebApi.Services
{
    public  interface ICard
    {
        public string CardNumber { get; set; }
        public string Name { get; set; }
        public DateTime ValidTo { get; set; }

        public double Amount { get; set; }
    }
}
