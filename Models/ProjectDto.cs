namespace personal_portfolio_v2.Models;

public class ProjectDto
{
    public string Slug { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Subtitle { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;
    public string ImageAlt { get; set; } = string.Empty;
    public List<string> Badges { get; set; } = new();
    public List<string> Tags { get; set; } = new();
    public string ViewUrl { get; set; } = string.Empty;
}
