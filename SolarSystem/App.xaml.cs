﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SolarSystem {
	public partial class App : Application {
		public App() {
			InitializeComponent();

			MainPage = new PlanetsPage();
		}

		protected override void OnStart() {
		}

		protected override void OnSleep() {
		}

		protected override void OnResume() {
		}
	}
}
