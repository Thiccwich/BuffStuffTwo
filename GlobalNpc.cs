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
    public class Party : GlobalNPC
    {
        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            if (type == NPCID.PartyGirl)
            {
                shop.item[nextSlot].SetDefaults(ItemID.Gel);
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ItemID.PinkGel);
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ItemID.MoneyTrough);
                nextSlot++;
                { if (Main.hardMode == true)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.Blindfold);
                        nextSlot++;
                    }
                }
            }
            if (type == NPCID.Dryad)
            {
                shop.item[nextSlot].SetDefaults(ItemID.HerbBag);
                nextSlot++;
            }
        }
        public override void NPCLoot(NPC npc)
        {
            if (npc.type == NPCID.Shark)
            {
                if (Main.rand.Next(100) == 0)
                    Item.NewItem(npc.getRect(), ItemID.SharkToothNecklace, 1);
            }
            if (npc.type == NPCID.Shark)
            {
                if (Main.rand.Next(3000) == 0)
                    Item.NewItem(npc.getRect(), ItemID.BottomlessBucket, 1);
            }
            if (npc.type == NPCID.Shark)
            {
                if (Main.rand.Next(3000) == 0)
                    Item.NewItem(npc.getRect(), ItemID.SuperAbsorbantSponge, 1);
            }
            if (npc.type == NPCID.PinkJellyfish)
            {
                if (Main.rand.Next(3000) == 0)
                    Item.NewItem(npc.getRect(), ItemID.BottomlessBucket, 1);
            }
            if (npc.type == NPCID.PinkJellyfish)
            {
                if (Main.rand.Next(3000) == 0)
                    Item.NewItem(npc.getRect(), ItemID.SuperAbsorbantSponge, 1);
            }

            if (npc.type == NPCID.Crab)
            {
                if (Main.rand.Next(3000) == 0)
                    Item.NewItem(npc.getRect(), ItemID.BottomlessBucket, 1);
            }
            if (npc.type == NPCID.Crab)
            {
                if (Main.rand.Next(3000) == 0)
                    Item.NewItem(npc.getRect(), ItemID.SuperAbsorbantSponge, 1);
            }
            if (npc.type == NPCID.SeaSnail)
            {
                if (Main.rand.Next(300) == 0)
                    Item.NewItem(npc.getRect(), ItemID.BottomlessBucket, 1);
            }
            if (npc.type == NPCID.SeaSnail)
            {
                if (Main.rand.Next(300) == 0)
                    Item.NewItem(npc.getRect(), ItemID.SuperAbsorbantSponge, 1);
            }
            if (npc.type == NPCID.Squid)
            {
                if (Main.rand.Next(300) == 0)
                    Item.NewItem(npc.getRect(), ItemID.BottomlessBucket, 1);
            }
            if (npc.type == NPCID.Squid)
            {
                if (Main.rand.Next(300) == 0)
                    Item.NewItem(npc.getRect(), ItemID.SuperAbsorbantSponge, 1);
            }
            if (npc.type == NPCID.GoblinWarrior)
            {
                if (Main.rand.Next(100) == 0 && Main.hardMode)
                    Item.NewItem(npc.getRect(), ItemID.ArmorPolish, 1);
            }
            if (npc.type == NPCID.TaxCollector)
            {
                if (Main.rand.Next(3) == 0 && Main.hardMode)
                    Item.NewItem(npc.getRect(), ItemID.Megaphone, 1);
            }
            if (npc.type == NPCID.Nurse)
            {
                if (Main.rand.Next(1) == 0 && Main.hardMode)
                    Item.NewItem(npc.getRect(), ItemID.Vitamins, 1);
            }
            if (npc.type == NPCID.Stylist)
            {
                if (Main.rand.Next(1) == 0 && Main.hardMode)
                    Item.NewItem(npc.getRect(), ItemID.AdhesiveBandage, 1);
            }
            if (npc.type == NPCID.PirateCaptain)
            {
                if (Main.rand.Next(10) == 0 && Main.hardMode)
                    Item.NewItem(npc.getRect(), ItemID.TrifoldMap, 1);
            }
            if (npc.type == NPCID.BloodCrawler)
            {
                if (Main.rand.Next(1) == 0)
                    Item.NewItem(npc.getRect(), ItemType < New.CrawlerFang>(), 1);
            }
            if (npc.type == NPCID.FloatyGross)
            {
                    Item.NewItem(npc.getRect(), ItemID.Ichor, 1);
            }
        }
        public override void OnHitPlayer(NPC npc, Player target, int damage, bool crit)
        {
            if (npc.type == NPCID.FloatyGross)
            {
                target.AddBuff(BuffID.Ichor, 900, true);
            }
        }
    }
}