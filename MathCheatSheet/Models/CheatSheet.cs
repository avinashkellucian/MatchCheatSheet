namespace MathCheatSheet.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class CheatSheet
    {
        public CheatSheet() { }
    
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
