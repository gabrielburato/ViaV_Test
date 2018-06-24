 USE [ViaVarejo]
GO

/****** Object:  Table [dbo].[CalculoHistoricoLog]    Script Date: 24/06/2018 18:48:34 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CalculoHistoricoLog](
	[Id_Historico] [int] IDENTITY(1,1) NOT NULL,
	[Calculo] [varchar](200) NULL,
	[Resultado] [varchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Historico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


