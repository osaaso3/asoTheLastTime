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
        public string Description { get; set; } = "Model";

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
        public int N { get; set; } = 20;
        [Required]
        public int durFix { get; set; } = 20;
        [Required]
        public int durPrime { get; set; } = 20;
        [Required]
        public int durMask { get; set; } = 20;
        [Required]
        public int durTarget { get; set; } = 20;
        [Required]
        public int durPrimeMaskISI { get; set; } = 20;
        [Required]
        public int durMaskTargetISI { get; set; } = 20;
        [Required]
        public int noisePTR { get; set; } = 20;
        [Required]
        public int noiseMasks { get; set; } = 20;
        [Required]
        public int noiseTask { get; set; } = 20;
        [Required]
        public int CrossPri { get; set; } = 20;
        [Required]
        public int SelfPri { get; set; } = 20;
        [Required]
        public int inpamin { get; set; } = 20;
        [Required]
        public int inpamax { get; set; } = 20;
        [Required]
        public int ThreshPri { get; set; } = 20;
        [Required]
        public int inhPri { get; set; } = 20;
        [Required]
        public int biasPL { get; set; } = 20;
        [Required]
        public int conPrime { get; set; } = 20;
        public int CrossTar { get; set; } = 20;
        [Required]
        public int SelfTar { get; set; } = 20;
        [Required]
        public int inpbmin { get; set; } = 20;
        [Required]
        public int inpbmax { get; set; } = 20;
        [Required]
        public int inhTar { get; set; } = 20;
        public int ThreshTar { get; set; } = 20;
        [Required]
        public int biasPR { get; set; } = 20;
        [Required]
        public int conTarget { get; set; } = 20;
        [Required]
        public int SelfO { get; set; } = 20;
        [Required]
        public int inhO { get; set; } = 20;
        [Required]
        public int ThreshO { get; set; } = 20;
        public int biasOut { get; set; } = 20;
        [Required]
        public int conResponse { get; set; } = 20;
        [Required]
        public int SelfT { get; set; } = 20;
        [Required]
        public int inhT { get; set; } = 20;
        public int ThreshT { get; set; } = 20;
        [Required]
        public int biasTask { get; set; } = 20;
        [Required]
        public int ThreshConf { get; set; } = 20;
        [Required]
        public int cLC { get; set; } = 20;
        [Required]
        public int CLCthresh { get; set; } = 20;
        public int g1 { get; set; } = 20;
        [Required]
        public int g2 { get; set; } = 20;
        [Required]
        public int SelfMasks { get; set; } = 20;
        public int BiasMasks { get; set; } = 20;
        [Required]
        public int CrossLMasks { get; set; } = 20;
        [Required]
        public int ConMasks { get; set; } = 20;
        [Required]
        public int InhMasks { get; set; } = 20;
        [Required]
        public int durM_T_ISIcoef { get; set; } = 20;
        public int inpamask { get; set; } = 20;
        [Required]
        public int inpbmask { get; set; } = 20;
    }
}
