using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecettesAPI_HBKMAM.Models
{
	public class IngredientAmount
	{
		[ForeignKey("Id_Ingredient")]
		public int Id_Ingredient { get; set; }
		public string Amount { get; set; }
	}
}
