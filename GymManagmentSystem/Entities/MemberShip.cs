namespace GymManagmentSystem.Entities
{
    public class MemberShip:BaseEntity
    {
        public DateTime StartDate {  get; set; }
        public DateTime EndDate { get; set; }
        public int MemberId {  get; set; }
        public Member Member { get; set; } = default!;
        public int PlanId { get; set; }
        public Plan Plan { get; set; } = default!;
        public string Status => StartDate > DateTime.Now ? "UPComing" : EndDate > DateTime.Now ? "Active" : "Expired";
    }
}
