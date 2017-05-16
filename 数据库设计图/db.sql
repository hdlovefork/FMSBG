/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2012                    */
/* Created on:     2017-05-13 18:27:11                          */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ACL_File_Role') and o.name = 'FK_ACL_FILE_REFERENCE_ACL_ROLE')
alter table ACL_File_Role
   drop constraint FK_ACL_FILE_REFERENCE_ACL_ROLE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ACL_File_Role') and o.name = 'FK_ACL_FILE_ROLE_REFERENCE_FILE')
alter table ACL_File_Role
   drop constraint FK_ACL_FILE_ROLE_REFERENCE_FILE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ACL_File_User') and o.name = 'FK_ACL_FILE_USER_REFERENCE_FILE')
alter table ACL_File_User
   drop constraint FK_ACL_FILE_USER_REFERENCE_FILE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ACL_File_User') and o.name = 'FK_ACL_FILE_REFERENCE_USER')
alter table ACL_File_User
   drop constraint FK_ACL_FILE_REFERENCE_USER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ACL_Role_Function') and o.name = 'FK_ACL_ROLE_REFERENCE_ACL_ROLE')
alter table ACL_Role_Function
   drop constraint FK_ACL_ROLE_REFERENCE_ACL_ROLE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ACL_User_Role') and o.name = 'FK_ACL_USER_REFERENCE_USER')
alter table ACL_User_Role
   drop constraint FK_ACL_USER_REFERENCE_USER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ACL_User_Role') and o.name = 'FK_ACL_USER_REFERENCE_ACL_ROLE')
alter table ACL_User_Role
   drop constraint FK_ACL_USER_REFERENCE_ACL_ROLE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Comment') and o.name = 'FK_COMMENT_REFERENCE_FILE')
alter table Comment
   drop constraint FK_COMMENT_REFERENCE_FILE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Comment') and o.name = 'FK_COMMENT_REFERENCE_USER')
alter table Comment
   drop constraint FK_COMMENT_REFERENCE_USER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('File_Department') and o.name = 'FK_FILE_DEP_REFERENCE_FILE')
alter table File_Department
   drop constraint FK_FILE_DEP_REFERENCE_FILE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('File_Department') and o.name = 'FK_FILE_DEP_REFERENCE_DEPARTME')
alter table File_Department
   drop constraint FK_FILE_DEP_REFERENCE_DEPARTME
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('User_Department_Position') and o.name = 'FK_USER_DEP_REFERENCE_USER')
alter table User_Department_Position
   drop constraint FK_USER_DEP_REFERENCE_USER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('User_Department_Position') and o.name = 'FK_USER_DEP_REFERENCE_DEPARTME')
alter table User_Department_Position
   drop constraint FK_USER_DEP_REFERENCE_DEPARTME
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('User_Department_Position') and o.name = 'FK_USER_DEP_REFERENCE_POSITION')
alter table User_Department_Position
   drop constraint FK_USER_DEP_REFERENCE_POSITION
go

if exists (select 1
            from  sysobjects
           where  id = object_id('View_User_Role_Function')
            and   type = 'V')
   drop view View_User_Role_Function
go

if exists (select 1
            from  sysobjects
           where  id = object_id('View_User_Role')
            and   type = 'V')
   drop view View_User_Role
go

if exists (select 1
            from  sysobjects
           where  id = object_id('View_User_Department_Position')
            and   type = 'V')
   drop view View_User_Department_Position
go

if exists (select 1
            from  sysobjects
           where  id = object_id('View_Role_Function')
            and   type = 'V')
   drop view View_Role_Function
go

if exists (select 1
            from  sysobjects
           where  id = object_id('View_File_User')
            and   type = 'V')
   drop view View_File_User
go

if exists (select 1
            from  sysobjects
           where  id = object_id('View_File_Role')
            and   type = 'V')
   drop view View_File_Role
go

if exists (select 1
            from  sysobjects
           where  id = object_id('View_File_Department')
            and   type = 'V')
   drop view View_File_Department
go

