USE [PPM]
GO
/****** Object:  StoredProcedure [dbo].[spInsertEmployees]    Script Date: 18.12.2021 19:16:01 ******/
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
@vidPodg nvarchar(50),
@date_pass date,
@dateExp date,
@lastId int OUTPUT
AS
INSERT INTO employees  (id_podr, lastname, firstname, parentname, position, num_talon, vid_podg,  date_of_passage, dateExpired) 
				VALUES (@idpodr, @lastname, @firstname, @parentname, @position, @talon, @vidPodg, @date_pass, @dateExp)

	SET @lastId = @@IDENTITY
