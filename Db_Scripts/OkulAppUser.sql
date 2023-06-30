USE [master]
GO
CREATE LOGIN [OkulAppUser] WITH PASSWORD=N'OkulAppUser123', DEFAULT_DATABASE=[OkulOtomasyon], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO
USE [OkulOtomasyon]
GO
CREATE USER [OkulAppUser] FOR LOGIN [OkulAppUser]
GO
USE [OkulOtomasyon]
GO
ALTER ROLE [db_datareader] ADD MEMBER [OkulAppUser]
GO
USE [OkulOtomasyon]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [OkulAppUser]
GO
