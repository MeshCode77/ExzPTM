USE [PPM]
GO
/****** Object:  StoredProcedure [dbo].[spInsertVidPodg]    Script Date: 18.12.2021 10:14:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[spInsertVidPodg]

@name nvarchar(30),
@expDate int

AS
INSERT INTO typepodg (name, expDate) 
				VALUES (@name, @expDate)

	--SET @lastId = @@IDENTITY -- вернуть последний добавленный id