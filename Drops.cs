using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using BumblePet;
using BumblePet.Pet;
using Terraria.GameContent.ItemDropRules;

public class Drops : GlobalNPC
{
	public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {
		Mod mod;
		ModLoader.TryGetMod("CalamityMod", out mod);
		if (mod == null)
		{
  		if (npc.type == NPCID.Harpy)
		{
			npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<FluffyFeather>(), 30));
		}
			return;
		}
  		if (npc.type == mod.Find<ModNPC>("Bumblefuck").Type)
		{
			npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<FluffyFeather>(), 3));
		}
	}
}
