INSERT INTO [User] (UserName,UserRealName,UserPassword,UserSex,UserAddress) VALUES ('xm','小明','123',0,'湖南湘潭')
INSERT INTO [User] (UserName,UserRealName,UserPassword,UserSex,UserAddress) VALUES ('xz','小张','123',0,'湖南湘潭')
INSERT INTO [User] (UserName,UserRealName,UserPassword,UserSex,UserAddress) VALUES ('xh','小红','123',0,'湖南湘潭')


INSERT INTO [ACL_Role] (RoleName,RoleDescription) VALUES ('超级管理员','拥有后台操作所有权限')
INSERT INTO [ACL_Role] (RoleName,RoleDescription) VALUES ('用户管理员','拥有后台用户管理权限')
INSERT INTO [ACL_Role] (RoleName,RoleDescription) VALUES ('部门管理员','拥有后台部门管理权限')
INSERT INTO [ACL_Role] (RoleName,RoleDescription) VALUES ('角色管理员','拥有后台角色管理权限')
INSERT INTO [ACL_Role] (RoleName,RoleDescription) VALUES ('功能管理员','拥有后台功能管理权限')
INSERT INTO [ACL_Role] (RoleName,RoleDescription) VALUES ('模板管理员','拥有后台模板的管理权限')


INSERT INTO [File] (FileName,FileSize,FilePID,UserID) VALUES ('我的图片',0,-1,1)
INSERT INTO [File] (FileName,FileSize,FilePID,UserID) VALUES ('生活照片',0,1,1)
INSERT INTO [File] (FileName,FileSize,FilePID,UserID) VALUES ('艺术照片',0,1,1)
INSERT INTO [File] (FileName,FileSize,FilePID,UserID) VALUES ('个人笔记',0,-1,1)
INSERT INTO [File] (FileName,FileSize,FilePID,UserID) VALUES ('会议记录',0,-1,1)


-- INSERT INTO [File] (FileName,FileSize,FilePID,UserID) VALUES ('人事部会议',0,-1,-1)
-- INSERT INTO [File] (FileName,FileSize,FilePID,UserID) VALUES ('销售部会议',0,-1,-1)
-- INSERT INTO [File] (FileName,FileSize,FilePID,UserID) VALUES ('行政部会议',0,-1,-1)
-- INSERT INTO [File] (FileName,FileSize,FilePID,UserID) VALUES ('财务部会议',0,-1,-1)
-- INSERT INTO [File] (FileName,FileSize,FilePID,UserID) VALUES ('2017年',0,6,-1)
-- INSERT INTO [File] (FileName,FileSize,FilePID,UserID) VALUES ('1月份',0,10,-1)


-- INSERT INTO [File] (FileName,FileExt,FileSize,FilePID) VALUES ('会议文件1','jpg',13,11)
-- INSERT INTO [File] (FileName,FileExt,FileSize,FilePID) VALUES ('会议文件2','jpg',30,11)
-- INSERT INTO [File] (FileName,FileExt,FileSize,FilePID) VALUES ('会议文件3','jpg',12,11)
-- INSERT INTO [File] (FileName,FileExt,FileSize,FilePID) VALUES ('会议文件4','jpg',10,11)


INSERT INTO [Position] (PositionName) VALUES ('总监')
INSERT INTO [Position] (PositionName) VALUES ('经理')
INSERT INTO [Position] (PositionName) VALUES ('组长')
INSERT INTO [Position] (PositionName) VALUES ('普通员工')

INSERT INTO [Department] (DepartmentName) VALUES ('人事部')
INSERT INTO [Department] (DepartmentName) VALUES ('销售部')
INSERT INTO [Department] (DepartmentName) VALUES ('行政部')
INSERT INTO [Department] (DepartmentName) VALUES ('财务部')

INSERT INTO [User_Department_Position] (UserID,DepartmentID,PositionID) VALUES (1,1,2)
INSERT INTO [User_Department_Position] (UserID,DepartmentID,PositionID) VALUES (1,2,2)
INSERT INTO [User_Department_Position] (UserID,DepartmentID,PositionID) VALUES (2,3,4)
INSERT INTO [User_Department_Position] (UserID,DepartmentID,PositionID) VALUES (3,4,3)
INSERT INTO [User_Department_Position] (UserID,DepartmentID,PositionID) VALUES (3,2,3)


