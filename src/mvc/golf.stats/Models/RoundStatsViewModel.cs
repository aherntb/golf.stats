using System.Collections.Generic;

namespace golf.stats.Models
{
    public class RoundStatsViewModel
    {
        
        public int[] Score { get; set; }
        public GolfBag[] TeeShotClub { get; set; }
        public GolfBag[] ApproachClub { get; set; }
        public YesNo[] FairwayInReg { get; set; }
        public YesNo[] GreenInReg { get; set; }
        public YesNoNa[] Scrambling { get; set; }
        public int[] NumOfPutts { get; set; }


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