if exists (select 1
            from  sysobjects
           where  id = object_id('View_Department_Position')
            and   type = 'V')
   drop view View_Department_Position
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ACL_File_Role')
            and   type = 'U')
   drop table ACL_File_Role
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ACL_File_User')
            and   type = 'U')
   drop table ACL_File_User
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ACL_Function')
            and   type = 'U')
   drop table ACL_Function
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ACL_Role')
            and   type = 'U')
   drop table ACL_Role
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ACL_Role_Function')
            and   type = 'U')
   drop table ACL_Role_Function
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ACL_User_Role')
            and   type = 'U')
   drop table ACL_User_Role
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Comment')
            and   type = 'U')
   drop table Comment
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Department')
            and   type = 'U')
   drop table Department
go

if exists (select 1
            from  sysobjects
           where  id = object_id('"File"')
            and   type = 'U')
   drop table "File"
go

if exists (select 1
            from  sysobjects
           where  id = object_id('File_Department')
            and   type = 'U')
   drop table File_Department
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Position')
            and   type = 'U')
   drop table Position
go

if exists (select 1
            from  sysobjects
           where  id = object_id('"User"')
            and   type = 'U')
   drop table "User"
go

if exists (select 1
            from  sysobjects
           where  id = object_id('User_Department_Position')
            and   type = 'U')
   drop table User_Department_Position
go

/*==============================================================*/
/* Table: ACL_File_Role                                         */
/*==============================================================*/
create table ACL_File_Role (
   FileID               int                  null,
   RoleID               int                  null
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('ACL_File_Role') and minor_id = 0)
begin 
   declare @CurrentUser sysname 
select @CurrentUser = user_name() 
execute sp_dropextendedproperty 'MS_Description',  
   'user', @CurrentUser, 'table', 'ACL_File_Role' 
 
end 


select @CurrentUser = user_name() 
execute sp_addextendedproperty 'MS_Description',  
   '文件所属角色', 
   'user', @CurrentUser, 'table', 'ACL_File_Role'
go

/*==============================================================*/
/* Table: ACL_File_User                                         */
/*==============================================================*/
create table ACL_File_User (
   FileID               int                  null,
   UserID               int                  null
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('ACL_File_User') and minor_id = 0)
begin 
   declare @CurrentUser sysname 
select @CurrentUser = user_name() 
execute sp_dropextendedproperty 'MS_Description',  
   'user', @CurrentUser, 'table', 'ACL_File_User' 
 
end 


select @CurrentUser = user_name() 
execute sp_addextendedproperty 'MS_Description',  
   '文件所属用户', 
   'user', @CurrentUser, 'table', 'ACL_File_User'
go

/*==============================================================*/
/* Table: ACL_Function                                          */
/*==============================================================*/
create table ACL_Function (
   FunctionID           int                  identity,
   FunctionPID          int                  null,
   FunctionName         varchar(50)          null,
   FunctionControl      varchar(50)          null,
   constraint PK_ACL_FUNCTION primary key nonclustered (FunctionID)
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('ACL_Function') and minor_id = 0)
begin 
   declare @CurrentUser sysname 
select @CurrentUser = user_name() 
execute sp_dropextendedproperty 'MS_Description',  
   'user', @CurrentUser, 'table', 'ACL_Function' 
 
end 


select @CurrentUser = user_name() 
execute sp_addextendedproperty 'MS_Description',  
   '具体的功能操作，如：
   用户管理：增删改
   角色管理：增删改
   
   ', 
   'user', @CurrentUser, 'table', 'ACL_Function'
go

/*==============================================================*/
/* Table: ACL_Role                                              */
/*==============================================================*/
create table ACL_Role (
   RoleID               int                  identity,
   RoleName             varchar(50)          null,
   constraint PK_ACL_ROLE primary key nonclustered (RoleID)
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('ACL_Role') and minor_id = 0)
begin 
   declare @CurrentUser sysname 
select @CurrentUser = user_name() 
execute sp_dropextendedproperty 'MS_Description',  
   'user', @CurrentUser, 'table', 'ACL_Role' 
 
