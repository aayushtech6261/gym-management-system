namespace GymManagementSystem.Models
{
    internal class GymMember
    {
        // ── Properties ──────────────────────────────
        public int MemberId;
        public string Name = string.Empty;
        public int Age;
        public string MembershipType = string.Empty;
        public double MonthlyFee;
        public string JoinDate = string.Empty;

        // ── Constructor ──────────────────────────────
        public GymMember(int memberId, string name, int age,
                         string membershipType, double monthlyFee,
                         string joinDate)
        {
            MemberId = memberId;
            Name = name;
            Age = age;
            MembershipType = membershipType;
            MonthlyFee = monthlyFee;
            JoinDate = joinDate;
        }

        // ── Method: Display Member Info ───────────────
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