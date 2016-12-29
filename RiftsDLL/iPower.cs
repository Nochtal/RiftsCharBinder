using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiftsDLL
{
    public interface iPower
    {
        // Powers interface. Will splinter off to cover Spells, psychic powers,
        // technological powers, etc, based on the OCC for the character.
        string GetName();
        string GetType();
    }
}
