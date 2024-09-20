using Terraria;
using Terraria.Enums;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace tweakmod.Items.Weapons.LeafWhip
{
    public class LeafWhip : ModItem
    {
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.tweakmod.hjson file.
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            // This method quickly sets the whip's properties.
            // Mouse over to see its parameters.
            Item.DefaultToWhip(ModContent.ProjectileType<LeafWhipProjectile>(), 8, 2, 4);

            Item.shootSpeed = 4;
            Item.channel = false;

            Item.SetShopValues(ItemRarityColor.White0, 10);

        }

        // Please see Content/ExampleRecipes.cs for a detailed explanation of recipe creation.
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.WoodenSword, 1);
            recipe.AddIngredient(ItemID.Wood, 10);
            recipe.AddIngredient(ItemID.Acorn, 6);
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();
        }

        // Makes the whip receive melee prefixes
        public override bool MeleePrefix()
        {
            return true;
        }
    }
}