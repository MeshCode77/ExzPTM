USE [PPM]
GO
/****** Object:  StoredProcedure [dbo].[spUpdateVidPodg]    Script Date: 18.12.2021 10:15:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[spUpdateVidPodg]
	@id int,
	@vidPodg nvarchar(30),
	@dateExp int
	
AS
UPDATE typepodg				
SET				
	name = @vidPodg,
	expdate = @dateExp	

WHERE	typepodg.id = @id;