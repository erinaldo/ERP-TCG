
-- =============================================
-- Author:		Nevado Barrios Erick
-- Create date: 18/01/2012
-- Description:	
-- =============================================
ALTER PROCEDURE [SGD].[Isp_Turno_Usuario_IAE] 
	@TIPOOPERACION CHAR(1)
	,@Id CHAR(7) = ''
	,@IdTurno CHAR(7) = ''
	,@IdUsuario CHAR(12) = ''
	,@Usuario CHAR(12) = ''
	,@Activo BIT = 1
	,@Prefijo CHAR(3) = '1SI'
	,@IdEmpresaSis CHAR(12) = ''
	,@IdSucursal CHAR(12) = ''
 As 
 BEGIN 
 BEGIN TRY
 
	if @Id  = ''
		begin
			set @TIPOOPERACION = 'I'
		end
	else
		begin
			if @TIPOOPERACION = ''
				begin
					set @TIPOOPERACION = 'A'
				end	
		end
 
 
   IF @TIPOOPERACION = 'I' 
   BEGIN
   declare @Id_Nuevo VARCHAR(20) 
   exec STD.Isp_GeneraID 'SGD.Turno_Usuario',@Prefijo,@Id_Nuevo out 
       INSERT INTO SGD.Turno_Usuario(
        Id
       ,IdTurno
       ,IdUsuario
       ,UsuarioCreacion
       ,Activo
	   ,IdEmpresaSis
	   ,IdSucursal
       )VALUES(
        @Id_Nuevo
       ,@IdTurno 
       ,@IdUsuario 
       ,@Usuario
       ,1 
	   ,@IdEmpresaSis
	   ,@IdSucursal
       )
       select @Id_Nuevo
   END
   ELSE IF @TIPOOPERACION = 'A' 
   BEGIN
       UPDATE SGD.Turno_Usuario SET 
        IdTurno = @IdTurno 
       ,IdUsuario = @IdUsuario 
       ,Activo = @Activo 
	   ,UsuarioModifica = @Usuario
	   ,FechaModifica = GETDATE()
       WHERE id = @id
       select @id
   END
   ELSE IF @TIPOOPERACION = 'E' 
   BEGIN
       UPDATE SGD.Turno_Usuario SET Activo = 0
	   ,UsuarioModifica = @Usuario
	   ,FechaModifica = GETDATE()
       WHERE id = @id
   END
 END TRY
 BEGIN CATCH
    EXEC STD.Isp_Retornar_Error
 END CATCH
 END 
