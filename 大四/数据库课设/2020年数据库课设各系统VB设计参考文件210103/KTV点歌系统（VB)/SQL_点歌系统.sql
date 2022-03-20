create table 明星信息表
( 明星编号   char(10)    not null    primary key,
姓名        char(20)        not null,
性别        char(2)        not null    check (性别 in ('男' , '女')),
出生日期    datetime         not null,
国籍        char(20)        not null,
拼音缩写    char(10)        not null,
录入时间    datetime        not null
)
go
insert into 明星信息表 values    ('S000','张栋梁','男','1981-11-29','大陆男歌手','zdl','2010-05-09')
insert into 明星信息表 values    ('S001','潘玮柏','男','1980-08-06','港台男歌手','pwb','2010-05-09')
insert into 明星信息表 values    ('S002','林俊杰','男','1981-03-27','港台男歌手','ljj','2010-05-09')
insert into 明星信息表 values    ('S003','任贤齐','男','1966-06-23','港台男歌手','rxq','2010-05-09')
insert into 明星信息表 values    ('S004','刘若英','女','1970-06-01','港台女歌手','lry','2010-05-09')
insert into 明星信息表 values    ('S005','郑秀文','女','1972-08-19','港台女歌手','zxw','2010-05-09')
insert into 明星信息表 values    ('S006','张敬轩','男','1981-02-01','大陆男歌手','zjx','2010-05-09')
insert into 明星信息表 values    ('S007','郑源','男','1982-11-02','大陆男歌手','zy','2010-05-09')
insert into 明星信息表 values    ('S008','田震','女','1966-05-02','大陆女歌手','tz','2010-05-09')
insert into 明星信息表 values ('S009','张信哲','男','1967-03-26','台湾男歌手','zxz','2010-05-09')
insert into 明星信息表 values ('S010','韩红','女','1971-09-26','中国女歌手','hh','2010-05-09')
insert into 明星信息表 values ('S011','张娜拉','女','1981-03-18','韩国女歌手','znl','2010-05-09')
insert into 明星信息表 values    ('S012','Matthew Lien','男','1981-11-29','欧美男歌手','ml','2010-05-09')

select * from 明星信息表
go
create table 组合信息表
( 组合编号    char(10)    not null    primary key,
组合名称    char(20)        not null,
组合人数    int            not null,
组合人员    char(50)        not null,
组合缩写    char(20)        not null,
录入时间    Datetime        not null
)
go
insert into 组合信息表 values('A001','S.H.E', '3','任家萱,田馥甄,陈嘉桦','she','2019-11-05')
insert into 组合信息表 values('001','S.H.E', '3','任家萱,田馥甄,陈嘉桦','she','2019-11-05')