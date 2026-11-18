
var job1 = new JobPosting(
    "Website Developer",
    "ABC Company",
    15000m
);

var job2 = new JobPosting(
    "Graphic Designer",
    "XYZ Company",
    10000m
);

Console.WriteLine("=== STUDENT FREELANCE MARKETPLACE ===");

Console.WriteLine("\nJob 1: " + job1.JobTitle);
Console.WriteLine("Client: " + job1.ClientName);
Console.WriteLine("Budget: " + job1.Budget);

Console.WriteLine("\nApplying to Job 1:");
Console.WriteLine(job1.TryApply());

job1.CloseJob();

Console.WriteLine("\nApplying to Job 1 after closing:");
Console.WriteLine(job1.TryApply());

Console.WriteLine("\nApplying to Job 2:");
Console.WriteLine(job2.TryApply());

