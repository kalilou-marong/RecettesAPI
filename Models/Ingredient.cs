using System.ComponentModel.DataAnnotations;

namespace RecettesAPI_HBKMAM.Models;

public class Ingredient
{
    [Key]
    public int Id_Ingredient { get; set; }
    public string Ingredient_name { get; set; }
    public string Photo_url_ingredient { get; set; }
}
