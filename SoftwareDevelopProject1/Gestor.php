<?php
/*
Módulo: 			Gestor
Propósito:			Servir de capa lógica de negocios, es decir, servir
de interfaz de servicios y orquestador de procesos
Creado por:			Sebastian Lapcevic
Fecha de creación:	13-4-2012
Fecha de última 
modificación:		13-4-2012
Bitácora de modificaciones:

*/
include "AccesoDatos.php";

class Gestor{
	
	//variable que almacena la instancia del acceso a datos
	var $acceso;
	
	/*
	Entrada:			Ninguna
	Salida:			Ninguna
	Precondición:	Se estableció la cadena de conexión correcta
	y se hizo el ODBC
	Funcionamiento:	Se inicializa la instancia del Gestor y la variable
	de acceso a datos
	*/
	function Gestor(){
		$this->acceso=new AccesoDatos();	
	}
	
		
	public function agregarRutaCamion($chofer, $placaCC, $puntoSalida,$puntoLlegada, $horaSalida, $horaLlega, $precioRuta, $kilometrajeLlegada, $kilometrajeRegreso, $comentarios, $fechaSalida,$fechaLlegada){
		
		//echo "ingresa a agregarEmpleado";
		$sql="INSERT INTO TRuta(Cedula, PlacaCC, PuntoSalida, PuntoLlegada, FechaSalida, FechaLlegada, HoraSalida, HoraLlegada, KIda, KVenida, Precio, Ruta) 
		VALUES ('".$chofer."','".$placaCC."','".$puntoSalida."','".$puntoLlegada."','".$fechaSalida."','".$fechaLlegada."','".$horaSalida."','".$horaLlega."','".$kilometrajeLlegada."','".$kilometrajeRegreso."','".$precioRuta."','".$comentarios."')";
		//echo "<p></p>";
		//echo "$sql";
		$this->acceso->ejecutarSQL($sql);
		$this->acceso->cerrarConexion();
		//echo "<p>va a salir de agregarEmpleado...</p>";
	}
	
		public function agregarRutaVinculo($chofer, $placa, $puntoSalida,$puntoLlegada, $horaSalida, $horaLlega, $precioRuta, $kilometrajeLlegada, $kilometrajeRegreso, $comentarios, $fechaSalida,$fechaLlegada, $idVinculo){
		
		//echo "ingresa a agregarEmpleado";
		$sql="INSERT INTO TRuta(Cedula, PlacaCC, IdVinculo,  PuntoSalida, PuntoLlegada, FechaSalida, FechaLlegada, HoraSalida, HoraLlegada, KIda, KVenida, Precio, Ruta) 
		VALUES ('".$chofer."','".$placa."','".$idVinculo."','".$puntoSalida."','".$puntoLlegada."','".$fechaSalida."','".$fechaLlegada."','".$horaSalida."','".$horaLlega."','".$kilometrajeLlegada."','".$kilometrajeRegreso."','".$precioRuta."','".$comentarios."')";
		//echo "<p></p>";
		//echo "$sql";
		$this->acceso->ejecutarSQL($sql);
		$this->acceso->cerrarConexion();
		//echo "<p>va a salir de agregarEmpleado...</p>";
	}
	
		public function cargarVinculo(){
		$sql="";
		$rs=false;
		$registro=array();
		$consulta=array();
		$camion="Camión";
		
		$sql = "(Select TVinculo.IdVinculo, TCamionCabezal.PlacaCC, TVinculo.PlacaE
				from TCamionCabezal, TVinculo,TEquipo
				where TCamionCabezal.PlacaCC=TVinculo.PlacaCC and TVinculo.PlacaE=TEquipo.PlacaE)
				union
				(Select TCamionCabezal.PlacaCC,TRuta.Vacio,  TRuta.Vacio
				from TCamionCabezal, TRuta
				where TCamionCabezal.Tipo='".$camion."' and TCamionCabezal.PlacaCC=TRuta.PlacaCC)";
			
