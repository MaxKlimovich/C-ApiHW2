using WebApplication.Models.Base;

namespace WebApplication.Models;

public class Group : BaseModel
{
    public virtual List<Product> Products { get; set; } = null!;
        
}