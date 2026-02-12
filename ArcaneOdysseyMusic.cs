using ArcaneOdysseyMusic.MusicBoxes;
using System.Collections.Generic;
using Terraria;
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
				void AddMusic(string songName, string authorName, string songPath)
				{
					short slot = (short)MusicLoader.GetMusicSlot(this, $"Music/{songPath}");
					musicDisplay.Call("AddMusic", slot, songName, authorName, DisplayName);
				}
				AddMusic("A Concerning Plot (Reimagined)", "Tobi", "TitleTheme");
				AddMusic("The Dark Sea", "Tobi", "DarkSea");
				AddMusic("Flamboyant Fatality", "Godwooper", "Elius");
				AddMusic("Auric Obliteration", "Godwooper", "Argos");
			}
		}
	}

	public class SpawningItems : ModPlayer
	{
		public override IEnumerable<Item> AddStartingItems(bool mediumCoreDeath)
		{
			if (!mediumCoreDeath)
				return [new Item(ModContent.ItemType<TitleMusicBox>())];
			return [];
		}
	}
}
