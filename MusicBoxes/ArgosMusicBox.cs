using Terraria.ModLoader;

namespace ArcaneOdysseyMusic.MusicBoxes
{
	public class ArgosMusicBox : MusicBox
	{
		public override int MusicBoxTile => ModContent.TileType<ArgosMusicBoxTile>();
		public override string MusicFilePath => "Music/DarkSea"; // placeholder
	}
}
