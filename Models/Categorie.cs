using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace RecettesAPI_HBKMAM.Models;

public class Categorie
{
    [Key]

	public int Id_categorie { get; set; }


	public string name { get; set; }


	public string photo_url { get; set; }

}
