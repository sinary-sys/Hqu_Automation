USE [图书管理系统]
GO
/****** Object:  Trigger [dbo].[BorrowBook_Handle]    Script Date: 11/09/2019 21:51:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER TRIGGER [dbo].[BorrowBook_Handle]
ON [dbo].[借阅] FOR INSERT 
AS
  DECLARE @BookNumber char(10)
  DECLARE @BorrowNumber char(10)
  DECLARE @BookRest int
  
  SELECT @BookNumber = i.书号 FROM inserted i
  SELECT @BorrowNumber = i.借书证号 FROM inserted i
  UPDATE 图书 SET 剩余数量 = 剩余数量-1,被借次数 = 被借次数+1 WHERE 书号 = @BookNumber
  UPDATE 读者 SET 借阅次数 = 借阅次数+1 WHERE 借书证号 = @BorrowNumber 
  SELECT @BookRest = 剩余数量 FROM 图书 WHERE 书号 = @BookNumber
  if(@BookRest=-1)
	BEGIN
		PRINT '图书已被借完'
		ROLLBACK TRAN
	END
  Else
	print '插入成功'