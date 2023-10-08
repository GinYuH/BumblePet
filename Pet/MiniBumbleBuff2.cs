

// BumblePet.Pet.MiniBumbleBuff
using BumblePet;
using Terraria;
using Terraria.ModLoader;
using BumblePet.Pet;

namespace BumblePet.Pet
{
public class MiniBumbleBuff2 : ModBuff
{
	public override void SetStaticDefaults()
	{
		DisplayName.SetDefault("Mini Birb");
		Description.SetDefault("Tweet");
		Main.buffNoTimeDisplay[Type] = true;
		Main.buffNoSave[Type] = true;
	}

	public override void Update(Player player, ref int buffIndex)
	{
		BumblePetPlayer modPlayer = player.GetModPlayer<BumblePetPlayer>();
		if (player.ownedProjectileCounts[Mod.Find<ModProjectile>("MiniBumble").Type] > 0)
		{
			modPlayer.mBirb2 = true;
		}
		if (!modPlayer.mBirb2)
		{
			player.DelBuff(buffIndex);
			buffIndex--;
		}
		else
		{
			player.buffTime[buffIndex] = 18000;
		}
	}
}
}