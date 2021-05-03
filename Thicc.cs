using System;
using System.Collections.Generic;
using System.IO;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.UI;

namespace Thicc
{
    class Thicc : Mod
    {
        public override void AddRecipes()
        {
                ModRecipe recipe = new ModRecipe(this);
                recipe.AddIngredient(ItemID.Vertebrae, 5);
                recipe.AddTile(TileID.WorkBenches);
                recipe.SetResult(ItemID.Leather, 1);
                recipe.AddRecipe();           
           
                recipe = new ModRecipe(this);
                recipe.AddRecipeGroup("Thicc:CopperBar", 5);
                recipe.AddRecipeGroup("Thicc:IronBar", 3);
                recipe.AddTile(TileID.WorkBenches);
                recipe.SetResult(ItemID.Aglet, 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ItemID.EmeraldGemsparkBlock, 5);
                recipe.AddRecipeGroup("Thicc:IronBar", 10);
                recipe.AddTile(TileID.WorkBenches);
                recipe.SetResult(ItemID.Radar, 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ItemID.CobaltBar, 12);
                recipe.AddTile(TileID.MythrilAnvil);
                recipe.SetResult(ItemID.CobaltShield, 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ItemID.HallowedBar, 30);
                recipe.AddIngredient(ItemID.Ectoplasm, 50);
                recipe.AddTile(TileID.MythrilAnvil);
                recipe.SetResult(ItemID.PaladinsShield, 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ItemID.JungleRose, 1);
                recipe.AddIngredient(ItemID.JungleSpores, 10);
                recipe.AddIngredient(ItemID.Vine, 1);
                recipe.AddTile(TileID.LivingLoom);
                recipe.SetResult(ItemID.AnkletoftheWind, 1);
             	recipe.AddRecipe();

            	recipe = new ModRecipe(this);
            	recipe.AddIngredient(ItemID.JungleSpores, 150);
            	recipe.AddIngredient(ItemID.Stinger, 99);
            	recipe.AddIngredient(ItemID.TurtleShell, 3);
           	    recipe.AddTile(TileID.MythrilAnvil);
            	recipe.SetResult(ItemID.JungleKey, 1);
            	recipe.AddRecipe();

            	recipe = new ModRecipe(this);
            	recipe.AddIngredient(ItemID.SlushBlock, 150);
            	recipe.AddIngredient(ItemID.FrozenTurtleShell, 1);
            	recipe.AddIngredient(ItemID.FrostCore, 3);
            	recipe.AddTile(TileID.MythrilAnvil);
            	recipe.SetResult(ItemID.FrozenKey, 1);
            	recipe.AddRecipe();

            	recipe = new ModRecipe(this);
            	recipe.AddIngredient(ItemID.SoulofNight, 150);
            	recipe.AddIngredient(ItemID.CursedFlame, 99);
            	recipe.AddIngredient(ItemID.RottenChunk, 30);
            	recipe.AddTile(TileID.MythrilAnvil);
            	recipe.SetResult(ItemID.CorruptionKey, 1);
            	recipe.AddRecipe();

            	recipe = new ModRecipe(this);
           	    recipe.AddIngredient(ItemID.SoulofNight, 150);
            	recipe.AddIngredient(ItemID.Ichor, 99);
            	recipe.AddIngredient(ItemID.Vertebrae, 30);
            	recipe.AddTile(TileID.MythrilAnvil);
            	recipe.SetResult(ItemID.CrimsonKey, 1);
            	recipe.AddRecipe();

            	recipe = new ModRecipe(this);
           	    recipe.AddIngredient(ItemID.SoulofLight, 150);
            	recipe.AddIngredient(ItemID.PixieDust, 99);
            	recipe.AddIngredient(ItemID.UnicornHorn, 30);
            	recipe.AddTile(TileID.MythrilAnvil);
            	recipe.SetResult(ItemID.HallowedKey, 1);
            	recipe.AddRecipe();
	    
            	recipe = new ModRecipe(this);
                recipe.AddIngredient(ItemID.Silk, 15);
                recipe.AddIngredient(ItemID.Feather, 20);
                recipe.AddIngredient(ItemID.GiantHarpyFeather, 1);
                recipe.AddIngredient(ItemID.Leather, 10);
                recipe.AddTile(TileID.Loom);
                recipe.SetResult(ItemID.HermesBoots, 1);
                recipe.AddRecipe();
                  
                recipe = new ModRecipe(this);
                recipe.AddIngredient(ItemID.IceBlock, 40);
                recipe.AddIngredient(ItemID.SnowBlock, 50);
                recipe.AddIngredient(ItemID.Bottle, 1);
                recipe.AddTile(TileID.TinkerersWorkbench);
                recipe.SetResult(ItemID.BlizzardinaBottle, 1);
                recipe.AddRecipe();
                   
                recipe = new ModRecipe(this);
                recipe.AddRecipeGroup("Thicc:IronBar", 20);
                recipe.AddTile(TileID.Anvils);
                recipe.SetResult(ItemID.ClimbingClaws, 1);
                recipe.AddRecipe();        
            
                recipe = new ModRecipe(this);
                recipe.AddRecipeGroup("Thicc:SilverBar", 15);
                recipe.AddIngredient(ItemID.Leather, 5);
                recipe.AddTile(TileID.Anvils);
                recipe.SetResult(ItemID.ShoeSpikes, 1);
                recipe.AddRecipe();
                 
                recipe = new ModRecipe(this);
                recipe.AddRecipeGroup("Thicc:IronBar", 1);
                recipe.AddIngredient(ItemID.Leather, 2);
                recipe.AddTile(TileID.Anvils);
                recipe.SetResult(ItemID.Flipper, 1);
                recipe.AddRecipe();
        
                recipe = new ModRecipe(this);
                recipe.AddIngredient(ItemID.Leather, 5);
                recipe.AddIngredient(ItemID.Shiverthorn, 30);
                recipe.AddIngredient(ItemID.Silk, 5);
                recipe.AddTile(TileID.Loom);
                recipe.SetResult(ItemID.FlurryBoots, 1);
                recipe.AddRecipe();
         
                recipe = new ModRecipe(this);
                recipe.AddIngredient(ItemID.Silk, 15);
                recipe.AddTile(TileID.Loom);
                recipe.AddTile(TileID.CrystalBall);
                recipe.SetResult(ItemID.FlyingCarpet, 1);
                recipe.AddRecipe();
       
                recipe = new ModRecipe(this);
                recipe.AddIngredient(ItemID.Frog, 12);
                recipe.AddTile(TileID.MythrilAnvil);
                recipe.SetResult(ItemID.FrogLeg, 1);
                recipe.AddRecipe();
            
                recipe = new ModRecipe(this);
                recipe.AddRecipeGroup("Thicc:GoldBar", 5);
                recipe.AddIngredient(ItemID.FlurryBoots, 1);
                recipe.AddTile(TileID.TinkerersWorkbench);
                recipe.SetResult(ItemID.IceSkates, 1);
                recipe.AddRecipe();
        
                recipe = new ModRecipe(this);
                recipe.AddRecipeGroup("Thicc:GoldBar", 12);
                recipe.AddIngredient(ItemID.ObsidianRose, 1);
                recipe.AddIngredient(ItemID.LavaBucket, 1);
                recipe.AddTile(TileID.MythrilAnvil);
                recipe.SetResult(ItemID.LavaCharm, 1);
                recipe.AddRecipe();
            
                recipe = new ModRecipe(this);
                recipe.AddRecipeGroup("Thicc:GoldBar", 6);
                recipe.AddIngredient(ItemID.SunplateBlock, 25);
                recipe.AddTile(TileID.TinkerersWorkbench);
                recipe.SetResult(ItemID.LuckyHorseshoe, 1);
                recipe.AddRecipe();
          
                recipe = new ModRecipe(this);
                recipe.AddIngredient(ItemID.SandBlock, 40);
                recipe.AddIngredient(ItemID.Bottle, 1);
                recipe.AddIngredient(ItemID.AntlionMandible, 35);
                recipe.AddTile(TileID.TinkerersWorkbench);
                recipe.SetResult(ItemID.SandstorminaBottle, 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ItemID.Cloud, 20);
                recipe.AddIngredient(ItemID.Bottle, 1);
                recipe.AddTile(TileID.SkyMill);
                recipe.SetResult(ItemID.CloudinaBottle, 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ItemID.Cloud, 5);
                recipe.AddIngredient(ItemID.SillyBalloonTiedPink, 1);
                recipe.AddTile(TileID.TinkerersWorkbench);
                recipe.SetResult(ItemID.ShinyRedBalloon, 1);
                recipe.AddRecipe();
		
		        recipe = new ModRecipe(this);
                recipe.AddIngredient(ItemID.Cloud, 5);
                recipe.AddIngredient(ItemID.SillyBalloonTiedPurple, 1);
                recipe.AddTile(TileID.TinkerersWorkbench);
                recipe.SetResult(ItemID.ShinyRedBalloon, 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ItemID.Cloud, 5);
                recipe.AddIngredient(ItemID.SillyBalloonTiedGreen, 1);
                recipe.AddTile(TileID.TinkerersWorkbench);
                recipe.SetResult(ItemID.ShinyRedBalloon, 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ItemID.Leather, 15);
                recipe.AddIngredient(ItemID.Silk, 70);
                recipe.AddIngredient(ItemID.WaterWalkingPotion, 30);
                recipe.AddTile(TileID.TinkerersWorkbench);
                recipe.SetResult(ItemID.WaterWalkingBoots, 1);
                recipe.AddRecipe();
            
                recipe = new ModRecipe(this);
                recipe.AddRecipeGroup("Thicc:GoldBar", 5);
                recipe.AddRecipeGroup("Thicc:SilverBar", 7);
                recipe.AddRecipeGroup("Thicc:CopperBar", 9);
                recipe.AddTile(TileID.TinkerersWorkbench);
                recipe.SetResult(ItemID.DepthMeter, 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddRecipeGroup("Thicc:GoldBar", 5);
                recipe.AddRecipeGroup("Thicc:SilverBar", 15);
                recipe.AddTile(TileID.TinkerersWorkbench);
                recipe.SetResult(ItemID.Compass, 1);
                recipe.AddRecipe();
            
                recipe = new ModRecipe(this);
                recipe.AddIngredient(ItemID.Book, 1);
                recipe.AddRecipeGroup("Thicc:Fish", 5);
                recipe.AddTile(TileID.Bookcases);
                recipe.SetResult(ItemID.FishermansGuide, 1);
                recipe.AddRecipe();
            
                recipe = new ModRecipe(this);
                recipe.AddRecipeGroup("Thicc:CopperBar", 30);
                recipe.AddRecipeGroup("Thicc:GoldBar", 70);
                recipe.AddIngredient(ItemID.Sapphire, 10);
                recipe.AddTile(TileID.TinkerersWorkbench);
                recipe.SetResult(ItemID.WeatherRadio, 1);
                recipe.AddRecipe();
           
                recipe = new ModRecipe(this);
                recipe.AddRecipeGroup("Thicc:GoldBar", 80);
                recipe.AddTile(TileID.TinkerersWorkbench);
                recipe.SetResult(ItemID.Sextant, 1);
                recipe.AddRecipe();
         
                recipe = new ModRecipe(this);
                recipe.AddRecipeGroup("Thicc:CopperBar", 5);
                recipe.AddRecipeGroup("Thicc:IronBar", 5);
                recipe.AddRecipeGroup("Thicc:SilverBar", 5);
                recipe.AddRecipeGroup("Thicc:GoldBar", 5);
                recipe.AddIngredient(ItemID.Ruby, 1);
                recipe.AddIngredient(ItemID.Emerald, 1);
                recipe.AddTile(TileID.TinkerersWorkbench);
                recipe.SetResult(ItemID.MetalDetector, 1);
                recipe.AddRecipe();
           
                recipe = new ModRecipe(this);
                recipe.AddRecipeGroup("Thicc:IronBar", 120);
                recipe.AddRecipeGroup("Thicc:GoldBar", 50);
                recipe.AddIngredient(ItemID.Wire, 3);
                recipe.AddIngredient(ItemID.Glass, 5);
                recipe.AddTile(TileID.TinkerersWorkbench);
                recipe.SetResult(ItemID.Stopwatch, 1);
                recipe.AddRecipe();
           
                recipe = new ModRecipe(this);
                recipe.AddRecipeGroup("Thicc:CopperBar", 4);
                recipe.AddRecipeGroup("Thicc:IronBar", 4);
                recipe.AddRecipeGroup("Thicc:SilverBar", 4);
                recipe.AddRecipeGroup("Thicc:GoldBar", 4);
                recipe.AddIngredient(ItemID.Ruby, 3);
                recipe.AddTile(TileID.TinkerersWorkbench);
                recipe.SetResult(ItemID.DPSMeter, 1);
                recipe.AddRecipe();
           
                recipe = new ModRecipe(this);
                recipe.AddRecipeGroup("Thicc:GoldBar", 60);
                recipe.AddIngredient(ItemID.Bone, 500);
                recipe.AddIngredient(ItemID.Wire, 10);
                recipe.AddTile(TileID.TinkerersWorkbench);
                recipe.SetResult(ItemID.TallyCounter, 1);
                recipe.AddRecipe();
           
                recipe = new ModRecipe(this);
                recipe.AddRecipeGroup("Thicc:GoldBar", 8);
                recipe.AddIngredient(ItemID.Ruby, 2);
                recipe.AddIngredient(ItemID.Emerald, 1);
                recipe.AddTile(TileID.TinkerersWorkbench);
                recipe.SetResult(ItemID.LifeformAnalyzer, 1);
                recipe.AddRecipe();
            
                recipe = new ModRecipe(this);
                recipe.AddRecipeGroup("Thicc:GoldBar", 16);
                recipe.AddIngredient(ItemID.Glass, 10);
                recipe.AddIngredient(ItemID.Emerald, 10);
                recipe.AddTile(TileID.TinkerersWorkbench);
                recipe.SetResult(ItemID.LifeformAnalyzer, 1);
                recipe.AddRecipe();
          
                recipe = new ModRecipe(this);
                recipe.AddRecipeGroup("Thicc:IronBar", 15);
                recipe.AddIngredient(ItemID.LifeCrystal, 2);
                recipe.AddTile(TileID.TinkerersWorkbench);
                recipe.SetResult(ItemID.BandofRegeneration, 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ItemID.ManaCrystal, 1);
                recipe.AddIngredient(ItemID.PanicNecklace, 1);
                recipe.AddTile(TileID.TinkerersWorkbench);
                recipe.SetResult(ItemID.BandofStarpower, 1);
                recipe.AddRecipe();
            
                recipe = new ModRecipe(this);
                recipe.AddIngredient(ItemID.LifeCrystal, 1);
                recipe.AddIngredient(ItemID.BandofStarpower, 1);
                recipe.AddTile(TileID.TinkerersWorkbench);
                recipe.SetResult(ItemID.PanicNecklace, 1);
                recipe.AddRecipe();
            
                recipe = new ModRecipe(this);
                recipe.AddIngredient(ItemID.ManaCrystal, 10);
                recipe.AddIngredient(ItemID.MeteoriteBar, 30);
                recipe.AddTile(TileID.TinkerersWorkbench);
                recipe.SetResult(ItemID.CelestialMagnet, 1);
                recipe.AddRecipe();
           
                recipe = new ModRecipe(this);
                recipe.AddIngredient(ItemID.JungleSpores, 10);
                recipe.AddIngredient(ItemID.Stinger, 10);
                recipe.AddTile(TileID.TinkerersWorkbench);
                recipe.SetResult(ItemID.FeralClaws, 1);
                recipe.AddRecipe();
            
                recipe = new ModRecipe(this);
                recipe.AddIngredient(ItemID.Obsidian, 10);
                recipe.AddIngredient(ItemID.LavaBucket, 5);
                recipe.AddIngredient(ItemID.HellstoneBrick, 24);
                recipe.AddTile(TileID.TinkerersWorkbench);
                recipe.SetResult(ItemID.MagmaStone, 1);
                recipe.AddRecipe();
            
                recipe = new ModRecipe(this);
                recipe.AddIngredient(ItemID.MarbleBlock, 5);
                recipe.AddRecipeGroup("Thicc:GoldBar", 1);
                recipe.AddTile(TileID.Anvils);
                recipe.SetResult(ItemID.Javelin, 50);
                recipe.AddRecipe();
           
                recipe = new ModRecipe(this);
                recipe.AddRecipeGroup("Thicc:CopperBar", 35);
                recipe.AddRecipeGroup("Thicc:IronBar", 35);
                recipe.AddRecipeGroup("Thicc:SilverBar", 35);
                recipe.AddRecipeGroup("Thicc:GoldBar", 35);
                recipe.AddTile(TileID.TinkerersWorkbench);
                recipe.SetResult(ItemID.TackleBox, 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddRecipeGroup("Thicc:IronBar", 13);
                recipe.AddIngredient(ItemID.Cobweb, 135);
                recipe.AddIngredient(ItemID.GoldWorm, 1);
                recipe.AddTile(TileID.TinkerersWorkbench);
                recipe.SetResult(ItemID.HighTestFishingLine, 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ItemID.SuspiciousLookingEye, 1);
                recipe.AddIngredient(ItemID.BlackLens, 1);
                recipe.AddIngredient(ItemID.Sapphire, 10);
                recipe.AddTile(TileID.BoneWelder);
                recipe.SetResult(ItemID.Nazar, 1);
                recipe.AddRecipe();

            	recipe = new ModRecipe(this);
            	recipe.AddIngredient(ItemID.PlatinumWatch, 1);
            	recipe.AddIngredient(ItemID.PixieDust, 198);
            	recipe.AddTile(TileID.TinkerersWorkbench);
            	recipe.SetResult(ItemID.FastClock, 1);
            	recipe.AddRecipe();

        	    recipe = new ModRecipe(this);
        	    recipe.AddIngredient(ItemID.GoldWatch, 1);
            	recipe.AddIngredient(ItemID.PixieDust, 396);
          	    recipe.AddTile(TileID.TinkerersWorkbench);
          	    recipe.SetResult(ItemID.FastClock, 1);
          	    recipe.AddRecipe();

            	recipe = new ModRecipe(this);
           	    recipe.AddIngredient(ItemID.Gel, 50);
            	recipe.AddIngredient(ItemID.Stinger, 60);
            	recipe.AddTile(TileID.Solidifier);
            	recipe.SetResult(ItemID.Bezoar, 1);
            	recipe.AddRecipe();

            	recipe = new ModRecipe(this);
                recipe.AddRecipeGroup("Thicc:GoldBar", 26);
                recipe.AddRecipeGroup("Thicc:Fish", 8);
                recipe.AddTile(TileID.TinkerersWorkbench);
                recipe.SetResult(ItemID.AnglerEarring, 1);
                recipe.AddRecipe();
           
                recipe = new ModRecipe(this);
                recipe.AddIngredient(ItemID.Leather, 15);
                recipe.AddIngredient(ItemID.Silk, 5);
                recipe.AddIngredient(ItemID.Vine, 10);
                recipe.AddTile(TileID.TinkerersWorkbench);
                recipe.SetResult(ItemID.FlowerBoots, 1);
                recipe.AddRecipe();
          
                recipe = new ModRecipe(this);
                recipe.AddIngredient(ItemID.Book, 1);
                recipe.AddIngredient(ItemID.DirtBlock, 100);
                recipe.AddIngredient(ItemID.Acorn, 20);
                recipe.AddTile(TileID.Bookcases);
                recipe.SetResult(ItemID.CordageGuide, 1);
                recipe.AddRecipe();
         
                recipe = new ModRecipe(this);
                recipe.AddRecipeGroup("Thicc:IronBar", 15);
                recipe.AddIngredient(ItemID.Glowstick, 50);
                recipe.AddTile(TileID.TinkerersWorkbench);
                recipe.SetResult(ItemID.JellyfishNecklace, 1);
                recipe.AddRecipe();
           
                recipe = new ModRecipe(this);
                recipe.AddIngredient(ItemID.GoldBroadsword, 1);
                recipe.AddIngredient(ItemID.IceBlock, 300);
                recipe.AddTile(TileID.Anvils);
                recipe.SetResult(ItemID.IceBlade, 1);
                recipe.AddRecipe();
                   
                recipe = new ModRecipe(this);
                recipe.AddIngredient(ItemID.PlatinumBroadsword, 1);
                recipe.AddIngredient(ItemID.IceBlock, 300);
                recipe.AddTile(TileID.Anvils);
                recipe.SetResult(ItemID.IceBlade, 1);
                recipe.AddRecipe();
            
                recipe = new ModRecipe(this);
                recipe.AddIngredient(ItemID.GoldBroadsword, 1);
                recipe.AddIngredient(ItemID.ManaCrystal, 3);
                recipe.AddIngredient(ItemID.Ruby, 1);
                recipe.AddTile(TileID.Anvils);
                recipe.SetResult(ItemID.EnchantedSword, 1);
                recipe.AddRecipe();
          
                recipe = new ModRecipe(this);
                recipe.AddIngredient(ItemID.PlatinumBroadsword, 1);
                recipe.AddIngredient(ItemID.ManaCrystal, 3);
                recipe.AddIngredient(ItemID.Ruby, 1);
                recipe.AddTile(TileID.Anvils);
                recipe.SetResult(ItemID.EnchantedSword, 1);
                recipe.AddRecipe();
           
                recipe = new ModRecipe(this);
                recipe.AddRecipeGroup("Thicc:SilverBar", 15);
                recipe.AddIngredient(ItemID.Feather, 30);
                recipe.AddIngredient(ItemID.GiantHarpyFeather, 1);
                recipe.AddTile(TileID.Anvils);
                recipe.SetResult(ItemID.FalconBlade, 1);
                recipe.AddRecipe();
           
                recipe = new ModRecipe(this);
                recipe.AddIngredient(ItemID.GoldBroadsword, 1);
                recipe.AddIngredient(ItemID.FallenStar, 25);
                recipe.AddIngredient(ItemID.SunplateBlock, 25);
                recipe.AddTile(TileID.Anvils);
                recipe.SetResult(ItemID.Starfury, 1);
                recipe.AddRecipe();
            
                recipe = new ModRecipe(this);
                recipe.AddIngredient(ItemID.PlatinumBroadsword, 1);
                recipe.AddIngredient(ItemID.FallenStar, 25);
                recipe.AddIngredient(ItemID.SunplateBlock, 25);
                recipe.AddTile(TileID.Anvils);
                recipe.SetResult(ItemID.Starfury, 1);
                recipe.AddRecipe();
           
                recipe = new ModRecipe(this);
                recipe.AddRecipeGroup("Thicc:GoldBar", 2);
                recipe.AddRecipeGroup("Thicc:SilverBar", 12);
                recipe.AddIngredient(ItemID.Leather, 2);
                recipe.AddTile(TileID.Anvils);
                recipe.SetResult(ItemID.DyeTradersScimitar, 1);
                recipe.AddRecipe();
          
                recipe = new ModRecipe(this);
                recipe.AddRecipeGroup("Thicc:IronBar", 100);
                recipe.AddIngredient(ItemID.Leather, 20);
                recipe.AddTile(TileID.Anvils);
                recipe.SetResult(ItemID.BladedGlove, 1);
                recipe.AddRecipe();
          
                recipe = new ModRecipe(this);
                recipe.AddRecipeGroup("Thicc:SilverBar", 80);
                recipe.AddTile(TileID.Anvils);
                recipe.SetResult(ItemID.BloodyMachete, 1);
                recipe.AddRecipe();
           
                recipe = new ModRecipe(this);
                recipe.AddRecipeGroup("Thicc:IronBar", 5);
                recipe.AddIngredient(ItemID.HairDyeRemover, 1);
                recipe.AddTile(TileID.Anvils);
                recipe.SetResult(ItemID.StylistKilLaKillScissorsIWish, 1);
                recipe.AddRecipe();
            
                recipe = new ModRecipe(this);
                recipe.AddRecipeGroup("Thicc:Fish", 1);
                recipe.AddIngredient(ItemID.IceBlock, 5);
                recipe.AddTile(TileID.WorkBenches);
                recipe.SetResult(ItemID.FrostDaggerfish, 50);
                recipe.AddRecipe();
            
                recipe = new ModRecipe(this);
                recipe.AddRecipeGroup("Thicc:IronBar", 30);
                recipe.AddRecipeGroup("Thicc:GoldBar", 10);
                recipe.AddIngredient(ItemID.Leather, 1);
                recipe.AddTile(TileID.Anvils);
                recipe.SetResult(ItemID.Katana, 1);
                recipe.AddRecipe();
            
                recipe = new ModRecipe(this);
                recipe.AddRecipeGroup("Thicc:IronBar", 14);
                recipe.AddRecipeGroup("Thicc:GoldBar", 1);
                recipe.AddTile(TileID.Anvils);
                recipe.SetResult(ItemID.Spear, 1);
                recipe.AddRecipe();
           
                recipe = new ModRecipe(this);
                recipe.AddRecipeGroup("Thicc:IronBar", 4);
                recipe.AddRecipeGroup("Wood", 12);
                recipe.AddTile(TileID.Anvils);
                recipe.SetResult(ItemID.WoodenBoomerang, 1);
                recipe.AddRecipe();
          
                recipe = new ModRecipe(this);
                recipe.AddIngredient(ItemID.WoodenBoomerang, 1);
                recipe.AddIngredient(ItemID.IceBlock, 20);
                recipe.AddIngredient(ItemID.SnowBlock, 150);
                recipe.AddIngredient(ItemID.SlushBlock, 60);
                recipe.AddTile(TileID.Anvils);
                recipe.SetResult(ItemID.IceBoomerang, 1);
                recipe.AddRecipe();
                        
                recipe = new ModRecipe(this);
                recipe.AddIngredient(ItemID.WoodenBoomerang, 1);
                recipe.AddIngredient(ItemID.ManaCrystal, 3);
                recipe.AddIngredient(ItemID.Ruby, 1);
                recipe.AddTile(TileID.Anvils);
                recipe.SetResult(ItemID.EnchantedBoomerang, 1);
                recipe.AddRecipe();            
            
                recipe = new ModRecipe(this);
                recipe.AddIngredient(ItemID.EnchantedSword, 1);
                recipe.AddIngredient(ItemID.ManaCrystal, 25);
                recipe.AddIngredient(ItemID.Ruby, 10);
                recipe.AddTile(TileID.Anvils);
                recipe.SetResult(ItemID.Arkhalis, 1);
                recipe.AddRecipe();            
            
                recipe = new ModRecipe(this);
                recipe.AddIngredient(ItemID.ThrowingKnife, 1);
                recipe.AddIngredient(ItemID.Chain, 100);
                recipe.AddTile(TileID.Anvils);
                recipe.SetResult(ItemID.ChainKnife, 1);
                recipe.AddRecipe();
                        
                recipe = new ModRecipe(this);
                recipe.AddRecipeGroup("Thicc:IronBar", 24);
                recipe.AddIngredient(ItemID.RichMahogany, 50);
                recipe.AddTile(TileID.Anvils);
                recipe.SetResult(ItemID.Boomstick, 1);
                recipe.AddRecipe();
                        
                recipe = new ModRecipe(this);
                recipe.AddRecipeGroup("Thicc:GoldBar", 4);
                recipe.AddRecipeGroup("Wood", 10);
                recipe.AddTile(TileID.Anvils);
                recipe.SetResult(ItemID.FlareGun, 1);
                recipe.AddRecipe();
                       
                recipe = new ModRecipe(this);
                recipe.AddRecipeGroup("Thicc:GoldBar", 17);
                recipe.AddIngredient(ItemID.Snowball, 130);
                recipe.AddTile(TileID.Anvils);
                recipe.SetResult(ItemID.SnowballCannon, 1);
                recipe.AddRecipe();
                      
                recipe = new ModRecipe(this);
                recipe.AddIngredient(ItemID.RedPaint, 1);
                recipe.AddIngredient(ItemID.YellowPaint, 1);
                recipe.AddIngredient(ItemID.BluePaint, 1);
                recipe.AddIngredient(ItemID.FlintlockPistol, 1);
                recipe.AddTile(TileID.Anvils);
                recipe.SetResult(ItemID.PainterPaintballGun, 1);
                recipe.AddRecipe();
            
                recipe = new ModRecipe(this);
                recipe.AddIngredient(ItemID.Torch, 30);
                recipe.AddRecipeGroup("Wood", 150);
                recipe.AddTile(TileID.Anvils);
                recipe.SetResult(ItemID.WandofSparking, 1);
                recipe.AddRecipe();
                      
                recipe = new ModRecipe(this);
                recipe.AddIngredient(ItemID.Gel, 200);
                recipe.AddRecipeGroup("Wood", 24);
                recipe.AddIngredient(ItemID.PinkGel, 65);
                recipe.AddTile(TileID.Solidifier);
                recipe.SetResult(ItemID.SlimeStaff, 1);
                recipe.AddRecipe();
                       
                recipe = new ModRecipe(this);
                recipe.AddRecipeGroup("Thicc:IronBar", 1);
                recipe.AddTile(TileID.Anvils);
                recipe.SetResult(ItemID.ThrowingKnife, 25);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(ItemID.SoulofLight, 99);
                recipe.AddIngredient(ItemID.CrystalShard, 999);
                recipe.AddTile(TileID.MythrilAnvil);
                recipe.AddTile(TileID.CrystalBall);
                recipe.SetResult(ItemID.RodofDiscord, 1);
                recipe.AddRecipe();

    }
        public override void AddRecipeGroups()
        {
            {
                RecipeGroup group = new RecipeGroup(() => Lang.misc[37] + " Copper Bar", new int[]
                {
                ItemID.CopperBar,
                ItemID.TinBar
                });
                RecipeGroup.RegisterGroup("Thicc:CopperBar", group);
            }
            {
                RecipeGroup group = new RecipeGroup(() => Lang.misc[37] + " Silver Bar", new int[]
                    {
                ItemID.SilverBar,
                ItemID.TungstenBar
                    });
                RecipeGroup.RegisterGroup("Thicc:SilverBar", group);
            }
            {
                RecipeGroup group = new RecipeGroup(() => Lang.misc[37] + " Gold Bar", new int[]
                    {
                ItemID.GoldBar,
                ItemID.PlatinumBar
                    });
                RecipeGroup.RegisterGroup("Thicc:GoldBar", group);
            }
            {
                RecipeGroup group = new RecipeGroup(() => Lang.misc[37] + " Iron Bar", new int[]
                    {
                ItemID.IronBar,
                ItemID.LeadBar
                    });
                RecipeGroup.RegisterGroup("Thicc:IronBar", group);
            }
            {
                RecipeGroup group = new RecipeGroup(() => Lang.misc[37] + " Fish", new int[]
            {
                ItemID.ArmoredCavefish,
                ItemID.Damselfish,
                ItemID.CrimsonTigerfish,
                ItemID.PrincessFish,
                ItemID.SpecularFish,
                ItemID.VariegatedLardfish,
                ItemID.Obsidifish,
                ItemID.ChaosFish,
                ItemID.Stinkfish,
                ItemID.AtlanticCod,
                ItemID.Bass,
                ItemID.BlueJellyfish,
                ItemID.GreenJellyfish,
                ItemID.PinkJellyfish,
                ItemID.DoubleCod,
                ItemID.Ebonkoi,
                ItemID.FlarefinKoi,
                ItemID.FrostMinnow,
                ItemID.Hemopiranha,
                ItemID.Honeyfin,
                ItemID.NeonTetra,
                ItemID.Prismite,
                ItemID.RedSnapper,
                ItemID.Salmon,
                ItemID.Shrimp,
                ItemID.Trout,
                ItemID.Tuna,
                    });
                RecipeGroup.RegisterGroup("Thicc:Fish", group);
                    }
               }

    }
}
