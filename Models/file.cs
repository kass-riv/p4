using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using p4.Models;


namespace p4.Models{


[Table("t_file")]
    public class file{

    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int ID { get; set; }


    [Required(ErrorMessage = "Por favor ingrese Nombre")]
    [Display(Name = "Nombre")]
     public string Name { get; set; }
    
    
    [Required(ErrorMessage = "Please enter Image Name")]
    
    public String ImagenName { get; set; }

    public string Comentario{ get; set; }
   

    
}


}