INSERT INTO [ACL_User_Role] (UserID,RoleID) VALUES (1,1)
INSERT INTO [ACL_User_Role] (UserID,RoleID) VALUES (1,2)
INSERT INTO [ACL_User_Role] (UserID,RoleID) VALUES (2,3)
INSERT INTO [ACL_User_Role] (UserID,RoleID) VALUES (3,4)
INSERT INTO [ACL_User_Role] (UserID,RoleID) VALUES (3,2)
INSERT INTO [ACL_User_Role] (UserID,RoleID) VALUES (3,6)


-- INSERT INTO [ACL_File_Role] (FileID,RoleID) VALUES (6,2)
-- INSERT INTO [ACL_File_Role] (FileID,RoleID) VALUES (7,3)
-- INSERT INTO [ACL_File_Role] (FileID,RoleID) VALUES (8,4)
-- INSERT INTO [ACL_File_Role] (FileID,RoleID) VALUES (9,5)
-- INSERT INTO [ACL_File_Role] (FileID,RoleID) VALUES (10,2)
-- INSERT INTO [ACL_File_Role] (FileID,RoleID) VALUES (11,2)


-- INSERT INTO [ACL_File_User] (FileID,UserID) VALUES (1,1)
-- INSERT INTO [ACL_File_User] (FileID,UserID) VALUES (2,1)
-- INSERT INTO [ACL_File_User] (FileID,UserID) VALUES (3,1)
-- INSERT INTO [ACL_File_User] (FileID,UserID) VALUES (4,1)
-- INSERT INTO [ACL_File_User] (FileID,UserID) VALUES (5,1)

-- INSERT INTO [ACL_File_User] (FileID,UserID) VALUES (12,1)
-- INSERT INTO [ACL_File_User] (FileID,UserID) VALUES (13,2)
-- INSERT INTO [ACL_File_User] (FileID,UserID) VALUES (14,1)
-- INSERT INTO [ACL_File_User] (FileID,UserID) VALUES (15,1)

-- INSERT INTO [ACL_File_Department] (FileID,DepartmentID) VALUES (6,1)
-- INSERT INTO [ACL_File_Department] (FileID,DepartmentID) VALUES (7,2)
-- INSERT INTO [ACL_File_Department] (FileID,DepartmentID) VALUES (8,3)
-- INSERT INTO [ACL_File_Department] (FileID,DepartmentID) VALUES (9,4)
-- INSERT INTO [ACL_File_Department] (FileID,DepartmentID) VALUES (10,1)
-- INSERT INTO [ACL_File_Department] (FileID,DepartmentID) VALUES (11,1)

-- INSERT INTO [File_Department] (FileID,DepartmentID) VALUES (12,1)
-- INSERT INTO [File_Department] (FileID,DepartmentID) VALUES (13,1)
-- INSERT INTO [File_Department] (FileID,DepartmentID) VALUES (14,1)
-- INSERT INTO [File_Department] (FileID,DepartmentID) VALUES (15,1)

INSERT INTO [ACL_Function] (FunctionPID,FunctionName,FunctionControl) VALUES (-1,'文件管理系统','FMSBG')

INSERT INTO [ACL_Function] (FunctionPID,FunctionName,FunctionControl) VALUES (1,'用户管理','User')
INSERT INTO [ACL_Function] (FunctionPID,FunctionName,FunctionControl) VALUES (2,'添加用户','User/Add')
INSERT INTO [ACL_Function] (FunctionPID,FunctionName,FunctionControl) VALUES (2,'删除用户','User/Delete')
INSERT INTO [ACL_Function] (FunctionPID,FunctionName,FunctionControl) VALUES (2,'编辑用户','User/Edit')

