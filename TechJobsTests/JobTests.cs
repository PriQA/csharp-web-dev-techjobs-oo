using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;



namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
       
       [TestInitialize]
       public void TestInitialize()
        {
          
        }

        [TestMethod]
        public void Test_1SettingJobId()
        {

            Job job_1 = new Job();
            Job job_2 = new Job();
            Assert.AreEqual(1, job_1.Id);
            Assert.AreEqual(1, job_2.Id - job_1.Id);
           
            Assert.IsFalse(job_1.Equals(job_2));

        }
        /*
        "Persistence" for JobCoreCompetency.
        Use Assert statements to test that the constructor correctly assigns the value of each field*/

        [TestMethod]
        public void Test_2JobConstructorSetsAllFields()
        {

           Employer employer = new Employer("ACME");
           Location location = new Location("Desert");
           PositionType positionType = new PositionType("Quality control");
           CoreCompetency competency = new CoreCompetency("Persistence");
           Job job = new Job("Product tester", employer, location, positionType, competency);
           Assert.AreEqual(3, job.Id);
           Assert.AreEqual("Product tester", job.Name); 
           Assert.AreEqual("ACME", job.EmployerName.Value);
           Assert.AreEqual("Desert", job.EmployerLocation.Value);
           Assert.AreEqual("Quality control", job.JobType.Value);
           Assert.AreEqual("Persistence", job.JobCoreCompetency.Value);

        }

        [TestMethod]
        public void Test_3JobsForEquality()
        {


            Job identicalJob_1 = new Job("Web Developer", new Employer("LaunchCode"), new Location("St. Louis"), new PositionType("Front-end developer"), new CoreCompetency("JavaScript"));
            Job identicalJob_2 = new Job("Web Developer", new Employer("LaunchCode"), new Location("St. Louis"), new PositionType("Front-end developer"), new CoreCompetency("JavaScript"));
            Assert.IsFalse(identicalJob_1.Equals(identicalJob_2));

        }

        [TestMethod]
        public void Test_4ToString()
        {

            Job  testJob= new Job("QA", new Employer("MasterCard"), new Location("Atlanta"), new PositionType("Automation Testing"), new CoreCompetency("Java"));
            string expectedOutput = $"\nID: {testJob.Id}\n" +
                $"Name: {testJob.Name}\n" +
                $"Employer: {testJob.EmployerName}\n" +
                $"Location: {testJob.EmployerLocation}\n" +
                $"Position Type: {testJob.JobType}\n" +
                $"Core Competency: {testJob.JobCoreCompetency}\n";
            Assert.AreEqual(expectedOutput, testJob.ToString());
        }

        [TestMethod]
        public void Test_5ToStringWhenDataNotAvailable()
        {

            Job jobWithNoPositionType = new Job("Sr. Software Developer", new Employer("Bayer"), new Location("Dallas"), new PositionType(""), new CoreCompetency("C#"));
            string expectedOutput = $"\nID: {jobWithNoPositionType.Id}\n" +
                $"Name: {jobWithNoPositionType.Name}\n" +
                $"Employer: {jobWithNoPositionType.EmployerName}\n" +
                $"Location: {jobWithNoPositionType.EmployerLocation}\n" +
                $"Position Type: Data not available\n" +
                $"Core Competency: {jobWithNoPositionType.JobCoreCompetency}\n";
            Assert.AreEqual(expectedOutput, jobWithNoPositionType.ToString());
        }

        [TestMethod]
        public void Test_6ToStringWhenDataNotAvailable()
        {

            Job jobWithNoLocation = new Job("Sr. Software Developer", new Employer("Bayer"), new Location(""), new PositionType("Web Developer"), new CoreCompetency("C#"));
            string expectedOutput = $"\nID: {jobWithNoLocation.Id}\n" +
                $"Name: {jobWithNoLocation.Name}\n" +
                $"Employer: {jobWithNoLocation.EmployerName}\n" +
                $"Location: Data not available\n" +
                $"Position Type: {jobWithNoLocation.JobType}\n" +
                $"Core Competency: {jobWithNoLocation.JobCoreCompetency}\n";
            Assert.AreEqual(expectedOutput, jobWithNoLocation.ToString());
        }


        [TestMethod]
        public void Test_7ToStringForZeroArgumentConstructor()
        {

            Job jobWithOnlyID = new Job();
            
            Assert.AreEqual("OOPS! This job does not seem to exist.", jobWithOnlyID.ToString());
        }
    }

}

