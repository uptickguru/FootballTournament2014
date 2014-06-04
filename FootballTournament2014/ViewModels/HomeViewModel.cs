﻿using System;
using System.Collections.ObjectModel;
using FootballTournament2014.Common.Models;

namespace FootballTournament2014
{
    public class HomeViewModel : BaseViewModel
    {
        public ObservableCollection<MenuItem> MenuItems { get; set; }
        public HomeViewModel ()
        {
            CanLoadMore = true;
            Title = "Tournament 2014";
            MenuItems = new ObservableCollection<MenuItem> ();
            MenuItems.Add (new MenuItem {
                Id = 0, Title = "News", MenuType = MenuType.News
            });
            MenuItems.Add(new MenuItem
            {
                Id = 1, Title = "Teams", MenuType = MenuType.Teams
            });
            MenuItems.Add(new MenuItem
            {
                Id = 2, Title = "Group Stage", MenuType = MenuType.Groups
            });
            MenuItems.Add(new MenuItem
            {
                Id = 3, Title = "Knockout Stage", MenuType = MenuType.Groups
            });
            MenuItems.Add(new MenuItem
            {
                Id = 4, Title = "Map", MenuType = MenuType.Map
            });
            MenuItems.Add(new MenuItem
            {
                Id = 5, Title = "About", MenuType = MenuType.About, Icon = "about.png"
            });
        }

    }
}
