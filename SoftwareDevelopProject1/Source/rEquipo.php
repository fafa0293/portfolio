<!DOCTYPE HTML>
<html>
	<head>
		<title>Registrar Equipo</title>
		<!-- Elaborado: Sebastian Lapcevic
		Fecha de creacion:07/02/2012 11:15a.m
		Ultima modificacion:07/02/2012 11:26a.m-->
		
			<!--Enlace con la hoja de estilo -->
		<link type="text/css" href="hojaDeEstilo.css" rel="stylesheet" />  
			
		
		
		<script language="javascript">
			function get(id){//Se usa esta funcion para no poner tanto codigo en el archivo
				return document.getElementById(id);
				}
				function seleccionar(idFormulario){
					get('idTipo').focus();
				}
				
				
			function validar(formulario){/*Recibe el formulario entero como parametro
			Realiza la validacion de la pagina, revisa que no hayan espacios en blanco
			y que todo este en el formato correcto*/
				if(get('idTipo').value=="Seleccionar"){
					alert("El campo del tipo de equipo no puede quedar vacío, seleccione los datos solicitados.");
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
					alert("El campo del ancho del equipo no puede quedar vacio, ingrese los datos solicitados");
					get('idAncho').focus();
					return false;
				}else if(get('idAlto').value==""){
					alert("El campo de la altura del equipo no puede quedar vacio, ingrese los datos solicitados");
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
				var conf=confirm("Desea registrar este equipo.");
				if (conf==false){
					alert("No se ha aceptado la confirmación.");
					return false;
				}else{
					alert("Se ha registrado el equipo exitosamente.");
				}
				formulario.submit();
			}
		</script>
		<!--Se hace la llamada a la hoja de estilo-->
		<link rel="stylesheet" type="text/css" href="hojaDeEstilo.css" />
	</head>
	<body onLoad="seleccionar(idFormulario)">
	<?php
		include "Gestor.php";
		$gestor= new Gestor();
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
		<div><!--Division que contiene el formulario-->
			<h1>Registrar Equipo</h1>
			<p>Ingrese los datos del equipo que desea registrar.</p>
			<form id="idFormulario" method="post" action="rEquipo.php">
				<table id="tabla">
					<tr>
						<td><br></td>
						<td></td>
					</tr>
					<tr>
						<td align="right">Tipo de Equipo</td>
						<td>
							<select id="idTipo" name="idTipo">
								<option>--Seleccionar--</option>
								<option>Plataforma</option>
								<option>Contenedor</option>
								<option>Furg&oacute;n</option>
							</select>
						</td>
					</tr>
					<tr>
						<td align="right">Placa</td>
						<td><input type="text" id="idPlaca" name="idPlaca">Ejemplo: S123123</td>
					</tr>

					<tr>
						<td align="right">Largo</td>
						<td><input type="text" id="idLargo" name="idLargo">Pies, Ejemplo: 40</td>

					</tr>
					<tr>
						<td align="right">Ancho</td>
						<td><input type="text" id="idAncho" name="idAncho">Pies, Ejemplo: 6</td>
					</tr>
					<tr>
						<td align="right">Alto</td>
						<td><input type="text" id="idAlto" name="idAlto">Pies, Ejemplo: 6</td>
					</tr>
					<tr>
						<td align="right">Capacidad</td>
						<td><input type="text" id="idCapacidad" name="idCapacidad">Toneladas, Ejemplo: 4</td>
					</tr>
					<tr>
						<td align="right">Carga Neta</td>
						<td><input type="text" id="idCargaNeta" name="idCargaNeta">Toneladas, Ejemplo: 4</td>
					</tr>
					<tr>
						<td align="right" valign="top">Comentarios</td>
						<td><textarea rows="6" cols="40" id="idComentario" name="idComentario"></textarea>
						</td>
					</tr>
					<tr>
						<td><input type="button" id="oboton" value="Registrar" onClick="validar(get('idFormulario'))"/></td><!--Llama a la funcion validar, y le envia como parametro el formulario entero-->
						<td><input type="reset" id="oboton" value="Limpiar" onClick="seleccionar(idFormulario)"/></td><!--Llama a la funcion seleccionar, y le envia como parametro el formulario entero-->
					</tr>
				</table>
			</form>
			<?php
			//Registrar el equipo
				if(array_key_exists('idPlaca',$_POST))
				{
					$tipo=$_POST['idTipo'];
					$placa=$_POST['idPlaca'];
					$largo=$_POST['idLargo'];
					$ancho=$_POST['idAncho'];
					$alto=$_POST['idAlto'];
					$capacidad=$_POST['idCapacidad'];
					$cargaNeta=$_POST['idCargaNeta'];
					$comentario=$_POST['idComentario'];	
					$gestor->registrarEquipo($placa,$tipo,$largo,$ancho,$alto,$capacidad,$cargaNeta,$comentario);
					echo "<p><font color='red'>El equipo fue registrado satisfactoriamente</font></p>";
				}
			?>
		</div>
		<div id="copyright">Copyright &copy; 2012<a href="mailto:matrixsolutionsint@gmail.com">Matrix Solutions</a></div>
	</body>
</html>