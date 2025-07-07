SELECT [CourseId]
      ,[CourseName]
      ,[TeacherId]
      ,[StartDate]
      ,[EndDate]
      ,[SyllabusId]
  FROM [dbo].[Courses]
  
  
  
------------------------
  

USE [University]
GO

SELECT [AssignmentId]
      ,[CourseId]
      ,[AssignmentTitle]
      ,[Description]
      ,[Weight]
      ,[MaxGrade]
      ,[DueDate]
  FROM [dbo].[Assignments] WHERE [CourseId] = 10

GO



------------------------






USE [University]
GO

SELECT [UserId]
      ,[UserName]
      ,[FirstName]
      ,[LastName]
      ,[EmailAddress]
      ,[PhoneNumber]
      ,[Role]
  FROM [dbo].[Users] WHERE Role = 'Student'

GO





USE [University]
GO

UPDATE [dbo].[Users]
   SET [Role] = 'Intern'
 WHERE FirstName = 'Zaid'



------------------------




USE [University]
GO

DELETE FROM [dbo].[Comments]
      WHERE CreatedByUserId = 3
GO



------------------------


USE [University]
GO

SELECT a.AssignmentTitle
	  ,u.UserName
	  ,g.Grade 
FROM Assignments a

INNER JOIN grades g on  a.AssignmentId = g.AssignmentId
INNER JOIN Users u on u.UserId = g.StudentId

WHERE CourseId =9 order by u.UserName

GO




------------------------

USE [University]
GO
SELECT c.CourseName
      ,AVG(g.grade) AS AvgGrade  
FROM Assignments a
INNER JOIN grades g ON  a.AssignmentId = g.AssignmentId
INNER JOIN Courses c ON c.CourseId =a.CourseId
GROUP BY c.CourseName
GO


------------------------

USE [University]
GO

SELECT c.CourseName
      ,s.Description 
FROM Courses c
INNER JOIN Syllabus s ON s.SyllabusId = c.SyllabusId 
GO


------------------------

USE [University]
GO

SELECT c.CourseName , com.CommentContent  from Assignments a
INNER JOIN Comments com on com.AssignmentId = a.AssignmentId
INNER JOIN Courses c on c.CourseId =a.CourseId
WHERE c.CourseId =2

GO





------------------------



CREATE PROCEDURE p_addStudent (
	@UserName varchar(64),
    @FirstName varchar(64),
    @LastName varchar(64),
    @EmailAddress varchar(128),
    @PhoneNumber varchar(16)
)
AS
BEGIN


INSERT INTO [dbo].[Users]
           ([UserName]
           ,[FirstName]
           ,[LastName]
           ,[EmailAddress]
           ,[PhoneNumber]
           ,[Role])
     VALUES
           (@UserName
           ,@FirstName
           ,@LastName
           ,@EmailAddress
           ,@PhoneNumber
           ,'Student')

END;

GO

EXEC p_addStudent 'TestUser' , 'Test' , 'User' , 'Testasdas.user@email.com', '123546'







------------------------






CREATE PROCEDURE p_addAssignment (
	@CourseId int,
	@AssignmentTitle varchar(128),
    @Description text,
    @Weight float,
    @MaxGrade int,
    @DueDate date
)
AS
BEGIN
IF @Weight > 100 
	BEGIN
		THROW 999999, 'The Grade cannot be more than 100', 1;
	END


INSERT INTO [dbo].[Assignments]
           ([CourseId]
           ,[AssignmentTitle]
           ,[Description]
           ,[Weight]
           ,[MaxGrade]
           ,[DueDate])
     VALUES
           (@CourseId
		   ,@AssignmentTitle
           ,@Description
           ,@Weight
           ,@MaxGrade
           ,@DueDate)

END;

GO

EXEC p_addAssignment 10, 'Test Assignment' , 'This is a test assignment' , 50 , 100, '2025-08-01'

EXEC p_addAssignment 10, 'Test Assignment2' , 'This is second test assignment' , 101 , 100, '2025-08-01'






------------------------


CREATE FUNCTION f_calculateGrade (@StudentId int, @CourseId int)
RETURNS VARCHAR(2)
AS 
BEGIN 
	Declare @Grade int
	Declare @LetterGrade varchar(2)
	SELECT @Grade = SUM(g.Grade) / COUNT(g.Grade)
	FROM Grades g
	INNER JOIN Assignments a ON a.AssignmentId = g.AssignmentId
	INNER JOIN Courses c ON c.CourseId = a.CourseId
	WHERE @StudentId  = 13 and @CourseId = 9

	IF @Grade  > 90 
			BEGIN
					SET @LetterGrade =  'AA'
			END

	ELSE IF @Grade > 80
			BEGIN
					SET @LetterGrade =  'BA'
			END

	ELSE IF @Grade > 70
			BEGIN
					SET @LetterGrade =  'BC'
			END

	ELSE IF @Grade > 60
			BEGIN
					SET @LetterGrade =  'CC'
			END

	ELSE IF @Grade > 50
			BEGIN
					SET @LetterGrade =  'DC'
			END
	ELSE IF @Grade > 35
			BEGIN
					SET @LetterGrade =  'DD'
			END

	ELSE
			BEGIN
					SET @LetterGrade =  'FF'
			END

	RETURN @LetterGrade
END 






Select [dbo].f_calculateGrade(5,9)




------------------------




CREATE FUNCTION dbo.fn_GetStudentGPA (
    @StudentId INT
)
RETURNS FLOAT
AS
BEGIN
    DECLARE @GPA FLOAT;

    WITH CourseAverages AS (
        SELECT 
            a.CourseId,
            AVG(CAST(g.Grade AS FLOAT)) AS CourseAvg
        FROM Grades g
        INNER JOIN Assignments a ON g.AssignmentId = a.AssignmentId
        WHERE g.StudentId = @StudentId
        GROUP BY a.CourseId
    )
   
    SELECT @GPA = AVG(CourseAvg)/25
    FROM CourseAverages;

    RETURN @GPA;
END;



SELECT [dbo].fn_GetStudentGPA(13) AS GPA;
