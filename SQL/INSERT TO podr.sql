CREATE PROCEDURE [dbo].[spInsertPodr]
@podr nvarchar (30)
AS
INSERT INTO podr  (name) 
				VALUES (@podr)

	