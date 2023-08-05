--=====================================================================================================================================--
-- Contributor: Hoang Nguyen Vu
--=====================================================================================================================================--

CREATE DATABASE LMS1
GO

USE LMS1

--=====================================================================================================================================--
------------------------------------------------------------- Create tables -------------------------------------------------------------
--=====================================================================================================================================--
CREATE TABLE LMS1.dbo.book (
  B_ID SMALLINT IDENTITY
 ,ID_withChar AS ('B' + RIGHT('0000' + CONVERT([VARCHAR](10), [B_ID]), (4))) PERSISTED
 ,Title VARCHAR(250) NOT NULL
 ,Publication_Year SMALLINT NULL
 ,Created_time DATETIME NOT NULL DEFAULT (GETDATE())
 ,Updated_time DATETIME NOT NULL DEFAULT (GETDATE())
 ,CONSTRAINT PK_book_B_ID PRIMARY KEY CLUSTERED (B_ID)
) ON [PRIMARY]
GO

CREATE TABLE LMS1.dbo.book_stock (
  B_ID SMALLINT NOT NULL
 ,Stock_num SMALLINT NULL
 ,UNIQUE (B_ID)
 ,CONSTRAINT FK_book_stock FOREIGN KEY (B_ID) REFERENCES dbo.book (B_ID)
) ON [PRIMARY]
GO

CREATE TABLE LMS1.dbo.author (
  AU_ID SMALLINT IDENTITY
 ,Name VARCHAR(100) NOT NULL
 ,CONSTRAINT PK_author_au_id PRIMARY KEY CLUSTERED (AU_ID)
 ,UNIQUE (Name)
) ON [PRIMARY]
GO

CREATE TABLE LMS1.dbo.book_author (
  B_ID SMALLINT NOT NULL
 ,AU_ID SMALLINT NOT NULL
 ,PRIMARY KEY CLUSTERED (B_ID, AU_ID)
 ,CONSTRAINT FK_book_author_AU_ID FOREIGN KEY (AU_ID) REFERENCES dbo.author (AU_ID)
 ,CONSTRAINT FK_book_author_B_ID FOREIGN KEY (B_ID) REFERENCES dbo.book (B_ID)
) ON [PRIMARY]
GO

CREATE TABLE LMS1.dbo.category (
  CA_ID SMALLINT IDENTITY
 ,Title VARCHAR(100) NOT NULL
 ,CONSTRAINT PK_category_CA_ID PRIMARY KEY CLUSTERED (CA_ID)
 ,UNIQUE (Title)
) ON [PRIMARY]
GO

CREATE TABLE LMS1.dbo.book_category (
  B_ID SMALLINT NOT NULL
 ,CA_ID SMALLINT NOT NULL
 ,PRIMARY KEY CLUSTERED (B_ID, CA_ID)
 ,CONSTRAINT FK_book_category_B_ID FOREIGN KEY (B_ID) REFERENCES dbo.book (B_ID)
 ,CONSTRAINT FK_book_category_CA_ID FOREIGN KEY (CA_ID) REFERENCES dbo.category (CA_ID)
) ON [PRIMARY]
GO

CREATE TABLE LMS1.dbo.member (
  M_ID SMALLINT IDENTITY
 ,ID_withChar AS ('M' + RIGHT('0000' + CONVERT([VARCHAR](10), [M_ID]), (4))) PERSISTED
 ,Name VARCHAR(100) NULL
 ,Birthday DATE NULL
 ,Sex VARCHAR(10) NULL
 ,Phone VARCHAR(20) NULL
 ,Mem_status VARCHAR(50) NULL
 ,Created_time DATETIME NOT NULL DEFAULT (GETDATE())
 ,Updated_time DATETIME NOT NULL DEFAULT (GETDATE())
 ,CONSTRAINT PK_member_M_ID PRIMARY KEY CLUSTERED (M_ID)
) ON [PRIMARY]
GO

CREATE TABLE LMS1.dbo.membership_type (
  MST_ID SMALLINT IDENTITY
 ,Title VARCHAR(50) NULL
 ,Fee DECIMAL(10) NULL
 ,Max_num_book SMALLINT NULL
 ,Max_loan_day SMALLINT NULL
 ,CONSTRAINT PK_ms_type_M_ID PRIMARY KEY CLUSTERED (MST_ID)
) ON [PRIMARY]
GO

CREATE TABLE LMS1.dbo.membership (
  M_ID SMALLINT NOT NULL
 ,MST_ID SMALLINT NOT NULL
 ,Membership_status VARCHAR(50) NULL
 ,Created_time DATETIME NOT NULL DEFAULT (GETDATE())
 ,Updated_time DATETIME NOT NULL DEFAULT (GETDATE())
 ,Expiry_date DATE NULL
 ,UNIQUE (M_ID)
 ,CONSTRAINT FK_membership_mem_M_ID FOREIGN KEY (M_ID) REFERENCES dbo.member (M_ID)
 ,CONSTRAINT FK_membership_type_MST_ID FOREIGN KEY (MST_ID) REFERENCES dbo.membership_type (MST_ID)
) ON [PRIMARY]
GO

CREATE TABLE LMS1.dbo.loan (
  L_ID SMALLINT IDENTITY
 ,ID_withChar AS ('L' + RIGHT('0000' + CONVERT([VARCHAR](10), [L_ID]), (4))) PERSISTED
 ,M_ID SMALLINT NOT NULL
 ,Loan_date DATE NULL
 ,Due_date DATE NULL
 ,Loan_status VARCHAR(50) NULL
 ,CONSTRAINT PK_loan_L_ID PRIMARY KEY CLUSTERED (L_ID)
 ,CONSTRAINT FK_member_loan_M_ID FOREIGN KEY (M_ID) REFERENCES dbo.member (M_ID)
) ON [PRIMARY]
GO

CREATE TABLE LMS1.dbo.loan_list (
  L_ID SMALLINT NOT NULL
 ,B_ID SMALLINT NOT NULL
 ,PRIMARY KEY CLUSTERED (L_ID, B_ID)
 ,CONSTRAINT FK_book_loan_list_B_ID FOREIGN KEY (B_ID) REFERENCES dbo.book (B_ID)
 ,CONSTRAINT FK_loan_list_L_ID FOREIGN KEY (L_ID) REFERENCES dbo.loan (L_ID)
) ON [PRIMARY]
GO

CREATE TABLE LMS1.dbo.return_book (
  RE_ID SMALLINT IDENTITY
 ,ID_withChar AS ('RE' + RIGHT('0000' + CONVERT([VARCHAR](10), [RE_ID]), (4))) PERSISTED
 ,L_ID SMALLINT NOT NULL
 ,Return_date DATE NULL
 ,Return_status VARCHAR(50) NULL
 ,CONSTRAINT PK_return_RE_ID PRIMARY KEY CLUSTERED (RE_ID)
 ,CONSTRAINT FK_loan_return_L_ID FOREIGN KEY (L_ID) REFERENCES dbo.loan (L_ID)
 ,UNIQUE (L_ID)
) ON [PRIMARY]
GO

CREATE TABLE LMS1.dbo.return_list (
  RE_ID SMALLINT NOT NULL
 ,B_ID SMALLINT NOT NULL
 ,PRIMARY KEY CLUSTERED (RE_ID, B_ID)
 ,CONSTRAINT FK_book_return_list_B_ID FOREIGN KEY (B_ID) REFERENCES dbo.book (B_ID)
 ,CONSTRAINT FK_return_list_RE_ID FOREIGN KEY (RE_ID) REFERENCES dbo.return_book (RE_ID)
) ON [PRIMARY]
GO

