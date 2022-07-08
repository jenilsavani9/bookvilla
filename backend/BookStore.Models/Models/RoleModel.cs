using BookStore.Models.DataModels;

namespace BookStore.Models.Models
{
    public class RoleModel
    {
        public RoleModel(Role role) { }
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
