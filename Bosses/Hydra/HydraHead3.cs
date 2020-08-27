using Terraria.ModLoader;using AAMod;
using Terraria.ID;
using AAMod.Misc;
using AAMod.Globals;

namespace AAModEXAI.Bosses.Hydra
{
    [AutoloadBossHead]
    public class HydraHead3 : HydraHead1
    {
        public override void SetDefaults()
        {
            base.SetDefaults();
            Head = 2;
        }
    }
}