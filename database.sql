create database ans
use ans

create table UserAccount
(
	UserAccountID int identity(1,1) primary key,
	Firstname varchar(50) not null,
	Middlename varchar(50),
	Lastname varchar(50) not null,
	Username varchar(50) not null,
	Password varchar(50) not null,
	ContactNumber varchar(50) not null,
	AccessCode varchar(50) not null,
	Status varchar(50) not null,
	IsFirstLogin bit not null,
	UserTypeID int foreign key references UserType(UserTypeID)
)

create table Teacher
(
	TeacherID int identity(1,1) primary key,
	Firstname varchar(50) not null,
	Middlename varchar(50),
	Lastname varchar(50) not null,
	ContactNumber varchar(50) not null,
	Status varchar(50) not null,
	SubjectID int foreign key references Subject(SubjectID)
)

create table TimeSchedule
(
	TimeScheduleID int primary key identity(1,1),
	TimeStart varchar(50) not null,
	TimeEnd varchar(50) not null
)

create table UserType
(
	UserTypeID int identity(1,1) primary key,
	Type varchar(50) not null
)

create table Student
(
	StudentID int primary key identity(1,1),
	Firstname varchar(50) not null,
	Middlname varchar(50),
	Lastname varchar(50) not null,
	Birthdate date not null,
	Age int not null,
	Address varchar(max) not null,
	Gender varchar(50) not null,
	ParentName varchar(150) not null,
	ParentNo varchar(50),
	Occupation varchar(50) not null,
	Height decimal(5,2) not null,
	Weight decimal(5,2) not null,
	Systolic int not null,
	Diastolic int not null,
	Form137 varchar(50),
	Form138 varchar(50),
	GoodMoral varchar(50),
	NSO varchar(50),
	YearLevel varchar(50),
	SectionID int foreign key references Section(SectionID),
	SchoolyearID int foreign key references Schoolyear(SchoolyearID)
)

create table Section
(
	SectionID int primary key identity(1,1),
	Section varchar(50) not null,
	Capacity int not null,
	YearLevel varchar(50),
	TeacherID int foreign key references Teacher(TeacherID)
)

create table Schoolyear
(
	SchoolyearID int primary key identity(1,1),
	Year varchar(50) not null
)

create table Subject
(
	SubjectID int primary key identity(1,1),
	Subject varchar(50) not null
)
alter table Subject
add YearLevel varchar(50)

create table Payment
(
	PaymentID int primary key identity(1,1),
	Payment varchar(50) not null,
	Amount decimal(6,2) not null,
	SchoolyearID int foreign key references Schoolyear(SchoolyearID)
)

create table Schedule
(
	ScheduleID int primary key identity(1,1),
	TeacherID int foreign key references Teacher(TeacherID),
	SectionID int foreign key references Section(SectionID),
	YearLevel varchar(50) not null,
	TimeScheduleID int foreign key references TimeSchedule(TimeScheduleID)
)

create table Book
(
	BookID int primary key identity(1,1),
	Bookname varchar(50) not null,
	BookDesciption varchar(50) not null,
	YearLevel varchar(50) not null,
	BookAuthor varchar(50) not null,
	BookReleased date not null,
	BookQuantity int not null
)

create table ProcessBook	
(
	ProcessBookID int primary key identity(1,1),
	StudentID int foreign key references Student(StudentID),
	BookID int foreign key references Book(BookID),
	Distributer varchar(50),
	BookRelease date not null,
	BookReturn date null
)

create table RequiOfRequirement
(
	RequiOfRequirementID  int primary key identity(1,1),
	StudentID int foreign key references Student(StudentID),
	SchoolyearID int foreign key references Schoolyear(SchoolyearID),
	Requirement  varchar(50) not null,
	UserAccountID int foreign key references UserAccount(UserAccountID),
	DateRelease date not null
)

create table Inquiry
(
	InquiryID int primary key identity(1,1),
	InquiryFor  varchar(50) not null,
	InquiryDesc  varchar(50) not null,
	Creator varchar(50) not null
)

create table UserSecurity
(
	UserSecurityID int primary key identity(1,1),
	SecurityQuestion  varchar(50) not null,
	Answer  varchar(50) not null,
	UserAccountID int foreign key references UserAccount(UserAccountID)
)

create table StudentGrade
(
	StudentGradeID int primary key identity(1,1),
	StudentID int foreign key references Student(StudentID),
	SubjectID int foreign key references Subject(SubjectID),
	Grade  decimal(5,1) not null,
	YearLevel varchar(50)not null,
	Period varchar(50) not null,
	SchoolyearID int foreign key references Schoolyear(SchoolyearID)
)

create table StudentPayment
(
	StudentPaymentID int primary key identity(1,1),
	StudentID int foreign key references Student(StudentID),
	Amount decimal(6,2) not null,
	PaymentType varchar(50) not null,
	Date datetime not null
)

select * from UserAccount
select * from Schedule
select * from StudPayment
select * from StudentPayment
select * from UserSecurity
select * from processbook
select * from UserType
select * from Student
delete from UserType
INSERT INTO UserType values('Admin')
INSERT INTO UserType values('Staff')
select * from RequiOfRequirement