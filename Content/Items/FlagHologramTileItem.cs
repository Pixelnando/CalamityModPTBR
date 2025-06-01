using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using CalamityModPTBR.Content.Tiles;

namespace CalamityModPTBR.Content.Items
{
    public class FlagHologramTileItem : ModItem
    {
        public override void SetDefaults()
        {
            if (ModLoader.TryGetMod("CalamityMod", out Mod calamityMod) && calamityMod.TryFind("LabHologramProjectorItem", out ModItem LabHologramProjector))
            {
                Item.CloneDefaults(LabHologramProjector.Type);
                Item.createTile = ModContent.TileType<FlagHologramTile>();
            }
        }
        public override void AddRecipes()
        {
            if (ModLoader.TryGetMod("CalamityMod", out Mod calamityMod) && calamityMod.TryFind("LaboratoryPlating", out ModItem LaboratoryPlating) && calamityMod.TryFind("DubiousPlating", out ModItem DubiousPlating))
            {
                CreateRecipe().
                    AddIngredient(LaboratoryPlating.Type, 10).
                    AddIngredient(DubiousPlating.Type, 5).
                    AddTile(TileID.Anvils).
                Register();
            }
        }
    }
}
