//using EFCoreWithConsoleApp.Contexts;
//using EFCoreWithConsoleApp.Entities;
//using Microsoft.EntityFrameworkCore;
//using System.Diagnostics.Metrics;
//using System.Linq.Expressions;
//using System.Numerics;


//using var context = new UniversityDbContext();


////Insert Students and Teachers 

//var users = new List<User>
//{
//    new User { FirstName = "Sami", LastName = "Hijazi", EmailAdress = "samihijazi@test.com", PhoneNumber = "5300000011", Role = "Teacher" },
//    new User { FirstName = "Feryal", LastName = "Tulaimat", EmailAdress = "feryaltulaimat@test.com", PhoneNumber = "5300000003", Role = "Teacher" },
//    new User { FirstName = "Abdelhake", LastName = "Hamdaoui", EmailAdress = "abdelhakehamdaoui@test.com", PhoneNumber = "5378527466", Role = "Student" },
//    new User { FirstName = "Houzifa", LastName = "Habbo", EmailAdress = "houzifahabbo@test.com", PhoneNumber = "5300560001", Role = "Student" },
//    new User { FirstName = "Aya", LastName = "Khalifa", EmailAdress = "ayakhalifa@test.com", PhoneNumber = "5300000001", Role = "Student" },
//    new User { FirstName = "Farah", LastName = "Silk", EmailAdress = "farahsilk@test.com", PhoneNumber = "5300000002", Role = "Student" },
//    new User { FirstName = "Masa", LastName = "Soudan", EmailAdress = "masasoudan@test.com", PhoneNumber = "5300000007", Role = "Student" },
//    new User { FirstName = "Mohammad", LastName = "Ramez", EmailAdress = "mohammadramez@test.com", PhoneNumber = "5300000008", Role = "Student" },
//    new User { FirstName = "Mosa", LastName = "Mosa", EmailAdress = "mosamosa@test.com", PhoneNumber = "5300000009", Role = "Student" },
//    new User { FirstName = "Nouhad", LastName = "El Hallab", EmailAdress = "nouhadelhallab@test.com", PhoneNumber = "5300000010", Role = "Student" },
//    new User { FirstName = "Sham", LastName = "Jamous", EmailAdress = "shamjamous@test.com", PhoneNumber = "5300000012", Role = "Student" },
//    new User { FirstName = "Yasin", LastName = "Yildiz", EmailAdress = "yasinyildiz@test.com", PhoneNumber = "5300000013", Role = "Student" },
//    new User { FirstName = "Zaid", LastName = "Almoughrabl", EmailAdress = "zaidalmoughrabl@test.com", PhoneNumber = "5300000014", Role = "Student" },
//    new User { FirstName = "Zomorodah", LastName = "Bakhit", EmailAdress = "zomorodahbakhit@test.com", PhoneNumber = "5300000015", Role = "Student" }
//};


//context.Users.AddRange(users);
//context.SaveChanges();


////Insert Syllabus

//var syllabus = new List<Syllabus>
//{
//    new Syllabus {Description = "This course introduces students to the fundamentals of SQL, including data definition, data manipulation, and query techniques. Learners will gain hands-on experience writing SELECT, INSERT, UPDATE, and DELETE statements, understanding relational database design, and working with JOINs, aggregate functions, and subqueries."},
//    new Syllabus {Description = "This course provides a comprehensive introduction to C#, covering object-oriented programming concepts such as classes, inheritance, interfaces, and exception handling. Students will build practical console applications and explore the use of C# in modern software development, including memory management and LINQ."},
//    new Syllabus {Description = "In this course, students will learn how to interact with databases using Entity Framework Core. The course covers model creation, migrations, querying with LINQ, and handling relationships and constraints. It emphasizes code-first and database-first approaches and demonstrates best practices for managing data access layers in .NET applications."},
//    new Syllabus {Description = "This course focuses on building RESTful web services using ASP.NET Core Web API. Students will learn how to create controllers, define endpoints, handle HTTP methods, and manage authentication and authorization. The course also introduces JSON serialization, versioning, and API documentation using Swagger.\r\n"},
//    new Syllabus {Description = "This course offers an in-depth look at building modern web applications using React. Topics include JSX, components, state management, props, hooks, and routing. By the end of the course, students will be able to create dynamic, single-page applications and understand how React integrates with APIs and backend services."}
//};


//context.Syllabus.AddRange(syllabus);
//context.SaveChanges();


////Insert Course
//var courses = new List<Course>
//{
//    new Course
//    {
//        Name = "SQL",
//        TeacherId = 1,
//        StartDate = new DateTime(2025, 7, 1),
//        EndDate = new DateTime(2025, 8, 1),
//        SyllabusId = 1
//    },
//    new Course
//    {
//        Name = "C#",
//        TeacherId = 1,
//        StartDate = new DateTime(2025, 7, 5),
//        EndDate = new DateTime(2025, 8, 15),
//        SyllabusId = 2
//    },
//    new Course
//    {
//        Name = "Entity Framework",
//        TeacherId = 1,
//        StartDate = new DateTime(2025, 7, 10),
//        EndDate = new DateTime(2025, 8, 20),
//        SyllabusId = 3
//    },
//    new Course
//    {
//        Name = "Web API",
//        TeacherId = 2,
//        StartDate = new DateTime(2025, 7, 12),
//        EndDate = new DateTime(2025, 8, 25),
//        SyllabusId = 4
//    },
//    new Course
//    {
//        Name = "React",
//        TeacherId = 2,
//        StartDate = new DateTime(2025, 8, 1),
//        EndDate = new DateTime(2025, 9, 15),
//        SyllabusId = 5
//    }
//};

//context.Courses.AddRange(courses);
//context.SaveChanges();

