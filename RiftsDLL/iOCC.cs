using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiftsDLL
{
    public interface iOCC
    {
        /// Base interface for Occupational Character Classes
        /// Each character has an OCC or RCC (racial character class)
        /// This object will determine what powers and skills 
        /// the character has.
        string GetName();
        string GetCategory();
    }
}
