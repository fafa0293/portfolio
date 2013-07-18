<!DOCTYPE HTML>
<html>
	<head>
		<title>Realizar Ruta</title>
		<!--Elaborado por: Jonathan Jara Morales-->
        <!--Fecha de creación:28/03/2012 9:06 am--> 
        <!--Ultima modificación: --> 
			
		<!--Icono -->
		<link rel="shortcut icon" href="images/favicon.ico" >
		<link rel="icon" type="image/gif" href="images/animated_favicon1.gif" >
		
		
		<!--Enlace con la hoja de estilo -->
		<link type="text/css" href="hojaDeEstilo.css" rel="stylesheet" />  
		
		
		<script src="popcalendar.js">
		</script>
		<script language = "javascript">	
		
			//Entrada: El id
			//Salida: Ninguna
			//Funcionamiento: Obtener los id deseados	
			function get(id){ 
				return document.getElementById(id);
			}
				
			//Entrada: Ninguna
			//Salida: Ninguna
			//Funcionamiento: Colocar el cursor en la primera casilla				
			function puntero(){
				frmRealizarRuta.txtSalida.focus();
			}
			
			//Entrada: Ninguna
			//Salida: Ninguna
			//Funcionamiento: Obtner la fecha del sistema
			function obtenerFecha() {
				var dias = new Date();
				var fecha = dias.getDate() +" / "+ (dias.getMonth()+ 1) + " / " + dias.getFullYear();
				document.getElementById("idFechaSalida").value = fecha;
				return true;
			}
			
			
			
			//Entrada: Ninguna
			//Salida: Ninguna
			//Funcionamiento: Inicar el reloj del sistema
			function iniciarReloj() {
			    obtenerFecha();
			   
			}
			
			//Entrada: datos
			//Salida: Ninguna
			//Funcionamiento: Validar los espacios vacios del formulario
			function validarVacios(datos){
				
				if (get('idSalida').value==""){
						alert("Ingrese el punto de salida")
						return false;
					}else if (get('idLlegada').value==""){
							alert("Ingrese el punto de llegada")
							return false;				
						}else if(get('idFechaSalida').value==""){
									alert("Ingrese la fecha de salida");
									return false;
								}else if(get('idFechaLlegada').value==""){
										alert("Ingrese la fecha de llegada");
										return false;
									}else if(get('idHoraSalida').value==""){
											alert("Ingrese la hora de salida");
											return false;
										}else if(get('idHoraLlegada').value==""){
												alert("Ingrese la hora de la llegada");
												return false;
											}else if(get('idKIda').value==""){
														alert("Ingrese el kilometraje de Ida");
														return false;
													}else if(get('idKmRegreso').value==""){
															alert("Ingrese el kilometraje de Regreso");
															return false;
														}else if(get('idsltChofer').value =="SELECT"){
																alert("Seleccione un chofer");
																return false;
															}else if(get('idsltPlaca').value =="SELECT"){
																	alert("Seleccione una placa");
																	return false;
																}else if(get('idPrecioZona').value==""){
																		alert("Ingrese el precio por zona");
																		return false;
																	}else if(get('idRutaExacta').value==""){
																		alert("Ingrese la ruta exacta");
																		return false;
																	}
						
				validarFormatos();
				return true;
			}
			
			//Entrada: Ninguna
			//Salida: Ninguna
			//Funcionamiento: Validar las expresiones regulares de los campos
			function validarFormatos(){
				
				var ExprecionReg;
					
				ExprecionReg=/^\d{6}$/;
				
				if (!ExprecionReg.test(get('idKmRegreso').value)){
						alert("Formato incorrecto del kilometraje de regreso, deben de ser números");
						return false;
					}else if(!ExprecionReg.test(get('idKIda').value)){
							alert("Formato incorrecto del kilometraje de ida, deben de ser números");
							return false;
						}
						else{
							ExprecionReg=/^[0-9]*$/;
						}if(!ExprecionReg.test(get('idPrecioZona').value)){
								alert("Formato incorrecto del precio por zona, deben de ser números");
								return false;
							}else if(confirm("¿Desea registrar la ruta?")){
									frmRealizarRuta.submit();
									return false;
								}else{
									alert("No se registraron los datos");
									return false;
								}
				return true;
			}
				
		//Entrada: Ninguna 
		//Salida: Ninguna
		//Funcionamiento: Limpia el formulario	
		function reset(){
			get(idfrmRealizarRuta).reset();
			return false;
		}
		
		</script>
	</head>	
	
	<body onLoad="puntero()">
		<?php
			include "Gestor.php";
			$gestor= new Gestor();
			$consulta1=$gestor->cargarChoferes();
			$consulta2=$gestor->cargarVinculo();
		?>
		
			
		<div id="menu">
		<ul class="menu">	
			<!--Primera casilla -->
			<li><a href="#" class="parent"><span>Registrar <span class="subtext"></span></span></a> <!--Segundo registrar poner en blanco -->
				<ul>             
					<li><a href="rChofer.php"><span>Registrar Chofer</span></a></li>
					<li><a href="rCabezalCamion.php"><span>Registrar Cabezal/Camion</span></a></li>
					<li><a href="rEquipo.php"><span>Registrar Equipo</span></a></li>
					<li><a href="rVinculo.php"><span>Registrar Vinculo</span></a></li>
					<li><a href="realizarRuta.php"><span>Realizar Ruta</span></a></li>
				</ul>
			</li>
			<!--Segunda casilla -->
			<li><a href="#" class="parent"><span>Modificar<span class="subtext"></span></span></a>
				<ul>             
					<li><a href="mBEquipo.php"><span>Modificar equipo</span></a></li>
					<li><a href="mBChofer.php"><span>Modificar chofer</span></a></li>
					<li><a href="mBCabezalCamion.php"><span>Modificar Cabezal/Camion</span></a></li>
				</ul>
			</li>
			<!--Tercera casilla -->
			<li><a href="#" class="parent"><span>Busquedas<span class="subtext"></span></span></a>
				<ul>             
					<li><a href="bTipoTransporte.php"><span>Buscar por tipo de transporte</span></a></li>
					<li><a href="bVinculoCabezalEquipo.php"><span>Buscar Vinculo</span></a></li>
					<li><a href="bPorPlaca.php"><span>Buscar por placa</span></a></li>
					<li><a href="bRuta.php"><span>Buscar por Rutas</span></a></li>
				</ul>
			</li>	
			
			<!--Cuarta casilla -->
			 <li><a href="#" class="parent"><span>Eliminar<span class="subtext"></span></span></a>
				<ul>             
					<li><a href="eliminarVinculo.php"><span>Eliminar Vinculo</span></a></li>	
				</ul>
					
			<!--Quinta casilla -->
			<li class="last"><a href="ayuda.html"><span>Ayuda</span></a></li>
			
			<!--Quinta casilla -->
			<li class="last"><a href="default.html"><span>Salir</span></a></li>
		</ul>
		</div>
		
		<div id="div">
			<!--Titulo principal de la pagina -->
			<h1>Realizar Ruta</h1><br>
			
			Ingrese los datos requeridos para realizar el registro de una ruta nueva.<br><br>
				
			<form name="frmRealizarRuta" action="realizarRuta.php" id="idfrmRealizarRuta" method="post">
				
				<!--Creacion de la tabla -->
				<table id="tabla">
					
					<!--Creacion de una caja de texto -->
					<tr>
						<td>Punto de Salida:</td>
						<td><input type="text" value="" name="txtSalida" id="idSalida" /></td>
					</tr>
					
					<!--Creacion de una caja de texto -->
					<tr>	
						<td>Punto de Llegada:</td>
						<td><input type="text" value="" name="txtLlegada" id="idLlegada" /></td>
					</tr>
					
					<!--Creacion de una caja de texto -->
					<tr>					
						<td>Fecha Llegada:</td>
						<td><input type="text" name="txtFechaLlegada" id="idFechaLlegada" onClick="popUpCalendar(this, frmRealizarRuta.idFechaLlegada, 'dd/mm/yyyy');" size="20">Ej: dd/mm/yyyy</td>
					</tr>
					
					<!--Creacion de una caja de texto -->
					<tr>	
						<td>Hora de Llegada:</td>
						<td><input type="text" value="" name="txtHoraLlegada" id="idHoraLlegada"/>Ejemplo: ##:## (am/pm)</td>
					</tr>	
					
					<!--Creacion de una caja de texto -->
					<tr>
						<td>Kilometraje Ida:</td>
						<td><input type="text" value="" name="txtKIda" id="idKIda"/>Ejemplo: ######</td>
					</tr>
	
					<!--Creacion de una caja de texto -->
					<tr>		
						<td>Kilometraje Llegada:</td>
						<td><input type="text" value="" name="txtKmRegreso" id="idKmRegreso"/>Ejemplo: ######</td>
					</tr>
					
					<!--Creacion de una caja de seleccion -->
					<tr>
						<td>Chofer:</td>
						<td><select name="sltChofer" id="idsltChofer">
							<option value="SELECT">--Seleccionar--</option>
								<?php
									foreach($consulta1 as $row)
									{
										echo "<option value=".$row[0].">".$row[0]." - ".$row[1]."</option>";
									}
								?>
						</select>	
						</td>
					</tr>	
					
					<!-- Creacion de la caja de seleccion-->
					<tr>
						<td>Transporte:</td>
						<td>
							<select name="sltPlaca" id="idsltPlaca">
								<option value="SELECT">--Seleccionar--</option>
								<?php
									foreach($consulta2 as $row)
									{
										echo "<option value=".$row[0].$row[1].">".$row[0]."   ".$row[1]." - ".$row[2]."   ".$row[3]."</option>";
									}
								?>
							</select>
						</td>
					</tr>
					
					<!--Creacion de una caja de texto -->
					<tr>			
						<h1 id="Mensaje"></h1>
						<td>Fecha Salida:</td>
						<td><input type="text" name="txtFechaSalida" id="idFechaSalida"onClick="popUpCalendar(this, frmRealizarRuta.idFechaSalida, 'dd/mm/yyyy');" size="20">
						</td>
					</tr>
					
					<!--Creacion de una caja de texto -->					
					<tr>					
						<td>Hora Salida:</td>
						<td><input type="text" value="" name="txtHora" id="idHoraSalida"/></td>
					</tr>
					
					<!--Creacion de una caja de texto -->
					<tr>
						<td>Precio por zona:</td>
						<td><input type="text" value="" name="txtPrecioZona" id="idPrecioZona" />colones</td>
					</tr>
					
					<!--Creacion de una caja de texto -->
					<tr>
						<td>Ruta exacta:</td>
						<td><textarea name="texaComentarios" id="idRutaExacta" rows="6" cols="40"></textarea></td>
					</tr>
										
					<!--Creacion de los botones -->
					<tr>
						<!--Creacion de un boton encargado de validar -->
						<td><input id="oboton"type="button" value="Registrar" onClick="validarVacios(get(idfrmRealizarRuta))"/></td>
						<!--Creacion de un boton encargado de limpiar -->
						<td><input type="button" id="oboton" name="btLimp" value="Limpiar"onClick="reset()"/></td>
					</tr>					
				</table>
			</form>
			
		<?php
			//Agregar Ruta
			$consulta3=$gestor->cargarVinculo();
			$placa=$_POST['sltPlaca'];

			$placaCC=substr($placa, 1, 7);

			$id=substr($placa, 0, 1);

			if(array_key_exists('sltPlaca',$_POST)){
				
				if(substr($placa=$_POST['sltPlaca'], 0, 1)=='C'){
					
					$chofer=$_POST['sltChofer'];					
					$puntoSalida=$_POST['txtSalida'];
					$puntoLlegada=$_POST['txtLlegada'];
					$fechaSalida=$_POST['txtFechaSalida'];
					$fechaLlegada=$_POST['txtFechaLlegada'];
					$horaSalida=$_POST['txtHora'];
					$horaLlega=$_POST['txtHoraLlegada'];
					$precioRuta=$_POST['txtPrecioZona'];
					$kilometrajeLlegada=$_POST['txtKIda'];
					$kilometrajeRegreso=$_POST['txtKmRegreso'];
					$comentarios=$_POST['texaComentarios'];
					$gestor->agregarRutaCamion($chofer, $placaCC, $puntoSalida,$puntoLlegada, $horaSalida, $horaLlega, $precioRuta, $kilometrajeLlegada, $kilometrajeRegreso, $comentarios, $fechaSalida,$fechaLlegada);
					echo "<script Language='Javascript'>";
					echo "alert('La ruta se ha registrado exitosamente');";
					echo "</script>";
				}else{
					//$placaa=substr($placa=$_POST['sltPlaca'], 0, 7);
					$chofer=$_POST['sltChofer'];
					$puntoSalida=$_POST['txtSalida'];
					$puntoLlegada=$_POST['txtLlegada'];
					$fechaSalida=$_POST['txtFechaSalida'];
					$fechaLlegada=$_POST['txtFechaLlegada'];
					$horaSalida=$_POST['txtHora'];
					$horaLlega=$_POST['txtHoraLlegada'];
					$precioRuta=$_POST['txtPrecioZona'];
					$kilometrajeLlegada=$_POST['txtKIda'];
					$kilometrajeRegreso=$_POST['txtKmRegreso'];
					$comentarios=$_POST['texaComentarios'];
					$idVinculo=1;
					//$idVinculo=substr($placa=$_POST['sltPlaca'], 14, 1);
					$gestor->agregarRutaVinculo($chofer, $placaCC, $puntoSalida,$puntoLlegada, $horaSalida, $horaLlega, $precioRuta, $kilometrajeLlegada, $kilometrajeRegreso, $comentarios, $fechaSalida,$fechaLlegada, $idVinculo);
					echo "<script Language='Javascript'>";
					echo "alert('La ruta se ha registrado exitosamente');";
					echo "</script>";
				}
			}
			?>

		</div>
		<div id="copyright">Copyright &copy; 2012<a href="mailto:matrixsolutionsint@gmail.com">Matrix Solutions</a></div>
	</body>
</html>