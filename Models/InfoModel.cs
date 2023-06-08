#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace DojoSurveyValidation.Models;
public class Survey
{
    [Required(ErrorMessage = "is required")]
    [MinLength(2, ErrorMessage="Message must be at least 2 characters in length.")]
    public string Name { get; set; }

    [Required(ErrorMessage = "is required")]
    public string Location { get; set; }

    [Required(ErrorMessage = "is required")]
    public string Language { get; set; }

    [MinLength(20, ErrorMessage="Message must be at least 20 characters in length.")]
    public string? Comment { get; set; }
}