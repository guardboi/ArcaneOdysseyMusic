using Terraria.ModLoader;

namespace ArcaneOdysseyMusic.MusicBoxes
{
	public class EliusMusicBox : MusicBox
	{
		public override int MusicBoxTile => ModContent.TileType<EliusMusicBoxTile>();
		public override string MusicFilePath => "Music/Elius";
	}
}
