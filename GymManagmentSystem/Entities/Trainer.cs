using GymManagmentSystem.Entities.Enums;

namespace GymManagmentSystem.Entities
{
    public class Trainer:GymUser
    {
        public DateTime HireDate {  get; set; }
        public Specialties Specialties { get; set; }
        public ICollection<Session> Sessions { get; set; }=new HashSet<Session>();
    }
}
