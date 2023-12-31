USE [OkulOtomasyon]
GO
/****** Object:  Table [dbo].[TBL_OGRETMENLER]    Script Date: 27.06.2023 17:12:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_OGRETMENLER](
	[OGRTID] [int] IDENTITY(1,1) NOT NULL,
	[OGRTAD] [varchar](30) NULL,
	[OGRTSOYAD] [varchar](30) NULL,
	[OGRTTC] [char](11) NULL,
	[OGRTTEL] [char](15) NULL,
	[OGRTMAIL] [varchar](40) NULL,
	[OGRTIL] [varchar](20) NULL,
	[OGRTILCE] [varchar](20) NULL,
	[OGRTADRES] [varchar](100) NULL,
	[OGRTBRANS] [varchar](50) NULL,
	[OGRTFOTO] [varchar](500) NULL,
 CONSTRAINT [PK_TBL_OGRETMENLER] PRIMARY KEY CLUSTERED 
(
	[OGRTID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [OkulOtomasyon] SET  READ_WRITE 
GO
