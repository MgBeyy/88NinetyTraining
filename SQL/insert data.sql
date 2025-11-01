USE [University]
GO

INSERT INTO [dbo].[Users]
           ([UserName]
           ,[FirstName]
           ,[LastName]
           ,[EmailAddress]
           ,[PhoneNumber]
           ,[Role])
     VALUES

('AbdelhakeHamdaoui', 'Abdelhake', 'Hamdaoui', 'abdelhakehamdaoui@test.com', '5378527466' ,'Student'),
('HouzifaHabbo', 'Houzifa', 'Habbo', 'houzifahabbo@test.com', '5325527466' ,'Student'),
('AyaKhalifa', 'Aya', 'Khalifa', 'ayakhalifa@test.com', '5300000001', 'Student'),
('FarahSilk', 'Farah', 'Silk', 'farahsilk@test.com', '5300000002', 'Student'),
('FeryalTulaimat', 'Feryal', 'Tulaimat', 'feryaltulaimat@test.com', '5300000003', 'Teacher'),
('MasaSoudan', 'Masa', 'Soudan', 'masasoudan@test.com', '5300000007', 'Student'),
('MohammadRamez', 'Mohammad', 'Ramez', 'mohammadramez@test.com', '5300000008', 'Student'),
('MosaMosa', 'Mosa', 'Mosa', 'mosamosa@test.com', '5300000009', 'Student'),
('NouhadElHallab', 'Nouhad', 'El Hallab', 'nouhadelhallab@test.com', '5300000010', 'Student'),
('SamiHijazi', 'Sami', 'Hijazi', 'samihijazi@test.com', '5300000011', 'Teacher'),
('ShamJamous', 'Sham', 'Jamous', 'shamjamous@test.com', '5300000012', 'Student'),
('YasinYildiz', 'Yasin', 'Yildiz', 'yasinyildiz@test.com', '5300000013', 'Student'),
('ZaidAlmoughrabl', 'Zaid', 'Almoughrabl', 'zaidalmoughrabl@test.com', '5300000014', 'Student'),
('ZomorodahBakhit', 'Zomorodah', 'Bakhit', 'zomorodahbakhit@test.com', '5300000015', 'Student')

GO




USE [University]
GO

INSERT INTO [dbo].[Syllabus]
           ([Description])
     VALUES
           

('This course introduces students to the fundamentals of SQL, including data definition, data manipulation, and query techniques. Learners will gain hands-on experience writing SELECT, INSERT, UPDATE, and DELETE statements, understanding relational database design, and working with JOINs, aggregate functions, and subqueries.'),
 ('This course provides a comprehensive introduction to C#, covering object-oriented programming concepts such as classes, inheritance, interfaces, and exception handling. Students will build practical console applications and explore the use of C# in modern software development, including memory management and LINQ.'),
 ('In this course, students will learn how to interact with databases using Entity Framework Core. The course covers model creation, migrations, querying with LINQ, and handling relationships and constraints. It emphasizes code-first and database-first approaches and demonstrates best practices for managing data access layers in .NET applications.'),
 ('This course focuses on building RESTful web services using ASP.NET Core Web API. Students will learn how to create controllers, define endpoints, handle HTTP methods, and manage authentication and authorization. The course also introduces JSON serialization, versioning, and API documentation using Swagger.'),
 ('This course offers an in-depth look at building modern web applications using React. Topics include JSX, components, state management, props, hooks, and routing. By the end of the course, students will be able to create dynamic, single-page applications and understand how React integrates with APIs and backend services.')

GO





USE [University]
GO

INSERT INTO [dbo].[Courses]
           ([CourseName]
           ,[TeacherId]
           ,[StartDate]
           ,[EndDate]
           ,[SyllabusId])
     VALUES
           ('SQL ', 10, '2025-07-01', '2025-08-01', 1),
('C#', 10, '2025-07-05', '2025-08-15', 2),
('Entity Framework', 10, '2025-07-10', '2025-08-20', 3),
('Web API', 5, '2025-07-12', '2025-08-25', 4),
('React', 5, '2025-08-01', '2025-09-15', 5)
GO






USE [University]
GO

