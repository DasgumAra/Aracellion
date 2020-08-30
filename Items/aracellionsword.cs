using Terraria.ID;
using Terraria.ModLoader;

namespace aracellion.Items
{
	public class aracellionsword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("The Aracellion Sword");
			Tooltip.SetDefault("It shimmers in the dark, but it's full power has yet to be revealed");
		}

		public override void SetDefaults() 
		{
			item.damage = 70;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 4;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
