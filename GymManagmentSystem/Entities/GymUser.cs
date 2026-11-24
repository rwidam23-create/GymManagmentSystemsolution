using GymManagmentSystem.Entities.Enums;

namespace GymManagmentSystem.Entities
{
    public class GymUser:BaseEntity
    {
        public string Name { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string Phone { get; set; } = default!;
        public DateOnly DateOfBirth { get; set; } = default!;
        public Gender Gender { get; set; } 
        public Address Address { get; set; } = default!;

    }
}