////Insert Assignment

//var assignments = new List<Assignment>
//{
//    new Assignment { CourseId = 1, AssignmentTitle = "SQL Basics Quiz", Description = "Covers SELECT, WHERE, and basic filtering.", Weight = 20.0f, MaxGrade = 20, DueDate = new DateTime(2025, 7, 8) },
//    new Assignment { CourseId = 1, AssignmentTitle = "Join Operations Task", Description = "Hands-on assignment about INNER JOIN, LEFT JOIN, etc.", Weight = 30.0f, MaxGrade = 30, DueDate = new DateTime(2025, 7, 18) },
//    new Assignment { CourseId = 1, AssignmentTitle = "SQL Final Project", Description = "Design a small database and run meaningful queries.", Weight = 50.0f, MaxGrade = 50, DueDate = new DateTime(2025, 7, 30) },
//    new Assignment { CourseId = 1, AssignmentTitle = "Aggregate Functions Quiz", Description = "Practice with COUNT, SUM, AVG, MIN, MAX.", Weight = 20.0f, MaxGrade = 20, DueDate = new DateTime(2025, 7, 10) },
//    new Assignment { CourseId = 1, AssignmentTitle = "Subquery Challenge", Description = "Solve problems using subqueries and nested SELECTs.", Weight = 30.0f, MaxGrade = 30, DueDate = new DateTime(2025, 7, 20) },
//    new Assignment { CourseId = 1, AssignmentTitle = "Normalization Task", Description = "Refactor tables to 3NF and explain design decisions.", Weight = 50.0f, MaxGrade = 50, DueDate = new DateTime(2025, 8, 1) },

//    new Assignment { CourseId = 2, AssignmentTitle = "C# Syntax and Basics", Description = "Covers variables, loops, and conditionals.", Weight = 25.0f, MaxGrade = 25, DueDate = new DateTime(2025, 7, 12) },
//    new Assignment { CourseId = 2, AssignmentTitle = "OOP in C#", Description = "Implement classes, inheritance, and polymorphism.", Weight = 35.0f, MaxGrade = 35, DueDate = new DateTime(2025, 7, 25) },
//    new Assignment { CourseId = 2, AssignmentTitle = "Mini C# App", Description = "Create a small console application using C#.", Weight = 40.0f, MaxGrade = 40, DueDate = new DateTime(2025, 8, 10) },
//    new Assignment { CourseId = 2, AssignmentTitle = "Arrays and Collections", Description = "Work with arrays, lists, dictionaries in C#.", Weight = 20.0f, MaxGrade = 20, DueDate = new DateTime(2025, 7, 15) },
//    new Assignment { CourseId = 2, AssignmentTitle = "Exception Handling Exercise", Description = "Handle runtime errors gracefully using try-catch.", Weight = 35.0f, MaxGrade = 35, DueDate = new DateTime(2025, 7, 28) },
//    new Assignment { CourseId = 2, AssignmentTitle = "LINQ Practice Task", Description = "Write LINQ queries on sample collections.", Weight = 40.0f, MaxGrade = 40, DueDate = new DateTime(2025, 8, 15) },

//    new Assignment { CourseId = 3, AssignmentTitle = "EF Core Basics", Description = "Setup DbContext, entities, and basic CRUD.", Weight = 30.0f, MaxGrade = 30, DueDate = new DateTime(2025, 7, 18) },
//    new Assignment { CourseId = 3, AssignmentTitle = "Relationships & Navigation Properties", Description = "Implement one-to-many and many-to-many relations.", Weight = 30.0f, MaxGrade = 30, DueDate = new DateTime(2025, 7, 29) },
//    new Assignment { CourseId = 3, AssignmentTitle = "Final EF Project", Description = "Create a small app using EF and real database.", Weight = 40.0f, MaxGrade = 40, DueDate = new DateTime(2025, 8, 18) },
//    new Assignment { CourseId = 3, AssignmentTitle = "EF Querying with LINQ", Description = "Perform filtering, ordering, and projection.", Weight = 25.0f, MaxGrade = 25, DueDate = new DateTime(2025, 7, 20) },
//    new Assignment { CourseId = 3, AssignmentTitle = "Migrations and Updates", Description = "Practice creating and applying migrations.", Weight = 35.0f, MaxGrade = 35, DueDate = new DateTime(2025, 8, 1) },
//    new Assignment { CourseId = 3, AssignmentTitle = "Seeding and Validation", Description = "Add seed data and validation rules to models.", Weight = 40.0f, MaxGrade = 40, DueDate = new DateTime(2025, 8, 20) },

//    new Assignment { CourseId = 4, AssignmentTitle = "REST API Basics", Description = "Create basic API with GET, POST, PUT, DELETE.", Weight = 30.0f, MaxGrade = 30, DueDate = new DateTime(2025, 7, 20) },
//    new Assignment { CourseId = 4, AssignmentTitle = "Authentication and Middleware", Description = "Implement JWT and custom middleware.", Weight = 30.0f, MaxGrade = 30, DueDate = new DateTime(2025, 8, 5) },
//    new Assignment { CourseId = 4, AssignmentTitle = "Final API Project", Description = "Develop a full CRUD Web API with EF Core integration.", Weight = 40.0f, MaxGrade = 40, DueDate = new DateTime(2025, 8, 22) },
//    new Assignment { CourseId = 4, AssignmentTitle = "Routing and Versioning", Description = "Implement attribute routing and API versioning.", Weight = 25.0f, MaxGrade = 25, DueDate = new DateTime(2025, 7, 22) },
//    new Assignment { CourseId = 4, AssignmentTitle = "Swagger & Documentation", Description = "Auto-generate and customize API docs.", Weight = 30.0f, MaxGrade = 30, DueDate = new DateTime(2025, 8, 7) },
//    new Assignment { CourseId = 4, AssignmentTitle = "API Testing Assignment", Description = "Test endpoints using Postman or Swagger.", Weight = 45.0f, MaxGrade = 45, DueDate = new DateTime(2025, 8, 25) },