		$rs = $this->acceso->ejecutarSQL($sql);
			
		while(odbc_fetch_row($rs)){
			$idVinculo=odbc_result($rs,"IdVinculo");
			$placaCC=odbc_result($rs,"PlacaCC");
			$placaE=odbc_result($rs,"PlacaE");
			$registro = array($idVinculo=>array($idVinculo, $placaCC, $placaE, $idVinculo));
			$consulta = array_merge($consulta, $registro);			
		}
		$this->acceso->cerrarConexion();
		return $consulta;
	}
	


	public function cargarPlaca(){
		$sql="";
		$rs=false;
		$registro=array();
		$consulta=array();
		
		$sql = "SELECT PlacaCC FROM TRuta";
		$rs = $this->acceso->ejecutarSQL($sql);
		
		while(odbc_fetch_row($rs)){
			$placa=odbc_result($rs,"PlacaCC");
			$registro = array($placa=>array($placa));
			$consulta = array_merge($consulta, $registro);			
		}
		$this->acceso->cerrarConexion();
		return $consulta;
	}
	
	public function cargarPlacaC(){
		$sql="";
		$rs=false;
		$registro=array();
		$consulta=array();
		
		$sql = "SELECT PlacaCC FROM TCamionCabezal";
		$rs = $this->acceso->ejecutarSQL($sql);
		
		while(odbc_fetch_row($rs)){
			$placa=odbc_result($rs,"PlacaCC");
			$registro = array($placa=>array($placa));
			$consulta = array_merge($consulta, $registro);			
		}
		$this->acceso->cerrarConexion();
		return $consulta;
	}
	
	public function cargarPlacaE(){
		$sql="";
		$rs=false;
		$registro=array();
		$consulta=array();
		
		$sql = "SELECT PlacaE FROM TEquipo";
		$rs = $this->acceso->ejecutarSQL($sql);
		
		while(odbc_fetch_row($rs)){
			$placa=odbc_result($rs,"PlacaE");
			$registro = array($placa=>array($placa));
			$consulta = array_merge($consulta, $registro);			
		}
		
		
		$this->acceso->cerrarConexion();
		return $consulta;
	}
	public function cargarRutasWherePlaca($criterio){
		$sql="";
		$rs=false;
		$registro=array();
		$consulta=array();
		
		$sql = "SELECT * From TRuta where PlacaCC='".$criterio."'";
		$rs = $this->acceso->ejecutarSQL($sql);
		
		while(odbc_fetch_row($rs)){
			$cedula=odbc_result($rs,"Cedula");
			$placa=odbc_result($rs,"PlacaCC");
			$idVinculo=odbc_result($rs,"IdVinculo");
			$pSalida=odbc_result($rs,"PuntoSalida");
			$pLlegada=odbc_result($rs,"PuntoLlegada");
			$fSalida=odbc_result($rs,"FechaSalida");
			$fLlegada=odbc_result($rs,"FechaLlegada");
			$hSalida=odbc_result($rs,"HoraSalida");
			$hLlegada=odbc_result($rs,"HoraLlegada");
			$kIda=odbc_result($rs,"KIda");
			$kVenida=odbc_result($rs,"KVenida");
			$precio=odbc_result($rs,"Precio");
			$ruta=odbc_result($rs,"Ruta");
			$registro = array($cedula=>array($cedula, $placa, $idVinculo, $pSalida, $pLlegada, $fSalida, $fLlegada, $hSalida,$hLlegada, $kIda, $kVenida, $precio, $ruta));
			$consulta = array_merge($consulta, $registro);			
		}
		$this->acceso->cerrarConexion();
		//return $registro;
		return $consulta;
	}
	
	public function cargarPlacaCCWherePlaca($criterio){
		$sql="";
		$rs=false;
		$registro=array();
		$consulta=array();
		
		$sql = "SELECT * From TCamionCabezal where PlacaCC='".$criterio."'";
		$rs = $this->acceso->ejecutarSQL($sql);
		
		while(odbc_fetch_row($rs)){
			$placa=odbc_result($rs,"PlacaCC");
			$vin=odbc_result($rs,"VIN");
			$marca=odbc_result($rs,"Marca");
			$modelo=odbc_result($rs,"Modelo");
			$anno=odbc_result($rs,"Anno");
			$cilindraje=odbc_result($rs,"Cilindraje");
			$combustible=odbc_result($rs,"Combustible");
			$transmision=odbc_result($rs,"Transmision");
			$kilometraje=odbc_result($rs,"Kilometraje");
			$equipamiento=odbc_result($rs,"Equipamiento");
			$largo=odbc_result($rs,"Largo");
			$tipo=odbc_result($rs,"Tipo");
			$comentario=odbc_result($rs,"Comentario");
			$registro = array($placa=>array($placa, $vin, $marca, $modelo, $anno, $cilindraje, $combustible, $transmision,$kilometraje, $equipamiento, $largo, $tipo, $comentario));
			$consulta = array_merge($consulta, $registro);			
		}
		$this->acceso->cerrarConexion();
		//return $registro;
		return $consulta;
	}
	
	public function cargarPlacaEWherePlaca($criterio){
		$sql="";
		$rs=false;
		$registro=array();
		$consulta=array();
		
		$sql = "SELECT * From TEquipo where PlacaE='".$criterio."'";
		$rs = $this->acceso->ejecutarSQL($sql);
		
		while(odbc_fetch_row($rs)){
			$placa=odbc_result($rs,"PlacaE");
			$largo=odbc_result($rs,"Largo");
			$ancho=odbc_result($rs,"Ancho");
			$alto=odbc_result($rs,"Alto");
			$capacidad=odbc_result($rs,"Capacidad");
			$cargaNeta=odbc_result($rs,"Carga");
			$tipo=odbc_result($rs,"Tipo");
			$comentario=odbc_result($rs,"Comentarios");
			$registro = array($placa=>array($placa, $largo, $ancho, $alto, $capacidad, $cargaNeta, $tipo, $comentario));
			$consulta = array_merge($consulta, $registro);			
		}
		$this->acceso->cerrarConexion();
		//return $registro;
		return $consulta;
	}
	
	public function registrarEquipo($placa,$tipo,$largo,$ancho,$alto,$capacidad,$cargaNeta,$comentario){
		//echo "ingresa a registrarEquipo";
		$sql="INSERT INTO TEquipo(PlacaE, Largo, Ancho, Alto, Capacidad, Carga, Tipo, Comentarios) VALUES ('".$placa."','".$largo."','".$ancho."','".$alto."','".$capacidad."','".$cargaNeta."','".$tipo."','".$comentario."')";
		//echo "<p></p>";
		//echo "$sql";
		$this->acceso->ejecutarSQL($sql);
		$this->acceso->cerrarConexion();
		//echo "<p>va a salir de registrarEquipo...</p>";
	}
	public function consultarEquipo($placa){
				
		$sql = "SELECT * FROM TEquipo WHERE PlacaE='".$placa."'";
		$rs = $this->acceso->ejecutarSQL($sql);
		
		if (odbc_fetch_row($rs)){
			$placa=odbc_result($rs,"PlacaE");
			$tipo=odbc_result($rs,"Tipo");
			$largo=odbc_result($rs,"Largo");
			$ancho=odbc_result($rs,"Ancho");
			$alto=odbc_result($rs,"Alto");
			$capacidad=odbc_result($rs,"Capacidad");
			$cargaNeta=odbc_result($rs,"Carga");
			$comentario=odbc_result($rs,"Comentarios");
			$consulta = array($placa,$tipo,$largo,$ancho,$alto,$capacidad,$cargaNeta,$comentario);
		}
		$this->acceso->cerrarConexion();
		return $consulta;
			
	}
	public function modificarEquipo($placa,$tipo,$largo,$ancho,$alto,$capacidad,$cargaNeta,$comentario){
		$sql="UPDATE TEquipo SET PlacaE='".$placa."', Tipo='".$tipo."', Largo='".$largo."', Ancho='".$ancho."', Alto='".$alto."', Capacidad='".$capacidad."', Carga='".$cargaNeta."', Comentarios='".$comentario."' WHERE PlacaE='".$placa."'";
		$this->acceso->ejecutarSQL($sql);
		$this->acceso->cerrarConexion();
	}
	
	public function agregarChofer($pcedula,$pnombre,$ptelefono1,$ptelefono2,$ptelefono3,$pfecha,$pcomentarios){
		//echo "ingresa a agregarEmpleado";
		$sql="INSERT INTO TChofer(Cedula, Nombre, Vencimiento, Telefono1, Telefono2, Telefono3, Comentarios) VALUES ('".$pcedula."','".$pnombre."','".$pfecha."','".$ptelefono1."','".$ptelefono2."','".$ptelefono3."','".$pcomentarios."')";
		//echo "<p></p>";
		//echo "$sql";
		$this->acceso->ejecutarSQL($sql);
		$this->acceso->cerrarConexion();
		//echo "<p>va a salir de agregarEmpleado...</p>";
	}

	/*
	Entrada:			Ninguna
	Salida:			$consulta : arreglo que guarda el resultado de
	la consulta de todos los choferes
	Precondición:	Se estableció correctamente la conexión con la 
	base de datos
	Hay choferes almacenados en el sistema
	Funcionamiento:	Se realiza la consulta de todos los choferes.  
	Se descarga el resultado en variables
	Las variables se guardan en un arreglo y el arreglo en una matriz
	que guarda todos los registros
	*/
	public function cargarChoferes(){
		$sql="";
		$rs=false;
		$registro=array();
		$consulta=array();
		
		$sql = "SELECT * FROM TChofer";
		$rs = $this->acceso->ejecutarSQL($sql);
		
		while(odbc_fetch_row($rs)){
			$cedula=odbc_result($rs,"Cedula");
			$nombre=odbc_result($rs,"Nombre");
			$registro = array($cedula=>array($cedula,$nombre));
			$consulta = array_merge($consulta, $registro);			
		}
		$this->acceso->cerrarConexion();
		return $consulta;
	}

	/*
	Entrada:		$criterio: criterio de busqueda
	Salida:			$consulta : arreglo que guarda el resultado de
	la consulta del chofer
	Precondición:	Se estableció correctamente la conexión con la 
	base de datos
	Hay algun chofer almacenados en el sistema que coincida al criterio
	de busqueda
	Funcionamiento:	Se realiza la consulta del chofer.  
	Se descarga el resultado en variables
	Las variables se guardan en un arreglo y el arreglo en una matriz
	que guarda todos los registros
	*/
	public function cargarChoferesWhereId($criterio){
		$sql="";
		$rs=false;
		$registro=array();
		$consulta=array();
		
		$sql = "SELECT * FROM TChofer where Cedula='".$criterio."'";
		$rs = $this->acceso->ejecutarSQL($sql);
		
		while(odbc_fetch_row($rs)){
			$nombre=odbc_result($rs,"Nombre");
			$cedula=odbc_result($rs,"Cedula");
			$telefono1=odbc_result($rs,"Telefono1");
			$telefono2=odbc_result($rs,"Telefono2");
			$telefono3=odbc_result($rs,"Telefono3");
			$fecha=odbc_result($rs,"Vencimiento");
			$comentarios=odbc_result($rs,"Comentarios");

			//$registro = array($codigo,$nombre,$apellido1,$apellido2,$puesto);
			$registro = array($cedula=>array($cedula,$nombre,$telefono1,$telefono2,$telefono3,$fecha,$comentarios));
			$consulta = array_merge($consulta, $registro);			
		}
		$this->acceso->cerrarConexion();
		//return $registro;
		return $consulta;
	}
	/*
	Entrada:			$pnombre : nombre del chofer
						$pcedula : cedula del chofer
						$ptelefono1 : telefono1 del chofer
						$ptelefono2 : telefono2 del chofer
						$ptelefono3 : telefono3 del chofer
						$pfecha : fecha de vencimiento de la licencia del chofer
						$pcomentarios : comentarios
	Salida:			Ninguna
	Precondición:		El chofer existe
	Funcionamiento:		Se actualiza el chofer en la base de datos
	*/
	public function modificarChofer($pnombre,$pcedula,$ptelefono1,$ptelefono2,$ptelefono3,$pfecha,$pcomentarios){
		$sql="UPDATE TChofer SET Cedula='".$pcedula."', Nombre='".$pnombre."', Telefono1='".$ptelefono1."', Telefono2='".$ptelefono2."', Telefono3='".$ptelefono3."', Vencimiento='".$pfecha."', Comentarios='".$pcomentarios."' WHERE Cedula='".$pcedula."'";
		$this->acceso->ejecutarSQL($sql);
		$this->acceso->cerrarConexion();
	}

	/*
	Entrada:		$codChofer : Cedula del chofer
	Salida:			$consulta : Datos del chofer
	Precondición:	Se estableció correctamente la conexión con la 
	base de datos
	Funcionamiento:	Se consulta el chofer por su cedula, se guarda la
	consulta en variables y las variables en un arreglo que se devuelve
	a la capa de presentación
	*/
	public function consultarChofer($codChofer){
				
		$sql = "SELECT * FROM TChofer WHERE Cedula='".$codChofer."'";
		$rs = $this->acceso->ejecutarSQL($sql);
		
		if (odbc_fetch_row($rs)){
			$nombre=odbc_result($rs,"Nombre");
			$cedula=odbc_result($rs,"Cedula");
			$telefono1=odbc_result($rs,"Telefono1");
			$telefono2=odbc_result($rs,"Telefono2");
			$telefono3=odbc_result($rs,"Telefono3");
			$fecha=odbc_result($rs,"Vencimiento");

			$comentarios=odbc_result($rs,"Comentarios");
			$consulta = array($cedula,$nombre,$telefono1,$telefono2,$telefono3,$fecha,$comentarios);
		}
		$this->acceso->cerrarConexion();
		return $consulta;
			
	}

	public function buscarUsuario($pusuario,$pclave){
		$sql="";
		$rs=false;
		$sql = "SELECT Nombre,Tipo FROM TUsuario WHERE Nombre='".$pusuario."' AND Contrasenna='".$pclave."'";
		$rs = $this->acceso->ejecutarSQL($sql);
		while(odbc_fetch_row($rs)){
			$nombre=odbc_result($rs,"Nombre");
			$tipo=odbc_result($rs,"Tipo");
			$consulta=array($nombre,$tipo);
		}
		$this->acceso->cerrarConexion();
		return $consulta;
	}
	
	
	
	
	
	//JUAREZ
	public function agregarVinculo($placaCC, $placaE){
		//echo "ingresa a agregarEmpleado";
		$sql="INSERT INTO TVinculo(PlacaCC, PlacaE) VALUES ('".$placaCC."','".$placaE."')";
		//echo "<p></p>";
		//echo "$sql";
		$this->acceso->ejecutarSQL($sql);
		$this->acceso->cerrarConexion();
		//echo "<p>va a salir de agregarEmpleado...</p>";
	}
	
	public function cargarPlacaCabezal(){
		$sql="";
		$rs=false;
		$registro=array();
		$consultaUno=array();
		
		$sql = "SELECT PlacaCC FROM TCamionCabezal"; 
		$rs = $this->acceso->ejecutarSQL($sql);
		
		while(odbc_fetch_row($rs)){
			$placaCC=odbc_result($rs,"PlacaCC");
			$registro = array($placaCC=>array($placaCC));
			$consultaUno = array_merge($consultaUno, $registro);			
		}
		$this->acceso->cerrarConexion();
		return $consultaUno;
	}
	
	public function cargarPlacaEquipo(){
		$sql="";
		$rs=false;
		$registro=array();
		$consultaDos=array();
		
		$sql = "SELECT PlacaE FROM TEquipo"; 
		$rs = $this->acceso->ejecutarSQL($sql);
		
		while(odbc_fetch_row($rs)){
			$placaE=odbc_result($rs,"PlacaE");
			$registro = array($placaE=>array($placaE));
			$consultaDos = array_merge($consultaDos, $registro);			
		}
		$this->acceso->cerrarConexion();
		return $consultaDos;
	}
	
	public function cargarVinculoCC($criterio){
		$sql="";
		$rs=false;
		$registro=array();
		$consultaV=array();
		
		$sql = "SELECT PlacaE FROM TVinculo where PlacaCC='".$criterio."'"; 
		$rs = $this->acceso->ejecutarSQL($sql);
		
		while(odbc_fetch_row($rs)){
			$placaE=odbc_result($rs,"PlacaE");
			$registro = array($placaE=>array($placaE));
			$consultaV = array_merge($consultaV, $registro);			
		}
		$this->acceso->cerrarConexion();
		return $consultaV;
	}
	
	public function cargarVinculoE($criterio){
		$sql="";
		$rs=false;
		$registro=array();
		$consultaE=array();
		
		$sql = "SELECT PlacaCC FROM TVinculo where PlacaE='".$criterio."'"; 
		$rs = $this->acceso->ejecutarSQL($sql);
		
		while(odbc_fetch_row($rs)){
			$placaCC=odbc_result($rs,"PlacaCC");
			$registro = array($placaCC=>array($placaCC));
			$consultaE = array_merge($consultaE, $registro);			
		}
		$this->acceso->cerrarConexion();
		return $consultaE;
	}
	
	public function cargarVinculoWhereIds($idUno, $idDos){
		$sql="";
		$rs=false;
		$consulta=array();
		
		$sql = "SELECT * FROM TVinculo WHERE PlacaCC='".$idUno."' AND PlacaE='".$idDos."'";
		$rs = $this->acceso->ejecutarSQL($sql);
		
		while(odbc_fetch_row($rs)){
			$codigo=odbc_result($rs,"IdVinculo");
			$placaCC=odbc_result($rs,"PlacaCC");
			$placaE=odbc_result($rs,"PlacaE");
			$consulta = array($codigo, $placaCC, $placaE);
			//$registro = array($cedula=>array($cedula,$nombre,$telefono1,$telefono2,$telefono3,$fecha,$comentarios));
						
		}
		$this->acceso->cerrarConexion();
		//return $registro;
		return $consulta;
	}
	
	public function eliminarVinculo($idUno, $idDos, $cod){
		$sql="DELETE FROM TVinculo WHERE PlacaCC='".$idUno."' AND PlacaE='".$idDos."' AND IdVinculo=".$cod;
		$this->acceso->ejecutarSQL($sql);
		$this->acceso->cerrarConexion();
	}
	
	//BARRETT
	
	public function buscartTipoTransportewhere($criterio){
		$sql="";
		$rs=false;
		$registro=array();
		$consulta=array();
		
		$sql = "SELECT * FROM TCamionCabezal WHERE Tipo='".$criterio."'";
		$rs = $this->acceso->ejecutarSQL($sql);
		
		while(odbc_fetch_row($rs)){
			$placa=odbc_result($rs,"PlacaCC");
			$numVin=odbc_result($rs,"VIN");
			$marca=odbc_result($rs,"Marca");
			$modelo=odbc_result($rs,"Modelo");
			$fecha=odbc_result($rs,"Anno");
			$cilindraje=odbc_result($rs,"Cilindraje");
			$combustible=odbc_result($rs,"Combustible");
			$transmision=odbc_result($rs,"Transmision");
			$kilometraje=odbc_result($rs,"Kilometraje");
			$equipamiento=odbc_result($rs,"Equipamiento");
			$largo=odbc_result($rs,"Largo");
			$sltTipoTrans=odbc_result($rs,"Tipo");
			$comentario=odbc_result($rs,"Comentario");
			$registro = array($placa=>array($placa, $numVin, $marca, $modelo, $fecha, $cilindraje, $combustible, $transmision, $kilometraje, $equipamiento, $largo, $sltTipoTrans, $comentario));
			$consulta = array_merge($consulta, $registro);
		}
		$this->acceso->cerrarConexion();
		//return $registro;
		return $consulta;
	}
	
	////////// Caso de uso registrarCabezalCamion //////////
	public function registrarCabezalCamion($pplaca, $pnumVin, $pmarca, $pmodelo, $pfecha, $pcilindraje, $pcombustible, $ptransmision, $pkilometraje, $pequipamiento, $plargo, $psltTipoTrans, $pcomentario){
		$sql="INSERT INTO TCamionCabezal(PlacaCC, VIN, Marca, Modelo, Anno, Cilindraje, Combustible, Transmision, kilometraje, Equipamiento, Largo, Tipo, Comentario)  values ('".$pplaca."', '".$pnumVin."', '".$pmarca."', '".$pmodelo."', ".$pfecha.", ".$pcilindraje.", '".$pcombustible."', '".$ptransmision."', ".$pkilometraje.", '".$pequipamiento."', ".$plargo.", '".$psltTipoTrans."', '".$pcomentario."')";
		
		$this->acceso->ejecutarSQL($sql);
		$this->acceso->cerrarConexion();
	}
	
	public function consultarCabezalCamion($placa){
				
		$sql = "SELECT * FROM TCamionCabezal WHERE PlacaCC='".$placa."'";
		$rs = $this->acceso->ejecutarSQL($sql);
		if (odbc_fetch_row($rs)){
			$placa=odbc_result($rs,"PlacaCC");
			$numVin=odbc_result($rs,"VIN");
			$marca=odbc_result($rs,"Marca");
			$modelo=odbc_result($rs,"Modelo");
			$fecha=odbc_result($rs,"Anno");
			$cilindraje=odbc_result($rs,"Cilindraje");
			$combustible=odbc_result($rs,"Combustible");
			$transmision=odbc_result($rs,"Transmision");
			$kilometraje=odbc_result($rs,"kilometraje");
			$equipamiento=odbc_result($rs,"Equipamiento");
			$largo=odbc_result($rs,"Largo");
			$sltTipoTrans=odbc_result($rs,"Tipo");
			$comentario=odbc_result($rs,"Comentario");
			$consulta = array($placa, $numVin, $marca, $modelo, $fecha, $cilindraje, $combustible, $transmision, $kilometraje, $equipamiento, $largo, $sltTipoTrans, $comentario);
	
		}
		$this->acceso->cerrarConexion();
		return $consulta;
			
	}
	public function modificarCabezalCamion($pplaca, $pnumVin, $pmarca, $pmodelo, $pfecha, $pcilindraje, $pcombustible, $ptransmision, $pkilometraje, $pequipamiento, $plargo, $psltTipoTrans, $pcomentario){		
		$sql="UPDATE TCamionCabezal SET VIN='".$pnumVin."', Marca='".$pmarca."', Modelo='".$pmodelo."', Anno=".$pfecha.", Cilindraje=".$pcilindraje.", Combustible='".$pcombustible."', Transmision='".$ptransmision."', kilometraje=".$pkilometraje.", Equipamiento='".$pequipamiento."', Largo=".$plargo.", Tipo='".$psltTipoTrans."', Comentario='".$pcomentario."' WHERE PlacaCC='".$pplaca."'";
		$this->acceso->ejecutarSQL($sql);
		$this->acceso->cerrarConexion();
	}
}
?>
