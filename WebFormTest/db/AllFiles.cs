namespace WebFormTest.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("File.AllFiles")]
    public partial class AllFiles
    {
        [Key]
        [Column(Order = 0)]
        public Guid stream_id { get; set; }

        public byte[] file_stream { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(255)]
        public string name { get; set; }

        [StringLength(255)]
        public string file_type { get; set; }

        public long? cached_file_size { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTimeOffset creation_time { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTimeOffset last_write_time { get; set; }

        public DateTimeOffset? last_access_time { get; set; }

        [Key]
        [Column(Order = 4)]
        public bool is_directory { get; set; }

        [Key]
        [Column(Order = 5)]
        public bool is_offline { get; set; }

        [Key]
        [Column(Order = 6)]
        public bool is_hidden { get; set; }

        [Key]
        [Column(Order = 7)]
        public bool is_readonly { get; set; }

        [Key]
        [Column(Order = 8)]
        public bool is_archive { get; set; }

        [Key]
        [Column(Order = 9)]
        public bool is_system { get; set; }

        [Key]
        [Column(Order = 10)]
        public bool is_temporary { get; set; }
    }
}