//    new Assignment { CourseId = 5, AssignmentTitle = "React Fundamentals", Description = "JSX, props, and state basics.", Weight = 25.0f, MaxGrade = 25, DueDate = new DateTime(2025, 8, 10) },
//    new Assignment { CourseId = 5, AssignmentTitle = "Component & Hooks Practice", Description = "Use functional components and custom hooks.", Weight = 35.0f, MaxGrade = 35, DueDate = new DateTime(2025, 8, 25) },
//    new Assignment { CourseId = 5, AssignmentTitle = "React Final Project", Description = "Build a dynamic React app with routing and API calls.", Weight = 40.0f, MaxGrade = 40, DueDate = new DateTime(2025, 9, 10) },
//    new Assignment { CourseId = 5, AssignmentTitle = "React Forms & Validation", Description = "Create and validate forms using controlled components.", Weight = 25.0f, MaxGrade = 25, DueDate = new DateTime(2025, 8, 12) },
//    new Assignment { CourseId = 5, AssignmentTitle = "React Router Exercise", Description = "Implement navigation using React Router.", Weight = 35.0f, MaxGrade = 35, DueDate = new DateTime(2025, 8, 28) },
//    new Assignment { CourseId = 5, AssignmentTitle = "State Management Challenge", Description = "Use useReducer or a global state library.", Weight = 40.0f, MaxGrade = 40, DueDate = new DateTime(2025, 9, 12) }
//};

//context.Assignments.AddRange(assignments);
//context.SaveChanges();


////Insert Comments

//var comments = new List<Comment>
//{
//    new Comment { AssignmentId = 1, CreatedByUserId = 10, CreatedDate = new DateTime(2025, 7, 9), CommentContent = "Well done! Just improve the use of aliases." },
//    new Comment { AssignmentId = 3, CreatedByUserId = 10, CreatedDate = new DateTime(2025, 7, 10), CommentContent = "Try optimizing your JOIN statements for better performance." },
//    new Comment { AssignmentId = 5, CreatedByUserId = 10, CreatedDate = new DateTime(2025, 7, 11), CommentContent = "Add comments to explain complex queries." },
//    new Comment { AssignmentId = 7, CreatedByUserId = 10, CreatedDate = new DateTime(2025, 7, 13), CommentContent = "Excellent OOP usage in your solution." },
//    new Comment { AssignmentId = 9, CreatedByUserId = 10, CreatedDate = new DateTime(2025, 7, 14), CommentContent = "Great use of inheritance, but watch out for redundancy." },
//    new Comment { AssignmentId = 12, CreatedByUserId = 10, CreatedDate = new DateTime(2025, 7, 17), CommentContent = "Your API handles errors well. Keep it up!" },
//    new Comment { AssignmentId = 15, CreatedByUserId = 10, CreatedDate = new DateTime(2025, 7, 19), CommentContent = "Nice Swagger documentation. Very clear." },
//    new Comment { AssignmentId = 18, CreatedByUserId = 5, CreatedDate = new DateTime(2025, 7, 22), CommentContent = "Consider adding more seeding data for realism." },
//    new Comment { AssignmentId = 20, CreatedByUserId = 5, CreatedDate = new DateTime(2025, 7, 24), CommentContent = "Watch out for relationship naming conventions." },
//    new Comment { AssignmentId = 22, CreatedByUserId = 4, CreatedDate = new DateTime(2025, 7, 26), CommentContent = "Clean routing logic. I like your folder structure." },
//    new Comment { AssignmentId = 23, CreatedByUserId = 10, CreatedDate = new DateTime(2025, 7, 27), CommentContent = "Authentication is working well. Try adding refresh tokens." },
//    new Comment { AssignmentId = 25, CreatedByUserId = 6, CreatedDate = new DateTime(2025, 8, 1), CommentContent = "Try using React Context instead of prop drilling." },
//    new Comment { AssignmentId = 27, CreatedByUserId = 10, CreatedDate = new DateTime(2025, 8, 3), CommentContent = "Hooks are implemented correctly. Good job!" },
//    new Comment { AssignmentId = 28, CreatedByUserId = 3, CreatedDate = new DateTime(2025, 8, 4), CommentContent = "Routing works well. Try nested routes too." },
//    new Comment { AssignmentId = 30, CreatedByUserId = 8, CreatedDate = new DateTime(2025, 8, 6), CommentContent = "Final React app looks great! Well styled and functional." }
//};

//context.Comments.AddRange(comments);
//context.SaveChanges();



////Insert Grades

