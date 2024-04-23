using System.ComponentModel.DataAnnotations.Schema;

namespace DB_993
{
    internal class BlackList
    {
        public int Id { get; set; }
        public int Id_Realty { get; set; }
        [ForeignKey("ReltyInIdBlL")]
        public Realty? Realty_id { get; set; }
    }
}
