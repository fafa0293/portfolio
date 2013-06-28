
<?php
	//session_start();
	include "Gestor.php";
	$gestor = new Gestor();
	
	$usuario = $_POST['txtNomUsua'];
	$clave = $_POST['cntCont'];
	
	$consulta = $gestor->buscarUsuario($usuario,$clave);

	if (count($consulta)==0){
		echo "<script language='JavaScript'>";
		echo "alert('El usuario ".$usuario." no existe o la contraseña es incorrecta');";
		echo "window.location.href = 'default.html'";
		echo "</script>";
	}else{
		$_SESSION['sIdUsuario'] = $consulta[1]; //devuelve el còdigo
		$_SESSION['sNombreUsuario'] = $consulta[0]; //devuelve el nombre del empleado
		//echo "Consulta0   ".$consulta[0];
		//echo "Consulta1   ".$consulta[1];
		switch ($consulta[1]) {
		    case "0":
		        echo "<script language='JavaScript'>";
				echo "window.location.href = 'IndexS.php'";
				echo "</script>";
				break;
		    case "1":
		        echo "<script language='JavaScript'>";
				echo "window.location.href = 'IndexA.php'";
				echo "</script>";
				break;
		}
	}
	
?>