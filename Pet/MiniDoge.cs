using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using BumblePet;

namespace BumblePet.Pet
{
	public class MiniDoge : ModProjectile
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Mini Bumbledoge");
			Main.projFrames[Projectile.type] = 5;
			Main.projPet[Projectile.type] = true;
		}

		public override void SetDefaults() {
			Projectile.CloneDefaults(ProjectileID.ZephyrFish);
			AIType = ProjectileID.ZephyrFish;
		}

		public override bool PreAI() {
			_ = Main.player[Projectile.owner];
			return true;
		}

		public override void AI() {
			Player player = Main.player[Projectile.owner];
			BumblePetPlayer modPlayer = player.GetModPlayer<BumblePetPlayer>();
			if (player.dead) {
				modPlayer.mDoge = false;
			}
			if (modPlayer.mDoge) {
				Projectile.timeLeft = 2;
			}
		}
	}
}