CREATE TABLE LMS1.dbo.payment (
  P_ID SMALLINT IDENTITY
 ,ID_withChar AS ('P' + RIGHT('0000' + CONVERT([VARCHAR](10), [P_ID]), (4))) PERSISTED
 ,M_ID SMALLINT NOT NULL
 ,Payment_date DATE NULL
 ,Payment_amount DECIMAL(10) NULL
 ,Payment_method VARCHAR(20) NULL
 ,Payment_type VARCHAR(50) NULL
 ,CONSTRAINT PK_payment_P_ID PRIMARY KEY CLUSTERED (P_ID)
 ,CONSTRAINT FK_member_payment_M_ID FOREIGN KEY (M_ID) REFERENCES dbo.member (M_ID)
) ON [PRIMARY]
GO

CREATE TABLE LMS1.dbo.fine_type (
  FT_ID SMALLINT IDENTITY
 ,Title VARCHAR(70) NULL
 ,Fine_amount DECIMAL(10) NULL
 ,CONSTRAINT PK_fine_amount_FT_ID PRIMARY KEY CLUSTERED (FT_ID)
) ON [PRIMARY]
GO

CREATE TABLE LMS1.dbo.fine (
  F_ID SMALLINT IDENTITY
 ,ID_withChar AS ('F' + RIGHT('0000' + CONVERT([VARCHAR](10), [F_ID]), (4))) PERSISTED
 ,RE_ID SMALLINT NOT NULL
 ,M_ID SMALLINT NOT NULL
 ,Fine_date DATE NULL
 ,FT_ID SMALLINT NOT NULL
 ,Fine_status VARCHAR(50) NULL
 ,P_ID SMALLINT NULL
 ,Fine_amount DECIMAL(10) NULL
 ,CONSTRAINT PK_fine_F_ID PRIMARY KEY CLUSTERED (F_ID)
 ,UNIQUE (RE_ID)
 ,CONSTRAINT FK_fine_payment_P_ID FOREIGN KEY (P_ID) REFERENCES dbo.payment (P_ID)
 ,CONSTRAINT FK_fine_type_FT_ID FOREIGN KEY (FT_ID) REFERENCES dbo.fine_type (FT_ID)
 ,CONSTRAINT FK_member_fine_M_ID FOREIGN KEY (M_ID) REFERENCES dbo.member (M_ID)
 ,CONSTRAINT FK_return_fine_RE_ID FOREIGN KEY (RE_ID) REFERENCES dbo.return_book (RE_ID)
) ON [PRIMARY]
GO



--=====================================================================================================================================--
----------------------------------------------------------- Book information ------------------------------------------------------------
--=====================================================================================================================================--


------------------------------------------------ Insert new book with author and category -----------------------------------------------
GO
CREATE OR ALTER PROCEDURE dbo.InsertBook 
	@title VARCHAR(250), 
	@author VARCHAR(100),
	@category VARCHAR(100),
	@pub_year SMALLINT,
	@num_cop SMALLINT,
	@result SMALLINT OUTPUT --Return value
AS
BEGIN
	SET @result = 0 -- Default to 0

	IF NOT EXISTS 
	(
		SELECT * 
		FROM book b 
		Join book_category bc On bc.B_ID = b.B_ID
		Join category c On bc.CA_ID = c.CA_ID
		Join book_author ba On ba.B_ID = b.B_ID
		Join author a On a.AU_ID = ba.AU_ID
		WHERE Lower(@title) = Lower(b.Title) And LOWER(a.Name) = LOWER(@author) And LOWER(c.Title) = @category And b.Publication_Year = @pub_year 
	)
	BEGIN
		-- Author does not exist, create a new one
		IF NOT EXISTS (SELECT * FROM author a WHERE a.Name LIKE @author)
			BEGIN
				INSERT INTO author(Name) VALUES (@author)
			END
		DECLARE @AU_ID SMALLINT = (SELECT a.AU_ID FROM author a WHERE a.Name = @author)
		-- Category does not exist, create a new one
		IF NOT EXISTS (SELECT * FROM category c WHERE c.Title LIKE @category)
			BEGIN
				INSERT INTO category (Title) VALUES (@category)
			END
		DECLARE @CA_ID SMALLINT = (SELECT c.CA_ID FROM category c WHERE c.Title = @category)

		Declare @B_ID SMALLINT
		-- Book does not exist, create a new one
		IF NOT EXISTS
			(SELECT * FROM book b WHERE Lower(@title) = Lower(b.Title) And b.Publication_Year = @pub_year)
			BEGIN
				INSERT INTO book (Title, Publication_Year) VALUES (@title, @pub_year)
				Set @B_ID = SCOPE_IDENTITY()
				Insert Into book_stock (B_ID, Stock_num) Values (@B_ID, @num_cop)
			END
		ELSE --
			Begin
				Set @B_ID = (SELECT b.B_ID FROM book b WHERE Lower(@title) = Lower(b.Title) And b.Publication_Year = @pub_year)
			End

		-- insert book-author and book-category if does not exist
		If Not Exists (Select * From book_author ba Where @B_ID = ba.B_ID And @AU_ID = ba.AU_ID)
			Begin
				Insert Into book_author (B_ID, AU_ID) Values (@B_ID, @AU_ID)
			End
		If Not Exists (Select * From book_category bc Where @B_ID = bc.B_ID And @CA_ID = bc.CA_ID)
			Begin
				Insert Into book_category (B_ID, CA_ID) Values (@B_ID, @CA_ID)
			End
		SET @result = 1 -- Book saved successfully
	END
	ELSE
	BEGIN
		SET @result = 0 -- Book already exists
	END
END;
GO

-------------------------------------------------------- Search book by bookID ----------------------------------------------------------
GO
CREATE OR ALTER PROCEDURE dbo.BookSearch
	@ID Varchar(5)
As
Begin

	SELECT 
			b.ID_withChar As ID, b.Title, 
			b.Publication_Year As 'Publication Year', 
			bs.Stock_num As 'Number in stock',
			STUFF((SELECT ', ' + a.Name FROM author a
				  JOIN book_author ba ON a.AU_ID = ba.AU_ID
				  WHERE ba.B_ID = b.B_ID 
				  FOR XML PATH('')), 1, 2, '') AS 'Author(s)',
			STUFF((SELECT ', ' + c.Title FROM category c
				  JOIN book_category bc ON c.CA_ID = bc.CA_ID
				  WHERE bc.B_ID = b.B_ID
				  FOR XML PATH('')), 1, 2, '') AS 'Category(s)',
			b.Created_time, b.Updated_time
	FROM book b
	Join book_stock bs On bs.B_ID = b.B_ID
	Where @ID = b.ID_withChar

End
GO

-------------------------------------------------------- All books list ----------------------------------------------------------
GO
CREATE OR ALTER Procedure dbo.BookInfo
As
Begin

	SELECT b.ID_withChar As ID, b.Title, b.Publication_Year As 'Publication Year', 
			STUFF((SELECT ', ' + a.Name FROM author a
				  JOIN book_author ba ON a.AU_ID = ba.AU_ID
				  WHERE ba.B_ID = b.B_ID 
				  FOR XML PATH('')), 1, 2, '') AS 'Author(s)',
			STUFF((SELECT ', ' + c.Title FROM category c
				  JOIN book_category bc ON c.CA_ID = bc.CA_ID
				  WHERE bc.B_ID = b.B_ID
				  FOR XML PATH('')), 1, 2, '') AS 'Category(s)',
			bs.Stock_num As 'Number in stock',
			b.Created_time, b.Updated_time
	FROM book b
	Join book_stock bs On bs.B_ID = b.B_ID
	ORDER BY b.B_ID ASC

