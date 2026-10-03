namespace GymManagementSystem.Models
{
    internal class Trainer
    {
        public int TrainerId { get; set; }
        public string Name { get; set; }
        public string Specialization { get; set; }

        public Trainer(int trainerId, string name, string specialization)
        {
            TrainerId = trainerId;
            Name = name;
            Specialization = specialization;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Trainer ID: {TrainerId} | Name: {Name} | Specialization: {Specialization}");
        }
    }
}