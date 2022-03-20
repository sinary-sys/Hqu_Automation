CREATE TRIGGER ReturnHandle 
ON 借阅 FOR UPDATE
AS
  DECLARE @BookNumber char(10)
  SELECT @BookNumber = i.书号 FROM inserted i
  UPDATE 图书 SET 剩余数量 = 剩余数量+1 WHERE 书号 = @BookNumber