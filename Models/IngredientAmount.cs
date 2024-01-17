using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecettesAPI_HBKMAM.Models
{
	public class IngredientAmount
	{

		[Key]
		public int Id_IngredientRecipe { get; set; }

		
		[ForeignKey("Ingredient")]
		public int Id_Ingredient { get; set; }
		

		[ForeignKey("Recipe")]
		public int Id_Recipe { get; set; }

		public string Amount { get; set; }
	}
}
