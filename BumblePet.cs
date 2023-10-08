using Terraria.ModLoader;

namespace BumblePet
{
	public class BumblePet : Mod
	{
		public BumblePet()
		{
		}
        public static BumblePet instance;
        public override void Load()
        {
            instance = this;
}
        public override void Unload()
        {
            instance = null;
}
	}
}