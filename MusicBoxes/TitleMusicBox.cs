using ArcaneOdysseyMusic.MusicBoxes.Tiles;
using Terraria.ID;
using Terraria.ModLoader;

namespace ArcaneOdysseyMusic.MusicBoxes
{
	public class TitleMusicBox : MusicBox
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			ItemID.Sets.ShimmerTransformToItem[Type] = ModContent.ItemType<TitleMusicBox2>();
		}

		public override int MusicBoxTile => ModContent.TileType<TitleMusicBoxTile>();
		public override MusicTrack Music => MusicTrack.TitleTheme;
	}
}
