INSERT INTO [User] (UserName,UserRealName,UserPassword,UserSex,UserAddress) VALUES ('xm','С��','123',0,'������̶')
INSERT INTO [User] (UserName,UserRealName,UserPassword,UserSex,UserAddress) VALUES ('xz','С��','123',0,'������̶')
INSERT INTO [User] (UserName,UserRealName,UserPassword,UserSex,UserAddress) VALUES ('xh','С��','123',0,'������̶')


INSERT INTO [ACL_Role] (RoleName,RoleDescription) VALUES ('��̨��������Ա','ӵ�к�̨��������Ȩ��')
INSERT INTO [ACL_Role] (RoleName,RoleDescription) VALUES ('������','ӵ�����²��ļ��ķ���Ȩ��')
INSERT INTO [ACL_Role] (RoleName,RoleDescription) VALUES ('������','ӵ�����۲��ļ��ķ���Ȩ��')
INSERT INTO [ACL_Role] (RoleName,RoleDescription) VALUES ('������','ӵ���������ļ��ķ���Ȩ��')
INSERT INTO [ACL_Role] (RoleName,RoleDescription) VALUES ('������','ӵ�в����ļ��ķ���Ȩ��')
INSERT INTO [ACL_Role] (RoleName,RoleDescription) VALUES ('��̨���¹���Ա','ӵ�к�̨�û��Ĺ���Ȩ��')


INSERT INTO [File] (FileName,FileSize,FilePID) VALUES ('�ҵ�ͼƬ',0,-1)
INSERT INTO [File] (FileName,FileSize,FilePID) VALUES ('������Ƭ',0,1)
INSERT INTO [File] (FileName,FileSize,FilePID) VALUES ('������Ƭ',0,1)
INSERT INTO [File] (FileName,FileSize,FilePID) VALUES ('���˱ʼ�',0,-1)
INSERT INTO [File] (FileName,FileSize,FilePID) VALUES ('�����¼',0,-1)


INSERT INTO [File] (FileName,FileSize,FilePID) VALUES ('���²��ļ���',0,-1)
INSERT INTO [File] (FileName,FileSize,FilePID) VALUES ('���۲��ļ���',0,-1)
INSERT INTO [File] (FileName,FileSize,FilePID) VALUES ('�������ļ���',0,-1)
INSERT INTO [File] (FileName,FileSize,FilePID) VALUES ('�����ļ���',0,-1)
INSERT INTO [File] (FileName,FileSize,FilePID) VALUES ('���²������¼',0,6)
INSERT INTO [File] (FileName,FileSize,FilePID) VALUES ('���²���һ�λ����¼',0,10)


INSERT INTO [File] (FileName,FileExt,FileSize,FilePID) VALUES ('�����ļ�1','jpg',13,11)
INSERT INTO [File] (FileName,FileExt,FileSize,FilePID) VALUES ('�����ļ�2','jpg',30,11)
INSERT INTO [File] (FileName,FileExt,FileSize,FilePID) VALUES ('�����ļ�3','jpg',12,11)
INSERT INTO [File] (FileName,FileExt,FileSize,FilePID) VALUES ('�����ļ�4','jpg',10,11)


INSERT INTO [Position] (PositionName) VALUES ('�ܼ�')
INSERT INTO [Position] (PositionName) VALUES ('����')
INSERT INTO [Position] (PositionName) VALUES ('�鳤')
INSERT INTO [Position] (PositionName) VALUES ('��ͨԱ��')

INSERT INTO [Department] (DepartmentName) VALUES ('���²�')
INSERT INTO [Department] (DepartmentName) VALUES ('���۲�')
INSERT INTO [Department] (DepartmentName) VALUES ('������')
INSERT INTO [Department] (DepartmentName) VALUES ('����')

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


INSERT INTO [ACL_File_Role] (FileID,RoleID) VALUES (6,2)
INSERT INTO [ACL_File_Role] (FileID,RoleID) VALUES (7,3)
INSERT INTO [ACL_File_Role] (FileID,RoleID) VALUES (8,4)
INSERT INTO [ACL_File_Role] (FileID,RoleID) VALUES (9,5)
INSERT INTO [ACL_File_Role] (FileID,RoleID) VALUES (10,2)
INSERT INTO [ACL_File_Role] (FileID,RoleID) VALUES (11,2)


INSERT INTO [ACL_File_User] (FileID,UserID) VALUES (1,1)
INSERT INTO [ACL_File_User] (FileID,UserID) VALUES (2,1)
INSERT INTO [ACL_File_User] (FileID,UserID) VALUES (3,1)
INSERT INTO [ACL_File_User] (FileID,UserID) VALUES (4,1)
INSERT INTO [ACL_File_User] (FileID,UserID) VALUES (5,1)

INSERT INTO [ACL_File_User] (FileID,UserID) VALUES (12,1)
INSERT INTO [ACL_File_User] (FileID,UserID) VALUES (13,2)
INSERT INTO [ACL_File_User] (FileID,UserID) VALUES (14,1)
INSERT INTO [ACL_File_User] (FileID,UserID) VALUES (15,1)

INSERT INTO [File_Department] (FileID,DepartmentID) VALUES (6,1)
INSERT INTO [File_Department] (FileID,DepartmentID) VALUES (7,2)
INSERT INTO [File_Department] (FileID,DepartmentID) VALUES (8,3)
INSERT INTO [File_Department] (FileID,DepartmentID) VALUES (9,4)
INSERT INTO [File_Department] (FileID,DepartmentID) VALUES (10,1)
INSERT INTO [File_Department] (FileID,DepartmentID) VALUES (11,1)

