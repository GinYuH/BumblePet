using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using BumblePet;

namespace BumblePet.Pet
{
	public class MiniBumble : ModProjectile
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Mini Bumble");
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
				modPlayer.mBirb = false;
			}
			if (modPlayer.mBirb) {
				Projectile.timeLeft = 2;
			}
		}
	}
}