using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TheLastTime.Shared.Pages;

namespace TheLastTime.Shared.Models
{
    public class Category
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public string Description { get; set; } = "Default";

        [Required]
        public string Color { get; set; } = string.Empty;

        [Required]
        public string Icon { get; set; } = string.Empty;

        public List<Habit> HabitList = new List<Habit>();

        [Required]
        public int ModelNumber { get; set; } = 5;
        [Required]
        public int TrialNumber { get; set; } = 20;
        [Required]
        public int CongRatio { get; set; } = 50;
        [Required]
        public int N { get; set; } = 1000;
        [Required]
        public int durFix { get; set; } = 500;
        [Required]
        public int durPrime { get; set; } = 45;
        [Required]
        public int durMask { get; set; } = 75;
        [Required]
        public int durTarget { get; set; } = 200;
        [Required]
        public int durPrimeMaskISI { get; set; } = 0;
        [Required]
        public int durMaskTargetISI { get; set; } = 0;
        [Required]
        public double noisePTR { get; set; } = 0.15;
        [Required]
        public double noiseMasks { get; set; } = 0.25;
        [Required]
        public double noiseTask { get; set; } = 0.05;
        [Required]
        public double CrossPri { get; set; } = 0.33;
        [Required]
        public double SelfPri { get; set; } = 1.5;
        [Required]
        public double inpamin { get; set; } = 0;
        [Required]
        public double inpamax { get; set; } = 1.0;
        [Required]
        public double ThreshPri { get; set; } = 0.65;
        [Required]
        public double inhPri { get; set; } = -1.0;
        [Required]
        public double biasPL { get; set; } = -0.5;
        [Required]
        public double conPrime { get; set; } = 3.0;
        [Required]
        public double CrossTar { get; set; } = 0.33;
        [Required]
        public double SelfTar { get; set; } = 1.5;
        [Required]
        public double inpbmin { get; set; } = 0;
        [Required]
        public double inpbmax { get; set; } = 1.0;
        [Required]
        public double inhTar { get; set; } = -1.0;
        [Required]
        public double ThreshTar { get; set; } = 0.65;
        [Required]
        public double biasPR { get; set; } = -0.5;
        [Required]
        public double conTarget { get; set; } = 3.0;
        [Required]
        public double SelfO { get; set; } = 1.0;
        [Required]
        public double inhO { get; set; } = -1.0;
        [Required]
        public double ThreshO { get; set; } = 0.7;
        [Required]
        public double biasOut { get; set; } = -2.0;
        [Required]
        public double conResponse { get; set; } = 1.5;
        [Required]
        public double SelfT { get; set; } = 1.0;
        [Required]
        public double inhT { get; set; } = -1.0;
        [Required]
        public double ThreshT { get; set; } = 0.45;
        [Required]
        public double biasTask { get; set; } = -1.25;
        [Required]
        public double ThreshConf { get; set; } = 2.0;
        [Required]
        public double cLC { get; set; } = 3.85;
        [Required]
        public double CLCthresh { get; set; } = 1.0;
        [Required]
        public double g1 { get; set; } = 3;
        [Required]
        public double g2 { get; set; } = 1;
        [Required]
        public double SelfMasks { get; set; } = 1.5;
        [Required]
        public double BiasMasks { get; set; } = -1.25;
        [Required]
        public double CrossLMasks { get; set; } = 0.75;
        [Required]
        public double ConMasks { get; set; } = 1.5;
        [Required]
        public double InhMasks { get; set; } = -1.0;
        [Required]
        public int durM_T_ISIcoef { get; set; } = 35;
        [Required]
        public double inpamask { get; set; } = 1.0;
        [Required]
        public double inpbmask { get; set; } = 1.0;
    }
}
