namespace DbTest.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class member
    {
        public int id { get; set; }

        [StringLength(32)]
        public string name { get; set; }

        public DateTime? birthday { get; set; }
    }
}
