USE [master]
GO
/****** Object:  Database [RFBDesktopApp]    Script Date: 9/4/2021 9:11:53 PM ******/
CREATE DATABASE [RFBDesktopApp]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'RFBDesktopApp', FILENAME = N'C:\Users\home pc\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\RFBDesktopApp.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'RFBDesktopApp_log', FILENAME = N'C:\Users\home pc\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\RFBDesktopApp.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [RFBDesktopApp] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [RFBDesktopApp].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [RFBDesktopApp] SET ANSI_NULL_DEFAULT ON 
GO
ALTER DATABASE [RFBDesktopApp] SET ANSI_NULLS ON 
GO
ALTER DATABASE [RFBDesktopApp] SET ANSI_PADDING ON 
GO
ALTER DATABASE [RFBDesktopApp] SET ANSI_WARNINGS ON 
GO
ALTER DATABASE [RFBDesktopApp] SET ARITHABORT ON 
GO
ALTER DATABASE [RFBDesktopApp] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [RFBDesktopApp] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [RFBDesktopApp] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [RFBDesktopApp] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [RFBDesktopApp] SET CURSOR_DEFAULT  LOCAL 
GO
ALTER DATABASE [RFBDesktopApp] SET CONCAT_NULL_YIELDS_NULL ON 
GO
ALTER DATABASE [RFBDesktopApp] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [RFBDesktopApp] SET QUOTED_IDENTIFIER ON 
GO
ALTER DATABASE [RFBDesktopApp] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [RFBDesktopApp] SET  DISABLE_BROKER 
GO
ALTER DATABASE [RFBDesktopApp] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [RFBDesktopApp] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [RFBDesktopApp] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [RFBDesktopApp] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [RFBDesktopApp] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [RFBDesktopApp] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [RFBDesktopApp] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [RFBDesktopApp] SET RECOVERY FULL 
GO
ALTER DATABASE [RFBDesktopApp] SET  MULTI_USER 
GO
ALTER DATABASE [RFBDesktopApp] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [RFBDesktopApp] SET DB_CHAINING OFF 
GO
ALTER DATABASE [RFBDesktopApp] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [RFBDesktopApp] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [RFBDesktopApp] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [RFBDesktopApp] SET QUERY_STORE = OFF
GO
USE [RFBDesktopApp]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [RFBDesktopApp]
GO
/****** Object:  Table [dbo].[Address]    Script Date: 9/4/2021 9:11:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Address](
	[AddressID] [int] IDENTITY(1,1) NOT NULL,
	[HouseNo] [varchar](250) NOT NULL,
	[Street] [varchar](250) NOT NULL,
	[Barangay] [varchar](250) NOT NULL,
	[City] [varchar](250) NOT NULL,
	[Person_ID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[AddressID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Attendance]    Script Date: 9/4/2021 9:11:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Attendance](
	[Attendance_ID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeName] [varchar](250) NOT NULL,
	[Time_in] [varchar](250) NOT NULL,
	[Time_out] [varchar](250) NOT NULL,
	[Total_Work_Hrs] [int] NULL,
	[Work_date] [datetime] NOT NULL,
	[RecordedBy] [varchar](250) NOT NULL,
	[Employee_ID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Attendance_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 9/4/2021 9:11:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[CustomerID] [int] IDENTITY(1,1) NOT NULL,
	[Customer_Status] [varchar](250) NOT NULL,
	[Person_ID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Dispatch]    Script Date: 9/4/2021 9:11:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dispatch](
	[Dispatch_ID] [int] IDENTITY(1,1) NOT NULL,
	[TimeIn] [varchar](250) NOT NULL,
	[TimeOut] [varchar](250) NOT NULL,
	[Team1] [varchar](250) NOT NULL,
	[Team2] [varchar](250) NOT NULL,
	[Team3] [varchar](250) NOT NULL,
	[DispatchRecorded] [timestamp] NOT NULL,
	[DispatchDate] [datetime] NULL,
	[ServiceID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Dispatch_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 9/4/2021 9:11:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[EmployeeID] [int] IDENTITY(1,1) NOT NULL,
	[Status] [varchar](250) NOT NULL,
	[DateHired] [datetime] NULL,
	[Position] [varchar](250) NOT NULL,
	[TypeOfContract] [varchar](250) NOT NULL,
	[Person_ID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Login]    Script Date: 9/4/2021 9:11:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[LoginID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](250) NULL,
	[Password] [varchar](250) NULL,
PRIMARY KEY CLUSTERED 
(
	[LoginID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[orders]    Script Date: 9/4/2021 9:11:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[orders](
	[orderid] [int] IDENTITY(1,1) NOT NULL,
	[price] [nvarchar](250) NOT NULL,
	[orderdate] [date] NOT NULL,
 CONSTRAINT [PK_orders] PRIMARY KEY CLUSTERED 
(
	[orderid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PayRoll]    Script Date: 9/4/2021 9:11:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PayRoll](
	[PayRoll_ID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeName] [varchar](250) NULL,
	[PayRolltime] [timestamp] NOT NULL,
	[Total_Amount] [int] NOT NULL,
	[PayRoll_Date] [datetime] NULL,
	[Hrsly_rate] [int] NOT NULL,
	[Total_Work_Hrs] [varchar](250) NOT NULL,
	[RecordedBy] [varchar](250) NOT NULL,
	[Employee_ID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[PayRoll_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[People]    Script Date: 9/4/2021 9:11:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[People](
	[PersonID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[MobileNo] [varchar](50) NOT NULL,
	[TelephoneNo] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PersonID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Schedule]    Script Date: 9/4/2021 9:11:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Schedule](
	[SchedID] [int] IDENTITY(1,1) NOT NULL,
	[Quantity] [int] NOT NULL,
	[ServiceType] [varchar](250) NOT NULL,
	[AcType] [varchar](250) NOT NULL,
	[ServiceDate] [datetime] NULL,
	[ServiceTime] [varchar](250) NOT NULL,
	[Brand] [varchar](250) NOT NULL,
	[ServiceStatus] [varchar](250) NOT NULL,
	[RecordedBy] [varchar](250) NULL,
	[TimeRecorded] [timestamp] NOT NULL,
	[Person_ID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[SchedID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ServiceType]    Script Date: 9/4/2021 9:11:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ServiceType](
	[ServicesID] [int] IDENTITY(1,1) NOT NULL,
	[ServiceName] [varchar](250) NOT NULL,
	[Price] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[ServicesID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Address]  WITH CHECK ADD FOREIGN KEY([Person_ID])
REFERENCES [dbo].[People] ([PersonID])
GO
ALTER TABLE [dbo].[Attendance]  WITH CHECK ADD FOREIGN KEY([Employee_ID])
REFERENCES [dbo].[Employee] ([EmployeeID])
GO
ALTER TABLE [dbo].[Customer]  WITH CHECK ADD FOREIGN KEY([Person_ID])
REFERENCES [dbo].[People] ([PersonID])
GO
ALTER TABLE [dbo].[Dispatch]  WITH CHECK ADD FOREIGN KEY([ServiceID])
REFERENCES [dbo].[Schedule] ([SchedID])
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD FOREIGN KEY([Person_ID])
REFERENCES [dbo].[People] ([PersonID])
GO
ALTER TABLE [dbo].[PayRoll]  WITH CHECK ADD FOREIGN KEY([Employee_ID])
REFERENCES [dbo].[Employee] ([EmployeeID])
GO
ALTER TABLE [dbo].[Schedule]  WITH CHECK ADD FOREIGN KEY([Person_ID])
REFERENCES [dbo].[People] ([PersonID])
GO
/****** Object:  StoredProcedure [dbo].[SpAddCustomer]    Script Date: 9/4/2021 9:11:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SpAddCustomer] 

		-- People Table 
    		@FirstName varchar(250),
    		@LastName varchar(250), 
    		@MobileNo varchar(250),
    		@TelephoneNo varchar(250),
			-- Address table 
			@HouseNo int, 
			@Street varchar(250),
			@Barangay varchar(250),
			@City varchar(250),


			-- Status 
			@Cus_Status varchar(250)

	
AS

	SET NOCOUNT ON;
	DECLARE @PersonID int

	INSERT INTO People(FirstName,LastName,MobileNo,TelephoneNo)
    	VALUES(@FirstName,@LastName,@MobileNo,@TelephoneNo)

	SET @PersonID = SCOPE_IDENTITY();

	INSERT INTO Customer(Customer_Status, Person_ID)VALUES(@Cus_Status, @PersonID)

	INSERT INTO Address(HouseNo, Street, Barangay, City, Person_ID)
	VALUES(@HouseNo, @Street, @Barangay, @City, @PersonID)

--https://www.youtube.com/watch?v=w6mOplKiVok
 
GO
/****** Object:  StoredProcedure [dbo].[SpAddEmp]    Script Date: 9/4/2021 9:11:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SpAddEmp]

-- Made on 2/6/21
		-- Author: Angelo Burias

		@FirstName varchar(250),
		@LastName varchar(250),
		@MobileNo varchar(250),
		@TelephoneNo varchar(250),
		@DateHired datetime,
		@Status varchar(250),
		@Position varchar(250),
		@TypeOfContract varchar(250)



AS 
		
BEGIN 
		DECLARE @Person_ID INT 
		SET NOCOUNT ON;

		INSERT INTO People(FirstName, LastName, MobileNo, TelephoneNo)
		VALUES (@FirstName, @LastName, @MobileNo, @TelephoneNo)

		SET @Person_ID = SCOPE_IDENTITY();

		INSERT INTO Employee(DateHired, Status, Position,TypeOfContract, Person_ID)
		VALUES(@DateHired, @Status, @Position,@TypeOfContract, @Person_ID)



END
GO
/****** Object:  StoredProcedure [dbo].[SpAddPayRoll]    Script Date: 9/4/2021 9:11:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SpAddPayRoll]

-- Made on 2/6/21
		-- Author: Angelo Burias


		@Employee_ID int,
		@Amount decimal,
		@Pr_date datetime
		


AS 
		
BEGIN 
		SET NOCOUNT ON;

		INSERT INTO PayRoll(Employee_ID, Amount, PayRoll_Date)
		VALUES (@Employee_ID,@Amount, @Pr_date)

		


END
GO
/****** Object:  StoredProcedure [dbo].[SpAttendance_GetEmp]    Script Date: 9/4/2021 9:11:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Created on: 7/2/21
-- Author: Angelo Burias


CREATE PROCEDURE [dbo].[SpAttendance_GetEmp] 


AS

SET NOCOUNT ON;


BEGIN

	SELECT  CONCAT(peo.FirstName, ' ',  peo.LastName) AS 'Employee', emp.EmployeeID, emp.Position FROM People as peo 
	INNER JOIN Employee as emp on peo.PersonID = emp.Person_ID


END
GO
/****** Object:  StoredProcedure [dbo].[SpCustomerList]    Script Date: 9/4/2021 9:11:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROC [dbo].[SpCustomerList]

-- Created on 8/19/22 by Angelo Burias

AS 

SET NOCOUNT ON;

BEGIN 

		SELECT cus.CustomerID, cus.Customer_Status, pe.FirstName, pe.LastName, pe.MobileNo, pe.TelephoneNo, addr.HouseNo, addr.Street, addr.Barangay, addr.City, pe.PersonID
		FROM Customer as cus inner join People as pe on pe.PersonID = cus.Person_ID inner join Address as addr on cus.Person_ID = addr.Person_ID


		--SELECT sch.SchedID,Pe.FirstName, Pe.LastName, sch.ServiceType,sch.ServiceStatus, dp.TimeIn, dp.TimeOut, Team1, dp.Team2, dp.Team3, dp.DispatchDate
		--FROM Schedule as sch inner join Dispatch as dp on sch.SchedID = dp.ServiceID inner join People as pe on Pe.PersonID = sch.Person_ID
END 
GO
/****** Object:  StoredProcedure [dbo].[SpDeleteEmployee]    Script Date: 9/4/2021 9:11:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROC [dbo].[SpDeleteEmployee]

		@Person_Id int,
		@Emp_Id int
as 

BEGIN
		SET NOCOUNT ON;
		
		
DELETE FROM Employee where EmployeeID = @Emp_Id
DELETE FROM People where PersonID = @Person_Id
--set @Person_Id = SCOPE_IDENTITY();

--set @Emp_Id = SCOPE_IDENTITY();

--DELETE FROM PayRoll where Employee_ID = @Emp_Id

--DELETE FROM Schedule where Person_ID = @Person_Id


END
GO
/****** Object:  StoredProcedure [dbo].[SpDisplayEmpPr]    Script Date: 9/4/2021 9:11:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Created on: 2/6/21
-- Author: Angelo Burias


CREATE PROCEDURE [dbo].[SpDisplayEmpPr] 


AS

SET NOCOUNT ON;


BEGIN

	Select emp.EmployeeID,p.FirstName, p.LastName,emp.Status,  emp.Position,emp.TypeOfContract, emp.Status, emp.DateHired FROM Employee as emp 
	inner join People p on emp.EmployeeID = p.PersonID

END
GO
/****** Object:  StoredProcedure [dbo].[SpFinishedSched]    Script Date: 9/4/2021 9:11:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROC [dbo].[SpFinishedSched]


AS 

SET NOCOUNT ON;

BEGIN 
		SELECT dp.Dispatch_ID,sch.SchedID,Pe.FirstName, Pe.LastName, sch.ServiceType,
		sch.ServiceStatus,dp.TimeIn, dp.TimeOut, Team1, dp.Team2, dp.Team3, dp.DispatchDate
		FROM Schedule as sch inner join Dispatch as dp on sch.SchedID = dp.ServiceID 
		inner join People as pe on Pe.PersonID = sch.Person_ID and sch.ServiceStatus = 'Done'
		where pe.PersonID = sch.Person_ID
END 
GO
/****** Object:  StoredProcedure [dbo].[SpGetDispatched]    Script Date: 9/4/2021 9:11:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROC [dbo].[SpGetDispatched]


AS 

SET NOCOUNT ON;

BEGIN 
		SELECT dp.Dispatch_ID, sch.SchedID, Pe.FirstName, Pe.LastName, sch.ServiceType,
		sch.ServiceStatus , dp.TimeIn , dp.TimeOut, Team1, dp.Team2, dp.Team3, dp.DispatchDate

		FROM Schedule as sch inner join Dispatch as dp on sch.SchedID = dp.ServiceID 
		inner join People as pe on Pe.PersonID = sch.Person_ID and sch.ServiceStatus = 'Not Done' 
		or sch.ServiceStatus = 'Dispatched' where pe.PersonID = sch.Person_ID
END 
GO
/****** Object:  StoredProcedure [dbo].[SpGetEmp]    Script Date: 9/4/2021 9:11:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Created on: 2/6/21
-- Author: Angelo Burias


CREATE PROCEDURE [dbo].[SpGetEmp] 


AS

SET NOCOUNT ON;


BEGIN

	Select emp.EmployeeID,p.FirstName, p.LastName,emp.Status,  emp.Position,emp.TypeOfContract,p.MobileNo, p.TelephoneNo, emp.DateHired, p.PersonID FROM Employee as emp 
	inner join People p on p.PersonID = emp.Person_ID

END
GO
/****** Object:  StoredProcedure [dbo].[SpGetEmpAtt]    Script Date: 9/4/2021 9:11:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SpGetEmpAtt]

AS 

BEGIN 

SET NOCOUNT ON;

SELECT emp.EmployeeID, P.FirstName, P.LastName, emp.Position FROM Employee as emp
inner join People P on P.PersonID = emp.EmployeeID


END

GO
/****** Object:  StoredProcedure [dbo].[SpGetNoOfDispatched]    Script Date: 9/4/2021 9:11:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- created on 9/2/21

CREATE PROCEDURE [dbo].[SpGetNoOfDispatched]

AS 



BEGIN 

		SELECT count(Dispatch_ID) FROM Dispatch as NumberOfDispatch 

END
GO
/****** Object:  StoredProcedure [dbo].[SpGetPayRoll]    Script Date: 9/4/2021 9:11:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Created on: 2/6/21
-- Author: Angelo Burias


CREATE PROCEDURE [dbo].[SpGetPayRoll] 


AS

SET NOCOUNT ON;


BEGIN


	SELECT  pr.PayRoll_ID, p.FirstName, p.LastName, pr.Total_Amount,pr.Total_Work_Hrs,pr.RecordedBy,pr.PayRoll_Date

	FROM Employee emp inner join PayRoll pr
	on emp.EmployeeID = pr.Employee_ID inner join People p
	on emp.Person_ID = p.PersonID 
	where pr.Employee_ID = pr.Employee_ID
	
	--Select emp.EmployeeID,p.FirstName, p.LastName,emp.Status,  emp.Position,emp.TypeOfContract, emp.Status, emp.DateHired FROM Employee as emp 
	--inner join People p on emp.EmployeeID = p.PersonID

END
GO
/****** Object:  StoredProcedure [dbo].[SpGetPayRolls]    Script Date: 9/4/2021 9:11:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SpGetPayRolls]

AS 
SET NOCOUNT ON;

BEGIN 


SELECT p.FirstName, p.LastName,pr.PayRoll_Date, e.Position, e.Status, pr.Amount
FROM People as p inner join Employee as e on p.PersonID = e.Person_ID 
inner join PayRoll as pr on e.EmployeeID = pr.Employee_ID


END
GO
/****** Object:  StoredProcedure [dbo].[SpGetSample]    Script Date: 9/4/2021 9:11:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Created on: 2/6/21
-- Author: Angelo Burias


CREATE PROCEDURE [dbo].[SpGetSample] 


AS

SET NOCOUNT ON;


BEGIN

	SELECT year(orderdate) as Year, count (orderid) as TOTAL
	FROM orders 

	WHERE orderdate is not null 
	group by year(orderdate)
	order by year(orderdate) asc
	
	
END
GO
/****** Object:  StoredProcedure [dbo].[SpGetServicesOffered]    Script Date: 9/4/2021 9:11:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Created on 8-21-2021

CREATE PROC [dbo].[SpGetServicesOffered]


AS 

SET NOCOUNT ON;

BEGIN 
		SELECT ServicesID, ServiceName
		FROM ServiceType
END 
GO
/****** Object:  StoredProcedure [dbo].[SpInsertDispatch]    Script Date: 9/4/2021 9:11:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SpInsertDispatch]

-- Author: Angelo B. Burias
 
	@TimeIn varchar(250), 
	@TimeOut varchar(250),
	@Team1 varchar(250),
	@Team2 varchar(250),
	@Team3 varchar(250),
	@ServiceTime varchar(250),
	@ServiceDate datetime, 
	@Brand varchar(250),
	@Quantity int, 
	@ServiceType varchar(250), 
	@Actype varchar(250),
	@DispatchDate datetime,
	@Status  varchar(250),
	@SchedID int
	

AS 
	--DECLARE @SchedID int

	SET NOCOUNT ON;

	INSERT INTO Schedule(Quantity, ServiceType, Actype, ServiceDate, ServiceTime, Brand,ServiceStatus, Person_ID)
	VALUES (@Quantity, @ServiceType, @Actype, @ServiceDate, @ServiceTime, @Brand,@Status, @SchedID)

	--SET @SchedID = SCOPE_IDENTITY();
	 
	INSERT INTO Dispatch(TimeIn,TimeOut,Team1,Team2,Team3,DispatchDate,ServiceID)
	VALUES (@TimeIn, @TimeOut, @Team1, @Team2, @Team3, @DispatchDate, @SchedID)

	
	
GO
/****** Object:  StoredProcedure [dbo].[SpInsertDispatch1]    Script Date: 9/4/2021 9:11:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SpInsertDispatch1]

-- Author: Angelo B. Burias
 
	@TimeIn varchar(250), 
	@TimeOut varchar(250),

	@Team1 varchar(250),
	@Team2 varchar(250),
	@Team3 varchar(250),

	@ServiceTime varchar(250),
	@ServiceDate datetime, 
	@Brand varchar(250),
	@Quantity int, 
	@ServiceType varchar(250), 

	@Actype varchar(250),
	@DispatchDate datetime,
	@SchedID int

AS 
	--DECLARE @SchedID int

	SET NOCOUNT ON;

	INSERT INTO Schedule(Quantity, ServiceType, Actype, ServiceDate, ServiceTime, Brand, Person_ID)
	VALUES (@Quantity, @ServiceType, @Actype, @ServiceDate, @ServiceTime, @Brand, @SchedID)

	--SET @SchedID = SCOPE_IDENTITY();
	 
	INSERT INTO Dispatch(TimeIn,TimeOut,Team1,Team2,Team3,DispatchDate,ServiceID)
	VALUES (@TimeIn, @TimeOut, @Team1, @Team2, @Team3, @DispatchDate, @SchedID)

	
	
GO
/****** Object:  StoredProcedure [dbo].[SpInsertNewDispatch]    Script Date: 9/4/2021 9:11:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

		-- Author: Angelo B. Burias

CREATE PROCEDURE [dbo].[SpInsertNewDispatch] 

	-- People Table 
    	@FirstName varchar(250),
    	@LastName varchar(250), 
    	@MobileNo varchar(250),
    	@TelephoneNo varchar(250),

		
		-- Address table 
		@HouseNo int, 
		@Street varchar(250),
		@Barangay varchar(250),
		@City varchar(250),


		-- Service details table
		@Quantity int, 
		@ServiceType varchar(250),
		@Brand varchar(250), 
		@AcType varchar(250),
		@ServiceTime varchar(250),
		@ServiceDate datetime,
		@ServiceStatus varchar(250),
		@RecordedBy varchar(250),

		@TimeIn varchar(250),
		@TimeOut varchar(250),
		@Team1 varchar(250),
		@Team2 varchar(250),
		@Team3 varchar(250),
		@DispatchDate datetime
	

		AS
		BEGIN 

		SET NOCOUNT ON;

		DECLARE @PersonID int
		DECLARE @SchedID int

		INSERT INTO People(FirstName,LastName,MobileNo,TelephoneNo)
    	VALUES(@FirstName,@LastName,@MobileNo,@TelephoneNo)

		SET @PersonID = SCOPE_IDENTITY(); -- returns ID of the recent Person

		INSERT INTO Schedule(Quantity,ServiceType, AcType, Brand,ServiceDate, ServiceTime,ServiceStatus, RecordedBy, Person_ID)
		VALUES(@Quantity, @ServiceType,@AcType, @Brand,@ServiceDate, @ServiceTime,@ServiceStatus, @RecordedBy, @PersonID )

		SET @SchedID = SCOPE_IDENTITY(); -- returns ID of the recent Schedule

		INSERT INTO Address(HouseNo, Street, Barangay, City, Person_ID)
		VALUES(@HouseNo, @Street, @Barangay, @City, @PersonID)

		INSERT INTO Dispatch(TimeIn, TimeOut,Team1,Team2, Team3, DispatchDate, ServiceID)
		VALUES(@TimeIn,@TimeOut,@Team1,@Team2,@Team3,@DispatchDate, @SchedID)

END
GO
/****** Object:  StoredProcedure [dbo].[SpInsertSchedule]    Script Date: 9/4/2021 9:11:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SpInsertSchedule] 

		-- People Table 
    		@FirstName varchar(250),
    		@LastName varchar(250), 
    		@MobileNo varchar(250),
    		@TelephoneNo varchar(250),

		-- Service details table
		@Quantity int, 
		@ServiceType varchar(250),
		@Brand varchar(250), 
		@AcType varchar(250),
		@ServiceTime varchar(250),
		@ServiceDate datetime,
		@RecordedBy varchar(250),
		
		-- Address table 
		@HouseNo int, 
		@Street varchar(250),
		@Barangay varchar(250),
		@City varchar(250),


		-- Status 
		@Status varchar(250)

	
AS

	SET NOCOUNT ON;
	DECLARE @PersonID int

	INSERT INTO People(FirstName,LastName,MobileNo,TelephoneNo)
    	VALUES(@FirstName,@LastName,@MobileNo,@TelephoneNo)

	SET @PersonID = SCOPE_IDENTITY();

	INSERT INTO Schedule(Quantity,ServiceType,ServiceStatus, AcType, Brand,ServiceDate, ServiceTime, RecordedBy, Person_ID)
	VALUES(@Quantity, @ServiceType,@Status, @AcType, @Brand,@ServiceDate, @ServiceTime, @RecordedBy, @PersonID )


	INSERT INTO Customer(Customer_Status, Person_ID)VALUES('Active', @PersonID)

	INSERT INTO Address(HouseNo, Street, Barangay, City, Person_ID)
	VALUES(@HouseNo, @Street, @Barangay, @City, @PersonID)

--https://www.youtube.com/watch?v=w6mOplKiVok
 
GO
/****** Object:  StoredProcedure [dbo].[SpLoginUser]    Script Date: 9/4/2021 9:11:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

	CREATE PROCEDURE [dbo].[SpLoginUser]
		@Uname varchar(250),	
		@Pwd varchar(250)


		
AS
BEGIN 

SET NOCOUNT ON;
		select UserName,Password FROM Login 
		where UserName = @Uname and password = @Pwd;

END
GO
/****** Object:  StoredProcedure [dbo].[SpNCRChart]    Script Date: 9/4/2021 9:11:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROC [dbo].[SpNCRChart]

	--@Cleaning varchar(250)
	

as 
	SET NOCOUNT ON;


	


BEGIN



SELECT  (
    SELECT COUNT(City) 
    FROM   Address
	where City = 'Caloocan'
) AS caloocan,
(
    SELECT COUNT(City)
    FROM   Address
	WHERE City = 'Las Pinas'
) AS laspinas,
(
    SELECT COUNT(City)
    FROM   Address
	WHERE City = 'Mandaluyong'
) AS mandaluyong,
(
	SELECT COUNT(City)
	FROM Address
	WHERE City = 'Makati'
)AS makati,
(
	SELECT COUNT(City)
	FROM Address
	WHERE City = 'Muntinlupa'
)AS muntinlupa,
(
	SELECT COUNT(City)
	FROM Address
	WHERE City = 'Manila'
)AS manila,

(
	SELECT COUNT(City)
	FROM Address
	WHERE City = 'Malabon'
)AS malabon,

(
	SELECT COUNT(City)
	FROM Address
	WHERE City = 'Navotas'
)AS navotas,

(
	SELECT COUNT(City)
	FROM Address
	WHERE City = 'Pasig'
)AS pasig,

(
	SELECT COUNT(City)
	FROM Address
	WHERE City = 'Pasay'
)AS pasay,

(
	SELECT COUNT(City)
	FROM Address
	WHERE City = 'Pateros'
)AS pateros,

(
	SELECT COUNT(City)
	FROM Address
	WHERE City = 'Paranaque'
)AS paranaque,

(
	SELECT COUNT(City)
	FROM Address
	WHERE City = 'Quezon'
)AS quezon,
(
	SELECT COUNT(City)
	FROM Address
	WHERE City = 'San Juan'
)AS sanjuan,

(
	SELECT COUNT(City)
	FROM Address
	WHERE City = 'Taguig'
)AS taguig,

(
	SELECT COUNT(City)
	FROM Address
	WHERE City = 'Valenzuela'
)AS valenzuela
END 
GO
/****** Object:  StoredProcedure [dbo].[SpNewAdmin]    Script Date: 9/4/2021 9:11:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROC [dbo].[SpNewAdmin] 

		@UserName varchar(250),
		@Password varchar(250)

		
AS
BEGIN 
SET NOCOUNT ON;
	INSERT INTO Login(UserName, Password) VALUES(@UserName, @Password)


END
GO
/****** Object:  StoredProcedure [dbo].[SpPayRoll]    Script Date: 9/4/2021 9:11:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Created on: 2/6/21
-- Author: Angelo Burias


CREATE PROCEDURE [dbo].[SpPayRoll] 

		@EmployeeName varchar(250),
		 @To_date datetime,
		 @Frm_date datetime
as 

SET NOCOUNT ON;


BEGIN

		
		SELECT emp.EmployeeID, att.EmployeeName, emp.Position, att.Work_date FROM Attendance as att 
		INNER JOIN Employee as emp ON att.Employee_ID = emp.EmployeeID 
		WHERE att.EmployeeName = @EmployeeName 
		AND att.Work_date > @To_date AND @Frm_date < att.Work_date
	


		--INSERT INTO Attendance(EmployeeName,Time_in,Time_out,Work_date,RecordedBy)
  --  	VALUES(@EmployeeName,@Time_in,@Time_out,@Work_Date,@RecordedBy)

		--SET @EmpID = SCOPE_IDENTITY();

END
GO
/****** Object:  StoredProcedure [dbo].[SpServices]    Script Date: 9/4/2021 9:11:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SpServices] 

AS

SET NOCOUNT ON;

BEGIN

	
Select D.SchedID,R.FirstName,R.LastName, R.MobileNo, R.TelephoneNo, P.HouseNo,
P.Street, P.Barangay, P.City, D.Quantity,D.Brand, D.ServiceDate, D.ServiceTime, D.ServiceType, D.AcType, 
D.RecordedBy, D.ServiceStatus

from People R inner join Schedule D 
on R.PersonID = D.Person_ID Inner join Address P 
on R.PersonID = P.Person_ID 
where R.PersonID = D.Person_ID and D.ServiceStatus = 'Schedule' 


--Select D.SchedID,R.FirstName,R.LastName, R.MobileNo, R.TelephoneNo, P.HouseNo,
--P.Street, P.Barangay, P.City, D.Quantity,D.Brand, D.ServiceDate, D.ServiceTime, D.ServiceType, D.AcType, 
--D.RecordedBy from People R inner join Schedule D on R.PersonID = D.SchedID 
--Inner join Address P on D.Person_ID = P.AddressID 
--where R.PersonID = D.SchedID

END 
GO
/****** Object:  StoredProcedure [dbo].[SpServicesChart]    Script Date: 9/4/2021 9:11:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROC [dbo].[SpServicesChart]

	--@Cleaning varchar(250)
	

as 
	SET NOCOUNT ON;


	


BEGIN



SELECT  (
    SELECT COUNT(ServiceType) 
    FROM   Schedule
	where ServiceType = 'Cleaning'
) AS clea,
(
    SELECT COUNT(ServiceType)
    FROM   Schedule
	WHERE ServiceType = 'Repair'
) AS rep,
(
    SELECT COUNT(ServiceType)
    FROM   Schedule
	WHERE ServiceType = 'Check-up'
) AS che,
(
	SELECT COUNT(ServiceType)
	FROM Schedule
	WHERE ServiceType = 'Installation'
)AS ins
	--SELECT count(ServiceType)as rep
	--from Schedule where ServiceType='Repair'

	--SELECT count(ServiceType)as rep
	--from Schedule where ServiceType='Checkup'


	--SELECT count(ServiceType)as ins
	--from Schedule where ServiceType='Installation';
END 
GO
/****** Object:  StoredProcedure [dbo].[SpUpdateCustomer]    Script Date: 9/4/2021 9:11:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SpUpdateCustomer] 

		-- People Table 
			@PersonID int,
			@CustomerID int,
    		@FirstName varchar(250),
    		@LastName varchar(250), 
    		@MobileNo varchar(250),
    		@TelephoneNo varchar(250),

		
			-- Address table 
			@HouseNo int, 
			@Street varchar(250),
			@Barangay varchar(250),
			@City varchar(250),


			-- Status 
			@Cus_Status varchar(250)

	
AS

	SET NOCOUNT ON;
--	DECLARE @PersonID int

	UPDATE People
	SET FirstName=@FirstName,LastName=@LastName,MobileNo=@MobileNo,TelephoneNo=@TelephoneNo
	WHERE People.PersonID = @PersonID

	--SET @PersonID = SCOPE_IDENTITY();
	UPDATE Customer
	SET Customer_Status = @Cus_Status, Person_ID = @PersonID
	WHERE Customer.Person_ID = @PersonID

	UPDATE Address
	SET HouseNo =@HouseNo,Street =@Street,Barangay = @Barangay,City= @City, Person_ID =@PersonID
	WHERE Address.Person_ID = @PersonID

--https://www.youtube.com/watch?v=w6mOplKiVok
 
GO
/****** Object:  StoredProcedure [dbo].[SpUpdateEmployee]    Script Date: 9/4/2021 9:11:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROC [dbo].[SpUpdateEmployee]

		@EmpID int, 
		@Fname varchar(250),
		@Lname varchar(250),
		@MobNo varchar(250),
		@TelNo varchar(250),
		@Pos varchar(250),
		@SvStatus varchar(250),
		@ContractType varchar(250),
		@DateHired datetime,
		@Person_ID int
AS 
		

BEGIN 
	SET NOCOUNT ON;


		
		UPDATE People
		SET FirstName = @Fname, LastName = @Lname, MobileNo = @MobNo, TelephoneNo = @TelNo WHERE PersonID = @Person_ID
		
	
		UPDATE Employee 
		SET Position = @Pos, Status = @SvStatus, DateHired = @DateHired, TypeOfContract = @ContractType WHERE EmployeeID = @EmpID



END
GO
USE [master]
GO
ALTER DATABASE [RFBDesktopApp] SET  READ_WRITE 
GO
