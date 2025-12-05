using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Compactor.Content.Items.Accessories {
    public class CompactedMiningArmor : ModItem {


        public override void SetDefaults() {
            Item.DefaultToAccessory(32, 32);
            Item.rare = ItemRarityID.Blue;
            Item.value = Item.sellPrice(gold: 1);
        }

        public override void UpdateAccessory(Player player, bool hideVisual) {
            player.pickSpeed -= 0.3f;
            base.UpdateAccessory(player, hideVisual);
        }

        public override void AddRecipes() {
            CreateRecipe()
                .AddIngredient(ItemID.MiningHelmet)
                .AddIngredient(ItemID.MiningShirt)
                .AddIngredient(ItemID.MiningPants)
                .AddTile(TileID.TinkerersWorkbench)
                .Register();
        }
    }
}
