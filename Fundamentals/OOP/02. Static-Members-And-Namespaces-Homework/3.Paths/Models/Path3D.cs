﻿namespace _3.Paths.Models
{
    using _1.Point3D;
    using System.Collections.Generic;
    public class Path3D
    {
        public Path3D(params Point3D[] points) : this()
        {
            this.Path = new List<Point3D>();
            this.AddPoints(points);
        }

        private Path3D()
        {
        }

        public List<Point3D> Path { get; set; }

        private void AddPoints(params Point3D[] points)
        {
            foreach (var point3D in points)
            {
                this.Path.Add(point3D);
            }
        }

    }
}
