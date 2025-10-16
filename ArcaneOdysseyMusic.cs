using ArcaneOdysseyMusic.MusicBoxes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace ArcaneOdysseyMusic
{
	public class ArcaneOdysseyMusic : Mod
	{
		public override object Call(params object[] args)
		{
			return MusicLoader.GetMusicSlot(this, $"Music/{args[0]}");
		}

		public override void PostSetupContent()
		{
			if (ModLoader.TryGetMod("MusicDisplay", out Mod musicDisplay))
			{
				void AddMusic(string songName, string authorName, string songPath)
				{
					short slot = (short)MusicLoader.GetMusicSlot(this, $"Music/{songPath}");
					musicDisplay.Call("AddMusic", slot, songName, authorName, DisplayName);
				}
				AddMusic("The Call of Adventure", "Tobi", "TitleTheme");
				AddMusic("The Dark Sea", "Tobi", "DarkSea");
				AddMusic("Lord Elius", "Godwooper", "Elius");
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
