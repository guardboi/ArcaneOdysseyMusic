using Terraria.ModLoader;
using Terraria.ID;
using Terraria.Localization;

namespace ArcaneOdysseyMusic.MusicBoxes.Items
{
	public abstract class MusicBox : ModItem
	{
		public abstract int MusicBoxTile { get; }
		public abstract MusicTrack Music { get; }

		public override void SetStaticDefaults()
		{
			ItemID.Sets.CanGetPrefixes[Type] = false;
			ItemID.Sets.ShimmerTransformToItem[Type] = ItemID.MusicBox;
			MusicLoader.AddMusicBox(Mod, Music.MusicSlot, Type, MusicBoxTile);
		}

		public override LocalizedText Tooltip => Mod.GetLocalization("Tooltip", () => "Plays '{0}' by {1}").WithFormatArgs(Music.DisplayName, Music.Author);

		public override void SetDefaults()
		{
			Item.DefaultToMusicBox(MusicBoxTile, 0);
		}
	}
}
