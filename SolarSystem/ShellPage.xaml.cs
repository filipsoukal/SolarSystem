﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SolarSystem {
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ShellPage : Shell {
		private ObservableCollection<SpaceObject> spaceonjectlist;
		public ShellPage() {
			InitializeComponent();
		}
	}
}