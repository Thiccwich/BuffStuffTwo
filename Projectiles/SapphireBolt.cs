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
    public class SapphireBolt : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.SapphireBolt);			
            aiType = ProjectileID.SapphireBolt;
			projectile.penetrate = 2;
        }
    }
}