INSERT INTO [ACL_Function] (FunctionPID,FunctionName,FunctionControl) VALUES (1,'部门管理','Department')
INSERT INTO [ACL_Function] (FunctionPID,FunctionName,FunctionControl) VALUES (6,'添加部门','Department/Add')
INSERT INTO [ACL_Function] (FunctionPID,FunctionName,FunctionControl) VALUES (6,'删除部门','Department/Delete')
INSERT INTO [ACL_Function] (FunctionPID,FunctionName,FunctionControl) VALUES (6,'编辑部门','Department/Edit')

INSERT INTO [ACL_FUNCTION] (FUNCTIONPID,FUNCTIONNAME,FUNCTIONCONTROL) VALUES (1,'角色管理','Role')
INSERT INTO [ACL_FUNCTION] (FUNCTIONPID,FUNCTIONNAME,FUNCTIONCONTROL) VALUES (10,'添加角色','Role/Add')
INSERT INTO [ACL_FUNCTION] (FUNCTIONPID,FUNCTIONNAME,FUNCTIONCONTROL) VALUES (10,'删除角色','Role/Delete')
INSERT INTO [ACL_FUNCTION] (FUNCTIONPID,FUNCTIONNAME,FUNCTIONCONTROL) VALUES (10,'编辑角色','Role/Edit')

INSERT INTO [ACL_Function] (FunctionPID,FunctionName,FunctionControl) VALUES (1,'岗位管理','Position')
INSERT INTO [ACL_Function] (FunctionPID,FunctionName,FunctionControl) VALUES (14,'添加岗位','Position/Add')
INSERT INTO [ACL_Function] (FunctionPID,FunctionName,FunctionControl) VALUES (14,'删除岗位','Position/Delete')
INSERT INTO [ACL_Function] (FunctionPID,FunctionName,FunctionControl) VALUES (14,'编辑岗位','Position/Edit')

INSERT INTO [ACL_Function] (FunctionPID,FunctionName,FunctionControl) VALUES (1,'功能管理','Function')
INSERT INTO [ACL_Function] (FunctionPID,FunctionName,FunctionControl) VALUES (18,'添加功能','Function/Add')
INSERT INTO [ACL_Function] (FunctionPID,FunctionName,FunctionControl) VALUES (18,'删除功能','Function/Delete')
INSERT INTO [ACL_Function] (FunctionPID,FunctionName,FunctionControl) VALUES (18,'编辑功能','Function/Edit')

INSERT INTO [ACL_Function] (FunctionPID,FunctionName,FunctionControl) VALUES (1,'模板管理','Templete')
INSERT INTO [ACL_Function] (FunctionPID,FunctionName,FunctionControl) VALUES (22,'添加模板','Templete/Add')
INSERT INTO [ACL_Function] (FunctionPID,FunctionName,FunctionControl) VALUES (22,'删除模板','Templete/Delete')

INSERT INTO [ACL_Role_Function] (RoleID,FunctionID) VALUES (1,1)
INSERT INTO [ACL_Role_Function] (RoleID,FunctionID) VALUES (1,2)
INSERT INTO [ACL_Role_Function] (RoleID,FunctionID) VALUES (1,3)
INSERT INTO [ACL_Role_Function] (RoleID,FunctionID) VALUES (1,4)
INSERT INTO [ACL_Role_Function] (RoleID,FunctionID) VALUES (1,5)
INSERT INTO [ACL_Role_Function] (RoleID,FunctionID) VALUES (1,6)
INSERT INTO [ACL_Role_Function] (RoleID,FunctionID) VALUES (1,7)
INSERT INTO [ACL_Role_Function] (RoleID,FunctionID) VALUES (1,8)
INSERT INTO [ACL_Role_Function] (RoleID,FunctionID) VALUES (1,9)
INSERT INTO [ACL_Role_Function] (RoleID,FunctionID) VALUES (1,10)
INSERT INTO [ACL_Role_Function] (RoleID,FunctionID) VALUES (1,11)
INSERT INTO [ACL_Role_Function] (RoleID,FunctionID) VALUES (1,12)
INSERT INTO [ACL_Role_Function] (RoleID,FunctionID) VALUES (1,13)
INSERT INTO [ACL_Role_Function] (RoleID,FunctionID) VALUES (1,14)
INSERT INTO [ACL_Role_Function] (RoleID,FunctionID) VALUES (1,15)
INSERT INTO [ACL_Role_Function] (RoleID,FunctionID) VALUES (1,16)
INSERT INTO [ACL_Role_Function] (RoleID,FunctionID) VALUES (1,17)
INSERT INTO [ACL_Role_Function] (RoleID,FunctionID) VALUES (1,18)
INSERT INTO [ACL_Role_Function] (RoleID,FunctionID) VALUES (1,19)
INSERT INTO [ACL_Role_Function] (RoleID,FunctionID) VALUES (1,20)
INSERT INTO [ACL_Role_Function] (RoleID,FunctionID) VALUES (1,21)
INSERT INTO [ACL_Role_Function] (RoleID,FunctionID) VALUES (1,22)
INSERT INTO [ACL_Role_Function] (RoleID,FunctionID) VALUES (1,23)
INSERT INTO [ACL_Role_Function] (RoleID,FunctionID) VALUES (1,24)

