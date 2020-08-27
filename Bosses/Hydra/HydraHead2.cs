using Terraria.ModLoader;using AAMod.Misc;
using AAMod.Globals;
using AAMod;

namespace AAModEXAI.Bosses.Hydra
{
    [AutoloadBossHead]
    public class HydraHead2 : HydraHead1
    {
        public override void SetDefaults()
        {
            base.SetDefaults();
            Head = 1;
        }
    }
}