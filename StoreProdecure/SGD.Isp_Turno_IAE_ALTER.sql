
-- =============================================
-- Author:		Nevado Barrios Erick
-- Create date: 18/01/2012
-- Description:	
-- =============================================
ALTER PROCEDURE [SGD].[Isp_Turno_IAE] 
	@TIPOOPERACION CHAR(1) = ''
	,@Id CHAR(7) = ''
	,@HoraInicio varchar(20) = ''
	,@HoraSalida varchar(20) = ''
	,@Dia varchar(15) = ''
	,@Turno CHAR(1) = ''
	,@Usuario CHAR(12) = ''
	,@Activo BIT = 1
	,@Prefijo CHAR(3) = '1SI'
	,@FechaInicio DATETIME = '01/01/1900'
	,@FechaSalida DATETIME = '01/01/1900'
	,@IdEmpresaSis CHAR(12) = ''
	,@IdSucursal CHAR(12) = ''
 As 
 BEGIN 
 BEGIN TRY
   IF @TIPOOPERACION = 'I' 
   BEGIN
   declare @Id_Nuevo VARCHAR(20) 
   exec STD.Isp_GeneraID 'SGD.Turno',@Prefijo,@Id_Nuevo out 
       INSERT INTO SGD.Turno(
        Id
       ,HoraInicio
       ,HoraSalida
       ,Dia
       ,Turno
       ,UsuarioCreacion
       ,Activo
	   ,FechaInicio
	   ,FechaSalida
	   ,IdEmpresaSis
	   ,IdSucursal
       )VALUES(
        @Id_Nuevo
       ,convert(time,@HoraInicio , 108)
       ,convert(time,@HoraSalida  , 108) 
       ,@Dia 
       ,@Turno 
       ,@Usuario
       ,1
	   ,@FechaInicio
	   ,@FechaSalida
	   ,@IdEmpresaSis
	   ,@IdSucursal
       )
       select @Id_Nuevo
   END
   ELSE IF @TIPOOPERACION = 'A' 
   BEGIN
       UPDATE SGD.Turno SET 
        HoraInicio = convert(time,@HoraInicio , 108) 
       ,HoraSalida = convert(time,@HoraSalida  , 108) 
       ,Dia = @Dia 
       ,Turno = @Turno
	   ,FechaInicio = @FechaInicio
	   ,FechaSalida = @FechaSalida 
	   ,UsuarioModifica = @Usuario
	   ,FechaModifica = GETDATE() 
       WHERE id = @id
       select @id
   END
   ELSE IF @TIPOOPERACION = 'E' 
   BEGIN
       UPDATE SGD.Turno SET Activo = 0
	   ,UsuarioModifica = @Usuario
	   ,FechaModifica = GETDATE() 
       WHERE id = @id
   END
 END TRY
 BEGIN CATCH
    EXEC STD.Isp_Retornar_Error
 END CATCH
 END 
