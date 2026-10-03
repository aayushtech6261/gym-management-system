using GymManagementSystem.Models;

namespace GymManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // --- Members List ---
            List<GymMember> members = new List<GymMember>();
            members.Add(new GymMember(1, "Rahul", 21, "Premium", 1500, "01-Oct-2026"));
            members.Add(new GymMember(2, "Amit", 25, "Basic", 800, "01-Oct-2026"));
            members.Add(new GymMember(3, "Priya", 22, "VIP", 2500, "01-Oct-2026"));

            // --- Display All Members ---
            Console.WriteLine("=== ALL MEMBERS ===");
            foreach (var member in members)
            {
                member.DisplayInfo();
            }

            // --- Search Member by ID ---
            Console.WriteLine("\nEnter Member ID to search:");
            int searchId = int.Parse(Console.ReadLine());
            GymMember found = members.Find(m => m.MemberId == searchId);

            if (found != null)
            {
                Console.WriteLine("Member Found:");
                found.DisplayInfo();
            }
            else
            {
                Console.WriteLine("Member not found.");
            }

            // --- Trainer ---
            Console.WriteLine("\n=== TRAINER ===");
            Trainer trainer1 = new Trainer(1, "Vikram", "Weight Training");
            trainer1.DisplayInfo();
        }
    }
}