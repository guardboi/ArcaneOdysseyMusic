using ArcaneOdysseyMusic.MusicBoxes.Tiles;
using Terraria.ModLoader;

namespace ArcaneOdysseyMusic.MusicBoxes
{
	public class EliusMusicBox : MusicBox
	{
		public override int MusicBoxTile => ModContent.TileType<EliusMusicBoxTile>();
		public override MusicTrack Music => MusicTrack.Elius;
	}
}
