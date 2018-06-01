using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

using ListView1.Models;


namespace ListView1
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            //var names = new List<string>
            //{ "Jaime", "Steph", "Sophie", "Denise", "Caroline" };
            //myListView.ItemsSource = names;

            myListView.ItemsSource = new List<Contact>
            {
                //new Contact {Name="Jaime", ImageUrl= "http://lorempixel.com/100/100/people/1", Status="sure!"},
                new Contact {Name="Jaime", ImageUrl= "https://placeimg.com/100/100/tech/any", Status="sure!"},
                new Contact {Name="Steph", ImageUrl= "https://placeimg.com/100/100/people/2", Status="not sure..."},
                new Contact {Name="Sophie", ImageUrl= "https://placeimg.com/100/100/people/3", Status="so happy"},
                new Contact {Name="Denise", ImageUrl= "https://placeimg.com/100/100/people/4", Status="resentful"},
                new Contact {Name="Caroline", ImageUrl= "https://placeimg.com/100/100/people/5", Status="am i alive?"}
            };
        }
	}
}
