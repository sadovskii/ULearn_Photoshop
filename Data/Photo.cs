using System;
using System.Runtime.CompilerServices;
using MyPhotoshop.Data;

namespace MyPhotoshop
{
	public class Photo
    {
        public readonly int width;
        public readonly int height;
        private readonly Pixel[,] data;

        public Photo(int width, int height)
        {
            this.width = width;
            this.height = height;
            data = new Pixel[width, height];
        }

        public Pixel this[int width, int height]
        {
            get { return data[width, height]; }
            set { data[width, height] = value; }
        }
	}
}

