using System.Collections.Generic;

namespace golf.stats.Models
{
    public class RoundStatsViewModel
    {      
        public List<PostStatsViewModel> Stats { get; set; }
    }

    public enum YesNo
    {
        Yes,
        No
    }

    public enum YesNoNa
    {
        Yes,
        No,
        NA
    }

    public enum GolfBag
    {
        Driver,
        ThreeWood,
        FiveWood,
        TwentyOneDegree,
        TwentyThreeDegree,
        FourIron,
        FiveIron,
        SixIron,
        SevenIron,
        EightIron,
        NineIron,
        PitchingWedge,
        GapWedge,
        LobWedge
    }
}