INSERT INTO [ACL_Role_Function] (RoleID,FunctionID) VALUES (2,1)
INSERT INTO [ACL_Role_Function] (RoleID,FunctionID) VALUES (2,2)
INSERT INTO [ACL_Role_Function] (RoleID,FunctionID) VALUES (2,3)
INSERT INTO [ACL_Role_Function] (RoleID,FunctionID) VALUES (2,4)
INSERT INTO [ACL_Role_Function] (RoleID,FunctionID) VALUES (2,5)

INSERT INTO [ACL_Role_Function] (RoleID,FunctionID) VALUES (3,1)
INSERT INTO [ACL_Role_Function] (RoleID,FunctionID) VALUES (3,6)
INSERT INTO [ACL_Role_Function] (RoleID,FunctionID) VALUES (3,7)
INSERT INTO [ACL_Role_Function] (RoleID,FunctionID) VALUES (3,8)
INSERT INTO [ACL_Role_Function] (RoleID,FunctionID) VALUES (3,9)


INSERT INTO [ACL_Role_Function] (RoleID,FunctionID) VALUES (4,1)
INSERT INTO [ACL_Role_Function] (RoleID,FunctionID) VALUES (4,10)
INSERT INTO [ACL_Role_Function] (RoleID,FunctionID) VALUES (4,11)
INSERT INTO [ACL_Role_Function] (RoleID,FunctionID) VALUES (4,12)
INSERT INTO [ACL_Role_Function] (RoleID,FunctionID) VALUES (4,13)

INSERT INTO [ACL_Role_Function] (RoleID,FunctionID) VALUES (5,1)
INSERT INTO [ACL_Role_Function] (RoleID,FunctionID) VALUES (5,18)
INSERT INTO [ACL_Role_Function] (RoleID,FunctionID) VALUES (5,19)
INSERT INTO [ACL_Role_Function] (RoleID,FunctionID) VALUES (5,20)
INSERT INTO [ACL_Role_Function] (RoleID,FunctionID) VALUES (5,21)

INSERT INTO [ACL_Role_Function] (RoleID,FunctionID) VALUES (6,1)
INSERT INTO [ACL_Role_Function] (RoleID,FunctionID) VALUES (6,22)
INSERT INTO [ACL_Role_Function] (RoleID,FunctionID) VALUES (6,23)
INSERT INTO [ACL_Role_Function] (RoleID,FunctionID) VALUES (6,24)

INSERT INTO [DOC_Templete] (TempleteName,TempleteType,TempleteExt) VALUES ('销售模板',1,'docx')
INSERT INTO [DOC_Templete] (TempleteName,TempleteType,TempleteExt) VALUES ('人事模板',1,'docx')
INSERT INTO [DOC_Templete] (TempleteName,TempleteType,TempleteExt) VALUES ('行政模板',1,'docx')
INSERT INTO [DOC_Templete] (TempleteName,TempleteType,TempleteExt) VALUES ('采购模板',1,'docx')
INSERT INTO [DOC_Templete] (TempleteName,TempleteType,TempleteExt) VALUES ('采购表格',2,'xls')
INSERT INTO [DOC_Templete] (TempleteName,TempleteType,TempleteExt) VALUES ('采购PPT',3,'ppt')