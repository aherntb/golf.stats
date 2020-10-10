using System;
using System.Collections.Generic;

namespace Golf.Stats.Model
{
    public class Round
    {
        public DateTime DateTime { get; set; }
        public string Name { get; set; }

        public List<Hole> Holes { get; set; }
    }

    public class Hole
    {
        public int Number { get; set; }
        public int Par { get; set; }
        public int Score { get; set; }
        
        
    }

    
    public class Stroke
    {
        public StrokeType Type { get; set; }
        public GolfClub Club { get; set; }
        
    }

    public enum StrokeType
    {
        TeeShot,
        Approach,
        Putt
    } 
    public enum GolfClub
    {
        Driver,
        ThreeWood,
        PowerHybrid,
        FourIron,
        FiveIron,
        SixIron,
        SevenIron,
        EightIron,
        NineIron,
        PitchingWedge,
        GapWedge,
        SandWedge,
        LobWedge,
        Putter
    }
}