End
GO

CREATE TYPE Author_type AS TABLE
(
  author_name VARCHAR(100) UNIQUE
)
GO
CREATE TYPE Category_type AS TABLE
(
  category_name VARCHAR(100) UNIQUE
)
GO
-------------------------------------------------------- Update book ----------------------------------------------------------
CREATE OR ALTER PROCEDURE dbo.UpdateBook
  @bookID VARCHAR(5),
  @u_title VARCHAR(250),
  @u_pub_year SMALLINT,
  @u_num_cop SMALLINT,
  @u_au_list Author_type READONLY,
  @u_cat_list Category_type READONLY
AS
  DECLARE @B_ID SMALLINT = (SELECT b.B_ID FROM book b WHERE b.ID_withChar = @bookID)
	--Kiểm tra xem tên có trùng không
  IF 
    @u_title <> (SELECT b.Title FROM book b WHERE b.B_ID = @B_ID)
    OR @u_pub_year <> (SELECT b.Publication_Year FROM book b WHERE b.B_ID = @B_ID)
  BEGIN
  	UPDATE book 
    SET Title = @u_title, Publication_Year = @u_pub_year
    WHERE B_ID = @B_ID;
  END

  IF @u_num_cop <> (SELECT bs.Stock_num FROM book_stock bs WHERE bs.B_ID = @B_ID)
  BEGIN
  	UPDATE book_stock 
    SET Stock_num = @u_num_cop
    WHERE B_ID = @B_ID
  END
  
  --Delete records that associate the current book with an author outside the updated list in the book_author table.
  DELETE FROM book_author
  WHERE B_ID = @B_ID
  AND AU_ID IN (SELECT a.AU_ID FROM author a JOIN book_author ba ON a.AU_ID = ba.AU_ID WHERE ba.B_ID = @B_ID
                EXCEPT
                SELECT a.AU_ID FROM @u_au_list JOIN author a ON author_name = a.Name)
  --Add authors that exists in the updated list but not in the author table.
  INSERT INTO author (Name)
  (SELECT author_name FROM @u_au_list
  EXCEPT 
  SELECT a.Name FROM author a)
  --Insert associations between the current book and the author appear in the updated list but was not associated with the current book.
  INSERT INTO book_author (B_ID, AU_ID)
  (SELECT @B_ID, a.AU_ID FROM @u_au_list JOIN author a ON author_name = a.Name
  EXCEPT
  SELECT @B_ID, ba.AU_ID FROM book_author ba WHERE ba.B_ID = @B_ID)
  --Delete the author that does not have association with any book.
  DELETE FROM author
  WHERE AU_ID NOT IN (SELECT ba.AU_ID FROM book_author ba)

  DELETE FROM book_category
  WHERE B_ID = @B_ID
  AND CA_ID IN (SELECT c.CA_ID FROM category c JOIN book_category bc ON c.CA_ID = bc.CA_ID WHERE bc.B_ID = @B_ID
                EXCEPT
                SELECT c.CA_ID FROM @u_cat_list JOIN category c ON category_name = c.Title)
  INSERT INTO category (Title)
  (SELECT category_name FROM @u_cat_list
  EXCEPT
  SELECT c.Title FROM category c)
  INSERT INTO book_category (B_ID, CA_ID)
  (SELECT @B_ID, c.CA_ID FROM @u_cat_list JOIN category c ON category_name = c.Title
  EXCEPT
  SELECT @B_ID, bc.CA_ID FROM book_category bc WHERE bc.B_ID = @B_ID)
  DELETE FROM category
  WHERE CA_ID NOT IN (SELECT bc.CA_ID FROM book_category bc)
GO

-------------------------------------------------------- Triggers to update book ----------------------------------------------------------
CREATE TRIGGER dbo.trig_update_book
ON book
AFTER UPDATE
AS
  UPDATE book
  SET Updated_time = GETDATE()
  WHERE B_ID = (SELECT B_ID FROM INSERTED)
GO

CREATE TRIGGER dbo.trig_update_book_author
ON book_author
AFTER INSERT, DELETE, UPDATE
AS
  UPDATE book
  SET Updated_time = GETDATE()
  WHERE B_ID = (SELECT B_ID FROM INSERTED)

GO

CREATE TRIGGER dbo.trig_update_book_category
on book_category
AFTER INSERT, DELETE, UPDATE
AS
  UPDATE book
  SET Updated_time = GETDATE()
  WHERE B_ID = (SELECT B_ID FROM INSERTED)
GO

-------------------------------------------------------- Views information -------------------------------------------------------------
CREATE OR ALTER VIEW v_author
AS
SELECT
  author.Name AS [Author name]
 ,COUNT(book_author.B_ID) AS [Number of books]
FROM dbo.book_author
INNER JOIN dbo.author
  ON book_author.AU_ID = author.AU_ID
INNER JOIN dbo.book
  ON book_author.B_ID = book.B_ID
GROUP BY author.Name
GO

CREATE OR ALTER VIEW v_category
AS
SELECT
  category.Title AS [Category Title]
 ,COUNT(book_category.B_ID) AS [Number of books]
FROM dbo.book_category
INNER JOIN dbo.category
  ON book_category.CA_ID = category.CA_ID
INNER JOIN dbo.book
  ON book_category.B_ID = book.B_ID
GROUP BY category.Title
GO

--=====================================================================================================================================--
----------------------------------------------------------- Book information ------------------------------------------------------------
--=====================================================================================================================================--

----------------------------------------------------------- Insert new member -------------------------------------------------------------
GO
CREATE OR ALTER PROCEDURE dbo.InsertMember
	@name Varchar(100),
	@birthday Date,
	@sex Varchar(10),
	@phone Varchar(20),
	@result Int Output
As
Begin

	If Not Exists
	(
		Select * 
		From member m
		WHERE Lower(@name) = Lower(m.Name) And @birthday = m.Birthday And @phone = m.Phone And @sex = m.Sex
	)
	Begin
		Insert Into member (Name, Birthday, Sex, Phone, Mem_status)
		Values (@name, @birthday, @sex, @phone, 'Normal')
		Set @result = 1 -- Member insert susscessfully
	End
	Else 
	Begin
		Set @result = 0 -- Member already exixts
	End

END
GO

----------------------------------------------------------- all members list -------------------------------------------------------------
CREATE OR ALTER PROCEDURE dbo.MemberInfo
As
Begin

	SELECT 
		m.ID_withChar AS ID,
		m.Name AS 'Full name',
		Convert(Varchar(10), m.Birthday, 103) AS 'Date of birth',
		m.Sex,
		m.Phone,
		m.Mem_status AS 'Member status',
		COALESCE(mst.Title, '-') AS 'Membership',
		COALESCE(Cast(Format(mst.Fee, 'N0') As Varchar), '-') AS 'Membership fee',
		COALESCE(Convert(Varchar(10), msh.Expiry_date, 103 ), '-') AS 'Expiry date', 
		m.Created_time,
		m.Updated_time
	FROM 
		member m
		LEFT JOIN membership msh ON msh.M_ID = m.M_ID
		LEFT JOIN membership_type mst ON msh.MST_ID = mst.MST_ID;

END
GO

----------------------------------------------------------- Search by member ID -------------------------------------------------------------
CREATE OR ALTER Procedure dbo.MemberSearch
	@ID VARCHAR(5)
