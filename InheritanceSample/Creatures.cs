using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSample
{
    // Use a colon : for inheritance

    /// <summary>
    /// A base class to represent human and AI controlled characters.
    /// </summary>
    class Creature
    {
        public string Name { get; set; }
        public double Health { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Speed { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    class Player : Creature
    {
        public double Stamina { get; set; }
    }

    class Enemy : Creature
    {
        public int EnemyId { get; set; }
    }
}
