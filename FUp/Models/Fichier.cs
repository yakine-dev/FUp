using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FUp.Models
{
    public class Fichier
    {
        
        public int Id { get; set; }

        public string Nom { get; set; }
  
        public float Taile { get; set; }

        public DateTime DateUpload { get; set; }
    }
}