//var grades = new List<Grade>
//{
//    new Grade { AssignmentId = 1, StudentId = 3, Score = 71 },
//new Grade { AssignmentId = 1, StudentId = 4, Score = 63 },
//new Grade { AssignmentId = 1, StudentId = 5, Score = 78 },
//new Grade { AssignmentId = 1, StudentId = 6, Score = 61 },
//new Grade { AssignmentId = 1, StudentId = 7, Score = 79 },
//new Grade { AssignmentId = 1, StudentId = 8, Score = 82 },
//new Grade { AssignmentId = 1, StudentId = 9, Score = 98 },
//new Grade { AssignmentId = 1, StudentId = 10, Score = 79 },
//new Grade { AssignmentId = 1, StudentId = 11, Score = 51 },
//new Grade { AssignmentId = 1, StudentId = 12, Score = 51 },
//new Grade { AssignmentId = 2, StudentId = 3, Score = 88 },
//new Grade { AssignmentId = 2, StudentId = 4, Score = 88 },
//new Grade { AssignmentId = 2, StudentId = 5, Score = 74 },
//new Grade { AssignmentId = 2, StudentId = 6, Score = 60 },
//new Grade { AssignmentId = 2, StudentId = 7, Score = 95 },
//new Grade { AssignmentId = 2, StudentId = 8, Score = 88 },
//new Grade { AssignmentId = 2, StudentId = 9, Score = 82 },
//new Grade { AssignmentId = 2, StudentId = 10, Score = 60 },
//new Grade { AssignmentId = 2, StudentId = 11, Score = 52 },
//new Grade { AssignmentId = 2, StudentId = 12, Score = 89 },
//new Grade { AssignmentId = 3, StudentId = 3, Score = 80 },
//new Grade { AssignmentId = 3, StudentId = 4, Score = 79 },
//new Grade { AssignmentId = 3, StudentId = 5, Score = 83 },
//new Grade { AssignmentId = 3, StudentId = 6, Score = 62 },
//new Grade { AssignmentId = 3, StudentId = 7, Score = 97 },
//new Grade { AssignmentId = 3, StudentId = 8, Score = 62 },
//new Grade { AssignmentId = 3, StudentId = 9, Score = 81 },
//new Grade { AssignmentId = 3, StudentId = 10, Score = 91 },
//new Grade { AssignmentId = 3, StudentId = 11, Score = 53 },
//new Grade { AssignmentId = 3, StudentId = 12, Score = 92 },
//new Grade { AssignmentId = 4, StudentId = 3, Score = 82 },
//new Grade { AssignmentId = 4, StudentId = 4, Score = 99 },
//new Grade { AssignmentId = 4, StudentId = 5, Score = 72 },
//new Grade { AssignmentId = 4, StudentId = 6, Score = 74 },
//new Grade { AssignmentId = 4, StudentId = 7, Score = 57 },
//new Grade { AssignmentId = 4, StudentId = 8, Score = 61 },
//new Grade { AssignmentId = 4, StudentId = 9, Score = 63 },
//new Grade { AssignmentId = 4, StudentId = 10, Score = 87 },
//new Grade { AssignmentId = 4, StudentId = 11, Score = 97 },
//new Grade { AssignmentId = 4, StudentId = 12, Score = 67 },
//new Grade { AssignmentId = 5, StudentId = 3, Score = 86 },
//new Grade { AssignmentId = 5, StudentId = 4, Score = 66 },
//new Grade { AssignmentId = 5, StudentId = 5, Score = 51 },
//new Grade { AssignmentId = 5, StudentId = 6, Score = 59 },
//new Grade { AssignmentId = 5, StudentId = 7, Score = 80 },
//new Grade { AssignmentId = 5, StudentId = 8, Score = 55 },
//new Grade { AssignmentId = 5, StudentId = 9, Score = 77 },
//new Grade { AssignmentId = 5, StudentId = 10, Score = 52 },
//new Grade { AssignmentId = 5, StudentId = 11, Score = 59 },
//new Grade { AssignmentId = 5, StudentId = 12, Score = 72 },
//new Grade { AssignmentId = 6, StudentId = 3, Score = 83 },
//new Grade { AssignmentId = 6, StudentId = 4, Score = 58 },
//new Grade { AssignmentId = 6, StudentId = 5, Score = 84 },
//new Grade { AssignmentId = 6, StudentId = 6, Score = 92 },
//new Grade { AssignmentId = 6, StudentId = 7, Score = 85 },
//new Grade { AssignmentId = 6, StudentId = 8, Score = 50 },
//new Grade { AssignmentId = 6, StudentId = 9, Score = 98 },
//new Grade { AssignmentId = 6, StudentId = 10, Score = 58 },
//new Grade { AssignmentId = 6, StudentId = 11, Score = 86 },
//new Grade { AssignmentId = 6, StudentId = 12, Score = 72 },
//new Grade { AssignmentId = 7, StudentId = 3, Score = 56 },
//new Grade { AssignmentId = 7, StudentId = 4, Score = 74 },
//new Grade { AssignmentId = 7, StudentId = 5, Score = 65 },
//new Grade { AssignmentId = 7, StudentId = 6, Score = 99 },
//new Grade { AssignmentId = 7, StudentId = 7, Score = 97 },
//new Grade { AssignmentId = 7, StudentId = 8, Score = 51 },
//new Grade { AssignmentId = 7, StudentId = 9, Score = 55 },
//new Grade { AssignmentId = 7, StudentId = 10, Score = 97 },
//new Grade { AssignmentId = 7, StudentId = 11, Score = 73 },
//new Grade { AssignmentId = 7, StudentId = 12, Score = 72 },
//new Grade { AssignmentId = 8, StudentId = 3, Score = 69 },
//new Grade { AssignmentId = 8, StudentId = 4, Score = 89 },
//new Grade { AssignmentId = 8, StudentId = 5, Score = 62 },
//new Grade { AssignmentId = 8, StudentId = 6, Score = 60 },
//new Grade { AssignmentId = 8, StudentId = 7, Score = 85 },
//new Grade { AssignmentId = 8, StudentId = 8, Score = 65 },
//new Grade { AssignmentId = 8, StudentId = 9, Score = 54 },
//new Grade { AssignmentId = 8, StudentId = 10, Score = 75 },
//new Grade { AssignmentId = 8, StudentId = 11, Score = 53 },
//new Grade { AssignmentId = 8, StudentId = 12, Score = 58 },
//new Grade { AssignmentId = 9, StudentId = 3, Score = 57 },
//new Grade { AssignmentId = 9, StudentId = 4, Score = 80 },
//new Grade { AssignmentId = 9, StudentId = 5, Score = 90 },
//new Grade { AssignmentId = 9, StudentId = 6, Score = 78 },
//new Grade { AssignmentId = 9, StudentId = 7, Score = 74 },
//new Grade { AssignmentId = 9, StudentId = 8, Score = 65 },
//new Grade { AssignmentId = 9, StudentId = 9, Score = 54 },
//new Grade { AssignmentId = 9, StudentId = 10, Score = 57 },
//new Grade { AssignmentId = 9, StudentId = 11, Score = 55 },
//new Grade { AssignmentId = 9, StudentId = 12, Score = 68 },
//new Grade { AssignmentId = 10, StudentId = 3, Score = 85 },
//new Grade { AssignmentId = 10, StudentId = 4, Score = 69 },
//new Grade { AssignmentId = 10, StudentId = 5, Score = 55 },
//new Grade { AssignmentId = 10, StudentId = 6, Score = 92 },
//new Grade { AssignmentId = 10, StudentId = 7, Score = 50 },
//new Grade { AssignmentId = 10, StudentId = 8, Score = 77 },
//new Grade { AssignmentId = 10, StudentId = 9, Score = 64 },
//new Grade { AssignmentId = 10, StudentId = 10, Score = 61 },
//new Grade { AssignmentId = 10, StudentId = 11, Score = 94 },
//new Grade { AssignmentId = 10, StudentId = 12, Score = 80 },
//new Grade { AssignmentId = 11, StudentId = 3, Score = 78 },
//new Grade { AssignmentId = 11, StudentId = 4, Score = 99 },
//new Grade { AssignmentId = 11, StudentId = 5, Score = 77 },
//new Grade { AssignmentId = 11, StudentId = 6, Score = 88 },
//new Grade { AssignmentId = 11, StudentId = 7, Score = 65 },
//new Grade { AssignmentId = 11, StudentId = 8, Score = 100 },
//new Grade { AssignmentId = 11, StudentId = 9, Score = 64 },
//new Grade { AssignmentId = 11, StudentId = 10, Score = 58 },
//new Grade { AssignmentId = 11, StudentId = 11, Score = 59 },
//new Grade { AssignmentId = 11, StudentId = 12, Score = 56 },
//new Grade { AssignmentId = 12, StudentId = 3, Score = 82 },
//new Grade { AssignmentId = 12, StudentId = 4, Score = 60 },
//new Grade { AssignmentId = 12, StudentId = 5, Score = 85 },
//new Grade { AssignmentId = 12, StudentId = 6, Score = 93 },
//new Grade { AssignmentId = 12, StudentId = 7, Score = 51 },
//new Grade { AssignmentId = 12, StudentId = 8, Score = 69 },
//new Grade { AssignmentId = 12, StudentId = 9, Score = 65 },
//new Grade { AssignmentId = 12, StudentId = 10, Score = 92 },
//new Grade { AssignmentId = 12, StudentId = 11, Score = 87 },
//new Grade { AssignmentId = 12, StudentId = 12, Score = 74 },
//new Grade { AssignmentId = 13, StudentId = 3, Score = 64 },
//new Grade { AssignmentId = 13, StudentId = 4, Score = 74 },
//new Grade { AssignmentId = 13, StudentId = 5, Score = 76 },
//new Grade { AssignmentId = 13, StudentId = 6, Score = 52 },
//new Grade { AssignmentId = 13, StudentId = 7, Score = 79 },
//new Grade { AssignmentId = 13, StudentId = 8, Score = 52 },
//new Grade { AssignmentId = 13, StudentId = 9, Score = 89 },
//new Grade { AssignmentId = 13, StudentId = 10, Score = 77 },
//new Grade { AssignmentId = 13, StudentId = 11, Score = 83 },
//new Grade { AssignmentId = 13, StudentId = 12, Score = 62 },
//new Grade { AssignmentId = 14, StudentId = 3, Score = 93 },
//new Grade { AssignmentId = 14, StudentId = 4, Score = 56 },
//new Grade { AssignmentId = 14, StudentId = 5, Score = 64 },
//new Grade { AssignmentId = 14, StudentId = 6, Score = 97 },
//new Grade { AssignmentId = 14, StudentId = 7, Score = 73 },
//new Grade { AssignmentId = 14, StudentId = 8, Score = 70 },
//new Grade { AssignmentId = 14, StudentId = 9, Score = 100 },
//new Grade { AssignmentId = 14, StudentId = 10, Score = 72 },
//new Grade { AssignmentId = 14, StudentId = 11, Score = 95 },
//new Grade { AssignmentId = 14, StudentId = 12, Score = 55 },
//new Grade { AssignmentId = 15, StudentId = 3, Score = 53 },
//new Grade { AssignmentId = 15, StudentId = 4, Score = 80 },
//new Grade { AssignmentId = 15, StudentId = 5, Score = 99 },
//new Grade { AssignmentId = 15, StudentId = 6, Score = 89 },
//new Grade { AssignmentId = 15, StudentId = 7, Score = 86 },
//new Grade { AssignmentId = 15, StudentId = 8, Score = 59 },
//new Grade { AssignmentId = 15, StudentId = 9, Score = 92 },
//new Grade { AssignmentId = 15, StudentId = 10, Score = 66 },
//new Grade { AssignmentId = 15, StudentId = 11, Score = 60 },
//new Grade { AssignmentId = 15, StudentId = 12, Score = 57 },
//new Grade { AssignmentId = 16, StudentId = 3, Score = 71 },
//new Grade { AssignmentId = 16, StudentId = 4, Score = 54 },
//new Grade { AssignmentId = 16, StudentId = 5, Score = 66 },
//new Grade { AssignmentId = 16, StudentId = 6, Score = 94 },
//new Grade { AssignmentId = 16, StudentId = 7, Score = 77 },
//new Grade { AssignmentId = 16, StudentId = 8, Score = 79 },
//new Grade { AssignmentId = 16, StudentId = 9, Score = 63 },
//new Grade { AssignmentId = 16, StudentId = 10, Score = 92 },
//new Grade { AssignmentId = 16, StudentId = 11, Score = 78 },
//new Grade { AssignmentId = 16, StudentId = 12, Score = 85 },
//new Grade { AssignmentId = 17, StudentId = 3, Score = 73 },
//new Grade { AssignmentId = 17, StudentId = 4, Score = 69 },
//new Grade { AssignmentId = 17, StudentId = 5, Score = 76 },
//new Grade { AssignmentId = 17, StudentId = 6, Score = 55 },
//new Grade { AssignmentId = 17, StudentId = 7, Score = 54 },
//new Grade { AssignmentId = 17, StudentId = 8, Score = 82 },
//new Grade { AssignmentId = 17, StudentId = 9, Score = 67 },
//new Grade { AssignmentId = 17, StudentId = 10, Score = 81 },
//new Grade { AssignmentId = 17, StudentId = 11, Score = 87 },
//new Grade { AssignmentId = 17, StudentId = 12, Score = 61 },
//new Grade { AssignmentId = 18, StudentId = 3, Score = 53 },
//new Grade { AssignmentId = 18, StudentId = 4, Score = 81 },
//new Grade { AssignmentId = 18, StudentId = 5, Score = 55 },
//new Grade { AssignmentId = 18, StudentId = 6, Score = 92 },
//new Grade { AssignmentId = 18, StudentId = 7, Score = 66 },
//new Grade { AssignmentId = 18, StudentId = 8, Score = 74 },
//new Grade { AssignmentId = 18, StudentId = 9, Score = 95 },
//new Grade { AssignmentId = 18, StudentId = 10, Score = 50 },
//new Grade { AssignmentId = 18, StudentId = 11, Score = 84 },
//new Grade { AssignmentId = 18, StudentId = 12, Score = 57 },
//new Grade { AssignmentId = 19, StudentId = 3, Score = 52 },
//new Grade { AssignmentId = 19, StudentId = 4, Score = 81 },
//new Grade { AssignmentId = 19, StudentId = 5, Score = 86 },
//new Grade { AssignmentId = 19, StudentId = 6, Score = 82 },
//new Grade { AssignmentId = 19, StudentId = 7, Score = 59 },
//new Grade { AssignmentId = 19, StudentId = 8, Score = 99 },
//new Grade { AssignmentId = 19, StudentId = 9, Score = 67 },
//new Grade { AssignmentId = 19, StudentId = 10, Score = 59 },
//new Grade { AssignmentId = 19, StudentId = 11, Score = 90 },
//new Grade { AssignmentId = 19, StudentId = 12, Score = 72 },
//new Grade { AssignmentId = 20, StudentId = 3, Score = 84 },
//new Grade { AssignmentId = 20, StudentId = 4, Score = 78 },
//new Grade { AssignmentId = 20, StudentId = 5, Score = 50 },
//new Grade { AssignmentId = 20, StudentId = 6, Score = 54 },
//new Grade { AssignmentId = 20, StudentId = 7, Score = 81 },
//new Grade { AssignmentId = 20, StudentId = 8, Score = 79 },
//new Grade { AssignmentId = 20, StudentId = 9, Score = 69 },
//new Grade { AssignmentId = 20, StudentId = 10, Score = 79 },
//new Grade { AssignmentId = 20, StudentId = 11, Score = 76 },
//new Grade { AssignmentId = 20, StudentId = 12, Score = 74 },
//new Grade { AssignmentId = 21, StudentId = 3, Score = 95 },
//new Grade { AssignmentId = 21, StudentId = 4, Score = 76 },
//new Grade { AssignmentId = 21, StudentId = 5, Score = 100 },
//new Grade { AssignmentId = 21, StudentId = 6, Score = 69 },
//new Grade { AssignmentId = 21, StudentId = 7, Score = 54 },
//new Grade { AssignmentId = 21, StudentId = 8, Score = 87 },
//new Grade { AssignmentId = 21, StudentId = 9, Score = 99 },
//new Grade { AssignmentId = 21, StudentId = 10, Score = 96 },
//new Grade { AssignmentId = 21, StudentId = 11, Score = 64 },
//new Grade { AssignmentId = 21, StudentId = 12, Score = 83 },
//new Grade { AssignmentId = 22, StudentId = 3, Score = 69 },
//new Grade { AssignmentId = 22, StudentId = 4, Score = 65 },
//new Grade { AssignmentId = 22, StudentId = 5, Score = 100 },
//new Grade { AssignmentId = 22, StudentId = 6, Score = 83 },
//new Grade { AssignmentId = 22, StudentId = 7, Score = 90 },
//new Grade { AssignmentId = 22, StudentId = 8, Score = 59 },
//new Grade { AssignmentId = 22, StudentId = 9, Score = 58 },
//new Grade { AssignmentId = 22, StudentId = 10, Score = 71 },
//new Grade { AssignmentId = 22, StudentId = 11, Score = 53 },
//new Grade { AssignmentId = 22, StudentId = 12, Score = 67 },
//new Grade { AssignmentId = 23, StudentId = 3, Score = 68 },
//new Grade { AssignmentId = 23, StudentId = 4, Score = 86 },
//new Grade { AssignmentId = 23, StudentId = 5, Score = 94 },
//new Grade { AssignmentId = 23, StudentId = 6, Score = 53 },
//new Grade { AssignmentId = 23, StudentId = 7, Score = 52 },
//new Grade { AssignmentId = 23, StudentId = 8, Score = 74 },
//new Grade { AssignmentId = 23, StudentId = 9, Score = 60 },
//new Grade { AssignmentId = 23, StudentId = 10, Score = 88 },
//new Grade { AssignmentId = 23, StudentId = 11, Score = 65 },
//new Grade { AssignmentId = 23, StudentId = 12, Score = 68 },
//new Grade { AssignmentId = 24, StudentId = 3, Score = 61 },
//new Grade { AssignmentId = 24, StudentId = 4, Score = 78 },
//new Grade { AssignmentId = 24, StudentId = 5, Score = 86 },
//new Grade { AssignmentId = 24, StudentId = 6, Score = 62 },
//new Grade { AssignmentId = 24, StudentId = 7, Score = 95 },
//new Grade { AssignmentId = 24, StudentId = 8, Score = 53 },
//new Grade { AssignmentId = 24, StudentId = 9, Score = 64 },
//new Grade { AssignmentId = 24, StudentId = 10, Score = 93 },
//new Grade { AssignmentId = 24, StudentId = 11, Score = 85 },
//new Grade { AssignmentId = 24, StudentId = 12, Score = 79 },
//new Grade { AssignmentId = 25, StudentId = 3, Score = 100 },
//new Grade { AssignmentId = 25, StudentId = 4, Score = 95 },
//new Grade { AssignmentId = 25, StudentId = 5, Score = 86 },
//new Grade { AssignmentId = 25, StudentId = 6, Score = 75 },
//new Grade { AssignmentId = 25, StudentId = 7, Score = 70 },
//new Grade { AssignmentId = 25, StudentId = 8, Score = 54 },
//new Grade { AssignmentId = 25, StudentId = 9, Score = 93 },
//new Grade { AssignmentId = 25, StudentId = 10, Score = 62 },
//new Grade { AssignmentId = 25, StudentId = 11, Score = 74 },
//new Grade { AssignmentId = 25, StudentId = 12, Score = 57 },
//new Grade { AssignmentId = 26, StudentId = 3, Score = 92 },
//new Grade { AssignmentId = 26, StudentId = 4, Score = 88 },
//new Grade { AssignmentId = 26, StudentId = 5, Score = 94 },
//new Grade { AssignmentId = 26, StudentId = 6, Score = 74 },
//new Grade { AssignmentId = 26, StudentId = 7, Score = 58 },
//new Grade { AssignmentId = 26, StudentId = 8, Score = 70 },
//new Grade { AssignmentId = 26, StudentId = 9, Score = 62 },
//new Grade { AssignmentId = 26, StudentId = 10, Score = 60 },
//new Grade { AssignmentId = 26, StudentId = 11, Score = 92 },
//new Grade { AssignmentId = 26, StudentId = 12, Score = 92 },
//new Grade { AssignmentId = 27, StudentId = 3, Score = 63 },
//new Grade { AssignmentId = 27, StudentId = 4, Score = 55 },
//new Grade { AssignmentId = 27, StudentId = 5, Score = 55 },
//new Grade { AssignmentId = 27, StudentId = 6, Score = 78 },
//new Grade { AssignmentId = 27, StudentId = 7, Score = 65 },
//new Grade { AssignmentId = 27, StudentId = 8, Score = 81 },
//new Grade { AssignmentId = 27, StudentId = 9, Score = 97 },
//new Grade { AssignmentId = 27, StudentId = 10, Score = 90 },
//new Grade { AssignmentId = 27, StudentId = 11, Score = 82 },
//new Grade { AssignmentId = 27, StudentId = 12, Score = 91 },
//new Grade { AssignmentId = 28, StudentId = 3, Score = 68 },
//new Grade { AssignmentId = 28, StudentId = 4, Score = 97 },
//new Grade { AssignmentId = 28, StudentId = 5, Score = 75 },
//new Grade { AssignmentId = 28, StudentId = 6, Score = 60 },
//new Grade { AssignmentId = 28, StudentId = 7, Score = 96 },
//new Grade { AssignmentId = 28, StudentId = 8, Score = 58 },
//new Grade { AssignmentId = 28, StudentId = 9, Score = 86 },
//new Grade { AssignmentId = 28, StudentId = 10, Score = 60 },
//new Grade { AssignmentId = 28, StudentId = 11, Score = 80 },
//new Grade { AssignmentId = 28, StudentId = 12, Score = 63 },
//new Grade { AssignmentId = 29, StudentId = 3, Score = 70 },
//new Grade { AssignmentId = 29, StudentId = 4, Score = 97 },
//new Grade { AssignmentId = 29, StudentId = 5, Score = 58 },
//new Grade { AssignmentId = 29, StudentId = 6, Score = 70 },
//new Grade { AssignmentId = 29, StudentId = 7, Score = 85 },
//new Grade { AssignmentId = 29, StudentId = 8, Score = 67 },
//new Grade { AssignmentId = 29, StudentId = 9, Score = 96 },
//new Grade { AssignmentId = 29, StudentId = 10, Score = 81 },
//new Grade { AssignmentId = 29, StudentId = 11, Score = 98 },
//new Grade { AssignmentId = 29, StudentId = 12, Score = 69 },
//new Grade { AssignmentId = 30, StudentId = 3, Score = 61 },
//new Grade { AssignmentId = 30, StudentId = 4, Score = 97 },
//new Grade { AssignmentId = 30, StudentId = 5, Score = 50 },
//new Grade { AssignmentId = 30, StudentId = 6, Score = 66 },
//new Grade { AssignmentId = 30, StudentId = 7, Score = 67 },
//new Grade { AssignmentId = 30, StudentId = 8, Score = 66 },
//new Grade { AssignmentId = 30, StudentId = 9, Score = 94 },
//new Grade { AssignmentId = 30, StudentId = 10, Score = 61 },
//new Grade { AssignmentId = 30, StudentId = 11, Score = 86 },
//new Grade { AssignmentId = 30, StudentId = 12, Score = 80 },

