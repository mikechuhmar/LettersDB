using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettersDBLibrary
{
    public class Letter
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(1)]
        public string Name { get; set; }

        public byte[] Image { get; set; }


    }
}