As
Begin

	SELECT 
		m.ID_withChar AS ID,
		m.Name AS 'Full name',
		m.Birthday AS 'Date of birth',
		m.Sex,
		m.Phone,
		m.Mem_status AS 'Member status',
		COALESCE(mst.Title, '-') AS 'Membership',
		COALESCE(Cast(Format(mst.Fee, 'N0') As Varchar), '-') AS 'Membership fee',
		COALESCE(Convert(Varchar(10), msh.Expiry_date, 103 ), '-') AS 'Expiry date', 
		m.Created_time,
		m.Updated_time
	FROM 
		member m
		LEFT JOIN membership msh ON msh.M_ID = m.M_ID
		LEFT JOIN membership_type mst ON msh.MST_ID = mst.MST_ID
	Where @ID = m.ID_withChar

End
GO

----------------------------------------------------------- Update member -------------------------------------------------------------
CREATE OR ALTER PROCEDURE dbo.UpdateMember
  @memID VARCHAR(5),
  @u_name VARCHAR(100),
  @u_sex VARCHAR(10),
  @u_DoB DATE,
  @u_phone VARCHAR(20)
AS
BEGIN
	
  DECLARE @M_ID SMALLINT = (SELECT m.M_ID FROM member m WHERE m.ID_withChar = @memID)
  IF @u_name <> (SELECT m.Name FROM member m WHERE m.M_ID = @M_ID)
  OR @u_sex <> (SELECT m.Sex FROM member m WHERE m.M_ID = @M_ID)
  OR @u_DoB <> (SELECT m.Birthday FROM member m WHERE m.M_ID = @M_ID)
  OR @u_phone <> (SELECT m.Phone FROM member m WHERE m.M_ID = @M_ID)
  BEGIN  
  	UPDATE member 
    SET 
      Name = @u_name
     ,Birthday = @u_DoB
     ,Sex = @u_sex
     ,Phone = @u_phone
    WHERE M_ID = @M_ID;
  END
  
END
GO

------------------------------------------------------ Trigger to update member -------------------------------------------------------------
CREATE TRIGGER dbo.trig_update_member
ON member
AFTER UPDATE
AS
  UPDATE member
  SET Updated_time = GETDATE()
  WHERE M_ID = (SELECT M_ID FROM INSERTED)
GO


--=====================================================================================================================================--
--------------------------------------------------------------- Membership --------------------------------------------------------------
--=====================================================================================================================================--

--------------------------------------------------------- Insert membership -------------------------------------------------------------
CREATE OR ALTER Procedure dbo.InsertMembership
	@memID Varchar(5),
	@mem_type Varchar(20),
	@ex_date Date

As
Begin
	Declare @M_ID SmallInt = (Select m.M_ID From member m Where @memID = ID_withChar)
	Declare @MST_ID Smallint = (Select mst.MST_ID From membership_type mst Where @mem_type = mst.Title)	
	If Not Exists
	(
		Select * From membership ms Where @M_ID = M_ID
	)
	Begin

		Insert Into membership (M_ID, MST_ID, Membership_status, Expiry_date)
		Values (@M_ID, @MST_ID, 'Normal', @ex_date)
	End
	Else
	Begin
		Update membership 
		Set MST_ID = @MST_ID, Expiry_date = @ex_date
		WHERE M_ID = @M_ID
	End
End
GO

----------------------------------------------------- Search membership by Member ID ---------------------------------------------------------
CREATE OR ALTER PROCEDURE dbo.MembershipSearch
	@memID VARCHAR(5)
As
Begin
	Declare @M_ID SmallInt= (Select m.M_ID From member m Where @memID = ID_withChar)
	Select	
		m.ID_withChar As 'Member ID',
		m.Name,
		mst.Title As 'Membership',
		mst.Fee As 'Membership Fee',
		ms.Expiry_date As 'Expiry date',
		ms.Membership_status As 'Status',
		ms.Created_time,
		ms.Updated_time
	From membership ms 
	Left Join member m On m.M_ID = ms.M_ID
	Join membership_type mst On mst.MST_ID = ms.MST_ID
	Where m.M_ID = @M_ID
END
GO


CREATE OR ALTER PROCEDURE dbo.MembershipDetailSearch
	@memID varchar(5)
As
Begin
	Declare @M_ID SmallInt= (Select m.M_ID From member m Where @memID = ID_withChar)
	Select	
		m.ID_withChar As 'Member ID',
		m.Name AS 'Member name',
		ISNULL(mt.Title, '-') As 'Membership',
		ISNULL(mt.Max_num_book, 0) AS 'Max number of book',
		ISNULL(mt.Max_loan_day, 0) AS 'Max number of day'
	From member m 
	LEFT JOIN membership ms On m.M_ID = ms.M_ID
	LEFT JOIN membership_type mt ON ms.MST_ID = mt.MST_ID
	Where m.M_ID = @M_ID
End
GO

------------------------------------------------------- View memberships about to expire ---------------------------------------------------------
CREATE OR ALTER VIEW v_aboutToExpire
AS
SELECT
  member.ID_withChar AS [Member ID]
 ,member.Name AS [Member name]
 ,membership_type.Title AS Membership
 ,CONVERT(VARCHAR(10), membership.Expiry_date, 103) AS [Expiry date]
FROM dbo.membership
INNER JOIN dbo.member
  ON membership.M_ID = member.M_ID
INNER JOIN dbo.membership_type
  ON membership.MST_ID = membership_type.MST_ID
WHERE membership.Expiry_date <= CONVERT(DATE, DATEADD(DAY, 7, GETDATE()))
GO

------------------------------------------------------ Trigger to update membership -------------------------------------------------------------
CREATE TRIGGER dbo.trig_update_membership
ON membership
AFTER UPDATE
AS
  UPDATE membership
  SET Updated_time = GETDATE()
  WHERE M_ID = (SELECT M_ID FROM INSERTED)
GO


--=====================================================================================================================================--
--------------------------------------------------------------- Transactions --------------------------------------------------------------
--=====================================================================================================================================--

-------------------------------------------------------------Book Type--------------------------------------------------------------------

GO 
CREATE TYPE Book AS TABLE
(
	BookID VARCHAR(5) NOT NULL,
	Title VARCHAR(70) NOT NULL,
	Stock_num SMALLINT NOT NULL
	PRIMARY KEY (BookID)
)
GO
------------------------------------------------------------- Loan list --------------------------------------------------------------------
CREATE OR ALTER PROCEDURE dbo.InsertLoanList
	@L_ID SMALLINT,
	@BookList Book READONLY
AS
BEGIN

	INSERT INTO loan_list(L_ID, B_ID)
	SELECT @L_ID, b.B_ID 
	FROM book b 
	INNER JOIN @BookList bl ON b.ID_withChar = bl.BookID

	UPDATE book_stock
	SET Stock_num = Stock_num - 1
	WHERE B_ID IN (SELECT b.B_ID FROM book b INNER JOIN @BookList bl ON b.ID_withChar = bl.BookID)

END
GO

CREATE OR ALTER PROCEDURE dbo.InsertReLoanList
	@L_ID SMALLINT,
	@BookList Book READONLY
AS
BEGIN

	IF EXISTS(SELECT * FROM @BookList)
	BEGIN
    	INSERT INTO loan_list(L_ID, B_ID)
		SELECT @L_ID, b.B_ID 
		FROM book b 
		INNER JOIN @BookList bl ON b.ID_withChar = bl.BookID
    END

END
GO

---------------------------------------------------------- Insert new loan ---------------------------------------------------------------
CREATE OR ALTER PROCEDURE dbo.InsertLoan
	@memID varchar(5),
	@loanDate Date,
	@BookLoanList Book READONLY,
	@BookReloanList Book READONLY,
	@return INT OUTPUT
