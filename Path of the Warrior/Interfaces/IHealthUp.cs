using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Characters;

namespace Interfaces
{
    public interface IHealthUp
    {
        int BonusHealth { get; set; }

        void AddHealth(Character character);
    }
}