end 


select @CurrentUser = user_name() 
execute sp_addextendedproperty 'MS_Description',  
   '角色表', 
   'user', @CurrentUser, 'table', 'ACL_Role'
go

/*==============================================================*/
/* Table: ACL_Role_Function                                     */
/*==============================================================*/
create table ACL_Role_Function (
   RoleID               int                  null,
   FunctionID           int                  null
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('ACL_Role_Function') and minor_id = 0)
begin 
   declare @CurrentUser sysname 
select @CurrentUser = user_name() 
execute sp_dropextendedproperty 'MS_Description',  
   'user', @CurrentUser, 'table', 'ACL_Role_Function' 
 
end 


select @CurrentUser = user_name() 
execute sp_addextendedproperty 'MS_Description',  
   '角色权限表，描述角色具有哪些权限', 
   'user', @CurrentUser, 'table', 'ACL_Role_Function'
go

/*==============================================================*/
/* Table: ACL_User_Role                                         */
/*==============================================================*/
create table ACL_User_Role (
   UserID               int                  null,
   RoleID               int                  null
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('ACL_User_Role') and minor_id = 0)
begin 
   declare @CurrentUser sysname 
select @CurrentUser = user_name() 
execute sp_dropextendedproperty 'MS_Description',  
   'user', @CurrentUser, 'table', 'ACL_User_Role' 
 
end 


select @CurrentUser = user_name() 
execute sp_addextendedproperty 'MS_Description',  
   '用户角色中间表', 
   'user', @CurrentUser, 'table', 'ACL_User_Role'
go

/*==============================================================*/
/* Table: Comment                                               */
/*==============================================================*/
create table Comment (
   CommentID            int                  identity,
   FileID               int                  null,
   UserID               int                  null,
   CommentCreateTime    datetime             null,
   CommentMsg           varchar(500)         null,
   constraint PK_COMMENT primary key (CommentID)
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('Comment') and minor_id = 0)
begin 
   declare @CurrentUser sysname 
select @CurrentUser = user_name() 
execute sp_dropextendedproperty 'MS_Description',  
   'user', @CurrentUser, 'table', 'Comment' 
 
end 


select @CurrentUser = user_name() 
execute sp_addextendedproperty 'MS_Description',  
   '用户评论表', 
   'user', @CurrentUser, 'table', 'Comment'
go

/*==============================================================*/
/* Table: Department                                            */
/*==============================================================*/
create table Department (
   DepartmentID         int                  identity,
   DepartmentName       varchar(50)          null,
   constraint PK_DEPARTMENT primary key nonclustered (DepartmentID)
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('Department') and minor_id = 0)
begin 
   declare @CurrentUser sysname 
select @CurrentUser = user_name() 
execute sp_dropextendedproperty 'MS_Description',  
   'user', @CurrentUser, 'table', 'Department' 
 
end 


select @CurrentUser = user_name() 
execute sp_addextendedproperty 'MS_Description',  
   '部门表', 
   'user', @CurrentUser, 'table', 'Department'
go

/*==============================================================*/
/* Table: "File"                                                */
/*==============================================================*/
create table "File" (
   FileID               int                  identity,
   FileName             varchar(50)          null,
   FileExt              varchar(50)          null,
   FileSize             int                  null,
   FileData             varbinary(Max)       null,
   FileCreateTime       datetime             null default getdate(),
   FilePID              int                  null,
   FileOwner            int                  null default 1023,
   FileRole             int                  null default 0,
   FileOther            int                  null default 0,
   constraint PK_FILE primary key nonclustered (FileID)
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('"File"') and minor_id = 0)
begin 
   declare @CurrentUser sysname 
select @CurrentUser = user_name() 
execute sp_dropextendedproperty 'MS_Description',  
   'user', @CurrentUser, 'table', 'File' 
 
end 


select @CurrentUser = user_name() 
execute sp_addextendedproperty 'MS_Description',  
   '文件表，文件和目录都为文件，FileSize为0即为目录', 
   'user', @CurrentUser, 'table', 'File'