//};

//context.Grades.AddRange(grades);
//context.SaveChanges();


//// ---------  QUERIES ----------------

//Console.WriteLine("List all courses");

//var courses2 = context.Courses.ToList();

//foreach (var course in courses2)
//{
//    Console.WriteLine($"{course.Name}");
//}

//Console.WriteLine("----------------------------------------------");
//Console.WriteLine("Show all assignments for a specific course");

//var assignments2 = context.Assignments.Where(x => x.CourseId == 3);


//foreach (var assignment in assignments2)
//{
//    Console.WriteLine($"{assignment.AssignmentTitle}");
//}

//Console.WriteLine("----------------------------------------------");
//Console.WriteLine("List all students");


//var students = context.Users.Where(x => x.Role == "Student");


//foreach (var student in students)
//{
//    Console.WriteLine($"{student.FirstName} {student.LastName}");
//}


//Console.WriteLine("----------------------------------------------");
//Console.WriteLine("Show all comments for a given assignment");

//var comments2 = context.Comments.Where(x => x.AssignmentId == 3);


//foreach (var comment2 in comments2)
//{
//    Console.WriteLine($"Content : {comment2.CommentContent}");
//}



//Console.WriteLine("----------------------------------------------");
//Console.WriteLine("Show all grades for a student");

