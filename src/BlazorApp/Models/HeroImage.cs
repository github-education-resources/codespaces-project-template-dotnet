namespace BlazorApp.Models
{
    public class HeroImage
    {
        public virtual string Name { get; set; } = string.Empty;
        public virtual string Src { get; set; } = string.Empty;
        public virtual string Alt { get; set; } = string.Empty;
    }
}