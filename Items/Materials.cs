﻿using System;
using Terraria.ID;
using Terraria.ModLoader;

namespace MokkelMod.Items
{
	public class IlluminescentEssence : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Illuminescent Essence";
			item.width = 32;
			item.height = 32;
			item.maxStack = 999;
			item.value = 1000;
			item.rare = 3;
		}
	}

	public class ZombieFlesh : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Zombie Flesh";
			item.width = 24;
			item.height = 24;
			item.maxStack = 999;
		}
	}

	public class Comet : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Comet";
			item.width = 28;
			item.height = 28;
			item.maxStack = 999;
			item.value = 1000;
			item.rare = 6;
		}
	}

	public class CometBar : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Comet Bar";
			item.width = 30;
			item.height = 24;
			item.maxStack = 999;
			item.value = 4000;
			item.rare = 6;
		}
	}

	public class EmpoweredIngot : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Empowered Ingot";
			item.width = 30;
			item.height = 24;
			item.maxStack = 999;
			AddTooltip("Infused with the essence of The Destroyer");
			item.value = 5000;
			item.rare = 5;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "RadiantIngot");
			recipe.AddIngredient(ItemID.SoulofMight);
			recipe.AddTile(TileID.AdamantiteForge);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}

	public class EnragedIngot : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Enraged Ingot";
			item.width = 30;
			item.height = 24;
			item.maxStack = 999;
			AddTooltip("Infused with the essence of Skeletron Prime");
			item.value = 5000;
			item.rare = 5;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "RadiantIngot");
			recipe.AddIngredient(ItemID.SoulofFright);
			recipe.AddTile(TileID.AdamantiteForge);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}

	public class InscribedIngot : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Inscribed Ingot";
			item.width = 30;
			item.height = 24;
			item.maxStack = 999;
			AddTooltip("Infused with the essence of The Twins");
			item.value = 5000;
			item.rare = 5;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "RadiantIngot");
			recipe.AddIngredient(ItemID.SoulofSight);
			recipe.AddTile(TileID.AdamantiteForge);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}

	public class MagmaIngot : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Magma Ingot";
			item.width = 30;
			item.height = 24;
			item.maxStack = 999;
			AddTooltip("Ouch! Too hot!");
			item.value = 5000;
			item.rare = 4;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "MagmaOre", 4);
			recipe.AddIngredient(ItemID.SoulofNight, 1);
			recipe.AddTile(TileID.AdamantiteForge);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}

	public class MagmaOre : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Magma Ore";
			item.width = 16;
			item.height = 16;
			item.maxStack = 999;
			AddTooltip("Burns with a hellish fire");
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("MagmaOre");
		}
	}

	public class RadiantIngot : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Radiant Ingot";
			item.width = 30;
			item.height = 24;
			item.maxStack = 999;
			AddTooltip("It seems to glow and shine in your hand");
			item.value = 5000;
			item.rare = 4;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "RadiantOre", 5);
			recipe.AddTile(TileID.AdamantiteForge);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}

	public class RadiantOre : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Radiant Ore";
			item.width = 16;
			item.height = 16;
			item.maxStack = 999;
			AddTooltip("Pulses with arcane power");
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("RadiantOre");
		}
	}

	public class RoyalIngot : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Royal Ingot";
			item.width = 30;
			item.height = 24;
			item.maxStack = 999;
			AddTooltip("Forged from valuable materials");
			item.value = 5000;
			item.rare = 4;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "RadiantIngot", 1);
			recipe.AddIngredient(ItemID.HallowedBar, 2);
			recipe.AddTile(TileID.AdamantiteForge);
			recipe.SetResult(this, 2);
			recipe.AddRecipe();
		}
	}
}
