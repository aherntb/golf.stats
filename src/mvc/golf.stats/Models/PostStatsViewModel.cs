using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace golf.stats.Models
{
    public class PostStatsViewModel
    {
        [Range(0, 8, ErrorMessage = "Please enter a number between 0 & 8")]
        public int Score { get; set; }
        public string TeeShotClub { get; set; }
        public string FairwayInReg { get; set; }
        public string ApproachClub { get; set; }
        public string GreenInReg { get; set; }
        public string Scrambling { get; set; }
        
        [Range(0, 5, ErrorMessage = "Please enter a number between 0 & 5")]
        public string NumOfPutts { get; set; }

    }
}