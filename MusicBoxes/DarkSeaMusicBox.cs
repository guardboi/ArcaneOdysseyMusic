using Terraria.ModLoader;

namespace ArcaneOdysseyMusic.MusicBoxes
{
	public class DarkSeaMusicBox : MusicBox
	{
		public override int MusicBoxTile => ModContent.TileType<DarkSeaMusicBoxTile>();
		public override string MusicFilePath => "Music/DarkSea";
	}
}