//var grades2 = context.Grades.Where(x => x.StudentId == 9);


//foreach (var grade in grades2)
//{
//    Console.WriteLine($"Grade : {grade.Score} for Assignment Id : {grade.AssignmentId}");
//}


//Console.WriteLine("----------------------------------------------");
//Console.WriteLine("List each assignment with its course and the teacher’s full name");



//var assignments3 = context.Assignments
//    .Include(g => g.Course)
//    .ThenInclude(c => c.Teacher)
//    .ToList();


//foreach (var assignment in assignments3)
//{
//    Console.WriteLine($"Assignment : {assignment.AssignmentTitle} " +
//        $"for {assignment.Course.Name} course, " +
//        $"Teacher : {assignment.Course.Teacher.FirstName} {assignment.Course.Teacher.LastName}");
//}




//Console.WriteLine("----------------------------------------------");
//Console.WriteLine("Query to show average grade per course");



//var courses3 = context.Courses
//    .Include(c => c.Assignments)
//    .ThenInclude(a => a.Grades)
//    .ToList();


//foreach (var course in courses3)
//{
//    var total = 0;
//    var counter = 0;
//    foreach (var assignment in course.Assignments)
//    {
//        foreach (var grade in assignment.Grades)
//        {
//            total += grade.Score;
//            counter++;
//        }
//    }
//    Console.WriteLine($"The average score for the {course.Name} course is {total / counter}.");
//}

