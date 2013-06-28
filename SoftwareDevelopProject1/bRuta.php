<!DOCTYPE HTML>
<html>
	<head>
		<title>Buscar Ruta</title>
		<!--Elaborado por: Jonathan Jara Morales-->
        <!--Fecha de creación:28/03/2012 9:06 am--> 
        <!--Ultima modificación: 28/03/2012 2:00 am--> 
	
		<!--Enlace con la hoja de estilo -->
		<link type="text/css" href="hojaDeEstilo.css" rel="stylesheet" />  
				
		<script language = "javascript">		
		
			//Entrada: id 
			//Salida: Ninguna
			//Funcionamiento:Pone el cursor en el primer objeto donde debe escribir el usuario. 
			function get(id){ 
				return document.getElementById(id);
			}
			
			//Entrada: Ninguna 
			//Salida: Ninguna
			//Funcionamiento: Poner el puntero en el primer objeto donde va a escribir el usuario 	
			function puntero(){
				frmBuscarRuta.idsltChofer.focus();
			}
			
			/*Entrada: Todos los objetos del formulario.
			Salida: El envío de los datos del formulario si todos los datos son correctos.
			Funcionamiento: Analiza progresivamente objeto por objeto, el antecesor debe 
			cumplir el formato para evaluar el siguiente, usando el ID para validar
			*/
			function validar(Formulario){
				if(get('idsltChofer').value=="SELECT"){
					alert("Ingrese el número de placa");
					return false;
				}
	
					
					Formulario.submit();
				
				
				
			}
			
			//Entrada: Ninguna 
			//Salida: Ninguna
			//Funcionamiento: Limpia el formulario	
			function reset(){
				get(idfrmBuscarRuta).reset();
				return false;
			}
		</script>
	</head>
	
	<body onLoad = "puntero()">
		<?php
			include "Gestor.php";
			$gestor= new Gestor();
			$consulta=$gestor->cargarPlaca();
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
		<!--Inicio del formulario -->
		<div>
			<!-- Titulo principal de la pagina-->
			<h1>Buscar Ruta</h1>
			<p>Seleccione una placa para realizar la b&uacute;squeda de su ruta.</p>
			<form name="frmBuscarRuta" id="idfrmBuscarRuta" action="bRuta.php" method="post">
				<table id="tabla">
					<tr>
						<!-- Creacion de la caja de seleccion-->
						Placa:					
						<select name="sltChofer" id="idsltChofer">
								<option value="SELECT">--Seleccionar--</option>
								<?php
									foreach($consulta as $row)
									{
										echo "<option value=".$row[0].">".$row[0]."</option>";
									}
								?>
						</select>					
					</tr>
					<tr>
						<!-- Creacion del boton encargado de la validacion de la pagina-->
						<td><input type="button" id="oboton" value="Buscar" onClick="validar(get('idfrmBuscarRuta'))"/></td>
						<!-- Creacion del boton encargado de la limpieza-->
						<td><input type="button" id="oboton" name="btLimp" value="Limpiar"onClick="reset()"/></td>
					</tr>					
				</table>
			</form>

		

	<?php
		if(array_key_exists('sltChofer',$_POST))
		{
			$criterio=$_POST['sltChofer'];
			$consulta=$gestor->cargarRutasWherePlaca($criterio);
			If(count($consulta)==0)
			{
				echo "<p><font color='red'>La consulta no obtuvo resultados</font></p>";
			}else{
					echo "<p><font color='red'> La ruta es:</font></p>";
					echo "<table border=1>";
					//fila1
					echo "<tr>";
					echo "<td>Cedula</td>";				
					echo "<td>PlacaCC</td>";	
					echo "<td>IdVinculo</td>";				
					echo "<td>PuntoSalida</td>";	
					echo "<td>PuntoLlegada</td>";
					echo "<td>FechaSalida</td>";				
					echo "<td>FechaLlegada</td>";	
					echo "<td>HoraSalida</td>";				
					echo "<td>HoraLlegada</td>";	
					echo "<td>Kida</td>";
					echo "<td>KVenida</td>";
					echo "<td>Precio</td>";
					echo "<td>Ruta</td>";
					echo "</tr>";
					//fila 2
					$fila=array();
					foreach($consulta as $fila)
					{
						echo "<tr>";
						echo "<td>".$fila[0]."</td>";
						echo "<td>".$fila[1]."</td>";
						echo "<td>".$fila[2]."</td>";
						echo "<td>".$fila[3]."</td>";
						echo "<td>".$fila[4]."</td>";
						echo "<td>".$fila[5]."</td>";
						echo "<td>".$fila[6]."</td>";
						echo "<td>".$fila[7]."</td>";
						echo "<td>".$fila[8]."</td>";
						echo "<td>".$fila[9]."</td>";
						echo "<td>".$fila[10]."</td>";
						echo "<td>".$fila[11]."</td>";
						echo "<td>".$fila[12]."</td>";
						echo "</tr>";						
					}
					echo "</table>";
				 }
		}
	?>
		</div>
		<div id="copyright">Copyright &copy; 2012<a href="mailto:matrixsolutionsint@gmail.com">Matrix Solutions</a></div>
	</body>
</html>