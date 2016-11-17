INSERT INTO dbo.Excercises (ExerciseName, ExcersiceDescription, Image, Category) 
SELECT 'John', 'AIT', BulkColumn, 4
FROM Openrowset( Bulk 'C:\Users\Marius\Pictures\arnold.jpg', Single_Blob) as Image