go

/*==============================================================*/
/* Table: File_Department                                       */
/*==============================================================*/
create table File_Department (
   FileID               int                  null,
   DepartmentID         int                  null
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('File_Department') and minor_id = 0)
begin 
   declare @CurrentUser sysname 
select @CurrentUser = user_name() 
execute sp_dropextendedproperty 'MS_Description',  
   'user', @CurrentUser, 'table', 'File_Department' 
 
end 


select @CurrentUser = user_name() 
execute sp_addextendedproperty 'MS_Description',  
   '文件属于哪些部门', 
   'user', @CurrentUser, 'table', 'File_Department'
go

/*==============================================================*/
/* Table: Position                                              */
/*==============================================================*/
create table Position (
   PositionID           int                  identity,
   PositionName         varchar(50)          null,
   constraint PK_POSITION primary key nonclustered (PositionID)
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('Position') and minor_id = 0)
begin 
   declare @CurrentUser sysname 
select @CurrentUser = user_name() 
execute sp_dropextendedproperty 'MS_Description',  
   'user', @CurrentUser, 'table', 'Position' 
 
end 


select @CurrentUser = user_name() 
execute sp_addextendedproperty 'MS_Description',  
   '职位表', 
   'user', @CurrentUser, 'table', 'Position'
go

/*==============================================================*/
/* Table: "User"                                                */
/*==============================================================*/
create table "User" (
   UserID               int                  identity,
   UserName             varchar(50)          not null,
   UserRealName         varchar(50)          null,
   UserPassword         varchar(50)          not null,
   UserSex              bit                  null,
   UserMobile           varchar(20)          null,
   UserAddress          varchar(100)         null,
   UserCreateTime       datetime             null default getdate(),
   UserEnable           bit                  null default 1,
   constraint PK_USER primary key nonclustered (UserID)
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('"User"') and minor_id = 0)
begin 
   declare @CurrentUser sysname 
select @CurrentUser = user_name() 
execute sp_dropextendedproperty 'MS_Description',  
   'user', @CurrentUser, 'table', 'User' 
 
end 


select @CurrentUser = user_name() 
execute sp_addextendedproperty 'MS_Description',  
   '用户表', 
   'user', @CurrentUser, 'table', 'User'
go

/*==============================================================*/
/* Table: User_Department_Position                              */
/*==============================================================*/
create table User_Department_Position (
   UserID               int                  null,
   DepartmentID         int                  null,
   PositionID           int                  null
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('User_Department_Position') and minor_id = 0)
begin 
   declare @CurrentUser sysname 
select @CurrentUser = user_name() 
execute sp_dropextendedproperty 'MS_Description',  
   'user', @CurrentUser, 'table', 'User_Department_Position' 
 
end 


select @CurrentUser = user_name() 
execute sp_addextendedproperty 'MS_Description',  
   '用户-部门-职位中间表，描述用户属于哪个部门的哪个职业，一个用户可属于多个部门和职位', 
   'user', @CurrentUser, 'table', 'User_Department_Position'
go

/*==============================================================*/
/* View: View_Department_Position                               */
/*==============================================================*/
create view View_Department_Position as
SELECT d.*,p.* FROM [dbo].[Position] p
	cross join [dbo].[Department] d
go

/*==============================================================*/
/* View: View_File_Department                                   */
/*==============================================================*/
create view View_File_Department as
select 
	f.*,
	d.*,
	fu.UserID
	from File_Department fd
	inner join "File" f on f.FileID = fd.FileID
	inner join Department d on d.DepartmentID = fd.DepartmentID
	inner join [ACL_File_User] fu on fu.FileID  = fd.FileID
go

/*==============================================================*/
/* View: View_File_Role                                         */
/*==============================================================*/
create view View_File_Role as
 select 
	f.*,
	r.*
	from ACL_File_Role fr
	inner join "File" f on f.FileID = fr.FileID
	inner join ACL_Role r on r.RoleID = fr.RoleID
