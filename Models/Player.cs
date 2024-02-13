﻿namespace Models
{
    public class Player
    {
        //----- parameters -----//
        public int CurrentHitPoints;
        public int CurrentLocation;
        public int CurrentWeapon;
        public int MaximumHitPoints;
        public int Name;

        //----- Constructor -----//
        public Player(int currentHitPoints, int currentLocation, int currentWeapon, int maximumHitPoints, int name)
        {
            this.CurrentHitPoints = currentHitPoints;
            this.CurrentLocation = currentLocation;
            this.CurrentWeapon = currentWeapon;
            this.MaximumHitPoints = maximumHitPoints;
            this.Name = name;
        }
    }
}