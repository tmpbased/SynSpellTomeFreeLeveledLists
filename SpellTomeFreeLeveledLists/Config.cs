using Mutagen.Bethesda.WPF.Reflection.Attributes;
using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Plugins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpellTomeFreeLeveledLists
{
    public class PatcherConfig
    {
        [Tooltip("The skill level from which spell tomes are purged from leveled lists. Setting it to -1 means there is no upper level limit.\nTiers (based on vanilla leveled lists):\n0 - Novice\n25 - Apprentice\n50 - Adept\n75 - Expert\n100 - Master")]
        public int MaxSpellTomeSkillLevel { get; set; } = -1; // (x..+inf), if x != -1


        [Tooltip("The skill level below which spell tomes are purged from leveled lists. Setting it to 0 means there is no lower level limit.\nTiers (based on vanilla leveled lists):\n0 - Novice\n25 - Apprentice\n50 - Adept\n75 - Expert\n100 - Master")]
        public int MinSpellTomeSkillLevel { get; set; } = 100; // [0..x)
    }
}
