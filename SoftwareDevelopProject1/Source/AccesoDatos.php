<?php
/*
Módulo: 				AccesoDatos
Propósito:			Servir de capa de acceso a datos y abstraer al 
programador de los detalles del motor de base de datos con el que 
se conecta
Creado por:			Laura Monge Izaguirre
Fecha de creación:	26-Jun-2008
Fecha de última 
modificación:		26-Jun-2008
Bitácora de modificaciones:

*/
class AccesoDatos{	

	var $cnx;
	var $cadena_conexion;

	/*
	Entrada:			Ninguna
	Salida:			Ninguna
	Precondición:	Ya se construyó la base de datos y se configuró
	el ODBC
	Funcionamiento:	Se establece la cadena de conexión con la base
	de datos
	*/
	public function AccesoDatos(){
		$this->cnx=false;
		$this->cadena_conexion='ODBCSAT'; 
	}
	
	/*
	Entrada:			$psql : Sentencia de SQL con la inserción, el
	borrado, la modificación o consulta de la base de datos
	Salida:			$rs : ResultSet que almacena el resultado de 
	la consulta, cuando aplique
	Precondición:	La conexión con la base de datos está correctamente
	configurada
	Funcionamiento:	Se conecta con la base de datos, se ejecuta la 
	sentencia.  Dentro del proceso se verifica si la conexión se estableción
	y si la sentencia se ejecutó con éxito
	*/
	public function ejecutarSQL($psql){	
		//echo "ingresa a ejecutarSQL";
		$this->cnx=odbc_connect($this->cadena_conexion,'','');
		if(!$this->cnx){
			exit("Falló la conexión:<br>".$this->cnx);
		}				
		$rs=odbc_exec($this->cnx, $psql);
		if (!$rs){
			exit("Error al ejecutar la sentencia");
		}	
		//echo "el rs es: ".$rs;
		return $rs;
	}
	
	/*
	Entrada:			Ninguna
	Salida:			Ninguna
	Precondición:	La conexión con la base de datos se encuentra
	abierta
	Funcionamiento:	Se cierra la conexión con la base de datos
	*/
	public function cerrarConexion(){
		odbc_close($this->cnx);
	}
	
}

?>