<?php
/*
M�dulo: 				AccesoDatos
Prop�sito:			Servir de capa de acceso a datos y abstraer al 
programador de los detalles del motor de base de datos con el que 
se conecta
Creado por:			Laura Monge Izaguirre
Fecha de creaci�n:	26-Jun-2008
Fecha de �ltima 
modificaci�n:		26-Jun-2008
Bit�cora de modificaciones:

*/
class AccesoDatos{	

	var $cnx;
	var $cadena_conexion;

	/*
	Entrada:			Ninguna
	Salida:			Ninguna
	Precondici�n:	Ya se construy� la base de datos y se configur�
	el ODBC
	Funcionamiento:	Se establece la cadena de conexi�n con la base
	de datos
	*/
	public function AccesoDatos(){
		$this->cnx=false;
		$this->cadena_conexion='ODBCSAT'; 
	}
	
	/*
	Entrada:			$psql : Sentencia de SQL con la inserci�n, el
	borrado, la modificaci�n o consulta de la base de datos
	Salida:			$rs : ResultSet que almacena el resultado de 
	la consulta, cuando aplique
	Precondici�n:	La conexi�n con la base de datos est� correctamente
	configurada
	Funcionamiento:	Se conecta con la base de datos, se ejecuta la 
	sentencia.  Dentro del proceso se verifica si la conexi�n se estableci�n
	y si la sentencia se ejecut� con �xito
	*/
	public function ejecutarSQL($psql){	
		//echo "ingresa a ejecutarSQL";
		$this->cnx=odbc_connect($this->cadena_conexion,'','');
		if(!$this->cnx){
			exit("Fall� la conexi�n:<br>".$this->cnx);
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
	Precondici�n:	La conexi�n con la base de datos se encuentra
	abierta
	Funcionamiento:	Se cierra la conexi�n con la base de datos
	*/
	public function cerrarConexion(){
		odbc_close($this->cnx);
	}
	
}

?>