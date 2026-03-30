using ArcaneOdysseyMusic.MusicBoxes.Tiles;
using Terraria.ID;
using Terraria.ModLoader;

namespace ArcaneOdysseyMusic.MusicBoxes.Items
{
	public class DjinMusicBox : MusicBox
	{
		public override int MusicBoxTile => ModContent.TileType<DjinMusicBoxTile>();
		public override MusicTrack Music => MusicTrack.Djin;
	}
}
