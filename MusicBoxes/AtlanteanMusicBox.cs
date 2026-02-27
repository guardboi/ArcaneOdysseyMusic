using Terraria.ModLoader;

namespace ArcaneOdysseyMusic.MusicBoxes
{
	public class AtlanteanMusicBox : MusicBox
	{
		public override int MusicBoxTile => ModContent.TileType<AtlanteanMusicBoxTile>();
		public override string MusicFilePath => "Music/Atlantean";
	}
}
