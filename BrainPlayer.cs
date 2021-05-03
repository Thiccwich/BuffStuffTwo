using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using Terraria;
using Terraria.GameContent.Dyes;
using Terraria.GameContent.UI;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.UI;

namespace Thicc
{
    public class BrainPlayer : ModPlayer
    {
        public bool Confuse;

        public override void ResetEffects()
        {
            Confuse = false;
        }
        public override void OnHitNPC(Item item, NPC target, int damage, float knockback, bool crit)
        {    
            if (Confuse == true)
            {
                if (damage >= Main.rand.Next(50))
                {
                    target.AddBuff(BuffID.Confused, 360);
                }
            }
        }
        public override void OnHitNPCWithProj(Projectile proj, NPC target, int damage, float knockback, bool crit)
        {
            if (Confuse == true)
            {
                if (damage >= Main.rand.Next(50))
                {
                    target.AddBuff(BuffID.Confused, 300);
                }
            }
        }
    }
}
            