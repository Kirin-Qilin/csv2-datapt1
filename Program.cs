using System;
using System.Linq;

class Program
{

    // public static Dictionary<string, List<students>> arrayDictionary()//top ten assignments i never want to do again twin
    // {
    //     Dictionary<string, List<students>> d = new Dictionary<string, List<students>>();
    //     string filePath = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory + "\\Attendence.csv");
    //     using StreamReader sr = new StreamReader(filePath);
    //     sr.ReadLine();
    //     string[] column;
    //     List<string[]> listOfArray = new List<string[]>();
    //     string? line = sr.ReadLine();
    //     while ((line = sr.ReadLine()) != null)
    //     {
    //         column = line.Split(",");
    //         students test1 = new students(column[0], column[1], column[2], column[3], column[4]);
    //         if (d.ContainsKey(column[1]))
    //         {

    //             d[column[1]].Add(test1);

    //         }

    //         else
    //         {
    //             List<students> testList2 = new List<students>();
    //             testList2.Add(test1);
    //             d.Add(test1.studentID, testList2);

    //         }
    //     }
    //     sr.Close();
    //     return d;
    // }

    // public static void DisplayOne(Dictionary<string, List<students>> list)
    // {
    //     foreach (KeyValuePair<string, List<students>> studentData in list)
    //     {
    //         string ID = studentData.Key;
    //         List<students> testList = studentData.Value;
    //         string names = testList[0].name;
    //         Console.WriteLine("ID Number:" + ID);
    //         Console.WriteLine("Student Name: " + names);
    //         Console.WriteLine("{0, -15} {1,-15}{2,-15}", "Data", "Course", "Event");
    //         foreach (students student in testList)
    //         {
    //             Console.WriteLine("{0,-15}{1,-15}{2,-15}", student.date, student.course, student.events);
    //         }
    //         Console.WriteLine();
    //     }
    // }

    // public static void DisplayTwo(Dictionary<string, List<students>> list)
    // {
    //     Console.WriteLine("{0, -15}{1,-15}{2,-15}{3,-15}", "Student ID", "Student Name", "Absences", "Tardies");
    //     Console.WriteLine("{0,-15}{1,-15}{2,-15}{3,-15}", "---------", "---------", "---------", "---------");
    //     foreach (KeyValuePair<string, List<students>> student in list)
    //     {
    //         string ID = student.Key;
    //         string names = student.Value[0].name;
    //         int absences = 0;
    //         int tardies = 0;
    //         foreach (students children in student.Value)
    //         {
    //             if (children.events.Equals("Absent"))
    //                 absences++;
    //             else if (children.events.Equals("Tardy"))
    //                 tardies++;
    //         }
    //         Console.WriteLine("{0,-15}{2,-15}{2,-15}{3,-15}", ID, names, absences, tardies);
    //     }
    // }

    public static List<UserRecord> Read(String filePath)
    {
        // Dictionary<string, List<students>> d = new Dictionary<string, List<students>>();
        List<UserRecord> WhyAmIDoingThis = new List<UserRecord>();
        string totallynotfilePath = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory + "\\OGE.csv.csv");
        using StreamReader sr = new StreamReader(filePath);
        {
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string[] hehehehehe = line.Split(',');
                UserRecord heherecordhehehe = new UserRecord(hehehehehe[0], hehehehehe[1], hehehehehe[2], hehehehehe[3], hehehehehe[4] == "TRUE", hehehehehe[5], hehehehehe[6] == "TRUE", hehehehehe[7], hehehehehe[8], hehehehehe[9], hehehehehe[10], hehehehehe[11], hehehehehe[12]);
                WhyAmIDoingThis.Add(heherecordhehehe);
            }
   
        }
        return WhyAmIDoingThis;
        
    }





    static void Main(string[] args)
    {

        // Dictionary<string, List<students>> SuperAwesomeSauceArray = arrayDictionary();
        // try
        // {
        //     // DisplayOne(SuperAwesomeSauceArray);
        //     // DisplayTwo(SuperAwesomeSauceArray);
        // }
        // catch (Exception e)
        // {
        //     Console.WriteLine(e + "is not a Super Awesome Sauce Array");
        // }

        //UserRecord read = new UserRecord();
        List<UserRecord> usershehehe = Read("OGE.csv.csv");

        Console.WriteLine("row maxxing " + usershehehe.Count);

        List<UserRecord> WhyAmIDoingThis = new List<UserRecord>();
        var inactiveRecords = WhyAmIDoingThis
        .Where(r => r.cloudLifecycleState == false)
        .ToList();

        foreach (var why in inactiveRecords)
        {
            Console.WriteLine($"Name: {why.displayName}, Active: {why.cloudLifecycleState}");
        }

        Console.WriteLine($"\nNumber of inactive records: {inactiveRecords.Count}");

    }

    

}

public struct UserRecord
{
    public UserRecord(
        string displayName,
        string firstName,
        string lastName,
        string workEmail,
        bool cloudLifecycleState,
        string identityId,
        bool isManager,
        string department,
        string jobTitle,
        string access1Type,
        string access1Source,
        string access1DisplayName,
        string access1Description)
    {
        this.displayName = displayName;
        this.firstName = firstName;
        this.lastName = lastName;
        this.workEmail = workEmail;
        this.cloudLifecycleState = cloudLifecycleState;
        this.identityId = identityId;
        this.isManager = isManager;
        this.department = department;
        this.jobTitle = jobTitle;
        this.access1Type = access1Type;
        this.access1Source = access1Source;
        this.access1DisplayName = access1DisplayName;
        this.access1Description = access1Description;
    }

    public string displayName { get; set; }
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string workEmail { get; set; }
    public bool cloudLifecycleState { get; set; }
    public string identityId { get; set; }
    public bool isManager { get; set; }
    public string department { get; set; }
    public string jobTitle { get; set; }
    public string access1Type { get; set; }
    public string access1Source { get; set; }
    public string access1DisplayName { get; set; }
    public string access1Description { get; set; }
}
// public struct students
// {


//     public students(string date, string studentID, string name, string course, string events)
//     {
//         this.date = date;
//         this.studentID = studentID;
//         this.name = name;
//         this.course = course;
//         this.events = events;

//     }
//     public string date { get; set; }
//     public string studentID { get; set; }
//     public string name { get; set; }
//     public string course { get; set; }
//     public string events { get; set; }




// }