//Console.WriteLine("----------------------------------------------");
//Console.WriteLine("Create a method to return letter grades (A, B, C, etc.) based on the student’s performance");


//char getLetterGrade(int studentId, int courseId)
//{
//    var gradeAvg = context.Grades
//    .Include(g => g.Assignment)
//    .Where(g => g.StudentId == studentId && g.Assignment.CourseId == courseId)
//    .Average(g => g.Score);

//    if (gradeAvg > 85)
//        return 'A';
//    else if (gradeAvg > 70)
//        return 'B';
//    else if (gradeAvg > 55)
//        return 'C';
//    else if (gradeAvg > 40)
//        return 'D';
//    else
//        return 'F';
//}

//Console.WriteLine($"The Letter Grade for Mohammad Ramez in C# Course is {getLetterGrade(8, 2)}");

//Console.WriteLine("----------------------------------------------");
//Console.WriteLine("Create a method to calculate GPA for a student");

//float calculateGpa(int studentId)
//{
//    var courses = context.Courses.ToList();
//    var total = 0;
//    foreach (var cousre in courses)
//    {
//        var letterGrade = getLetterGrade(studentId, cousre.Id);
//        switch (letterGrade)
//        {
//            case 'A':
//                total += 5;
//                break;
//            case 'B':
//                total += 4;
//                break;
//            case 'C':
//                total += 3;
//                break;
//            case 'D':
//                total += 2;
//                break;
//            default:
//                total += 0;
//                break;
//        }
//    }
//    total = total * 4; // 4 credit for each course
//    float gpa = (float)total / 25; // To get the GPA out of 4.00
//    return gpa;
//}


//Console.WriteLine($"Houzifa Habbo's GPA is {calculateGpa(4)}");



//Console.WriteLine("----------------------------------------------");
//Console.WriteLine("Update a student’s role to “Teacher”");


//var user = context.Users.FirstOrDefault(u => u.FirstName == "Zaid");
//Console.WriteLine($"{user.FirstName} is a {user.Role}");

//if (user != null)
//{
//    user.Role = "Teacher";
//    context.SaveChanges();
//}


//var newuser = context.Users.FirstOrDefault(u => u.FirstName == "Zaid");
//Console.WriteLine($"{newuser.FirstName} is now  a {newuser.Role}");



//Console.WriteLine("----------------------------------------------");
//Console.WriteLine("Delete a specific comment");


//var comment = context.Comments.Find(5);
//if (comment != null)
//{
//    context.Comments.Remove(comment);
//    context.SaveChanges();
//}
