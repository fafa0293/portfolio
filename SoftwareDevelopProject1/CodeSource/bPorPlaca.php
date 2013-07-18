<!DOCTYPE HTML>
<html>
	<head>
		<title>Buscar por Placa</title>		
		<!-- Elaborado: Sebastian Lapcevic
		Fecha de creacion:07/02/2012 11:15a.m
		Ultima modificacion:07/02/2012 11:26a.m-->
		
		<!--Enlace con la hoja de estilo -->
		<link type="text/css" href="hojaDeEstilo.css" rel="stylesheet" />  
		
		<script language="javascript">
		
			//Entrada: id 
			//Salida: Ninguna
			//Funcionamiento:Pone el cursor en el primer objeto donde debe escribir el usuario. 
			function get(id){
				return document.getElementById(id);
			}
			
			
			/*Entrada: Todos los objetos del formulario.
			Salida: El envío de los datos del formulario si todos los datos son correctos.
			Funcionamiento: Analiza progresivamente objeto por objeto, el antecesor debe 
			cumplir el formato para evaluar el siguiente, usando el ID para validar
			*/
			function validar(formulario){
				formulario.submit();
			}
		</script>
	</head>
	
	<body>
		<?php
			include "Gestor.php";
			$gestor= new Gestor();
			$consulta=$gestor->cargarPlacaC();
			$consulta1=$gestor->cargarPlacaE();
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
	
	<!-- Inicio del Formulario -->
	<div id="form">
			<h1>Buscar por Placa</h1>
			<p>Seleccione le placa del equipo, cabezal o cami&oacute;n que desea encontrar</p>
			<form id="idFormulario" name="formulario" action="bPorPlaca.php" method="post">
				<table id="tabla">
					<tr>
						<td><br></td>
						<td></td>
					</tr>
					<tr>
						<td>Placa</td>
						<td>
							<select name="sltChofer" id="idsltChofer">
									<option value="SELECT">--Seleccionar--</option>
									<?php
										foreach($consulta as $row)
										{
											echo "<option value=".$row[0].">".$row[0]."</option>";
										}
										
										foreach($consulta1 as $row)
										{
											echo "<option value=".$row[0].">".$row[0]."</option>";
										}
									?>
							</select>
						</td>
					</tr>
					<tr>
						<td><input type="button" id="oboton" value="Buscar" onClick="validar(get('idFormulario'))"/></td>
						<td><input type="reset" id="oboton" value="Limpiar" onClick="seleccionar(idFormulario)"/></td>
					</tr>
				</table>
			</form>
			<?php
				if(array_key_exists('sltChofer',$_POST))
				{
					$criterio=$_POST['sltChofer'];
					if($criterio[0]=="C"){
						$consulta=$gestor->cargarPlacaCCWherePlaca($criterio);
						If(count($consulta)==0)
						{
							echo "<p><font color='red'>La consulta no obtuvo resultados</font></p>";
						}else{
								echo "<p><font color='red'> Los resultados de la busqueda son: </font></p>";
								echo "<table border=1>";
								//fila1
								echo "<tr>";
								echo "<td>PlacaCC</td>";				
								echo "<td>VIN</td>";	
								echo "<td>Marca</td>";				
								echo "<td>Anno</td>";	
								echo "<td>Cilindraje</td>";
								echo "<td>Combustible</td>";				
								echo "<td>Transmision</td>";	
								echo "<td>Kilometraje</td>";				
								echo "<td>Equipamiento</td>";	
								echo "<td>Largo</td>";
								echo "<td>Tipo</td>";
								echo "<td>Comentarios</td>";
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
									echo "</tr>";						
								}
								echo "</table>";
							 }
						 }else if ($criterio[0]=="S"){
					$consulta=$gestor->cargarPlacaEWherePlaca($criterio);
					If(count($consulta)==0)
					{
						echo "<p><font color='red'>La consulta no obtuvo resultados</font></p>";
					}else{
							echo "<p><font color='red'> Los resultados de la busqueda son: </font></p>";
							echo "<table border=1>";
							//fila1
							echo "<tr>";
							echo "<td>PlacaE</td>";				
							echo "<td>Largo</td>";	
							echo "<td>Ancho</td>";				
							echo "<td>Alto</td>";	
							echo "<td>Capacidad</td>";
							echo "<td>Carga</td>";				
							echo "<td>Tipo</td>";	
							echo "<td>Comentarios</td>";				
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
								echo "</tr>";						
							}
							echo "</table>";
						 }
				}
				}
			?>
		</div>	
		<div id="copyright">Copyright &copy; 2012<a href="mailto:matrixsolutionsint@gmail.com">Matrix Solutions</a></div>
	</body>
</html>