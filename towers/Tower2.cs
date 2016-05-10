﻿using System.Drawing;
using tower_defense_domain.bullets;

namespace tower_defense_domain.towers
{
    class Tower2 : AbstractTower
    {
        Tower2(Point location, int range, int atackSpeed)
            : base(location, range, atackSpeed)
        { }

        protected override IBullet createBullet(IEnemy enemy)
        {
            return new Bullet2(enemy, location, 4);
        }
    }
}