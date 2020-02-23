using System.Text.RegularExpressions;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace SCTNPCP.Items
{
    public abstract class Caught : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault($"The {Regex.Replace(Name, "([A-Z])", " $1").Trim()}");
        }
        public override void SetDefaults()
        {
            base.SetDefaults();
            item.width = 20;
            item.height = 20;
            item.maxStack = 5;
            item.rare = 1;
            item.useStyle = 1;
            item.useAnimation = 15;
            item.useTime = 10;
            item.consumable = true;
            item.UseSound = SoundID.Item44;
        }
    }
}