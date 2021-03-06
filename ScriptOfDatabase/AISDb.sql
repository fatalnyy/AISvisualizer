USE [AISDb]
GO
/****** Object:  UserDefinedTableType [dbo].[message_type_123_table_type]    Script Date: 7/5/2020 7:48:45 PM ******/
CREATE TYPE [dbo].[message_type_123_table_type] AS TABLE(
	[Id] [int] NOT NULL,
	[Date] [datetime2](7) NULL,
	[MessageType] [nvarchar](max) NULL,
	[Repeat] [smallint] NOT NULL,
	[MMSI] [bigint] NOT NULL,
	[Packet] [nvarchar](max) NULL,
	[Channel] [nvarchar](max) NULL,
	[Country] [nvarchar](max) NULL,
	[Status] [nvarchar](max) NULL,
	[ROT] [float] NULL,
	[SOG] [float] NULL,
	[Accuracy] [nvarchar](max) NULL,
	[Longitude] [float] NOT NULL,
	[Latitude] [float] NOT NULL,
	[COG] [float] NULL,
	[HDG] [smallint] NULL,
	[Timestamp] [smallint] NOT NULL,
	[Maneuver] [nvarchar](max) NULL,
	[Spare] [smallint] NOT NULL,
	[RAIM] [nvarchar](max) NULL,
	[RadioStatus] [int] NOT NULL,
	[Type] [nvarchar](max) NOT NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[message_type_21_table_type]    Script Date: 7/5/2020 7:48:45 PM ******/
CREATE TYPE [dbo].[message_type_21_table_type] AS TABLE(
	[Id] [int] NOT NULL,
	[Date] [datetime2](7) NULL,
	[MessageType] [nvarchar](max) NULL,
	[Repeat] [smallint] NOT NULL,
	[MMSI] [bigint] NOT NULL,
	[Packet] [nvarchar](max) NULL,
	[Channel] [nvarchar](max) NULL,
	[Country] [nvarchar](max) NULL,
	[AidType] [nvarchar](max) NULL,
	[Name] [nvarchar](max) NULL,
	[Accuracy] [nvarchar](max) NULL,
	[Longitude] [float] NOT NULL,
	[Latitude] [float] NOT NULL,
	[DimensionToBow] [smallint] NOT NULL,
	[DimensionToStern] [smallint] NOT NULL,
	[DimensionToPort] [smallint] NOT NULL,
	[DimensionToStarboard] [smallint] NOT NULL,
	[EPFD] [nvarchar](max) NULL,
	[Second] [smallint] NOT NULL,
	[OffPosition] [nvarchar](max) NULL,
	[Reserved] [smallint] NOT NULL,
	[Spare] [smallint] NOT NULL,
	[RAIM] [nvarchar](max) NULL,
	[VirtualAidFlag] [nvarchar](max) NULL,
	[Assigned] [nvarchar](max) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[message_type_4_table_type]    Script Date: 7/5/2020 7:48:45 PM ******/
CREATE TYPE [dbo].[message_type_4_table_type] AS TABLE(
	[Id] [int] NOT NULL,
	[Date] [datetime2](7) NULL,
	[MessageType] [nvarchar](max) NULL,
	[Repeat] [smallint] NOT NULL,
	[MMSI] [bigint] NOT NULL,
	[Packet] [nvarchar](max) NULL,
	[Channel] [nvarchar](max) NULL,
	[Country] [nvarchar](max) NULL,
	[Year] [smallint] NOT NULL,
	[Month] [smallint] NOT NULL,
	[Day] [smallint] NOT NULL,
	[Hour] [smallint] NOT NULL,
	[Minute] [smallint] NOT NULL,
	[Second] [smallint] NOT NULL,
	[FixQuality] [nvarchar](max) NULL,
	[Longitude] [float] NOT NULL,
	[Latitude] [float] NOT NULL,
	[EPFD] [nvarchar](max) NULL,
	[RAIM] [nvarchar](max) NULL,
	[Spare] [smallint] NOT NULL,
	[RadioStatus] [int] NOT NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[message_type_5_table_type]    Script Date: 7/5/2020 7:48:45 PM ******/
CREATE TYPE [dbo].[message_type_5_table_type] AS TABLE(
	[Id] [int] NOT NULL,
	[Date] [datetime2](7) NULL,
	[MessageType] [nvarchar](max) NULL,
	[Repeat] [smallint] NOT NULL,
	[MMSI] [bigint] NOT NULL,
	[Packet] [nvarchar](max) NULL,
	[Channel] [nvarchar](max) NULL,
	[Country] [nvarchar](max) NULL,
	[AisVersion] [nvarchar](max) NULL,
	[ImoNumber] [bigint] NOT NULL,
	[CallSign] [nvarchar](max) NULL,
	[VesselName] [nvarchar](max) NULL,
	[ShipType] [nvarchar](max) NULL,
	[DimensionToBow] [smallint] NOT NULL,
	[DimensionToStern] [smallint] NOT NULL,
	[DimensionToPort] [smallint] NOT NULL,
	[DimensionToStarboard] [smallint] NOT NULL,
	[EPFD] [nvarchar](max) NULL,
	[Month] [smallint] NULL,
	[Day] [smallint] NULL,
	[Hour] [smallint] NULL,
	[Minute] [smallint] NULL,
	[Draught] [float] NOT NULL,
	[Destination] [nvarchar](max) NULL,
	[Spare] [smallint] NOT NULL,
	[DTE] [nvarchar](max) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[message_type_9_table_type]    Script Date: 7/5/2020 7:48:45 PM ******/
CREATE TYPE [dbo].[message_type_9_table_type] AS TABLE(
	[Id] [int] NOT NULL,
	[Date] [datetime2](7) NULL,
	[MessageType] [nvarchar](max) NULL,
	[Repeat] [smallint] NOT NULL,
	[MMSI] [bigint] NOT NULL,
	[Packet] [nvarchar](max) NULL,
	[Channel] [nvarchar](max) NULL,
	[Country] [nvarchar](max) NULL,
	[Altitude] [nvarchar](max) NULL,
	[SOG] [float] NULL,
	[Accuracy] [nvarchar](max) NULL,
	[Longitude] [float] NOT NULL,
	[Latitude] [float] NOT NULL,
	[COG] [float] NULL,
	[Timestamp] [smallint] NULL,
	[Reserved] [smallint] NULL,
	[DTE] [nvarchar](max) NULL,
	[Assigned] [nvarchar](max) NULL,
	[RAIM] [nvarchar](max) NULL,
	[Spare] [smallint] NOT NULL,
	[RadioStatus] [int] NOT NULL
)
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 7/5/2020 7:48:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MessagesType1]    Script Date: 7/5/2020 7:48:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MessagesType1](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Date] [datetime2](7) NULL,
	[MessageType] [nvarchar](max) NULL,
	[Repeat] [smallint] NOT NULL,
	[MMSI] [bigint] NOT NULL,
	[Packet] [nvarchar](max) NULL,
	[Channel] [nvarchar](max) NULL,
	[Country] [nvarchar](max) NULL,
	[Status] [nvarchar](max) NULL,
	[ROT] [float] NULL,
	[SOG] [float] NULL,
	[Accuracy] [nvarchar](max) NULL,
	[Longitude] [float] NOT NULL,
	[Latitude] [float] NOT NULL,
	[COG] [float] NULL,
	[HDG] [smallint] NULL,
	[Timestamp] [smallint] NOT NULL,
	[Maneuver] [nvarchar](max) NULL,
	[Spare] [smallint] NOT NULL,
	[RAIM] [nvarchar](max) NULL,
	[RadioStatus] [int] NOT NULL,
	[Type] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_MessagesType1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MessagesType21]    Script Date: 7/5/2020 7:48:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MessagesType21](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Date] [datetime2](7) NULL,
	[MessageType] [nvarchar](max) NULL,
	[Repeat] [smallint] NOT NULL,
	[MMSI] [bigint] NOT NULL,
	[Packet] [nvarchar](max) NULL,
	[Channel] [nvarchar](max) NULL,
	[Country] [nvarchar](max) NULL,
	[AidType] [nvarchar](max) NULL,
	[Name] [nvarchar](max) NULL,
	[Accuracy] [nvarchar](max) NULL,
	[Longitude] [float] NOT NULL,
	[Latitude] [float] NOT NULL,
	[DimensionToBow] [smallint] NOT NULL,
	[DimensionToStern] [smallint] NOT NULL,
	[DimensionToPort] [smallint] NOT NULL,
	[DimensionToStarboard] [smallint] NOT NULL,
	[EPFD] [nvarchar](max) NULL,
	[Second] [smallint] NOT NULL,
	[OffPosition] [nvarchar](max) NULL,
	[Reserved] [smallint] NOT NULL,
	[Spare] [smallint] NOT NULL,
	[RAIM] [nvarchar](max) NULL,
	[VirtualAidFlag] [nvarchar](max) NULL,
	[Assigned] [nvarchar](max) NULL,
 CONSTRAINT [PK_MessagesType21] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MessagesType4]    Script Date: 7/5/2020 7:48:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MessagesType4](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Date] [datetime2](7) NULL,
	[MessageType] [nvarchar](max) NULL,
	[Repeat] [smallint] NOT NULL,
	[MMSI] [bigint] NOT NULL,
	[Packet] [nvarchar](max) NULL,
	[Channel] [nvarchar](max) NULL,
	[Country] [nvarchar](max) NULL,
	[Year] [smallint] NOT NULL,
	[Month] [smallint] NOT NULL,
	[Day] [smallint] NOT NULL,
	[Hour] [smallint] NOT NULL,
	[Minute] [smallint] NOT NULL,
	[Second] [smallint] NOT NULL,
	[FixQuality] [nvarchar](max) NULL,
	[Longitude] [float] NOT NULL,
	[Latitude] [float] NOT NULL,
	[EPFD] [nvarchar](max) NULL,
	[RAIM] [nvarchar](max) NULL,
	[Spare] [smallint] NOT NULL,
	[RadioStatus] [int] NOT NULL,
 CONSTRAINT [PK_MessagesType4] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MessagesType5]    Script Date: 7/5/2020 7:48:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MessagesType5](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Date] [datetime2](7) NULL,
	[MessageType] [nvarchar](max) NULL,
	[Repeat] [smallint] NOT NULL,
	[MMSI] [bigint] NOT NULL,
	[Packet] [nvarchar](max) NULL,
	[Channel] [nvarchar](max) NULL,
	[Country] [nvarchar](max) NULL,
	[AisVersion] [nvarchar](max) NULL,
	[ImoNumber] [bigint] NOT NULL,
	[CallSign] [nvarchar](max) NULL,
	[VesselName] [nvarchar](max) NULL,
	[ShipType] [nvarchar](max) NULL,
	[DimensionToBow] [smallint] NOT NULL,
	[DimensionToStern] [smallint] NOT NULL,
	[DimensionToPort] [smallint] NOT NULL,
	[DimensionToStarboard] [smallint] NOT NULL,
	[EPFD] [nvarchar](max) NULL,
	[Month] [smallint] NULL,
	[Day] [smallint] NULL,
	[Hour] [smallint] NULL,
	[Minute] [smallint] NULL,
	[Draught] [float] NOT NULL,
	[Destination] [nvarchar](max) NULL,
	[Spare] [smallint] NOT NULL,
	[DTE] [nvarchar](max) NULL,
 CONSTRAINT [PK_MessagesType5] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MessagesType9]    Script Date: 7/5/2020 7:48:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MessagesType9](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Date] [datetime2](7) NULL,
	[MessageType] [nvarchar](max) NULL,
	[Repeat] [smallint] NOT NULL,
	[MMSI] [bigint] NOT NULL,
	[Packet] [nvarchar](max) NULL,
	[Channel] [nvarchar](max) NULL,
	[Country] [nvarchar](max) NULL,
	[Altitude] [nvarchar](max) NULL,
	[SOG] [float] NULL,
	[Accuracy] [nvarchar](max) NULL,
	[Longitude] [float] NOT NULL,
	[Latitude] [float] NOT NULL,
	[COG] [float] NULL,
	[Timestamp] [smallint] NOT NULL,
	[Reserved] [smallint] NOT NULL,
	[DTE] [nvarchar](max) NULL,
	[Assigned] [nvarchar](max) NULL,
	[RAIM] [nvarchar](max) NULL,
	[Spare] [smallint] NOT NULL,
	[RadioStatus] [int] NOT NULL,
 CONSTRAINT [PK_MessagesType9] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[MessagesType4] ADD  CONSTRAINT [DF__MessagesTy__Year__73BA3083]  DEFAULT (CONVERT([smallint],(0))) FOR [Year]
