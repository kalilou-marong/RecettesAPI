using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecettesAPI_HBKMAM.Models;

public class Recipe
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id_Recipe { get; set; }

    [ForeignKey("Id_categorie")]
	public int Id_categorie { get; set; }
	public string Photo_url { get; set; }
    public List<string> Photo_array { get; set; }

	public string Time { get; set; }

	public List<IngredientAmount> Ingredients { get; set; }

    public string Description { get; set; }

	[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime Created_at { get; set; }

}
