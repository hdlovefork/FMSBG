/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2012                    */
/* Created on:     2017-05-29 18:04:19                          */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ACL_File_Department') and o.name = 'FK_ACL_FILE_REFERENCE_FILE')
alter table ACL_File_Department
   drop constraint FK_ACL_FILE_REFERENCE_FILE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ACL_File_Department') and o.name = 'FK_ACL_FILE_REFERENCE_DEPARTME')
alter table ACL_File_Department
   drop constraint FK_ACL_FILE_REFERENCE_DEPARTME
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ACL_File_User') and o.name = 'FK_ACL_FILE_REFERENCE_FILE2')
alter table ACL_File_User
   drop constraint FK_ACL_FILE_REFERENCE_FILE2
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
   where r.fkeyid = object_id('ACL_Role_Function') and o.name = 'FK_ACL_ROLE_REFERENCE_ACL_FUNC')
alter table ACL_Role_Function
   drop constraint FK_ACL_ROLE_REFERENCE_ACL_FUNC
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
   where r.fkeyid = object_id('File_User_Notice') and o.name = 'FK_FILE_SHA_REFERENCE_FILE2')
alter table File_User_Notice
   drop constraint FK_FILE_SHA_REFERENCE_FILE2
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('File_User_Notice') and o.name = 'FK_FILE_SHA_REFERENCE_USER3')
alter table File_User_Notice
   drop constraint FK_FILE_SHA_REFERENCE_USER3
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('File_User_Notice') and o.name = 'FK_FILE_SHA_REFERENCE_USER2')
alter table File_User_Notice
   drop constraint FK_FILE_SHA_REFERENCE_USER2
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
           where  id = object_id('View_File_User_Notice')
            and   type = 'V')
   drop view View_File_User_Notice
go

if exists (select 1
            from  sysobjects
           where  id = object_id('View_File_User')
            and   type = 'V')
   drop view View_File_User
go

if exists (select 1
            from  sysobjects
           where  id = object_id('View_File_Department')
            and   type = 'V')
   drop view View_File_Department
go

if exists (select 1
            from  sysobjects
           where  id = object_id('View_File')
            and   type = 'V')
   drop view View_File
go

if exists (select 1
            from  sysobjects
           where  id = object_id('View_Department_Position')
            and   type = 'V')
   drop view View_Department_Position
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ACL_File_Department')
            and   type = 'U')
   drop table ACL_File_Department
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
           where  id = object_id('DOC_Templete')
            and   type = 'U')
   drop table DOC_Templete
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
           where  id = object_id('File_User_Notice')
            and   type = 'U')
   drop table File_User_Notice
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
/* Table: ACL_File_Department                                   */
/*==============================================================*/
create table ACL_File_Department (
   FileID               int                  null,
   DepartmentID         int                  null,
   FilePermission       int                  null default 1
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('ACL_File_Department') and minor_id = 0)
begin 
   declare @CurrentUser sysname 
select @CurrentUser = user_name() 
execute sp_dropextendedproperty 'MS_Description',  
   'user', @CurrentUser, 'table', 'ACL_File_Department' 
 
end 


select @CurrentUser = user_name() 
execute sp_addextendedproperty 'MS_Description',  
   '�ļ�������Щ����', 
   'user', @CurrentUser, 'table', 'ACL_File_Department'
go

/*==============================================================*/
/* Table: ACL_File_User                                         */
/*==============================================================*/
create table ACL_File_User (
   FileID               int                  null,
   UserID               int                  null,
   FilePermission       int                  null default 1
)
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
   '����Ĺ��ܲ������磺
   �û�������ɾ��
   ��ɫ������ɾ��
   
   ', 
   'user', @CurrentUser, 'table', 'ACL_Function'
go

