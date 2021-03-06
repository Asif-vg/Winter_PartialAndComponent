USE [WinterDB]
GO
SET IDENTITY_INSERT [dbo].[Socials] ON 

INSERT [dbo].[Socials] ([Id], [Name], [Icon], [Link]) VALUES (1, N'facebook', N'fa fa-facebook', N'https://www.facebook.com/')
INSERT [dbo].[Socials] ([Id], [Name], [Icon], [Link]) VALUES (2, N'twitter', N'fa fa-twitter', N'https://twitter.com/')
INSERT [dbo].[Socials] ([Id], [Name], [Icon], [Link]) VALUES (3, N'instagram', N'fa fa-instagram', N'https://www.instagram.com/')
SET IDENTITY_INSERT [dbo].[Socials] OFF
GO
SET IDENTITY_INSERT [dbo].[SocialImages] ON 

INSERT [dbo].[SocialImages] ([Id], [SocialsImage], [SocialId]) VALUES (1, N'inst_1.png', 3)
INSERT [dbo].[SocialImages] ([Id], [SocialsImage], [SocialId]) VALUES (2, N'inst_2.png', 3)
INSERT [dbo].[SocialImages] ([Id], [SocialsImage], [SocialId]) VALUES (3, N'inst_3.png', 3)
INSERT [dbo].[SocialImages] ([Id], [SocialsImage], [SocialId]) VALUES (4, N'inst_4.png', 3)
INSERT [dbo].[SocialImages] ([Id], [SocialsImage], [SocialId]) VALUES (5, N'inst_5.png', 3)
SET IDENTITY_INSERT [dbo].[SocialImages] OFF
GO
SET IDENTITY_INSERT [dbo].[Banners] ON 

INSERT [dbo].[Banners] ([Id], [Title], [SupTitle], [Image]) VALUES (1, N'Fashion Collection 2019', N'Winter Fasion', NULL)
SET IDENTITY_INSERT [dbo].[Banners] OFF
GO
SET IDENTITY_INSERT [dbo].[Setting] ON 

INSERT [dbo].[Setting] ([Id], [Address], [Phone], [Email], [Logo]) VALUES (1, N'200, Green block, NewYork', N'+10 456 267 1678', N'Contact89@Winter.Com', N'logo.png')
SET IDENTITY_INSERT [dbo].[Setting] OFF
GO
