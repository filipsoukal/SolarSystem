using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SolarSystem {
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PlanetsPage : ContentPage {
		public static ObservableCollection<SpaceObject> PlanetList;
		//public static ObservableCollection<SpaceObject> SpaceObjectList {
		//	get { return spaceobjectlist; }
		//	set { spaceobjectlist = value; }
		//} 
		public PlanetsPage() {
			InitializeComponent();
			this.BindingContext = this;
			PlanetList = new ObservableCollection<SpaceObject>();
			PlanetList.Add(new SpaceObject("Earth", 5, 7, 6, SpaceObject.TypeOfObject.planet));
			PlanetList.Add(new SpaceObject("Mars", 9, 5, 4, SpaceObject.TypeOfObject.planet));
			PlanetList.Add(new SpaceObject("Mercury", 7, 3, 6, SpaceObject.TypeOfObject.planet));
			PlanetList.Add(new SpaceObject("Venus", 9, 2, 1, SpaceObject.TypeOfObject.planet));
			PlanetList.Add(new SpaceObject("Moon", 5, 7, 6, SpaceObject.TypeOfObject.planet));
			SpaceObjectsListView.ItemsSource = SpaceObjectList;
		}

		private void Button_Clicked(object sender, EventArgs e) {
			SpaceObjectList.Add(new SpaceObject("Earth", 5, 7, 6, SpaceObject.TypeOfObject.planet));
		}
		private void Delete_Clicked(object sender, EventArgs e) {
			SpaceObjectList.Remove(SpaceObjectList.LastOrDefault());
		}
		private void MenuItem_Delete(object sender, EventArgs e) {
			var mi = sender as MenuItem;
			SpaceObjectList.Remove((SpaceObject)mi.CommandParameter);
		}
		public SpaceObject SelectedSpaceObject { get; set; }
		private void PlanetTapped(object sender, ItemTappedEventArgs e)
        {
            //SelectedSpaceObject = ObjectsList.SelectedItem as SpaceObject;
			 DisplayAlert("Učitel", (SpaceObjectsListView.SelectedItem as SpaceObject).Name, "OK");
        }
	}
}