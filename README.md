# Chatroom
Chatroom test

1. Create a new database "StockChatroomDB" in SQLServer and create a new table with the following:

USE [StockChatroomDB]
GO

/****** Object:  Table [dbo].[Users]    Script Date: 19/04/2021 10:51:16 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Users](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[Login] [varchar](50) NOT NULL,
	[Password] [varchar](200) NOT NULL,
	[Rol] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

2. Set the ConnectionStrings in the appsettings.json file inside the project:

"ConnectionStrings": {
    "StockChatroomDB": "Server=******;Database=StockChatroomDB;Integrated Security=True;"
  }
