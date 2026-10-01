namespace GymManagementSystem.Models
{
    internal class GymMember
    {
        // ── Properties ──────────────────────────
        public int MemberId;
        public string Name;
        public int Age;
        public string MembershipType;
        public double MonthlyFee;
        public string JoinDate;

        // ── Method: Display Member Info ──────────
        public void DisplayInfo()
        {
            Console.WriteLine("================================");
            Console.WriteLine("Member ID   : " + MemberId);
            Console.WriteLine("Name        : " + Name);
            Console.WriteLine("Age         : " + Age);
            Console.WriteLine("Membership  : " + MembershipType);
            Console.WriteLine("Monthly Fee : Rs." + MonthlyFee);
            Console.WriteLine("Join Date   : " + JoinDate);
            Console.WriteLine("================================");
        }
    }
}