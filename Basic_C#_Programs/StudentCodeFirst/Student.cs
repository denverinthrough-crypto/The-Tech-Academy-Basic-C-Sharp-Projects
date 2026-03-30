using System;
using System.Collections.Generic;
using System.Text;

namespace StudentCodeFirst
{
    // This class represents a single row in the Students table
    // EF Core will use this class to generate the table structure in SQL Server
    public class Student
    {
        // EF Core automatically treats a property named [ClassName]Id as the Primary Key
        // SQl Server will auto-increment this value
        public int StudentId { get; set; }

        public string StudentName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public decimal Height { get; set; } 
        public float weight { get; set; }

        // These properties become columns in the Students table
        // The property type determines the SQL column type:
        // string = NVARCHAR(MAX)
        // DateTime = DATETIME2
        // decimal = DECIMAL(18,2)
        // float = REAL



    }
}
