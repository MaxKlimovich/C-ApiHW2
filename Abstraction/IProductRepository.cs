using WebApplication.Models;
using WebApplication.Models.DTO;
using WebApplication.Models.DTO;

namespace WebApplication.Abstraction
{

    public interface IProductRepository
    {
        public int AddGroup(GroupDto group);

        public IEnumerable<GroupDto> GetGroups();

        public int AddProduct(ProbuctDto product);

        public IEnumerable<ProbuctDto> GetProducts();

    }
}
