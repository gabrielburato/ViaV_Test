USE [ViaVarejo]
GO
SET IDENTITY_INSERT [dbo].[Friend] ON 

INSERT [dbo].[Friend] ([Id], [Latitude], [Longitude], [Name]) VALUES (1, CAST(223.50 AS Decimal(18, 2)), CAST(294.50 AS Decimal(18, 2)), N'Pedro')
INSERT [dbo].[Friend] ([Id], [Latitude], [Longitude], [Name]) VALUES (2, CAST(145.00 AS Decimal(18, 2)), CAST(369.00 AS Decimal(18, 2)), N'Maria')
INSERT [dbo].[Friend] ([Id], [Latitude], [Longitude], [Name]) VALUES (3, CAST(458.00 AS Decimal(18, 2)), CAST(346.80 AS Decimal(18, 2)), N'João')
INSERT [dbo].[Friend] ([Id], [Latitude], [Longitude], [Name]) VALUES (4, CAST(333.00 AS Decimal(18, 2)), CAST(777.00 AS Decimal(18, 2)), N'Carla')
INSERT [dbo].[Friend] ([Id], [Latitude], [Longitude], [Name]) VALUES (5, CAST(1120.00 AS Decimal(18, 2)), CAST(456.00 AS Decimal(18, 2)), N'José')
SET IDENTITY_INSERT [dbo].[Friend] OFF
