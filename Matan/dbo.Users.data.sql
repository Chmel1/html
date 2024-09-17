SET IDENTITY_INSERT [dbo].[Users] ON
INSERT INTO [dbo].[Users] ([User_Id], [Login], [Password], [Role], [patient_id]) VALUES (15, N'user1', N'password1', N'User', 35)
INSERT INTO [dbo].[Users] ([User_Id], [Login], [Password], [Role], [patient_id]) VALUES (16, N'doctor1', N'password2', N'Doctor', NULL)
INSERT INTO [dbo].[Users] ([User_Id], [Login], [Password], [Role], [patient_id]) VALUES (17, N'123', N'123', NULL, NULL)
SET IDENTITY_INSERT [dbo].[Users] OFF
