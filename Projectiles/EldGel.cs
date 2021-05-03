using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.Enums;

namespace Thicc.Projectiles
{
    public class EldGel : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Eldy flames");
        }

        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.Flames);
            projectile.penetrate = 6;
        }
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            target.immune[projectile.owner] = 6;
        }
    }
}
