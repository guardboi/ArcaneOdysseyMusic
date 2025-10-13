using Terraria.ModLoader;

namespace ArcaneOdysseyMusic.MusicBoxes
{
	public class TitleMusicBox : MusicBox
	{
		public override int MusicBoxTile => ModContent.TileType<TitleMusicBoxTile>();
		public override string MusicFilePath => "Music/TitleTheme";
	}
}
