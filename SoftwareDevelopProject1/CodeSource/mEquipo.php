<!DOCTYPE HTML>
<html>
	<head>
		<title>Modicar Equipo</title>
		<!-- Elaborado: Sebastian Lapcevic
		Fecha de creacion:07/02/2012 11:15a.m
		Ultima modificacion:07/02/2012 11:26a.m-->
		
		<!--Enlace con la hoja de estilo -->
		<link type="text/css" href="hojaDeEstilo.css" rel="stylesheet" />  
			
		
		<script language="javascript">
			function get(id){//Se usa esta funcion para no poner tanto codigo en el archivo
				return document.getElementById(id);
				}
			function validar(formulario){/*Recibe el formulario entero como parametro
			Realiza la validacion de la pagina, revisa que no hayan espacios en blanco
			y que todo este en el formato correcto*/
				if(get('idTipo').value==""){
					alert("El campo del tipo de equipo no puede quedar vacío, ingrese los datos solicitados.");
					get('idTipo').focus();
					return false;
				}else if(get('idPlaca').value==""){
					alert("El campo de la placa no puede quedar vacío, ingrese los datos solicitados.");
					get('idPlaca').focus();
					return false;
				}else if(get('idLargo').value==""){
					alert("El campo del largo del equipo no puede quedar vacio, ingrese los datos solicitados.");
					get('idLargo').focus();
					return false;
				}else if(get('idAncho').value==""){
					alert("El campo del largo del equipo no puede quedar vacio, ingrese los datos solicitados");
					get('idAncho').focus();
					return false;
				}else if(get('idAlto').value==""){
					alert("El campo del largo del equipo no puede quedar vacio, ingrese los datos solicitados");
					get('idAlto').focus();
					return false;
				}else if(get('idCapacidad').value==""){
					alert("El campo de la capacidad del equipo no puede quedar vacio, ingrese los datos solicitados");
					get('idCapacidad').focus();
					return false;
				}else if(get('idCargaNeta').value==""){
					alert("El campo de la carga neta que puede cargar el equipo no puede quedar vacio, ingrese los datos solicitados.");
					get('idCargaNeta').focus();
					return false;
				}else{
					expresionRegular=/^(s|S){1}\d{6}$/;//Expresion regular de la placa
					oExpresionRegular= /^\d+$/;//Expresion regular para los datos que sean numeros
					if(!expresionRegular.test(get('idPlaca').value)){
						alert("El formato del campo de la placa es incorrecto, verifique que este introduciendo los datos correctos.");
						get('idPlaca').select();
						return false;
					}else if(!oExpresionRegular.test(get('idLargo').value)){
						alert("El formato del campo del largo es incorrecto, verifique que este introduciendo los datos correctos.");
						get('idLargo').select();
						return false;
					}else if(!oExpresionRegular.test(get('idAlto').value)){
						alert("El formato del campo de la altura es incorrecto, verifique que este introduciendo los datos correctos.");
						get('idAlto').select();
						return false;
					}else if(!oExpresionRegular.test(get('idAncho').value)){
						alert("El formato del campo del ancho es incorrecto, verifique que este introduciendo los datos correctos.");
						get('idAncho').select();
						return false;
					}else if(!oExpresionRegular.test(get('idCapacidad').value)){
						alert("El formato del campo de la capacidad es incorrecto, verifique que este introduciendo los datos correctos.");
						get('idCapacidad').select();
						return false;
					}else if(!oExpresionRegular.test(get('idCargaNeta').value)){
						alert("El formato del campo de carga neta es incorrecto, verifique que este introduciendo los datos correctos.");
						get('idCargaNeta').select();
						return false;
					}
				}
				var conf=confirm("Desea modificar los datos de este equipo?");
				if (conf==false){
					alert("No se ha aceptado la confirmacion.");
					return false;
				}
				formulario.submit();
			}
		</script>
		<link rel="stylesheet" type="text/css" href="hojaDeEstilo.css" />
	</head>
	<body onLoad="seleccionar(idFormulario)">
		 
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
		
		 
		<div><!--Division que contiene el formulario-->
		<?php
		
			include "Gestor.php";
			$gestor= new Gestor();
			$empleado= array();
			$refrescar=false;
			$plat=false;
			$cont=false;
			$furgon=false;
			
			// para cargar los datos en los controles********************
			//echo "Ingreso al get 2";
			//$empleado=$gestor->consultarEmpleado($_GET['codigo']);
			//echo $empleado[0];echo $empleado[1];echo $empleado[2];echo $empleado[3];
			//$refrescar=true;
			//echo "refrescar".$refrescar;
					// para cargar los datos en los controles
			if(array_key_exists('id',$_GET))
			{
				$equipo=$gestor->consultarEquipo($_GET['id']);
				$refrescar=true;
				if($equipo[1]=="Plataforma"){
					$plat=true;
				}
				if($equipo[1]=="Furgón"){
					$furgon=true;
				}
				if($equipo[1]=="Contenedor"){
					$cont=true;
				}
			}
			
			//si se trata de un postback se verifica si se presionó el botón de modificar********************
			if(array_key_exists('idPlaca',$_POST)){
				$placa=$_POST['idPlaca'];
				$tipo=$_POST['idTipo'];
				$largo=$_POST['idLargo'];
				$ancho=$_POST['idAncho'];
				$alto=$_POST['idAncho'];
				$capacidad=$_POST['idCapacidad'];
				$cargaNeta=$_POST['idCargaNeta'];
				$comentario=$_POST['idComentario'];
				$gestor->modificarEquipo($placa,$tipo,$largo,$ancho,$alto,$capacidad,$cargaNeta,$comentario);
				echo "<script language='JavaScript'>";
				echo "alert('El equipo fue modificado con éxito');";
				echo "document.location = 'mBEquipo.php';";
				echo "</script>";			
			}
		?>
			<h1>Modificar Equipo</h1>
			<p>Ingrese los datos que desea modificar del equipo.</p>
			<form id="idFormulario" action="mEquipo.php" method="post"><!--Formulario con la informacion-->
				<table id="tabla"><!--Tabla que contiene la informacion del formulario-->
					<tr>
						<td><br></td>
						<td></td>
					</tr>
					<tr>
						<td align="right">Tipo de Equipo</td>
						<td>
							<select id="idTipo" name="idTipo">
								<option>--Seleccionar--</option>
								<option <?php if($plat){echo"selected='true'";}else{echo"";} ?>>Plataforma</option>
								<option <?php if($cont){echo"selected='true'";}else{echo"";} ?>>Contenedor</option>
								<option <?php if($furgon){echo"selected='true'";}else{echo"";} ?>>Furgón</option>
							</select>
						</td>
					</tr>
					<tr>
						<td align="right">Placa</td>
						<td><input type="text" id="idPlaca" name="idPlaca" value="<?php if ($refrescar) {echo $equipo[0];}?>" readonly="true"></td>
					</tr>

					<tr>
						<td align="right">Largo</td>
						<td><input type="text" id="idLargo" name="idLargo" value="<?php if ($refrescar) {echo $equipo[2];}?>">Pies, Ejemplo: 40</td>

					</tr>
					<tr>
						<td align="right">Ancho</td>
						<td><input type="text" id="idAncho" name="idAncho" value="<?php if ($refrescar) {echo $equipo[3];}?>">Pies, Ejemplo: 6</td>
					</tr>
					<tr>
						<td align="right">Alto</td>
						<td><input type="text" id="idAlto" name="idAlto" value="<?php if ($refrescar) {echo $equipo[4];}?>">Pies, Ejemplo: 6</td>
					</tr>
					<tr>
						<td align="right">Capacidad</td>
						<td><input type="text" id="idCapacidad" name="idCapacidad" value="<?php if ($refrescar) {echo $equipo[5];}?>">Toneladas, Ejemplo: 4</td>
					</tr>
					<tr>
						<td align="right">Carga Neta</td>
						<td><input type="text" id="idCargaNeta" name="idCargaNeta" value="<?php if ($refrescar) {echo $equipo[6];}?>">Toneladas, Ejemplo: 4</td>
					</tr>
					<tr>
						<td align="right" valign="top">Comentarios</td>
						<td><textarea rows="5" cols="20" name="idComentario"><?php if ($refrescar) {echo $equipo[7];}?></textarea>
						</td>
					</tr>
					<tr>
						<td><input type="button" id="oboton" value="Modificar" onClick="validar(idFormulario)"/></td><!--Se llama la funcion validar, y se le envia como parametro el formulario entero-->
						<td><input type="reset" id="oboton" value="Limpiar"/></td><!--Se llama a la funcion seleccionar-->
					</tr>
				</table>
			</form>
		</div>
		<div id="copyright">Copyright &copy; 2012<a href="mailto:matrixsolutionsint@gmail.com">Matrix Solutions</a></div>
	</body>
</html>