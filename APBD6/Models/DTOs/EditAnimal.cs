namespace DefaultNamespace;

public class EditAnimal
{
    [Required]
    public string Name { get; set; }
    public string? Description { get; set; }
    [Required]
    public string Category { get; set; }
    [Required]
    public string Area { get; set; }
}