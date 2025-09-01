using Terraria;
using Terraria.ModLoader;
using System.Collections.Generic;

namespace CalamityModPTBR
{
    public class TranslationGlobalItem : GlobalItem
    {
        public override bool InstancePerEntity => true;

        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            var config = ModContent.GetInstance<TranslationConfig>();

            if (!config.mostrarNomeOriginal)
                return;

            foreach (var line in tooltips)
            {
                if (line.Mod == "Terraria" && line.Name == "ItemName")
                {
                    if (item.ModItem != null && item.ModItem.Mod.Name == "CalamityMod")
                    {
                        string internalName = ItemLoader.GetItem(item.type).Name;
                        line.Text = $"{line.Text} ({internalName})";
                    }
                    else
                    {
                        string internalName = item.Name;
                    }
                }
            }
        }
    }
}
