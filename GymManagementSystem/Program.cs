using GymManagementSystem.Models;

namespace GymManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ── Using Constructor — ONE clean line each! ──
            GymMember member1 = new GymMember(1, "Rahul", 21, "Premium", 1500, "01-Oct-2026");
            GymMember member2 = new GymMember(2, "Amit", 25, "Basic", 800, "01-Oct-2026");
            GymMember member3 = new GymMember(3, "Priya", 22, "VIP", 2500, "01-Oct-2026");

            // ── Display all members ──────────────────────
            member1.DisplayInfo();
            member2.DisplayInfo();
            member3.DisplayInfo();
        }
    }
}