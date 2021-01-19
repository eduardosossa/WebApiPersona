namespace ApiPersona.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public enum SexoType
    {
        Femenino = 0,
        Masculino = 1
    }
    public class Persona
    {
        [Key]
        public int PersonaId { get; set; }
        [Required]
        [StringLength(80,ErrorMessage ="muy largo tu nombre bro",MinimumLength = 5)]
        public string Name { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true,DataFormatString = "{0;DD/MM/YYYY}")]

        public DateTime Birthday { get; set; }
        public SexoType Sex { get; set; }
    }
}