/*==============================================================*/
/* Table: ACL_Role                                              */
/*==============================================================*/
create table ACL_Role (
   RoleID               int                  identity,
   RoleName             varchar(50)          null,
   RoleDescription      varchar(100)         null,
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
   '��ɫ��', 
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
   '��ɫȨ�ޱ�������ɫ������ЩȨ��', 
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
   '�û���ɫ�м��', 
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
   '�û����۱�', 
   'user', @CurrentUser, 'table', 'Comment'
go

/*==============================================================*/
/* Table: DOC_Templete                                          */
/*==============================================================*/
create table DOC_Templete (
   TempleteID           int                  identity,
   TempleteName         varchar(50)          null,
   TempleteType         int                  null,
   TempleteExt          varchar(50)          null,
   TempleteData         image                null,
   constraint PK_DOC_TEMPLETE primary key (TempleteID)
)
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
   '���ű�', 
   'user', @CurrentUser, 'table', 'Department'
go

/*==============================================================*/
/* Table: "File"                                                */
/*==============================================================*/
create table "File" (
   FileID               int                  identity,
   UserID               int                  null,
   FileName             varchar(50)          null,
   FileExt              varchar(50)          null,
   FileSize             int                  null,
   FileData             image                null,
   FileCreateTime       datetime             null default getdate(),
   FilePID              int                  null,
   FileArchive          bit                  null,
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
   '�ļ����ļ���Ŀ¼��Ϊ�ļ���FileSizeΪ0��ΪĿ¼', 
   'user', @CurrentUser, 'table', 'File'
go

/*==============================================================*/
/* Table: File_User_Notice                                      */
/*==============================================================*/
create table File_User_Notice (
   NoticeID             int                  identity,
   FromUserID           int                  null,
   ToUserID             int                  null,
   FileID               int                  null,
   IsRead               bit                  null default 0,
   CreateTime           datetime             null default getdate(),
   constraint PK_FILE_USER_NOTICE primary key (NoticeID)
)
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
   'ְλ��', 
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
   '�û���', 
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
   '�û�-����-ְλ�м�������û������ĸ����ŵ��ĸ�ְҵ��һ���û������ڶ�����ź�ְλ', 
   'user', @CurrentUser, 'table', 'User_Department_Position'
go

/*==============================================================*/
/* View: View_Department_Position                               */
/*==============================================================*/
create view View_Department_Position as
select
   d.*,
   p.*
from
   Position p,
   Department d
go

/*==============================================================*/
/* View: View_File                                              */
/*==============================================================*/
create view View_File as
select
   u.*,
   f.FileID,
   f.FileName,
   f.FileExt,
   f.FileData,
   f.FilePID,
   f.FileSize,
   f.FileArchive,
   f.FileCreateTime
from
   "File" f
   inner join "User" u on f.UserID = u.UserID
go

/*==============================================================*/
/* View: View_File_Department                                   */
/*==============================================================*/
create view View_File_Department as
select
   f.*,
   d.*,
   fd.FilePermission
from
   ACL_File_Department fd
   inner join "File" f on  f.FileID = fd.FileID
   inner join Department d on  d.DepartmentID = fd.DepartmentID
go

/*==============================================================*/
/* View: View_File_User                                         */
/*==============================================================*/
create view View_File_User as
select    f.FileID,
   f.FileName,
   f.FileExt,
   f.FileData,
   f.FilePID,
   f.FileSize,
   f.FileArchive,
   f.FileCreateTime,u2.UserID,u2.UserRealName, u.UserID as OwnerUserID,u.UserRealName as OwnerRealName,fu.FilePermission from ACL_File_User fu 
	inner join [File] f on f.FileID	= fu.FileID
	inner join [User] u on f.UserID = u.UserID
	inner join [User] u2 on u2.userid = fu.UserID
go

/*==============================================================*/
/* View: View_File_User_Notice                                  */
/*==============================================================*/
create view View_File_User_Notice as
select n.*,u.UserRealName from [File_User_Notice] n
	inner join [User] u on u.UserID=n.FromUserID
go

/*==============================================================*/
/* View: View_Role_Function                                     */
/*==============================================================*/
create view View_Role_Function as
select r.*,f.* from ACL_Role_Function rf
	inner join ACL_Role r on r.RoleID = rf.RoleID
	inner join ACL_Function f on f.FunctionID = rf.FunctionID
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
		from View_User_Role ur
	inner join View_Role_Function rf on rf.RoleID = ur.RoleID
go

alter table ACL_File_Department
   add constraint FK_ACL_FILE_REFERENCE_FILE foreign key (FileID)
      references "File" (FileID)
go

alter table ACL_File_Department
   add constraint FK_ACL_FILE_REFERENCE_DEPARTME foreign key (DepartmentID)
      references Department (DepartmentID)
go

alter table ACL_File_User
   add constraint FK_ACL_FILE_REFERENCE_FILE2 foreign key (FileID)
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

alter table ACL_Role_Function
   add constraint FK_ACL_ROLE_REFERENCE_ACL_FUNC foreign key (FunctionID)
      references ACL_Function (FunctionID)
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

alter table File_User_Notice
   add constraint FK_FILE_SHA_REFERENCE_FILE2 foreign key (FileID)
      references "File" (FileID)
go

alter table File_User_Notice
   add constraint FK_FILE_SHA_REFERENCE_USER3 foreign key (FromUserID)
      references "User" (UserID)
go

alter table File_User_Notice
   add constraint FK_FILE_SHA_REFERENCE_USER2 foreign key (ToUserID)
      references "User" (UserID)
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

