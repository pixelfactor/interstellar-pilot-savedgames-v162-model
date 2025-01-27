﻿using System.Collections.Generic;

namespace Pixelfactor.IP.SavedGames.V162.Model
{
    /// <summary>
    /// This helper map is populated for ships only
    /// </summary>
    public static class ComponentBayMap
    {
        public static Dictionary<UnitClass, List<ComponentBay>> UnitClassComponentBays { get; } = new Dictionary<UnitClass, List<ComponentBay>>();

        static ComponentBayMap()
        {
            // Ares
            AddBay((UnitClass)50, new ComponentBay { Id = 1, Type = (ComponentBayType)100, Name = "Capacitor" });
            AddBay((UnitClass)50, new ComponentBay { Id = 2, Type = (ComponentBayType)300, Name = "Countermeasure" });
            AddBay((UnitClass)50, new ComponentBay { Id = 3, Type = (ComponentBayType)500, Name = "Engine Bay" });
            AddBay((UnitClass)50, new ComponentBay { Id = 4, Type = (ComponentBayType)1300, Name = "Front Left Turret" });
            AddBay((UnitClass)50, new ComponentBay { Id = 5, Type = (ComponentBayType)1300, Name = "Rear Turret" });
            AddBay((UnitClass)50, new ComponentBay { Id = 6, Type = (ComponentBayType)1300, Name = "Mid Turret" });
            AddBay((UnitClass)50, new ComponentBay { Id = 7, Type = (ComponentBayType)1300, Name = "Front Right Turret" });
            AddBay((UnitClass)50, new ComponentBay { Id = 8, Type = (ComponentBayType)1300, Name = "Top Turret" });
            AddBay((UnitClass)50, new ComponentBay { Id = 9, Type = (ComponentBayType)1000, Name = "Power Generator" });
            AddBay((UnitClass)50, new ComponentBay { Id = 10, Type = (ComponentBayType)1100, Name = "Shield" });
            AddBay((UnitClass)50, new ComponentBay { Id = 11, Type = (ComponentBayType)1200, Name = "Tractor Beam" });
            AddBay((UnitClass)50, new ComponentBay { Id = 100, Type = (ComponentBayType)900, Name = "Passenger Module" });
            // AresA
            AddBay((UnitClass)0, new ComponentBay { Id = 1, Type = (ComponentBayType)100, Name = "Capacitor" });
            AddBay((UnitClass)0, new ComponentBay { Id = 2, Type = (ComponentBayType)300, Name = "Countermeasure" });
            AddBay((UnitClass)0, new ComponentBay { Id = 3, Type = (ComponentBayType)500, Name = "Engine Bay" });
            AddBay((UnitClass)0, new ComponentBay { Id = 4, Type = (ComponentBayType)1300, Name = "Front Left Turret" });
            AddBay((UnitClass)0, new ComponentBay { Id = 5, Type = (ComponentBayType)1300, Name = "Rear Turret" });
            AddBay((UnitClass)0, new ComponentBay { Id = 6, Type = (ComponentBayType)1300, Name = "Mid Turret" });
            AddBay((UnitClass)0, new ComponentBay { Id = 7, Type = (ComponentBayType)1300, Name = "Front Right Turret" });
            AddBay((UnitClass)0, new ComponentBay { Id = 8, Type = (ComponentBayType)1300, Name = "Top Turret" });
            AddBay((UnitClass)0, new ComponentBay { Id = 9, Type = (ComponentBayType)1000, Name = "Power Generator" });
            AddBay((UnitClass)0, new ComponentBay { Id = 10, Type = (ComponentBayType)1100, Name = "Shield" });
            AddBay((UnitClass)0, new ComponentBay { Id = 11, Type = (ComponentBayType)1200, Name = "Tractor Beam" });
            AddBay((UnitClass)0, new ComponentBay { Id = 100, Type = (ComponentBayType)900, Name = "Passenger Module" });
            // AresX
            AddBay((UnitClass)100, new ComponentBay { Id = 12, Type = (ComponentBayType)400, Name = "Electronics" });
            AddBay((UnitClass)100, new ComponentBay { Id = 1, Type = (ComponentBayType)100, Name = "Capacitor" });
            AddBay((UnitClass)100, new ComponentBay { Id = 2, Type = (ComponentBayType)300, Name = "Countermeasure" });
            AddBay((UnitClass)100, new ComponentBay { Id = 3, Type = (ComponentBayType)500, Name = "Engine Bay" });
            AddBay((UnitClass)100, new ComponentBay { Id = 4, Type = (ComponentBayType)1300, Name = "Front Left Turret" });
            AddBay((UnitClass)100, new ComponentBay { Id = 5, Type = (ComponentBayType)1300, Name = "Rear Turret" });
            AddBay((UnitClass)100, new ComponentBay { Id = 6, Type = (ComponentBayType)1300, Name = "Mid Turret" });
            AddBay((UnitClass)100, new ComponentBay { Id = 7, Type = (ComponentBayType)1300, Name = "Front Right Turret" });
            AddBay((UnitClass)100, new ComponentBay { Id = 8, Type = (ComponentBayType)1300, Name = "Top Turret" });
            AddBay((UnitClass)100, new ComponentBay { Id = 9, Type = (ComponentBayType)1000, Name = "Power Generator" });
            AddBay((UnitClass)100, new ComponentBay { Id = 10, Type = (ComponentBayType)1100, Name = "Shield" });
            AddBay((UnitClass)100, new ComponentBay { Id = 11, Type = (ComponentBayType)1200, Name = "Tractor Beam" });
            AddBay((UnitClass)100, new ComponentBay { Id = 100, Type = (ComponentBayType)900, Name = "Passenger Module" });
            // Creon
            AddBay((UnitClass)8001, new ComponentBay { Id = 1, Type = (ComponentBayType)100, Name = "Capacitor" });
            AddBay((UnitClass)8001, new ComponentBay { Id = 2, Type = (ComponentBayType)500, Name = "Engine Bay" });
            AddBay((UnitClass)8001, new ComponentBay { Id = 3, Type = (ComponentBayType)1300, Name = "Front Right Turret" });
            AddBay((UnitClass)8001, new ComponentBay { Id = 4, Type = (ComponentBayType)1300, Name = "Front Left Turret" });
            AddBay((UnitClass)8001, new ComponentBay { Id = 5, Type = (ComponentBayType)1300, Name = "Rear Lower Turret" });
            AddBay((UnitClass)8001, new ComponentBay { Id = 6, Type = (ComponentBayType)1300, Name = "Top Turret" });
            AddBay((UnitClass)8001, new ComponentBay { Id = 7, Type = (ComponentBayType)1000, Name = "Power Generator" });
            AddBay((UnitClass)8001, new ComponentBay { Id = 8, Type = (ComponentBayType)1300, Name = "Rear Upper Turret" });
            AddBay((UnitClass)8001, new ComponentBay { Id = 9, Type = (ComponentBayType)1100, Name = "Shield" });
            AddBay((UnitClass)8001, new ComponentBay { Id = 10, Type = (ComponentBayType)1200, Name = "Tractor Beam" });
            AddBay((UnitClass)8001, new ComponentBay { Id = 100, Type = (ComponentBayType)900, Name = "Passenger Module " });
            // CreonML
            AddBay((UnitClass)9000, new ComponentBay { Id = 100, Type = (ComponentBayType)900, Name = "Passenger Module" });
            AddBay((UnitClass)9000, new ComponentBay { Id = 1, Type = (ComponentBayType)100, Name = "Capacitor" });
            AddBay((UnitClass)9000, new ComponentBay { Id = 2, Type = (ComponentBayType)500, Name = "Engine" });
            AddBay((UnitClass)9000, new ComponentBay { Id = 3, Type = (ComponentBayType)1300, Name = "Front Right Turret" });
            AddBay((UnitClass)9000, new ComponentBay { Id = 4, Type = (ComponentBayType)1300, Name = "Front Left Turret" });
            AddBay((UnitClass)9000, new ComponentBay { Id = 5, Type = (ComponentBayType)1300, Name = "Top Turret" });
            AddBay((UnitClass)9000, new ComponentBay { Id = 6, Type = (ComponentBayType)1000, Name = "Power Generator" });
            AddBay((UnitClass)9000, new ComponentBay { Id = 7, Type = (ComponentBayType)1300, Name = "Rear Lower Turret" });
            AddBay((UnitClass)9000, new ComponentBay { Id = 8, Type = (ComponentBayType)1300, Name = "Rear Upper Turret" });
            AddBay((UnitClass)9000, new ComponentBay { Id = 9, Type = (ComponentBayType)1100, Name = "Shield" });
            AddBay((UnitClass)9000, new ComponentBay { Id = 10, Type = (ComponentBayType)1200, Name = "Tractor Beam" });
            // CreonA
            AddBay((UnitClass)8000, new ComponentBay { Id = 1, Type = (ComponentBayType)100, Name = "Capacitor" });
            AddBay((UnitClass)8000, new ComponentBay { Id = 2, Type = (ComponentBayType)500, Name = "Engine Bay" });
            AddBay((UnitClass)8000, new ComponentBay { Id = 3, Type = (ComponentBayType)1300, Name = "Front Right Turret" });
            AddBay((UnitClass)8000, new ComponentBay { Id = 4, Type = (ComponentBayType)1300, Name = "Front Left Turret" });
            AddBay((UnitClass)8000, new ComponentBay { Id = 5, Type = (ComponentBayType)1300, Name = "Rear Lower Turret" });
            AddBay((UnitClass)8000, new ComponentBay { Id = 6, Type = (ComponentBayType)1300, Name = "Top Turret" });
            AddBay((UnitClass)8000, new ComponentBay { Id = 7, Type = (ComponentBayType)1000, Name = "Power Generator" });
            AddBay((UnitClass)8000, new ComponentBay { Id = 8, Type = (ComponentBayType)1300, Name = "Rear Upper Turret" });
            AddBay((UnitClass)8000, new ComponentBay { Id = 9, Type = (ComponentBayType)1100, Name = "Shield" });
            AddBay((UnitClass)8000, new ComponentBay { Id = 10, Type = (ComponentBayType)1200, Name = "Tractor Beam" });
            AddBay((UnitClass)8000, new ComponentBay { Id = 100, Type = (ComponentBayType)900, Name = "Passenger Module " });
            // Drake
            AddBay((UnitClass)38000, new ComponentBay { Id = 1, Type = (ComponentBayType)100, Name = "Capacitor" });
            AddBay((UnitClass)38000, new ComponentBay { Id = 2, Type = (ComponentBayType)500, Name = "Engine Bay" });
            AddBay((UnitClass)38000, new ComponentBay { Id = 3, Type = (ComponentBayType)300, Name = "Countermeasure Bay" });
            AddBay((UnitClass)38000, new ComponentBay { Id = 4, Type = (ComponentBayType)1300, Name = "Left Turret" });
            AddBay((UnitClass)38000, new ComponentBay { Id = 5, Type = (ComponentBayType)1300, Name = "Main Turret" });
            AddBay((UnitClass)38000, new ComponentBay { Id = 6, Type = (ComponentBayType)1300, Name = "Right Turret" });
            AddBay((UnitClass)38000, new ComponentBay { Id = 7, Type = (ComponentBayType)1000, Name = "Power Generator" });
            AddBay((UnitClass)38000, new ComponentBay { Id = 8, Type = (ComponentBayType)1300, Name = "Rear Turret" });
            AddBay((UnitClass)38000, new ComponentBay { Id = 9, Type = (ComponentBayType)1100, Name = "Shield Bay" });
            AddBay((UnitClass)38000, new ComponentBay { Id = 10, Type = (ComponentBayType)1300, Name = "Top Turret" });
            AddBay((UnitClass)38000, new ComponentBay { Id = 11, Type = (ComponentBayType)1200, Name = "Tractor Beam" });
            AddBay((UnitClass)38000, new ComponentBay { Id = 12, Type = (ComponentBayType)400, Name = "Electronics" });
            // DrakeA
            AddBay((UnitClass)39000, new ComponentBay { Id = 1, Type = (ComponentBayType)100, Name = "Capacitor" });
            AddBay((UnitClass)39000, new ComponentBay { Id = 2, Type = (ComponentBayType)500, Name = "Engine Bay" });
            AddBay((UnitClass)39000, new ComponentBay { Id = 3, Type = (ComponentBayType)300, Name = "Countermeasure Bay" });
            AddBay((UnitClass)39000, new ComponentBay { Id = 4, Type = (ComponentBayType)1300, Name = "Left Turret" });
            AddBay((UnitClass)39000, new ComponentBay { Id = 5, Type = (ComponentBayType)1300, Name = "Main Turret" });
            AddBay((UnitClass)39000, new ComponentBay { Id = 6, Type = (ComponentBayType)1300, Name = "Top Turret" });
            AddBay((UnitClass)39000, new ComponentBay { Id = 7, Type = (ComponentBayType)1300, Name = "Right Turret" });
            AddBay((UnitClass)39000, new ComponentBay { Id = 8, Type = (ComponentBayType)1000, Name = "Power Generator" });
            AddBay((UnitClass)39000, new ComponentBay { Id = 9, Type = (ComponentBayType)1300, Name = "Rear Turret" });
            AddBay((UnitClass)39000, new ComponentBay { Id = 10, Type = (ComponentBayType)1100, Name = "Shield Bay" });
            AddBay((UnitClass)39000, new ComponentBay { Id = 11, Type = (ComponentBayType)1200, Name = "Tractor Beam" });
            AddBay((UnitClass)39000, new ComponentBay { Id = 12, Type = (ComponentBayType)400, Name = "Electronics" });
            // Flyer
            AddBay((UnitClass)11000, new ComponentBay { Id = 1, Type = (ComponentBayType)100, Name = "Capacitor" });
            AddBay((UnitClass)11000, new ComponentBay { Id = 2, Type = (ComponentBayType)300, Name = "Countermeasure" });
            AddBay((UnitClass)11000, new ComponentBay { Id = 3, Type = (ComponentBayType)500, Name = "Engine" });
            AddBay((UnitClass)11000, new ComponentBay { Id = 4, Type = (ComponentBayType)1300, Name = "Left Turret" });
            AddBay((UnitClass)11000, new ComponentBay { Id = 5, Type = (ComponentBayType)1300, Name = "Mid Turret" });
            AddBay((UnitClass)11000, new ComponentBay { Id = 6, Type = (ComponentBayType)700, Name = "Mine" });
            AddBay((UnitClass)11000, new ComponentBay { Id = 7, Type = (ComponentBayType)1000, Name = "Power Generator" });
            AddBay((UnitClass)11000, new ComponentBay { Id = 8, Type = (ComponentBayType)1300, Name = "Top Turret" });
            AddBay((UnitClass)11000, new ComponentBay { Id = 9, Type = (ComponentBayType)1300, Name = "Right Turret" });
            AddBay((UnitClass)11000, new ComponentBay { Id = 10, Type = (ComponentBayType)1100, Name = "Shield" });
            AddBay((UnitClass)11000, new ComponentBay { Id = 11, Type = (ComponentBayType)1200, Name = "Tractor Beam" });
            AddBay((UnitClass)11000, new ComponentBay { Id = 12, Type = (ComponentBayType)400, Name = "Electronics" });
            // FlyerA
            AddBay((UnitClass)12000, new ComponentBay { Id = 1, Type = (ComponentBayType)100, Name = "Capacitor" });
            AddBay((UnitClass)12000, new ComponentBay { Id = 2, Type = (ComponentBayType)300, Name = "Countermeasure" });
            AddBay((UnitClass)12000, new ComponentBay { Id = 3, Type = (ComponentBayType)500, Name = "Engine" });
            AddBay((UnitClass)12000, new ComponentBay { Id = 4, Type = (ComponentBayType)1300, Name = "Left Turret" });
            AddBay((UnitClass)12000, new ComponentBay { Id = 5, Type = (ComponentBayType)1300, Name = "Mid Turret" });
            AddBay((UnitClass)12000, new ComponentBay { Id = 6, Type = (ComponentBayType)700, Name = "Mine" });
            AddBay((UnitClass)12000, new ComponentBay { Id = 7, Type = (ComponentBayType)1000, Name = "Power Generator" });
            AddBay((UnitClass)12000, new ComponentBay { Id = 8, Type = (ComponentBayType)1300, Name = "Top Turret" });
            AddBay((UnitClass)12000, new ComponentBay { Id = 9, Type = (ComponentBayType)1300, Name = "Right Turret" });
            AddBay((UnitClass)12000, new ComponentBay { Id = 10, Type = (ComponentBayType)1100, Name = "Shield" });
            AddBay((UnitClass)12000, new ComponentBay { Id = 11, Type = (ComponentBayType)1200, Name = "Tractor Beam" });
            AddBay((UnitClass)12000, new ComponentBay { Id = 12, Type = (ComponentBayType)400, Name = "Electronics" });
            // FlyerX
            AddBay((UnitClass)13000, new ComponentBay { Id = 1, Type = (ComponentBayType)100, Name = "Capacitor" });
            AddBay((UnitClass)13000, new ComponentBay { Id = 2, Type = (ComponentBayType)500, Name = "Engine" });
            AddBay((UnitClass)13000, new ComponentBay { Id = 3, Type = (ComponentBayType)1300, Name = "Left Turret" });
            AddBay((UnitClass)13000, new ComponentBay { Id = 4, Type = (ComponentBayType)300, Name = "Countermeasure" });
            AddBay((UnitClass)13000, new ComponentBay { Id = 5, Type = (ComponentBayType)1300, Name = "Right Turret" });
            AddBay((UnitClass)13000, new ComponentBay { Id = 6, Type = (ComponentBayType)700, Name = "Mine Bay" });
            AddBay((UnitClass)13000, new ComponentBay { Id = 7, Type = (ComponentBayType)1000, Name = "Power Generator" });
            AddBay((UnitClass)13000, new ComponentBay { Id = 8, Type = (ComponentBayType)1300, Name = "Top Turret" });
            AddBay((UnitClass)13000, new ComponentBay { Id = 9, Type = (ComponentBayType)1300, Name = "Mid Turret" });
            AddBay((UnitClass)13000, new ComponentBay { Id = 10, Type = (ComponentBayType)1100, Name = "Shield Bay" });
            AddBay((UnitClass)13000, new ComponentBay { Id = 11, Type = (ComponentBayType)1200, Name = "Tractor Beam" });
            AddBay((UnitClass)13000, new ComponentBay { Id = 12, Type = (ComponentBayType)400, Name = "Electronics" });
            // Hauler
            AddBay((UnitClass)15010, new ComponentBay { Id = 1, Type = (ComponentBayType)100, Name = "Capacitor" });
            AddBay((UnitClass)15010, new ComponentBay { Id = 2, Type = (ComponentBayType)500, Name = "Engine Bay" });
            AddBay((UnitClass)15010, new ComponentBay { Id = 3, Type = (ComponentBayType)1300, Name = "Front Turret" });
            AddBay((UnitClass)15010, new ComponentBay { Id = 4, Type = (ComponentBayType)300, Name = "Countermeasure Bay" });
            AddBay((UnitClass)15010, new ComponentBay { Id = 5, Type = (ComponentBayType)1300, Name = "Top Turret" });
            AddBay((UnitClass)15010, new ComponentBay { Id = 6, Type = (ComponentBayType)1300, Name = "Rear Turret" });
            AddBay((UnitClass)15010, new ComponentBay { Id = 7, Type = (ComponentBayType)1300, Name = "Mid Turret" });
            AddBay((UnitClass)15010, new ComponentBay { Id = 8, Type = (ComponentBayType)700, Name = "Mine Bay" });
            AddBay((UnitClass)15010, new ComponentBay { Id = 9, Type = (ComponentBayType)1000, Name = "Power Generator" });
            AddBay((UnitClass)15010, new ComponentBay { Id = 10, Type = (ComponentBayType)1100, Name = "Shield Bay" });
            AddBay((UnitClass)15010, new ComponentBay { Id = 11, Type = (ComponentBayType)1200, Name = "Tractor Beam" });
            AddBay((UnitClass)15010, new ComponentBay { Id = 12, Type = (ComponentBayType)400, Name = "Electronics Bay" });
            AddBay((UnitClass)15010, new ComponentBay { Id = 100, Type = (ComponentBayType)900, Name = "Passenger Module" });
            // HaulerP
            AddBay((UnitClass)14000, new ComponentBay { Id = 1, Type = (ComponentBayType)100, Name = "Capacitor" });
            AddBay((UnitClass)14000, new ComponentBay { Id = 2, Type = (ComponentBayType)500, Name = "Engine Bay" });
            AddBay((UnitClass)14000, new ComponentBay { Id = 3, Type = (ComponentBayType)1300, Name = "Front Turret" });
            AddBay((UnitClass)14000, new ComponentBay { Id = 4, Type = (ComponentBayType)300, Name = "Countermeasure Bay" });
            AddBay((UnitClass)14000, new ComponentBay { Id = 5, Type = (ComponentBayType)1300, Name = "Top Turret" });
            AddBay((UnitClass)14000, new ComponentBay { Id = 6, Type = (ComponentBayType)1300, Name = "Rear Turret" });
            AddBay((UnitClass)14000, new ComponentBay { Id = 7, Type = (ComponentBayType)1300, Name = "Mid Turret" });
            AddBay((UnitClass)14000, new ComponentBay { Id = 8, Type = (ComponentBayType)700, Name = "Mine Bay" });
            AddBay((UnitClass)14000, new ComponentBay { Id = 9, Type = (ComponentBayType)1000, Name = "Power Generator" });
            AddBay((UnitClass)14000, new ComponentBay { Id = 10, Type = (ComponentBayType)1100, Name = "Shield Bay" });
            AddBay((UnitClass)14000, new ComponentBay { Id = 11, Type = (ComponentBayType)1200, Name = "Tractor Beam" });
            AddBay((UnitClass)14000, new ComponentBay { Id = 12, Type = (ComponentBayType)400, Name = "Electronics Bay" });
            AddBay((UnitClass)14000, new ComponentBay { Id = 100, Type = (ComponentBayType)900, Name = "Passenger Module" });
            // HaulerA
            AddBay((UnitClass)15000, new ComponentBay { Id = 1, Type = (ComponentBayType)100, Name = "Capacitor" });
            AddBay((UnitClass)15000, new ComponentBay { Id = 2, Type = (ComponentBayType)500, Name = "Engine Bay" });
            AddBay((UnitClass)15000, new ComponentBay { Id = 3, Type = (ComponentBayType)1300, Name = "Front Turret" });
            AddBay((UnitClass)15000, new ComponentBay { Id = 4, Type = (ComponentBayType)300, Name = "Countermeasure Bay" });
            AddBay((UnitClass)15000, new ComponentBay { Id = 5, Type = (ComponentBayType)1300, Name = "Top Turret" });
            AddBay((UnitClass)15000, new ComponentBay { Id = 6, Type = (ComponentBayType)1300, Name = "Rear Turret" });
            AddBay((UnitClass)15000, new ComponentBay { Id = 7, Type = (ComponentBayType)1300, Name = "Mid Turret" });
            AddBay((UnitClass)15000, new ComponentBay { Id = 8, Type = (ComponentBayType)700, Name = "Mine Bay" });
            AddBay((UnitClass)15000, new ComponentBay { Id = 9, Type = (ComponentBayType)1000, Name = "Power Generator" });
            AddBay((UnitClass)15000, new ComponentBay { Id = 10, Type = (ComponentBayType)1100, Name = "Shield Bay" });
            AddBay((UnitClass)15000, new ComponentBay { Id = 11, Type = (ComponentBayType)1200, Name = "Tractor Beam" });
            AddBay((UnitClass)15000, new ComponentBay { Id = 12, Type = (ComponentBayType)400, Name = "Electronics Bay" });
            AddBay((UnitClass)15000, new ComponentBay { Id = 100, Type = (ComponentBayType)900, Name = "Passenger Module" });
            // HaulerH
            AddBay((UnitClass)15100, new ComponentBay { Id = 1, Type = (ComponentBayType)100, Name = "Capacitor" });
            AddBay((UnitClass)15100, new ComponentBay { Id = 2, Type = (ComponentBayType)500, Name = "Engine Bay" });
            AddBay((UnitClass)15100, new ComponentBay { Id = 3, Type = (ComponentBayType)1300, Name = "Front Turret" });
            AddBay((UnitClass)15100, new ComponentBay { Id = 4, Type = (ComponentBayType)300, Name = "Countermeasure Bay" });
            AddBay((UnitClass)15100, new ComponentBay { Id = 5, Type = (ComponentBayType)1300, Name = "Top Turret" });
            AddBay((UnitClass)15100, new ComponentBay { Id = 7, Type = (ComponentBayType)1300, Name = "Mid Turret" });
            AddBay((UnitClass)15100, new ComponentBay { Id = 8, Type = (ComponentBayType)700, Name = "Mine Bay" });
            AddBay((UnitClass)15100, new ComponentBay { Id = 9, Type = (ComponentBayType)1000, Name = "Power Generator" });
            AddBay((UnitClass)15100, new ComponentBay { Id = 10, Type = (ComponentBayType)1100, Name = "Shield Bay" });
            AddBay((UnitClass)15100, new ComponentBay { Id = 11, Type = (ComponentBayType)1200, Name = "Tractor Beam" });
            AddBay((UnitClass)15100, new ComponentBay { Id = 12, Type = (ComponentBayType)400, Name = "Electronics Bay" });
            AddBay((UnitClass)15100, new ComponentBay { Id = 100, Type = (ComponentBayType)900, Name = "Passenger Module" });
            // HaulerM
            AddBay((UnitClass)16000, new ComponentBay { Id = 1, Type = (ComponentBayType)100, Name = "Capacitor" });
            AddBay((UnitClass)16000, new ComponentBay { Id = 2, Type = (ComponentBayType)300, Name = "Countermeasure Bay" });
            AddBay((UnitClass)16000, new ComponentBay { Id = 3, Type = (ComponentBayType)500, Name = "Engine Bay" });
            AddBay((UnitClass)16000, new ComponentBay { Id = 4, Type = (ComponentBayType)1400, Name = "Front Mining Turret" });
            AddBay((UnitClass)16000, new ComponentBay { Id = 5, Type = (ComponentBayType)1400, Name = "Mid Mining Turret" });
            AddBay((UnitClass)16000, new ComponentBay { Id = 6, Type = (ComponentBayType)1300, Name = "Mid Turret" });
            AddBay((UnitClass)16000, new ComponentBay { Id = 7, Type = (ComponentBayType)700, Name = "Mine Bay" });
            AddBay((UnitClass)16000, new ComponentBay { Id = 8, Type = (ComponentBayType)1000, Name = "Power Generator" });
            AddBay((UnitClass)16000, new ComponentBay { Id = 9, Type = (ComponentBayType)1300, Name = "Rear Turret" });
            AddBay((UnitClass)16000, new ComponentBay { Id = 10, Type = (ComponentBayType)1100, Name = "Shield Bay" });
            AddBay((UnitClass)16000, new ComponentBay { Id = 11, Type = (ComponentBayType)1200, Name = "Tractor Beam" });
            AddBay((UnitClass)16000, new ComponentBay { Id = 12, Type = (ComponentBayType)400, Name = "Electronics Bay" });
            // Hornet
            AddBay((UnitClass)40000, new ComponentBay { Id = 1, Type = (ComponentBayType)100, Name = "Capacitor" });
            AddBay((UnitClass)40000, new ComponentBay { Id = 2, Type = (ComponentBayType)500, Name = "Engine Bay" });
            AddBay((UnitClass)40000, new ComponentBay { Id = 3, Type = (ComponentBayType)300, Name = "Countermeasure Bay" });
            AddBay((UnitClass)40000, new ComponentBay { Id = 4, Type = (ComponentBayType)1300, Name = "Left Turret" });
            AddBay((UnitClass)40000, new ComponentBay { Id = 5, Type = (ComponentBayType)700, Name = "Mine" });
            AddBay((UnitClass)40000, new ComponentBay { Id = 6, Type = (ComponentBayType)1300, Name = "Right Turret" });
            AddBay((UnitClass)40000, new ComponentBay { Id = 7, Type = (ComponentBayType)1000, Name = "Power Generator" });
            AddBay((UnitClass)40000, new ComponentBay { Id = 8, Type = (ComponentBayType)1100, Name = "Shield Bay" });
            AddBay((UnitClass)40000, new ComponentBay { Id = 9, Type = (ComponentBayType)1300, Name = "Top Turret" });
            AddBay((UnitClass)40000, new ComponentBay { Id = 10, Type = (ComponentBayType)1200, Name = "Tractor Beam" });
            AddBay((UnitClass)40000, new ComponentBay { Id = 12, Type = (ComponentBayType)400, Name = "Electronics" });
            // HornetA
            AddBay((UnitClass)41000, new ComponentBay { Id = 12, Type = (ComponentBayType)400, Name = "Electronics" });
            AddBay((UnitClass)41000, new ComponentBay { Id = 1, Type = (ComponentBayType)100, Name = "Capacitor" });
            AddBay((UnitClass)41000, new ComponentBay { Id = 2, Type = (ComponentBayType)500, Name = "Engine Bay" });
            AddBay((UnitClass)41000, new ComponentBay { Id = 3, Type = (ComponentBayType)300, Name = "Countermeasure Bay" });
            AddBay((UnitClass)41000, new ComponentBay { Id = 4, Type = (ComponentBayType)1300, Name = "Left Turret" });
            AddBay((UnitClass)41000, new ComponentBay { Id = 5, Type = (ComponentBayType)700, Name = "Mine" });
            AddBay((UnitClass)41000, new ComponentBay { Id = 6, Type = (ComponentBayType)1300, Name = "Right Turret" });
            AddBay((UnitClass)41000, new ComponentBay { Id = 7, Type = (ComponentBayType)1000, Name = "Power Generator" });
            AddBay((UnitClass)41000, new ComponentBay { Id = 8, Type = (ComponentBayType)1300, Name = "Top Turret" });
            AddBay((UnitClass)41000, new ComponentBay { Id = 9, Type = (ComponentBayType)1100, Name = "Shield Bay" });
            AddBay((UnitClass)41000, new ComponentBay { Id = 10, Type = (ComponentBayType)1200, Name = "Tractor Beam" });
            // HornetX
            AddBay((UnitClass)41003, new ComponentBay { Id = 12, Type = (ComponentBayType)400, Name = "Electronics" });
            AddBay((UnitClass)41003, new ComponentBay { Id = 1, Type = (ComponentBayType)100, Name = "Capacitor" });
            AddBay((UnitClass)41003, new ComponentBay { Id = 2, Type = (ComponentBayType)500, Name = "Engine Bay" });
            AddBay((UnitClass)41003, new ComponentBay { Id = 3, Type = (ComponentBayType)300, Name = "Countermeasure Bay" });
            AddBay((UnitClass)41003, new ComponentBay { Id = 4, Type = (ComponentBayType)1300, Name = "Left Turret" });
            AddBay((UnitClass)41003, new ComponentBay { Id = 5, Type = (ComponentBayType)700, Name = "Mine" });
            AddBay((UnitClass)41003, new ComponentBay { Id = 6, Type = (ComponentBayType)1300, Name = "Right Turret" });
            AddBay((UnitClass)41003, new ComponentBay { Id = 7, Type = (ComponentBayType)1000, Name = "Power Generator" });
            AddBay((UnitClass)41003, new ComponentBay { Id = 8, Type = (ComponentBayType)1300, Name = "Top Turret" });
            AddBay((UnitClass)41003, new ComponentBay { Id = 9, Type = (ComponentBayType)1100, Name = "Shield Bay" });
            AddBay((UnitClass)41003, new ComponentBay { Id = 10, Type = (ComponentBayType)1200, Name = "Tractor Beam" });
            // Magnus
            AddBay((UnitClass)22010, new ComponentBay { Id = 1, Type = (ComponentBayType)100, Name = "Capacitor" });
            AddBay((UnitClass)22010, new ComponentBay { Id = 2, Type = (ComponentBayType)500, Name = "Engine Bay" });
            AddBay((UnitClass)22010, new ComponentBay { Id = 3, Type = (ComponentBayType)1300, Name = "Front Right Turret" });
            AddBay((UnitClass)22010, new ComponentBay { Id = 4, Type = (ComponentBayType)1300, Name = "Rear Turret" });
            AddBay((UnitClass)22010, new ComponentBay { Id = 5, Type = (ComponentBayType)1300, Name = "Main Turret" });
            AddBay((UnitClass)22010, new ComponentBay { Id = 6, Type = (ComponentBayType)1300, Name = "Front Left Turret" });
            AddBay((UnitClass)22010, new ComponentBay { Id = 7, Type = (ComponentBayType)1300, Name = "Front Turret" });
            AddBay((UnitClass)22010, new ComponentBay { Id = 8, Type = (ComponentBayType)1300, Name = "Top Turret" });
            AddBay((UnitClass)22010, new ComponentBay { Id = 9, Type = (ComponentBayType)1300, Name = "Rear Left Turret" });
            AddBay((UnitClass)22010, new ComponentBay { Id = 10, Type = (ComponentBayType)1000, Name = "Power Generator" });
            AddBay((UnitClass)22010, new ComponentBay { Id = 11, Type = (ComponentBayType)1300, Name = "Rear Right Turret" });
            AddBay((UnitClass)22010, new ComponentBay { Id = 12, Type = (ComponentBayType)1100, Name = "Shield Bay" });
            AddBay((UnitClass)22010, new ComponentBay { Id = 13, Type = (ComponentBayType)1200, Name = "Tractor Beam" });
            AddBay((UnitClass)22010, new ComponentBay { Id = 100, Type = (ComponentBayType)900, Name = "Passenger Module" });
            // MagnusA
            AddBay((UnitClass)22000, new ComponentBay { Id = 1, Type = (ComponentBayType)100, Name = "Capacitor" });
            AddBay((UnitClass)22000, new ComponentBay { Id = 2, Type = (ComponentBayType)500, Name = "Engine Bay" });
            AddBay((UnitClass)22000, new ComponentBay { Id = 3, Type = (ComponentBayType)1300, Name = "Front Right Turret" });
            AddBay((UnitClass)22000, new ComponentBay { Id = 4, Type = (ComponentBayType)1300, Name = "Rear Turret" });
            AddBay((UnitClass)22000, new ComponentBay { Id = 5, Type = (ComponentBayType)1300, Name = "Main Turret" });
            AddBay((UnitClass)22000, new ComponentBay { Id = 6, Type = (ComponentBayType)1300, Name = "Front Left Turret" });
            AddBay((UnitClass)22000, new ComponentBay { Id = 7, Type = (ComponentBayType)1300, Name = "Front Turret" });
            AddBay((UnitClass)22000, new ComponentBay { Id = 8, Type = (ComponentBayType)1300, Name = "Top Turret" });
            AddBay((UnitClass)22000, new ComponentBay { Id = 9, Type = (ComponentBayType)1300, Name = "Rear Left Turret" });
            AddBay((UnitClass)22000, new ComponentBay { Id = 10, Type = (ComponentBayType)1000, Name = "Power Generator" });
            AddBay((UnitClass)22000, new ComponentBay { Id = 11, Type = (ComponentBayType)1300, Name = "Rear Right Turret" });
            AddBay((UnitClass)22000, new ComponentBay { Id = 12, Type = (ComponentBayType)1100, Name = "Shield Bay" });
            AddBay((UnitClass)22000, new ComponentBay { Id = 13, Type = (ComponentBayType)1200, Name = "Tractor Beam" });
            AddBay((UnitClass)22000, new ComponentBay { Id = 100, Type = (ComponentBayType)900, Name = "Passenger Module" });
            // MagnusEQ
            AddBay((UnitClass)22050, new ComponentBay { Id = 1, Type = (ComponentBayType)100, Name = "Capacitor" });
            AddBay((UnitClass)22050, new ComponentBay { Id = 2, Type = (ComponentBayType)500, Name = "Engine Bay" });
            AddBay((UnitClass)22050, new ComponentBay { Id = 3, Type = (ComponentBayType)1300, Name = "Front Right Turret" });
            AddBay((UnitClass)22050, new ComponentBay { Id = 4, Type = (ComponentBayType)1300, Name = "Rear Turret" });
            AddBay((UnitClass)22050, new ComponentBay { Id = 6, Type = (ComponentBayType)1300, Name = "Front Left Turret" });
            AddBay((UnitClass)22050, new ComponentBay { Id = 7, Type = (ComponentBayType)1300, Name = "Front Turret" });
            AddBay((UnitClass)22050, new ComponentBay { Id = 8, Type = (ComponentBayType)1300, Name = "Top Turret" });
            AddBay((UnitClass)22050, new ComponentBay { Id = 9, Type = (ComponentBayType)1300, Name = "Rear Left Turret" });
            AddBay((UnitClass)22050, new ComponentBay { Id = 10, Type = (ComponentBayType)1000, Name = "Power Generator" });
            AddBay((UnitClass)22050, new ComponentBay { Id = 11, Type = (ComponentBayType)1300, Name = "Rear Right Turret" });
            AddBay((UnitClass)22050, new ComponentBay { Id = 12, Type = (ComponentBayType)1100, Name = "Shield Bay" });
            AddBay((UnitClass)22050, new ComponentBay { Id = 13, Type = (ComponentBayType)1200, Name = "Tractor Beam" });
            AddBay((UnitClass)22050, new ComponentBay { Id = 100, Type = (ComponentBayType)900, Name = "Passenger Module" });
            // MagnusX
            AddBay((UnitClass)22005, new ComponentBay { Id = 1, Type = (ComponentBayType)100, Name = "Capacitor" });
            AddBay((UnitClass)22005, new ComponentBay { Id = 2, Type = (ComponentBayType)500, Name = "Engine Bay" });
            AddBay((UnitClass)22005, new ComponentBay { Id = 3, Type = (ComponentBayType)1300, Name = "Front Right Turret" });
            AddBay((UnitClass)22005, new ComponentBay { Id = 5, Type = (ComponentBayType)1300, Name = "Main Turret" });
            AddBay((UnitClass)22005, new ComponentBay { Id = 6, Type = (ComponentBayType)1300, Name = "Front Left Turret" });
            AddBay((UnitClass)22005, new ComponentBay { Id = 7, Type = (ComponentBayType)1300, Name = "Front Turret" });
            AddBay((UnitClass)22005, new ComponentBay { Id = 8, Type = (ComponentBayType)1300, Name = "Top Turret" });
            AddBay((UnitClass)22005, new ComponentBay { Id = 9, Type = (ComponentBayType)1300, Name = "Rear Left Turret" });
            AddBay((UnitClass)22005, new ComponentBay { Id = 10, Type = (ComponentBayType)1000, Name = "Power Generator" });
            AddBay((UnitClass)22005, new ComponentBay { Id = 11, Type = (ComponentBayType)1300, Name = "Rear Right Turret" });
            AddBay((UnitClass)22005, new ComponentBay { Id = 12, Type = (ComponentBayType)1100, Name = "Shield Bay" });
            AddBay((UnitClass)22005, new ComponentBay { Id = 13, Type = (ComponentBayType)1200, Name = "Tractor Beam" });
            AddBay((UnitClass)22005, new ComponentBay { Id = 100, Type = (ComponentBayType)900, Name = "Passenger Module" });
            AddBay((UnitClass)22005, new ComponentBay { Id = 200, Type = (ComponentBayType)400, Name = "Electronics" });
            // Orion
            AddBay((UnitClass)55010, new ComponentBay { Id = 1, Type = (ComponentBayType)100, Name = "Capacitor" });
            AddBay((UnitClass)55010, new ComponentBay { Id = 2, Type = (ComponentBayType)300, Name = "Countermeasure" });
            AddBay((UnitClass)55010, new ComponentBay { Id = 3, Type = (ComponentBayType)500, Name = "Engine Bay" });
            AddBay((UnitClass)55010, new ComponentBay { Id = 4, Type = (ComponentBayType)1300, Name = "Front Left Turret" });
            AddBay((UnitClass)55010, new ComponentBay { Id = 5, Type = (ComponentBayType)1300, Name = "Rear Turret" });
            AddBay((UnitClass)55010, new ComponentBay { Id = 6, Type = (ComponentBayType)700, Name = "Mine Turret" });
            AddBay((UnitClass)55010, new ComponentBay { Id = 7, Type = (ComponentBayType)1300, Name = "Front Right Turret" });
            AddBay((UnitClass)55010, new ComponentBay { Id = 8, Type = (ComponentBayType)1300, Name = "Top Left Turret" });
            AddBay((UnitClass)55010, new ComponentBay { Id = 9, Type = (ComponentBayType)1000, Name = "Power Generator" });
            AddBay((UnitClass)55010, new ComponentBay { Id = 10, Type = (ComponentBayType)1100, Name = "Shield" });
            AddBay((UnitClass)55010, new ComponentBay { Id = 11, Type = (ComponentBayType)1200, Name = "Tractor Beam" });
            AddBay((UnitClass)55010, new ComponentBay { Id = 100, Type = (ComponentBayType)900, Name = "Passenger Module" });
            AddBay((UnitClass)55010, new ComponentBay { Id = 200, Type = (ComponentBayType)400, Name = "Electronics" });
            AddBay((UnitClass)55010, new ComponentBay { Id = 110, Type = (ComponentBayType)1300, Name = "Top Right Turret" });
            // OrionA
            AddBay((UnitClass)55000, new ComponentBay { Id = 1, Type = (ComponentBayType)100, Name = "Capacitor" });
            AddBay((UnitClass)55000, new ComponentBay { Id = 2, Type = (ComponentBayType)300, Name = "Countermeasure" });
            AddBay((UnitClass)55000, new ComponentBay { Id = 3, Type = (ComponentBayType)500, Name = "Engine Bay" });
            AddBay((UnitClass)55000, new ComponentBay { Id = 4, Type = (ComponentBayType)1300, Name = "Front Left Turret" });
            AddBay((UnitClass)55000, new ComponentBay { Id = 5, Type = (ComponentBayType)1300, Name = "Rear Turret" });
            AddBay((UnitClass)55000, new ComponentBay { Id = 6, Type = (ComponentBayType)700, Name = "Mine Turret" });
            AddBay((UnitClass)55000, new ComponentBay { Id = 7, Type = (ComponentBayType)1300, Name = "Front Right Turret" });
            AddBay((UnitClass)55000, new ComponentBay { Id = 8, Type = (ComponentBayType)1300, Name = "Top Left Turret" });
            AddBay((UnitClass)55000, new ComponentBay { Id = 9, Type = (ComponentBayType)1000, Name = "Power Generator" });
            AddBay((UnitClass)55000, new ComponentBay { Id = 10, Type = (ComponentBayType)1100, Name = "Shield" });
            AddBay((UnitClass)55000, new ComponentBay { Id = 11, Type = (ComponentBayType)1200, Name = "Tractor Beam" });
            AddBay((UnitClass)55000, new ComponentBay { Id = 100, Type = (ComponentBayType)900, Name = "Passenger Module" });
            AddBay((UnitClass)55000, new ComponentBay { Id = 200, Type = (ComponentBayType)400, Name = "Electronics" });
            AddBay((UnitClass)55000, new ComponentBay { Id = 110, Type = (ComponentBayType)1300, Name = "Top Right Turret" });
            // OrionX
            AddBay((UnitClass)55005, new ComponentBay { Id = 1, Type = (ComponentBayType)100, Name = "Capacitor" });
            AddBay((UnitClass)55005, new ComponentBay { Id = 2, Type = (ComponentBayType)300, Name = "Countermeasure" });
            AddBay((UnitClass)55005, new ComponentBay { Id = 3, Type = (ComponentBayType)500, Name = "Engine Bay" });
            AddBay((UnitClass)55005, new ComponentBay { Id = 4, Type = (ComponentBayType)1300, Name = "Front Left Turret" });
            AddBay((UnitClass)55005, new ComponentBay { Id = 5, Type = (ComponentBayType)1300, Name = "Rear Turret" });
            AddBay((UnitClass)55005, new ComponentBay { Id = 6, Type = (ComponentBayType)700, Name = "Mine Turret" });
            AddBay((UnitClass)55005, new ComponentBay { Id = 7, Type = (ComponentBayType)1300, Name = "Front Right Turret" });
            AddBay((UnitClass)55005, new ComponentBay { Id = 8, Type = (ComponentBayType)1300, Name = "Top Left Turret" });
            AddBay((UnitClass)55005, new ComponentBay { Id = 9, Type = (ComponentBayType)1000, Name = "Power Generator" });
            AddBay((UnitClass)55005, new ComponentBay { Id = 10, Type = (ComponentBayType)1100, Name = "Shield" });
            AddBay((UnitClass)55005, new ComponentBay { Id = 11, Type = (ComponentBayType)1200, Name = "Tractor Beam" });
            AddBay((UnitClass)55005, new ComponentBay { Id = 100, Type = (ComponentBayType)900, Name = "Passenger Module" });
            AddBay((UnitClass)55005, new ComponentBay { Id = 200, Type = (ComponentBayType)400, Name = "Electronics" });
            AddBay((UnitClass)55005, new ComponentBay { Id = 110, Type = (ComponentBayType)1300, Name = "Top Right Turret" });
            // Overlord
            AddBay((UnitClass)25010, new ComponentBay { Id = 1, Type = (ComponentBayType)100, Name = "Capacitor" });
            AddBay((UnitClass)25010, new ComponentBay { Id = 2, Type = (ComponentBayType)300, Name = "Countermeasure Bay" });
            AddBay((UnitClass)25010, new ComponentBay { Id = 3, Type = (ComponentBayType)500, Name = "Engine Bay" });
            AddBay((UnitClass)25010, new ComponentBay { Id = 4, Type = (ComponentBayType)1300, Name = "Front Left Turret" });
            AddBay((UnitClass)25010, new ComponentBay { Id = 5, Type = (ComponentBayType)1300, Name = "Rear Left Turret" });
            AddBay((UnitClass)25010, new ComponentBay { Id = 6, Type = (ComponentBayType)1300, Name = "Mid Turret" });
            AddBay((UnitClass)25010, new ComponentBay { Id = 7, Type = (ComponentBayType)1300, Name = "Front Right Turret" });
            AddBay((UnitClass)25010, new ComponentBay { Id = 8, Type = (ComponentBayType)1300, Name = "Lower Mid Turret" });
            AddBay((UnitClass)25010, new ComponentBay { Id = 9, Type = (ComponentBayType)1300, Name = "Top Turret" });
            AddBay((UnitClass)25010, new ComponentBay { Id = 10, Type = (ComponentBayType)1000, Name = "Power Generator" });
            AddBay((UnitClass)25010, new ComponentBay { Id = 11, Type = (ComponentBayType)1300, Name = "Rear Right Turret" });
            AddBay((UnitClass)25010, new ComponentBay { Id = 12, Type = (ComponentBayType)1100, Name = "Shield Bay" });
            AddBay((UnitClass)25010, new ComponentBay { Id = 13, Type = (ComponentBayType)1200, Name = "Tractor Beam" });
            AddBay((UnitClass)25010, new ComponentBay { Id = 100, Type = (ComponentBayType)900, Name = "Passenger Module" });
            // OverlordA
            AddBay((UnitClass)25000, new ComponentBay { Id = 1, Type = (ComponentBayType)100, Name = "Capacitor" });
            AddBay((UnitClass)25000, new ComponentBay { Id = 2, Type = (ComponentBayType)300, Name = "Countermeasure Bay" });
            AddBay((UnitClass)25000, new ComponentBay { Id = 3, Type = (ComponentBayType)500, Name = "Engine Bay" });
            AddBay((UnitClass)25000, new ComponentBay { Id = 4, Type = (ComponentBayType)1300, Name = "Front Left Turret" });
            AddBay((UnitClass)25000, new ComponentBay { Id = 5, Type = (ComponentBayType)1300, Name = "Rear Left Turret" });
            AddBay((UnitClass)25000, new ComponentBay { Id = 6, Type = (ComponentBayType)1300, Name = "Mid Turret" });
            AddBay((UnitClass)25000, new ComponentBay { Id = 7, Type = (ComponentBayType)1300, Name = "Front Right Turret" });
            AddBay((UnitClass)25000, new ComponentBay { Id = 8, Type = (ComponentBayType)1300, Name = "Lower Mid Turret" });
            AddBay((UnitClass)25000, new ComponentBay { Id = 9, Type = (ComponentBayType)1300, Name = "Top Turret" });
            AddBay((UnitClass)25000, new ComponentBay { Id = 10, Type = (ComponentBayType)1000, Name = "Power Generator" });
            AddBay((UnitClass)25000, new ComponentBay { Id = 11, Type = (ComponentBayType)1300, Name = "Rear Right Turret" });
            AddBay((UnitClass)25000, new ComponentBay { Id = 12, Type = (ComponentBayType)1100, Name = "Shield Bay" });
            AddBay((UnitClass)25000, new ComponentBay { Id = 13, Type = (ComponentBayType)1200, Name = "Tractor Beam" });
            AddBay((UnitClass)25000, new ComponentBay { Id = 100, Type = (ComponentBayType)900, Name = "Passenger Module" });
            // OverlordX
            AddBay((UnitClass)25003, new ComponentBay { Id = 1, Type = (ComponentBayType)100, Name = "Capacitor" });
            AddBay((UnitClass)25003, new ComponentBay { Id = 2, Type = (ComponentBayType)300, Name = "Countermeasure Bay" });
            AddBay((UnitClass)25003, new ComponentBay { Id = 3, Type = (ComponentBayType)500, Name = "Engine Bay" });
            AddBay((UnitClass)25003, new ComponentBay { Id = 4, Type = (ComponentBayType)1300, Name = "Front Left Turret" });
            AddBay((UnitClass)25003, new ComponentBay { Id = 5, Type = (ComponentBayType)1300, Name = "Rear Turret" });
            AddBay((UnitClass)25003, new ComponentBay { Id = 6, Type = (ComponentBayType)1300, Name = "Mid Turret" });
            AddBay((UnitClass)25003, new ComponentBay { Id = 7, Type = (ComponentBayType)1300, Name = "Front Right Turret" });
            AddBay((UnitClass)25003, new ComponentBay { Id = 8, Type = (ComponentBayType)1300, Name = "Lower Mid Turret" });
            AddBay((UnitClass)25003, new ComponentBay { Id = 9, Type = (ComponentBayType)1300, Name = "Top Turret" });
            AddBay((UnitClass)25003, new ComponentBay { Id = 10, Type = (ComponentBayType)1000, Name = "Power Generator" });
            AddBay((UnitClass)25003, new ComponentBay { Id = 12, Type = (ComponentBayType)1100, Name = "Shield Bay" });
            AddBay((UnitClass)25003, new ComponentBay { Id = 13, Type = (ComponentBayType)1200, Name = "Tractor Beam" });
            AddBay((UnitClass)25003, new ComponentBay { Id = 100, Type = (ComponentBayType)900, Name = "Passenger Module" });
            AddBay((UnitClass)25003, new ComponentBay { Id = 200, Type = (ComponentBayType)400, Name = "Electronics" });
            // Pioneer
            AddBay((UnitClass)26000, new ComponentBay { Id = 1, Type = (ComponentBayType)100, Name = "Capacitor" });
            AddBay((UnitClass)26000, new ComponentBay { Id = 2, Type = (ComponentBayType)500, Name = "Engine Bay" });
            AddBay((UnitClass)26000, new ComponentBay { Id = 3, Type = (ComponentBayType)300, Name = "Countermeasure Bay" });
            AddBay((UnitClass)26000, new ComponentBay { Id = 4, Type = (ComponentBayType)1300, Name = "Left Turret" });
            AddBay((UnitClass)26000, new ComponentBay { Id = 5, Type = (ComponentBayType)700, Name = "Mine" });
            AddBay((UnitClass)26000, new ComponentBay { Id = 6, Type = (ComponentBayType)1300, Name = "Top Turret" });
            AddBay((UnitClass)26000, new ComponentBay { Id = 7, Type = (ComponentBayType)1300, Name = "Right Turret" });
            AddBay((UnitClass)26000, new ComponentBay { Id = 8, Type = (ComponentBayType)1000, Name = "Power Generator" });
            AddBay((UnitClass)26000, new ComponentBay { Id = 9, Type = (ComponentBayType)1300, Name = "Rear Turret" });
            AddBay((UnitClass)26000, new ComponentBay { Id = 10, Type = (ComponentBayType)1100, Name = "Shield Bay" });
            AddBay((UnitClass)26000, new ComponentBay { Id = 11, Type = (ComponentBayType)1200, Name = "Tractor Beam" });
            AddBay((UnitClass)26000, new ComponentBay { Id = 100, Type = (ComponentBayType)900, Name = "Passenger Module" });
            AddBay((UnitClass)26000, new ComponentBay { Id = 12, Type = (ComponentBayType)400, Name = "Electronics" });
            // PioneerP
            AddBay((UnitClass)27000, new ComponentBay { Id = 1, Type = (ComponentBayType)100, Name = "Capacitor" });
            AddBay((UnitClass)27000, new ComponentBay { Id = 2, Type = (ComponentBayType)500, Name = "Engine Bay" });
            AddBay((UnitClass)27000, new ComponentBay { Id = 3, Type = (ComponentBayType)300, Name = "Countermeasure Bay" });
            AddBay((UnitClass)27000, new ComponentBay { Id = 4, Type = (ComponentBayType)1300, Name = "Left Turret" });
            AddBay((UnitClass)27000, new ComponentBay { Id = 5, Type = (ComponentBayType)700, Name = "Mine" });
            AddBay((UnitClass)27000, new ComponentBay { Id = 6, Type = (ComponentBayType)1300, Name = "Top Turret" });
            AddBay((UnitClass)27000, new ComponentBay { Id = 7, Type = (ComponentBayType)1300, Name = "Right Turret" });
            AddBay((UnitClass)27000, new ComponentBay { Id = 8, Type = (ComponentBayType)1000, Name = "Power Generator" });
            AddBay((UnitClass)27000, new ComponentBay { Id = 9, Type = (ComponentBayType)1300, Name = "Rear Turret" });
            AddBay((UnitClass)27000, new ComponentBay { Id = 10, Type = (ComponentBayType)1100, Name = "Shield Bay" });
            AddBay((UnitClass)27000, new ComponentBay { Id = 11, Type = (ComponentBayType)1200, Name = "Tractor Beam" });
            AddBay((UnitClass)27000, new ComponentBay { Id = 100, Type = (ComponentBayType)900, Name = "Passenger Module" });
            AddBay((UnitClass)27000, new ComponentBay { Id = 12, Type = (ComponentBayType)400, Name = "Electronics" });
            // PioneerA
            AddBay((UnitClass)28000, new ComponentBay { Id = 1, Type = (ComponentBayType)100, Name = "Capacitor" });
            AddBay((UnitClass)28000, new ComponentBay { Id = 2, Type = (ComponentBayType)500, Name = "Engine Bay" });
            AddBay((UnitClass)28000, new ComponentBay { Id = 3, Type = (ComponentBayType)300, Name = "Countermeasure Bay" });
            AddBay((UnitClass)28000, new ComponentBay { Id = 4, Type = (ComponentBayType)1300, Name = "Left Turret" });
            AddBay((UnitClass)28000, new ComponentBay { Id = 5, Type = (ComponentBayType)700, Name = "Mine" });
            AddBay((UnitClass)28000, new ComponentBay { Id = 6, Type = (ComponentBayType)1300, Name = "Top Turret" });
            AddBay((UnitClass)28000, new ComponentBay { Id = 7, Type = (ComponentBayType)1300, Name = "Right Turret" });
            AddBay((UnitClass)28000, new ComponentBay { Id = 8, Type = (ComponentBayType)1000, Name = "Power Generator" });
            AddBay((UnitClass)28000, new ComponentBay { Id = 9, Type = (ComponentBayType)1300, Name = "Rear Turret" });
            AddBay((UnitClass)28000, new ComponentBay { Id = 10, Type = (ComponentBayType)1100, Name = "Shield Bay" });
            AddBay((UnitClass)28000, new ComponentBay { Id = 11, Type = (ComponentBayType)1200, Name = "Tractor Beam" });
            AddBay((UnitClass)28000, new ComponentBay { Id = 100, Type = (ComponentBayType)900, Name = "Passenger Module" });
            AddBay((UnitClass)28000, new ComponentBay { Id = 12, Type = (ComponentBayType)400, Name = "Electronics" });
            // Ranger
            AddBay((UnitClass)600, new ComponentBay { Id = 1, Type = (ComponentBayType)100, Name = "Capacitor" });
            AddBay((UnitClass)600, new ComponentBay { Id = 2, Type = (ComponentBayType)500, Name = "Engine Bay" });
            AddBay((UnitClass)600, new ComponentBay { Id = 3, Type = (ComponentBayType)300, Name = "Countermeasure Bay" });
            AddBay((UnitClass)600, new ComponentBay { Id = 4, Type = (ComponentBayType)1300, Name = "Main Turret" });
            AddBay((UnitClass)600, new ComponentBay { Id = 6, Type = (ComponentBayType)1000, Name = "Power Generator" });
            AddBay((UnitClass)600, new ComponentBay { Id = 7, Type = (ComponentBayType)1100, Name = "Shield Bay" });
            AddBay((UnitClass)600, new ComponentBay { Id = 8, Type = (ComponentBayType)1200, Name = "Tractor Beam" });
            AddBay((UnitClass)600, new ComponentBay { Id = 16, Type = (ComponentBayType)700, Name = "Mine Bay" });
            AddBay((UnitClass)600, new ComponentBay { Id = 20, Type = (ComponentBayType)1300, Name = "Rear Turret" });
            // RangerA
            AddBay((UnitClass)620, new ComponentBay { Id = 1, Type = (ComponentBayType)100, Name = "Capacitor" });
            AddBay((UnitClass)620, new ComponentBay { Id = 2, Type = (ComponentBayType)500, Name = "Engine Bay" });
            AddBay((UnitClass)620, new ComponentBay { Id = 3, Type = (ComponentBayType)300, Name = "Countermeasure Bay" });
            AddBay((UnitClass)620, new ComponentBay { Id = 4, Type = (ComponentBayType)1300, Name = "Main Turret" });
            AddBay((UnitClass)620, new ComponentBay { Id = 6, Type = (ComponentBayType)1000, Name = "Power Generator" });
            AddBay((UnitClass)620, new ComponentBay { Id = 7, Type = (ComponentBayType)1100, Name = "Shield Bay" });
            AddBay((UnitClass)620, new ComponentBay { Id = 8, Type = (ComponentBayType)1200, Name = "Tractor Beam" });
            AddBay((UnitClass)620, new ComponentBay { Id = 16, Type = (ComponentBayType)700, Name = "Mine Bay" });
            AddBay((UnitClass)620, new ComponentBay { Id = 20, Type = (ComponentBayType)1300, Name = "Rear Turret" });
            // RangerH
            AddBay((UnitClass)625, new ComponentBay { Id = 1, Type = (ComponentBayType)100, Name = "Capacitor" });
            AddBay((UnitClass)625, new ComponentBay { Id = 2, Type = (ComponentBayType)500, Name = "Engine Bay" });
            AddBay((UnitClass)625, new ComponentBay { Id = 3, Type = (ComponentBayType)300, Name = "Countermeasure Bay" });
            AddBay((UnitClass)625, new ComponentBay { Id = 6, Type = (ComponentBayType)1000, Name = "Power Generator" });
            AddBay((UnitClass)625, new ComponentBay { Id = 7, Type = (ComponentBayType)1100, Name = "Shield Bay" });
            AddBay((UnitClass)625, new ComponentBay { Id = 8, Type = (ComponentBayType)1200, Name = "Tractor Beam" });
            AddBay((UnitClass)625, new ComponentBay { Id = 16, Type = (ComponentBayType)700, Name = "Mine Bay" });
            AddBay((UnitClass)625, new ComponentBay { Id = 4, Type = (ComponentBayType)1300, Name = "Main Turret" });
            // RangerM
            AddBay((UnitClass)630, new ComponentBay { Id = 1, Type = (ComponentBayType)100, Name = "Capacitor" });
            AddBay((UnitClass)630, new ComponentBay { Id = 2, Type = (ComponentBayType)500, Name = "Engine Bay" });
            AddBay((UnitClass)630, new ComponentBay { Id = 3, Type = (ComponentBayType)300, Name = "Countermeasure Bay" });
            AddBay((UnitClass)630, new ComponentBay { Id = 4, Type = (ComponentBayType)1400, Name = "Main Mining Turret" });
            AddBay((UnitClass)630, new ComponentBay { Id = 6, Type = (ComponentBayType)1000, Name = "Power Generator" });
            AddBay((UnitClass)630, new ComponentBay { Id = 7, Type = (ComponentBayType)1100, Name = "Shield Bay" });
            AddBay((UnitClass)630, new ComponentBay { Id = 8, Type = (ComponentBayType)1200, Name = "Tractor Beam" });
            AddBay((UnitClass)630, new ComponentBay { Id = 16, Type = (ComponentBayType)700, Name = "Mine Bay" });
            AddBay((UnitClass)630, new ComponentBay { Id = 20, Type = (ComponentBayType)1300, Name = "Rear Turret" });
            // Raptor
            AddBay((UnitClass)800, new ComponentBay { Id = 1, Type = (ComponentBayType)100, Name = "Capacitor" });
            AddBay((UnitClass)800, new ComponentBay { Id = 2, Type = (ComponentBayType)500, Name = "Engine Bay" });
            AddBay((UnitClass)800, new ComponentBay { Id = 3, Type = (ComponentBayType)300, Name = "Countermeasure Bay" });
            AddBay((UnitClass)800, new ComponentBay { Id = 6, Type = (ComponentBayType)1000, Name = "Power Generator" });
            AddBay((UnitClass)800, new ComponentBay { Id = 7, Type = (ComponentBayType)1100, Name = "Shield Bay" });
            AddBay((UnitClass)800, new ComponentBay { Id = 8, Type = (ComponentBayType)1200, Name = "Tractor Beam" });
            AddBay((UnitClass)800, new ComponentBay { Id = 16, Type = (ComponentBayType)700, Name = "Mine Bay" });
            AddBay((UnitClass)800, new ComponentBay { Id = 4, Type = (ComponentBayType)1300, Name = "Top Turret" });
            AddBay((UnitClass)800, new ComponentBay { Id = 150, Type = (ComponentBayType)1300, Name = "Left Turret" });
            AddBay((UnitClass)800, new ComponentBay { Id = 120, Type = (ComponentBayType)1300, Name = "Right Turret" });
            // RaptorA
            AddBay((UnitClass)820, new ComponentBay { Id = 1, Type = (ComponentBayType)100, Name = "Capacitor" });
            AddBay((UnitClass)820, new ComponentBay { Id = 2, Type = (ComponentBayType)500, Name = "Engine Bay" });
            AddBay((UnitClass)820, new ComponentBay { Id = 3, Type = (ComponentBayType)300, Name = "Countermeasure Bay" });
            AddBay((UnitClass)820, new ComponentBay { Id = 6, Type = (ComponentBayType)1000, Name = "Power Generator" });
            AddBay((UnitClass)820, new ComponentBay { Id = 7, Type = (ComponentBayType)1100, Name = "Shield Bay" });
            AddBay((UnitClass)820, new ComponentBay { Id = 8, Type = (ComponentBayType)1200, Name = "Tractor Beam" });
            AddBay((UnitClass)820, new ComponentBay { Id = 16, Type = (ComponentBayType)700, Name = "Mine Bay" });
            AddBay((UnitClass)820, new ComponentBay { Id = 4, Type = (ComponentBayType)1300, Name = "Top Turret" });
            AddBay((UnitClass)820, new ComponentBay { Id = 150, Type = (ComponentBayType)1300, Name = "Left Turret" });
            AddBay((UnitClass)820, new ComponentBay { Id = 120, Type = (ComponentBayType)1300, Name = "Right Turret" });
            // Shuttle
            AddBay((UnitClass)35000, new ComponentBay { Id = 1, Type = (ComponentBayType)100, Name = "Capacitor" });
            AddBay((UnitClass)35000, new ComponentBay { Id = 2, Type = (ComponentBayType)500, Name = "Engine Bay" });
            AddBay((UnitClass)35000, new ComponentBay { Id = 3, Type = (ComponentBayType)300, Name = "Countermeasure Bay" });
            AddBay((UnitClass)35000, new ComponentBay { Id = 4, Type = (ComponentBayType)1300, Name = "Left Turret" });
            AddBay((UnitClass)35000, new ComponentBay { Id = 5, Type = (ComponentBayType)1300, Name = "Right Turret" });
            AddBay((UnitClass)35000, new ComponentBay { Id = 6, Type = (ComponentBayType)1000, Name = "Power Generator" });
            AddBay((UnitClass)35000, new ComponentBay { Id = 7, Type = (ComponentBayType)1100, Name = "Shield Bay" });
            AddBay((UnitClass)35000, new ComponentBay { Id = 8, Type = (ComponentBayType)1200, Name = "Tractor Beam" });
            AddBay((UnitClass)35000, new ComponentBay { Id = 100, Type = (ComponentBayType)900, Name = "Passenger Module" });
            // ShuttleA
            AddBay((UnitClass)36000, new ComponentBay { Id = 100, Type = (ComponentBayType)900, Name = "Passenger Module" });
            AddBay((UnitClass)36000, new ComponentBay { Id = 1, Type = (ComponentBayType)100, Name = "Capacitor" });
            AddBay((UnitClass)36000, new ComponentBay { Id = 2, Type = (ComponentBayType)500, Name = "Engine Bay" });
            AddBay((UnitClass)36000, new ComponentBay { Id = 3, Type = (ComponentBayType)300, Name = "Countermeasure Bay" });
            AddBay((UnitClass)36000, new ComponentBay { Id = 4, Type = (ComponentBayType)1300, Name = "Left Turret" });
            AddBay((UnitClass)36000, new ComponentBay { Id = 5, Type = (ComponentBayType)1300, Name = "Right Turret" });
            AddBay((UnitClass)36000, new ComponentBay { Id = 6, Type = (ComponentBayType)1000, Name = "Power Generator" });
            AddBay((UnitClass)36000, new ComponentBay { Id = 7, Type = (ComponentBayType)1100, Name = "Shield Bay" });
            AddBay((UnitClass)36000, new ComponentBay { Id = 8, Type = (ComponentBayType)1200, Name = "Tractor Beam" });
            // Thunder
            AddBay((UnitClass)55505, new ComponentBay { Id = 1, Type = (ComponentBayType)100, Name = "Capacitor" });
            AddBay((UnitClass)55505, new ComponentBay { Id = 2, Type = (ComponentBayType)300, Name = "Countermeasure" });
            AddBay((UnitClass)55505, new ComponentBay { Id = 3, Type = (ComponentBayType)500, Name = "Engine Bay" });
            AddBay((UnitClass)55505, new ComponentBay { Id = 4, Type = (ComponentBayType)1300, Name = "Front Left Turret" });
            AddBay((UnitClass)55505, new ComponentBay { Id = 7, Type = (ComponentBayType)1300, Name = "Front Right Turret" });
            AddBay((UnitClass)55505, new ComponentBay { Id = 6, Type = (ComponentBayType)700, Name = "Mine Turret" });
            AddBay((UnitClass)55505, new ComponentBay { Id = 8, Type = (ComponentBayType)1300, Name = "Top Turret" });
            AddBay((UnitClass)55505, new ComponentBay { Id = 9, Type = (ComponentBayType)1000, Name = "Power Generator" });
            AddBay((UnitClass)55505, new ComponentBay { Id = 10, Type = (ComponentBayType)1100, Name = "Shield" });
            AddBay((UnitClass)55505, new ComponentBay { Id = 11, Type = (ComponentBayType)1200, Name = "Tractor Beam" });
            AddBay((UnitClass)55505, new ComponentBay { Id = 100, Type = (ComponentBayType)900, Name = "Passenger Module" });
            AddBay((UnitClass)55505, new ComponentBay { Id = 200, Type = (ComponentBayType)400, Name = "Electronics" });
            AddBay((UnitClass)55505, new ComponentBay { Id = 300, Type = (ComponentBayType)1300, Name = "Rear Left Turret" });
            AddBay((UnitClass)55505, new ComponentBay { Id = 400, Type = (ComponentBayType)1300, Name = "Rear Right Turret" });
            // ThunderA
            AddBay((UnitClass)55500, new ComponentBay { Id = 1, Type = (ComponentBayType)100, Name = "Capacitor" });
            AddBay((UnitClass)55500, new ComponentBay { Id = 2, Type = (ComponentBayType)300, Name = "Countermeasure" });
            AddBay((UnitClass)55500, new ComponentBay { Id = 3, Type = (ComponentBayType)500, Name = "Engine Bay" });
            AddBay((UnitClass)55500, new ComponentBay { Id = 4, Type = (ComponentBayType)1300, Name = "Front Left Turret" });
            AddBay((UnitClass)55500, new ComponentBay { Id = 7, Type = (ComponentBayType)1300, Name = "Front Right Turret" });
            AddBay((UnitClass)55500, new ComponentBay { Id = 6, Type = (ComponentBayType)700, Name = "Mine Turret" });
            AddBay((UnitClass)55500, new ComponentBay { Id = 8, Type = (ComponentBayType)1300, Name = "Top Turret" });
            AddBay((UnitClass)55500, new ComponentBay { Id = 9, Type = (ComponentBayType)1000, Name = "Power Generator" });
            AddBay((UnitClass)55500, new ComponentBay { Id = 10, Type = (ComponentBayType)1100, Name = "Shield" });
            AddBay((UnitClass)55500, new ComponentBay { Id = 11, Type = (ComponentBayType)1200, Name = "Tractor Beam" });
            AddBay((UnitClass)55500, new ComponentBay { Id = 100, Type = (ComponentBayType)900, Name = "Passenger Module" });
            AddBay((UnitClass)55500, new ComponentBay { Id = 200, Type = (ComponentBayType)400, Name = "Electronics" });
            AddBay((UnitClass)55500, new ComponentBay { Id = 300, Type = (ComponentBayType)1300, Name = "Rear Left Turret" });
            AddBay((UnitClass)55500, new ComponentBay { Id = 400, Type = (ComponentBayType)1300, Name = "Rear Right Turret" });
            // ThunderX
            AddBay((UnitClass)55503, new ComponentBay { Id = 1, Type = (ComponentBayType)100, Name = "Capacitor" });
            AddBay((UnitClass)55503, new ComponentBay { Id = 2, Type = (ComponentBayType)300, Name = "Countermeasure" });
            AddBay((UnitClass)55503, new ComponentBay { Id = 3, Type = (ComponentBayType)500, Name = "Engine Bay" });
            AddBay((UnitClass)55503, new ComponentBay { Id = 4, Type = (ComponentBayType)1300, Name = "Front Left Turret" });
            AddBay((UnitClass)55503, new ComponentBay { Id = 7, Type = (ComponentBayType)1300, Name = "Front Right Turret" });
            AddBay((UnitClass)55503, new ComponentBay { Id = 6, Type = (ComponentBayType)700, Name = "Mine Turret" });
            AddBay((UnitClass)55503, new ComponentBay { Id = 8, Type = (ComponentBayType)1300, Name = "Top Turret" });
            AddBay((UnitClass)55503, new ComponentBay { Id = 9, Type = (ComponentBayType)1000, Name = "Power Generator" });
            AddBay((UnitClass)55503, new ComponentBay { Id = 10, Type = (ComponentBayType)1100, Name = "Shield" });
            AddBay((UnitClass)55503, new ComponentBay { Id = 11, Type = (ComponentBayType)1200, Name = "Tractor Beam" });
            AddBay((UnitClass)55503, new ComponentBay { Id = 100, Type = (ComponentBayType)900, Name = "Passenger Module" });
            AddBay((UnitClass)55503, new ComponentBay { Id = 200, Type = (ComponentBayType)400, Name = "Electronics" });
            AddBay((UnitClass)55503, new ComponentBay { Id = 300, Type = (ComponentBayType)1300, Name = "Rear Left Turret" });
            AddBay((UnitClass)55503, new ComponentBay { Id = 400, Type = (ComponentBayType)1300, Name = "Rear Right Turret" });
            // Venture
            AddBay((UnitClass)700, new ComponentBay { Id = 1, Type = (ComponentBayType)100, Name = "Capacitor" });
            AddBay((UnitClass)700, new ComponentBay { Id = 2, Type = (ComponentBayType)500, Name = "Engine Bay" });
            AddBay((UnitClass)700, new ComponentBay { Id = 3, Type = (ComponentBayType)300, Name = "Countermeasure Bay" });
            AddBay((UnitClass)700, new ComponentBay { Id = 4, Type = (ComponentBayType)1300, Name = "Front Turret" });
            AddBay((UnitClass)700, new ComponentBay { Id = 5, Type = (ComponentBayType)1300, Name = "Mid Turret" });
            AddBay((UnitClass)700, new ComponentBay { Id = 6, Type = (ComponentBayType)1300, Name = "Top Turret" });
            AddBay((UnitClass)700, new ComponentBay { Id = 7, Type = (ComponentBayType)1000, Name = "Power Generator" });
            AddBay((UnitClass)700, new ComponentBay { Id = 8, Type = (ComponentBayType)1300, Name = "Rear Turret" });
            AddBay((UnitClass)700, new ComponentBay { Id = 9, Type = (ComponentBayType)1100, Name = "Shield Bay" });
            AddBay((UnitClass)700, new ComponentBay { Id = 11, Type = (ComponentBayType)1200, Name = "Tractor Beam" });
            AddBay((UnitClass)700, new ComponentBay { Id = 12, Type = (ComponentBayType)400, Name = "Electronics" });
            AddBay((UnitClass)700, new ComponentBay { Id = 30, Type = (ComponentBayType)700, Name = "Mine Bay" });
            // VentureA
            AddBay((UnitClass)710, new ComponentBay { Id = 1, Type = (ComponentBayType)100, Name = "Capacitor" });
            AddBay((UnitClass)710, new ComponentBay { Id = 2, Type = (ComponentBayType)500, Name = "Engine Bay" });
            AddBay((UnitClass)710, new ComponentBay { Id = 3, Type = (ComponentBayType)300, Name = "Countermeasure Bay" });
            AddBay((UnitClass)710, new ComponentBay { Id = 4, Type = (ComponentBayType)1300, Name = "Front Turret" });
            AddBay((UnitClass)710, new ComponentBay { Id = 5, Type = (ComponentBayType)1300, Name = "Mid Turret" });
            AddBay((UnitClass)710, new ComponentBay { Id = 6, Type = (ComponentBayType)1300, Name = "Top Turret" });
            AddBay((UnitClass)710, new ComponentBay { Id = 7, Type = (ComponentBayType)1000, Name = "Power Generator" });
            AddBay((UnitClass)710, new ComponentBay { Id = 8, Type = (ComponentBayType)1300, Name = "Rear Turret" });
            AddBay((UnitClass)710, new ComponentBay { Id = 9, Type = (ComponentBayType)1100, Name = "Shield Bay" });
            AddBay((UnitClass)710, new ComponentBay { Id = 11, Type = (ComponentBayType)1200, Name = "Tractor Beam" });
            AddBay((UnitClass)710, new ComponentBay { Id = 12, Type = (ComponentBayType)400, Name = "Electronics" });
            AddBay((UnitClass)710, new ComponentBay { Id = 30, Type = (ComponentBayType)700, Name = "Mine Bay" });
            // Laser III Turret
            AddBay((UnitClass)37206, new ComponentBay { Id = 1, Type = (ComponentBayType)1000, Name = "component_bay_pwr_generator" });
            AddBay((UnitClass)37206, new ComponentBay { Id = 2, Type = (ComponentBayType)100, Name = "component_bay_capacitor" });
            AddBay((UnitClass)37206, new ComponentBay { Id = 3, Type = (ComponentBayType)1100, Name = "component_bay_shield" });
            AddBay((UnitClass)37206, new ComponentBay { Id = 4, Type = (ComponentBayType)1300, Name = "Main Turret" });
            // Laser V Turret
            AddBay((UnitClass)37205, new ComponentBay { Id = 1, Type = (ComponentBayType)1000, Name = "component_bay_pwr_generator" });
            AddBay((UnitClass)37205, new ComponentBay { Id = 2, Type = (ComponentBayType)100, Name = "component_bay_capacitor" });
            AddBay((UnitClass)37205, new ComponentBay { Id = 3, Type = (ComponentBayType)1100, Name = "component_bay_shield" });
            AddBay((UnitClass)37205, new ComponentBay { Id = 4, Type = (ComponentBayType)1300, Name = "Main Turret" });


        }

        public static IEnumerable<ComponentBay> GetComponentBays(UnitClass unitClass)
        {
            List<ComponentBay> bays = null;
            if (!UnitClassComponentBays.TryGetValue(unitClass, out bays))
            {
                bays = new List<ComponentBay>();
            }

            return bays;
        }

        private static void AddBay(UnitClass unitClass, ComponentBay componentBay)
        {
            List<ComponentBay> bays = null;
            if (!UnitClassComponentBays.TryGetValue(unitClass, out bays))
            {
                bays = new List<ComponentBay>();
                UnitClassComponentBays[unitClass] = bays;
            }

            bays.Add(componentBay);
        }
    }
}
