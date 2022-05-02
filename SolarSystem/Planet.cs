using System;
using System.Collections.Generic;
using System.Text;

namespace SolarSystem {
	class Planet : SpaceObject  {
		public Planet(string name, double size, double velocity, double tempature, PlanetType planettype) : base(name,size,velocity,tempature) {
			TypeofPlanet = planettype;
		}
		public enum PlanetType {
			GasGiant,
			Terrestrial,
			DwarfPlanet,
			SuperEarth
		}
		public PlanetType TypeofPlanet { get; set; }
	}
}
