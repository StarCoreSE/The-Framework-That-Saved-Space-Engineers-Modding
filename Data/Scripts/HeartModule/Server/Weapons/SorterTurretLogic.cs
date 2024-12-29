﻿using Orrery.HeartModule.Shared.Definitions;
using Orrery.HeartModule.Shared.WeaponSettings;
using Sandbox.ModAPI;

namespace Orrery.HeartModule.Server.Weapons
{
    internal class SorterTurretLogic : SorterWeaponLogic
    {
        public new TurretSettings Settings
        {
            get
            {
                return (TurretSettings)base.Settings;
            }
            set
            {
                base.Settings = value;
            }
        }

        public SorterTurretLogic(IMyConveyorSorter sorterWep, WeaponDefinitionBase definition, uint id) : base(sorterWep, definition, id)
        {
            Settings = new TurretSettings();
        }
    }
}
