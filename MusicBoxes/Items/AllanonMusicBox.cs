using ArcaneOdysseyMusic.MusicBoxes.Tiles;
using Terraria.ModLoader;

namespace ArcaneOdysseyMusic.MusicBoxes.Items
{
	public class AllanonMusicBox : MusicBox
	{
		public override int MusicBoxTile => ModContent.TileType<AllanonMusicBoxTile>();
		public override MusicTrack Music => MusicTrack.Allanon;
	}
}