AS
BEGIN
	DECLARE @M_ID SMALLINT = (SELECT m.M_ID FROM member m WHERE @memID = m.ID_withChar)

  BEGIN TRANSACTION
	If(EXISTS(SELECT * FROM fine f WHERE f.M_ID = @M_ID AND f.P_ID IS NULL))
	BEGIN
		Insert Into loan (M_ID ,Loan_date, Due_date, Loan_status)
		VALUES (@M_ID, @loanDate, NULL, 'Declined due to unpaid fine')
		Set @return = 0
	End
	Else IF EXISTS 
		(SELECT * FROM loan l
		WHERE l.M_ID = @M_ID
		AND l.L_ID NOT IN (SELECT L_ID FROM return_book)
		AND l.Loan_status = 'Accepted'
		)
	BEGIN
		Insert Into loan (M_ID ,Loan_date, Due_date, Loan_status)
		VALUES (@M_ID, @loanDate, NULL, 'Declined due to unreturned loan')
		Set @return = 1
	END
	ELSE IF 
		(SELECT ms.Expiry_date FROM member m 
		JOIN membership ms ON m.M_ID = ms.M_ID
		WHERE m.M_ID = @M_ID) < @loanDate  
	BEGIN 
		Insert Into loan (M_ID ,Loan_date, Due_date, Loan_status)
		VALUES (@M_ID, @loanDate, NULL, 'Declined due to expried membership')
		Set @return = 2
	END 
	ELSE 
	BEGIN
		DECLARE @maxDay INT = (SELECT mt.Max_loan_day FROM membership_type mt JOIN membership ms On ms.MST_ID = mt.MST_ID WHERE @M_ID = ms.M_ID)
		DECLARE @dueDate DATE = DATEADD(DAY, @maxDay, @loanDate)

		INSERT INTO loan (M_ID ,Loan_date, Due_date, Loan_status)
		VALUES (@M_ID, @loanDate, @dueDate, 'Accepted')

		DECLARE @L_ID SMALLINT = SCOPE_IDENTITY()
		EXEC InsertLoanList @L_ID, @BookLoanList
		EXEC InsertReLoanList @L_ID, @BookReloanList

		Set @return = 3
	END
  IF NOT EXISTS (SELECT * FROM membership m WHERE m.M_ID = @M_ID) 
  BEGIN  
    SET @return = -1
    ROLLBACK TRANSACTION
  END
  ELSE
  BEGIN
  	COMMIT TRANSACTION
  END

END
GO

----------------------------------------------------------Unreturned loan check----------------------------------------------------------------

CREATE OR ALTER PROCEDURE dbo.LoanCheck
	@memID VARCHAR(5),
	@out INT OUTPUT
AS 
BEGIN

	DECLARE @M_ID SMALLINT = (SELECT m.M_ID FROM member m WHERE @memID = m.ID_withChar)
	IF EXISTS
	(
	SELECT *
	FROM loan
	WHERE M_ID = @M_ID
	AND L_ID NOT IN (SELECT L_ID FROM return_book)
	)
	BEGIN
		SET @out = 1 --Exists unreturned loan
	END
	ELSE 
	BEGIN
		SET @out = 0 --No unreturned loan
	END
END
GO

CREATE OR ALTER PROCEDURE dbo.UnreturnedLoanSearch
	@memID VARCHAR(5) 
AS
BEGIN

	SELECT
		L.ID_withChar AS 'Loan ID',
		m.ID_withChar AS 'Member ID',
		m.Name AS 'Member Name',
		CONVERT(varchar(10), L.Loan_date, 103) AS 'Loan Date',
		ISNULL(CONVERT(varchar(10), L.Due_date, 103), '-') AS 'Due Date',
		(SELECT COUNT(*) FROM loan_list ll WHERE ll.L_ID = l.L_ID) AS 'Number of loaned book',
		L.Loan_status AS 'Loan Status',
		ISNULL(rb.ID_withChar, '-') AS 'Return ID'
	FROM loan l
	JOIN member m ON l.M_ID = m.M_ID
	LEFT JOIN return_book rb ON l.L_ID = rb.L_ID
	WHERE @memID = m.ID_withChar AND l.Loan_status = 'Accepted' AND rb.RE_ID IS NULL 

END
GO

CREATE OR ALTER PROCEDURE dbo.SearchLoanList
	@LoanID VARCHAR(5)
AS
BEGIN
	
	DECLARE @L_ID SMALLINT = (SELECT L.L_ID FROM loan l WHERE l.ID_withChar = @LoanID)
	SELECT b.ID_withChar AS 'Book ID' FROM loan_list ll 
	JOIN book b ON b.B_ID = ll.B_ID
	WHERE ll.L_ID = @L_ID

END
GO

---------------------------------------------------------------------------------------------------------------------------------
CREATE OR ALTER PROCEDURE dbo.GetLoanList
	@loanID VARCHAR(5)
AS
BEGIN

	SELECT b.ID_withChar AS 'BookID', b.Title AS 'Book Title'
	FROM loan_list ll
	JOIN loan l ON ll.L_ID = l.L_ID
	JOIN book b ON ll.B_ID = b.B_ID
	WHERE l.ID_withChar = @loanID

END
GO

------------------------------------------------------ Insert new fine ------------------------------------------------------------------
CREATE OR ALTER PROCEDURE dbo.InsertFine
	@RE_ID SMALLINT,
	@memID VARCHAR(5),
	@fineDate DATE,
	@fineType VARCHAR(70)
AS
BEGIN
	DECLARE @FT_ID SMALLINT = (SELECT ft.FT_ID FROM fine_type ft WHERE ft.Title = @fineType)
	DECLARE @M_ID SMALLINT = (SELECT m.M_ID FROM member m WHERE @memID = m.ID_withChar)
  DECLARE @fine_amount DECIMAL(10,0) = (SELECT ft.Fine_amount FROM fine_type ft WHERE ft.FT_ID = @FT_ID)

	INSERT INTO fine (RE_ID, M_ID, Fine_date, FT_ID, Fine_status, Fine_amount, P_ID)
	VALUES (@RE_ID, @M_ID, @fineDate, @FT_ID, 'Unpaid', @fine_amount, NULL)

END
GO

-------------------------------------------------------------------- ------------------------------------------------------------------
CREATE OR ALTER PROCEDURE dbo.UnpaidFineSearch
	@memID VARCHAR(5)
AS 
BEGIN
	DECLARE @M_ID SMALLINT = (SELECT m.M_ID FROM member m WHERE @memID = m.ID_withChar)
	SELECT 
		m.ID_withChar AS 'Member ID',
		m.Name,
		ft.Title AS 'Fine Type',
		ft.Fine_amount AS 'Fine Amount',
		f.Fine_date AS 'Fine Date',
		f.Fine_status AS 'Status',
		ISNULL(p.ID_withChar, '-') AS 'Payment ID'

	FROM fine f
	JOIN fine_type ft ON f.FT_ID = ft.FT_ID
	JOIN member m ON f.M_ID = m.M_ID
	LEFT JOIN payment p ON f.P_ID = p.P_ID
	WHERE f.M_ID = @M_ID AND f.P_ID IS NULL
END 
GO

---------------------------------------------Trigger to update member status----------------------------------------------------------
CREATE TRIGGER dbo.trig_insert_fine
ON fine
AFTER INSERT
AS
  UPDATE member
  SET Mem_status = 'Fine unpaid'
  WHERE M_ID = (SELECT M_ID FROM INSERTED)
