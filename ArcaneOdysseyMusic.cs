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
				foreach (var track in AOMusicTrack.All)
				{
					musicDisplay.Call("AddMusic", (short)track.MusicSlot, track.Name.Value, track.Author.Value, track.InternalName);
				}
			}
		}
	}

	public class AOMusicTrack(string name)
	{
		public static AOMusicTrack Elius => new("Elius");
		public static AOMusicTrack TitleTheme => new("TitleTheme");
		public static AOMusicTrack TitleTheme2 => new("TitleTheme2");
		public static AOMusicTrack DarkSea => new("DarkSea");
		public static AOMusicTrack Allanon => new("Allanon");
		public static AOMusicTrack Argos => new("Argos");
		public static AOMusicTrack Atlantean => new("Atlantean");
		public static AOMusicTrack[] All => [Atlantean, Argos, TitleTheme, TitleTheme2, DarkSea, Elius, Allanon];

		public string InternalName = name;

		public LocalizedText Name => Language.GetOrRegister($"Mods.{ArcaneOdysseyMusicMod.InternalName}.Music.{InternalName}.DisplayName", () => Regex.Replace(InternalName, "([A-Z])", " $1").Trim());
		public LocalizedText Author => Language.GetOrRegister($"Mods.{ArcaneOdysseyMusicMod.InternalName}.Music.{InternalName}.Author", () => "Unknown Author");

		public int MusicSlot => MusicLoader.GetMusicSlot($"{ArcaneOdysseyMusicMod.InternalName}/Music/{InternalName}");
	}
}
