using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using BumblePet;

namespace BumblePet
{
	public class BumblePetPlayer : ModPlayer
	{
		private const int saveVersion = 0;

		public bool mBirb = false;
		public bool mBirb2 = false;
		public bool mDoge = false;
		
		public override void ResetEffects()
		{
			mBirb = false;
			mBirb2 = false;
			mDoge = false;
		}

		public override void UpdateDead()
		{
			mBirb = false;
			mBirb2 = false;
			mDoge = false;
		}
	}
}
