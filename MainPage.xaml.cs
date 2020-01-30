using App1.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
	// Learn more about making custom code visible in the Xamarin.Forms previewer
	// by visiting https://aka.ms/xamarinforms-previewer
	[DesignTimeVisible(false)]
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

			List<Game> lGames = new List<Game>();
			lGames.Add(new Game{ Id=0 ,Name="League of Legends", Category="MOBA", ImageUrl="league.png" });
			lGames.Add(new Game{ Id=1 ,Name="Madden 2020", Category="Sports", ImageUrl= "madden.png" });
			lGames.Add(new Game{ Id=2 ,Name="Starcraft 2", Category="RTS", ImageUrl= "sc2.png" });
			lGames.Add(new Game{ Id=3 ,Name="Rocket League", Category="Cars", ImageUrl= "rocket_league.png" });
			lGames.Add(new Game{ Id=4 ,Name="Overwatch", Category="FPS", ImageUrl= "overwatch.png" });

			lvGames.ItemsSource = lGames;
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();

			List<Game> lGames = new List<Game>();
			lGames.Add(new Game { Id = 0, Name = "League of Legends", Category = "MOBA", ImageUrl = "league.png" });
			lGames.Add(new Game { Id = 1, Name = "Madden 2020", Category = "Sports", ImageUrl = "madden.png" });
			lGames.Add(new Game { Id = 2, Name = "Starcraft 2", Category = "RTS", ImageUrl = "sc2.png" });
			lGames.Add(new Game { Id = 3, Name = "Rocket League", Category = "Cars", ImageUrl = "rocket_league.png" });
			lGames.Add(new Game { Id = 4, Name = "Overwatch", Category = "FPS", ImageUrl = "overwatch.png" });

			lvGames.ItemsSource = lGames;
		}

		}
	}
