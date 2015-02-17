namespace PensionWorld.Web.Models
{
    using System;
    using System.ComponentModel;

    public class RoomViewModel
    {
        public Guid Id { get; set; }

        public int Number { get; set; }

        public float Surface { get; set; }

        public int Floor { get; set; }

        [DisplayName("Has balcony?")]
        public bool HasBalcony { get; set; }

        [DisplayName("Has bathroom?")]
        public bool HasBathroom { get; set; }

        public string Type { get; set; }
    }
}