using System;
using System.Collections.Generic;
using System.Text;

namespace SolarSystem {
	public class Planet : SpaceObject  {
		public Planet(string name, double size, double velocity, double tempature,TypeOfObject objectType, PlanetType planettype) : base(name,size,velocity,tempature,objectType) {
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
