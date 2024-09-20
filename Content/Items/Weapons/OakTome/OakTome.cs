using Terraria;
using Terraria.Enums;
using Terraria.ID;
using Terraria.ModLoader;

namespace tweakmod.Content.Items.Weapons.OakTome
{
    public class OakTome : ModItem
    {
        public override void SetDefaults()
        {
            // DefaultToStaff handles setting various Item values that magic staff weapons use.
            // Hover over DefaultToStaff in Visual Studio to read the documentation!
            // Shoot a leaf, also known as the projectile shot from the leaf blower.
            Item.DefaultToStaff(ProjectileID.Leaf, 7, 20, 1);
            Item.width = 18;
            Item.height = 26;
            Item.UseSound = SoundID.Grass;

            // A special method that sets the damage, knockback, and bonus critical strike chance.
            // This weapon has a crit of 16% which is added to the players default crit chance of 4%
            Item.SetWeaponValues(8, 6, 16); // 8 damage, 6 knockback, 16 crit modifier

            Item.SetShopValues(ItemRarityColor.White0, 10);
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.Wood, 25);
            recipe.AddIngredient(ItemID.Acorn, 5);
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();
        }

        public override void ModifyManaCost(Player player, ref float reduce, ref float mult)
        {
            // We can use ModifyManaCost to dynamically adjust the mana cost of this item, similar to how Space Gun works with the Meteor armor set.
            if (player.statLife < player.statLifeMax2 / 2)
            {
                mult *= 0.5f; // Half the mana cost when at low health. Make sure to use multiplication with the mult parameter.
            }
        }
    }
}