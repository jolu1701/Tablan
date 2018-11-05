namespace Tablån.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Shows
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        public int? Channel_id { get; set; }

        public int? Genre_id { get; set; }

        public DateTime Start_time { get; set; }

        public TimeSpan Duration { get; set; }

        [Required]
        [StringLength(300)]
        public string Info { get; set; }

        public virtual Channels Channels { get; set; }

        public virtual Genres Genres { get; set; }
    }
}
