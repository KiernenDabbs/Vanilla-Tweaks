using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace tweakmod.Content.ItemTweaks.Armor.Pharoah
{
    // This file shows a very simple example of a GlobalItem class. GlobalItem hooks are called on all items in the game and are suitable for sweeping changes like 
    // adding additional data to all items in the game. Here we simply adjust the damage of the Copper Shortsword item, as it is simple to understand. 
    // See other GlobalItem classes in ExampleMod to see other ways that GlobalItem can be used.
    public class PharohSet : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (item.type == ItemID.PharaohsMask)
            { // Here we make sure to only change Copper Shortsword by checking item.type in an if statement
                item.defense = 1; //Change item defense to 1
                item.vanity = false; //Changes item to non-vanity
                /*Tooltip.SetDefault("This is a modded body armor."
                + "\nImmunity to 'On Fire!'"
                + "\n+20 max mana and +1 max minions");*/
            }
            if (item.type == ItemID.PharaohsRobe)
            { // Here we make sure to only change Copper Shortsword by checking item.type in an if statement
                item.defense = 1; //Change item defense to 1
                item.vanity = false; //Changes item to non-vanity
            }




        /*
        if (item.type == ItemID.CopperShortsword)
        { // Here we make sure to only change Copper Shortsword by checking item.type in an if statement
            item.damage = 50;       // Changed original CopperShortsword's damage to 50!
        }
        */
    }


    }
}
