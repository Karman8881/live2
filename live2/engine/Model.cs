using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace live2.engine
{
    internal class Model
    {
        public int heigh { get { return height; } set { height = value; } }
        public int widt { get { return width; } set { width = value; } }

        private static int height;
        private static int width;
        public int[,] a = new int[height, width];
        public int[,] b = new int[height, width];
    }

}
