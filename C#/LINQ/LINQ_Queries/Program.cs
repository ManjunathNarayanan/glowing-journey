using LINQ_Queries;

IList<Student> studentList = new List<Student>() {
    new Student() { StudentID = 1, StudentName = "John", Age = 18, StandardID = 1 } ,
    new Student() { StudentID = 2, StudentName = "Steve",  Age = 21, StandardID = 1 } ,
    new Student() { StudentID = 3, StudentName = "Bill",  Age = 18, StandardID = 2 } ,
    new Student() { StudentID = 4, StudentName = "Ram" , Age = 20, StandardID = 2 } ,
    new Student() { StudentID = 5, StudentName = "Ron" , Age = 21 }
};

IList<Standard> standardList = new List<Standard>() {
    new Standard(){ StandardID = 1, StandardName="Standard 1"},
    new Standard(){ StandardID = 2, StandardName="Standard 2"},
    new Standard(){ StandardID = 3, StandardName="Standard 3"}
};


//SELECT and WHERE operators
Console.WriteLine("\r\n1. Returns all students with age > 18 AND standardID > 0"); 
var studentNames = studentList.Where(s => s.Age > 18).Select(s => s).Where(st => st.StandardID > 0).Select(s => s.StudentName);

studentNames.ToList().ForEach(s => Console.WriteLine(s));

Console.WriteLine("\r\n2.Teen Students with Age > 12 and < 20");
var teenStudents = from s in studentList
                   where s.Age > 12 && s.Age < 20
                   select new
                   {
                       StudentName = s.StudentName,
                       Age = s.Age,
                   };

teenStudents.ToList().ForEach(s => Console.WriteLine(s.StudentName + " is " + s.Age + " years old!" ));


Console.WriteLine("\r\n3.list students group by StandardID");
var studentsGroupByStandard = from s in studentList
                              group s by s.StandardID into sg
                              orderby sg.Key
                              select new
                              {
                                  sg.Key,
                                  sg
                              };

foreach(var group in studentsGroupByStandard)
{
    Console.WriteLine($"StandrdID {group.Key}");

    group.sg.ToList().ForEach(st => Console.WriteLine(st.StudentName));
}

Console.WriteLine("\r\nUse left outer join to display students under each standard. Display the standard name even if there is no student assigned to that standard.");
var studentsGroup = from standard in standardList
                    join student in studentList
                    on standard.StandardID equals student.StandardID
                    into sg
                    select new
                    {
                        standardName = standard.StandardName,
                        students = sg
                    };

foreach(var group in studentsGroup)
{
    Console.WriteLine(group.standardName);
    group.students.ToList().ForEach(st => Console.WriteLine(st.StudentName));
}

Console.WriteLine("\r\ninner Join to display students belonging to each standard");
var studentsWithStandard = from s in studentList
                           join standard in standardList
                           on s.StandardID equals standard.StandardID
                           select new
                           {
                               studentName = s.StudentName,
                               standardName = standard.StandardName
                           };

studentsWithStandard.ToList().ForEach(s => Console.WriteLine($"{s.studentName} is in {s.standardName}"));