INSERT INTO [File_Department] (FileID,DepartmentID) VALUES (12,1)
INSERT INTO [File_Department] (FileID,DepartmentID) VALUES (13,1)
INSERT INTO [File_Department] (FileID,DepartmentID) VALUES (14,1)
INSERT INTO [File_Department] (FileID,DepartmentID) VALUES (15,1)

INSERT INTO [ACL_Function] (FunctionPID,FunctionName,FunctionControl) VALUES (-1,'�ļ�����ϵͳ','FMSBG')

INSERT INTO [ACL_Function] (FunctionPID,FunctionName,FunctionControl) VALUES (1,'�û�����','User')
INSERT INTO [ACL_Function] (FunctionPID,FunctionName,FunctionControl) VALUES (2,'����û�','User/Add')
INSERT INTO [ACL_Function] (FunctionPID,FunctionName,FunctionControl) VALUES (2,'ɾ���û�','User/Delete')
INSERT INTO [ACL_Function] (FunctionPID,FunctionName,FunctionControl) VALUES (2,'�༭�û�','User/Edit')

INSERT INTO [ACL_Function] (FunctionPID,FunctionName,FunctionControl) VALUES (1,'���Ź���','Department')
INSERT INTO [ACL_Function] (FunctionPID,FunctionName,FunctionControl) VALUES (6,'��Ӳ���','Department/Add')
INSERT INTO [ACL_Function] (FunctionPID,FunctionName,FunctionControl) VALUES (6,'ɾ������','Department/Delete')
INSERT INTO [ACL_Function] (FunctionPID,FunctionName,FunctionControl) VALUES (6,'�༭����','Department/Edit')

INSERT INTO [ACL_FUNCTION] (FUNCTIONPID,FUNCTIONNAME,FUNCTIONCONTROL) VALUES (1,'��ɫ����','ROLE')
INSERT INTO [ACL_FUNCTION] (FUNCTIONPID,FUNCTIONNAME,FUNCTIONCONTROL) VALUES (10,'��ӽ�ɫ','ROLE/ADD')
INSERT INTO [ACL_FUNCTION] (FUNCTIONPID,FUNCTIONNAME,FUNCTIONCONTROL) VALUES (10,'ɾ����ɫ','ROLE/DELETE')
INSERT INTO [ACL_FUNCTION] (FUNCTIONPID,FUNCTIONNAME,FUNCTIONCONTROL) VALUES (10,'�༭��ɫ','ROLE/EDIT')

INSERT INTO [ACL_Function] (FunctionPID,FunctionName,FunctionControl) VALUES (1,'��λ����','Position')
INSERT INTO [ACL_Function] (FunctionPID,FunctionName,FunctionControl) VALUES (14,'��Ӹ�λ','Position/Add')
INSERT INTO [ACL_Function] (FunctionPID,FunctionName,FunctionControl) VALUES (14,'ɾ����λ','Position/Delete')
INSERT INTO [ACL_Function] (FunctionPID,FunctionName,FunctionControl) VALUES (14,'�༭��λ','Position/Edit')

INSERT INTO [ACL_Function] (FunctionPID,FunctionName,FunctionControl) VALUES (1,'���ܹ���','Function')
INSERT INTO [ACL_Function] (FunctionPID,FunctionName,FunctionControl) VALUES (18,'��ӹ���','Function/Add')
INSERT INTO [ACL_Function] (FunctionPID,FunctionName,FunctionControl) VALUES (18,'ɾ������','Function/Delete')
INSERT INTO [ACL_Function] (FunctionPID,FunctionName,FunctionControl) VALUES (18,'�༭����','Function/Edit')

INSERT INTO [ACL_Function] (FunctionPID,FunctionName,FunctionControl) VALUES (1,'ģ�����','Template')
INSERT INTO [ACL_Function] (FunctionPID,FunctionName,FunctionControl) VALUES (22,'���ģ��','Template/Add')
INSERT INTO [ACL_Function] (FunctionPID,FunctionName,FunctionControl) VALUES (22,'ɾ��ģ��','Template/Delete')

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

INSERT INTO [ACL_Role_Function] (RoleID,FunctionID) VALUES (6,1)
INSERT INTO [ACL_Role_Function] (RoleID,FunctionID) VALUES (6,2)
INSERT INTO [ACL_Role_Function] (RoleID,FunctionID) VALUES (6,3)
INSERT INTO [ACL_Role_Function] (RoleID,FunctionID) VALUES (6,4)
INSERT INTO [ACL_Role_Function] (RoleID,FunctionID) VALUES (6,5)

INSERT INTO [DOC_Template] (TemplateName,TemplateType,TemplateExt) VALUES ('����ģ��',1,'docx')
INSERT INTO [DOC_Template] (TemplateName,TemplateType,TemplateExt) VALUES ('����ģ��',1,'docx')
INSERT INTO [DOC_Template] (TemplateName,TemplateType,TemplateExt) VALUES ('����ģ��',1,'docx')
INSERT INTO [DOC_Template] (TemplateName,TemplateType,TemplateExt) VALUES ('�ɹ�ģ��',1,'docx')

INSERT INTO [DOC_Template] (TemplateName,TemplateType,TemplateExt) VALUES ('�ɹ����',2,'xls')

INSERT INTO [DOC_Template] (TemplateName,TemplateType,TemplateExt) VALUES ('�ɹ�PPT',3,'ppt')