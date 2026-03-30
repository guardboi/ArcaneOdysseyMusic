using System.Text.RegularExpressions;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ArcaneOdysseyMusic
{
	public class ArcaneOdysseyMusicMod : Mod
	{
		public static ArcaneOdysseyMusicMod Instance => ModContent.GetInstance<ArcaneOdysseyMusicMod>();

		public static string InternalName => typeof(ArcaneOdysseyMusicMod).Namespace;

		public override void PostSetupContent()
		{
			if (ModLoader.TryGetMod("MusicDisplay", out Mod musicDisplay))
			{
				foreach (var track in MusicTrack.All)
				{
					musicDisplay.Call("AddMusic", track.MusicSlotShort, track.DisplayName.Value, track.Author.Value, DisplayNameClean);
				}
			}
		}
	}

	public class MusicTrack(string name)
	{
		public static MusicTrack Elius => new("Elius");
		public static MusicTrack TitleTheme => new("TitleTheme");
		public static MusicTrack TitleTheme2 => new("TitleTheme2");
		public static MusicTrack DarkSea => new("DarkSea");
		public static MusicTrack Allanon => new("Allanon");
		public static MusicTrack Argos => new("Argos");
		public static MusicTrack Atlantean => new("Atlantean");
		public static MusicTrack Djin => new("Djin");
		public static MusicTrack[] All => [Atlantean, Argos, TitleTheme, TitleTheme2, DarkSea, Elius, Allanon, Djin];

		public string InternalName = name;

		public LocalizedText DisplayName => Language.GetOrRegister($"Mods.{ArcaneOdysseyMusicMod.InternalName}.Music.{InternalName}.DisplayName", () => Regex.Replace(InternalName, "([A-Z])", " $1").Trim());
		public LocalizedText Author => Language.GetOrRegister($"Mods.{ArcaneOdysseyMusicMod.InternalName}.Music.{InternalName}.Author", () => "Unknown Author");

		public int MusicSlot => MusicLoader.GetMusicSlot($"{ArcaneOdysseyMusicMod.InternalName}/Music/{InternalName}");
		public short MusicSlotShort => (short)MusicSlot;
	}
}
