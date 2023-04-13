USE [PBL3]
GO
SET IDENTITY_INSERT [dbo].[POSITION] ON 
GO
INSERT [dbo].[POSITION] ([PositionID], [Position]) VALUES (1, N'Giám đốc')
GO
INSERT [dbo].[POSITION] ([PositionID], [Position]) VALUES (2, N'Nhân viên')
GO
INSERT [dbo].[POSITION] ([PositionID], [Position]) VALUES (3, N'Khách hàng')
GO
INSERT [dbo].[POSITION] ([PositionID], [Position]) VALUES (4, N'Lái tàu')
GO
SET IDENTITY_INSERT [dbo].[POSITION] OFF
GO
INSERT [dbo].[PEOPLE] ([Username], [Name], [Gender], [BirthDay], [Address], [IDCard], [Email], [Phone], [PositionID]) VALUES (N'Admin1', N'Nguyễn Văn A', 1, CAST(N'2001-02-03T00:00:00.000' AS DateTime), N'Đà Nẵng', N'125279822913', N'nguyenVanA@gmail.com', N'0684938938', 1)
GO
INSERT [dbo].[PEOPLE] ([Username], [Name], [Gender], [BirthDay], [Address], [IDCard], [Email], [Phone], [PositionID]) VALUES (N'adsff', N'Duing Tri Duc', 1, CAST(N'2001-07-02T08:52:01.000' AS DateTime), N'Anh Sơn', N'634724768563', N'd@gmail.com', N'0127737737', 2)
GO
INSERT [dbo].[PEOPLE] ([Username], [Name], [Gender], [BirthDay], [Address], [IDCard], [Email], [Phone], [PositionID]) VALUES (N'BaoTri', N'Phan Trí Bảo', 1, CAST(N'2002-02-19T00:00:00.000' AS DateTime), N'Hà Nội', N'42589729821 ', N'tri12@gmail.com', N'0625376375', 4)
GO
INSERT [dbo].[PEOPLE] ([Username], [Name], [Gender], [BirthDay], [Address], [IDCard], [Email], [Phone], [PositionID]) VALUES (N'CongHai', N'Hồ Công Hải', 1, CAST(N'2002-08-09T00:00:00.000' AS DateTime), N'Đồng Nai', N'078972583297', N'congHai@gmail.com', N'0578957921', 4)
GO
INSERT [dbo].[PEOPLE] ([Username], [Name], [Gender], [BirthDay], [Address], [IDCard], [Email], [Phone], [PositionID]) VALUES (N'DangHoan', N'Nguyễn Thế Đăng Hoan', 1, CAST(N'2002-02-03T00:00:00.000' AS DateTime), N'Quảng Nam', N'049202013212', N'nguyenthedanghoan@gmail.com', N'0852556258', 3)
GO
INSERT [dbo].[PEOPLE] ([Username], [Name], [Gender], [BirthDay], [Address], [IDCard], [Email], [Phone], [PositionID]) VALUES (N'DangHoan2', N'Nguyễn Thế Đăng Hoan', 1, CAST(N'2002-02-03T20:51:17.000' AS DateTime), N'Quảng Nam', N'049202013212', N'nguyenthedanghoan@gmail.com', N'0852556258', 3)
GO
INSERT [dbo].[PEOPLE] ([Username], [Name], [Gender], [BirthDay], [Address], [IDCard], [Email], [Phone], [PositionID]) VALUES (N'Du', N'Dương Như Hoan', 1, CAST(N'2001-07-02T08:47:38.000' AS DateTime), N'Hà Nam', N'354647583547', N'duc@gmail.com', N'0748463564', 3)
GO
INSERT [dbo].[PEOPLE] ([Username], [Name], [Gender], [BirthDay], [Address], [IDCard], [Email], [Phone], [PositionID]) VALUES (N'duccc', N'duc', 1, CAST(N'2002-07-02T09:15:31.000' AS DateTime), N'', N'354435474577', N'sss@gmail.com', N'6364663666', 2)
GO
INSERT [dbo].[PEOPLE] ([Username], [Name], [Gender], [BirthDay], [Address], [IDCard], [Email], [Phone], [PositionID]) VALUES (N'Hien123', N'Nguyễn Thị Hiền', 0, CAST(N'2002-07-18T00:00:00.000' AS DateTime), N'TP Hồ Chí Minh', N'62860926070 ', N'hien@gmail.com', N'0290652762', 4)
GO
INSERT [dbo].[PEOPLE] ([Username], [Name], [Gender], [BirthDay], [Address], [IDCard], [Email], [Phone], [PositionID]) VALUES (N'NhuPhong', N'Hồ Như Phong', 1, CAST(N'2002-03-15T00:00:00.000' AS DateTime), N'Nghệ An', N'027527582517', N'nhuphong@gmail.com', N'0869016712', 3)
GO
INSERT [dbo].[PEOPLE] ([Username], [Name], [Gender], [BirthDay], [Address], [IDCard], [Email], [Phone], [PositionID]) VALUES (N'TriDuc', N'Dương Trí Đức', 1, CAST(N'2002-03-15T00:00:00.000' AS DateTime), N'Hà Tĩnh', N'07686783732 ', N'triduc@gmail.com', N'0865332774', 3)
GO
SET IDENTITY_INSERT [dbo].[LOGIN] ON 
GO
INSERT [dbo].[LOGIN] ([LoginID], [Username], [PassWord], [State]) VALUES (2, N'Admin1', N'admin1', 1)
GO
INSERT [dbo].[LOGIN] ([LoginID], [Username], [PassWord], [State]) VALUES (4, N'DangHoan', N'danghoan', 1)
GO
INSERT [dbo].[LOGIN] ([LoginID], [Username], [PassWord], [State]) VALUES (31, N'Du', N'du', NULL)
GO
INSERT [dbo].[LOGIN] ([LoginID], [Username], [PassWord], [State]) VALUES (32, N'adsff', N'713685636', NULL)
GO
INSERT [dbo].[LOGIN] ([LoginID], [Username], [PassWord], [State]) VALUES (33, N'duccc', N'123456789', NULL)
GO
INSERT [dbo].[LOGIN] ([LoginID], [Username], [PassWord], [State]) VALUES (34, N'DangHoan2', N'123', NULL)
GO
SET IDENTITY_INSERT [dbo].[LOGIN] OFF
GO
SET IDENTITY_INSERT [dbo].[STATION] ON 
GO
INSERT [dbo].[STATION] ([StationID], [StationName], [Address], [State]) VALUES (1, N'Đà Nẵng', N'Đà Nẵng', N'true')
GO
INSERT [dbo].[STATION] ([StationID], [StationName], [Address], [State]) VALUES (2, N'TP Hồ Chí Minh', N'TP Hồ Chí Minh', N'true')
GO
INSERT [dbo].[STATION] ([StationID], [StationName], [Address], [State]) VALUES (3, N'Hà Nội ', N'Hà Nội', N'true')
GO
INSERT [dbo].[STATION] ([StationID], [StationName], [Address], [State]) VALUES (4, N'Sài Gòn', N'Sài Gòn', N'true')
GO
INSERT [dbo].[STATION] ([StationID], [StationName], [Address], [State]) VALUES (5, N'Điện Biên', N'Điên Biên', N'true')
GO
INSERT [dbo].[STATION] ([StationID], [StationName], [Address], [State]) VALUES (6, N'Hà Tĩnh', N'Hà Tĩnh', N'true')
GO
INSERT [dbo].[STATION] ([StationID], [StationName], [Address], [State]) VALUES (7, N'Nghệ An', N'Nghệ An', N'true')
GO
INSERT [dbo].[STATION] ([StationID], [StationName], [Address], [State]) VALUES (8, N'Quảng Nam', N'Quảng Nam', N'true')
GO
INSERT [dbo].[STATION] ([StationID], [StationName], [Address], [State]) VALUES (9, N'Quảng Bình', N'quangbinh', NULL)
GO
SET IDENTITY_INSERT [dbo].[STATION] OFF
GO
SET IDENTITY_INSERT [dbo].[SCHEDULE] ON 
GO
INSERT [dbo].[SCHEDULE] ([ScheduleID], [DepartureID], [ArrivalID], [DepartureTime], [ArrivalTime]) VALUES (7, 1, 3, CAST(N'2022-09-10T00:00:00.000' AS DateTime), CAST(N'2022-09-11T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[SCHEDULE] ([ScheduleID], [DepartureID], [ArrivalID], [DepartureTime], [ArrivalTime]) VALUES (9, 3, 6, CAST(N'2022-08-15T00:00:00.000' AS DateTime), CAST(N'2022-08-23T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[SCHEDULE] ([ScheduleID], [DepartureID], [ArrivalID], [DepartureTime], [ArrivalTime]) VALUES (10, 2, 1, CAST(N'2022-07-25T23:35:43.000' AS DateTime), CAST(N'2022-08-25T23:35:43.000' AS DateTime))
GO
INSERT [dbo].[SCHEDULE] ([ScheduleID], [DepartureID], [ArrivalID], [DepartureTime], [ArrivalTime]) VALUES (11, 6, 5, CAST(N'2022-07-25T23:51:45.000' AS DateTime), CAST(N'2022-08-25T23:51:45.000' AS DateTime))
GO
INSERT [dbo].[SCHEDULE] ([ScheduleID], [DepartureID], [ArrivalID], [DepartureTime], [ArrivalTime]) VALUES (13, 3, 2, CAST(N'2022-08-28T15:28:30.000' AS DateTime), CAST(N'2022-09-28T15:28:30.000' AS DateTime))
GO
INSERT [dbo].[SCHEDULE] ([ScheduleID], [DepartureID], [ArrivalID], [DepartureTime], [ArrivalTime]) VALUES (27, 2, 1, CAST(N'2022-07-02T01:55:38.000' AS DateTime), CAST(N'2022-07-02T13:55:38.000' AS DateTime))
GO
INSERT [dbo].[SCHEDULE] ([ScheduleID], [DepartureID], [ArrivalID], [DepartureTime], [ArrivalTime]) VALUES (28, 1, 4, CAST(N'2022-07-02T02:13:22.000' AS DateTime), CAST(N'2022-07-02T02:16:22.000' AS DateTime))
GO
INSERT [dbo].[SCHEDULE] ([ScheduleID], [DepartureID], [ArrivalID], [DepartureTime], [ArrivalTime]) VALUES (30, 2, 1, CAST(N'2022-07-02T08:03:36.000' AS DateTime), CAST(N'2022-07-02T08:04:36.000' AS DateTime))
GO
INSERT [dbo].[SCHEDULE] ([ScheduleID], [DepartureID], [ArrivalID], [DepartureTime], [ArrivalTime]) VALUES (31, 7, 1, CAST(N'2022-07-02T08:07:34.000' AS DateTime), CAST(N'2022-07-02T08:08:34.000' AS DateTime))
GO
INSERT [dbo].[SCHEDULE] ([ScheduleID], [DepartureID], [ArrivalID], [DepartureTime], [ArrivalTime]) VALUES (32, 4, 6, CAST(N'2022-07-02T09:53:52.000' AS DateTime), CAST(N'2022-07-02T10:53:52.000' AS DateTime))
GO
INSERT [dbo].[SCHEDULE] ([ScheduleID], [DepartureID], [ArrivalID], [DepartureTime], [ArrivalTime]) VALUES (33, 1, 9, CAST(N'2022-07-03T09:18:49.000' AS DateTime), CAST(N'2022-07-05T09:18:49.000' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[SCHEDULE] OFF
GO
SET IDENTITY_INSERT [dbo].[TRAIN] ON 
GO
INSERT [dbo].[TRAIN] ([TrainID], [TrainName], [NumberOfCarriages], [State]) VALUES (1, N'Tàu Thống Nhất', 25, 1)
GO
INSERT [dbo].[TRAIN] ([TrainID], [TrainName], [NumberOfCarriages], [State]) VALUES (2, N'Tàu Trường Sơn', 24, 1)
GO
INSERT [dbo].[TRAIN] ([TrainID], [TrainName], [NumberOfCarriages], [State]) VALUES (3, N'Tàu Quyết Thắng', 25, 1)
GO
INSERT [dbo].[TRAIN] ([TrainID], [TrainName], [NumberOfCarriages], [State]) VALUES (4, N'Tàu Anh Dũng', 24, 1)
GO
INSERT [dbo].[TRAIN] ([TrainID], [TrainName], [NumberOfCarriages], [State]) VALUES (5, N'Tàu Thành Công', 25, 1)
GO
INSERT [dbo].[TRAIN] ([TrainID], [TrainName], [NumberOfCarriages], [State]) VALUES (6, N'se1', 10, NULL)
GO
SET IDENTITY_INSERT [dbo].[TRAIN] OFF
GO
INSERT [dbo].[TRIP] ([ScheduleID], [TrainID], [BasicPrice], [DriverUN]) VALUES (7, 2, 30000.0000, N'BaoTri')
GO
INSERT [dbo].[TRIP] ([ScheduleID], [TrainID], [BasicPrice], [DriverUN]) VALUES (7, 4, 10000.0000, N'BaoTri')
GO
INSERT [dbo].[TRIP] ([ScheduleID], [TrainID], [BasicPrice], [DriverUN]) VALUES (27, 1, 30000.0000, N'CongHai')
GO
INSERT [dbo].[TRIP] ([ScheduleID], [TrainID], [BasicPrice], [DriverUN]) VALUES (28, 3, 32000.0000, N'CongHai')
GO
INSERT [dbo].[TRIP] ([ScheduleID], [TrainID], [BasicPrice], [DriverUN]) VALUES (30, 5, 25000.0000, N'BaoTri')
GO
INSERT [dbo].[TRIP] ([ScheduleID], [TrainID], [BasicPrice], [DriverUN]) VALUES (31, 2, 23000.0000, N'BaoTri')
GO
SET IDENTITY_INSERT [dbo].[TICKET] ON 
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6585, N'A1', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6586, N'A2', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6587, N'A3', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6588, N'A4', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6589, N'A5', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6590, N'A6', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6591, N'A7', 30000.0000, 1, N'danghoan')
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6592, N'A8', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6593, N'A9', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6594, N'A10', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6595, N'A11', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6596, N'A12', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6597, N'A13', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6598, N'A14', 30000.0000, 1, N'DangHoan')
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6599, N'A15', 30000.0000, 1, N'danghoan')
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6600, N'A16', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6601, N'A17', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6602, N'A18', 30000.0000, 1, N'danghoan')
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6603, N'A19', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6604, N'A20', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6605, N'A21', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6606, N'A22', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6607, N'A23', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6608, N'A24', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6609, N'A25', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6610, N'A26', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6611, N'A27', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6612, N'A28', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6613, N'A29', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6614, N'A30', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6615, N'B1', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6616, N'B2', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6617, N'B3', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6618, N'B4', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6619, N'B5', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6620, N'B6', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6621, N'B7', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6622, N'B8', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6623, N'B9', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6624, N'B10', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6625, N'B11', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6626, N'B12', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6627, N'B13', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6628, N'B14', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6629, N'B15', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6630, N'B16', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6631, N'B17', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6632, N'B18', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6633, N'B19', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6634, N'B20', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6635, N'B21', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6636, N'B22', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6637, N'B23', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6638, N'B24', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6639, N'B25', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6640, N'B26', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6641, N'B27', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6642, N'B28', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6643, N'B29', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6644, N'B30', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6645, N'C1', 36000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6646, N'C2', 36000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6647, N'C3', 36000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6648, N'C4', 36000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6649, N'C5', 36000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6650, N'C6', 36000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6651, N'C7', 36000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6652, N'C8', 36000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6653, N'C9', 36000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6654, N'C10', 36000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6655, N'C11', 36000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6656, N'C12', 36000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6657, N'C13', 36000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6658, N'C14', 36000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6659, N'C15', 36000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6660, N'C16', 36000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6661, N'C17', 36000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6662, N'C18', 36000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6663, N'C19', 36000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6664, N'C20', 36000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6665, N'C21', 36000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6666, N'C22', 36000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6667, N'C23', 36000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6668, N'C24', 36000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6669, N'C25', 36000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6670, N'C26', 36000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6671, N'C27', 36000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6672, N'C28', 36000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6673, N'C29', 36000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6674, N'C30', 36000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6675, N'D1', 39000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6676, N'D2', 39000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6677, N'D3', 39000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6678, N'D4', 39000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6679, N'D5', 39000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6680, N'D6', 39000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6681, N'D7', 39000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6682, N'D8', 39000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6683, N'D9', 39000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6684, N'D10', 39000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6685, N'D11', 39000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6686, N'D12', 39000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6687, N'D13', 39000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6688, N'D14', 39000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6689, N'D15', 39000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6690, N'D16', 39000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6691, N'D17', 39000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6692, N'D18', 39000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6693, N'D19', 39000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6694, N'D20', 39000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6695, N'D21', 39000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6696, N'D22', 39000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6697, N'D23', 39000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6698, N'D24', 39000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6699, N'D25', 39000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6700, N'D26', 39000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6701, N'D27', 39000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6702, N'D28', 39000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6703, N'D29', 39000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6704, N'D30', 39000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6705, N'E1', 42000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6706, N'E2', 42000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6707, N'E3', 42000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6708, N'E4', 42000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6709, N'E5', 42000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6710, N'E6', 42000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6711, N'E7', 42000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6712, N'E8', 42000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6713, N'E9', 42000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6714, N'E10', 42000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6715, N'E11', 42000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6716, N'E12', 42000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6717, N'E13', 42000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6718, N'E14', 42000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6719, N'E15', 42000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6720, N'E16', 42000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6721, N'E17', 42000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6722, N'E18', 42000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6723, N'E19', 42000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6724, N'E20', 42000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6725, N'E21', 42000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6726, N'E22', 42000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6727, N'E23', 42000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6728, N'E24', 42000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6729, N'E25', 42000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6730, N'E26', 42000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6731, N'E27', 42000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6732, N'E28', 42000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6733, N'E29', 42000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6734, N'E30', 42000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6735, N'F1', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6736, N'F2', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6737, N'F3', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6738, N'F4', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6739, N'F5', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6740, N'F6', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6741, N'F7', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6742, N'F8', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6743, N'F9', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6744, N'F10', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6745, N'F11', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6746, N'F12', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6747, N'F13', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6748, N'F14', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6749, N'F15', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6750, N'F16', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6751, N'F17', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6752, N'F18', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6753, N'F19', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6754, N'F20', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6755, N'F21', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6756, N'F22', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6757, N'F23', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6758, N'F24', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6759, N'F25', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6760, N'F26', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6761, N'F27', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6762, N'F28', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6763, N'F29', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6764, N'F30', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6765, N'G1', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6766, N'G2', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6767, N'G3', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6768, N'G4', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6769, N'G5', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6770, N'G6', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6771, N'G7', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6772, N'G8', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6773, N'G9', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6774, N'G10', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6775, N'G11', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6776, N'G12', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6777, N'G13', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6778, N'G14', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6779, N'G15', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6780, N'G16', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6781, N'G17', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6782, N'G18', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6783, N'G19', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6784, N'G20', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6785, N'G21', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6786, N'G22', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6787, N'G23', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6788, N'G24', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6789, N'G25', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6790, N'G26', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6791, N'G27', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6792, N'G28', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6793, N'G29', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6794, N'G30', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6795, N'H1', 51000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6796, N'H2', 51000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6797, N'H3', 51000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6798, N'H4', 51000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6799, N'H5', 51000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6800, N'H6', 51000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6801, N'H7', 51000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6802, N'H8', 51000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6803, N'H9', 51000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6804, N'H10', 51000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6805, N'H11', 51000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6806, N'H12', 51000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6807, N'H13', 51000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6808, N'H14', 51000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6809, N'H15', 51000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6810, N'H16', 51000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6811, N'H17', 51000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6812, N'H18', 51000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6813, N'H19', 51000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6814, N'H20', 51000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6815, N'H21', 51000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6816, N'H22', 51000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6817, N'H23', 51000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6818, N'H24', 51000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6819, N'H25', 51000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6820, N'H26', 51000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6821, N'H27', 51000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6822, N'H28', 51000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6823, N'H29', 51000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6824, N'H30', 51000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6825, N'I1', 54000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6826, N'I2', 54000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6827, N'I3', 54000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6828, N'I4', 54000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6829, N'I5', 54000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6830, N'I6', 54000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6831, N'I7', 54000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6832, N'I8', 54000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6833, N'I9', 54000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6834, N'I10', 54000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6835, N'I11', 54000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6836, N'I12', 54000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6837, N'I13', 54000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6838, N'I14', 54000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6839, N'I15', 54000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6840, N'I16', 54000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6841, N'I17', 54000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6842, N'I18', 54000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6843, N'I19', 54000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6844, N'I20', 54000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6845, N'I21', 54000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6846, N'I22', 54000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6847, N'I23', 54000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6848, N'I24', 54000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6849, N'I25', 54000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6850, N'I26', 54000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6851, N'I27', 54000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6852, N'I28', 54000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6853, N'I29', 54000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6854, N'I30', 54000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6855, N'J1', 57000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6856, N'J2', 57000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6857, N'J3', 57000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6858, N'J4', 57000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6859, N'J5', 57000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6860, N'J6', 57000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6861, N'J7', 57000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6862, N'J8', 57000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6863, N'J9', 57000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6864, N'J10', 57000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6865, N'J11', 57000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6866, N'J12', 57000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6867, N'J13', 57000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6868, N'J14', 57000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6869, N'J15', 57000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6870, N'J16', 57000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6871, N'J17', 57000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6872, N'J18', 57000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6873, N'J19', 57000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6874, N'J20', 57000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6875, N'J21', 57000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6876, N'J22', 57000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6877, N'J23', 57000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6878, N'J24', 57000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6879, N'J25', 57000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6880, N'J26', 57000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6881, N'J27', 57000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6882, N'J28', 57000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6883, N'J29', 57000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6884, N'J30', 57000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6885, N'K1', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6886, N'K2', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6887, N'K3', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6888, N'K4', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6889, N'K5', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6890, N'K6', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6891, N'K7', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6892, N'K8', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6893, N'K9', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6894, N'K10', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6895, N'K11', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6896, N'K12', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6897, N'K13', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6898, N'K14', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6899, N'K15', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6900, N'K16', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6901, N'K17', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6902, N'K18', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6903, N'K19', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6904, N'K20', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6905, N'K21', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6906, N'K22', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6907, N'K23', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6908, N'K24', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6909, N'K25', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6910, N'K26', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6911, N'K27', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6912, N'K28', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6913, N'K29', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6914, N'K30', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6915, N'L1', 63000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6916, N'L2', 63000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6917, N'L3', 63000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6918, N'L4', 63000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6919, N'L5', 63000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6920, N'L6', 63000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6921, N'L7', 63000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6922, N'L8', 63000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6923, N'L9', 63000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6924, N'L10', 63000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6925, N'L11', 63000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6926, N'L12', 63000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6927, N'L13', 63000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6928, N'L14', 63000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6929, N'L15', 63000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6930, N'L16', 63000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6931, N'L17', 63000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6932, N'L18', 63000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6933, N'L19', 63000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6934, N'L20', 63000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6935, N'L21', 63000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6936, N'L22', 63000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6937, N'L23', 63000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6938, N'L24', 63000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6939, N'L25', 63000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6940, N'L26', 63000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6941, N'L27', 63000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6942, N'L28', 63000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6943, N'L29', 63000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6944, N'L30', 63000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6945, N'M1', 66000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6946, N'M2', 66000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6947, N'M3', 66000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6948, N'M4', 66000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6949, N'M5', 66000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6950, N'M6', 66000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6951, N'M7', 66000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6952, N'M8', 66000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6953, N'M9', 66000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6954, N'M10', 66000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6955, N'M11', 66000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6956, N'M12', 66000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6957, N'M13', 66000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6958, N'M14', 66000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6959, N'M15', 66000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6960, N'M16', 66000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6961, N'M17', 66000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6962, N'M18', 66000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6963, N'M19', 66000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6964, N'M20', 66000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6965, N'M21', 66000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6966, N'M22', 66000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6967, N'M23', 66000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6968, N'M24', 66000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6969, N'M25', 66000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6970, N'M26', 66000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6971, N'M27', 66000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6972, N'M28', 66000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6973, N'M29', 66000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6974, N'M30', 66000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6975, N'N1', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6976, N'N2', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6977, N'N3', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6978, N'N4', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6979, N'N5', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6980, N'N6', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6981, N'N7', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6982, N'N8', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6983, N'N9', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6984, N'N10', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6985, N'N11', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6986, N'N12', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6987, N'N13', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6988, N'N14', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6989, N'N15', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6990, N'N16', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6991, N'N17', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6992, N'N18', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6993, N'N19', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6994, N'N20', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6995, N'N21', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6996, N'N22', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6997, N'N23', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6998, N'N24', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 6999, N'N25', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7000, N'N26', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7001, N'N27', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7002, N'N28', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7003, N'N29', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7004, N'N30', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7005, N'O1', 72000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7006, N'O2', 72000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7007, N'O3', 72000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7008, N'O4', 72000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7009, N'O5', 72000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7010, N'O6', 72000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7011, N'O7', 72000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7012, N'O8', 72000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7013, N'O9', 72000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7014, N'O10', 72000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7015, N'O11', 72000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7016, N'O12', 72000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7017, N'O13', 72000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7018, N'O14', 72000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7019, N'O15', 72000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7020, N'O16', 72000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7021, N'O17', 72000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7022, N'O18', 72000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7023, N'O19', 72000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7024, N'O20', 72000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7025, N'O21', 72000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7026, N'O22', 72000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7027, N'O23', 72000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7028, N'O24', 72000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7029, N'O25', 72000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7030, N'O26', 72000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7031, N'O27', 72000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7032, N'O28', 72000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7033, N'O29', 72000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7034, N'O30', 72000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7035, N'P1', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7036, N'P2', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7037, N'P3', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7038, N'P4', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7039, N'P5', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7040, N'P6', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7041, N'P7', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7042, N'P8', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7043, N'P9', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7044, N'P10', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7045, N'P11', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7046, N'P12', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7047, N'P13', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7048, N'P14', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7049, N'P15', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7050, N'P16', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7051, N'P17', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7052, N'P18', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7053, N'P19', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7054, N'P20', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7055, N'P21', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7056, N'P22', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7057, N'P23', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7058, N'P24', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7059, N'P25', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7060, N'P26', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7061, N'P27', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7062, N'P28', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7063, N'P29', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7064, N'P30', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7065, N'Q1', 78000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7066, N'Q2', 78000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7067, N'Q3', 78000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7068, N'Q4', 78000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7069, N'Q5', 78000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7070, N'Q6', 78000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7071, N'Q7', 78000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7072, N'Q8', 78000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7073, N'Q9', 78000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7074, N'Q10', 78000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7075, N'Q11', 78000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7076, N'Q12', 78000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7077, N'Q13', 78000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7078, N'Q14', 78000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7079, N'Q15', 78000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7080, N'Q16', 78000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7081, N'Q17', 78000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7082, N'Q18', 78000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7083, N'Q19', 78000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7084, N'Q20', 78000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7085, N'Q21', 78000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7086, N'Q22', 78000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7087, N'Q23', 78000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7088, N'Q24', 78000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7089, N'Q25', 78000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7090, N'Q26', 78000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7091, N'Q27', 78000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7092, N'Q28', 78000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7093, N'Q29', 78000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7094, N'Q30', 78000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7095, N'R1', 81000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7096, N'R2', 81000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7097, N'R3', 81000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7098, N'R4', 81000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7099, N'R5', 81000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7100, N'R6', 81000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7101, N'R7', 81000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7102, N'R8', 81000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7103, N'R9', 81000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7104, N'R10', 81000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7105, N'R11', 81000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7106, N'R12', 81000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7107, N'R13', 81000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7108, N'R14', 81000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7109, N'R15', 81000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7110, N'R16', 81000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7111, N'R17', 81000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7112, N'R18', 81000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7113, N'R19', 81000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7114, N'R20', 81000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7115, N'R21', 81000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7116, N'R22', 81000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7117, N'R23', 81000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7118, N'R24', 81000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7119, N'R25', 81000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7120, N'R26', 81000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7121, N'R27', 81000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7122, N'R28', 81000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7123, N'R29', 81000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7124, N'R30', 81000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7125, N'S1', 84000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7126, N'S2', 84000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7127, N'S3', 84000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7128, N'S4', 84000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7129, N'S5', 84000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7130, N'S6', 84000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7131, N'S7', 84000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7132, N'S8', 84000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7133, N'S9', 84000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7134, N'S10', 84000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7135, N'S11', 84000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7136, N'S12', 84000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7137, N'S13', 84000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7138, N'S14', 84000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7139, N'S15', 84000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7140, N'S16', 84000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7141, N'S17', 84000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7142, N'S18', 84000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7143, N'S19', 84000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7144, N'S20', 84000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7145, N'S21', 84000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7146, N'S22', 84000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7147, N'S23', 84000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7148, N'S24', 84000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7149, N'S25', 84000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7150, N'S26', 84000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7151, N'S27', 84000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7152, N'S28', 84000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7153, N'S29', 84000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7154, N'S30', 84000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7155, N'T1', 87000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7156, N'T2', 87000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7157, N'T3', 87000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7158, N'T4', 87000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7159, N'T5', 87000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7160, N'T6', 87000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7161, N'T7', 87000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7162, N'T8', 87000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7163, N'T9', 87000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7164, N'T10', 87000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7165, N'T11', 87000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7166, N'T12', 87000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7167, N'T13', 87000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7168, N'T14', 87000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7169, N'T15', 87000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7170, N'T16', 87000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7171, N'T17', 87000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7172, N'T18', 87000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7173, N'T19', 87000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7174, N'T20', 87000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7175, N'T21', 87000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7176, N'T22', 87000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7177, N'T23', 87000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7178, N'T24', 87000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7179, N'T25', 87000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7180, N'T26', 87000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7181, N'T27', 87000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7182, N'T28', 87000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7183, N'T29', 87000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7184, N'T30', 87000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7185, N'U1', 90000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7186, N'U2', 90000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7187, N'U3', 90000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7188, N'U4', 90000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7189, N'U5', 90000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7190, N'U6', 90000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7191, N'U7', 90000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7192, N'U8', 90000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7193, N'U9', 90000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7194, N'U10', 90000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7195, N'U11', 90000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7196, N'U12', 90000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7197, N'U13', 90000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7198, N'U14', 90000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7199, N'U15', 90000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7200, N'U16', 90000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7201, N'U17', 90000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7202, N'U18', 90000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7203, N'U19', 90000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7204, N'U20', 90000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7205, N'U21', 90000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7206, N'U22', 90000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7207, N'U23', 90000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7208, N'U24', 90000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7209, N'U25', 90000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7210, N'U26', 90000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7211, N'U27', 90000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7212, N'U28', 90000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7213, N'U29', 90000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7214, N'U30', 90000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7215, N'V1', 93000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7216, N'V2', 93000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7217, N'V3', 93000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7218, N'V4', 93000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7219, N'V5', 93000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7220, N'V6', 93000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7221, N'V7', 93000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7222, N'V8', 93000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7223, N'V9', 93000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7224, N'V10', 93000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7225, N'V11', 93000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7226, N'V12', 93000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7227, N'V13', 93000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7228, N'V14', 93000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7229, N'V15', 93000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7230, N'V16', 93000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7231, N'V17', 93000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7232, N'V18', 93000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7233, N'V19', 93000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7234, N'V20', 93000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7235, N'V21', 93000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7236, N'V22', 93000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7237, N'V23', 93000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7238, N'V24', 93000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7239, N'V25', 93000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7240, N'V26', 93000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7241, N'V27', 93000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7242, N'V28', 93000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7243, N'V29', 93000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7244, N'V30', 93000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7245, N'W1', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7246, N'W2', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7247, N'W3', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7248, N'W4', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7249, N'W5', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7250, N'W6', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7251, N'W7', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7252, N'W8', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7253, N'W9', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7254, N'W10', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7255, N'W11', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7256, N'W12', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7257, N'W13', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7258, N'W14', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7259, N'W15', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7260, N'W16', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7261, N'W17', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7262, N'W18', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7263, N'W19', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7264, N'W20', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7265, N'W21', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7266, N'W22', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7267, N'W23', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7268, N'W24', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7269, N'W25', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7270, N'W26', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7271, N'W27', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7272, N'W28', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7273, N'W29', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7274, N'W30', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7275, N'X1', 99000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7276, N'X2', 99000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7277, N'X3', 99000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7278, N'X4', 99000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7279, N'X5', 99000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7280, N'X6', 99000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7281, N'X7', 99000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7282, N'X8', 99000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7283, N'X9', 99000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7284, N'X10', 99000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7285, N'X11', 99000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7286, N'X12', 99000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7287, N'X13', 99000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7288, N'X14', 99000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7289, N'X15', 99000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7290, N'X16', 99000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7291, N'X17', 99000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7292, N'X18', 99000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7293, N'X19', 99000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7294, N'X20', 99000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7295, N'X21', 99000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7296, N'X22', 99000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7297, N'X23', 99000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7298, N'X24', 99000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7299, N'X25', 99000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7300, N'X26', 99000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7301, N'X27', 99000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7302, N'X28', 99000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7303, N'X29', 99000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 2, 7304, N'X30', 99000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7305, N'A1', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7306, N'A2', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7307, N'A3', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7308, N'A4', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7309, N'A5', 30000.0000, 1, N'danghoan')
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7310, N'A6', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7311, N'A7', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7312, N'A8', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7313, N'A9', 30000.0000, 1, N'danghoan')
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7314, N'A10', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7315, N'A11', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7316, N'A12', 30000.0000, 1, N'danghoan')
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7317, N'A13', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7318, N'A14', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7319, N'A15', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7320, N'A16', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7321, N'A17', 30000.0000, 1, N'danghoan')
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7322, N'A18', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7323, N'A19', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7324, N'A20', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7325, N'A21', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7326, N'A22', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7327, N'A23', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7328, N'A24', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7329, N'A25', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7330, N'A26', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7331, N'A27', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7332, N'A28', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7333, N'A29', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7334, N'A30', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7335, N'B1', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7336, N'B2', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7337, N'B3', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7338, N'B4', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7339, N'B5', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7340, N'B6', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7341, N'B7', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7342, N'B8', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7343, N'B9', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7344, N'B10', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7345, N'B11', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7346, N'B12', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7347, N'B13', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7348, N'B14', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7349, N'B15', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7350, N'B16', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7351, N'B17', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7352, N'B18', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7353, N'B19', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7354, N'B20', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7355, N'B21', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7356, N'B22', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7357, N'B23', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7358, N'B24', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7359, N'B25', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7360, N'B26', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7361, N'B27', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7362, N'B28', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7363, N'B29', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7364, N'B30', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7365, N'C1', 36000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7366, N'C2', 36000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7367, N'C3', 36000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7368, N'C4', 36000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7369, N'C5', 36000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7370, N'C6', 36000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7371, N'C7', 36000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7372, N'C8', 36000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7373, N'C9', 36000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7374, N'C10', 36000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7375, N'C11', 36000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7376, N'C12', 36000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7377, N'C13', 36000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7378, N'C14', 36000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7379, N'C15', 36000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7380, N'C16', 36000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7381, N'C17', 36000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7382, N'C18', 36000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7383, N'C19', 36000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7384, N'C20', 36000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7385, N'C21', 36000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7386, N'C22', 36000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7387, N'C23', 36000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7388, N'C24', 36000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7389, N'C25', 36000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7390, N'C26', 36000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7391, N'C27', 36000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7392, N'C28', 36000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7393, N'C29', 36000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7394, N'C30', 36000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7395, N'D1', 39000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7396, N'D2', 39000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7397, N'D3', 39000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7398, N'D4', 39000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7399, N'D5', 39000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7400, N'D6', 39000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7401, N'D7', 39000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7402, N'D8', 39000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7403, N'D9', 39000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7404, N'D10', 39000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7405, N'D11', 39000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7406, N'D12', 39000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7407, N'D13', 39000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7408, N'D14', 39000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7409, N'D15', 39000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7410, N'D16', 39000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7411, N'D17', 39000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7412, N'D18', 39000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7413, N'D19', 39000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7414, N'D20', 39000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7415, N'D21', 39000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7416, N'D22', 39000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7417, N'D23', 39000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7418, N'D24', 39000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7419, N'D25', 39000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7420, N'D26', 39000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7421, N'D27', 39000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7422, N'D28', 39000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7423, N'D29', 39000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7424, N'D30', 39000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7425, N'E1', 42000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7426, N'E2', 42000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7427, N'E3', 42000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7428, N'E4', 42000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7429, N'E5', 42000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7430, N'E6', 42000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7431, N'E7', 42000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7432, N'E8', 42000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7433, N'E9', 42000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7434, N'E10', 42000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7435, N'E11', 42000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7436, N'E12', 42000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7437, N'E13', 42000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7438, N'E14', 42000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7439, N'E15', 42000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7440, N'E16', 42000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7441, N'E17', 42000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7442, N'E18', 42000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7443, N'E19', 42000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7444, N'E20', 42000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7445, N'E21', 42000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7446, N'E22', 42000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7447, N'E23', 42000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7448, N'E24', 42000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7449, N'E25', 42000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7450, N'E26', 42000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7451, N'E27', 42000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7452, N'E28', 42000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7453, N'E29', 42000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7454, N'E30', 42000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7455, N'F1', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7456, N'F2', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7457, N'F3', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7458, N'F4', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7459, N'F5', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7460, N'F6', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7461, N'F7', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7462, N'F8', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7463, N'F9', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7464, N'F10', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7465, N'F11', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7466, N'F12', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7467, N'F13', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7468, N'F14', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7469, N'F15', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7470, N'F16', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7471, N'F17', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7472, N'F18', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7473, N'F19', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7474, N'F20', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7475, N'F21', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7476, N'F22', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7477, N'F23', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7478, N'F24', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7479, N'F25', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7480, N'F26', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7481, N'F27', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7482, N'F28', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7483, N'F29', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7484, N'F30', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7485, N'G1', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7486, N'G2', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7487, N'G3', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7488, N'G4', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7489, N'G5', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7490, N'G6', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7491, N'G7', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7492, N'G8', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7493, N'G9', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7494, N'G10', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7495, N'G11', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7496, N'G12', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7497, N'G13', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7498, N'G14', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7499, N'G15', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7500, N'G16', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7501, N'G17', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7502, N'G18', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7503, N'G19', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7504, N'G20', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7505, N'G21', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7506, N'G22', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7507, N'G23', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7508, N'G24', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7509, N'G25', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7510, N'G26', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7511, N'G27', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7512, N'G28', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7513, N'G29', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7514, N'G30', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7515, N'H1', 51000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7516, N'H2', 51000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7517, N'H3', 51000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7518, N'H4', 51000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7519, N'H5', 51000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7520, N'H6', 51000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7521, N'H7', 51000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7522, N'H8', 51000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7523, N'H9', 51000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7524, N'H10', 51000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7525, N'H11', 51000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7526, N'H12', 51000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7527, N'H13', 51000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7528, N'H14', 51000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7529, N'H15', 51000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7530, N'H16', 51000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7531, N'H17', 51000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7532, N'H18', 51000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7533, N'H19', 51000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7534, N'H20', 51000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7535, N'H21', 51000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7536, N'H22', 51000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7537, N'H23', 51000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7538, N'H24', 51000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7539, N'H25', 51000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7540, N'H26', 51000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7541, N'H27', 51000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7542, N'H28', 51000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7543, N'H29', 51000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7544, N'H30', 51000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7545, N'I1', 54000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7546, N'I2', 54000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7547, N'I3', 54000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7548, N'I4', 54000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7549, N'I5', 54000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7550, N'I6', 54000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7551, N'I7', 54000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7552, N'I8', 54000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7553, N'I9', 54000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7554, N'I10', 54000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7555, N'I11', 54000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7556, N'I12', 54000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7557, N'I13', 54000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7558, N'I14', 54000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7559, N'I15', 54000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7560, N'I16', 54000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7561, N'I17', 54000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7562, N'I18', 54000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7563, N'I19', 54000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7564, N'I20', 54000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7565, N'I21', 54000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7566, N'I22', 54000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7567, N'I23', 54000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7568, N'I24', 54000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7569, N'I25', 54000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7570, N'I26', 54000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7571, N'I27', 54000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7572, N'I28', 54000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7573, N'I29', 54000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7574, N'I30', 54000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7575, N'J1', 57000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7576, N'J2', 57000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7577, N'J3', 57000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7578, N'J4', 57000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7579, N'J5', 57000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7580, N'J6', 57000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7581, N'J7', 57000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7582, N'J8', 57000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7583, N'J9', 57000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7584, N'J10', 57000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7585, N'J11', 57000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7586, N'J12', 57000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7587, N'J13', 57000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7588, N'J14', 57000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7589, N'J15', 57000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7590, N'J16', 57000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7591, N'J17', 57000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7592, N'J18', 57000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7593, N'J19', 57000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7594, N'J20', 57000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7595, N'J21', 57000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7596, N'J22', 57000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7597, N'J23', 57000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7598, N'J24', 57000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7599, N'J25', 57000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7600, N'J26', 57000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7601, N'J27', 57000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7602, N'J28', 57000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7603, N'J29', 57000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7604, N'J30', 57000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7605, N'K1', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7606, N'K2', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7607, N'K3', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7608, N'K4', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7609, N'K5', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7610, N'K6', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7611, N'K7', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7612, N'K8', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7613, N'K9', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7614, N'K10', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7615, N'K11', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7616, N'K12', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7617, N'K13', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7618, N'K14', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7619, N'K15', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7620, N'K16', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7621, N'K17', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7622, N'K18', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7623, N'K19', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7624, N'K20', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7625, N'K21', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7626, N'K22', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7627, N'K23', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7628, N'K24', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7629, N'K25', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7630, N'K26', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7631, N'K27', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7632, N'K28', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7633, N'K29', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7634, N'K30', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7635, N'L1', 63000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7636, N'L2', 63000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7637, N'L3', 63000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7638, N'L4', 63000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7639, N'L5', 63000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7640, N'L6', 63000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7641, N'L7', 63000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7642, N'L8', 63000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7643, N'L9', 63000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7644, N'L10', 63000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7645, N'L11', 63000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7646, N'L12', 63000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7647, N'L13', 63000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7648, N'L14', 63000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7649, N'L15', 63000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7650, N'L16', 63000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7651, N'L17', 63000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7652, N'L18', 63000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7653, N'L19', 63000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7654, N'L20', 63000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7655, N'L21', 63000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7656, N'L22', 63000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7657, N'L23', 63000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7658, N'L24', 63000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7659, N'L25', 63000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7660, N'L26', 63000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7661, N'L27', 63000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7662, N'L28', 63000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7663, N'L29', 63000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7664, N'L30', 63000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7665, N'M1', 66000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7666, N'M2', 66000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7667, N'M3', 66000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7668, N'M4', 66000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7669, N'M5', 66000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7670, N'M6', 66000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7671, N'M7', 66000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7672, N'M8', 66000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7673, N'M9', 66000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7674, N'M10', 66000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7675, N'M11', 66000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7676, N'M12', 66000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7677, N'M13', 66000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7678, N'M14', 66000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7679, N'M15', 66000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7680, N'M16', 66000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7681, N'M17', 66000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7682, N'M18', 66000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7683, N'M19', 66000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7684, N'M20', 66000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7685, N'M21', 66000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7686, N'M22', 66000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7687, N'M23', 66000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7688, N'M24', 66000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7689, N'M25', 66000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7690, N'M26', 66000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7691, N'M27', 66000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7692, N'M28', 66000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7693, N'M29', 66000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7694, N'M30', 66000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7695, N'N1', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7696, N'N2', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7697, N'N3', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7698, N'N4', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7699, N'N5', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7700, N'N6', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7701, N'N7', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7702, N'N8', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7703, N'N9', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7704, N'N10', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7705, N'N11', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7706, N'N12', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7707, N'N13', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7708, N'N14', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7709, N'N15', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7710, N'N16', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7711, N'N17', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7712, N'N18', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7713, N'N19', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7714, N'N20', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7715, N'N21', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7716, N'N22', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7717, N'N23', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7718, N'N24', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7719, N'N25', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7720, N'N26', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7721, N'N27', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7722, N'N28', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7723, N'N29', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7724, N'N30', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7725, N'O1', 72000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7726, N'O2', 72000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7727, N'O3', 72000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7728, N'O4', 72000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7729, N'O5', 72000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7730, N'O6', 72000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7731, N'O7', 72000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7732, N'O8', 72000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7733, N'O9', 72000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7734, N'O10', 72000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7735, N'O11', 72000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7736, N'O12', 72000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7737, N'O13', 72000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7738, N'O14', 72000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7739, N'O15', 72000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7740, N'O16', 72000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7741, N'O17', 72000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7742, N'O18', 72000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7743, N'O19', 72000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7744, N'O20', 72000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7745, N'O21', 72000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7746, N'O22', 72000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7747, N'O23', 72000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7748, N'O24', 72000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7749, N'O25', 72000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7750, N'O26', 72000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7751, N'O27', 72000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7752, N'O28', 72000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7753, N'O29', 72000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7754, N'O30', 72000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7755, N'P1', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7756, N'P2', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7757, N'P3', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7758, N'P4', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7759, N'P5', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7760, N'P6', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7761, N'P7', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7762, N'P8', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7763, N'P9', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7764, N'P10', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7765, N'P11', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7766, N'P12', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7767, N'P13', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7768, N'P14', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7769, N'P15', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7770, N'P16', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7771, N'P17', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7772, N'P18', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7773, N'P19', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7774, N'P20', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7775, N'P21', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7776, N'P22', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7777, N'P23', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7778, N'P24', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7779, N'P25', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7780, N'P26', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7781, N'P27', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7782, N'P28', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7783, N'P29', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7784, N'P30', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7785, N'Q1', 78000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7786, N'Q2', 78000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7787, N'Q3', 78000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7788, N'Q4', 78000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7789, N'Q5', 78000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7790, N'Q6', 78000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7791, N'Q7', 78000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7792, N'Q8', 78000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7793, N'Q9', 78000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7794, N'Q10', 78000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7795, N'Q11', 78000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7796, N'Q12', 78000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7797, N'Q13', 78000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7798, N'Q14', 78000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7799, N'Q15', 78000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7800, N'Q16', 78000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7801, N'Q17', 78000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7802, N'Q18', 78000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7803, N'Q19', 78000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7804, N'Q20', 78000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7805, N'Q21', 78000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7806, N'Q22', 78000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7807, N'Q23', 78000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7808, N'Q24', 78000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7809, N'Q25', 78000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7810, N'Q26', 78000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7811, N'Q27', 78000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7812, N'Q28', 78000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7813, N'Q29', 78000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7814, N'Q30', 78000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7815, N'R1', 81000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7816, N'R2', 81000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7817, N'R3', 81000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7818, N'R4', 81000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7819, N'R5', 81000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7820, N'R6', 81000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7821, N'R7', 81000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7822, N'R8', 81000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7823, N'R9', 81000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7824, N'R10', 81000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7825, N'R11', 81000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7826, N'R12', 81000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7827, N'R13', 81000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7828, N'R14', 81000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7829, N'R15', 81000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7830, N'R16', 81000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7831, N'R17', 81000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7832, N'R18', 81000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7833, N'R19', 81000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7834, N'R20', 81000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7835, N'R21', 81000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7836, N'R22', 81000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7837, N'R23', 81000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7838, N'R24', 81000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7839, N'R25', 81000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7840, N'R26', 81000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7841, N'R27', 81000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7842, N'R28', 81000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7843, N'R29', 81000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7844, N'R30', 81000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7845, N'S1', 84000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7846, N'S2', 84000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7847, N'S3', 84000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7848, N'S4', 84000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7849, N'S5', 84000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7850, N'S6', 84000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7851, N'S7', 84000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7852, N'S8', 84000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7853, N'S9', 84000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7854, N'S10', 84000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7855, N'S11', 84000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7856, N'S12', 84000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7857, N'S13', 84000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7858, N'S14', 84000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7859, N'S15', 84000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7860, N'S16', 84000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7861, N'S17', 84000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7862, N'S18', 84000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7863, N'S19', 84000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7864, N'S20', 84000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7865, N'S21', 84000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7866, N'S22', 84000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7867, N'S23', 84000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7868, N'S24', 84000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7869, N'S25', 84000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7870, N'S26', 84000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7871, N'S27', 84000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7872, N'S28', 84000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7873, N'S29', 84000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7874, N'S30', 84000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7875, N'T1', 87000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7876, N'T2', 87000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7877, N'T3', 87000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7878, N'T4', 87000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7879, N'T5', 87000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7880, N'T6', 87000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7881, N'T7', 87000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7882, N'T8', 87000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7883, N'T9', 87000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7884, N'T10', 87000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7885, N'T11', 87000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7886, N'T12', 87000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7887, N'T13', 87000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7888, N'T14', 87000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7889, N'T15', 87000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7890, N'T16', 87000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7891, N'T17', 87000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7892, N'T18', 87000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7893, N'T19', 87000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7894, N'T20', 87000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7895, N'T21', 87000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7896, N'T22', 87000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7897, N'T23', 87000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7898, N'T24', 87000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7899, N'T25', 87000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7900, N'T26', 87000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7901, N'T27', 87000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7902, N'T28', 87000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7903, N'T29', 87000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7904, N'T30', 87000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7905, N'U1', 90000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7906, N'U2', 90000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7907, N'U3', 90000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7908, N'U4', 90000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7909, N'U5', 90000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7910, N'U6', 90000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7911, N'U7', 90000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7912, N'U8', 90000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7913, N'U9', 90000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7914, N'U10', 90000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7915, N'U11', 90000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7916, N'U12', 90000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7917, N'U13', 90000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7918, N'U14', 90000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7919, N'U15', 90000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7920, N'U16', 90000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7921, N'U17', 90000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7922, N'U18', 90000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7923, N'U19', 90000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7924, N'U20', 90000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7925, N'U21', 90000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7926, N'U22', 90000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7927, N'U23', 90000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7928, N'U24', 90000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7929, N'U25', 90000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7930, N'U26', 90000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7931, N'U27', 90000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7932, N'U28', 90000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7933, N'U29', 90000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7934, N'U30', 90000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7935, N'V1', 93000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7936, N'V2', 93000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7937, N'V3', 93000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7938, N'V4', 93000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7939, N'V5', 93000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7940, N'V6', 93000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7941, N'V7', 93000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7942, N'V8', 93000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7943, N'V9', 93000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7944, N'V10', 93000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7945, N'V11', 93000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7946, N'V12', 93000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7947, N'V13', 93000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7948, N'V14', 93000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7949, N'V15', 93000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7950, N'V16', 93000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7951, N'V17', 93000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7952, N'V18', 93000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7953, N'V19', 93000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7954, N'V20', 93000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7955, N'V21', 93000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7956, N'V22', 93000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7957, N'V23', 93000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7958, N'V24', 93000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7959, N'V25', 93000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7960, N'V26', 93000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7961, N'V27', 93000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7962, N'V28', 93000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7963, N'V29', 93000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7964, N'V30', 93000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7965, N'W1', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7966, N'W2', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7967, N'W3', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7968, N'W4', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7969, N'W5', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7970, N'W6', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7971, N'W7', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7972, N'W8', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7973, N'W9', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7974, N'W10', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7975, N'W11', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7976, N'W12', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7977, N'W13', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7978, N'W14', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7979, N'W15', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7980, N'W16', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7981, N'W17', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7982, N'W18', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7983, N'W19', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7984, N'W20', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7985, N'W21', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7986, N'W22', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7987, N'W23', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7988, N'W24', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7989, N'W25', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7990, N'W26', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7991, N'W27', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7992, N'W28', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7993, N'W29', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7994, N'W30', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7995, N'X1', 99000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7996, N'X2', 99000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7997, N'X3', 99000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7998, N'X4', 99000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 7999, N'X5', 99000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 8000, N'X6', 99000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 8001, N'X7', 99000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 8002, N'X8', 99000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 8003, N'X9', 99000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 8004, N'X10', 99000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 8005, N'X11', 99000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 8006, N'X12', 99000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 8007, N'X13', 99000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 8008, N'X14', 99000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 8009, N'X15', 99000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 8010, N'X16', 99000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 8011, N'X17', 99000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 8012, N'X18', 99000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 8013, N'X19', 99000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 8014, N'X20', 99000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 8015, N'X21', 99000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 8016, N'X22', 99000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 8017, N'X23', 99000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 8018, N'X24', 99000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 8019, N'X25', 99000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 8020, N'X26', 99000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 8021, N'X27', 99000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 8022, N'X28', 99000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 8023, N'X29', 99000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 8024, N'X30', 99000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 8025, N'Y1', 102000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 8026, N'Y2', 102000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 8027, N'Y3', 102000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 8028, N'Y4', 102000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 8029, N'Y5', 102000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 8030, N'Y6', 102000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 8031, N'Y7', 102000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 8032, N'Y8', 102000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 8033, N'Y9', 102000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 8034, N'Y10', 102000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 8035, N'Y11', 102000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 8036, N'Y12', 102000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 8037, N'Y13', 102000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 8038, N'Y14', 102000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 8039, N'Y15', 102000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 8040, N'Y16', 102000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 8041, N'Y17', 102000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 8042, N'Y18', 102000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 8043, N'Y19', 102000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 8044, N'Y20', 102000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 8045, N'Y21', 102000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 8046, N'Y22', 102000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 8047, N'Y23', 102000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 8048, N'Y24', 102000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 8049, N'Y25', 102000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 8050, N'Y26', 102000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 8051, N'Y27', 102000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 8052, N'Y28', 102000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 8053, N'Y29', 102000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (27, 1, 8054, N'Y30', 102000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8055, N'A1', 32000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8056, N'A2', 32000.0000, 1, N'danghoan')
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8057, N'A3', 32000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8058, N'A4', 32000.0000, 1, N'danghoan')
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8059, N'A5', 32000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8060, N'A6', 32000.0000, 1, N'danghoan')
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8061, N'A7', 32000.0000, 1, N'danghoan')
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8062, N'A8', 32000.0000, 1, N'danghoan')
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8063, N'A9', 32000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8064, N'A10', 32000.0000, 1, N'danghoan')
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8065, N'A11', 32000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8066, N'A12', 32000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8067, N'A13', 32000.0000, 1, N'danghoan')
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8068, N'A14', 32000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8069, N'A15', 32000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8070, N'A16', 32000.0000, 1, N'danghoan')
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8071, N'A17', 32000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8072, N'A18', 32000.0000, 1, N'danghoan')
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8073, N'A19', 32000.0000, 1, N'danghoan')
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8074, N'A20', 32000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8075, N'A21', 32000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8076, N'A22', 32000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8077, N'A23', 32000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8078, N'A24', 32000.0000, 1, N'danghoan')
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8079, N'A25', 32000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8080, N'A26', 32000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8081, N'A27', 32000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8082, N'A28', 32000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8083, N'A29', 32000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8084, N'A30', 32000.0000, 1, N'danghoan')
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8085, N'B1', 35200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8086, N'B2', 35200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8087, N'B3', 35200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8088, N'B4', 35200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8089, N'B5', 35200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8090, N'B6', 35200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8091, N'B7', 35200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8092, N'B8', 35200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8093, N'B9', 35200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8094, N'B10', 35200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8095, N'B11', 35200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8096, N'B12', 35200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8097, N'B13', 35200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8098, N'B14', 35200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8099, N'B15', 35200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8100, N'B16', 35200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8101, N'B17', 35200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8102, N'B18', 35200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8103, N'B19', 35200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8104, N'B20', 35200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8105, N'B21', 35200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8106, N'B22', 35200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8107, N'B23', 35200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8108, N'B24', 35200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8109, N'B25', 35200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8110, N'B26', 35200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8111, N'B27', 35200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8112, N'B28', 35200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8113, N'B29', 35200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8114, N'B30', 35200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8115, N'C1', 38400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8116, N'C2', 38400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8117, N'C3', 38400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8118, N'C4', 38400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8119, N'C5', 38400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8120, N'C6', 38400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8121, N'C7', 38400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8122, N'C8', 38400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8123, N'C9', 38400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8124, N'C10', 38400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8125, N'C11', 38400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8126, N'C12', 38400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8127, N'C13', 38400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8128, N'C14', 38400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8129, N'C15', 38400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8130, N'C16', 38400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8131, N'C17', 38400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8132, N'C18', 38400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8133, N'C19', 38400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8134, N'C20', 38400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8135, N'C21', 38400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8136, N'C22', 38400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8137, N'C23', 38400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8138, N'C24', 38400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8139, N'C25', 38400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8140, N'C26', 38400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8141, N'C27', 38400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8142, N'C28', 38400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8143, N'C29', 38400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8144, N'C30', 38400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8145, N'D1', 41600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8146, N'D2', 41600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8147, N'D3', 41600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8148, N'D4', 41600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8149, N'D5', 41600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8150, N'D6', 41600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8151, N'D7', 41600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8152, N'D8', 41600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8153, N'D9', 41600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8154, N'D10', 41600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8155, N'D11', 41600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8156, N'D12', 41600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8157, N'D13', 41600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8158, N'D14', 41600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8159, N'D15', 41600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8160, N'D16', 41600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8161, N'D17', 41600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8162, N'D18', 41600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8163, N'D19', 41600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8164, N'D20', 41600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8165, N'D21', 41600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8166, N'D22', 41600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8167, N'D23', 41600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8168, N'D24', 41600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8169, N'D25', 41600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8170, N'D26', 41600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8171, N'D27', 41600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8172, N'D28', 41600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8173, N'D29', 41600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8174, N'D30', 41600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8175, N'E1', 44800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8176, N'E2', 44800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8177, N'E3', 44800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8178, N'E4', 44800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8179, N'E5', 44800.0000, 1, N'danghoan')
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8180, N'E6', 44800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8181, N'E7', 44800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8182, N'E8', 44800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8183, N'E9', 44800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8184, N'E10', 44800.0000, 1, N'danghoan')
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8185, N'E11', 44800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8186, N'E12', 44800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8187, N'E13', 44800.0000, 1, N'danghoan')
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8188, N'E14', 44800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8189, N'E15', 44800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8190, N'E16', 44800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8191, N'E17', 44800.0000, 1, N'danghoan')
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8192, N'E18', 44800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8193, N'E19', 44800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8194, N'E20', 44800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8195, N'E21', 44800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8196, N'E22', 44800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8197, N'E23', 44800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8198, N'E24', 44800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8199, N'E25', 44800.0000, 1, N'danghoan')
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8200, N'E26', 44800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8201, N'E27', 44800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8202, N'E28', 44800.0000, 1, N'danghoan')
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8203, N'E29', 44800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8204, N'E30', 44800.0000, 1, N'danghoan')
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8205, N'F1', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8206, N'F2', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8207, N'F3', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8208, N'F4', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8209, N'F5', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8210, N'F6', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8211, N'F7', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8212, N'F8', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8213, N'F9', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8214, N'F10', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8215, N'F11', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8216, N'F12', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8217, N'F13', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8218, N'F14', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8219, N'F15', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8220, N'F16', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8221, N'F17', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8222, N'F18', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8223, N'F19', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8224, N'F20', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8225, N'F21', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8226, N'F22', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8227, N'F23', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8228, N'F24', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8229, N'F25', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8230, N'F26', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8231, N'F27', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8232, N'F28', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8233, N'F29', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8234, N'F30', 48000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8235, N'G1', 51200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8236, N'G2', 51200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8237, N'G3', 51200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8238, N'G4', 51200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8239, N'G5', 51200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8240, N'G6', 51200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8241, N'G7', 51200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8242, N'G8', 51200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8243, N'G9', 51200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8244, N'G10', 51200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8245, N'G11', 51200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8246, N'G12', 51200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8247, N'G13', 51200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8248, N'G14', 51200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8249, N'G15', 51200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8250, N'G16', 51200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8251, N'G17', 51200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8252, N'G18', 51200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8253, N'G19', 51200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8254, N'G20', 51200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8255, N'G21', 51200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8256, N'G22', 51200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8257, N'G23', 51200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8258, N'G24', 51200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8259, N'G25', 51200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8260, N'G26', 51200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8261, N'G27', 51200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8262, N'G28', 51200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8263, N'G29', 51200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8264, N'G30', 51200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8265, N'H1', 54400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8266, N'H2', 54400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8267, N'H3', 54400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8268, N'H4', 54400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8269, N'H5', 54400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8270, N'H6', 54400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8271, N'H7', 54400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8272, N'H8', 54400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8273, N'H9', 54400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8274, N'H10', 54400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8275, N'H11', 54400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8276, N'H12', 54400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8277, N'H13', 54400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8278, N'H14', 54400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8279, N'H15', 54400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8280, N'H16', 54400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8281, N'H17', 54400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8282, N'H18', 54400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8283, N'H19', 54400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8284, N'H20', 54400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8285, N'H21', 54400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8286, N'H22', 54400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8287, N'H23', 54400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8288, N'H24', 54400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8289, N'H25', 54400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8290, N'H26', 54400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8291, N'H27', 54400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8292, N'H28', 54400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8293, N'H29', 54400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8294, N'H30', 54400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8295, N'I1', 57600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8296, N'I2', 57600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8297, N'I3', 57600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8298, N'I4', 57600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8299, N'I5', 57600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8300, N'I6', 57600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8301, N'I7', 57600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8302, N'I8', 57600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8303, N'I9', 57600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8304, N'I10', 57600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8305, N'I11', 57600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8306, N'I12', 57600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8307, N'I13', 57600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8308, N'I14', 57600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8309, N'I15', 57600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8310, N'I16', 57600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8311, N'I17', 57600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8312, N'I18', 57600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8313, N'I19', 57600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8314, N'I20', 57600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8315, N'I21', 57600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8316, N'I22', 57600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8317, N'I23', 57600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8318, N'I24', 57600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8319, N'I25', 57600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8320, N'I26', 57600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8321, N'I27', 57600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8322, N'I28', 57600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8323, N'I29', 57600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8324, N'I30', 57600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8325, N'J1', 60800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8326, N'J2', 60800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8327, N'J3', 60800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8328, N'J4', 60800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8329, N'J5', 60800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8330, N'J6', 60800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8331, N'J7', 60800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8332, N'J8', 60800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8333, N'J9', 60800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8334, N'J10', 60800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8335, N'J11', 60800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8336, N'J12', 60800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8337, N'J13', 60800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8338, N'J14', 60800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8339, N'J15', 60800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8340, N'J16', 60800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8341, N'J17', 60800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8342, N'J18', 60800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8343, N'J19', 60800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8344, N'J20', 60800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8345, N'J21', 60800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8346, N'J22', 60800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8347, N'J23', 60800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8348, N'J24', 60800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8349, N'J25', 60800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8350, N'J26', 60800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8351, N'J27', 60800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8352, N'J28', 60800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8353, N'J29', 60800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8354, N'J30', 60800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8355, N'K1', 64000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8356, N'K2', 64000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8357, N'K3', 64000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8358, N'K4', 64000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8359, N'K5', 64000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8360, N'K6', 64000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8361, N'K7', 64000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8362, N'K8', 64000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8363, N'K9', 64000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8364, N'K10', 64000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8365, N'K11', 64000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8366, N'K12', 64000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8367, N'K13', 64000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8368, N'K14', 64000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8369, N'K15', 64000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8370, N'K16', 64000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8371, N'K17', 64000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8372, N'K18', 64000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8373, N'K19', 64000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8374, N'K20', 64000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8375, N'K21', 64000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8376, N'K22', 64000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8377, N'K23', 64000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8378, N'K24', 64000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8379, N'K25', 64000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8380, N'K26', 64000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8381, N'K27', 64000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8382, N'K28', 64000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8383, N'K29', 64000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8384, N'K30', 64000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8385, N'L1', 67200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8386, N'L2', 67200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8387, N'L3', 67200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8388, N'L4', 67200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8389, N'L5', 67200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8390, N'L6', 67200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8391, N'L7', 67200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8392, N'L8', 67200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8393, N'L9', 67200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8394, N'L10', 67200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8395, N'L11', 67200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8396, N'L12', 67200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8397, N'L13', 67200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8398, N'L14', 67200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8399, N'L15', 67200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8400, N'L16', 67200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8401, N'L17', 67200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8402, N'L18', 67200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8403, N'L19', 67200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8404, N'L20', 67200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8405, N'L21', 67200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8406, N'L22', 67200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8407, N'L23', 67200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8408, N'L24', 67200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8409, N'L25', 67200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8410, N'L26', 67200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8411, N'L27', 67200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8412, N'L28', 67200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8413, N'L29', 67200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8414, N'L30', 67200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8415, N'M1', 70400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8416, N'M2', 70400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8417, N'M3', 70400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8418, N'M4', 70400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8419, N'M5', 70400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8420, N'M6', 70400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8421, N'M7', 70400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8422, N'M8', 70400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8423, N'M9', 70400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8424, N'M10', 70400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8425, N'M11', 70400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8426, N'M12', 70400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8427, N'M13', 70400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8428, N'M14', 70400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8429, N'M15', 70400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8430, N'M16', 70400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8431, N'M17', 70400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8432, N'M18', 70400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8433, N'M19', 70400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8434, N'M20', 70400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8435, N'M21', 70400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8436, N'M22', 70400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8437, N'M23', 70400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8438, N'M24', 70400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8439, N'M25', 70400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8440, N'M26', 70400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8441, N'M27', 70400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8442, N'M28', 70400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8443, N'M29', 70400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8444, N'M30', 70400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8445, N'N1', 73600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8446, N'N2', 73600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8447, N'N3', 73600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8448, N'N4', 73600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8449, N'N5', 73600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8450, N'N6', 73600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8451, N'N7', 73600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8452, N'N8', 73600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8453, N'N9', 73600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8454, N'N10', 73600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8455, N'N11', 73600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8456, N'N12', 73600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8457, N'N13', 73600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8458, N'N14', 73600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8459, N'N15', 73600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8460, N'N16', 73600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8461, N'N17', 73600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8462, N'N18', 73600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8463, N'N19', 73600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8464, N'N20', 73600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8465, N'N21', 73600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8466, N'N22', 73600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8467, N'N23', 73600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8468, N'N24', 73600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8469, N'N25', 73600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8470, N'N26', 73600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8471, N'N27', 73600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8472, N'N28', 73600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8473, N'N29', 73600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8474, N'N30', 73600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8475, N'O1', 76800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8476, N'O2', 76800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8477, N'O3', 76800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8478, N'O4', 76800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8479, N'O5', 76800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8480, N'O6', 76800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8481, N'O7', 76800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8482, N'O8', 76800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8483, N'O9', 76800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8484, N'O10', 76800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8485, N'O11', 76800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8486, N'O12', 76800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8487, N'O13', 76800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8488, N'O14', 76800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8489, N'O15', 76800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8490, N'O16', 76800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8491, N'O17', 76800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8492, N'O18', 76800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8493, N'O19', 76800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8494, N'O20', 76800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8495, N'O21', 76800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8496, N'O22', 76800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8497, N'O23', 76800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8498, N'O24', 76800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8499, N'O25', 76800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8500, N'O26', 76800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8501, N'O27', 76800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8502, N'O28', 76800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8503, N'O29', 76800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8504, N'O30', 76800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8505, N'P1', 80000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8506, N'P2', 80000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8507, N'P3', 80000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8508, N'P4', 80000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8509, N'P5', 80000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8510, N'P6', 80000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8511, N'P7', 80000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8512, N'P8', 80000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8513, N'P9', 80000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8514, N'P10', 80000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8515, N'P11', 80000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8516, N'P12', 80000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8517, N'P13', 80000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8518, N'P14', 80000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8519, N'P15', 80000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8520, N'P16', 80000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8521, N'P17', 80000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8522, N'P18', 80000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8523, N'P19', 80000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8524, N'P20', 80000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8525, N'P21', 80000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8526, N'P22', 80000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8527, N'P23', 80000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8528, N'P24', 80000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8529, N'P25', 80000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8530, N'P26', 80000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8531, N'P27', 80000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8532, N'P28', 80000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8533, N'P29', 80000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8534, N'P30', 80000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8535, N'Q1', 83200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8536, N'Q2', 83200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8537, N'Q3', 83200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8538, N'Q4', 83200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8539, N'Q5', 83200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8540, N'Q6', 83200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8541, N'Q7', 83200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8542, N'Q8', 83200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8543, N'Q9', 83200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8544, N'Q10', 83200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8545, N'Q11', 83200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8546, N'Q12', 83200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8547, N'Q13', 83200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8548, N'Q14', 83200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8549, N'Q15', 83200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8550, N'Q16', 83200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8551, N'Q17', 83200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8552, N'Q18', 83200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8553, N'Q19', 83200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8554, N'Q20', 83200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8555, N'Q21', 83200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8556, N'Q22', 83200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8557, N'Q23', 83200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8558, N'Q24', 83200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8559, N'Q25', 83200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8560, N'Q26', 83200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8561, N'Q27', 83200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8562, N'Q28', 83200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8563, N'Q29', 83200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8564, N'Q30', 83200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8565, N'R1', 86400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8566, N'R2', 86400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8567, N'R3', 86400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8568, N'R4', 86400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8569, N'R5', 86400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8570, N'R6', 86400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8571, N'R7', 86400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8572, N'R8', 86400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8573, N'R9', 86400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8574, N'R10', 86400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8575, N'R11', 86400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8576, N'R12', 86400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8577, N'R13', 86400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8578, N'R14', 86400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8579, N'R15', 86400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8580, N'R16', 86400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8581, N'R17', 86400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8582, N'R18', 86400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8583, N'R19', 86400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8584, N'R20', 86400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8585, N'R21', 86400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8586, N'R22', 86400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8587, N'R23', 86400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8588, N'R24', 86400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8589, N'R25', 86400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8590, N'R26', 86400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8591, N'R27', 86400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8592, N'R28', 86400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8593, N'R29', 86400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8594, N'R30', 86400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8595, N'S1', 89600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8596, N'S2', 89600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8597, N'S3', 89600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8598, N'S4', 89600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8599, N'S5', 89600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8600, N'S6', 89600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8601, N'S7', 89600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8602, N'S8', 89600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8603, N'S9', 89600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8604, N'S10', 89600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8605, N'S11', 89600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8606, N'S12', 89600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8607, N'S13', 89600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8608, N'S14', 89600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8609, N'S15', 89600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8610, N'S16', 89600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8611, N'S17', 89600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8612, N'S18', 89600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8613, N'S19', 89600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8614, N'S20', 89600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8615, N'S21', 89600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8616, N'S22', 89600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8617, N'S23', 89600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8618, N'S24', 89600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8619, N'S25', 89600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8620, N'S26', 89600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8621, N'S27', 89600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8622, N'S28', 89600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8623, N'S29', 89600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8624, N'S30', 89600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8625, N'T1', 92800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8626, N'T2', 92800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8627, N'T3', 92800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8628, N'T4', 92800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8629, N'T5', 92800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8630, N'T6', 92800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8631, N'T7', 92800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8632, N'T8', 92800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8633, N'T9', 92800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8634, N'T10', 92800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8635, N'T11', 92800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8636, N'T12', 92800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8637, N'T13', 92800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8638, N'T14', 92800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8639, N'T15', 92800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8640, N'T16', 92800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8641, N'T17', 92800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8642, N'T18', 92800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8643, N'T19', 92800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8644, N'T20', 92800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8645, N'T21', 92800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8646, N'T22', 92800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8647, N'T23', 92800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8648, N'T24', 92800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8649, N'T25', 92800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8650, N'T26', 92800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8651, N'T27', 92800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8652, N'T28', 92800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8653, N'T29', 92800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8654, N'T30', 92800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8655, N'U1', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8656, N'U2', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8657, N'U3', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8658, N'U4', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8659, N'U5', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8660, N'U6', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8661, N'U7', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8662, N'U8', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8663, N'U9', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8664, N'U10', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8665, N'U11', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8666, N'U12', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8667, N'U13', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8668, N'U14', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8669, N'U15', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8670, N'U16', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8671, N'U17', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8672, N'U18', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8673, N'U19', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8674, N'U20', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8675, N'U21', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8676, N'U22', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8677, N'U23', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8678, N'U24', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8679, N'U25', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8680, N'U26', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8681, N'U27', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8682, N'U28', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8683, N'U29', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8684, N'U30', 96000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8685, N'V1', 99200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8686, N'V2', 99200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8687, N'V3', 99200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8688, N'V4', 99200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8689, N'V5', 99200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8690, N'V6', 99200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8691, N'V7', 99200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8692, N'V8', 99200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8693, N'V9', 99200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8694, N'V10', 99200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8695, N'V11', 99200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8696, N'V12', 99200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8697, N'V13', 99200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8698, N'V14', 99200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8699, N'V15', 99200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8700, N'V16', 99200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8701, N'V17', 99200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8702, N'V18', 99200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8703, N'V19', 99200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8704, N'V20', 99200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8705, N'V21', 99200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8706, N'V22', 99200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8707, N'V23', 99200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8708, N'V24', 99200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8709, N'V25', 99200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8710, N'V26', 99200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8711, N'V27', 99200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8712, N'V28', 99200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8713, N'V29', 99200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8714, N'V30', 99200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8715, N'W1', 102400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8716, N'W2', 102400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8717, N'W3', 102400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8718, N'W4', 102400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8719, N'W5', 102400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8720, N'W6', 102400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8721, N'W7', 102400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8722, N'W8', 102400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8723, N'W9', 102400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8724, N'W10', 102400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8725, N'W11', 102400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8726, N'W12', 102400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8727, N'W13', 102400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8728, N'W14', 102400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8729, N'W15', 102400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8730, N'W16', 102400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8731, N'W17', 102400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8732, N'W18', 102400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8733, N'W19', 102400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8734, N'W20', 102400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8735, N'W21', 102400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8736, N'W22', 102400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8737, N'W23', 102400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8738, N'W24', 102400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8739, N'W25', 102400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8740, N'W26', 102400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8741, N'W27', 102400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8742, N'W28', 102400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8743, N'W29', 102400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8744, N'W30', 102400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8745, N'X1', 105600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8746, N'X2', 105600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8747, N'X3', 105600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8748, N'X4', 105600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8749, N'X5', 105600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8750, N'X6', 105600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8751, N'X7', 105600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8752, N'X8', 105600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8753, N'X9', 105600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8754, N'X10', 105600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8755, N'X11', 105600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8756, N'X12', 105600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8757, N'X13', 105600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8758, N'X14', 105600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8759, N'X15', 105600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8760, N'X16', 105600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8761, N'X17', 105600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8762, N'X18', 105600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8763, N'X19', 105600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8764, N'X20', 105600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8765, N'X21', 105600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8766, N'X22', 105600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8767, N'X23', 105600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8768, N'X24', 105600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8769, N'X25', 105600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8770, N'X26', 105600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8771, N'X27', 105600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8772, N'X28', 105600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8773, N'X29', 105600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8774, N'X30', 105600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8775, N'Y1', 108800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8776, N'Y2', 108800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8777, N'Y3', 108800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8778, N'Y4', 108800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8779, N'Y5', 108800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8780, N'Y6', 108800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8781, N'Y7', 108800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8782, N'Y8', 108800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8783, N'Y9', 108800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8784, N'Y10', 108800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8785, N'Y11', 108800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8786, N'Y12', 108800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8787, N'Y13', 108800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8788, N'Y14', 108800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8789, N'Y15', 108800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8790, N'Y16', 108800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8791, N'Y17', 108800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8792, N'Y18', 108800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8793, N'Y19', 108800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8794, N'Y20', 108800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8795, N'Y21', 108800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8796, N'Y22', 108800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8797, N'Y23', 108800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8798, N'Y24', 108800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8799, N'Y25', 108800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8800, N'Y26', 108800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8801, N'Y27', 108800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8802, N'Y28', 108800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8803, N'Y29', 108800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (28, 3, 8804, N'Y30', 108800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8805, N'A1', 10000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8806, N'A2', 10000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8807, N'A3', 10000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8808, N'A4', 10000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8809, N'A5', 10000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8810, N'A6', 10000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8811, N'A7', 10000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8812, N'A8', 10000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8813, N'A9', 10000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8814, N'A10', 10000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8815, N'A11', 10000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8816, N'A12', 10000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8817, N'A13', 10000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8818, N'A14', 10000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8819, N'A15', 10000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8820, N'A16', 10000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8821, N'A17', 10000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8822, N'A18', 10000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8823, N'A19', 10000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8824, N'A20', 10000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8825, N'A21', 10000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8826, N'A22', 10000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8827, N'A23', 10000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8828, N'A24', 10000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8829, N'A25', 10000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8830, N'A26', 10000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8831, N'A27', 10000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8832, N'A28', 10000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8833, N'A29', 10000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8834, N'A30', 10000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8835, N'B1', 11000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8836, N'B2', 11000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8837, N'B3', 11000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8838, N'B4', 11000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8839, N'B5', 11000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8840, N'B6', 11000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8841, N'B7', 11000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8842, N'B8', 11000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8843, N'B9', 11000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8844, N'B10', 11000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8845, N'B11', 11000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8846, N'B12', 11000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8847, N'B13', 11000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8848, N'B14', 11000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8849, N'B15', 11000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8850, N'B16', 11000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8851, N'B17', 11000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8852, N'B18', 11000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8853, N'B19', 11000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8854, N'B20', 11000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8855, N'B21', 11000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8856, N'B22', 11000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8857, N'B23', 11000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8858, N'B24', 11000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8859, N'B25', 11000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8860, N'B26', 11000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8861, N'B27', 11000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8862, N'B28', 11000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8863, N'B29', 11000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8864, N'B30', 11000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8865, N'C1', 12000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8866, N'C2', 12000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8867, N'C3', 12000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8868, N'C4', 12000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8869, N'C5', 12000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8870, N'C6', 12000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8871, N'C7', 12000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8872, N'C8', 12000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8873, N'C9', 12000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8874, N'C10', 12000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8875, N'C11', 12000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8876, N'C12', 12000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8877, N'C13', 12000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8878, N'C14', 12000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8879, N'C15', 12000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8880, N'C16', 12000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8881, N'C17', 12000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8882, N'C18', 12000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8883, N'C19', 12000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8884, N'C20', 12000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8885, N'C21', 12000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8886, N'C22', 12000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8887, N'C23', 12000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8888, N'C24', 12000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8889, N'C25', 12000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8890, N'C26', 12000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8891, N'C27', 12000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8892, N'C28', 12000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8893, N'C29', 12000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8894, N'C30', 12000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8895, N'D1', 13000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8896, N'D2', 13000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8897, N'D3', 13000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8898, N'D4', 13000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8899, N'D5', 13000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8900, N'D6', 13000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8901, N'D7', 13000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8902, N'D8', 13000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8903, N'D9', 13000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8904, N'D10', 13000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8905, N'D11', 13000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8906, N'D12', 13000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8907, N'D13', 13000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8908, N'D14', 13000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8909, N'D15', 13000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8910, N'D16', 13000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8911, N'D17', 13000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8912, N'D18', 13000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8913, N'D19', 13000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8914, N'D20', 13000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8915, N'D21', 13000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8916, N'D22', 13000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8917, N'D23', 13000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8918, N'D24', 13000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8919, N'D25', 13000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8920, N'D26', 13000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8921, N'D27', 13000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8922, N'D28', 13000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8923, N'D29', 13000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8924, N'D30', 13000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8925, N'E1', 14000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8926, N'E2', 14000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8927, N'E3', 14000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8928, N'E4', 14000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8929, N'E5', 14000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8930, N'E6', 14000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8931, N'E7', 14000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8932, N'E8', 14000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8933, N'E9', 14000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8934, N'E10', 14000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8935, N'E11', 14000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8936, N'E12', 14000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8937, N'E13', 14000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8938, N'E14', 14000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8939, N'E15', 14000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8940, N'E16', 14000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8941, N'E17', 14000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8942, N'E18', 14000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8943, N'E19', 14000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8944, N'E20', 14000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8945, N'E21', 14000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8946, N'E22', 14000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8947, N'E23', 14000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8948, N'E24', 14000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8949, N'E25', 14000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8950, N'E26', 14000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8951, N'E27', 14000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8952, N'E28', 14000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8953, N'E29', 14000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8954, N'E30', 14000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8955, N'F1', 15000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8956, N'F2', 15000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8957, N'F3', 15000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8958, N'F4', 15000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8959, N'F5', 15000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8960, N'F6', 15000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8961, N'F7', 15000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8962, N'F8', 15000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8963, N'F9', 15000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8964, N'F10', 15000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8965, N'F11', 15000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8966, N'F12', 15000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8967, N'F13', 15000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8968, N'F14', 15000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8969, N'F15', 15000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8970, N'F16', 15000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8971, N'F17', 15000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8972, N'F18', 15000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8973, N'F19', 15000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8974, N'F20', 15000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8975, N'F21', 15000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8976, N'F22', 15000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8977, N'F23', 15000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8978, N'F24', 15000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8979, N'F25', 15000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8980, N'F26', 15000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8981, N'F27', 15000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8982, N'F28', 15000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8983, N'F29', 15000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8984, N'F30', 15000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8985, N'G1', 16000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8986, N'G2', 16000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8987, N'G3', 16000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8988, N'G4', 16000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8989, N'G5', 16000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8990, N'G6', 16000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8991, N'G7', 16000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8992, N'G8', 16000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8993, N'G9', 16000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8994, N'G10', 16000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8995, N'G11', 16000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8996, N'G12', 16000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8997, N'G13', 16000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8998, N'G14', 16000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 8999, N'G15', 16000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9000, N'G16', 16000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9001, N'G17', 16000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9002, N'G18', 16000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9003, N'G19', 16000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9004, N'G20', 16000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9005, N'G21', 16000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9006, N'G22', 16000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9007, N'G23', 16000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9008, N'G24', 16000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9009, N'G25', 16000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9010, N'G26', 16000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9011, N'G27', 16000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9012, N'G28', 16000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9013, N'G29', 16000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9014, N'G30', 16000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9015, N'H1', 17000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9016, N'H2', 17000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9017, N'H3', 17000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9018, N'H4', 17000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9019, N'H5', 17000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9020, N'H6', 17000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9021, N'H7', 17000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9022, N'H8', 17000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9023, N'H9', 17000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9024, N'H10', 17000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9025, N'H11', 17000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9026, N'H12', 17000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9027, N'H13', 17000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9028, N'H14', 17000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9029, N'H15', 17000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9030, N'H16', 17000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9031, N'H17', 17000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9032, N'H18', 17000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9033, N'H19', 17000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9034, N'H20', 17000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9035, N'H21', 17000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9036, N'H22', 17000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9037, N'H23', 17000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9038, N'H24', 17000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9039, N'H25', 17000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9040, N'H26', 17000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9041, N'H27', 17000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9042, N'H28', 17000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9043, N'H29', 17000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9044, N'H30', 17000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9045, N'I1', 18000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9046, N'I2', 18000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9047, N'I3', 18000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9048, N'I4', 18000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9049, N'I5', 18000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9050, N'I6', 18000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9051, N'I7', 18000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9052, N'I8', 18000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9053, N'I9', 18000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9054, N'I10', 18000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9055, N'I11', 18000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9056, N'I12', 18000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9057, N'I13', 18000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9058, N'I14', 18000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9059, N'I15', 18000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9060, N'I16', 18000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9061, N'I17', 18000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9062, N'I18', 18000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9063, N'I19', 18000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9064, N'I20', 18000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9065, N'I21', 18000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9066, N'I22', 18000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9067, N'I23', 18000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9068, N'I24', 18000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9069, N'I25', 18000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9070, N'I26', 18000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9071, N'I27', 18000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9072, N'I28', 18000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9073, N'I29', 18000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9074, N'I30', 18000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9075, N'J1', 19000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9076, N'J2', 19000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9077, N'J3', 19000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9078, N'J4', 19000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9079, N'J5', 19000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9080, N'J6', 19000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9081, N'J7', 19000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9082, N'J8', 19000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9083, N'J9', 19000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9084, N'J10', 19000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9085, N'J11', 19000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9086, N'J12', 19000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9087, N'J13', 19000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9088, N'J14', 19000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9089, N'J15', 19000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9090, N'J16', 19000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9091, N'J17', 19000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9092, N'J18', 19000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9093, N'J19', 19000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9094, N'J20', 19000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9095, N'J21', 19000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9096, N'J22', 19000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9097, N'J23', 19000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9098, N'J24', 19000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9099, N'J25', 19000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9100, N'J26', 19000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9101, N'J27', 19000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9102, N'J28', 19000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9103, N'J29', 19000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9104, N'J30', 19000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9105, N'K1', 20000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9106, N'K2', 20000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9107, N'K3', 20000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9108, N'K4', 20000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9109, N'K5', 20000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9110, N'K6', 20000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9111, N'K7', 20000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9112, N'K8', 20000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9113, N'K9', 20000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9114, N'K10', 20000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9115, N'K11', 20000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9116, N'K12', 20000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9117, N'K13', 20000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9118, N'K14', 20000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9119, N'K15', 20000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9120, N'K16', 20000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9121, N'K17', 20000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9122, N'K18', 20000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9123, N'K19', 20000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9124, N'K20', 20000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9125, N'K21', 20000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9126, N'K22', 20000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9127, N'K23', 20000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9128, N'K24', 20000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9129, N'K25', 20000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9130, N'K26', 20000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9131, N'K27', 20000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9132, N'K28', 20000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9133, N'K29', 20000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9134, N'K30', 20000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9135, N'L1', 21000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9136, N'L2', 21000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9137, N'L3', 21000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9138, N'L4', 21000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9139, N'L5', 21000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9140, N'L6', 21000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9141, N'L7', 21000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9142, N'L8', 21000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9143, N'L9', 21000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9144, N'L10', 21000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9145, N'L11', 21000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9146, N'L12', 21000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9147, N'L13', 21000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9148, N'L14', 21000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9149, N'L15', 21000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9150, N'L16', 21000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9151, N'L17', 21000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9152, N'L18', 21000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9153, N'L19', 21000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9154, N'L20', 21000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9155, N'L21', 21000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9156, N'L22', 21000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9157, N'L23', 21000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9158, N'L24', 21000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9159, N'L25', 21000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9160, N'L26', 21000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9161, N'L27', 21000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9162, N'L28', 21000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9163, N'L29', 21000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9164, N'L30', 21000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9165, N'M1', 22000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9166, N'M2', 22000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9167, N'M3', 22000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9168, N'M4', 22000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9169, N'M5', 22000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9170, N'M6', 22000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9171, N'M7', 22000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9172, N'M8', 22000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9173, N'M9', 22000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9174, N'M10', 22000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9175, N'M11', 22000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9176, N'M12', 22000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9177, N'M13', 22000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9178, N'M14', 22000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9179, N'M15', 22000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9180, N'M16', 22000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9181, N'M17', 22000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9182, N'M18', 22000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9183, N'M19', 22000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9184, N'M20', 22000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9185, N'M21', 22000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9186, N'M22', 22000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9187, N'M23', 22000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9188, N'M24', 22000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9189, N'M25', 22000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9190, N'M26', 22000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9191, N'M27', 22000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9192, N'M28', 22000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9193, N'M29', 22000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9194, N'M30', 22000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9195, N'N1', 23000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9196, N'N2', 23000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9197, N'N3', 23000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9198, N'N4', 23000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9199, N'N5', 23000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9200, N'N6', 23000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9201, N'N7', 23000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9202, N'N8', 23000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9203, N'N9', 23000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9204, N'N10', 23000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9205, N'N11', 23000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9206, N'N12', 23000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9207, N'N13', 23000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9208, N'N14', 23000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9209, N'N15', 23000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9210, N'N16', 23000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9211, N'N17', 23000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9212, N'N18', 23000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9213, N'N19', 23000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9214, N'N20', 23000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9215, N'N21', 23000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9216, N'N22', 23000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9217, N'N23', 23000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9218, N'N24', 23000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9219, N'N25', 23000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9220, N'N26', 23000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9221, N'N27', 23000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9222, N'N28', 23000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9223, N'N29', 23000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9224, N'N30', 23000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9225, N'O1', 24000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9226, N'O2', 24000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9227, N'O3', 24000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9228, N'O4', 24000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9229, N'O5', 24000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9230, N'O6', 24000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9231, N'O7', 24000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9232, N'O8', 24000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9233, N'O9', 24000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9234, N'O10', 24000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9235, N'O11', 24000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9236, N'O12', 24000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9237, N'O13', 24000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9238, N'O14', 24000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9239, N'O15', 24000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9240, N'O16', 24000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9241, N'O17', 24000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9242, N'O18', 24000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9243, N'O19', 24000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9244, N'O20', 24000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9245, N'O21', 24000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9246, N'O22', 24000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9247, N'O23', 24000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9248, N'O24', 24000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9249, N'O25', 24000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9250, N'O26', 24000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9251, N'O27', 24000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9252, N'O28', 24000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9253, N'O29', 24000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9254, N'O30', 24000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9255, N'P1', 25000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9256, N'P2', 25000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9257, N'P3', 25000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9258, N'P4', 25000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9259, N'P5', 25000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9260, N'P6', 25000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9261, N'P7', 25000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9262, N'P8', 25000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9263, N'P9', 25000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9264, N'P10', 25000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9265, N'P11', 25000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9266, N'P12', 25000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9267, N'P13', 25000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9268, N'P14', 25000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9269, N'P15', 25000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9270, N'P16', 25000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9271, N'P17', 25000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9272, N'P18', 25000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9273, N'P19', 25000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9274, N'P20', 25000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9275, N'P21', 25000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9276, N'P22', 25000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9277, N'P23', 25000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9278, N'P24', 25000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9279, N'P25', 25000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9280, N'P26', 25000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9281, N'P27', 25000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9282, N'P28', 25000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9283, N'P29', 25000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9284, N'P30', 25000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9285, N'Q1', 26000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9286, N'Q2', 26000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9287, N'Q3', 26000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9288, N'Q4', 26000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9289, N'Q5', 26000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9290, N'Q6', 26000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9291, N'Q7', 26000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9292, N'Q8', 26000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9293, N'Q9', 26000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9294, N'Q10', 26000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9295, N'Q11', 26000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9296, N'Q12', 26000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9297, N'Q13', 26000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9298, N'Q14', 26000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9299, N'Q15', 26000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9300, N'Q16', 26000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9301, N'Q17', 26000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9302, N'Q18', 26000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9303, N'Q19', 26000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9304, N'Q20', 26000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9305, N'Q21', 26000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9306, N'Q22', 26000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9307, N'Q23', 26000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9308, N'Q24', 26000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9309, N'Q25', 26000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9310, N'Q26', 26000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9311, N'Q27', 26000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9312, N'Q28', 26000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9313, N'Q29', 26000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9314, N'Q30', 26000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9315, N'R1', 27000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9316, N'R2', 27000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9317, N'R3', 27000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9318, N'R4', 27000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9319, N'R5', 27000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9320, N'R6', 27000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9321, N'R7', 27000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9322, N'R8', 27000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9323, N'R9', 27000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9324, N'R10', 27000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9325, N'R11', 27000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9326, N'R12', 27000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9327, N'R13', 27000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9328, N'R14', 27000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9329, N'R15', 27000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9330, N'R16', 27000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9331, N'R17', 27000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9332, N'R18', 27000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9333, N'R19', 27000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9334, N'R20', 27000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9335, N'R21', 27000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9336, N'R22', 27000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9337, N'R23', 27000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9338, N'R24', 27000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9339, N'R25', 27000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9340, N'R26', 27000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9341, N'R27', 27000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9342, N'R28', 27000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9343, N'R29', 27000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9344, N'R30', 27000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9345, N'S1', 28000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9346, N'S2', 28000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9347, N'S3', 28000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9348, N'S4', 28000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9349, N'S5', 28000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9350, N'S6', 28000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9351, N'S7', 28000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9352, N'S8', 28000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9353, N'S9', 28000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9354, N'S10', 28000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9355, N'S11', 28000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9356, N'S12', 28000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9357, N'S13', 28000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9358, N'S14', 28000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9359, N'S15', 28000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9360, N'S16', 28000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9361, N'S17', 28000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9362, N'S18', 28000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9363, N'S19', 28000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9364, N'S20', 28000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9365, N'S21', 28000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9366, N'S22', 28000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9367, N'S23', 28000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9368, N'S24', 28000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9369, N'S25', 28000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9370, N'S26', 28000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9371, N'S27', 28000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9372, N'S28', 28000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9373, N'S29', 28000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9374, N'S30', 28000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9375, N'T1', 29000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9376, N'T2', 29000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9377, N'T3', 29000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9378, N'T4', 29000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9379, N'T5', 29000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9380, N'T6', 29000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9381, N'T7', 29000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9382, N'T8', 29000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9383, N'T9', 29000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9384, N'T10', 29000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9385, N'T11', 29000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9386, N'T12', 29000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9387, N'T13', 29000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9388, N'T14', 29000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9389, N'T15', 29000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9390, N'T16', 29000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9391, N'T17', 29000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9392, N'T18', 29000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9393, N'T19', 29000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9394, N'T20', 29000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9395, N'T21', 29000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9396, N'T22', 29000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9397, N'T23', 29000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9398, N'T24', 29000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9399, N'T25', 29000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9400, N'T26', 29000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9401, N'T27', 29000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9402, N'T28', 29000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9403, N'T29', 29000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9404, N'T30', 29000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9405, N'U1', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9406, N'U2', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9407, N'U3', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9408, N'U4', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9409, N'U5', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9410, N'U6', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9411, N'U7', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9412, N'U8', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9413, N'U9', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9414, N'U10', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9415, N'U11', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9416, N'U12', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9417, N'U13', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9418, N'U14', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9419, N'U15', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9420, N'U16', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9421, N'U17', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9422, N'U18', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9423, N'U19', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9424, N'U20', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9425, N'U21', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9426, N'U22', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9427, N'U23', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9428, N'U24', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9429, N'U25', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9430, N'U26', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9431, N'U27', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9432, N'U28', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9433, N'U29', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9434, N'U30', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9435, N'V1', 31000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9436, N'V2', 31000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9437, N'V3', 31000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9438, N'V4', 31000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9439, N'V5', 31000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9440, N'V6', 31000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9441, N'V7', 31000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9442, N'V8', 31000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9443, N'V9', 31000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9444, N'V10', 31000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9445, N'V11', 31000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9446, N'V12', 31000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9447, N'V13', 31000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9448, N'V14', 31000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9449, N'V15', 31000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9450, N'V16', 31000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9451, N'V17', 31000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9452, N'V18', 31000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9453, N'V19', 31000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9454, N'V20', 31000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9455, N'V21', 31000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9456, N'V22', 31000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9457, N'V23', 31000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9458, N'V24', 31000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9459, N'V25', 31000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9460, N'V26', 31000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9461, N'V27', 31000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9462, N'V28', 31000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9463, N'V29', 31000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9464, N'V30', 31000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9465, N'W1', 32000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9466, N'W2', 32000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9467, N'W3', 32000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9468, N'W4', 32000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9469, N'W5', 32000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9470, N'W6', 32000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9471, N'W7', 32000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9472, N'W8', 32000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9473, N'W9', 32000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9474, N'W10', 32000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9475, N'W11', 32000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9476, N'W12', 32000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9477, N'W13', 32000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9478, N'W14', 32000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9479, N'W15', 32000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9480, N'W16', 32000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9481, N'W17', 32000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9482, N'W18', 32000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9483, N'W19', 32000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9484, N'W20', 32000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9485, N'W21', 32000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9486, N'W22', 32000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9487, N'W23', 32000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9488, N'W24', 32000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9489, N'W25', 32000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9490, N'W26', 32000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9491, N'W27', 32000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9492, N'W28', 32000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9493, N'W29', 32000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9494, N'W30', 32000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9495, N'X1', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9496, N'X2', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9497, N'X3', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9498, N'X4', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9499, N'X5', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9500, N'X6', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9501, N'X7', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9502, N'X8', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9503, N'X9', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9504, N'X10', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9505, N'X11', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9506, N'X12', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9507, N'X13', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9508, N'X14', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9509, N'X15', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9510, N'X16', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9511, N'X17', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9512, N'X18', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9513, N'X19', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9514, N'X20', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9515, N'X21', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9516, N'X22', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9517, N'X23', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9518, N'X24', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9519, N'X25', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9520, N'X26', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9521, N'X27', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9522, N'X28', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9523, N'X29', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (7, 4, 9524, N'X30', 33000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9525, N'A1', 25000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9526, N'A2', 25000.0000, 1, N'danghoan')
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9527, N'A3', 25000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9528, N'A4', 25000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9529, N'A5', 25000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9530, N'A6', 25000.0000, 1, N'danghoan')
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9531, N'A7', 25000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9532, N'A8', 25000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9533, N'A9', 25000.0000, 1, N'danghoan')
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9534, N'A10', 25000.0000, 1, N'danghoan')
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9535, N'A11', 25000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9536, N'A12', 25000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9537, N'A13', 25000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9538, N'A14', 25000.0000, 1, N'danghoan')
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9539, N'A15', 25000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9540, N'A16', 25000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9541, N'A17', 25000.0000, 1, N'danghoan')
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9542, N'A18', 25000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9543, N'A19', 25000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9544, N'A20', 25000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9545, N'A21', 25000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9546, N'A22', 25000.0000, 1, N'danghoan')
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9547, N'A23', 25000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9548, N'A24', 25000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9549, N'A25', 25000.0000, 1, N'danghoan')
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9550, N'A26', 25000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9551, N'A27', 25000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9552, N'A28', 25000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9553, N'A29', 25000.0000, 1, N'danghoan')
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9554, N'A30', 25000.0000, 1, N'danghoan')
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9555, N'B1', 27500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9556, N'B2', 27500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9557, N'B3', 27500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9558, N'B4', 27500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9559, N'B5', 27500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9560, N'B6', 27500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9561, N'B7', 27500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9562, N'B8', 27500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9563, N'B9', 27500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9564, N'B10', 27500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9565, N'B11', 27500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9566, N'B12', 27500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9567, N'B13', 27500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9568, N'B14', 27500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9569, N'B15', 27500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9570, N'B16', 27500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9571, N'B17', 27500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9572, N'B18', 27500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9573, N'B19', 27500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9574, N'B20', 27500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9575, N'B21', 27500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9576, N'B22', 27500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9577, N'B23', 27500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9578, N'B24', 27500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9579, N'B25', 27500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9580, N'B26', 27500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9581, N'B27', 27500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9582, N'B28', 27500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9583, N'B29', 27500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9584, N'B30', 27500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9585, N'C1', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9586, N'C2', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9587, N'C3', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9588, N'C4', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9589, N'C5', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9590, N'C6', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9591, N'C7', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9592, N'C8', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9593, N'C9', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9594, N'C10', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9595, N'C11', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9596, N'C12', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9597, N'C13', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9598, N'C14', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9599, N'C15', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9600, N'C16', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9601, N'C17', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9602, N'C18', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9603, N'C19', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9604, N'C20', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9605, N'C21', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9606, N'C22', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9607, N'C23', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9608, N'C24', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9609, N'C25', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9610, N'C26', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9611, N'C27', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9612, N'C28', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9613, N'C29', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9614, N'C30', 30000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9615, N'D1', 32500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9616, N'D2', 32500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9617, N'D3', 32500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9618, N'D4', 32500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9619, N'D5', 32500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9620, N'D6', 32500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9621, N'D7', 32500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9622, N'D8', 32500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9623, N'D9', 32500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9624, N'D10', 32500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9625, N'D11', 32500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9626, N'D12', 32500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9627, N'D13', 32500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9628, N'D14', 32500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9629, N'D15', 32500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9630, N'D16', 32500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9631, N'D17', 32500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9632, N'D18', 32500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9633, N'D19', 32500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9634, N'D20', 32500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9635, N'D21', 32500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9636, N'D22', 32500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9637, N'D23', 32500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9638, N'D24', 32500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9639, N'D25', 32500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9640, N'D26', 32500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9641, N'D27', 32500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9642, N'D28', 32500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9643, N'D29', 32500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9644, N'D30', 32500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9645, N'E1', 35000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9646, N'E2', 35000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9647, N'E3', 35000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9648, N'E4', 35000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9649, N'E5', 35000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9650, N'E6', 35000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9651, N'E7', 35000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9652, N'E8', 35000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9653, N'E9', 35000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9654, N'E10', 35000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9655, N'E11', 35000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9656, N'E12', 35000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9657, N'E13', 35000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9658, N'E14', 35000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9659, N'E15', 35000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9660, N'E16', 35000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9661, N'E17', 35000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9662, N'E18', 35000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9663, N'E19', 35000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9664, N'E20', 35000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9665, N'E21', 35000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9666, N'E22', 35000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9667, N'E23', 35000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9668, N'E24', 35000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9669, N'E25', 35000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9670, N'E26', 35000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9671, N'E27', 35000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9672, N'E28', 35000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9673, N'E29', 35000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9674, N'E30', 35000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9675, N'F1', 37500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9676, N'F2', 37500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9677, N'F3', 37500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9678, N'F4', 37500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9679, N'F5', 37500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9680, N'F6', 37500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9681, N'F7', 37500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9682, N'F8', 37500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9683, N'F9', 37500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9684, N'F10', 37500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9685, N'F11', 37500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9686, N'F12', 37500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9687, N'F13', 37500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9688, N'F14', 37500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9689, N'F15', 37500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9690, N'F16', 37500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9691, N'F17', 37500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9692, N'F18', 37500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9693, N'F19', 37500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9694, N'F20', 37500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9695, N'F21', 37500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9696, N'F22', 37500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9697, N'F23', 37500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9698, N'F24', 37500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9699, N'F25', 37500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9700, N'F26', 37500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9701, N'F27', 37500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9702, N'F28', 37500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9703, N'F29', 37500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9704, N'F30', 37500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9705, N'G1', 40000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9706, N'G2', 40000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9707, N'G3', 40000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9708, N'G4', 40000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9709, N'G5', 40000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9710, N'G6', 40000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9711, N'G7', 40000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9712, N'G8', 40000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9713, N'G9', 40000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9714, N'G10', 40000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9715, N'G11', 40000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9716, N'G12', 40000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9717, N'G13', 40000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9718, N'G14', 40000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9719, N'G15', 40000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9720, N'G16', 40000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9721, N'G17', 40000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9722, N'G18', 40000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9723, N'G19', 40000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9724, N'G20', 40000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9725, N'G21', 40000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9726, N'G22', 40000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9727, N'G23', 40000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9728, N'G24', 40000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9729, N'G25', 40000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9730, N'G26', 40000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9731, N'G27', 40000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9732, N'G28', 40000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9733, N'G29', 40000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9734, N'G30', 40000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9735, N'H1', 42500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9736, N'H2', 42500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9737, N'H3', 42500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9738, N'H4', 42500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9739, N'H5', 42500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9740, N'H6', 42500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9741, N'H7', 42500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9742, N'H8', 42500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9743, N'H9', 42500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9744, N'H10', 42500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9745, N'H11', 42500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9746, N'H12', 42500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9747, N'H13', 42500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9748, N'H14', 42500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9749, N'H15', 42500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9750, N'H16', 42500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9751, N'H17', 42500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9752, N'H18', 42500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9753, N'H19', 42500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9754, N'H20', 42500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9755, N'H21', 42500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9756, N'H22', 42500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9757, N'H23', 42500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9758, N'H24', 42500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9759, N'H25', 42500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9760, N'H26', 42500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9761, N'H27', 42500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9762, N'H28', 42500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9763, N'H29', 42500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9764, N'H30', 42500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9765, N'I1', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9766, N'I2', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9767, N'I3', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9768, N'I4', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9769, N'I5', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9770, N'I6', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9771, N'I7', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9772, N'I8', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9773, N'I9', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9774, N'I10', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9775, N'I11', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9776, N'I12', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9777, N'I13', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9778, N'I14', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9779, N'I15', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9780, N'I16', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9781, N'I17', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9782, N'I18', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9783, N'I19', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9784, N'I20', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9785, N'I21', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9786, N'I22', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9787, N'I23', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9788, N'I24', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9789, N'I25', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9790, N'I26', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9791, N'I27', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9792, N'I28', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9793, N'I29', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9794, N'I30', 45000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9795, N'J1', 47500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9796, N'J2', 47500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9797, N'J3', 47500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9798, N'J4', 47500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9799, N'J5', 47500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9800, N'J6', 47500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9801, N'J7', 47500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9802, N'J8', 47500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9803, N'J9', 47500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9804, N'J10', 47500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9805, N'J11', 47500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9806, N'J12', 47500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9807, N'J13', 47500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9808, N'J14', 47500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9809, N'J15', 47500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9810, N'J16', 47500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9811, N'J17', 47500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9812, N'J18', 47500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9813, N'J19', 47500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9814, N'J20', 47500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9815, N'J21', 47500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9816, N'J22', 47500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9817, N'J23', 47500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9818, N'J24', 47500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9819, N'J25', 47500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9820, N'J26', 47500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9821, N'J27', 47500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9822, N'J28', 47500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9823, N'J29', 47500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9824, N'J30', 47500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9825, N'K1', 50000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9826, N'K2', 50000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9827, N'K3', 50000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9828, N'K4', 50000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9829, N'K5', 50000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9830, N'K6', 50000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9831, N'K7', 50000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9832, N'K8', 50000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9833, N'K9', 50000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9834, N'K10', 50000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9835, N'K11', 50000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9836, N'K12', 50000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9837, N'K13', 50000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9838, N'K14', 50000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9839, N'K15', 50000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9840, N'K16', 50000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9841, N'K17', 50000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9842, N'K18', 50000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9843, N'K19', 50000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9844, N'K20', 50000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9845, N'K21', 50000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9846, N'K22', 50000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9847, N'K23', 50000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9848, N'K24', 50000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9849, N'K25', 50000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9850, N'K26', 50000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9851, N'K27', 50000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9852, N'K28', 50000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9853, N'K29', 50000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9854, N'K30', 50000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9855, N'L1', 52500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9856, N'L2', 52500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9857, N'L3', 52500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9858, N'L4', 52500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9859, N'L5', 52500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9860, N'L6', 52500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9861, N'L7', 52500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9862, N'L8', 52500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9863, N'L9', 52500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9864, N'L10', 52500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9865, N'L11', 52500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9866, N'L12', 52500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9867, N'L13', 52500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9868, N'L14', 52500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9869, N'L15', 52500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9870, N'L16', 52500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9871, N'L17', 52500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9872, N'L18', 52500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9873, N'L19', 52500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9874, N'L20', 52500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9875, N'L21', 52500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9876, N'L22', 52500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9877, N'L23', 52500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9878, N'L24', 52500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9879, N'L25', 52500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9880, N'L26', 52500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9881, N'L27', 52500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9882, N'L28', 52500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9883, N'L29', 52500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9884, N'L30', 52500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9885, N'M1', 55000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9886, N'M2', 55000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9887, N'M3', 55000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9888, N'M4', 55000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9889, N'M5', 55000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9890, N'M6', 55000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9891, N'M7', 55000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9892, N'M8', 55000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9893, N'M9', 55000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9894, N'M10', 55000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9895, N'M11', 55000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9896, N'M12', 55000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9897, N'M13', 55000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9898, N'M14', 55000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9899, N'M15', 55000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9900, N'M16', 55000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9901, N'M17', 55000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9902, N'M18', 55000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9903, N'M19', 55000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9904, N'M20', 55000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9905, N'M21', 55000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9906, N'M22', 55000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9907, N'M23', 55000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9908, N'M24', 55000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9909, N'M25', 55000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9910, N'M26', 55000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9911, N'M27', 55000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9912, N'M28', 55000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9913, N'M29', 55000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9914, N'M30', 55000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9915, N'N1', 57500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9916, N'N2', 57500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9917, N'N3', 57500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9918, N'N4', 57500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9919, N'N5', 57500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9920, N'N6', 57500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9921, N'N7', 57500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9922, N'N8', 57500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9923, N'N9', 57500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9924, N'N10', 57500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9925, N'N11', 57500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9926, N'N12', 57500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9927, N'N13', 57500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9928, N'N14', 57500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9929, N'N15', 57500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9930, N'N16', 57500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9931, N'N17', 57500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9932, N'N18', 57500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9933, N'N19', 57500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9934, N'N20', 57500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9935, N'N21', 57500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9936, N'N22', 57500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9937, N'N23', 57500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9938, N'N24', 57500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9939, N'N25', 57500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9940, N'N26', 57500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9941, N'N27', 57500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9942, N'N28', 57500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9943, N'N29', 57500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9944, N'N30', 57500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9945, N'O1', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9946, N'O2', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9947, N'O3', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9948, N'O4', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9949, N'O5', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9950, N'O6', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9951, N'O7', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9952, N'O8', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9953, N'O9', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9954, N'O10', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9955, N'O11', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9956, N'O12', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9957, N'O13', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9958, N'O14', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9959, N'O15', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9960, N'O16', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9961, N'O17', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9962, N'O18', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9963, N'O19', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9964, N'O20', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9965, N'O21', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9966, N'O22', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9967, N'O23', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9968, N'O24', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9969, N'O25', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9970, N'O26', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9971, N'O27', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9972, N'O28', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9973, N'O29', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9974, N'O30', 60000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9975, N'P1', 62500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9976, N'P2', 62500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9977, N'P3', 62500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9978, N'P4', 62500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9979, N'P5', 62500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9980, N'P6', 62500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9981, N'P7', 62500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9982, N'P8', 62500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9983, N'P9', 62500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9984, N'P10', 62500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9985, N'P11', 62500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9986, N'P12', 62500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9987, N'P13', 62500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9988, N'P14', 62500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9989, N'P15', 62500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9990, N'P16', 62500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9991, N'P17', 62500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9992, N'P18', 62500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9993, N'P19', 62500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9994, N'P20', 62500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9995, N'P21', 62500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9996, N'P22', 62500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9997, N'P23', 62500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9998, N'P24', 62500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 9999, N'P25', 62500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10000, N'P26', 62500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10001, N'P27', 62500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10002, N'P28', 62500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10003, N'P29', 62500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10004, N'P30', 62500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10005, N'Q1', 65000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10006, N'Q2', 65000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10007, N'Q3', 65000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10008, N'Q4', 65000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10009, N'Q5', 65000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10010, N'Q6', 65000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10011, N'Q7', 65000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10012, N'Q8', 65000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10013, N'Q9', 65000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10014, N'Q10', 65000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10015, N'Q11', 65000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10016, N'Q12', 65000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10017, N'Q13', 65000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10018, N'Q14', 65000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10019, N'Q15', 65000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10020, N'Q16', 65000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10021, N'Q17', 65000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10022, N'Q18', 65000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10023, N'Q19', 65000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10024, N'Q20', 65000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10025, N'Q21', 65000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10026, N'Q22', 65000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10027, N'Q23', 65000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10028, N'Q24', 65000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10029, N'Q25', 65000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10030, N'Q26', 65000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10031, N'Q27', 65000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10032, N'Q28', 65000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10033, N'Q29', 65000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10034, N'Q30', 65000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10035, N'R1', 67500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10036, N'R2', 67500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10037, N'R3', 67500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10038, N'R4', 67500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10039, N'R5', 67500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10040, N'R6', 67500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10041, N'R7', 67500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10042, N'R8', 67500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10043, N'R9', 67500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10044, N'R10', 67500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10045, N'R11', 67500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10046, N'R12', 67500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10047, N'R13', 67500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10048, N'R14', 67500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10049, N'R15', 67500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10050, N'R16', 67500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10051, N'R17', 67500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10052, N'R18', 67500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10053, N'R19', 67500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10054, N'R20', 67500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10055, N'R21', 67500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10056, N'R22', 67500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10057, N'R23', 67500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10058, N'R24', 67500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10059, N'R25', 67500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10060, N'R26', 67500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10061, N'R27', 67500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10062, N'R28', 67500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10063, N'R29', 67500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10064, N'R30', 67500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10065, N'S1', 70000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10066, N'S2', 70000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10067, N'S3', 70000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10068, N'S4', 70000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10069, N'S5', 70000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10070, N'S6', 70000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10071, N'S7', 70000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10072, N'S8', 70000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10073, N'S9', 70000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10074, N'S10', 70000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10075, N'S11', 70000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10076, N'S12', 70000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10077, N'S13', 70000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10078, N'S14', 70000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10079, N'S15', 70000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10080, N'S16', 70000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10081, N'S17', 70000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10082, N'S18', 70000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10083, N'S19', 70000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10084, N'S20', 70000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10085, N'S21', 70000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10086, N'S22', 70000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10087, N'S23', 70000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10088, N'S24', 70000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10089, N'S25', 70000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10090, N'S26', 70000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10091, N'S27', 70000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10092, N'S28', 70000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10093, N'S29', 70000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10094, N'S30', 70000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10095, N'T1', 72500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10096, N'T2', 72500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10097, N'T3', 72500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10098, N'T4', 72500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10099, N'T5', 72500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10100, N'T6', 72500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10101, N'T7', 72500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10102, N'T8', 72500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10103, N'T9', 72500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10104, N'T10', 72500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10105, N'T11', 72500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10106, N'T12', 72500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10107, N'T13', 72500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10108, N'T14', 72500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10109, N'T15', 72500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10110, N'T16', 72500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10111, N'T17', 72500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10112, N'T18', 72500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10113, N'T19', 72500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10114, N'T20', 72500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10115, N'T21', 72500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10116, N'T22', 72500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10117, N'T23', 72500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10118, N'T24', 72500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10119, N'T25', 72500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10120, N'T26', 72500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10121, N'T27', 72500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10122, N'T28', 72500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10123, N'T29', 72500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10124, N'T30', 72500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10125, N'U1', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10126, N'U2', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10127, N'U3', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10128, N'U4', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10129, N'U5', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10130, N'U6', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10131, N'U7', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10132, N'U8', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10133, N'U9', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10134, N'U10', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10135, N'U11', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10136, N'U12', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10137, N'U13', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10138, N'U14', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10139, N'U15', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10140, N'U16', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10141, N'U17', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10142, N'U18', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10143, N'U19', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10144, N'U20', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10145, N'U21', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10146, N'U22', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10147, N'U23', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10148, N'U24', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10149, N'U25', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10150, N'U26', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10151, N'U27', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10152, N'U28', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10153, N'U29', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10154, N'U30', 75000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10155, N'V1', 77500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10156, N'V2', 77500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10157, N'V3', 77500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10158, N'V4', 77500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10159, N'V5', 77500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10160, N'V6', 77500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10161, N'V7', 77500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10162, N'V8', 77500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10163, N'V9', 77500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10164, N'V10', 77500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10165, N'V11', 77500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10166, N'V12', 77500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10167, N'V13', 77500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10168, N'V14', 77500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10169, N'V15', 77500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10170, N'V16', 77500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10171, N'V17', 77500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10172, N'V18', 77500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10173, N'V19', 77500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10174, N'V20', 77500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10175, N'V21', 77500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10176, N'V22', 77500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10177, N'V23', 77500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10178, N'V24', 77500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10179, N'V25', 77500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10180, N'V26', 77500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10181, N'V27', 77500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10182, N'V28', 77500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10183, N'V29', 77500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10184, N'V30', 77500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10185, N'W1', 80000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10186, N'W2', 80000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10187, N'W3', 80000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10188, N'W4', 80000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10189, N'W5', 80000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10190, N'W6', 80000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10191, N'W7', 80000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10192, N'W8', 80000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10193, N'W9', 80000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10194, N'W10', 80000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10195, N'W11', 80000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10196, N'W12', 80000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10197, N'W13', 80000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10198, N'W14', 80000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10199, N'W15', 80000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10200, N'W16', 80000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10201, N'W17', 80000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10202, N'W18', 80000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10203, N'W19', 80000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10204, N'W20', 80000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10205, N'W21', 80000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10206, N'W22', 80000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10207, N'W23', 80000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10208, N'W24', 80000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10209, N'W25', 80000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10210, N'W26', 80000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10211, N'W27', 80000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10212, N'W28', 80000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10213, N'W29', 80000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10214, N'W30', 80000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10215, N'X1', 82500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10216, N'X2', 82500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10217, N'X3', 82500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10218, N'X4', 82500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10219, N'X5', 82500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10220, N'X6', 82500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10221, N'X7', 82500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10222, N'X8', 82500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10223, N'X9', 82500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10224, N'X10', 82500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10225, N'X11', 82500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10226, N'X12', 82500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10227, N'X13', 82500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10228, N'X14', 82500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10229, N'X15', 82500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10230, N'X16', 82500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10231, N'X17', 82500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10232, N'X18', 82500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10233, N'X19', 82500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10234, N'X20', 82500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10235, N'X21', 82500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10236, N'X22', 82500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10237, N'X23', 82500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10238, N'X24', 82500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10239, N'X25', 82500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10240, N'X26', 82500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10241, N'X27', 82500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10242, N'X28', 82500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10243, N'X29', 82500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10244, N'X30', 82500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10245, N'Y1', 85000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10246, N'Y2', 85000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10247, N'Y3', 85000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10248, N'Y4', 85000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10249, N'Y5', 85000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10250, N'Y6', 85000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10251, N'Y7', 85000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10252, N'Y8', 85000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10253, N'Y9', 85000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10254, N'Y10', 85000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10255, N'Y11', 85000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10256, N'Y12', 85000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10257, N'Y13', 85000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10258, N'Y14', 85000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10259, N'Y15', 85000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10260, N'Y16', 85000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10261, N'Y17', 85000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10262, N'Y18', 85000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10263, N'Y19', 85000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10264, N'Y20', 85000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10265, N'Y21', 85000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10266, N'Y22', 85000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10267, N'Y23', 85000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10268, N'Y24', 85000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10269, N'Y25', 85000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10270, N'Y26', 85000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10271, N'Y27', 85000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10272, N'Y28', 85000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10273, N'Y29', 85000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (30, 5, 10274, N'Y30', 85000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10275, N'A1', 23000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10276, N'A2', 23000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10277, N'A3', 23000.0000, 1, N'danghoan')
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10278, N'A4', 23000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10279, N'A5', 23000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10280, N'A6', 23000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10281, N'A7', 23000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10282, N'A8', 23000.0000, 1, N'danghoan')
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10283, N'A9', 23000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10284, N'A10', 23000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10285, N'A11', 23000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10286, N'A12', 23000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10287, N'A13', 23000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10288, N'A14', 23000.0000, 1, N'danghoan')
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10289, N'A15', 23000.0000, 1, N'danghoan')
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10290, N'A16', 23000.0000, 1, N'danghoan')
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10291, N'A17', 23000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10292, N'A18', 23000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10293, N'A19', 23000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10294, N'A20', 23000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10295, N'A21', 23000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10296, N'A22', 23000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10297, N'A23', 23000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10298, N'A24', 23000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10299, N'A25', 23000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10300, N'A26', 23000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10301, N'A27', 23000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10302, N'A28', 23000.0000, 1, N'danghoan')
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10303, N'A29', 23000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10304, N'A30', 23000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10305, N'B1', 25300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10306, N'B2', 25300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10307, N'B3', 25300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10308, N'B4', 25300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10309, N'B5', 25300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10310, N'B6', 25300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10311, N'B7', 25300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10312, N'B8', 25300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10313, N'B9', 25300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10314, N'B10', 25300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10315, N'B11', 25300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10316, N'B12', 25300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10317, N'B13', 25300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10318, N'B14', 25300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10319, N'B15', 25300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10320, N'B16', 25300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10321, N'B17', 25300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10322, N'B18', 25300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10323, N'B19', 25300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10324, N'B20', 25300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10325, N'B21', 25300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10326, N'B22', 25300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10327, N'B23', 25300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10328, N'B24', 25300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10329, N'B25', 25300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10330, N'B26', 25300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10331, N'B27', 25300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10332, N'B28', 25300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10333, N'B29', 25300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10334, N'B30', 25300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10335, N'C1', 27600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10336, N'C2', 27600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10337, N'C3', 27600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10338, N'C4', 27600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10339, N'C5', 27600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10340, N'C6', 27600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10341, N'C7', 27600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10342, N'C8', 27600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10343, N'C9', 27600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10344, N'C10', 27600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10345, N'C11', 27600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10346, N'C12', 27600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10347, N'C13', 27600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10348, N'C14', 27600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10349, N'C15', 27600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10350, N'C16', 27600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10351, N'C17', 27600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10352, N'C18', 27600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10353, N'C19', 27600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10354, N'C20', 27600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10355, N'C21', 27600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10356, N'C22', 27600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10357, N'C23', 27600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10358, N'C24', 27600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10359, N'C25', 27600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10360, N'C26', 27600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10361, N'C27', 27600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10362, N'C28', 27600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10363, N'C29', 27600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10364, N'C30', 27600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10365, N'D1', 29900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10366, N'D2', 29900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10367, N'D3', 29900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10368, N'D4', 29900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10369, N'D5', 29900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10370, N'D6', 29900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10371, N'D7', 29900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10372, N'D8', 29900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10373, N'D9', 29900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10374, N'D10', 29900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10375, N'D11', 29900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10376, N'D12', 29900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10377, N'D13', 29900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10378, N'D14', 29900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10379, N'D15', 29900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10380, N'D16', 29900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10381, N'D17', 29900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10382, N'D18', 29900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10383, N'D19', 29900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10384, N'D20', 29900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10385, N'D21', 29900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10386, N'D22', 29900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10387, N'D23', 29900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10388, N'D24', 29900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10389, N'D25', 29900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10390, N'D26', 29900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10391, N'D27', 29900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10392, N'D28', 29900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10393, N'D29', 29900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10394, N'D30', 29900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10395, N'E1', 32200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10396, N'E2', 32200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10397, N'E3', 32200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10398, N'E4', 32200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10399, N'E5', 32200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10400, N'E6', 32200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10401, N'E7', 32200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10402, N'E8', 32200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10403, N'E9', 32200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10404, N'E10', 32200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10405, N'E11', 32200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10406, N'E12', 32200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10407, N'E13', 32200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10408, N'E14', 32200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10409, N'E15', 32200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10410, N'E16', 32200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10411, N'E17', 32200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10412, N'E18', 32200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10413, N'E19', 32200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10414, N'E20', 32200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10415, N'E21', 32200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10416, N'E22', 32200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10417, N'E23', 32200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10418, N'E24', 32200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10419, N'E25', 32200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10420, N'E26', 32200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10421, N'E27', 32200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10422, N'E28', 32200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10423, N'E29', 32200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10424, N'E30', 32200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10425, N'F1', 34500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10426, N'F2', 34500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10427, N'F3', 34500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10428, N'F4', 34500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10429, N'F5', 34500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10430, N'F6', 34500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10431, N'F7', 34500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10432, N'F8', 34500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10433, N'F9', 34500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10434, N'F10', 34500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10435, N'F11', 34500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10436, N'F12', 34500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10437, N'F13', 34500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10438, N'F14', 34500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10439, N'F15', 34500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10440, N'F16', 34500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10441, N'F17', 34500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10442, N'F18', 34500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10443, N'F19', 34500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10444, N'F20', 34500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10445, N'F21', 34500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10446, N'F22', 34500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10447, N'F23', 34500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10448, N'F24', 34500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10449, N'F25', 34500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10450, N'F26', 34500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10451, N'F27', 34500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10452, N'F28', 34500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10453, N'F29', 34500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10454, N'F30', 34500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10455, N'G1', 36800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10456, N'G2', 36800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10457, N'G3', 36800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10458, N'G4', 36800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10459, N'G5', 36800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10460, N'G6', 36800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10461, N'G7', 36800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10462, N'G8', 36800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10463, N'G9', 36800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10464, N'G10', 36800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10465, N'G11', 36800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10466, N'G12', 36800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10467, N'G13', 36800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10468, N'G14', 36800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10469, N'G15', 36800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10470, N'G16', 36800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10471, N'G17', 36800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10472, N'G18', 36800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10473, N'G19', 36800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10474, N'G20', 36800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10475, N'G21', 36800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10476, N'G22', 36800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10477, N'G23', 36800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10478, N'G24', 36800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10479, N'G25', 36800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10480, N'G26', 36800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10481, N'G27', 36800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10482, N'G28', 36800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10483, N'G29', 36800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10484, N'G30', 36800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10485, N'H1', 39100.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10486, N'H2', 39100.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10487, N'H3', 39100.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10488, N'H4', 39100.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10489, N'H5', 39100.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10490, N'H6', 39100.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10491, N'H7', 39100.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10492, N'H8', 39100.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10493, N'H9', 39100.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10494, N'H10', 39100.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10495, N'H11', 39100.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10496, N'H12', 39100.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10497, N'H13', 39100.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10498, N'H14', 39100.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10499, N'H15', 39100.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10500, N'H16', 39100.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10501, N'H17', 39100.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10502, N'H18', 39100.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10503, N'H19', 39100.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10504, N'H20', 39100.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10505, N'H21', 39100.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10506, N'H22', 39100.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10507, N'H23', 39100.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10508, N'H24', 39100.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10509, N'H25', 39100.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10510, N'H26', 39100.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10511, N'H27', 39100.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10512, N'H28', 39100.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10513, N'H29', 39100.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10514, N'H30', 39100.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10515, N'I1', 41400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10516, N'I2', 41400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10517, N'I3', 41400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10518, N'I4', 41400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10519, N'I5', 41400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10520, N'I6', 41400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10521, N'I7', 41400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10522, N'I8', 41400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10523, N'I9', 41400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10524, N'I10', 41400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10525, N'I11', 41400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10526, N'I12', 41400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10527, N'I13', 41400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10528, N'I14', 41400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10529, N'I15', 41400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10530, N'I16', 41400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10531, N'I17', 41400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10532, N'I18', 41400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10533, N'I19', 41400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10534, N'I20', 41400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10535, N'I21', 41400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10536, N'I22', 41400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10537, N'I23', 41400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10538, N'I24', 41400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10539, N'I25', 41400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10540, N'I26', 41400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10541, N'I27', 41400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10542, N'I28', 41400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10543, N'I29', 41400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10544, N'I30', 41400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10545, N'J1', 43700.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10546, N'J2', 43700.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10547, N'J3', 43700.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10548, N'J4', 43700.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10549, N'J5', 43700.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10550, N'J6', 43700.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10551, N'J7', 43700.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10552, N'J8', 43700.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10553, N'J9', 43700.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10554, N'J10', 43700.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10555, N'J11', 43700.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10556, N'J12', 43700.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10557, N'J13', 43700.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10558, N'J14', 43700.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10559, N'J15', 43700.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10560, N'J16', 43700.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10561, N'J17', 43700.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10562, N'J18', 43700.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10563, N'J19', 43700.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10564, N'J20', 43700.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10565, N'J21', 43700.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10566, N'J22', 43700.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10567, N'J23', 43700.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10568, N'J24', 43700.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10569, N'J25', 43700.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10570, N'J26', 43700.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10571, N'J27', 43700.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10572, N'J28', 43700.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10573, N'J29', 43700.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10574, N'J30', 43700.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10575, N'K1', 46000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10576, N'K2', 46000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10577, N'K3', 46000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10578, N'K4', 46000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10579, N'K5', 46000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10580, N'K6', 46000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10581, N'K7', 46000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10582, N'K8', 46000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10583, N'K9', 46000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10584, N'K10', 46000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10585, N'K11', 46000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10586, N'K12', 46000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10587, N'K13', 46000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10588, N'K14', 46000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10589, N'K15', 46000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10590, N'K16', 46000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10591, N'K17', 46000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10592, N'K18', 46000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10593, N'K19', 46000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10594, N'K20', 46000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10595, N'K21', 46000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10596, N'K22', 46000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10597, N'K23', 46000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10598, N'K24', 46000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10599, N'K25', 46000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10600, N'K26', 46000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10601, N'K27', 46000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10602, N'K28', 46000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10603, N'K29', 46000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10604, N'K30', 46000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10605, N'L1', 48300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10606, N'L2', 48300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10607, N'L3', 48300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10608, N'L4', 48300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10609, N'L5', 48300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10610, N'L6', 48300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10611, N'L7', 48300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10612, N'L8', 48300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10613, N'L9', 48300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10614, N'L10', 48300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10615, N'L11', 48300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10616, N'L12', 48300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10617, N'L13', 48300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10618, N'L14', 48300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10619, N'L15', 48300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10620, N'L16', 48300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10621, N'L17', 48300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10622, N'L18', 48300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10623, N'L19', 48300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10624, N'L20', 48300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10625, N'L21', 48300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10626, N'L22', 48300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10627, N'L23', 48300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10628, N'L24', 48300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10629, N'L25', 48300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10630, N'L26', 48300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10631, N'L27', 48300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10632, N'L28', 48300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10633, N'L29', 48300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10634, N'L30', 48300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10635, N'M1', 50600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10636, N'M2', 50600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10637, N'M3', 50600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10638, N'M4', 50600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10639, N'M5', 50600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10640, N'M6', 50600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10641, N'M7', 50600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10642, N'M8', 50600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10643, N'M9', 50600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10644, N'M10', 50600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10645, N'M11', 50600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10646, N'M12', 50600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10647, N'M13', 50600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10648, N'M14', 50600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10649, N'M15', 50600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10650, N'M16', 50600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10651, N'M17', 50600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10652, N'M18', 50600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10653, N'M19', 50600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10654, N'M20', 50600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10655, N'M21', 50600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10656, N'M22', 50600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10657, N'M23', 50600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10658, N'M24', 50600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10659, N'M25', 50600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10660, N'M26', 50600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10661, N'M27', 50600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10662, N'M28', 50600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10663, N'M29', 50600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10664, N'M30', 50600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10665, N'N1', 52900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10666, N'N2', 52900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10667, N'N3', 52900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10668, N'N4', 52900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10669, N'N5', 52900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10670, N'N6', 52900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10671, N'N7', 52900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10672, N'N8', 52900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10673, N'N9', 52900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10674, N'N10', 52900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10675, N'N11', 52900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10676, N'N12', 52900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10677, N'N13', 52900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10678, N'N14', 52900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10679, N'N15', 52900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10680, N'N16', 52900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10681, N'N17', 52900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10682, N'N18', 52900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10683, N'N19', 52900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10684, N'N20', 52900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10685, N'N21', 52900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10686, N'N22', 52900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10687, N'N23', 52900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10688, N'N24', 52900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10689, N'N25', 52900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10690, N'N26', 52900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10691, N'N27', 52900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10692, N'N28', 52900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10693, N'N29', 52900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10694, N'N30', 52900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10695, N'O1', 55200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10696, N'O2', 55200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10697, N'O3', 55200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10698, N'O4', 55200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10699, N'O5', 55200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10700, N'O6', 55200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10701, N'O7', 55200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10702, N'O8', 55200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10703, N'O9', 55200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10704, N'O10', 55200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10705, N'O11', 55200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10706, N'O12', 55200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10707, N'O13', 55200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10708, N'O14', 55200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10709, N'O15', 55200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10710, N'O16', 55200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10711, N'O17', 55200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10712, N'O18', 55200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10713, N'O19', 55200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10714, N'O20', 55200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10715, N'O21', 55200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10716, N'O22', 55200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10717, N'O23', 55200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10718, N'O24', 55200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10719, N'O25', 55200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10720, N'O26', 55200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10721, N'O27', 55200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10722, N'O28', 55200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10723, N'O29', 55200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10724, N'O30', 55200.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10725, N'P1', 57500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10726, N'P2', 57500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10727, N'P3', 57500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10728, N'P4', 57500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10729, N'P5', 57500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10730, N'P6', 57500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10731, N'P7', 57500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10732, N'P8', 57500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10733, N'P9', 57500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10734, N'P10', 57500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10735, N'P11', 57500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10736, N'P12', 57500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10737, N'P13', 57500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10738, N'P14', 57500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10739, N'P15', 57500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10740, N'P16', 57500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10741, N'P17', 57500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10742, N'P18', 57500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10743, N'P19', 57500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10744, N'P20', 57500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10745, N'P21', 57500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10746, N'P22', 57500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10747, N'P23', 57500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10748, N'P24', 57500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10749, N'P25', 57500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10750, N'P26', 57500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10751, N'P27', 57500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10752, N'P28', 57500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10753, N'P29', 57500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10754, N'P30', 57500.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10755, N'Q1', 59800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10756, N'Q2', 59800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10757, N'Q3', 59800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10758, N'Q4', 59800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10759, N'Q5', 59800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10760, N'Q6', 59800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10761, N'Q7', 59800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10762, N'Q8', 59800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10763, N'Q9', 59800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10764, N'Q10', 59800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10765, N'Q11', 59800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10766, N'Q12', 59800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10767, N'Q13', 59800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10768, N'Q14', 59800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10769, N'Q15', 59800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10770, N'Q16', 59800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10771, N'Q17', 59800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10772, N'Q18', 59800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10773, N'Q19', 59800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10774, N'Q20', 59800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10775, N'Q21', 59800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10776, N'Q22', 59800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10777, N'Q23', 59800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10778, N'Q24', 59800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10779, N'Q25', 59800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10780, N'Q26', 59800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10781, N'Q27', 59800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10782, N'Q28', 59800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10783, N'Q29', 59800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10784, N'Q30', 59800.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10785, N'R1', 62100.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10786, N'R2', 62100.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10787, N'R3', 62100.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10788, N'R4', 62100.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10789, N'R5', 62100.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10790, N'R6', 62100.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10791, N'R7', 62100.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10792, N'R8', 62100.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10793, N'R9', 62100.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10794, N'R10', 62100.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10795, N'R11', 62100.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10796, N'R12', 62100.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10797, N'R13', 62100.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10798, N'R14', 62100.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10799, N'R15', 62100.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10800, N'R16', 62100.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10801, N'R17', 62100.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10802, N'R18', 62100.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10803, N'R19', 62100.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10804, N'R20', 62100.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10805, N'R21', 62100.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10806, N'R22', 62100.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10807, N'R23', 62100.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10808, N'R24', 62100.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10809, N'R25', 62100.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10810, N'R26', 62100.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10811, N'R27', 62100.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10812, N'R28', 62100.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10813, N'R29', 62100.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10814, N'R30', 62100.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10815, N'S1', 64400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10816, N'S2', 64400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10817, N'S3', 64400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10818, N'S4', 64400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10819, N'S5', 64400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10820, N'S6', 64400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10821, N'S7', 64400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10822, N'S8', 64400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10823, N'S9', 64400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10824, N'S10', 64400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10825, N'S11', 64400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10826, N'S12', 64400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10827, N'S13', 64400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10828, N'S14', 64400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10829, N'S15', 64400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10830, N'S16', 64400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10831, N'S17', 64400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10832, N'S18', 64400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10833, N'S19', 64400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10834, N'S20', 64400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10835, N'S21', 64400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10836, N'S22', 64400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10837, N'S23', 64400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10838, N'S24', 64400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10839, N'S25', 64400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10840, N'S26', 64400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10841, N'S27', 64400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10842, N'S28', 64400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10843, N'S29', 64400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10844, N'S30', 64400.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10845, N'T1', 66700.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10846, N'T2', 66700.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10847, N'T3', 66700.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10848, N'T4', 66700.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10849, N'T5', 66700.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10850, N'T6', 66700.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10851, N'T7', 66700.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10852, N'T8', 66700.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10853, N'T9', 66700.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10854, N'T10', 66700.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10855, N'T11', 66700.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10856, N'T12', 66700.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10857, N'T13', 66700.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10858, N'T14', 66700.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10859, N'T15', 66700.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10860, N'T16', 66700.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10861, N'T17', 66700.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10862, N'T18', 66700.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10863, N'T19', 66700.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10864, N'T20', 66700.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10865, N'T21', 66700.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10866, N'T22', 66700.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10867, N'T23', 66700.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10868, N'T24', 66700.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10869, N'T25', 66700.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10870, N'T26', 66700.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10871, N'T27', 66700.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10872, N'T28', 66700.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10873, N'T29', 66700.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10874, N'T30', 66700.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10875, N'U1', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10876, N'U2', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10877, N'U3', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10878, N'U4', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10879, N'U5', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10880, N'U6', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10881, N'U7', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10882, N'U8', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10883, N'U9', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10884, N'U10', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10885, N'U11', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10886, N'U12', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10887, N'U13', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10888, N'U14', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10889, N'U15', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10890, N'U16', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10891, N'U17', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10892, N'U18', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10893, N'U19', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10894, N'U20', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10895, N'U21', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10896, N'U22', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10897, N'U23', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10898, N'U24', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10899, N'U25', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10900, N'U26', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10901, N'U27', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10902, N'U28', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10903, N'U29', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10904, N'U30', 69000.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10905, N'V1', 71300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10906, N'V2', 71300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10907, N'V3', 71300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10908, N'V4', 71300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10909, N'V5', 71300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10910, N'V6', 71300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10911, N'V7', 71300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10912, N'V8', 71300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10913, N'V9', 71300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10914, N'V10', 71300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10915, N'V11', 71300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10916, N'V12', 71300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10917, N'V13', 71300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10918, N'V14', 71300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10919, N'V15', 71300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10920, N'V16', 71300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10921, N'V17', 71300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10922, N'V18', 71300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10923, N'V19', 71300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10924, N'V20', 71300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10925, N'V21', 71300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10926, N'V22', 71300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10927, N'V23', 71300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10928, N'V24', 71300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10929, N'V25', 71300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10930, N'V26', 71300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10931, N'V27', 71300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10932, N'V28', 71300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10933, N'V29', 71300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10934, N'V30', 71300.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10935, N'W1', 73600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10936, N'W2', 73600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10937, N'W3', 73600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10938, N'W4', 73600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10939, N'W5', 73600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10940, N'W6', 73600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10941, N'W7', 73600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10942, N'W8', 73600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10943, N'W9', 73600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10944, N'W10', 73600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10945, N'W11', 73600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10946, N'W12', 73600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10947, N'W13', 73600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10948, N'W14', 73600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10949, N'W15', 73600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10950, N'W16', 73600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10951, N'W17', 73600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10952, N'W18', 73600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10953, N'W19', 73600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10954, N'W20', 73600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10955, N'W21', 73600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10956, N'W22', 73600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10957, N'W23', 73600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10958, N'W24', 73600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10959, N'W25', 73600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10960, N'W26', 73600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10961, N'W27', 73600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10962, N'W28', 73600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10963, N'W29', 73600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10964, N'W30', 73600.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10965, N'X1', 75900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10966, N'X2', 75900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10967, N'X3', 75900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10968, N'X4', 75900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10969, N'X5', 75900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10970, N'X6', 75900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10971, N'X7', 75900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10972, N'X8', 75900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10973, N'X9', 75900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10974, N'X10', 75900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10975, N'X11', 75900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10976, N'X12', 75900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10977, N'X13', 75900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10978, N'X14', 75900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10979, N'X15', 75900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10980, N'X16', 75900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10981, N'X17', 75900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10982, N'X18', 75900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10983, N'X19', 75900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10984, N'X20', 75900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10985, N'X21', 75900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10986, N'X22', 75900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10987, N'X23', 75900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10988, N'X24', 75900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10989, N'X25', 75900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10990, N'X26', 75900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10991, N'X27', 75900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10992, N'X28', 75900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10993, N'X29', 75900.0000, 0, NULL)
GO
INSERT [dbo].[TICKET] ([ScheduleID], [TrainID], [TicketID], [SeatNo], [TicketPrice], [Booked], [CustomerUN]) VALUES (31, 2, 10994, N'X30', 75900.0000, 0, NULL)
GO
SET IDENTITY_INSERT [dbo].[TICKET] OFF
GO
SET IDENTITY_INSERT [dbo].[SECURITY] ON 
GO
INSERT [dbo].[SECURITY] ([SecurityID], [Question], [Answer], [OwnUN]) VALUES (1, N'Bạn thích đến đâu nhất?', N'Việt Nam', N'DangHoan')
GO
INSERT [dbo].[SECURITY] ([SecurityID], [Question], [Answer], [OwnUN]) VALUES (2, N'Bạn ấn tượng bộ phim nào nhất?', N'Harry Potter', N'DangHoan')
GO
INSERT [dbo].[SECURITY] ([SecurityID], [Question], [Answer], [OwnUN]) VALUES (3, N'Bạn thích môn thể thao nào nhât?', N'Đá bóng', N'NhuPhong')
GO
INSERT [dbo].[SECURITY] ([SecurityID], [Question], [Answer], [OwnUN]) VALUES (4, N'Bạn thích làm gì khi rảnh?', N'Đi phượt', N'TriDuc')
GO
INSERT [dbo].[SECURITY] ([SecurityID], [Question], [Answer], [OwnUN]) VALUES (5, N'Bạn đam mê điều gì?', N'Lập trình', N'DangHoan')
GO
INSERT [dbo].[SECURITY] ([SecurityID], [Question], [Answer], [OwnUN]) VALUES (7, N'Tôi là ai?', N'Giám đốc công ty', N'admin1')
GO
SET IDENTITY_INSERT [dbo].[SECURITY] OFF
GO
SET IDENTITY_INSERT [dbo].[NOTICE] ON 
GO
INSERT [dbo].[NOTICE] ([NoticeID], [Title], [Content]) VALUES (1, N'GIẢM TIỀN VÉ TRONG HÈ', N'Vé đi tàu sẽ được giảm từ ngày 15-07-2022 đến hết ngày 20-08-2022 nhằm tạo điều kiện để khách hàng giảm tiền đi lại khi về quê hay đi du lịch trong hè!')
GO
INSERT [dbo].[NOTICE] ([NoticeID], [Title], [Content]) VALUES (2, N'Thông báo thời tiết', N'Dự báo nhiều chuyến tàu dừng khởi hành vì mưa bão')
GO
INSERT [dbo].[NOTICE] ([NoticeID], [Title], [Content]) VALUES (3, N'Tiêu đề 1', N'Nội dung 1')
GO
INSERT [dbo].[NOTICE] ([NoticeID], [Title], [Content]) VALUES (4, N'Điêu kien thoi tiet', N'bão gió lớn')
GO
INSERT [dbo].[NOTICE] ([NoticeID], [Title], [Content]) VALUES (5, N'vân dè 1', N'bão')
GO
SET IDENTITY_INSERT [dbo].[NOTICE] OFF
GO
