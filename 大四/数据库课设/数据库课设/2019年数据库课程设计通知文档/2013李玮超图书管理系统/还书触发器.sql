CREATE TRIGGER ReturnHandle 
ON ���� FOR UPDATE
AS
  DECLARE @BookNumber char(10)
  SELECT @BookNumber = i.��� FROM inserted i
  UPDATE ͼ�� SET ʣ������ = ʣ������+1 WHERE ��� = @BookNumber