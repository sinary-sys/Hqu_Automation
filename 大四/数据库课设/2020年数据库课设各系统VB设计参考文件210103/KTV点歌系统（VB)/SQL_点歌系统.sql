create table ������Ϣ��
( ���Ǳ��   char(10)    not null    primary key,
����        char(20)        not null,
�Ա�        char(2)        not null    check (�Ա� in ('��' , 'Ů')),
��������    datetime         not null,
����        char(20)        not null,
ƴ����д    char(10)        not null,
¼��ʱ��    datetime        not null
)
go
insert into ������Ϣ�� values    ('S000','�Ŷ���','��','1981-11-29','��½�и���','zdl','2010-05-09')
insert into ������Ϣ�� values    ('S001','�����','��','1980-08-06','��̨�и���','pwb','2010-05-09')
insert into ������Ϣ�� values    ('S002','�ֿ���','��','1981-03-27','��̨�и���','ljj','2010-05-09')
insert into ������Ϣ�� values    ('S003','������','��','1966-06-23','��̨�и���','rxq','2010-05-09')
insert into ������Ϣ�� values    ('S004','����Ӣ','Ů','1970-06-01','��̨Ů����','lry','2010-05-09')
insert into ������Ϣ�� values    ('S005','֣����','Ů','1972-08-19','��̨Ů����','zxw','2010-05-09')
insert into ������Ϣ�� values    ('S006','�ž���','��','1981-02-01','��½�и���','zjx','2010-05-09')
insert into ������Ϣ�� values    ('S007','֣Դ','��','1982-11-02','��½�и���','zy','2010-05-09')
insert into ������Ϣ�� values    ('S008','����','Ů','1966-05-02','��½Ů����','tz','2010-05-09')
insert into ������Ϣ�� values ('S009','������','��','1967-03-26','̨���и���','zxz','2010-05-09')
insert into ������Ϣ�� values ('S010','����','Ů','1971-09-26','�й�Ů����','hh','2010-05-09')
insert into ������Ϣ�� values ('S011','������','Ů','1981-03-18','����Ů����','znl','2010-05-09')
insert into ������Ϣ�� values    ('S012','Matthew Lien','��','1981-11-29','ŷ���и���','ml','2010-05-09')

select * from ������Ϣ��
go
create table �����Ϣ��
( ��ϱ��    char(10)    not null    primary key,
�������    char(20)        not null,
�������    int            not null,
�����Ա    char(50)        not null,
�����д    char(20)        not null,
¼��ʱ��    Datetime        not null
)
go
insert into �����Ϣ�� values('A001','S.H.E', '3','�μ���,�����,�¼���','she','2019-11-05')
insert into �����Ϣ�� values('001','S.H.E', '3','�μ���,�����,�¼���','she','2019-11-05')