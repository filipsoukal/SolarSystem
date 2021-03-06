using System;
using System.Collections.Generic;
using System.Text;

namespace SolarSystem {
	public class SpaceObject {
		public SpaceObject(string name, double size, double velocity, double tempature, TypeOfObject objectType ) {
			Name = name;
			Size = size;
			Velocity = velocity;
			Tempature = tempature;
			ObjectType = objectType;
		}
		public string Name { get; set; }
		public double Size { get; set; }
		public double Velocity { get; set; }
		public double Tempature { get; set; }

		public enum TypeOfObject {
			planet,
			moon,
			star,
			asteroid
		}

		public TypeOfObject ObjectType { get; set; }
	}
}
