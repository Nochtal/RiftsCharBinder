using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiftsDLL
{
    public interface iCharacter
    {
        // Base interface for the character object.
        // Is built through numerous other objects such as powers,
        // skills, and an OCC.
        string CharName();
        iOCC GetOCC();
        List<iPower> GetPowers();
        List<iSkill> GetSkills();
    }
}
