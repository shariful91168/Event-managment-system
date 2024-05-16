 

AMERICAN INTERNATIONAL UNIVERSITY–BANGLADESH (AIUB)
Dept. of Computer Science
Faculty of Science and Technology
CSC2210: OBJECT ORIENTED PROGRAMMING 2
Spring 2023-2024
Section: B
Group No: 

Project Report On
“Events Management System” 
Supervised By
DR. MD. IFTEKHARUL MOBIN                                                      

Submitted By: MD. SHARIFUL ISLAM
Name	ID
1.	MD.SHARIFUL ISLAM	21-45701-3
2.	NISHI AKTER	20-44277-3
3.	MD.SIRAJUL ISLAM	21-44931-2
CO2: Display and verify the mean of a real-life Project using the concepts of C# Graphical User Interface based environment with database integration to depict a desktop-based application.
Assessment
Criteria	Not Attended/ Incorrect (0)	Inadequate
 (1-2)	Average
(3)	Good 
(4)	Excellent
(5)
Evaluation Criteria	Evaluation Definition	Total = 15
Requirement fulfillment	Properly demonstrate a real-life scenario-based project with proper functional requirement identification for the Object-Oriented Programming project development activities.	5
Validation 	Ensuring the ability of students’ proper demonstration on validation forms in their system in terms of dealing with the data.	5
Verification	Identifying if the students can verify the system data along with proper functional requirements in terms of data flow.	5

 
Chapter 1: Introduction
The system is about event management from where customers will be able to reserve Some registered hotels or restaurants for various kinds of events like marriage, birthdays, iftar mehfils, business meeting etc.

Chapter 2: User stories
In the evert management system, there will be two types of users, admin and customer. First customers have to log in to use the system. If the customer has not any registered Id, then he/she must sign up first. Then he/she will be able to use the system. In this process customers will select the place where they want to arrange their occasion. Then they will select the type of occasion and choose the numbers of guests who will join the event. The system will show - the amount of money automatically according to the number of guests. Its customer is satisfied with the cost. He can confirm registration. Otherwise, he/she can press the "Cancel" button to exit the application.

•	User: 
I.	Login: User can log in to the system by providing their user ID and password. When the credentials match, the user will be able to access the system. 

II.	View User: User can view their own profile. And can edit only his name, email, and address. 

III.	View event: User can view the currently available event list. The list will include the event ID, event List, name ID, event Price.

IV.	View payment: User can view the payment transaction that have been done by the user. They can see payment ID, Price, and user ID.


•	Admin:   
I.	Log in: Manager can log into the system by providing their credentials into the System. 

II.	View Event: Manager has accessibility to view the event in a table. The table provides a view of the events with event Id, event type, event name, price, Available time, and date.

III.	Payment Transaction View: Manager can have view of transaction table by searching payment ID, however Manager isn’t authorized to make any changes on the table.

IV.	Change Profile: Manager also has the authority to Update their Information, they could change their name, address, email, as well as password.






Chapter 3: Database:

