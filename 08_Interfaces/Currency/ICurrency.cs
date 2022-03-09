using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Interfaces.Currency
{
    public interface ICurrency
    {
        //couple code or dependance enjection (CD and CD player)

        string Name { get; }
        decimal Value { get; }

    }
}
