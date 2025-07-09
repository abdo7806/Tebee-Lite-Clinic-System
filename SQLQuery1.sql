CREATE DATABASE TebeeLiteDB;
use TebeeLiteDB

-- ÃœÊ· Roles
CREATE TABLE Roles (
    RoleId INT PRIMARY KEY IDENTITY(1,1),
    RoleName NVARCHAR(50) NOT NULL
);

-- ÃœÊ· Users
CREATE TABLE Users (
    UserId INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(100) NOT NULL UNIQUE,
    PasswordHash NVARCHAR(255) NOT NULL,
    FullName NVARCHAR(100) NOT NULL,
    RoleId INT NOT NULL,
    IsActive BIT DEFAULT 1,
    FOREIGN KEY (RoleId) REFERENCES Roles(RoleId)
);

-- ÃœÊ· Doctors
CREATE TABLE Doctors (
    DoctorId INT PRIMARY KEY IDENTITY(1,1),
    UserId INT NOT NULL,
    Specialization NVARCHAR(100),
    LicenseNumber NVARCHAR(50),
    Education NVARCHAR(255),
    YearsOfExperience INT,
    WorkingHours NVARCHAR(100),
    Notes TEXT,
    FOREIGN KEY (UserId) REFERENCES Users(UserId)
);

-- ÃœÊ· Patients
CREATE TABLE Patients (
    PatientId INT PRIMARY KEY IDENTITY(1,1),
    FullName NVARCHAR(100) NOT NULL,
    DOB DATE,
    Gender NVARCHAR(10),
    Phone NVARCHAR(20),
    Email NVARCHAR(100),
    Address TEXT,
    Notes TEXT
);

-- ÃœÊ· Appointments („Ê⁄œ + “Ì«—…)
CREATE TABLE Appointments (
    AppointmentId INT PRIMARY KEY IDENTITY(1,1),
    PatientId INT NOT NULL,
    DoctorId INT NOT NULL,
    BookedByUserId INT,
    AppointmentDate DATETIME NOT NULL,
    Status NVARCHAR(50) NOT NULL,
    Diagnosis TEXT,
    Treatment TEXT,
    Notes TEXT,
    FOREIGN KEY (PatientId) REFERENCES Patients(PatientId),
    FOREIGN KEY (DoctorId) REFERENCES Doctors(DoctorId),
    FOREIGN KEY (BookedByUserId) REFERENCES Users(UserId)
);

-- ÃœÊ· Prescriptions
CREATE TABLE Prescriptions (
    PrescriptionId INT PRIMARY KEY IDENTITY(1,1),
    AppointmentId INT NOT NULL,
    PrescriptionDate DATE NOT NULL,
    Notes TEXT,
    FOREIGN KEY (AppointmentId) REFERENCES Appointments(AppointmentId)
);

-- ÃœÊ· PrescriptionItems
CREATE TABLE PrescriptionItems (
    ItemId INT PRIMARY KEY IDENTITY(1,1),
    PrescriptionId INT NOT NULL,
    MedicationName NVARCHAR(100) NOT NULL,
    Dosage NVARCHAR(50),
    Frequency NVARCHAR(50),
    Duration NVARCHAR(50),
    Instructions TEXT,
    FOREIGN KEY (PrescriptionId) REFERENCES Prescriptions(PrescriptionId)
);

-- ÃœÊ· Payments
CREATE TABLE Payments (
    PaymentId INT PRIMARY KEY IDENTITY(1,1),
    PatientId INT NOT NULL,
    AppointmentId INT NOT NULL,
    Amount DECIMAL(10,2) NOT NULL,
    PaymentDate DATETIME NOT NULL,
    PaymentMethod NVARCHAR(50),
    InvoiceNumber NVARCHAR(50) NOT NULL,
    Notes TEXT,
    FOREIGN KEY (PatientId) REFERENCES Patients(PatientId),
    FOREIGN KEY (AppointmentId) REFERENCES Appointments(AppointmentId)
);


--1.  ⁄œÌ· «·Ãœ«Ê· ·≈÷«›… CreatedAt, UpdatedAt

ALTER TABLE Users ADD CreatedAt DATETIME DEFAULT GETDATE(), UpdatedAt DATETIME NULL;
ALTER TABLE Doctors ADD CreatedAt DATETIME DEFAULT GETDATE(), UpdatedAt DATETIME NULL;
ALTER TABLE Patients ADD CreatedAt DATETIME DEFAULT GETDATE(), UpdatedAt DATETIME NULL;
ALTER TABLE Appointments ADD CreatedAt DATETIME DEFAULT GETDATE(), UpdatedAt DATETIME NULL;
ALTER TABLE Prescriptions ADD CreatedAt DATETIME DEFAULT GETDATE(), UpdatedAt DATETIME NULL;
ALTER TABLE Payments ADD CreatedAt DATETIME DEFAULT GETDATE(), UpdatedAt DATETIME NULL;
ALTER TABLE Patients ADD BloodType NVARCHAR(10);


-- ⁄œÌ· ÃœÊ· Payments ·≈÷«›… Õ«·… «·œ›⁄

ALTER TABLE Payments ADD PaymentStatus NVARCHAR(50) DEFAULT 'Paid';
--'Paid' („œ›Ê⁄)

--'Pending' (ﬁÌœ «·«‰ Ÿ«—)

--'Partial' („œ›Ê⁄ Ã“∆Ì«)

--'Cancelled' („·€Ì)



-- ≈‰‘«¡ ÃœÊ· AuditLogs ·  »⁄ «·√Õœ«À
CREATE TABLE AuditLogs (
    LogId INT PRIMARY KEY IDENTITY(1,1),
    UserId INT,
    Action NVARCHAR(100) NOT NULL,
    TableName NVARCHAR(100) NOT NULL,
    RecordId INT,
    Timestamp DATETIME DEFAULT GETDATE(),
    Details TEXT,
    FOREIGN KEY (UserId) REFERENCES Users(UserId)
);


Scaffold-DbContext "Server=.;Database=TebeeLiteDB;User Id=sa;Password=123456;Trusted_Connection=true;TrustServerCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -Force
