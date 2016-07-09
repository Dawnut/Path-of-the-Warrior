using Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IDamageUp
    {
        int BonusDamage { get; set; }

        void AddDamage(Character character);
    }
}