GO

------------------------------------------------------------Insert return list--------------------------------------------------------
CREATE OR ALTER PROCEDURE dbo.InsertReturnList
	@RE_ID SMALLINT,
	@BookList Book READONLY
AS
BEGIN

	INSERT INTO return_list(RE_ID, B_ID)
	SELECT @RE_ID, b.B_ID 
	FROM book b 
	INNER JOIN @BookList bl ON b.ID_withChar = bl.BookID

	UPDATE book_stock
	SET Stock_num = Stock_num + 1
	WHERE B_ID IN (SELECT b.B_ID FROM book b INNER JOIN @BookList bl ON b.ID_withChar = bl.BookID)

END
GO

---------------------------------------------------------------------------------------------------------------------------------
CREATE OR ALTER PROCEDURE dbo.GetReturnList
	@returnID VARCHAR(6)
AS 
BEGIN
	
	SELECT 
		b.ID_withChar AS 'Book ID',
		b.Title AS 'Book Title'
	FROM return_list rl
	JOIN return_book rb ON rl.RE_ID = rb.RE_ID
	JOIN book b ON rl.B_ID = b.B_ID
	WHERE rb.ID_withChar = @returnID
	
END

GO

----------------------------------------------------------------Insert new return--------------------------------------------------------------

CREATE OR ALTER PROCEDURE dbo.InsertReturn
	@memID VARCHAR(5),
	@returnDate DATE,
	@returnStatus VARCHAR(70),
	@BookList Book READONLY,
	@RE_ID_out SMALLINT OUTPUT,
	@return INT OUTPUT
AS
BEGIN
	DECLARE @M_ID SMALLINT = (SELECT m.M_ID FROM member m WHERE @memID = m.ID_withChar)

	DECLARE @L_ID SMALLINT
	SET @L_ID = 
			(SELECT L.L_ID FROM loan l 
			WHERE l.M_ID = @M_ID AND l.Loan_status = 'Accepted' 
			AND l.L_ID NOT IN (SELECT rb.L_ID FROM return_book rb))
	DECLARE @dueDate DATE = (SELECT L.Due_date FROM loan l WHERE l.L_ID = @L_ID)

	IF (@returnDate > @dueDate)
	BEGIN
    	IF (@returnStatus = 'Returned with damaged book')
		BEGIN
        	SET @returnStatus = 'Returned book overdue and damaged book'
        END
		ELSE
		BEGIN
        	SET @returnStatus = 'Returned book overdue'
        END
    END 
	
	INSERT INTO return_book (L_ID, Return_date, Return_status)
	VALUES (@L_ID, @returnDate, @returnStatus) 
	DECLARE @RE_ID SMALLINT = SCOPE_IDENTITY()
	EXEC InsertReturnList @RE_ID, @BookList

	SET @RE_ID_out = @RE_ID

	IF (@returnStatus <> 'Normal')
	BEGIN
		EXEC InsertFine @RE_ID, @memID, @returnDate, @returnStatus
		SET @return = (SELECT ft.FT_ID FROM fine_type ft WHERE ft.Title = @returnStatus) --Fine
	END
	ELSE
	BEGIN
    	SET @return = 0 --Normal
  END
END
GO
---------------------------------------------------------------------------------------------------------------------------------

CREATE OR ALTER PROCEDURE dbo.CheckReturnBookList
	@RE_ID SMALLINT
AS
BEGIN

	SELECT b.ID_withChar FROM book b
	WHERE b.B_ID IN 
		(SELECT ll.B_ID 
		FROM loan_list ll
		JOIN return_book rb ON ll.L_ID = rb.L_ID
		LEFT JOIN return_list rl ON rb.RE_ID = rl.RE_ID AND ll.B_ID = rl.B_ID
		WHERE rl.RE_ID IS NULL AND rb.RE_ID = @RE_ID)
		
END
GO

---------------------------------------------------------Insert payment------------------------------------------------------------------------
 CREATE OR ALTER Procedure dbo.InsertPayment
	@memID Varchar(5),
	@renewal_month INT,
	@pay_date Date,
	@pay_method Varchar(20),
	@pay_type Varchar(30)
As
Begin
	
	Declare @M_ID Smallint = (Select m.M_ID From member m Where @memID = ID_withChar)
  DECLARE @F_ID SMALLINT = (SELECT f.F_ID FROM fine f WHERE f.M_ID = @M_ID AND f.Fine_status = 'Unpaid')
	DECLARE @pay_amount DECIMAL(10,0)
	IF(@pay_type = 'Membership fee payment')
	BEGIN
		DECLARE @ex_date DATE
    SET @ex_date = (SELECT m.Expiry_date FROM membership m WHERE m.M_ID = @M_ID)
    
		SET @pay_amount = 
				(
				SELECT mt.Fee FROM membership ms 
				JOIN member m ON ms.M_ID = m.M_ID
				JOIN membership_type mt ON ms.MST_ID = mt.MST_ID
				WHERE ms.M_ID = @M_ID
				) * @renewal_month
		UPDATE membership 
		SET EXPIRY_DATE = DATEADD(MONTH, @renewal_month, @ex_date)
		WHERE M_ID = @M_ID
  END
	ELSE
	BEGIN
		SET @pay_amount = 
			(SELECT f.Fine_amount 
      FROM fine f
      WHERE f.M_ID = @M_ID AND f.P_ID IS NULL)
  END

	Insert Into payment (M_ID, Payment_date, Payment_amount, Payment_method, Payment_type)
	Values (@M_ID, @pay_date, @pay_amount, @pay_method, @pay_type)

END
GO

----------------------------------------------------Trigger to update fine status--------------------------------------------------------
CREATE TRIGGER dbo.trig_insert_payment
ON payment
AFTER INSERT
AS
  IF (SELECT Payment_type FROM INSERTED) = 'Fine payment'
  BEGIN
  	UPDATE member
    SET Mem_status = 'Normal'
    WHERE M_ID = (SELECT M_ID FROM INSERTED)

    UPDATE fine
    SET Fine_status = 'Paid',
        P_ID = (SELECT P_ID FROM INSERTED)
    WHERE M_ID = (SELECT M_ID FROM INSERTED)
    AND Fine_status = 'Unpaid'
  END
GO

-------------------------------------------------------------Show lists----------------------------------------------------------
CREATE OR ALTER Procedure dbo.MembershipList
As
Begin
	Select	
		m.ID_withChar As 'Member ID',
		m.Name,
		mst.Title As Membership,
		mst.Fee As 'Membership Fee',
		CONVERT(VARCHAR(10), ms.Expiry_date, 103) As 'Expiry date',
		ms.Membership_status As 'Status',
		ms.Created_time,
		ms.Updated_time
	From membership ms 
	Left Join member m On m.M_ID = ms.M_ID
	Join membership_type mst On mst.MST_ID = ms.MST_ID
End
GO


CREATE OR ALTER PROCEDURE dbo.LoanList
AS
BEGIN
	SELECT
		L.ID_withChar AS 'Loan ID',
		m.ID_withChar AS 'Member ID',
		CONVERT(varchar(10), L.Loan_date, 103) AS 'Loan Date',
		ISNULL(CONVERT(varchar(10), L.Due_date, 103), '-') AS 'Due Date',
		(SELECT COUNT(*) FROM loan_list ll WHERE ll.L_ID = l.L_ID) AS 'Number of loaned book',
		L.Loan_status AS 'Loan Status',
		ISNULL(rb.ID_withChar, '-') AS 'Return ID'
	FROM loan l
	JOIN member m ON l.M_ID = m.M_ID
	LEFT JOIN return_book rb ON l.L_ID = rb.L_ID
