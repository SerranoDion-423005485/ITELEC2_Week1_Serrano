
public class JobPosting
{
    // Properties
    public string JobTitle { get; }
    public string ClientName { get; }
    public decimal Budget { get; }
    public bool IsOpen { get; private set; }

    // Constructor
    public JobPosting(string jobTitle, string clientName, decimal budget)
    {
        JobTitle = jobTitle;
        ClientName = clientName;
        Budget = budget;
        IsOpen = true;
    }

    // Method 1: Close the job posting
    public void CloseJob()
    {
        IsOpen = false;
    }

    // Method 2: Check if students can apply
    public bool TryApply()
    {
        if (!IsOpen)
        {
            return false;
        }

        return true;
    }
}