INSERT INTO [dbo].[Assignments]
           ([CourseId]
           ,[AssignmentTitle]
           ,[Description]
           ,[Weight]
           ,[MaxGrade]
           ,[DueDate])
     VALUES
           (9, 'SQL Basics Quiz', 'Covers SELECT, WHERE, and basic filtering.', 20.0, 20, '2025-07-08'),
           (9, 'Join Operations Task', 'Hands-on assignment about INNER JOIN, LEFT JOIN, etc.', 30.0, 30, '2025-07-18'),
           (9, 'SQL Final Project', 'Design a small database and run meaningful queries.', 50.0, 50, '2025-07-30'),
           (9, 'Aggregate Functions Quiz', 'Practice with COUNT, SUM, AVG, MIN, MAX.', 20.0, 20, '2025-07-10'),
           (9, 'Subquery Challenge', 'Solve problems using subqueries and nested SELECTs.', 30.0, 30, '2025-07-20'),
           (9, 'Normalization Task', 'Refactor tables to 3NF and explain design decisions.', 50.0, 50, '2025-08-01'),

           (10, 'C# Syntax and Basics', 'Covers variables, loops, and conditionals.', 25.0, 25, '2025-07-12'),
           (10, 'OOP in C#', 'Implement classes, inheritance, and polymorphism.', 35.0, 35, '2025-07-25'),
           (10, 'Mini C# App', 'Create a small console application using C#.', 40.0, 40, '2025-08-10'),
           (10, 'Arrays and Collections', 'Work with arrays, lists, dictionaries in C#.', 20.0, 20, '2025-07-15'),
           (10, 'Exception Handling Exercise', 'Handle runtime errors gracefully using try-catch.', 35.0, 35, '2025-07-28'),
           (10, 'LINQ Practice Task', 'Write LINQ queries on sample collections.', 40.0, 40, '2025-08-15'),

           (11, 'EF Core Basics', 'Setup DbContext, entities, and basic CRUD.', 30.0, 30, '2025-07-18'),
           (11, 'Relationships & Navigation Properties', 'Implement one-to-many and many-to-many relations.', 30.0, 30, '2025-07-29'),
           (11, 'Final EF Project', 'Create a small app using EF and real database.', 40.0, 40, '2025-08-18'),
           (11, 'EF Querying with LINQ', 'Perform filtering, ordering, and projection.', 25.0, 25, '2025-07-20'),
           (11, 'Migrations and Updates', 'Practice creating and applying migrations.', 35.0, 35, '2025-08-01'),
           (11, 'Seeding and Validation', 'Add seed data and validation rules to models.', 40.0, 40, '2025-08-20'),

           (12, 'REST API Basics', 'Create basic API with GET, POST, PUT, DELETE.', 30.0, 30, '2025-07-20'),
           (12, 'Authentication and Middleware', 'Implement JWT and custom middleware.', 30.0, 30, '2025-08-05'),
           (12, 'Final API Project', 'Develop a full CRUD Web API with EF Core integration.', 40.0, 40, '2025-08-22'),
           (12, 'Routing and Versioning', 'Implement attribute routing and API versioning.', 25.0, 25, '2025-07-22'),
           (12, 'Swagger & Documentation', 'Auto-generate and customize API docs.', 30.0, 30, '2025-08-07'),
           (12, 'API Testing Assignment', 'Test endpoints using Postman or Swagger.', 45.0, 45, '2025-08-25'),

           (13, 'React Fundamentals', 'JSX, props, and state basics.', 25.0, 25, '2025-08-10'),
           (13, 'Component & Hooks Practice', 'Use functional components and custom hooks.', 35.0, 35, '2025-08-25'),
           (13, 'React Final Project', 'Build a dynamic React app with routing and API calls.', 40.0, 40, '2025-09-10'),
           (13, 'React Forms & Validation', 'Create and validate forms using controlled components.', 25.0, 25, '2025-08-12'),
           (13, 'React Router Exercise', 'Implement navigation using React Router.', 35.0, 35, '2025-08-28'),
           (13, 'State Management Challenge', 'Use useReducer or a global state library.', 40.0, 40, '2025-09-12')
GO










USE [University]
GO

INSERT INTO [dbo].[Comments] ([AssignmentId], [CreatedByUserId], [CreatedDate], [CommentContent]) VALUES
(1, 10, '2025-07-09', 'Well done! Just improve the use of aliases.'),
(3, 10, '2025-07-10', 'Try optimizing your JOIN statements for better performance.'),
(5, 10, '2025-07-11', 'Add comments to explain complex queries.'),
(7, 10, '2025-07-13', 'Excellent OOP usage in your solution.'),
(9, 10, '2025-07-14', 'Great use of inheritance, but watch out for redundancy.'),
(12, 10, '2025-07-17', 'Your API handles errors well. Keep it up!'),
(15, 10, '2025-07-19', 'Nice Swagger documentation. Very clear.'),
(18, 5, '2025-07-22', 'Consider adding more seeding data for realism.'),
(20, 5, '2025-07-24', 'Watch out for relationship naming conventions.'),
(22, 4, '2025-07-26', 'Clean routing logic. I like your folder structure.'),
(23, 10, '2025-07-27', 'Authentication is working well. Try adding refresh tokens.'),
(25, 6, '2025-08-01', 'Try using React Context instead of prop drilling.'),
(27, 10, '2025-08-03', 'Hooks are implemented correctly. Good job!'),
(28, 3, '2025-08-04', 'Routing works well. Try nested routes too.'),
(30, 8, '2025-08-06', 'Final React app looks great! Well styled and functional.');
GO