END
GO

CREATE OR ALTER PROCEDURE dbo.PaymentList
AS
BEGIN
	
	SELECT 
		P.ID_withChar AS 'Payment ID',
		m.ID_withChar AS 'Member ID',
		m.Name AS 'Member Name',
		P.Payment_type AS 'Payment Type',
		CONVERT(VARCHAR(10), P.Payment_date, 103) AS 'Payment Date',
		FORMAT(P.Payment_amount, 'N0') AS 'Payment Amount',
		P.Payment_method AS 'Payment Method'
	FROM payment p
	JOIN member m ON p.M_ID = m.M_ID
	
END
GO

CREATE OR ALTER PROCEDURE dbo.ReturnList
AS 
BEGIN
	
	SELECT 
		rb.ID_withChar AS 'Return ID',
		L.ID_withChar AS 'Loan ID',
		m.ID_withChar AS 'Member ID',
		CONVERT(VARCHAR(10), rb.Return_date, 103) AS 'Return Date',
		(SELECT COUNT(ll.B_ID) FROM loan_list ll WHERE ll.L_ID = l.L_ID) AS 'Loan quantity',
		(SELECT COUNT(rl.B_ID) FROM return_list rl WHERE rl.RE_ID = rb.RE_ID) AS 'Return quantity',
		rb.Return_status AS 'Return Status'
	FROM return_book rb
	JOIN loan l ON rb.L_ID = l.L_ID
	JOIN member m ON l.M_ID = m.M_ID

END
GO


CREATE OR ALTER PROCEDURE dbo.FineList
AS
BEGIN

	SELECT 
		f.ID_withChar AS 'Fine ID',
		m.ID_withChar AS 'Member ID',
		m.Name AS 'Member Name',
		ft.Title AS 'Fine Type',
		FORMAT(ft.Fine_amount, 'N0') AS 'Fine Amount',
		CONVERT(VARCHAR(10), f.Fine_date, 103) AS 'Fine Date',
		f.Fine_status AS 'Status',
		ISNULL(p.ID_withChar, '-') AS 'Payment ID'
	FROM fine f
	JOIN fine_type ft ON f.FT_ID = ft.FT_ID
	JOIN member m ON f.M_ID = m.M_ID
	LEFT JOIN payment p ON f.P_ID = p.P_ID

END
GO

-------------------------------------------------------------Views-------------------------------------------------------------------
CREATE or ALTER VIEW v_numberOfFinesByMember
AS
SELECT
  member.ID_withChar AS [Member ID]
 ,member.Name AS Name
 ,COUNT(fine.F_ID) AS [Number of fines]
 ,FORMAT(SUM(Fine_amount), 'N0') AS [Total amount]
FROM dbo.fine
INNER JOIN dbo.member
  ON fine.M_ID = member.M_ID
GROUP BY member.ID_withChar
        ,member.Name
GO

CREATE OR ALTER VIEW v_paymentStatistics
AS
SELECT
  member.ID_withChar AS [Member ID]
 ,member.Name AS Name
 ,(SELECT
      COUNT(p.P_ID) AS expr1
    FROM dbo.payment p
    WHERE p.M_ID = member.M_ID
    AND p.Payment_type = 'Membership fee payment')
  AS [Number of membership fee payments]
 ,(SELECT
      COUNT(p.P_ID) AS expr1
    FROM dbo.payment p
    WHERE p.M_ID = member.M_ID
    AND p.Payment_type = 'Fine payment')
  AS [Number of fine payments]
 ,COUNT(payment.P_ID) AS [Total number of payments]
 ,FORMAT(SUM(payment.Payment_amount), 'N0') AS [Total amount]
FROM dbo.payment
INNER JOIN dbo.member
  ON payment.M_ID = member.M_ID
GROUP BY member.ID_withChar
        ,member.Name
        ,member.M_ID
GO

CREATE OR ALTER VIEW v_unreturnedBooks
AS
SELECT
  book.ID_withChar AS [Book ID]
 ,book.Title
 ,COUNT(loan_list.B_ID) AS [Loaning quantity]
FROM dbo.loan_list
INNER JOIN dbo.book
  ON loan_list.B_ID = book.B_ID
INNER JOIN dbo.loan
  ON loan_list.L_ID = loan.L_ID
WHERE loan_list.L_ID NOT IN (SELECT rb.L_ID FROM return_book rb)
GROUP BY book.ID_withChar
        ,book.Title
GO

CREATE OR ALTER VIEW v_numberOfLoanedTimes
AS
SELECT
  book.ID_withChar AS [Book ID]
 ,book.Title
 ,COUNT(loan_list.B_ID) AS [Number of loaned times]
FROM dbo.loan_list
INNER JOIN dbo.book
  ON loan_list.B_ID = book.B_ID
GROUP BY book.ID_withChar
        ,book.Title
GO

CREATE OR ALTER VIEW v_LoanList
AS
SELECT
		L.ID_withChar AS 'Loan ID',
		m.ID_withChar AS 'Member ID',
		CONVERT(varchar(10), L.Loan_date, 103) AS 'Loan Date',
		ISNULL(CONVERT(varchar(10), L.Due_date, 103), '-') AS 'Due Date',
		(SELECT COUNT(*) FROM loan_list ll WHERE ll.L_ID = l.L_ID) AS 'Number of loaned book',
		L.Loan_status AS 'Loan Status',
		ISNULL(rb.ID_withChar, '-') AS 'Return ID'
	FROM loan l
	JOIN member m ON l.M_ID = m.M_ID
	LEFT JOIN return_book rb ON l.L_ID = rb.L_ID
GO

CREATE OR ALTER VIEW v_ReturnList
AS
SELECT 
		rb.ID_withChar AS 'Return ID',
		L.ID_withChar AS 'Loan ID',
		m.ID_withChar AS 'Member ID',
		CONVERT(VARCHAR(10), rb.Return_date, 103) AS 'Return Date',
		(SELECT COUNT(ll.B_ID) FROM loan_list ll WHERE ll.L_ID = l.L_ID) AS 'Loan quantity',
		(SELECT COUNT(rl.B_ID) FROM return_list rl WHERE rl.RE_ID = rb.RE_ID) AS 'Return quantity',
		rb.Return_status AS 'Return Status'
	FROM return_book rb
	JOIN loan l ON rb.L_ID = l.L_ID
	JOIN member m ON l.M_ID = m.M_ID
GO

CREATE OR ALTER VIEW v_FineList
AS
SELECT 
		f.ID_withChar AS 'Fine ID',
		m.ID_withChar AS 'Member ID',
		m.Name AS 'Member Name',
		ft.Title AS 'Fine Type',
		FORMAT(ft.Fine_amount, 'N0') AS 'Fine Amount',
		CONVERT(VARCHAR(10), f.Fine_date, 103) AS 'Fine Date',
		f.Fine_status AS 'Status',
		ISNULL(p.ID_withChar, '-') AS 'Payment ID'
	FROM fine f
	JOIN fine_type ft ON f.FT_ID = ft.FT_ID
	JOIN member m ON f.M_ID = m.M_ID
	LEFT JOIN payment p ON f.P_ID = p.P_ID
GO

CREATE OR ALTER VIEW v_PaymentList
AS
SELECT 
		P.ID_withChar AS 'Payment ID',
		m.ID_withChar AS 'Member ID',
		m.Name AS 'Member Name',
		P.Payment_type AS 'Payment Type',
		P.Payment_date AS 'Payment Date',
		P.Payment_amount AS 'Payment Amount',
		P.Payment_method AS 'Payment Method'
	FROM payment p
  JOIN member m ON p.M_ID = m.M_ID
