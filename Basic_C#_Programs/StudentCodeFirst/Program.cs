using Microsoft.EntityFrameworkCore;
using StudentCodeFirst;


// The "using" block here safely opens and closes the database conenction
// When the block finishes, it automatically disposes (cleans up) the context
using (var context = new SchoolContext())
{
    // EnsureCreate() checks if SchoolDB exists on SQL Server
    // If it doesn't exist yet, EF Core creates the database and all tables
    // If it already exists, this lien is simply skipped
    context.Database.EnsureCreated();


    // Create a new Student object in memory
    // 5.7m = the "m" means decimal
    // 65.5f = the "f" means float
    // Both must match the types defined in Student.cs

    var student = new Student()
    {
        //
        StudentName = "Bill",
        DateOfBirth = new DateTime(1990, 1, 1),
        Height = 5.7m,
        weight = 65.5f
    };

    // Stage the student to be inserted
    context.Students.Add(student);

    // SaveChanges() fires the actual INSERT SQL query to the database
    context.SaveChanges();


    // Confirm it worked in the console
    Console.WriteLine("Student added successfully!");
    Console.WriteLine($"Student ID: {student.StudentId}, Name: {student.StudentName}");
}


