using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Thicc
{
    public class GlobalItems : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            //Armor
            if (item.type == ItemID.AnglerHat)
            {
                item.defense = 2;
            }
            if (item.type == ItemID.AnglerPants)
            {
                item.defense = 2;
            }
            if (item.type == ItemID.AnglerVest)
            {
                item.defense = 3;
            }
            if (item.type == ItemID.BorealWoodBreastplate)
            {
                item.defense = 2;
            }
            if (item.type == ItemID.BorealWoodGreaves)
            {
                item.defense = 1;
            }
            if (item.type == ItemID.BorealWoodHelmet)
            {
                item.defense = 2;
            }
            if (item.type == ItemID.CactusBreastplate)
            {
                item.defense = 2;
            }
            if (item.type == ItemID.CactusHelmet)
            {
                item.defense = 2;
            }
            if (item.type == ItemID.CactusLeggings)
            {
                item.defense = 1;
            }

            //Tools

            if (item.type == ItemID.AdamantiteChainsaw)
            {
                item.useTime = 12;
                item.tileBoost += 1;
                item.useAnimation = 12;
            }
            if (item.type == ItemID.AdamantiteDrill)
            {
                item.tileBoost += 1;
                item.useTime = 12;
                item.useAnimation = 12;
                item.knockBack = 1.75f;
            }
            if (item.type == ItemID.AdamantitePickaxe)
            {
                item.useTime = 16;
                item.useAnimation = 16;
            }
            if (item.type == ItemID.AdamantiteWaraxe)
            {
                item.useTime = 24;
                item.useAnimation = 24;
            }
            if (item.type == ItemID.CobaltChainsaw)
            {
                item.useTime = 16;
                item.tileBoost += 1;
                item.useAnimation = 16;
            }
            if (item.type == ItemID.CobaltDrill)
            {
                item.tileBoost += 1;
                item.useTime = 16;
                item.useAnimation = 16;
                item.knockBack = .75f;
            }
            if (item.type == ItemID.CobaltPickaxe)
            {
                item.useTime = 20;
                item.useAnimation = 20;
            }
            if (item.type == ItemID.CobaltWaraxe)
            {
                item.useTime = 28;
                item.useAnimation = 28;
            }
            if (item.type == ItemID.CopperAxe)
            {
                item.damage = 4;
                item.axe = 8;
                item.useTime = 27;
                item.tileBoost += 1;
                item.useAnimation = 27;
                item.value = 600;
            }
            if (item.type == ItemID.CopperHammer)
            {
                item.damage = 6;
                item.hammer = 38;
                item.useTime = 30;
                item.tileBoost += 1;
                item.useAnimation = 30;
                item.value = 700;
            }
            if (item.type == ItemID.CopperPickaxe)
            {
                item.damage = 5;
                item.tileBoost += 1;
                item.useTime = 20;
                item.useAnimation = 20;
                item.value = 770;
            }
            if (item.type == ItemID.GoldAxe)
            {
                item.damage = 8;
                item.axe = 12;
                item.useTime = 24;
                item.useAnimation = 24;
                item.value = 12000;
            }
            if (item.type == ItemID.GoldHammer)
            {
                item.damage = 10;
                item.hammer = 59;
                item.useTime = 26;
                item.useAnimation = 16;
                item.value = 12000;
            }
            if (item.type == ItemID.GoldPickaxe)
            {
                item.damage = 7;
                item.useTime = 18;
                item.pick = 59;
                item.useAnimation = 18;
                item.value = 15000;
            }
            if (item.type == ItemID.IronAxe)
            {
                item.damage = 6;
                item.axe = 10;
                item.useTime = 27;
                item.useAnimation = 27;
                item.value = 2400;
            }
            if (item.type == ItemID.IronHammer)
            {
                item.damage = 8;
                item.hammer = 43;
                item.useTime = 28;
                item.useAnimation = 28;
                item.value = 2400;
            }
            if (item.type == ItemID.IronPickaxe)
            {
                item.damage = 6;
                item.useTime = 18;
                item.useAnimation = 18;
                item.value = 3000;
                item.pick = 43;
            }
            if (item.type == ItemID.MythrilChainsaw)
            {
                item.useTime = 14;
                item.tileBoost += 1;
                item.useAnimation = 14;
            }
            if (item.type == ItemID.MythrilDrill)
            {
                item.tileBoost += 1;
                item.useTime = 14;
                item.useAnimation = 14;
                item.knockBack = 1f;
            }
            if (item.type == ItemID.MythrilPickaxe)
            {
                item.useTime = 18;
                item.useAnimation = 18;
            }
            if (item.type == ItemID.MythrilWaraxe)
            {
                item.useTime = 26;
                item.useAnimation = 26;
            }
            if (item.type == ItemID.OrichalcumChainsaw)
            {
                item.useTime = 18;
                item.useAnimation = 18;
            }
            if (item.type == ItemID.OrichalcumDrill)
            {
                item.useTime = 18;
                item.useAnimation = 18;
                item.knockBack = 1f;
            }
            if (item.type == ItemID.PalladiumChainsaw)
            {
                item.useTime = 20;
                item.useAnimation = 20;
            }
            if (item.type == ItemID.PalladiumDrill)
            {
                item.useTime = 20;
                item.useAnimation = 20;
                item.knockBack = .75f;
            }
            if (item.type == ItemID.SilverAxe)
            {
                item.damage = 7;
                item.axe = 11;
                item.useTime = 25;
                item.useAnimation = 25;
                item.value = 4000;
            }
            if (item.type == ItemID.SilverHammer)
            {
                item.damage = 9;
                item.hammer = 50;
                item.useTime = 27;
                item.useAnimation = 27;
                item.value = 6000;
            }
            if (item.type == ItemID.SilverPickaxe)
            {
                item.damage = 6;
                item.useTime = 18;
                item.pick = 50;
                item.useAnimation = 18;
                item.value = 7500;
            }
            if (item.type == ItemID.TinHammer)
            {
                item.melee = true;
                item.useAnimation = 30;
            }
            if (item.type == ItemID.TinPickaxe)
            {
                item.damage = 5;
                item.tileBoost += 1;
                item.useTime = 20;
                item.useAnimation = 20;
                item.value = 770;
            }
            if (item.type == ItemID.TitaniumChainsaw)
            {
                item.useTime = 16;
                item.useAnimation = 16;
            }
            if (item.type == ItemID.TitaniumDrill)
            {
                item.useTime = 16;
                item.useAnimation = 16;
                item.knockBack = 1.75f;
            }

            //Weapons

            if (item.type == ItemID.AdamantiteGlaive)
            {
                item.useTime = 17;
                item.useAnimation = 17;
            }
            if (item.type == ItemID.AdamantiteRepeater)
            {
                item.useTime = 15;
                item.useAnimation = 15;
            }
            if (item.type == ItemID.AdamantiteSword)
            {
                item.useTime = 20;
                item.useAnimation = 20;
            }
            if (item.type == ItemID.AmethystStaff)
            {
                item.useTime = 34;
                item.useAnimation = 34;
            }
            if (item.type == ItemID.BatScepter)
            {
                item.damage = 60;
                item.useTime = 10;
            }
            if (item.type == ItemID.BeamSword)
            {
                item.autoReuse = true;
                item.useTime = 0;
            }
            if (item.type == ItemID.BeeGun)
            {
                item.damage = 11;
                item.knockBack = .5f;
            }
            if (item.type == ItemID.Beenade)
            {
                item.autoReuse = true;
            }
            if (item.type == ItemID.BeesKnees)
            {
                item.autoReuse = true;
            }
            if (item.type == ItemID.BloodyMachete)
            {
                item.damage = 25;
            }
            if (item.type == ItemID.Blowgun)
            {
                item.damage = 30;
            }
            if (item.type == ItemID.Blowpipe)
            {
                item.damage = 10;
            }
            if (item.type == ItemID.Bone)
            {
                item.autoReuse = true;
            }
            if (item.type == ItemID.BoneDagger)
            {
                item.autoReuse = true;
            }
            if (item.type == ItemID.BoneGlove)
            {
                item.autoReuse = true;
            }
            if (item.type == ItemID.BoneJavelin)
            {
                item.autoReuse = true;
            }
            if (item.type == ItemID.BouncyGrenade)
            {
                item.autoReuse = true;
            }
            if (item.type == ItemID.ButchersChainsaw)
            {
                item.damage = 150;
            }
            if (item.type == ItemID.ChainKnife)
            {
                item.damage = 18;
                item.autoReuse = true;
            }
            if (item.type == ItemID.ChlorophyteClaymore)
            {
                item.autoReuse = true;
                item.useTime = 20;
                item.useAnimation = 20;
            }
            if (item.type == ItemID.ChlorophyteSaber)
            {
                item.useTime = 12;
                item.useAnimation = 12;
                item.damage = 55;
            }
            if (item.type == ItemID.CobaltNaginata)
            {
                item.useTime = 20;
                item.useAnimation = 20;
            }
            if (item.type == ItemID.CobaltRepeater)
            {
                item.useTime = 20;
                item.useAnimation = 20;
            }
            if (item.type == ItemID.CobaltSword)
            {
                item.useTime = 18;
                item.useAnimation = 18;
            }
            if (item.type == ItemID.CopperBow)
            {
                item.damage = 7;
                item.useTime = 25;
                item.useAnimation = 25;
                item.value = 525;
            }
            if (item.type == ItemID.CopperBroadsword)
            {
                item.damage = 9;
                item.useTime = 19;
                item.useAnimation = 19;
                item.value = 675;
            }
            if (item.type == ItemID.CopperShortsword)
            {
                item.damage = 10;
                item.useTime = 10;
            }
            if (item.type == ItemID.CursedFlames)
            {
                item.damage = 48;
            }
            if (item.type == ItemID.DayBreak)
            {
                item.damage = 175;
            }
            if (item.type == ItemID.DeadlySphereStaff)
            {
                item.damage = 55;
                item.useTime = 20;
                item.autoReuse = true;
            }
            if (item.type == ItemID.DeathSickle)
            {
                item.damage = 75;
            }
            if (item.type == ItemID.DemonBow)
            {
                item.autoReuse = true;
            }
            if (item.type == ItemID.ElectrosphereLauncher)
            {
                item.damage = 50;
            }
            if (item.type == ItemID.EnchantedBoomerang)
            {
                item.damage = 18;
            }
            if (item.type == ItemID.EnchantedSword)
            {
                item.useTime = 36;
            }
            if (item.type == ItemID.Flairon)
            {
                item.damage = 74;
            }
            if (item.type == ItemID.Flamarang)
            {
                item.damage = 43;
            }
            if (item.type == ItemID.FlintlockPistol)
            {
                item.autoReuse = true;
                item.damage = 35;
                item.useTime = 40;
                item.knockBack = 4.5f;
                item.useAnimation = 40;
            }
            if (item.type == ItemID.FlyingKnife)
            {
                item.damage = 46;
            }
            if (item.type == ItemID.FrostDaggerfish)
            {
                item.autoReuse = true;
            }
            if (item.type == ItemID.FruitcakeChakram)
            {
                item.damage = 26;
            }
            if (item.type == ItemID.GoldBow)
            {
                item.damage = 13;
                item.useTime = 20;
                item.useAnimation = 20;
                item.value = 10500;
                item.autoReuse = true;
            }
            if (item.type == ItemID.GoldBroadsword)
            {
                item.damage = 15;
                item.useTime = 12;
                item.useAnimation = 12;
                item.value = 13500;
                item.autoReuse = true;
            }
            if (item.type == ItemID.GoldShortsword)
            {
                item.damage = 16;
                item.useTime = 7;
                item.autoReuse = true;
            }
            if (item.type == ItemID.Grenade)
            {
                item.autoReuse = true;
            }
            if (item.type == ItemID.Handgun)
            {
                item.autoReuse = true;
            }
            if (item.type == ItemID.HornetStaff)
            {
                item.damage = 18;
                item.useTime = 20;
                item.autoReuse = true;
            }
            if (item.type == ItemID.IceBlade)
            {
                item.useTime = 0;
                item.useAnimation = 20;
            }
            if (item.type == ItemID.ImpStaff)
            {
                item.damage = 42;
                item.useTime = 20;
                item.autoReuse = true;
            }
            if (item.type == ItemID.IronBow)
            {
                item.damage = 9;
                item.useTime = 24;
                item.useAnimation = 24;
                item.value = 2100;
            }
            if (item.type == ItemID.IronBroadsword)
            {
                item.damage = 11;
                item.useTime = 18;
                item.useAnimation = 18;
                item.value = 2700;
            }
            if (item.type == ItemID.IronShortsword)
            {
                item.damage = 13;
                item.useTime = 10;
            }
            if (item.type == ItemID.Javelin)
            {
                item.autoReuse = true;
            }
            if (item.type == ItemID.LaserMachinegun)
            {
                item.mana = 5;
                item.damage = 66;
            }
            if (item.type == ItemID.LeadBow)
            {
                item.damage = 10;
                item.useTime = 26;
                item.useAnimation = 26;
            }
            if (item.type == ItemID.LeadBroadsword)
            {
                item.damage = 12;
                item.useTime = 20;
                item.useAnimation = 20;
                item.value = 2700;
            }
            if (item.type == ItemID.LeadShortsword)
            {
                item.damage = 14;
                item.useTime = 11;
            }
            if (item.type == ItemID.LeafBlower)
            {
                item.damage = 52;
                item.useTime = 6;
            }
            if (item.type == ItemID.LunarFlareBook)
            {
                item.mana = 10;
                item.knockBack = 6;
                item.useTime = 6;
            }
            if (item.type == ItemID.MagicDagger)
            {
                item.autoReuse = true;
            }
            if (item.type == ItemID.MeteorShot)
            {
                item.damage = 12;
            }
            if (item.type == ItemID.MolotovCocktail)
            {
                item.autoReuse = true;
            }
            if (item.type == ItemID.MoltenFury)
            {
                item.damage = 33;
                item.autoReuse = true;
            }
            if (item.type == ItemID.MushroomSpear)
            {
                item.damage = 68;
            }
            if (item.type == ItemID.MythrilHalberd)
            {
                item.useTime = 18;
                item.useAnimation = 18;
            }
            if (item.type == ItemID.MythrilRepeater)
            {
                item.useTime = 14;
                item.useAnimation = 14;
            }
            if (item.type == ItemID.MythrilSword)
            {
                item.useTime = 20;
                item.useAnimation = 20;
            }
            if (item.type == ItemID.NailGun)
            {
                item.damage = 100;
                item.knockBack = 1.65f;
            }
            if (item.type == ItemID.OnyxBlaster)
            {
                item.autoReuse = true;
            }
            if (item.type == ItemID.OpticStaff)
            {
                item.damage = 32;
                item.useTime = 20;
                item.autoReuse = true;
            }
            if (item.type == ItemID.PainterPaintballGun)
            {
                item.autoReuse = true;
            }
            if (item.type == ItemID.PartyGirlGrenade)
            {
                item.damage = 40;
                item.value = 50;
                item.autoReuse = true;
            }
            if (item.type == ItemID.PearlwoodBow)
            {
                item.damage = 47;
                item.crit = 24;
                item.autoReuse = true;
                item.knockBack = 3;
            }
            if (item.type == ItemID.PearlwoodSword)
            {
                item.damage = 62;
                item.crit = 24;
                item.autoReuse = true;
            }
            if (item.type == ItemID.PiranhaGun)
            {
                item.damage = 48;
            }
            if (item.type == ItemID.PirateStaff)
            {
                item.damage = 46;
                item.useTime = 20;
                item.autoReuse = true;
            }
            if (item.type == ItemID.PlatinumBow)
            {
                item.damage = 15;
                item.useTime = 24;
                item.useAnimation = 24;
                item.value = 10500;
                item.autoReuse = true;
            }
            if (item.type == ItemID.PlatinumBroadsword)
            {
                item.damage = 18;
                item.useTime = 18;
                item.useAnimation = 18;
                item.value = 13500;
                item.autoReuse = true;
            }
            if (item.type == ItemID.PlatinumShortsword)
            {
                item.damage = 18;
                item.useTime = 9;
                item.autoReuse = true;
            }
            if (item.type == ItemID.PygmyStaff)
            {
                item.damage = 50;
                item.useTime = 20;
                item.autoReuse = true;
            }
            if (item.type == ItemID.QueenSpiderStaff)
            {
                item.damage = 32;
            }
            if (item.type == ItemID.RainbowCrystalStaff)
            {
                item.damage = 170;
            }
            if (item.type == ItemID.RainbowGun)
            {
                item.damage = 55;
                item.summon = true;
                item.magic = false;
            }
            if (item.type == ItemID.RavenStaff)
            {
                item.damage = 40;
                item.useTime = 20;
                item.autoReuse = true;
            }
            if (item.type == ItemID.RottenEgg)
            {
                item.autoReuse = true;
            }
            if (item.type == ItemID.RubyStaff)
            {
                item.useTime = 20;
                item.useAnimation = 20;
            }
            if (item.type == ItemID.SapphireStaff)
            {
                item.useTime = 26;
                item.useAnimation = 26;
                item.autoReuse = true;
                item.shoot = mod.ProjectileType("SapphireBolt");
            }
            if (item.type == ItemID.ScourgeoftheCorruptor)
            {
                item.damage = 70;
                item.useTime = 17;
            }
            if (item.type == ItemID.Seedler)
            {
                item.damage = 60;
                item.useTime = 20;
            }
            if (item.type == ItemID.ShadowbeamStaff)
            {
                item.damage = 60;
            }
            if (item.type == ItemID.ShadowFlameHexDoll)
            {
                item.damage = 44;
            }
            if (item.type == ItemID.ShadowFlameKnife)
            {
                item.damage = 42;
            }
            if (item.type == ItemID.Shotgun)
            {
                item.autoReuse = true;
            }
            if (item.type == ItemID.Shuriken)
            {
                item.autoReuse = true;
            }
            if (item.type == ItemID.SilverBow)
            {
                item.damage = 10;
                item.useTime = 23;
                item.useAnimation = 23;
                item.value = 5250;
                item.autoReuse = true;
            }
            if (item.type == ItemID.SilverBroadsword)
            {
                item.damage = 12;
                item.useTime = 17;
                item.useAnimation = 17;
                item.value = 6750;
                item.autoReuse = true;
            }
            if (item.type == ItemID.SilverShortsword)
            {
                item.damage = 14;
                item.useTime = 9;
                item.autoReuse = true;
            }
            if (item.type == ItemID.SlimeStaff)
            {
                item.damage = 10;
                item.useTime = 20;
                item.autoReuse = true;
            }
            if (item.type == ItemID.SniperRifle)
            {
                item.damage = 225;
            }
            if (item.type == ItemID.Snowball)
            {
                item.autoReuse = true;
            }
            if (item.type == ItemID.SolarEruption)
            {
                item.damage = 130;
            }
            if (item.type == ItemID.SoulDrain)
            {
                item.mana = 8;
                item.damage = 36;
                item.useTime = 10;
            }
            if (item.type == ItemID.SpiderStaff)
            {
                item.damage = 30;
                item.useTime = 20;
                item.autoReuse = true;
            }
            if (item.type == ItemID.SpikyBall)
            {
                item.autoReuse = true;
            }
            if (item.type == ItemID.StarAnise)
            {
                item.autoReuse = true;
            }
            if (item.type == ItemID.StardustCellStaff)
            {
                item.damage = 66;
                item.useTime = 20;
                item.autoReuse = true;
            }
            if (item.type == ItemID.StardustDragonStaff)
            {
                item.useTime = 20;
                item.autoReuse = true;
            }
            if (item.type == ItemID.StickyGrenade)
            {
                item.autoReuse = true;
            }
            if (item.type == ItemID.StylistKilLaKillScissorsIWish)
            {
                item.useTime = 10;
                item.autoReuse = true;
            }
            if (item.type == ItemID.TempestStaff)
            {
                item.damage = 55;
                item.useTime = 20;
                item.autoReuse = true;
            }
            if (item.type == ItemID.TendonBow)
            {
                item.autoReuse = true;
            }
            if (item.type == ItemID.TheUndertaker)
            {
                item.autoReuse = true;
            }
            if (item.type == ItemID.ThornChakram)
            {
                item.damage = 32;
            }
            if (item.type == ItemID.ThrowingKnife)
            {
                item.autoReuse = true;
            }
            if (item.type == ItemID.TinBow)
            {
                item.damage = 8;
                item.useTime = 27;
                item.useAnimation = 27;
                item.value = 525;
                item.knockBack = .1f;
            }
            if (item.type == ItemID.TinBroadsword)
            {
                item.damage = 10;
                item.useTime = 21;
                item.useAnimation = 21;
                item.value = 675;
            }
            if (item.type == ItemID.TinShortsword)
            {
                item.damage = 12;
                item.useTime = 12;
            }
            if (item.type == ItemID.ToxicFlask)
            {
                item.mana = 26;
                item.autoReuse = true;
            }
            if (item.type == ItemID.TungstenBow)
            {
                item.damage = 11;
                item.useTime = 25;
                item.useAnimation = 25;
                item.value = 5250;
                item.autoReuse = true;
            }
            if (item.type == ItemID.TungstenBroadsword)
            {
                item.damage = 13;
                item.useTime = 19;
                item.useAnimation = 19;
                item.autoReuse = true;
            }
            if (item.type == ItemID.TungstenShortsword)
            {
                item.damage = 15;
                item.useTime = 10;
                item.autoReuse = true;
            }
            if (item.type == ItemID.VortexBeater)
            {
                item.damage = 60;
            }
            if (item.type == ItemID.WoodenBoomerang)
            {
                item.damage = 12;
            }
            if (item.type == ItemID.Xenopopper)
            {
                item.knockBack = 5;
                item.damage = 60;
            }
            if (item.type == ItemID.XenoStaff)
            {
                item.damage = 42;
                item.useTime = 20;
                item.autoReuse = true;
            }
            if (item.type == ItemID.ZombieArm)
            {
                item.autoReuse = true;
            }
            Mod Calamity = ModLoader.GetMod("CalamityMod");
            if (Calamity == null)
            {
                if (item.type == ItemID.AncientGoldHelmet)
                {
                    item.defense = 5;
                }
                if (item.type == ItemID.AncientIronHelmet)
                {
                    item.defense = 3;
                }
                if (item.type == ItemID.CopperChainmail)
                {
                    item.defense = 3;
                }
                if (item.type == ItemID.Anchor)
                {
                    item.damage = 47;
                }
                if (item.type == ItemID.TinGreaves)
                {
                    item.defense = 2;
                }
                if (item.type == ItemID.TinChainmail)
                {
                    item.defense = 3;
                }
                if (item.type == ItemID.TinHelmet)
                {
                    item.defense = 2;
                }
                if (item.type == ItemID.TungstenHelmet)
                {
                    item.defense = 4;
                }
                if (item.type == ItemID.TungstenGreaves)
                {
                    item.defense = 4;
                }
                if (item.type == ItemID.TungstenChainmail)
                {
                    item.defense = 5;
                }
                if (item.type == ItemID.SilverHelmet)
                {
                    item.defense = 4;
                }
                if (item.type == ItemID.SilverGreaves)
                {
                    item.defense = 4;
                }
                if (item.type == ItemID.SilverChainmail)
                {
                    item.defense = 5;
                }
                if (item.type == ItemID.PlatinumHelmet)
                {
                    item.defense = 5;
                }
                if (item.type == ItemID.PlatinumGreaves)
                {
                    item.defense = 5;
                }
                if (item.type == ItemID.PlatinumChainmail)
                {
                    item.defense = 6;
                }
                if (item.type == ItemID.LeadHelmet)
                {
                    item.defense = 3;
                }
                if (item.type == ItemID.LeadGreaves)
                {
                    item.defense = 3;
                }
                if (item.type == ItemID.LeadChainmail)
                {
                    item.defense = 4;
                }
                if (item.type == ItemID.IronHelmet)
                {
                    item.defense = 3;
                }
                if (item.type == ItemID.IronChainmail)
                {
                    item.defense = 4;
                }
                if (item.type == ItemID.GoldGreaves)
                {
                    item.defense = 5;
                }
                if (item.type == ItemID.IronGreaves)
                {
                    item.defense = 3;
                }
                if (item.type == ItemID.GoldChainmail)
                {
                    item.defense = 6;
                }
                if (item.type == ItemID.GladiatorHelmet)
                {
                    item.defense = 4;
                }
                if (item.type == ItemID.GladiatorBreastplate)
                {
                    item.defense = 6;
                }
                if (item.type == ItemID.CopperHelmet)
                {
                    item.defense = 2;
                }
                if (item.type == ItemID.CopperGreaves)
                {
                    item.defense = 2;
                }
                if (item.type == ItemID.BallOHurt)
                {
                    item.damage = 24;
                }
                if (item.type == ItemID.BlueMoon)
                {
                    item.damage = 37;
                }
                if (item.type == ItemID.BluePhaseblade)
                {
                    item.damage = 30;
                    item.knockBack = 4;
                    item.crit = 3;
                    item.autoReuse = true;
                    item.useAnimation = 23;
                    item.useTime = 23;
                }
                if (item.type == ItemID.BluePhasesaber)
                {
                    item.damage = 60;
                    item.knockBack = 4;
                    item.crit = 3;
                    item.autoReuse = true;
                    item.useAnimation = 23;
                    item.useTime = 23;
                }
                if (item.type == ItemID.BookofSkulls)
                {
                    item.damage = 45;
                    item.knockBack = 6;
                    item.mana = 10;
                }
                if (item.type == ItemID.BreakerBlade)
                {

                    item.autoReuse = true;
                    item.damage = 55;
                }
                if (item.type == ItemID.ChainGuillotines)
                {

                    item.damage = 50;
                }
                if (item.type == ItemID.ChargedBlasterCannon)
                {
                    item.mana = 10;
                    item.knockBack = 2.5f;
                    item.damage = 60;
                }
                if (item.type == ItemID.CrystalVileShard)
                {
                    item.damage = 28;
                }
                if (item.type == ItemID.DaoofPow)
                {
                    item.damage = 90;
                }
                if (item.type == ItemID.EldMelter)
                {
                    item.knockBack = .6f;
                    item.shoot = mod.ProjectileType("EldGel");
                    item.crit = 6;
                }
                if (item.type == ItemID.Excalibur)
                {
                    item.autoReuse = true;
                    item.useTime = 16;
                    item.useAnimation = 16;
                    item.damage = 50;
                }
                if (item.type == ItemID.FireworksLauncher)
                {
                    item.useTime = 15;
                    item.useAnimation = 15;
                }
                if (item.type == ItemID.Flamethrower)
                {
                    item.damage = 40;
                    item.knockBack = .5f;
                }
                if (item.type == ItemID.FlowerofFrost)
                {
                    item.damage = 68;
                }
                if (item.type == ItemID.FlowerPow)
                {
                    item.damage = 106;
                }
                if (item.type == ItemID.Frostbrand)
                {
                    item.damage = 60;
                }
                if (item.type == ItemID.FrostStaff)
                {
                    item.damage = 54;
                }
                if (item.type == ItemID.GolemFist)
                {
                    item.damage = 90;
                }
                if (item.type == ItemID.GreenPhaseblade)
                {
                    item.damage = 30;
                    item.knockBack = 4;
                    item.crit = 3;
                    item.autoReuse = true;
                    item.useAnimation = 23;
                    item.useTime = 23;
                }
                if (item.type == ItemID.GreenPhasesaber)
                {
                    item.damage = 60;
                    item.knockBack = 4;
                    item.crit = 3;
                    item.autoReuse = true;
                    item.useAnimation = 23;
                    item.useTime = 23;
                }
                if (item.type == ItemID.Gungnir)
                {
                    item.damage = 70;
                }
                if (item.type == ItemID.IceBoomerang)
                {
                    item.damage = 21;

                }
                if (item.type == ItemID.IceBow)
                {
                    item.autoReuse = true;
                }
                if (item.type == ItemID.IceSickle)
                {
                    item.damage = 50;
                    item.autoReuse = true;
                }
                if (item.type == ItemID.Keybrand)
                {
                    item.damage = 120;
                }
                if (item.type == ItemID.KOCannon)
                {
                    item.damage = 53;
                }
                if (item.type == ItemID.Marrow)
                {
                    item.autoReuse = true;
                }
                if (item.type == ItemID.MedusaHead)
                {
                    item.damage = 56;
                }
                if (item.type == ItemID.MoonlordTurretStaff)
                {
                    item.damage = 75;
                }
                if (item.type == ItemID.NettleBurst)
                {
                    item.damage = 40;
                }
                if (item.type == ItemID.NightsEdge)
                {
                    item.autoReuse = true;
                    item.useTime = 26;
                    item.useAnimation = 26;
                }
                if (item.type == ItemID.PaladinsHammer)
                {
                    item.autoReuse = true;
                }
                if (item.type == ItemID.PhoenixBlaster)
                {
                    item.autoReuse = true;
                }
                if (item.type == ItemID.PoisonStaff)
                {
                    item.damage = 56;
                }
                if (item.type == ItemID.PsychoKnife)
                {
                    item.damage = 100;
                }
                if (item.type == ItemID.PurplePhaseblade)
                {
                    item.damage = 30;
                    item.knockBack = 4;
                    item.crit = 3;
                    item.autoReuse = true;
                    item.useAnimation = 23;
                    item.useTime = 23;
                }
                if (item.type == ItemID.PurplePhasesaber)
                {
                    item.damage = 60;
                    item.knockBack = 4;
                    item.crit = 3;
                    item.autoReuse = true;
                    item.useAnimation = 23;
                    item.useTime = 23;
                }
                if (item.type == ItemID.RainbowRod)
                {
                    item.damage = 90;
                }
                if (item.type == ItemID.RedPhaseblade)
                {
                    item.damage = 30;
                    item.knockBack = 4;
                    item.crit = 3;
                    item.autoReuse = true;
                    item.useAnimation = 23;
                    item.useTime = 23;
                }
                if (item.type == ItemID.RedPhasesaber)
                {
                    item.damage = 60;
                    item.knockBack = 4;
                    item.crit = 3;
                    item.autoReuse = true;
                    item.useAnimation = 23;
                    item.useTime = 23;
                }
                if (item.type == ItemID.SpectreStaff)
                {
                    item.damage = 90;
                    item.useTime = 18;
                    item.mana = 8;
                }
                if (item.type == ItemID.StaffofEarth)
                {
                    item.damage = 100;
                }
                if (item.type == ItemID.StaffoftheFrostHydra)
                {
                    item.damage = 124;
                }
                if (item.type == ItemID.Starfury)
                {
                    item.autoReuse = true;
                }
                if (item.type == ItemID.Sunfury)
                {
                    item.damage = 56;
                }
                if (item.type == ItemID.TerraBlade)
                {
                    item.damage = 105;
                    item.useTime = 0;
                    item.useAnimation = 16;
                }
                if (item.type == ItemID.TheMeatball)
                {
                    item.damage = 26;
                }
                if (item.type == ItemID.TrueNightsEdge)
                {
                    item.autoReuse = true;
                    item.useTime = 0;
                    item.useAnimation = 26;
                }
                if (item.type == ItemID.VenomStaff)
                {
                    item.damage = 80;
                }
                if (item.type == ItemID.VenusMagnum)
                {
                    item.autoReuse = true;
                }
                if (item.type == ItemID.WandofSparking)
                {
                    item.autoReuse = true;
                    item.mana = 1;
                    item.knockBack = 1;
                    item.damage = 12;
                }
                if (item.type == ItemID.WhitePhaseblade)
                {
                    item.damage = 30;
                    item.knockBack = 4;
                    item.crit = 3;
                    item.autoReuse = true;
                    item.useAnimation = 23;
                    item.useTime = 23;
                }
                if (item.type == ItemID.WhitePhasesaber)
                {
                    item.damage = 60;
                    item.knockBack = 4;
                    item.crit = 3;
                    item.autoReuse = true;
                    item.useAnimation = 23;
                    item.useTime = 23;
                }
                if (item.type == ItemID.YellowPhaseblade)
                {
                    item.damage = 30;
                    item.knockBack = 4;
                    item.crit = 3;
                    item.autoReuse = true;
                    item.useAnimation = 23;
                    item.useTime = 23;
                }
                if (item.type == ItemID.YellowPhasesaber)
                {
                    item.damage = 60;
                    item.knockBack = 4;
                    item.crit = 3;
                    item.autoReuse = true;
                    item.useAnimation = 23;
                    item.useTime = 23;
                }
            }

            //Ammo

            if (item.type == ItemID.PartyBullet)
            {
                item.damage = 12;
            }

            //Items

            if (item.type == ItemID.CopperBar)
            {
                item.value = 1125;
            }
            if (item.type == ItemID.CopperOre)
            {
                item.value = 375;
            }
            if (item.type == ItemID.GoldBar)
            {
                item.value = 9000;
            }
            if (item.type == ItemID.GoldOre)
            {
                item.value = 3000;
            }
            if (item.type == ItemID.IronBar)
            {
                item.value = 2250;
            }
            if (item.type == ItemID.IronOre)
            {
                item.value = 750;
            }
            if (item.type == ItemID.SilverBar)
            {
                item.value = 4500;
            }
            if (item.type == ItemID.SilverOre)
            {
                item.value = 1500;
            }
        }
        public override void OnHitNPC(Item item, Player player, NPC target, int damage, float knockback, bool crit)
        {
            if (item.type == ItemID.TaxCollectorsStickOfDoom)
            {
                target.AddBuff(BuffID.Midas, 18000);
            }
            Mod Calamity = ModLoader.GetMod("CalamityMod");
            if (Calamity == null)
            {
                if (item.type == ItemID.Excalibur)
                {
                    target.AddBuff(BuffID.OnFire, 150);
                }
                if (item.type == ItemID.NightsEdge)
                {
                    target.AddBuff(BuffID.CursedInferno, 60);
                }
                if (item.type == ItemID.TerraBlade)
                {
                    target.AddBuff(BuffID.CursedInferno, 120);
                    target.AddBuff(BuffID.OnFire, 450);
                }
                if (item.type == ItemID.TrueExcalibur)
                {
                    target.AddBuff(BuffID.OnFire, 300);
                }
                if (item.type == ItemID.TrueNightsEdge)
                {
                    target.AddBuff(BuffID.CursedInferno, 90);
                }
            }
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (item.type == ItemID.Aglet)
            {
                foreach (TooltipLine line2 in tooltips)
                {
                    if (line2.mod == "Terraria" && line2.Name == "Tooltip0")
                    {
                        line2.text = "8% increased movement speed";
                    }
                }
            }
            if (item.type == ItemID.AnkletoftheWind)
            {
                foreach (TooltipLine line2 in tooltips)
                {
                    if (line2.mod == "Terraria" && line2.Name == "Tooltip0")
                    {
                        line2.text = "16% increased movement speed";
                    }
                }
            }
            if (item.type == ItemID.CelestialCuffs)
            {
                foreach (TooltipLine line2 in tooltips)
                {
                    if (line2.mod == "Terraria" && line2.Name == "Tooltip0")
                    {
                        line2.text = "	Increases pickup range for mana stars, 20 % increased magic damage and increased mana by 50";
                    }
                }
            }
            if (item.type == ItemID.ClimbingClaws)
            {
                var line = new TooltipLine(mod, "ClimbingClaws", "Increases melee damage by 8%.");
                tooltips.Add(line);
            }
            if (item.type == ItemID.FireGauntlet)
            {
                foreach (TooltipLine line2 in tooltips)
                {
                    if (line2.mod == "Terraria" && line2.Name == "Tooltip0")
                    {
                        line2.text = "Increases melee knockback and inflicts fire damage on attack 15% increased melee damage and speed.";
                    }
                }
            }
            if (item.type == ItemID.GravityGlobe)
            {
                var line = new TooltipLine(mod, "Globe", "Bonus stats to wings");
                tooltips.Add(line);
            }
            if (item.type == ItemID.MasterNinjaGear)
            {
                var line = new TooltipLine(mod, "MasterNinjaGear", "Increases movement speed by 12%, and melee damage by 8%");
                tooltips.Add(line);
            }
            if (item.type == ItemID.ShoeSpikes)
            {
                var line = new TooltipLine(mod, "ShoeSpikes", "Increases movement speed by 12%.");
                tooltips.Add(line);
            }
            if (item.type == ItemID.TigerClimbingGear)
            {
                var line = new TooltipLine(mod, "TigerClimbingGear", "Increases movement speed by 12%, and melee damage by 8%");
                tooltips.Add(line);
            }
            if (item.type == ItemID.BrainOfConfusion)
            {
                var line = new TooltipLine(mod, "BrainOfConfusion", "Attacks may confuse enemies, melee attacks confuse for longer");
                tooltips.Add(line);
            }
        }






        public override void UpdateEquip(Item item, Player player)
        {
            if (item.type == ItemID.AdamantiteBreastplate)
            {
                player.moveSpeed += 0.15f;
            }
            if (item.type == ItemID.AdamantiteHeadgear)
            {
                player.moveSpeed += 0.25f;
            }
            if (item.type == ItemID.AdamantiteHelmet)
            {
                player.moveSpeed += 0.25f;
            }
            if (item.type == ItemID.AdamantiteLeggings)
            {
                player.moveSpeed += 0.35f;
            }
            if (item.type == ItemID.AdamantiteMask)
            {
                player.moveSpeed += 0.25f;
            }
            if (item.type == ItemID.CobaltBreastplate)
            {
                player.moveSpeed += 0.15f;
            }
            if (item.type == ItemID.CobaltHat)
            {
                player.moveSpeed += 0.25f;
            }
            if (item.type == ItemID.CobaltHelmet)
            {
                player.moveSpeed += 0.25f;
            }
            if (item.type == ItemID.CobaltLeggings)
            {
                player.moveSpeed += 0.35f;
            }
            if (item.type == ItemID.CobaltMask)
            {
                player.moveSpeed += 0.25f;
            }
            if (item.type == ItemID.GladiatorLeggings)
            {
                player.thrownCost33 = true;
            }
            if (item.type == ItemID.MythrilChainmail)
            {
                player.moveSpeed += 0.15f;
            }
            if (item.type == ItemID.MythrilGreaves)
            {
                player.moveSpeed += 0.35f;
            }
            if (item.type == ItemID.MythrilHat)
            {
                player.moveSpeed += 0.25f;
            }
            if (item.type == ItemID.MythrilHelmet)
            {
                player.moveSpeed += 0.25f;
            }
            if (item.type == ItemID.MythrilHood)
            {
                player.moveSpeed += 0.25f;
            }
            if (item.type == ItemID.NinjaHood) player.moveSpeed += 0.10f;

            if (item.type == ItemID.NinjaPants) player.moveSpeed += 0.35f;

            if (item.type == ItemID.NinjaShirt) player.moveSpeed += 0.15f;

            Mod Calamity = ModLoader.GetMod("CalamityMod");
            if (Calamity == null)
            {
                if (item.type == ItemID.GladiatorLeggings)
                {
                    player.thrownCost33 = true;
                }
                if (item.type == ItemID.ObsidianPants)
                {
                    player.buffImmune[BuffID.OnFire] = true;
                    player.buffImmune[BuffID.Burning] = true;
                    player.moveSpeed += 0.15f;
                }
                if (item.type == ItemID.ObsidianShirt)
                {
                    player.lavaRose = true;
                }
                if (item.type == ItemID.ObsidianPants)
                {
                    player.rangedDamage += .1f;
                }
            }
        }






        public override void UpdateAccessory(Item item, Player player, bool hideVisual)
        {
            if (item.type == ItemID.AnkletoftheWind)
            {
                player.moveSpeed += 0.06f;
            }
            if (item.type == ItemID.Aglet)
            {
                player.moveSpeed += 0.03f;
            }
            if (player.dJumpEffectBlizzard && player.doubleJumpBlizzard)
            {
                player.runAcceleration *= 1.25f;
                player.maxRunSpeed += 0.15f;
            }
            if (item.type == ItemID.BrainOfConfusion)
            {
                player.GetModPlayer<BrainPlayer>().Confuse = true;
            }
            if (item.type == ItemID.CelestialCuffs)
            {
                player.magicDamage += 0.05f;
                player.statManaMax2 += 50;
            }
            if (item.type == ItemID.ClimbingClaws)
            {
                player.meleeDamage += 0.08f;
            }
            if (item.type == ItemID.FireGauntlet)
            {
                player.meleeDamage += 0.05f;
                player.meleeSpeed += 0.05f;
            }
            if (item.type == ItemID.FrostsparkBoots)
            {
                player.moveSpeed += 0.06f;
            }
            if (Main.LocalPlayer.gravControl2 == true)
            {
                player.wingTimeMax += 90;
                player.buffImmune[BuffID.VortexDebuff] = true;
            }
            if (item.type == ItemID.MasterNinjaGear)
            {
                player.moveSpeed += 0.12f;
                player.meleeDamage += 0.08f;
            }
            if (item.type == ItemID.ShoeSpikes)
            {
                player.moveSpeed += 0.12f;
            }
            if (item.type == ItemID.TigerClimbingGear)
            {
                player.moveSpeed += 0.12f;
                player.meleeDamage += 0.08f;
            }           
        }
        public override void VerticalWingSpeeds(Item item, Player player, ref float ascentWhenFalling, ref float ascentWhenRising, ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)
        {
            if (Main.LocalPlayer.gravControl2 == true)
            {
                constantAscend *= 1.20f;
                maxAscentMultiplier *= 1.05f;
            }
        }

        public override void HorizontalWingSpeeds(Item item, Player player, ref float speed, ref float acceleration)
        {
            if (Main.LocalPlayer.gravControl2 == true)
            {
                speed *= 1.30f;
                acceleration *= 1.25f;
            }
        }


        public override string IsArmorSet(Item head, Item body, Item legs)
        {
            if (head.type == ItemID.AncientGoldHelmet && body.type == ItemID.GoldChainmail && legs.type == ItemID.GoldGreaves)
            {
                return "Gold";
            }
            if (head.type == ItemID.AncientIronHelmet && body.type == ItemID.IronChainmail && legs.type == ItemID.IronGreaves)
            {
                return "Iron";
            }
            if (head.type == ItemID.AnglerHat && body.type == ItemID.AnglerVest && legs.type == ItemID.AnglerPants)
            {
                return "Angler";
            }

            if (head.type == ItemID.BorealWoodHelmet && body.type == ItemID.BorealWoodBreastplate && legs.type == ItemID.BorealWoodGreaves)
            {
                return "BWood";
            }
            if (head.type == ItemID.CactusHelmet && body.type == ItemID.CactusBreastplate && legs.type == ItemID.CactusLeggings)
            {
                return "Cactus";
            }
            if (head.type == ItemID.CopperHelmet && body.type == ItemID.CopperChainmail && legs.type == ItemID.CopperGreaves)
            {
                return "Copper";
            }
            if (head.type == ItemID.EbonwoodHelmet && body.type == ItemID.EbonwoodBreastplate && legs.type == ItemID.EbonwoodGreaves)
            {
                return "EWood";
            }
            if (head.type == ItemID.EskimoHood && body.type == ItemID.EskimoCoat && legs.type == ItemID.EskimoPants)
            {
                return "Eskimo";
            }
            if (head.type == ItemID.GladiatorHelmet && body.type == ItemID.GladiatorBreastplate && legs.type == ItemID.GladiatorLeggings)
            {
                return "Gladiator";
            }
            if (head.type == ItemID.GoldHelmet && body.type == ItemID.GoldChainmail && legs.type == ItemID.GoldGreaves)
            {
                return "Gold";
            }
            if (head.type == ItemID.IronHelmet && body.type == ItemID.IronChainmail && legs.type == ItemID.IronGreaves)
            {
                return "Iron";
            }
            if (head.type == ItemID.MoltenHelmet && body.type == ItemID.MoltenBreastplate && legs.type == ItemID.MoltenGreaves)
            {
                return "MoltenHelmet";
            }
            if (head.type == ItemID.ObsidianHelm && body.type == ItemID.ObsidianShirt && legs.type == ItemID.ObsidianPants)
            {
                return "ObsidianOutlaw";
            }
            if (head.type == ItemID.PalmWoodHelmet && body.type == ItemID.PalmWoodBreastplate && legs.type == ItemID.PalmWoodGreaves)
            {
                return "PWood";
            }
            if (head.type == ItemID.PearlwoodHelmet && body.type == ItemID.PearlwoodBreastplate && legs.type == ItemID.PearlwoodGreaves)
            {
                return "Pearls";
            }
            if (head.type == ItemID.PinkEskimoHood && body.type == ItemID.PinkEskimoCoat && legs.type == ItemID.PinkEskimoPants)
            {
                return "PinkEskimo";
            }
            if (head.type == ItemID.PlatinumHelmet && body.type == ItemID.PlatinumChainmail && legs.type == ItemID.PlatinumGreaves)
            {
                return "Platinum";
            }
            if (head.type == ItemID.RainHat && body.type == ItemID.RainCoat)
            {
                return "Rain";
            }
            if (head.type == ItemID.RichMahoganyHelmet && body.type == ItemID.RichMahoganyBreastplate && legs.type == ItemID.RichMahoganyGreaves)
            {
                return "RWood";
            }
            if (head.type == ItemID.ShadewoodHelmet && body.type == ItemID.ShadewoodBreastplate && legs.type == ItemID.ShadewoodGreaves)
            {
                return "SWood";
            }
            if (head.type == ItemID.ShadowHelmet && body.type == ItemID.ShadowScalemail && legs.type == ItemID.ShadowGreaves)
            {
                return "Shadow";
            }
            if (head.type == ItemID.SilverHelmet && body.type == ItemID.SilverChainmail && legs.type == ItemID.SilverGreaves)
            {
                return "Silver";
            }
            if (head.type == ItemID.TinHelmet && body.type == ItemID.TinChainmail && legs.type == ItemID.TinGreaves)
            {
                return "Tin";
            }
            if (head.type == ItemID.TungstenHelmet && body.type == ItemID.TungstenChainmail && legs.type == ItemID.TungstenGreaves)
            {
                return "Tungsten";
            }
            if (head.type == ItemID.WoodHelmet && body.type == ItemID.WoodBreastplate && legs.type == ItemID.WoodGreaves)
            {
                return "Wood";
            }
            return "";
        }



        public override void UpdateArmorSet(Player player, string set)
        {
            if (set == "Angler")
            {
                player.fishingSkill += 15;
                player.setBonus = "15 percent bonus fishing level";
            }
            if (set == "Cactus")
            {
                player.AddBuff(BuffID.Thorns, 2);
                player.statDefense -= 1;
                player.setBonus = "Gain the thorns buff.";
            }
            if (set == "BWood")
            {
                player.AddBuff(BuffID.Warmth, 2);
                player.buffImmune[BuffID.Chilled] = true;
                player.statDefense -= 1;
                player.setBonus = "Take reduced damage from the cold and gain immunity to the chilled debuff";
            }
            if (set == "EWood")
            {
                player.AddBuff(BuffID.Battle, 2);
                player.statDefense -= 1;
                player.setBonus = "Increased spawn rates";
            }
            if (set == "EWood")
            {
                player.AddBuff(BuffID.Battle, 2);
                player.statDefense -= 1;
                player.setBonus = "Increased spawn rates";
            }
            if (set == "Eskimo")
            {
                player.AddBuff(BuffID.Warmth, 2);
                player.thrownDamage += .3f;
                player.meleeDamage += .3f;
                player.magicDamage += .3f;
                player.minionDamage += .3f;
                player.rangedDamage += .3f;
                player.setBonus = "Take reduced damage from the cold and deal 30% extra damage.";
            }
            if (set == "MoltenHelmet")
            {
                player.thrownDamage += .17f;
                player.magicDamage += .17f;
                player.minionDamage += .17f;
                player.rangedDamage += .17f;
                player.setBonus = "Increases  damage by 17%.";
            }
            if (set == "PWood")
            {
                player.AddBuff(BuffID.Flipper, 2);
                player.statDefense -= 1;
                player.setBonus = "Gain the ability to swim.";
            }
            if (set == "Pearls")
            {
                player.thrownDamage += 1f;
                player.meleeDamage += 1f;
                player.magicDamage += 1f;
                player.minionDamage += 1f;
                player.rangedDamage += 1f;
                player.setBonus = "Double Damage!";
            }
            if (set == "PinkEskimo")
            {
                player.AddBuff(BuffID.Warmth, 2);
                player.thrownDamage += .5f;
                player.meleeDamage += .5f;
                player.magicDamage += .5f;
                player.minionDamage += .5f;
                player.rangedDamage += .5f;
                player.setBonus = "Take reduced damage from the cold and deal 50% extra damage.";
            }
            if (set == "Rain")
            {
                player.maxMinions += 1;
                player.setBonus = "1 extra minion.";
            }
            if (set == "RWood")
            {
                player.buffImmune[BuffID.Poisoned] = true;
                player.statDefense -= 1;
                player.setBonus = "Immunity to poison";
            }
            if (set == "SWood")
            {
                player.AddBuff(BuffID.Battle, 2);
                player.statDefense -= 1;
                player.setBonus = "Increased spawn rates";
            }
            if (set == "Shadow")
            {
                player.thrownDamage += .2f;
                player.magicDamage += .2f;
                player.minionDamage += .2f;
                player.rangedDamage += .2f;
                player.setBonus = "Increases non melee damage by 20%.";
                player.moveSpeed -= 0.15f;
            }
            if (set == "Wood")
            {
                player.moveSpeed += 0.10f;
                player.statDefense -= 1;
                player.setBonus = "10 % Bonus movement speed";
            }
            Mod Calamity = ModLoader.GetMod("CalamityMod");
            if (Calamity == null)
            {
                if (set == "Gold")
                {
                    player.moveSpeed += 0.30f;
                    player.statDefense += 1;
                    player.setBonus = "4 defense and 30% extra movement speed.";
                }
                if (set == "Iron")
                {
                        player.moveSpeed += 0.30f;
                        player.statDefense += 1;
                        player.setBonus = "3 defense and 30% extra movement speed.";
                }
                if (set == "Copper")
                {
                    player.moveSpeed += 0.10f;
                    player.statDefense -= 2;
                    player.setBonus = "10% extra movement speed.";
                }
                if (set == "Gladiator")
                {
                        player.thrownVelocity += .50f;
                        player.setBonus = "Massively increases throwing velocity";
                }
                if (set == "Gold")
                {
                    player.moveSpeed += 0.25f;
                    player.statDefense -= 3;
                    player.setBonus = "25% extra movement speed.";
                }
                if (set == "Iron")
                {
                    player.moveSpeed += 0.15f;
                    player.statDefense -= 2;
                    player.setBonus = "15% extra movement speed.";
                }
                if (set == "ObsidianOutlaw")
                {
                        player.AddBuff(BuffID.Inferno, 2);
                        player.setBonus = "Grants you an inferno";
                }
                if (set == "Platinum")
                {
                    player.statDefense += 1;
                    player.setBonus = "5 defense";
                }
                if (set == "Silver")
                {
                    player.moveSpeed += 0.20f;
                    player.statDefense -= 3;
                    player.setBonus = "20% extra movement speed.";
                }
                if (set == "Tungsten")
                {
                    player.statDefense += 1;
                    player.setBonus = "4 defense";
                }
            }
        }
    }
}
