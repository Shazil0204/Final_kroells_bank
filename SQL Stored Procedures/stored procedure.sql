CREATE PROCEDURE CheckEmployeeLogin
    @Username VARCHAR(50),
    @Password VARCHAR(255),
    @Result INT OUTPUT
AS
BEGIN
    DECLARE @Position VARCHAR(30);
    DECLARE @Employee_Id INT;

    -- Check if the provided Username and Password match an employee's record
    SELECT @Employee_Id = Employee_Id, @Position = Position
    FROM Employees
    WHERE Username = @Username AND Password = @Password;

    IF @Employee_Id IS NOT NULL
    BEGIN
        -- Check if the Position is either "Admin" or "IT"
        IF @Position IN ('Admin', 'IT')
        BEGIN
            -- Valid login, set the result code to 1
            SET @Result = 1;
        END
        ELSE
        BEGIN
            -- Invalid position, set the result code to 0
            SET @Result = 0;
        END
    END
    ELSE
    BEGIN
        -- Invalid Username or Password, set the result code to -1
        SET @Result = -1;
    END
END;