USE [University]
GO

INSERT INTO [dbo].[Grades]
           ([AssignmentId]
           ,[StudentId]
           ,[Grade])
     VALUES
           
(1, 1, 100),
(1, 2, 63),
(1, 3, 75),
(1, 4, 62),
(1, 6, 64),
(1, 7, 74),
(1, 8, 63),
(1, 9, 68),
(1, 11, 75),
(1, 12, 91),
(1, 13, 76),
(1, 14, 88),
(2, 1, 61),
(2, 2, 92),
(2, 3, 68),
(2, 4, 71),
(2, 6, 69),
(2, 7, 78),
(2, 8, 92),
(2, 9, 96),
(2, 11, 83),
(2, 12, 100),
(2, 13, 82),
(2, 14, 70),
(3, 1, 87),
(3, 2, 97),
(3, 3, 83),
(3, 4, 97),
(3, 6, 94),
(3, 7, 86),
(3, 8, 88),
(3, 9, 94),
(3, 11, 87),
(3, 12, 100),
(3, 13, 76),
(3, 14, 73),
(4, 1, 70),
(4, 2, 71),
(4, 3, 96),
(4, 4, 70),
(4, 6, 86),
(4, 7, 100),
(4, 8, 86),
(4, 9, 67),
(4, 11, 60),
(4, 12, 72),
(4, 13, 62),
(4, 14, 73),
(5, 1, 80),
(5, 2, 86),
(5, 3, 97),
(5, 4, 99),
(5, 6, 87),
(5, 7, 89),
(5, 8, 75),
(5, 9, 91),
(5, 11, 95),
(5, 12, 62),
(5, 13, 70),
(5, 14, 84),
(6, 1, 88),
(6, 2, 80),
(6, 3, 63),
(6, 4, 80),
(6, 6, 88),
(6, 7, 91),
(6, 8, 100),
(6, 9, 72),
(6, 11, 97),
(6, 12, 100),
(6, 13, 71),
(6, 14, 94),
(7, 1, 65),
(7, 2, 62),
(7, 3, 67),
(7, 4, 78),
(7, 6, 79),
(7, 7, 75),
(7, 8, 81),
(7, 9, 72),
(7, 11, 89),
(7, 12, 98),
(7, 13, 78),
(7, 14, 62),
(8, 1, 85),
(8, 2, 76),
(8, 3, 67),
(8, 4, 76),
(8, 6, 72),
(8, 7, 93),
(8, 8, 76),
(8, 9, 86),
(8, 11, 87),
(8, 12, 60),
(8, 13, 99),
(8, 14, 94),
(9, 1, 94),
(9, 2, 72),
(9, 3, 80),
(9, 4, 68),
(9, 6, 76),
(9, 7, 73),
(9, 8, 81),
(9, 9, 65),
(9, 11, 93),
(9, 12, 85),
(9, 13, 71),
(9, 14, 69),
(10, 1, 66),
(10, 2, 94),
(10, 3, 98),
(10, 4, 97),
(10, 6, 67),
(10, 7, 91),
(10, 8, 93),
(10, 9, 64),
(10, 11, 71),
(10, 12, 97),
(10, 13, 92),
(10, 14, 95),
(11, 1, 89),
(11, 2, 86),
(11, 3, 95),
(11, 4, 63),
(11, 6, 73),
(11, 7, 91),
(11, 8, 69),
(11, 9, 90),
(11, 11, 80),
(11, 12, 68),
(11, 13, 70),
(11, 14, 93),
(12, 1, 60),
(12, 2, 72),
(12, 3, 97),
(12, 4, 98),
(12, 6, 73),
(12, 7, 81),
(12, 8, 85),
(12, 9, 67),
(12, 11, 91),
(12, 12, 71),
(12, 13, 82),
(12, 14, 98),
(13, 1, 96),
(13, 2, 78),
(13, 3, 60),
(13, 4, 99),
(13, 6, 66),
(13, 7, 73),
(13, 8, 62),
(13, 9, 93),
(13, 11, 60),
(13, 12, 65),
(13, 13, 78),
(13, 14, 90),
(14, 1, 82),
(14, 2, 76),
(14, 3, 76),
(14, 4, 60),
(14, 6, 77),
(14, 7, 91),
(14, 8, 68),
(14, 9, 85),
(14, 11, 83),
(14, 12, 71),
(14, 13, 100),
(14, 14, 77),
(15, 1, 78),
(15, 2, 68),
(15, 3, 87),
(15, 4, 70),
(15, 6, 80),
(15, 7, 87),
(15, 8, 70),
(15, 9, 81),
(15, 11, 88),
(15, 12, 61),
(15, 13, 74),
(15, 14, 99),
(16, 1, 82),
(16, 2, 71),
(16, 3, 79),
(16, 4, 70),
(16, 6, 73),
(16, 7, 67),
(16, 8, 89),
(16, 9, 90),
(16, 11, 81),
(16, 12, 97),
(16, 13, 96),
(16, 14, 82),
(17, 1, 95),
(17, 2, 61),
(17, 3, 64),
(17, 4, 84),
(17, 6, 100),
(17, 7, 64),
(17, 8, 94),
(17, 9, 72),
(17, 11, 72),
(17, 12, 79),
(17, 13, 76),
(17, 14, 68),
(18, 1, 96),
(18, 2, 60),
(18, 3, 96),
(18, 4, 99),
(18, 6, 64),
(18, 7, 96),
(18, 8, 69),
(18, 9, 60),
(18, 11, 64),
(18, 12, 60),
(18, 13, 71),
(18, 14, 86),
(19, 1, 60),
(19, 2, 77),
(19, 3, 88),
(19, 4, 79),
(19, 6, 85),
(19, 7, 88),
(19, 8, 76),
(19, 9, 80),
(19, 11, 92),
(19, 12, 64),
(19, 13, 66),
(19, 14, 80),
(1, 1, 66),
(1, 2, 98),
(1, 3, 86),
(1, 4, 95),
(1, 6, 97),
(1, 7, 87),
(1, 8, 77),
(1, 9, 77),
(1, 11, 95),
(1, 12, 92),
(1, 13, 98),
(1, 14, 78),
(2, 1, 61),
(2, 2, 99),
(2, 3, 72),
(2, 4, 91),
(2, 6, 71),
(2, 7, 60),
(2, 8, 98),
(2, 9, 68),
(2, 11, 97),
(2, 12, 61),
(2, 13, 86),
(2, 14, 77),
(3, 1, 88),
(3, 2, 69),
(3, 3, 99),
(3, 4, 60),
(3, 6, 72),
(3, 7, 60),
(3, 8, 64),
(3, 9, 76),
(3, 11, 81),
(3, 12, 85),
(3, 13, 64),
(3, 14, 69),
(4, 1, 77),
(4, 2, 98),
(4, 3, 74),
(4, 4, 65),
(4, 6, 76),
(4, 7, 97),
(4, 8, 63),
(4, 9, 99),
(4, 11, 89),
(4, 12, 82),
(4, 13, 60),
(4, 14, 63),
(24, 1, 87),
(24, 2, 77),
(24, 3, 69),
(24, 4, 74),
(24, 6, 65),
(24, 7, 93),
(24, 8, 95),
(24, 9, 97),
(24, 11, 92),
(24, 12, 77),
(24, 13, 68),
(24, 14, 66),
(6, 1, 63),
(6, 2, 62),
(6, 3, 97),
(6, 4, 99),
(6, 6, 61),
(6, 7, 61),
(6, 8, 94),
(6, 9, 99),
(6, 11, 80),
(6, 12, 78),
(6, 13, 98),
(6, 14, 63),
(7, 1, 83),
(7, 2, 89),
(7, 3, 81),
(7, 4, 64),
(7, 6, 79),
(7, 7, 93),
(7, 8, 64),
(7, 9, 80),
(7, 11, 62),
(7, 12, 73),
(7, 13, 91),
(7, 14, 94),
(8, 1, 83),
(8, 2, 99),
(8, 3, 98),
(8, 4, 71),
(8, 6, 83),
(8, 7, 92),
(8, 8, 96),
(8, 9, 62),
(8, 11, 67),
(8, 12, 91),
(8, 13, 74),
(8, 14, 71),
(9, 1, 71),
(9, 2, 91),
(9, 3, 73),
(9, 4, 80),
(9, 6, 95),
(9, 7, 82),
(9, 8, 69),
(9, 9, 91),
(9, 11, 78),
(9, 12, 78),
(9, 13, 91),
(9, 14, 94),
(29, 1, 72),
(29, 2, 75),
(29, 3, 69),
(29, 4, 71),
(29, 6, 96),
(29, 7, 70),
(29, 8, 86),
(29, 9, 97),
(29, 11, 65),
(29, 12, 73),
(29, 13, 64),
(29, 14, 98),
(11, 1, 96),
(11, 2, 85),
(11, 3, 73),
(11, 4, 79),
(11, 6, 94),
(11, 7, 71),
(11, 8, 89),
(11, 9, 81),
(11, 11, 77),
(11, 12, 66),
(11, 13, 84),
(11, 14, 63);
GO







