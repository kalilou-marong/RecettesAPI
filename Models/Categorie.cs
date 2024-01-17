using System.ComponentModel.DataAnnotations;

namespace RecettesAPI_HBKMAM.Models;

public class Categorie
{
    [Key]
    public int Id_categorie { get; set; }
    public string Name { get; set; }
    public string Photo_url { get; set; }

}
