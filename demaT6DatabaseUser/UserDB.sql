CREATE TABLE UserRole (
	RoleId int PRIMARY KEY IDENTITY,
	RoleName nvarchar(50)
)
GO
CREATE TABLE Users (
	Username varchar(32) PRIMARY KEY,
	Password varchar(128) NOT NULL,
	FullName nvarchar(250) NOT NULL,
	Email varchar(500) NULL,
	RoleId int FOREIGN KEY REFERENCES UserRole(RoleId),
	Active bit NOT NULL
)
GO

INSERT INTO UserRole(RoleName) VALUES ('Admin'), ('Mod'), ('User'), ('VIP');
GO
INSERT INTO Users VALUES ('admin','admin','ADMIN','admin@mail.com',1,1),  ('thang','Thang1230','Dao Thang','thang@mail.com',3,1),  ('test','test123','TEST USER','testuser@mail.com',3,0);
GO