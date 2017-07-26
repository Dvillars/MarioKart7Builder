USE [KartBuilder]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET IDENTITY_INSERT [dbo].[characters] ON
INSERT [dbo].[characters] ([id],[name],[landSpeed],[waterSpeed],[airSpeed],[acceleration],[weight],[landHandling],[watrHandling],[airHandling],[offRoad],[miniTurbo],[stabiliy],[drift]) VALUES (1,'Mario',0,0,0,0,0,0,0,0,0,0,0,0)
INSERT [dbo].[characters] ([id],[name],[landSpeed],[waterSpeed],[airSpeed],[acceleration],[weight],[landHandling],[watrHandling],[airHandling],[offRoad],[miniTurbo],[stabiliy],[drift]) VALUES (2,'Luigi',0,0,0,0,0,0,0,0,0,0,0,0)
INSERT [dbo].[characters] ([id],[name],[landSpeed],[waterSpeed],[airSpeed],[acceleration],[weight],[landHandling],[watrHandling],[airHandling],[offRoad],[miniTurbo],[stabiliy],[drift]) VALUES (3,'Peach',-.25,.25,0,.50,-.50,.25,.25,.25,0,0,0,0)
INSERT [dbo].[characters] ([id],[name],[landSpeed],[waterSpeed],[airSpeed],[acceleration],[weight],[landHandling],[watrHandling],[airHandling],[offRoad],[miniTurbo],[stabiliy],[drift]) VALUES (4,'Yoshi',-.25,.25,0,.50,-.50,.25,.25,.25,0,0,0,0)
INSERT [dbo].[characters] ([id],[name],[landSpeed],[waterSpeed],[airSpeed],[acceleration],[weight],[landHandling],[watrHandling],[airHandling],[offRoad],[miniTurbo],[stabiliy],[drift]) VALUES (5,'Bowser',.50,-.25,0,-1.0,1.0,-.25,-.25,-.25,-.25,-.25,0,-1.0)
INSERT [dbo].[characters] ([id],[name],[landSpeed],[waterSpeed],[airSpeed],[acceleration],[weight],[landHandling],[watrHandling],[airHandling],[offRoad],[miniTurbo],[stabiliy],[drift]) VALUES (6,'Donkey_Kong',.25,-.25,0,-.50,.50,-.25,-.25,-.25,0,-.25,0,-1.0)
INSERT [dbo].[characters] ([id],[name],[landSpeed],[waterSpeed],[airSpeed],[acceleration],[weight],[landHandling],[watrHandling],[airHandling],[offRoad],[miniTurbo],[stabiliy],[drift]) VALUES (7,'Toad',-.50,.25,0,1.0,-1.0,.25,.25,.25,.25,.25,0,1.0)
INSERT [dbo].[characters] ([id],[name],[landSpeed],[waterSpeed],[airSpeed],[acceleration],[weight],[landHandling],[watrHandling],[airHandling],[offRoad],[miniTurbo],[stabiliy],[drift]) VALUES (8,'Koopa_Troopa',-.50,.25,0,1.0,-1.0,.25,.25,.25,.25,.25,0,1.0)
INSERT [dbo].[characters] ([id],[name],[landSpeed],[waterSpeed],[airSpeed],[acceleration],[weight],[landHandling],[watrHandling],[airHandling],[offRoad],[miniTurbo],[stabiliy],[drift]) VALUES (9,'Daisy',-.25,.25,0,.50,-.50,.25,.25,.25,0,0,0,0)
INSERT [dbo].[characters] ([id],[name],[landSpeed],[waterSpeed],[airSpeed],[acceleration],[weight],[landHandling],[watrHandling],[airHandling],[offRoad],[miniTurbo],[stabiliy],[drift]) VALUES (10,'Wario',.50,-.25,0,-1.0,1.0,-.25,-.25,-.25,-.25,-.25,0,-1.0)
INSERT [dbo].[characters] ([id],[name],[landSpeed],[waterSpeed],[airSpeed],[acceleration],[weight],[landHandling],[watrHandling],[airHandling],[offRoad],[miniTurbo],[stabiliy],[drift]) VALUES (11,'Rosalina',.25,-.25,0,-.50,.50,-.25,-.25,-.25,0,-.25,0,-1.0)
INSERT [dbo].[characters] ([id],[name],[landSpeed],[waterSpeed],[airSpeed],[acceleration],[weight],[landHandling],[watrHandling],[airHandling],[offRoad],[miniTurbo],[stabiliy],[drift]) VALUES (12,'Metal_Mario',.50,-.25,0,-1.0,1.0,-.25,-.25,-.25,-.25,-.25,0,-1.0)
INSERT [dbo].[characters] ([id],[name],[landSpeed],[waterSpeed],[airSpeed],[acceleration],[weight],[landHandling],[watrHandling],[airHandling],[offRoad],[miniTurbo],[stabiliy],[drift]) VALUES (13,'Shy_Guy',-.50,.25,0,1.0,-1.0,.25,.25,.25,.25,.25,0,1.0)
INSERT [dbo].[characters] ([id],[name],[landSpeed],[waterSpeed],[airSpeed],[acceleration],[weight],[landHandling],[watrHandling],[airHandling],[offRoad],[miniTurbo],[stabiliy],[drift]) VALUES (14,'Honey_Queen',.50,-.25,0,-1.0,1.0,-.25,-.25,-.25,-.25,-.25,0,-1.0)
INSERT [dbo].[characters] ([id],[name],[landSpeed],[waterSpeed],[airSpeed],[acceleration],[weight],[landHandling],[watrHandling],[airHandling],[offRoad],[miniTurbo],[stabiliy],[drift]) VALUES (15,'Wiggler',.25,-.25,0,-.50,.50,-.25,-.25,-.25,0,-.25,0,-1.0)
INSERT [dbo].[characters] ([id],[name],[landSpeed],[waterSpeed],[airSpeed],[acceleration],[weight],[landHandling],[watrHandling],[airHandling],[offRoad],[miniTurbo],[stabiliy],[drift]) VALUES (16,'Lakitu',-.50,.25,0,1.0,-1.0,.25,.25,.25,.25,.25,0,1.0)
INSERT [dbo].[characters] ([id],[name],[landSpeed],[waterSpeed],[airSpeed],[acceleration],[weight],[landHandling],[watrHandling],[airHandling],[offRoad],[miniTurbo],[stabiliy],[drift]) VALUES (17,'Mii ',0,0,0,0,0,0,0,0,0,0,0,0)
SET IDENTITY_INSERT [dbo].[characters] OFF
GO
SET IDENTITY_INSERT [dbo].[bodys] ON
INSERT [dbo].[bodys] ([id],[name],[landSpeed],[waterSpeed],[airSpeed],[acceleration],[weight],[landHandling],[watrHandling],[airHandling],[offRoad],[miniTurbo],[stabiliy],[drift]) VALUES (1,'Standard',3.50,3.50,3.50,3.00,3.25,2.75,2.75,2.75,3.75,2.50,1.75,3.25)
INSERT [dbo].[bodys] ([id],[name],[landSpeed],[waterSpeed],[airSpeed],[acceleration],[weight],[landHandling],[watrHandling],[airHandling],[offRoad],[miniTurbo],[stabiliy],[drift]) VALUES (2,'Gold_Kart',3.75,3.50,3.25,2.75,3.50,2.75,2.75,2.75,3.50,2.25,1.75,3.00)
INSERT [dbo].[bodys] ([id],[name],[landSpeed],[waterSpeed],[airSpeed],[acceleration],[weight],[landHandling],[watrHandling],[airHandling],[offRoad],[miniTurbo],[stabiliy],[drift]) VALUES (3,'Birthday_Girl',3.00,4.00,4.00,3.50,3.00,3.25,3.00,3.00,3.50,3.00,1.75,3.50)
INSERT [dbo].[bodys] ([id],[name],[landSpeed],[waterSpeed],[airSpeed],[acceleration],[weight],[landHandling],[watrHandling],[airHandling],[offRoad],[miniTurbo],[stabiliy],[drift]) VALUES (4,'Bumble_V',3.50,3.50,4.00,3.50,3.00,2.25,2.75,3.00,4.00,4.00,1.75,3.50)
INSERT [dbo].[bodys] ([id],[name],[landSpeed],[waterSpeed],[airSpeed],[acceleration],[weight],[landHandling],[watrHandling],[airHandling],[offRoad],[miniTurbo],[stabiliy],[drift]) VALUES (5,'Bruiser',4.00,3.00,3.25,2.75,3.50,2.25,2.75,2.75,3.75,3.00,1.75,3.00)
INSERT [dbo].[bodys] ([id],[name],[landSpeed],[waterSpeed],[airSpeed],[acceleration],[weight],[landHandling],[watrHandling],[airHandling],[offRoad],[miniTurbo],[stabiliy],[drift]) VALUES (6,'Soda_Jet',3.75,3.00,4.00,3.25,3.00,2.75,2.75,3.00,3.50,3.00,1.75,3.50)
INSERT [dbo].[bodys] ([id],[name],[landSpeed],[waterSpeed],[airSpeed],[acceleration],[weight],[landHandling],[watrHandling],[airHandling],[offRoad],[miniTurbo],[stabiliy],[drift]) VALUES (7,'B_Dasher',4.00,3.00,3.50,2.50,3.25,3.00,2.75,2.75,3.50,2.50,1.75,3.25)
INSERT [dbo].[bodys] ([id],[name],[landSpeed],[waterSpeed],[airSpeed],[acceleration],[weight],[landHandling],[watrHandling],[airHandling],[offRoad],[miniTurbo],[stabiliy],[drift]) VALUES (8,'Egg_1',3.25,5.00,4.00,3.50,3.00,2.75,2.75,2.75,3.75,3.00,1.75,3.50)
INSERT [dbo].[bodys] ([id],[name],[landSpeed],[waterSpeed],[airSpeed],[acceleration],[weight],[landHandling],[watrHandling],[airHandling],[offRoad],[miniTurbo],[stabiliy],[drift]) VALUES (9,'Barrel_Train',3.75,2.75,3.25,3.00,3.50,2.25,2.75,2.75,3.75,4.00,1.75,3.00)
INSERT [dbo].[bodys] ([id],[name],[landSpeed],[waterSpeed],[airSpeed],[acceleration],[weight],[landHandling],[watrHandling],[airHandling],[offRoad],[miniTurbo],[stabiliy],[drift]) VALUES (10,'Tiny_Tug',3.00,5.00,3.25,3.00,3.50,2.75,3.25,2.75,4.00,2.00,1.75,3.00)
INSERT [dbo].[bodys] ([id],[name],[landSpeed],[waterSpeed],[airSpeed],[acceleration],[weight],[landHandling],[watrHandling],[airHandling],[offRoad],[miniTurbo],[stabiliy],[drift]) VALUES (11,'Cact_X',3.25,4.00,3.25,2.75,3.25,3.00,2.75,2.75,4.00,2.00,1.75,3.25)
INSERT [dbo].[bodys] ([id],[name],[landSpeed],[waterSpeed],[airSpeed],[acceleration],[weight],[landHandling],[watrHandling],[airHandling],[offRoad],[miniTurbo],[stabiliy],[drift]) VALUES (12,'Koopa_Clown',3.50,3.50,3.50,2.75,3.25,3.25,3.00,3.00,3.50,4.00,1.75,3.25)
INSERT [dbo].[bodys] ([id],[name],[landSpeed],[waterSpeed],[airSpeed],[acceleration],[weight],[landHandling],[watrHandling],[airHandling],[offRoad],[miniTurbo],[stabiliy],[drift]) VALUES (13,'Cloud_9',3.00,4.50,4.00,3.25,3.00,3.25,3.25,3.00,3.75,3.00,1.75,3.50)
INSERT [dbo].[bodys] ([id],[name],[landSpeed],[waterSpeed],[airSpeed],[acceleration],[weight],[landHandling],[watrHandling],[airHandling],[offRoad],[miniTurbo],[stabiliy],[drift]) VALUES (14,'Zucchini',4.00,3.00,3.25,2.75,3.25,2.50,2.75,2.75,3.75,2.00,1.75,3.25)
INSERT [dbo].[bodys] ([id],[name],[landSpeed],[waterSpeed],[airSpeed],[acceleration],[weight],[landHandling],[watrHandling],[airHandling],[offRoad],[miniTurbo],[stabiliy],[drift]) VALUES (15,'Blue_Seven',4.00,3.50,3.25,2.50,3.50,2.50,2.75,2.75,3.75,2.00,1.75,3.00)
INSERT [dbo].[bodys] ([id],[name],[landSpeed],[waterSpeed],[airSpeed],[acceleration],[weight],[landHandling],[watrHandling],[airHandling],[offRoad],[miniTurbo],[stabiliy],[drift]) VALUES (16,'Bolt_Buggy',3.75,3.00,3.25,2.50,3.50,2.50,2.75,2.75,4.00,2.50,1.75,3.00)
INSERT [dbo].[bodys] ([id],[name],[landSpeed],[waterSpeed],[airSpeed],[acceleration],[weight],[landHandling],[watrHandling],[airHandling],[offRoad],[miniTurbo],[stabiliy],[drift]) VALUES (17,'Pipe_Frame',3.25,4.50,4.00,3.25,3.00,2.75,3.00,3.00,4.00,3.00,1.75,3.50)
SET IDENTITY_INSERT [dbo].[bodys] OFF
GO
SET IDENTITY_INSERT [dbo].[tires] ON
INSERT [dbo].[tires] ([id],[name],[landSpeed],[waterSpeed],[airSpeed],[acceleration],[weight],[landHandling],[watrHandling],[airHandling],[offRoad],[miniTurbo],[stabiliy],[drift]) VALUES (1,'Standard',0,0,0,0,0,0,0,0,0,0,0,0)
INSERT [dbo].[tires] ([id],[name],[landSpeed],[waterSpeed],[airSpeed],[acceleration],[weight],[landHandling],[watrHandling],[airHandling],[offRoad],[miniTurbo],[stabiliy],[drift]) VALUES (2,'Gold_Tires',1,-1,0,-0.5,0.5,-1.25,0,-1,-2.5,0,0,-1)
INSERT [dbo].[tires] ([id],[name],[landSpeed],[waterSpeed],[airSpeed],[acceleration],[weight],[landHandling],[watrHandling],[airHandling],[offRoad],[miniTurbo],[stabiliy],[drift]) VALUES (3,'Roller',-0.75,1,1,0.75,-1,2,1.25,1,-1.25,1,1,-1)
INSERT [dbo].[tires] ([id],[name],[landSpeed],[waterSpeed],[airSpeed],[acceleration],[weight],[landHandling],[watrHandling],[airHandling],[offRoad],[miniTurbo],[stabiliy],[drift]) VALUES (4,'Slim',-0.25,0,0,0.25,-0.25,1.25,1.25,0,-1.25,-1,1,1)
INSERT [dbo].[tires] ([id],[name],[landSpeed],[waterSpeed],[airSpeed],[acceleration],[weight],[landHandling],[watrHandling],[airHandling],[offRoad],[miniTurbo],[stabiliy],[drift]) VALUES (5,'Slick',1,-1,0,-0.25,0.25,-1.25,-1.25,0,-2.5,0,0,1)
INSERT [dbo].[tires] ([id],[name],[landSpeed],[waterSpeed],[airSpeed],[acceleration],[weight],[landHandling],[watrHandling],[airHandling],[offRoad],[miniTurbo],[stabiliy],[drift]) VALUES (6,'Sponge',-0.25,-1,1,0.5,-0.75,0,-1.25,1,0,0,0,1)
INSERT [dbo].[tires] ([id],[name],[landSpeed],[waterSpeed],[airSpeed],[acceleration],[weight],[landHandling],[watrHandling],[airHandling],[offRoad],[miniTurbo],[stabiliy],[drift]) VALUES (7,'Mushroom',0.25,0,0,-0.25,-0.5,1.25,0,0,-1.25,0,0,-1)
INSERT [dbo].[tires] ([id],[name],[landSpeed],[waterSpeed],[airSpeed],[acceleration],[weight],[landHandling],[watrHandling],[airHandling],[offRoad],[miniTurbo],[stabiliy],[drift]) VALUES (8,'Wood',-0.5,1,1,0.5,-0.5,1.25,2.5,1,0,-1,1,1)
INSERT [dbo].[tires] ([id],[name],[landSpeed],[waterSpeed],[airSpeed],[acceleration],[weight],[landHandling],[watrHandling],[airHandling],[offRoad],[miniTurbo],[stabiliy],[drift]) VALUES (9,'Red_Monster',0.75,-1,0,-0.5,0.75,-1.25,-1.25,-1,1.25,0.25,-1,-1)
INSERT [dbo].[tires] ([id],[name],[landSpeed],[waterSpeed],[airSpeed],[acceleration],[weight],[landHandling],[watrHandling],[airHandling],[offRoad],[miniTurbo],[stabiliy],[drift]) VALUES (10,'Monster',0.75,-1,0,-0.75,1,-1.25,-1.25,-1,1.25,0,-1,0)
SET IDENTITY_INSERT [dbo].[tires] OFF
GO
SET IDENTITY_INSERT [dbo].[gliders] ON
INSERT [dbo].[gliders] ([id],[name],[landSpeed],[waterSpeed],[airSpeed],[acceleration],[weight],[landHandling],[watrHandling],[airHandling],[offRoad],[miniTurbo],[stabiliy],[drift]) VALUES (1,'Super_Glider',0,0,0,0,0,0,0,0,0,0,0,0)
INSERT [dbo].[gliders] ([id],[name],[landSpeed],[waterSpeed],[airSpeed],[acceleration],[weight],[landHandling],[watrHandling],[airHandling],[offRoad],[miniTurbo],[stabiliy],[drift]) VALUES (2,'Gold_Glider',0,0,0,0,0,0,0,0,0,0,0,0)
INSERT [dbo].[gliders] ([id],[name],[landSpeed],[waterSpeed],[airSpeed],[acceleration],[weight],[landHandling],[watrHandling],[airHandling],[offRoad],[miniTurbo],[stabiliy],[drift]) VALUES (3,'Peach_Parasol',0,0,-3,0.25,-0.25,0,0,2,0,0.25,0,-0.25)
INSERT [dbo].[gliders] ([id],[name],[landSpeed],[waterSpeed],[airSpeed],[acceleration],[weight],[landHandling],[watrHandling],[airHandling],[offRoad],[miniTurbo],[stabiliy],[drift]) VALUES (4,'Flower_Glider',0,0,-3,0.25,-0.25,0,0,2,0,0.25,0,-0.25)
INSERT [dbo].[gliders] ([id],[name],[landSpeed],[waterSpeed],[airSpeed],[acceleration],[weight],[landHandling],[watrHandling],[airHandling],[offRoad],[miniTurbo],[stabiliy],[drift]) VALUES (5,'Beast_Glider',0,0,0,0,0,0,0,0,0,0,0,0)
INSERT [dbo].[gliders] ([id],[name],[landSpeed],[waterSpeed],[airSpeed],[acceleration],[weight],[landHandling],[watrHandling],[airHandling],[offRoad],[miniTurbo],[stabiliy],[drift]) VALUES (6,'Swooper',0,0,-1.5,0.25,-0.25,0,0,1,0,0.25,0,-0.25)
INSERT [dbo].[gliders] ([id],[name],[landSpeed],[waterSpeed],[airSpeed],[acceleration],[weight],[landHandling],[watrHandling],[airHandling],[offRoad],[miniTurbo],[stabiliy],[drift]) VALUES (7,'Paraglider',0,0,-1.5,0.25,-0.25,0,0,1,0,0.25,0,-0.25)
SET IDENTITY_INSERT [dbo].[gliders] OFF
GO
