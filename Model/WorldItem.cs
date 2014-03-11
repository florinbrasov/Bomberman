using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace Bomberman.Model
{
    class WorldItem
    {
        public Point LocationOnCanvas { get; set; }
        public WorldCell LocationOnWorld { get; set; }
        public World World { get; set; }
        public abstract void Update()
        {
            //TODO: Implement
            //TODO: Poate fi bagata intr-o interfata IUpdate
        }
    }
}