GO
ALTER TABLE [dbo].[MessagesType4] ADD  CONSTRAINT [DF__MessagesT__Month__71D1E811]  DEFAULT (CONVERT([smallint],(0))) FOR [Month]
GO
ALTER TABLE [dbo].[MessagesType4] ADD  CONSTRAINT [DF__MessagesTyp__Day__6EF57B66]  DEFAULT (CONVERT([smallint],(0))) FOR [Day]
GO
ALTER TABLE [dbo].[MessagesType4] ADD  CONSTRAINT [DF__MessagesTy__Hour__6FE99F9F]  DEFAULT (CONVERT([smallint],(0))) FOR [Hour]
GO
ALTER TABLE [dbo].[MessagesType4] ADD  CONSTRAINT [DF__MessagesT__Minut__70DDC3D8]  DEFAULT (CONVERT([smallint],(0))) FOR [Minute]
GO
ALTER TABLE [dbo].[MessagesType4] ADD  CONSTRAINT [DF__MessagesT__Secon__72C60C4A]  DEFAULT (CONVERT([smallint],(0))) FOR [Second]
GO
/****** Object:  StoredProcedure [dbo].[prc_addMessageType123]    Script Date: 7/5/2020 7:48:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Adam Penczek
-- Create date: 28.03.2020
-- Description:	Procedure which adds data to MessageType1 Table
-- =============================================
CREATE PROCEDURE [dbo].[prc_addMessageType123](
		@i_dt message_type_123_table_type READONLY,
		@i_iud varchar(10))
AS
BEGIN
	SET NOCOUNT ON;
	DECLARE @o_result bigint
	--
    IF @i_iud = 'add'
	BEGIN
		BEGIN TRANSACTION [TranAISmessages]
			BEGIN TRY
				INSERT INTO MessagesType1(Date, MessageType, Repeat, MMSI, Packet, Channel, Country, Status, ROT, SOG,
									Accuracy, Longitude, Latitude, COG, HDG, Timestamp, Maneuver, Spare, RAIM,
									RadioStatus, Type)
				SELECT Date, MessageType, Repeat, MMSI, Packet, Channel, Country, Status, ROT, SOG,
									Accuracy, Longitude, Latitude, COG, HDG, Timestamp, Maneuver, Spare, RAIM,
									RadioStatus, Type
				FROM @i_dt;
				--
				SET @o_result = SCOPE_IDENTITY()
				--
				COMMIT TRANSACTION [TranAISmessages]
				--
				RETURN @o_result; 
 			END TRY
  			BEGIN CATCH
				ROLLBACK TRANSACTION [TranAISmessages]
			END CATCH
	END;
END

GO
/****** Object:  StoredProcedure [dbo].[prc_addMessageType21]    Script Date: 7/5/2020 7:48:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Adam Penczek
-- Create date: 28.03.2020
-- Description:	Procedure which adds data to MessageType1 Table
-- =============================================
CREATE PROCEDURE [dbo].[prc_addMessageType21](
		@i_dt message_type_21_table_type READONLY,
		@i_iud varchar(10))
AS
BEGIN
	SET NOCOUNT ON;
	DECLARE @o_result bigint
    IF @i_iud = 'add'
	BEGIN
		BEGIN TRANSACTION [TranAISmessages]
			BEGIN TRY
				INSERT INTO MessagesType21(Date, MessageType, Repeat, MMSI, Packet, Channel, Country, AidType, Name, Accuracy,
											Longitude, Latitude, DimensionToBow, DimensionToStern, DimensionToPort, DimensionToStarboard, EPFD, Second, OffPosition,
											Reserved, Spare, RAIM, VirtualAidFlag, Assigned)
				SELECT Date, MessageType, Repeat, MMSI, Packet, Channel, Country, AidType, Name, Accuracy,
											Longitude, Latitude, DimensionToBow, DimensionToStern, DimensionToPort, DimensionToStarboard, EPFD, Second, OffPosition,
											Reserved, Spare, RAIM, VirtualAidFlag, Assigned
				FROM @i_dt;
				SET @o_result = SCOPE_IDENTITY()
								--
				COMMIT TRANSACTION [TranAISmessages]
				--
				RETURN @o_result; 
 			END TRY
  			BEGIN CATCH
				ROLLBACK TRANSACTION [TranAISmessages]
			END CATCH
	END;
END

GO
/****** Object:  StoredProcedure [dbo].[prc_addMessageType4]    Script Date: 7/5/2020 7:48:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Adam Penczek
-- Create date: 28.03.2020
-- Description:	Procedure which adds data to MessageType1 Table
-- =============================================
CREATE PROCEDURE [dbo].[prc_addMessageType4](
		@i_dt message_type_4_table_type READONLY,
		@i_iud varchar(10))
AS
BEGIN
	SET NOCOUNT ON;
	DECLARE @o_result bigint
    IF @i_iud = 'add'
	BEGIN
		BEGIN TRANSACTION [TranAISmessages]
			BEGIN TRY
				INSERT INTO MessagesType4(Date, MessageType, Repeat, MMSI, Packet, Channel, Country, Year, Month, Day,
											Hour, Minute, Second, FixQuality, Longitude, Latitude, EPFD, RAIM, Spare,
											RadioStatus)
				SELECT Date, MessageType, Repeat, MMSI, Packet, Channel, Country, Year, Month, Day,
											Hour, Minute, Second, FixQuality, Longitude, Latitude, EPFD, RAIM, Spare,
											RadioStatus
				FROM @i_dt;
				SET @o_result = SCOPE_IDENTITY()
				--
				COMMIT TRANSACTION [TranAISmessages]
				--
				RETURN @o_result; 
 			END TRY
  			BEGIN CATCH
				ROLLBACK TRANSACTION [TranAISmessages]
			END CATCH
	END;
END

GO
/****** Object:  StoredProcedure [dbo].[prc_addMessageType5]    Script Date: 7/5/2020 7:48:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Adam Penczek
-- Create date: 28.03.2020
-- Description:	Procedure which adds data to MessageType1 Table
-- =============================================
CREATE PROCEDURE [dbo].[prc_addMessageType5](
		@i_dt message_type_5_table_type READONLY,
		@i_iud varchar(10))
AS
BEGIN
	SET NOCOUNT ON;
	DECLARE @o_result bigint
    IF @i_iud = 'add'
	BEGIN
		BEGIN TRANSACTION [TranAISmessages]
			BEGIN TRY
				INSERT INTO MessagesType5(Date, MessageType, Repeat, MMSI, Packet, Channel, Country, AisVersion, ImoNumber, CallSign,
											VesselName, ShipType, DimensionToBow, DimensionToStern, DimensionToPort, DimensionToStarboard, EPFD, Month, Day,
											Hour, Minute, Draught, Destination, Spare, DTE)
				SELECT Date, MessageType, Repeat, MMSI, Packet, Channel, Country, AisVersion, ImoNumber, CallSign,
											VesselName, ShipType, DimensionToBow, DimensionToStern, DimensionToPort, DimensionToStarboard, EPFD, Month, Day,
											Hour, Minute, Draught, Destination, Spare, DTE
				FROM @i_dt;
				SET @o_result = SCOPE_IDENTITY()
				--
				COMMIT TRANSACTION [TranAISmessages]
				--
				RETURN @o_result; 
 			END TRY
  			BEGIN CATCH
				ROLLBACK TRANSACTION [TranAISmessages]
			END CATCH
	END;
END

GO
/****** Object:  StoredProcedure [dbo].[prc_addMessageType9]    Script Date: 7/5/2020 7:48:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Adam Penczek
-- Create date: 28.03.2020
-- Description:	Procedure which adds data to MessageType1 Table
-- =============================================
CREATE PROCEDURE [dbo].[prc_addMessageType9](
		@i_dt message_type_9_table_type READONLY,
		@i_iud varchar(10))
AS
BEGIN
	SET NOCOUNT ON;
	DECLARE @o_result bigint
    IF @i_iud = 'add'
	BEGIN
	BEGIN TRANSACTION [TranAISmessages]
			BEGIN TRY
				INSERT INTO MessagesType9(Date, MessageType, Repeat, MMSI, Packet, Channel, Country, Altitude, SOG, Accuracy,
											Longitude, Latitude, COG, Timestamp, Reserved, DTE, Assigned, RAIM, Spare,
											RadioStatus)
				SELECT Date, MessageType, Repeat, MMSI, Packet, Channel, Country, Altitude, SOG, Accuracy,
											Longitude, Latitude, COG, Timestamp, Reserved, DTE, Assigned, RAIM, Spare,
											RadioStatus
				FROM @i_dt;
				SET @o_result = SCOPE_IDENTITY()
				--
				COMMIT TRANSACTION [TranAISmessages]
				--
				RETURN @o_result; 
 			END TRY
  			BEGIN CATCH
				ROLLBACK TRANSACTION [TranAISmessages]
			END CATCH
	END;
END

GO
