using Terraria.ModLoader;

namespace ArcaneOdysseyMusic.MusicBoxes
{
	public class TitleMusicBox2 : MusicBox
	{
		public override int MusicBoxTile => ModContent.TileType<TitleMusicBoxTile2>();
		public override string MusicFilePath => "Music/TitleTheme2";
	}
}
