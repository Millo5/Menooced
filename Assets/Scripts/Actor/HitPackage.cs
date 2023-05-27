using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Actor
{
    public class HitPackage
    {
        public float damage { private set; get; }
        public Vector3 launchAngle { private set; get; }
        public float stunDuration { private set; get; }

        public HitPackage(float damage, Vector3 launchAngle, float stunDuration)
        {
            this.damage = damage;
            this.launchAngle = launchAngle;
            this.stunDuration = stunDuration;
        }

    }
}
