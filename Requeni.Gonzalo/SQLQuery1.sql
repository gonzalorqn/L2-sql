/****** Script para el comando SelectTopNRows de SSMS  ******/
/*SELECT TOP 1000 [id]
      ,[nombre]
      ,[apellido]
      ,[edad]
  FROM [Padron].[dbo].[Personas]*/

  /*SELECT id,nombre,apellido,edad
  FROM Padron.dbo.Personas*/
  /*WHERE edad > 60
  ORDER BY edad DESC*/
  /*INSERT INTO Padron.dbo.Personas (nombre,apellido,edad)
  VALUES ('asd','asdd',20)*/
  /*UPDATE Padron.dbo.Personas
  SET nombre = 'Juan', apellido = 'Lopez', edad = 45
  WHERE id = 6*/
  /*DELETE FROM Padron.dbo.Personas
  WHERE id = 7*/

  SELECT id,nombre,apellido,edad FROM Padron.dbo.Personas