using GymManagementSystem.Models;

namespace GymManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ── Creating first member object ──────
            GymMember member1 = new GymMember();
            member1.MemberId = 1;
            member1.Name = "Rahul";
            member1.Age = 21;
            member1.MembershipType = "Premium";
            member1.MonthlyFee = 1500;
            member1.JoinDate = "01-Oct-2026";

            // ── Creating second member object ─────
            GymMember member2 = new GymMember();
            member2.MemberId = 2;
            member2.Name = "Amit";
            member2.Age = 25;
            member2.MembershipType = "Basic";
            member2.MonthlyFee = 800;
            member2.JoinDate = "01-Oct-2026";

            // ── Display both members ──────────────
            member1.DisplayInfo();
            member2.DisplayInfo();
        }
    }
}