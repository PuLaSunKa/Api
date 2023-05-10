using System.ComponentModel.DataAnnotations;

namespace QLKHCN_API.Data
{
    public class DanhMucScimago
    {
        [Key]
        public int number { get; set; }

        [MaxLength(500)]
        public string journal_name { get; set; }

        [MaxLength(500)]
        public string issn { get; set; }

        [MaxLength(500)]
        public string eissn { get; set; }

        [MaxLength(500)]
        public string category_1 { get; set; }
    }
}