DATABASE SCHEMA
![image](https://github.com/shariful91168/Event-managment-system/assets/168640431/10f228bf-09fb-4e20-bd26-d5ebbcb372b5)

ER- Diagram:
![image](https://github.com/shariful91168/Event-managment-system/assets/168640431/2a723787-0e1d-47c8-a34d-029f0bf43bc1)

 
1.	User: UName, UPassword, Email, UType
2.	Event: EId, EName, ELocation, EImage,
3.	Booking: BId,BUId,BEvent,BCapacity,BPrice
4.	Payment:PEId,PUId,

SQL script: 

CREATE TABLE [User].[](

	[UserName] [varchar](50) NOT NULL,
	[UserID] [[varchar](50) NULL,
	[UserEmail] [[varchar](50) NULL,
                [UserPassword] [[varchar](50) NULL,
               [UserType] [[varchar](50) NULL,

 CONSTRAINT [PK_UserID] PRIMARY KEY CLUSTERED 
(  )

CREATE TABLE [Admin].(

	[AdminName] [varchar](50) NOT NULL,
	[AdminID] [[varchar](50) NULL,
	[AdminEmail] [[varchar](50) NULL,
                [AdminPassword] [[varchar](50) NULL,
               [AdminType] [[varchar](50) NULL,

 CONSTRAINT [PK_AdminID] PRIMARY KEY CLUSTERED 
( )

CREATE TABLE [Booking](

	[BId] [varchar](30) NOT NULL,
	[UserId] [varchar](50) NULL,
	[Hotel] [varchar](30) NULL,
	[Capacity] [int] NULL,
	[Event] [varchar](30) NULL,
	[Price] [varchar](30) NULL,
 CONSTRAINT [PK_BookingId] PRIMARY KEY CLUSTERED 
( )

CREATE TABLE [Hotel](
	[HId] [varchar](30) NOT NULL,
	[HName] [varchar](50) NULL,
	[HImage] [varchar](50) NULL,
                [HLocation] [varchar](50) NULL,
	
 CONSTRAINT [PK_HId] PRIMARY KEY CLUSTERED 
( )

CREATE TABLE [Event](
	[EId] [varchar](30) NOT NULL,
	[EName] [varchar](50) NULL,
	[EImage] [varchar](50) NULL,
                [ELocation] [varchar](50) NULL,
	
 CONSTRAINT [PK_EId] PRIMARY KEY CLUSTERED 
( )
CREATE TABLE [Payment](
	[EId] [varchar](30) NOT NULL,
	[UId] [varchar](50) NULL,
	[Payment] [varchar](50) NULL,	
 CONSTRAINT [PK_UId] PRIMARY KEY CLUSTERED 
( )


GO
INSERT [dbo].[Payment] ([PId], [PDate], [Amount]) VALUES (‘001', CAST(2024-5-22' AS Date), 20000)
INSERT [dbo].[Payment] ([PId], [PDate], [Amount]) VALUES (‘002', CAST(2024-5-22' AS Date), 30000)
INSERT [dbo].[Payment] ([PId], [PDate], [Amount]) VALUES (‘003', CAST(2024-5-22' AS Date), 40000)
INSERT [dbo].[Payment] ([PId], [PDate], [Amount]) VALUES (‘004', CAST(2024-5-22' AS Date), 50000)
INSERT [dbo].[Payment] ([PId], [PDate], [Amount]) VALUES (‘005', CAST(2024-5-22' AS Date), 60000)
GO
INSERT [dbo].[Event] ([EId], [EName], [EImage], [ELocation]) VALUES ('001',’ MD A', ‘Image', ‘Bonani’)
INSERT [dbo].[Event] ([EId], [EName], [EImage], [ELocation]) VALUES ('002',’ MD B', ‘Image', ‘Bonani’)
INSERT [dbo].[Event] ([EId], [EName], [EImage], [ELocation]) VALUES ('003',’ MD C', ‘Image', ‘Bonani’)
INSERT [dbo].[Event] ([EId], [EName], [EImage], [ELocation]) VALUES ('004',’ MD D', ‘Image', ‘Bonani’)
INSERT [dbo].[Event] ([EId], [EName], [EImage], [ELocation]) VALUES ('005',’ MD E', ‘Image', ‘Bonani’)
GO
INSERT [dbo].[Payment] ([EId], [UId], [Payment]) VALUES (‘001', ‘001', ‘20000’)
INSERT [dbo].[Payment] ([EId], [UId], [Payment]) VALUES (‘002', ‘002', ‘30000’)
INSERT [dbo].[Payment] ([EId], [UId], [Payment]) VALUES (‘003', ‘003', ‘40000’)
INSERT [dbo].[Payment] ([EId], [UId], [Payment]) VALUES (‘004', ‘004', ‘50000’)
INSERT [dbo].[Payment] ([EId], [UId], [Payment]) VALUES (‘005', ‘005', ‘60000’)
GO
INSERT [dbo].[User] ([UId], [UName], [UEmail], [UPassword], [UType]) VALUES ('001', ‘MD A’, 'a1@gmail.com','12345')
INSERT [dbo].[User] ([UId], [UName], [UEmail], [UPassword], [UType]) VALUES ('002', ‘MD B’, 'b2@gmail.com','12345')
INSERT [dbo].[User] ([UId], [UName], [UEmail], [UPassword], [UType]) VALUES ('003', ‘MD C’, 'c3@gmail.com','12345')
GO
ALTER TABLE [dbo].[Payment1]  WITH CHECK ADD  CONSTRAINT [FK_Payment1_Payment] FOREIGN KEY([PaymentId])
REFERENCES [dbo].[Payment] ([PaymentId])
GO
ALTER TABLE [dbo].[Payment] CHECK CONSTRAINT [FK_Payment1_Payment]
GO
ALTER TABLE [dbo].[Payment]  WITH CHECK ADD  CONSTRAINT [FK_Payment_User] FOREIGN KEY([UId])
REFERENCES [dbo].[User] ([UId])
GO
ALTER TABLE [dbo].[Payment] CHECK CONSTRAINT [FK_Payment_User]
GO


Chapter 4: Screenshot of forms:

LOGIN & SIGNUP PROCESS:
 ![image](https://github.com/shariful91168/Event-managment-system/assets/168640431/f82f0c3c-39b5-4276-a06a-c79a230866be)


FIGURE 01: Sign Up & Log In Procedure

 
![image](https://github.com/shariful91168/Event-managment-system/assets/168640431/470e5775-e1c5-4ffd-b50c-f978374bffe2)

FIGURE 02: Sign Up & Log In Procedure

 
![image](https://github.com/shariful91168/Event-managment-system/assets/168640431/e0369df0-f2d4-4aed-83c5-2fd7b0e6f2c3)

FIGURE 03: Sign Up & Log In Procedure

 
![image](https://github.com/shariful91168/Event-managment-system/assets/168640431/66f248a2-2c1f-4011-ab5a-1a21cdd1339b)

FIGURE 04: Search Procedure





 
![image](https://github.com/shariful91168/Event-managment-system/assets/168640431/dec17a79-5b5a-44f9-a282-14d150cd2344)



FIGURE 05: Events Procedure



 

![image](https://github.com/shariful91168/Event-managment-system/assets/168640431/67400b9d-af40-4283-b7f5-668bf47e3704)


FIGURE 06: Price list Procedure
PAYMENT PROCESS:


 
![image](https://github.com/shariful91168/Event-managment-system/assets/168640431/cf66a8e0-abb9-4a11-a4df-59bd9b6d576a)

FIGURE 07: Payment Procedure

 

![image](https://github.com/shariful91168/Event-managment-system/assets/168640431/8798d182-3080-4390-a5d2-67e4ba642588)

FIGURE 08: Payment Procedure

