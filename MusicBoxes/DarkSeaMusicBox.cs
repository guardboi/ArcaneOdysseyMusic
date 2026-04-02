using ArcaneOdysseyMusic.MusicBoxes.Tiles;
using Terraria.ModLoader;

namespace ArcaneOdysseyMusic.MusicBoxes
{
	public class DarkSeaMusicBox : MusicBox
	{
		public override int MusicBoxTile => ModContent.TileType<DarkSeaMusicBoxTile>();
		public override MusicTrack Music => MusicTrack.DarkSea;
	}
}
