USE [PPM]
GO
/****** Object:  StoredProcedure [dbo].[spUpdateVidPodg]    Script Date: 17.12.2021 20:44:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[spUpdatePodr]
	@id int,
	@podr nvarchar(30)	
AS
UPDATE podr			
SET				
	name = @podr	
WHERE	podr.id = @id;