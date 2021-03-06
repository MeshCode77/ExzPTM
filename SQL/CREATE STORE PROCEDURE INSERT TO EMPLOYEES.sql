USE [PPM]
GO
/****** Object:  StoredProcedure [dbo].[spInsertEmployees]    Script Date: 05.12.2021 9:46:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[spInsertEmployees]
@idpodr int,
@lastName nvarchar(50),
@firstname nvarchar(30),
@parentname nvarchar(30),
@position nvarchar(30),
@talon int,
@date_pass nvarchar(30),
@lastId int OUTPUT
AS
INSERT INTO employees  (id_podr, lastname, firstname, parentname, position, num_talon, date_of_passage) 
				VALUES (@idpodr, @lastname, @firstname, @parentname, @position, @talon, @date_pass)

	SET @lastId = @@IDENTITY
