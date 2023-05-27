using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Actor
{
    [Serializable]
    public class ActorStats
    {
        public float Weight;
        public float MoveSpeed;
        public float JumpHeight;
        public int JumpCount;
    }
}
