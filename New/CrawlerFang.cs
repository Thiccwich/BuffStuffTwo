using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Thicc.New
{
    public class CrawlerFang : ModItem
    {
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.WormTooth);
        }
        public override void AddRecipes()
        {
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.WoodenArrow, 5);
                recipe.AddIngredient(ItemType<CrawlerFang>(), 1);
                recipe.AddTile(TileID.Anvils);
                recipe.SetResult(ItemID.UnholyArrow, 5);
                recipe.AddRecipe();

            }
        }
    }
}
