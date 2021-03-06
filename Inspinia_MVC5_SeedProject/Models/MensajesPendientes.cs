﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Inspinia_MVC5_SeedProject.Models;

namespace Inspinia_MVC5_SeedProject.Models
{
    public class MensajesPendientes
    {
        public int Id { get; set; }
        public DateTime FechaCreado { get; set; }

        public PendientesMesa PendientesMesa { get; set; }
        public int PendientesMesaId { get; set; }

        public ApplicationUser Usuario { get; set; }
        public string UsuarioId { get; set; }

        [Required(ErrorMessage = "El mensaje es un campo requerido")]
        public string Mensaje { get; set; }
    }
}