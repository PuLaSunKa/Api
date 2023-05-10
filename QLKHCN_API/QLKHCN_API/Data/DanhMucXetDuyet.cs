using System;
using System.ComponentModel.DataAnnotations;

namespace QLKHCN_API.Data
{
    public class DanhMucXetDuyet
    {
        [Key]
        public int IDDanhMuc { get; set; }

        [MaxLength(500)]
        public string journal_name { get; set; }

        [MaxLength(50)]
        public string issn { get; set; }

        [MaxLength(50)]
        public string eissn { get; set; }

        [MaxLength(100)]
        public string category { get; set; }

        [MaxLength(50)]
        public string citations { get; set; }

        [MaxLength(50)]
        public string if_2022 { get; set; }

        [MaxLength(10)]
        public string jci { get; set; }

        [MaxLength(15)]
        public string percentageOAGold { get; set; }

        [MaxLength(30)]
        public string userId { get; set; }

        [MaxLength(50)]
        public string rank { get; set; }

        [MaxLength(100)]
        public string image { get; set; }

        [MaxLength(200)]
        public string link { get; set; }

        [MaxLength(500)]
        public string tenBaiBao { get; set; }

        [MaxLength(500)]
        public string type { get; set; }

        [MaxLength(500)]
        public string groupUser { get; set; }

        [MaxLength(100)]
        public string status { get; set; }

        [MaxLength(10)]
        public string quantity { get; set; }

        [MaxLength(10)]
        public string total { get; set; }

        public DateTime dateSubmit { get; set; }
    }
}