CREATE TABLE [tb_user] (
  [id] int PRIMARY KEY IDENTITY(1, 1) NOT NULL,
  [nm_nome] nvarchar (255) NOT NULL,
  [ds_email] nvarchar(255) NOT NULL,
  [ds_cpf] nvarchar(255),
  [ds_senha] nvarchar(255) NOT NULL,
  [dt_cadastro] datetime NOT NULL,
  [dt_alteracao] datetime
)
GO

CREATE TABLE [tb_friend] (
  [id] int PRIMARY KEY IDENTITY(1, 1) NOT NULL,
  [id_user] int FOREIGN KEY REFERENCES tb_user(id),
  [nm_nome] nvarchar(255) NOT NULL,
  [ds_email] nvarchar(255),
  [nr_ddd] nvarchar(255),
  [nr_telefone] nvarchar(255),
  [ds_endereco] nvarchar(255),
  [fl_status] bit NOT NULL,
  [dt_cadastro] datetime NOT NULL,
  [dt_alteracao] datetime
)
GO

ALTER TABLE [tb_user] ADD FOREIGN KEY ([id]) REFERENCES [tb_friend] ([id_user])
GO