using ArcaneOdysseyMusic.MusicBoxes.Tiles;
using Terraria.ID;
using Terraria.ModLoader;

namespace ArcaneOdysseyMusic.MusicBoxes
{
	public class TitleMusicBox2 : MusicBox
	{
		public override int MusicBoxTile => ModContent.TileType<TitleMusicBoxTile2>();
		public override MusicTrack Music => MusicTrack.TitleTheme2;
	}
}
