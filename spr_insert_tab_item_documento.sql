CREATE PROCEDURE dbo.spr_insert_tab_item_documento 
@server_name NVARCHAR(450), @database_name NVARCHAR(450),
@object_name NVARCHAR(450), @permissao NVARCHAR(450),
@username_cliente NVARCHAR(450)
AS

	DECLARE @id_objeto INT, @id_permissao INT, @id_cliente NVARCHAR(450); 

	SELECT @id_objeto = tobj.IdObjeto
	FROM dbdatastore.dbo.tabObjeto tobj WITH (NOLOCK)
	WHERE 1 = 1	
		AND tobj.serverName = @server_name
		AND tobj.DatabaseName = @database_name
		AND tobj.ObjectName = @object_name


	SELECT @id_permissao = tp.codigoPermissao
	FROM dbdatastore.dbo.tabPermissao tp WITH (NOLOCK)
	WHERE 1 = 1
		AND tp.descricaoPermissao = @permissao


	SELECT @id_cliente = users.Id
	FROM dbdatastore.dbo.AspNetUsers users WITH (NOLOCK)
	WHERE 1 = 1
		AND users.UserName = @username_cliente


	IF(@id_objeto IS NULL) RAISERROR('Objeto Invalido', 16, 1);
	IF(@id_permissao IS NULL) RAISERROR('Permissao Invalida', 16, 1);
	IF(@id_cliente IS NULL) RAISERROR('Usuario Invalido', 16, 1);


	IF NOT EXISTS (

		SELECT TOP 1 tid.codigoItemDocumento 
		FROM dbdatastore.dbo.tabItemDocumento tid WITH (NOLOCK)

			INNER JOIN dbdatastore.dbo.tabDocumento td WITH (NOLOCK)
				ON tid.codigoDocumento = td.codigoDocumento

			OUTER APPLY (
			
				SELECT TOP 1 ta.resultado resultado_avaliacao, recs.analiseRecurso 
				FROM dbdatastore.dbo.tabAvaliacao ta WITH (NOLOCK)

					OUTER APPLY (
					
						SELECT TOP 1 tra.analiseRecurso FROM dbdatastore.dbo.tabRecursoAvaliacao tra WITH (NOLOCk)
						WHERE 1 = 1
							AND ta.codigoAvaliacao = tra.codigoAvaliacao
							
						ORDER BY tra.dtaAberturaRecurso DESC

					) recs

				WHERE 1 = 1
					AND tid.codigoDocumento = ta.codigoDocumento
					AND tid.codigoItemDocumento = ta.codigoItemDocumento
				ORDER BY ta.dtaAvaliacao DESC
			
			) ta

		WHERE 1 = 1
			AND tid.codigoObjeto = @id_objeto
			AND tid.codigoPermissao = @id_permissao
			AND (
				ta.resultado_avaliacao = 1 -- AVALIDADO POSITIVAMENTE
				OR 
				(
					ta.resultado_avaliacao = 0 AND ta.analiseRecurso IS NULL -- AVALIADO NEGATIVAMENTE COM RECURSO EM ANDAMENTO
				)
				 
			)
			 
	) 
	BEGIN

		INSERT INTO dbdatastore.dbo.tabDocumento
		(
		    
		   [idCliente]
		  ,[idAvaliador]
		  ,[codigoStatusDocumento]
		  ,[dataSolicitacao]
		  ,[dataFinalizacaoAvaliacao]

		)
		SELECT @id_cliente, NULL, 1, GETDATE(), NULL;

		INSERT INTO dbdatastore.dbo.tabItemDocumento
		(
		
		   [codigoDocumento]
		  ,[codigoPermissao]
		  ,[codigoObjeto]
		
		)
		SELECT @@IDENTITY, @id_permissao, @id_objeto;

	END ELSE 
	BEGIN
		RAISERROR('Ja existe uma solicitacao dessa permissao para esse objeto', 16, 1);
	END