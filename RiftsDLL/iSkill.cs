using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiftsDLL
{
    public interface iSkill
    {
        // Skills! Skills can be either primary or secondary. That will be handled 
        // by the OCC of the character.
        string GetName();
        string GetDescription();
        int GetProfeciency();
        int GetBasePro();
        int GetProPerLvl();
    }
}