go

/*==============================================================*/
/* View: View_File_User                                         */
/*==============================================================*/
create view View_File_User as
select 
	f.*,
	u.*
		from [ACL_File_User] fu
	inner join [File] f on f.FileID = fu.FileID
	inner join [User] u on u.UserID = fu.UserID
go

/*==============================================================*/
/* View: View_Role_Function                                     */
/*==============================================================*/
create view View_Role_Function as
select r.*,f.* from [ACL_Role_Function] rf
	inner join [ACL_Role] r on r.RoleID = rf.RoleID
	inner join [ACL_Function] f on f.FunctionID = rf.FunctionID
go

/*==============================================================*/
/* View: View_User_Department_Position                          */
/*==============================================================*/
create view View_User_Department_Position as
select 
	u.*,
	d.*,
	p.*
	from User_Department_Position udp
    inner join Position p on p.PositionID = udp.PositionID
	inner join "User" u on u.UserID = udp.UserID 
	inner join Department d on d.DepartmentID = udp.DepartmentID
go

/*==============================================================*/
/* View: View_User_Role                                         */
/*==============================================================*/
create view View_User_Role as
select 
	u.*,
	r.*
	from ACL_User_Role ur
	inner join "User" u on u.UserID = ur.UserID
	inner join ACL_Role r on r.RoleID = ur.RoleID
go

/*==============================================================*/
/* View: View_User_Role_Function                                */
/*==============================================================*/
create view View_User_Role_Function as
select ur.UserID,ur.UserName,ur.UserRealName,ur.UserEnable,ur.RoleID,ur.RoleName,
	rf.FunctionID,rf.FunctionName,rf.FunctionPID,rf.FunctionControl
		from [View_User_Role] ur
	inner join [View_Role_Function] rf on rf.RoleID = ur.RoleID
go

alter table ACL_File_Role
   add constraint FK_ACL_FILE_REFERENCE_ACL_ROLE foreign key (RoleID)
      references ACL_Role (RoleID)
go

alter table ACL_File_Role
   add constraint FK_ACL_FILE_ROLE_REFERENCE_FILE foreign key (FileID)
      references "File" (FileID)
go

alter table ACL_File_User
   add constraint FK_ACL_FILE_USER_REFERENCE_FILE foreign key (FileID)
      references "File" (FileID)
go

alter table ACL_File_User
   add constraint FK_ACL_FILE_REFERENCE_USER foreign key (UserID)
      references "User" (UserID)
go

alter table ACL_Role_Function
   add constraint FK_ACL_ROLE_REFERENCE_ACL_ROLE foreign key (RoleID)
      references ACL_Role (RoleID)
go

alter table ACL_User_Role
   add constraint FK_ACL_USER_REFERENCE_USER foreign key (UserID)
      references "User" (UserID)
go

alter table ACL_User_Role
   add constraint FK_ACL_USER_REFERENCE_ACL_ROLE foreign key (RoleID)
      references ACL_Role (RoleID)
go

alter table Comment
   add constraint FK_COMMENT_REFERENCE_FILE foreign key (FileID)
      references "File" (FileID)
go

alter table Comment
   add constraint FK_COMMENT_REFERENCE_USER foreign key (UserID)
      references "User" (UserID)
go

alter table File_Department
   add constraint FK_FILE_DEP_REFERENCE_FILE foreign key (FileID)
      references "File" (FileID)
go

alter table File_Department
   add constraint FK_FILE_DEP_REFERENCE_DEPARTME foreign key (DepartmentID)
      references Department (DepartmentID)
go

alter table User_Department_Position
   add constraint FK_USER_DEP_REFERENCE_USER foreign key (UserID)
      references "User" (UserID)
go

alter table User_Department_Position
   add constraint FK_USER_DEP_REFERENCE_DEPARTME foreign key (DepartmentID)
      references Department (DepartmentID)
go

alter table User_Department_Position
   add constraint FK_USER_DEP_REFERENCE_POSITION foreign key (PositionID)
      references Position (PositionID)
go

