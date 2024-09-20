using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace tweakmod.Content.ItemTweaks.Armor.Pharoah
{
    public class PharohSet : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (item.type == ItemID.PharaohsMask)
            { 
                item.defense = 1; //Change item defense to 1
                item.vanity = false; //Changes item to non-vanity

                /*Tooltip.SetDefault("This is a modded body armor."
                + "\nImmunity to 'On Fire!'"
                + "\n+20 max mana and +1 max minions");*/
            }
            if (item.type == ItemID.PharaohsRobe)
            { 
                item.defense = 1; //Change item defense to 1
                item.vanity = false; //Changes item to non-vanity
            }
    }


    }
}
