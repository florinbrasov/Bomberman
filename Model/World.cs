using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Bomberman.Model
{
    class World
    {
        private WorldCell[][] cell;
        public Size size { get; set; }//TODO de ce e de tip point? Nu trb sa fie un integer?
        public void LoadGame(Uri filePath)
        {
            
            //TODO: Implement LoadGame
        }
    }
}
