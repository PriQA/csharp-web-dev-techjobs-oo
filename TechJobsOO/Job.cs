using System;
namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.

        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }
        // TODO: Generate Equals() and GetHashCode() methods.
        public override bool Equals(object obj)
        {
            return obj is Job job &&
            Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
         

        public override string ToString()
        {
            if(Name == null && EmployerName == null && EmployerLocation == null && JobType == null && JobCoreCompetency == null)
            {
                return "OOPS! This job does not seem to exist.";
            }

                
                return $"\nID: {Id}\n" +
                (Name == "" ? "Name: Data not available\n" : $"Name: {Name}\n") +
                (EmployerName.Value == "" ? "Employer: Data not available\n" : $"Employer: {EmployerName}\n") +
                (EmployerLocation.Value == "" ? "Location: Data not available\n" : $"Location: {EmployerLocation}\n") +
                (JobType.Value == "" ? "Position Type: Data not available\n" : $"Position Type: {JobType}\n")+
                (JobCoreCompetency.Value == "" ? "Core Competency: Data not available\n" : $"Core Competency: {JobCoreCompetency}\n");
        }
       
    }
}