GO

CREATE OR ALTER VIEW v_BookList
AS
SELECT b.ID_withChar As [Book ID], b.Title, b.Publication_Year As [Publication Year], 
			STUFF((SELECT ', ' + a.Name FROM author a
				  JOIN book_author ba ON a.AU_ID = ba.AU_ID
				  WHERE ba.B_ID = b.B_ID 
				  FOR XML PATH('')), 1, 2, '') AS [Author(s)],
			STUFF((SELECT ', ' + c.Title FROM category c
				  JOIN book_category bc ON c.CA_ID = bc.CA_ID
				  WHERE bc.B_ID = b.B_ID
				  FOR XML PATH('')), 1, 2, '') AS [Category(s)],
			bs.Stock_num As [Number in stock],
			b.Created_time, b.Updated_time
FROM book b
JOIN book_stock bs ON bs.B_ID = b.B_ID
GO

CREATE OR ALTER VIEW v_MemberList
AS
	SELECT 
		m.ID_withChar AS [Member ID],
		m.Name AS [Full name],
		m.Birthday AS [Date of birth],
		m.Sex,
		m.Phone,
		m.Mem_status AS [Member status],
		COALESCE(mst.Title, '-') AS [Membership],
		COALESCE(Cast(Format(mst.Fee, 'N0') As Varchar), '-') AS [Membership fee],
		COALESCE(Convert(Varchar(10), msh.Expiry_date, 103 ), '-') AS [Expiry date], 
		m.Created_time,
		m.Updated_time
	FROM 
		member m
		LEFT JOIN membership msh ON msh.M_ID = m.M_ID
		LEFT JOIN membership_type mst ON msh.MST_ID = mst.MST_ID
GO

---------------------------------------------------------- Data Filter ---------------------------------------------------------------
CREATE OR ALTER PROCEDURE dbo.FilterBooks
    @bookID VARCHAR(5) = NULL,
    @Title VARCHAR(100) = NULL,
    @Publication_year INT = NULL,
    @Author VARCHAR(100) = NULL,
    @Category VARCHAR(100) = NULL,
    @NumStock INT = NULL
AS
BEGIN
    SELECT *
    FROM v_BookList vbl
    WHERE (@bookID IS NULL OR [Book ID] = @bookID)
      AND (@Title IS NULL OR LOWER(Title) LIKE '%' + LOWER(@Title) + '%')
      AND (@Publication_year IS NULL OR [Publication Year] = @Publication_year)
      AND (@Author IS NULL OR LOWER([Author(s)]) LIKE '%' + LOWER(@Author) + '%')
      AND (@Category IS NULL OR LOWER([Category(s)]) LIKE '%' + LOWER(@Category) + '%')
      AND (@NumStock IS NULL OR vbl.[Number in stock] = @NumStock)
END
GO

GO
CREATE OR ALTER PROCEDURE FilterMembers
  @memID VARCHAR(5) = NULL,
  @name VARCHAR(100) = NULL,
  @DoB_day INT = NULL,
  @DoB_month INT = NULL, 
  @sex VARCHAR(10) = NULL,
  @membership VARCHAR(20) = NULL
AS
BEGIN
	SELECT 
    vml.[Member ID], 
    vml.[Full name], 
    CONVERT(VARCHAR(10), vml.[Date of birth], 103) AS [Date of birth],
    vml.Sex, vml.Phone, 
    vml.[Member status], 
    vml.Membership, 
    vml.[Membership fee], 
    vml.[Expiry date], 
    vml.Created_time, 
    vml.Updated_time
  FROM v_MemberList vml
  WHERE (@memID IS NULL OR [vml].[Member ID] = @memID)
    AND (@name IS NULL OR vml.[Full name] = @name)
    AND (@sex IS NULL OR vml.Sex = @sex)
    AND (@DoB_day IS NULL OR DAY(vml.[Date of birth]) = @DoB_day)
    AND (@DoB_month IS NULL OR MONTH(vml.[Date of birth]) = @DoB_month)
    AND (@membership IS NULL OR vml.Membership = @membership)
END
GO

---------------------------------------------------------- Statistical views ---------------------------------------------------------------
CREATE OR ALTER VIEW v_RevenueSta
AS
  SELECT
    vpl.[Payment Date],
    sum(vpl.[Payment Amount]) AS [Total Amount]
  FROM v_PaymentList vpl
  GROUP BY vpl.[Payment Date]
GO

CREATE OR ALTER VIEW v_PaymentMethodSta
AS
  SELECT
    [Payment Method],
    COUNT(*) AS [Number Of Payments],
    SUM([Payment Amount]) AS [Total Amount]
  FROM v_PaymentList
  GROUP BY [Payment Method]
GO

CREATE OR ALTER VIEW v_PaymentTypeSta
AS
  SELECT
    vpl.[Payment Type] AS [Type],
    SUM(vpl.[Payment Amount]) AS [Total]
  FROM v_PaymentList vpl
  GROUP BY vpl.[Payment Type]
GO

CREATE OR ALTER VIEW v_LoanedQuantitySta
AS
  SELECT
    SUM(vll.[Number of loaned book]) AS [Number of loaned books],
    vll.[Loan Date]
  FROM v_LoanList vll
  WHERE vll.[Number of loaned book] > 0
  GROUP BY vll.[Loan Date]
GO

CREATE OR ALTER VIEW v_LoanStatusSta
AS
  SELECT
    'Accepted' AS Status,
    COUNT(*) AS Quantity
  FROM v_LoanList vll
  WHERE vll.[Number of loaned book] > 0
  UNION
  SELECT
    'Declined' AS Status,
    COUNT(*) AS Quantity
  FROM v_LoanList vll
  WHERE vll.[Number of loaned book] = 0
GO

CREATE OR ALTER VIEW v_LoanByMemberSta
AS
  SELECT
    vll.[Member ID],
    COUNT(*) AS [Total loans]
  FROM v_LoanList vll
  GROUP BY vll.[Member ID]
GO

CREATE OR ALTER VIEW v_ReturnStatusSta
AS
  SELECT 
    'Valid' AS[Status], 
    COUNT(*) AS[Quantity]
  FROM v_ReturnList vrl
  WHERE vrl.[Return Status] = 'Normal'
  UNION
  SELECT
    'Invalid' AS[Status], 
    COUNT(*) AS[Quantity]
  FROM v_ReturnList vrl
  WHERE vrl.[Return Status] <> 'Normal'
GO

CREATE OR ALTER VIEW v_FineTypeSta
AS
  SELECT
    vfl.[Fine Type],
    COUNT(*) AS[Quantity],
    SUM(vfl.[Fine Amount]) AS[Total amount]
  FROM v_FineList vfl
  GROUP BY vfl.[Fine Type]
GO


--=====================================================================================================================================--
-------------------------------------------------------------- Initial Data -------------------------------------------------------------
--=====================================================================================================================================--

GO
Insert Into membership_type (Title, Fee, Max_num_book, Max_loan_day)
Values 
('Bronze', 50000, 5, 7),
('Silver', 100000, 7, 10),
('Gold', 150000, 10, 14)

GO
INSERT INTO fine_type (Title, Fine_amount)
VALUES 
('Returned book overdue', 30000),
('Returned with damaged book', 50000),
('Returned book overdue and damaged book', 80000)
-- The 'Title' of the records from the fine_type table should not be changed, however, you can modify the 'Fine_amount' attribute