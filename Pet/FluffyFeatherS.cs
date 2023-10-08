using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using BumblePet;

namespace BumblePet.Pet
{
	public class FluffyFeatherS : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Ultra Fluffy Feather");
			Tooltip.SetDefault("Attracts the last of a species\nCannot be equipped as a pet and has to be actively used\nHowever, equipped pets can be used in conjunction with this one");
		}

		public override void SetDefaults() {
		Item.CloneDefaults(ItemID.ZephyrFish);
		Item.UseSound = SoundID.NPCHit51;
		Item.shoot = Mod.Find<ModProjectile>("MiniBumble").Type;
		Item.value = Item.sellPrice(0, 0, 0, 1);
		Item.rare = 10;
		Item.buffType = Mod.Find<ModBuff>("MiniBumbleBuff2").Type;
		}

		public override void UseStyle(Player player, Rectangle heldItemFrame) {
			if (player.whoAmI == Main.myPlayer && player.itemTime == 0) {
				player.AddBuff(Item.buffType, 3600, true);
			}
		}
	

	public override void AddRecipes()
    {
            {
                Recipe recipe = CreateRecipe();
                recipe.AddIngredient(Mod.Find<ModItem>("FluffyFeather").Type, 1);
                recipe.AddTile(TileID.LunarCraftingStation);
                recipe.Register();
			}
    }
}
}