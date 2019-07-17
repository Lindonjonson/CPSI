
CREATE DATABASE [CPSI]
USE [CPSI]
GO
/****** Object:  Table [dbo].[Aluno]    Script Date: 17/07/2019 18:58:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Aluno](
	[IdAluno] [int] NOT NULL,
	[Aluno] [varchar](200) NULL,
	[DataNascimento] [date] NULL,
	[CPF] [varchar](20) NULL,
	[RG] [varchar](20) NULL,
	[RGOrgao] [varchar](200) NULL,
	[EstadoCivil] [int] NULL,
	[Naturalidade] [varchar](200) NULL,
	[NaturalidadeEstado] [char](2) NULL,
	[Endereco] [varchar](200) NULL,
	[Bairro] [varchar](200) NULL,
	[Cidade] [varchar](200) NULL,
	[Estado] [char](2) NULL,
	[Telefone1] [varchar](20) NULL,
	[Telefone2] [varchar](20) NULL,
	[Contato] [varchar](200) NULL,
	[ContatoTelefone] [varchar](100) NULL,
 CONSTRAINT [PK_Aluno] PRIMARY KEY CLUSTERED 
(
	[IdAluno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Matricula]    Script Date: 17/07/2019 18:58:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Matricula](
	[IdTurma] [int] NOT NULL,
	[IdAluno] [int] NOT NULL,
	[Situacao] [int] NULL,
	[DataMatricula] [datetime] NULL,
 CONSTRAINT [PK_Matricula] PRIMARY KEY CLUSTERED 
(
	[IdTurma] ASC,
	[IdAluno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[ViewMatriculadosTurma]    Script Date: 17/07/2019 18:58:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ViewMatriculadosTurma] AS
select Aluno.Aluno,Aluno.CPF, Matricula.Situacao, Matricula.DataMatricula,Matricula.IdAluno, Matricula.IdTurma from Aluno inner join Matricula on Matricula.IdAluno = Aluno.IdAluno 
GO
/****** Object:  Table [dbo].[ListaEspera]    Script Date: 17/07/2019 18:58:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ListaEspera](
	[IdTurma] [int] NOT NULL,
	[IdAluno] [int] NOT NULL,
	[DataInscricao] [datetime] NULL,
 CONSTRAINT [PK_ListaEspera] PRIMARY KEY CLUSTERED 
(
	[IdTurma] ASC,
	[IdAluno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[ViewListaEspera]    Script Date: 17/07/2019 18:58:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ViewListaEspera] AS
 select Aluno.Aluno,Aluno.CPF,ListaEspera.DataInscricao,ListaEspera.IdAluno,ListaEspera.IdTurma from Aluno inner join ListaEspera on ListaEspera.IdAluno = Aluno.IdAluno 
GO
/****** Object:  Table [dbo].[AlunoDocumento]    Script Date: 17/07/2019 18:58:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AlunoDocumento](
	[IdAluno] [int] NOT NULL,
	[IdDocumento] [int] NOT NULL,
	[DataValidade] [date] NULL,
 CONSTRAINT [PK_AlunoDocumento] PRIMARY KEY CLUSTERED 
(
	[IdAluno] ASC,
	[IdDocumento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Atestado]    Script Date: 17/07/2019 18:58:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Atestado](
	[IdAtestado] [int] NOT NULL,
	[IdAluno] [int] NULL,
	[Atestado] [varchar](200) NULL,
	[DataInicio] [date] NULL,
	[DataFim] [date] NULL,
 CONSTRAINT [PK_Atestado] PRIMARY KEY CLUSTERED 
(
	[IdAtestado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Aula]    Script Date: 17/07/2019 18:58:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Aula](
	[IdAula] [int] NOT NULL,
	[IdTurma] [int] NULL,
	[DataAula] [date] NULL,
 CONSTRAINT [PK_Aula] PRIMARY KEY CLUSTERED 
(
	[IdAula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Disciplina]    Script Date: 17/07/2019 18:58:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Disciplina](
	[IdDisciplina] [int] NOT NULL,
	[Disciplina] [varchar](50) NULL,
 CONSTRAINT [PK_Disciplina] PRIMARY KEY CLUSTERED 
(
	[IdDisciplina] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Documento]    Script Date: 17/07/2019 18:58:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Documento](
	[IdDocumento] [int] NOT NULL,
	[Documento] [varchar](50) NULL,
	[TemDataValidade] [bit] NULL,
	[Tipo] [int] NULL,
 CONSTRAINT [PK_Documento] PRIMARY KEY CLUSTERED 
(
	[IdDocumento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DocumentoDisciplina]    Script Date: 17/07/2019 18:58:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DocumentoDisciplina](
	[IdDisciplina] [int] NOT NULL,
	[IdDocumento] [int] NOT NULL,
 CONSTRAINT [PK_DocumentoDisciplina] PRIMARY KEY CLUSTERED 
(
	[IdDisciplina] ASC,
	[IdDocumento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LISTAGERAL]    Script Date: 17/07/2019 18:58:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LISTAGERAL](
	[REGISTRO] [varchar](50) NULL,
	[Coluna 1] [varchar](50) NULL,
	[DADOS PESSOAIS] [varchar](50) NULL,
	[Coluna 3] [varchar](50) NULL,
	[Coluna 4] [varchar](50) NULL,
	[Coluna 5] [varchar](50) NULL,
	[Coluna 6] [varchar](50) NULL,
	[Coluna 7] [varchar](50) NULL,
	[Coluna 8] [varchar](50) NULL,
	[Coluna 9] [varchar](50) NULL,
	[Coluna 10] [varchar](50) NULL,
	[Coluna 11] [varchar](50) NULL,
	[Coluna 12] [varchar](50) NULL,
	[DOCUMENTOS NECESSARIOS] [varchar](50) NULL,
	[Coluna 14] [varchar](50) NULL,
	[Coluna 15] [varchar](50) NULL,
	[Coluna 16] [varchar](50) NULL,
	[Coluna 17] [varchar](50) NULL,
	[Coluna 18] [varchar](50) NULL,
	[MODALIDADES] [varchar](50) NULL,
	[Coluna 20] [varchar](50) NULL,
	[Coluna 21] [varchar](50) NULL,
	[Coluna 22] [varchar](50) NULL,
	[Coluna 23] [varchar](50) NULL,
	[Coluna 24] [varchar](50) NULL,
	[Coluna 25] [varchar](50) NULL,
	[DataNascimento] [date] NULL,
	[id] [int] IDENTITY(1,1) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Presenca]    Script Date: 17/07/2019 18:58:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Presenca](
	[IdAula] [int] NOT NULL,
	[IdAluno] [int] NOT NULL,
 CONSTRAINT [PK_Presenca] PRIMARY KEY CLUSTERED 
(
	[IdAula] ASC,
	[IdAluno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Turma]    Script Date: 17/07/2019 18:58:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Turma](
	[IdTurma] [int] NOT NULL,
	[Turma] [varchar](100) NULL,
	[Ano] [int] NULL,
	[Horario] [varchar](50) NULL,
	[DataInicio] [date] NULL,
	[DataFim] [date] NULL,
	[QtdVagas] [int] NULL,
	[IdDisciplina] [int] NULL,
 CONSTRAINT [PK_Turma] PRIMARY KEY CLUSTERED 
(
	[IdTurma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AlunoDocumento]  WITH CHECK ADD  CONSTRAINT [FK_AlunoDocumento_Aluno] FOREIGN KEY([IdAluno])
REFERENCES [dbo].[Aluno] ([IdAluno])
GO
ALTER TABLE [dbo].[AlunoDocumento] CHECK CONSTRAINT [FK_AlunoDocumento_Aluno]
GO
ALTER TABLE [dbo].[AlunoDocumento]  WITH CHECK ADD  CONSTRAINT [FK_AlunoDocumento_Documento] FOREIGN KEY([IdDocumento])
REFERENCES [dbo].[Documento] ([IdDocumento])
GO
ALTER TABLE [dbo].[AlunoDocumento] CHECK CONSTRAINT [FK_AlunoDocumento_Documento]
GO
ALTER TABLE [dbo].[Atestado]  WITH CHECK ADD  CONSTRAINT [FK_Atestado_Aluno] FOREIGN KEY([IdAluno])
REFERENCES [dbo].[Aluno] ([IdAluno])
GO
ALTER TABLE [dbo].[Atestado] CHECK CONSTRAINT [FK_Atestado_Aluno]
GO
ALTER TABLE [dbo].[Aula]  WITH CHECK ADD  CONSTRAINT [FK_Aula_Turma] FOREIGN KEY([IdTurma])
REFERENCES [dbo].[Turma] ([IdTurma])
GO
ALTER TABLE [dbo].[Aula] CHECK CONSTRAINT [FK_Aula_Turma]
GO
ALTER TABLE [dbo].[DocumentoDisciplina]  WITH CHECK ADD  CONSTRAINT [FK_DocumentoDisciplina_Disciplina] FOREIGN KEY([IdDisciplina])
REFERENCES [dbo].[Disciplina] ([IdDisciplina])
GO
ALTER TABLE [dbo].[DocumentoDisciplina] CHECK CONSTRAINT [FK_DocumentoDisciplina_Disciplina]
GO
ALTER TABLE [dbo].[DocumentoDisciplina]  WITH CHECK ADD  CONSTRAINT [FK_DocumentoDisciplina_Documento] FOREIGN KEY([IdDocumento])
REFERENCES [dbo].[Documento] ([IdDocumento])
GO
ALTER TABLE [dbo].[DocumentoDisciplina] CHECK CONSTRAINT [FK_DocumentoDisciplina_Documento]
GO
ALTER TABLE [dbo].[ListaEspera]  WITH CHECK ADD  CONSTRAINT [FK_ListaEspera_Aluno] FOREIGN KEY([IdAluno])
REFERENCES [dbo].[Aluno] ([IdAluno])
GO
ALTER TABLE [dbo].[ListaEspera] CHECK CONSTRAINT [FK_ListaEspera_Aluno]
GO
ALTER TABLE [dbo].[ListaEspera]  WITH CHECK ADD  CONSTRAINT [FK_ListaEspera_Turma] FOREIGN KEY([IdTurma])
REFERENCES [dbo].[Turma] ([IdTurma])
GO
ALTER TABLE [dbo].[ListaEspera] CHECK CONSTRAINT [FK_ListaEspera_Turma]
GO
ALTER TABLE [dbo].[Matricula]  WITH CHECK ADD  CONSTRAINT [FK_Matricula_Aluno] FOREIGN KEY([IdAluno])
REFERENCES [dbo].[Aluno] ([IdAluno])
GO
ALTER TABLE [dbo].[Matricula] CHECK CONSTRAINT [FK_Matricula_Aluno]
GO
ALTER TABLE [dbo].[Matricula]  WITH CHECK ADD  CONSTRAINT [FK_Matricula_Turma] FOREIGN KEY([IdTurma])
REFERENCES [dbo].[Turma] ([IdTurma])
GO
ALTER TABLE [dbo].[Matricula] CHECK CONSTRAINT [FK_Matricula_Turma]
GO
ALTER TABLE [dbo].[Presenca]  WITH CHECK ADD  CONSTRAINT [FK_Presenca_Aluno] FOREIGN KEY([IdAluno])
REFERENCES [dbo].[Aluno] ([IdAluno])
GO
ALTER TABLE [dbo].[Presenca] CHECK CONSTRAINT [FK_Presenca_Aluno]
GO
ALTER TABLE [dbo].[Presenca]  WITH CHECK ADD  CONSTRAINT [FK_Presenca_Aula] FOREIGN KEY([IdAula])
REFERENCES [dbo].[Aula] ([IdAula])
GO
ALTER TABLE [dbo].[Presenca] CHECK CONSTRAINT [FK_Presenca_Aula]
GO
ALTER TABLE [dbo].[Turma]  WITH CHECK ADD  CONSTRAINT [FK_Turma_Disciplina] FOREIGN KEY([IdDisciplina])
REFERENCES [dbo].[Disciplina] ([IdDisciplina])
GO
ALTER TABLE [dbo].[Turma] CHECK CONSTRAINT [FK_Turma_Disciplina]
GO
USE [master]
GO
ALTER DATABASE [CPSI] SET  READ_WRITE 
GO
