using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using BumblePet;

namespace BumblePet.Pet
{
	public class FluffyFur : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Extra Fluffy Feather Clump");
			Tooltip.SetDefault("ISEJFDOIJNJSNFDGUISDBJNGSDJG\nSummons a beast, so horrific, that you will die\ngneurshk");
		}

		public override void SetDefaults() {
		Item.CloneDefaults(ItemID.ZephyrFish);
		Item.UseSound = SoundID.NPCHit51;
		Item.shoot = Mod.Find<ModProjectile>("MiniDoge").Type;
		Item.value = Item.sellPrice(1, 0, 0, 1);
		Item.rare = 11;
		Item.buffType = Mod.Find<ModBuff>("MiniDogeBuff").Type;
		}

		public override void UseStyle(Player player, Rectangle heldItemFrame) {
			if (player.whoAmI == Main.myPlayer && player.itemTime == 0) {
				player.AddBuff(Item.buffType, 3600, true);
			}
		}
		
		public override void AddRecipes()
    {
    Mod BublePet;
ModLoader.TryGetMod("CalamityMod", out BublePet);
            {
if (BublePet != null)
{
                Recipe recipe = CreateRecipe();
                recipe.AddIngredient(Mod.Find<ModItem>("FluffyFeather").Type, 10);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("EffulgentFeather").Type, 200);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("CosmicDischarge").Type, 1);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("HolyCollider").Type, 1);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("BansheeHook").Type, 1);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("StreamGouge").Type, 1);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("SoulEdge").Type, 1);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Valediction").Type, 1);
                recipe.AddTile(ModLoader.GetMod("CalamityMod").Find<ModTile>("DraedonsForge").Type);
                recipe.Register();
			}
    }
}
	}
}