USE [PPM]
GO
/****** Object:  StoredProcedure [dbo].[spUpdateEmployees]    Script Date: 18.12.2021 19:27:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[spUpdateEmployees]
	@idEmpl int,
	@lastName nvarchar(50),
	@firstname nvarchar(30),
	@parentname nvarchar(30),
	@position nvarchar(30),
	@talon int,
	@vidPodg nvarchar(50),
	@date_pass nvarchar(30),
	@dateExp date
AS
UPDATE employees				
SET			
	--id = @idEmpl,
	lastname = @lastName,
	firstname = @firstname,
	parentname = @parentname,
	position = @position,
	num_talon  = @talon,
	vid_podg = @vidPodg,
	date_of_passage = @date_pass,
	dateExpired = @dateExp

WHERE	employees.id = @idEmpl;