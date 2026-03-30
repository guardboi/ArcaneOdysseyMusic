using ArcaneOdysseyMusic.MusicBoxes.Tiles;
using Terraria.ModLoader;

namespace ArcaneOdysseyMusic.MusicBoxes.Items
{
	public class ArgosMusicBox : MusicBox
	{
		public override int MusicBoxTile => ModContent.TileType<ArgosMusicBoxTile>();
		public override MusicTrack Music => MusicTrack.Argos;
	}
}
