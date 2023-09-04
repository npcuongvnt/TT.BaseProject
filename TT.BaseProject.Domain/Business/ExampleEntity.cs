﻿using TT.BaseProject.Domain.Attributes;

namespace TT.BaseProject.Domain.Business
{
    [Table("example")]
    public class ExampleEntity
    {
        [Key]
        public Guid example_id { get; set; }
        public string example_name { get; set; }
        public DateTime? created_date { get; set; }
        public string create_by { get; set; }
        public DateTime? modified_date { get; set; }
        public string modified_by { get; set; }
    }
}
