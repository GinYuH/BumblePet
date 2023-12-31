﻿using Terraria;
using Terraria.ModLoader;
using BumblePet;
using BumblePet.Pet;

namespace BumblePet.Pet
{
	public class MiniDogeBuff : ModBuff
	{		
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Mini Bumbledoge");
		        Description.SetDefault("Bark");
			Main.buffNoTimeDisplay[Type] = true;
			Main.vanityPet[Type] = true;
		}
		
		public override void Update(Player player, ref int buffIndex) {
			player.buffTime[buffIndex] = 18000;
			player.GetModPlayer<BumblePetPlayer>().mDoge = true;
			bool petProjectileNotSpawned = player.ownedProjectileCounts[ModContent.ProjectileType<Pet.MiniDoge>()] <= 0;
			if (petProjectileNotSpawned && player.whoAmI == Main.myPlayer) {
				Projectile.NewProjectile(player.GetSource_Buff(buffIndex), player.position.X + (float)(player.width / 2), player.position.Y + (float)(player.height / 2), 0f, 0f, ModContent.ProjectileType<Pet.MiniDoge>(), 0, 0f, player.whoAmI, 0f, 0f);
			}
		}
	}
}