<!DOCTYPE HTML>
<html>
	<head>
	
			<!--Enlace con la hoja de estilo -->
		<link type="text/css" href="hojaDeEstilo.css" rel="stylesheet" />  
			
		
		<title>Busqueda Modificar Chofer</title>
		<!--Elaborado por: Fabian Vega -->
		<!--Fecha de creación: 28.03.2012 9:00 pm-->
		<!--Ultima modificaciòn: 12.04.2012 6:00 pm-->
		<script Language="javascript">
		//Entrada:id
		//Salida:document.getElementById(id)
		//Funcionamiento: accion del document.getElementById 
		function get(id){ 
				return document.getElementById(id);
		} 
		//Entrada:formulario
		//Salida:
		//Funcionamiento: Validar todas las entradas del formulario       
        function Validar(formulario){
        	if(get('idsltCabezalCamion').value=="SELEC"){
				alert("Seleccione la placa que desea buscar");
				return false;
			}else{
				formulario.submit();
			}
        }
        
        //Entrada:
		//Salida:
		//Funcionamiento: Vaciar todas las casillas del formulario
        function reset(){
			frmMChofer.reset();
			return false;
		}
		</script>
	</head>
	<body >
		<?php
			include "Gestor.php";
			$gestor= new Gestor();
			$consulta=$gestor->cargarPlacaC();
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
		<div>
			<br>
			<h1>Modificar Cabezal Cami&oacute;n</h1>
			<p>Realice la b&uacute;squeda para modificar el cabezal o cami&oacute;n</p>
			<form name="frmCabezalCamion" id="idfrmCabezalCamion" action="mBCabezalCamion.php" method="post"><!--Inicio del formulario-->
				<table>
					<tr>
						<td valign="top">
							Nombre:
						</td>
						<td >
							<select name="sltCabezalCamion" id="idsltCabezalCamion"><!--Caja de seleccion para la busqueda del chofer-->
								<option value="SELEC">--Seleccionar---</option>
								<?php
									foreach($consulta as $row){
										echo "<option value=".$row[0].">".$row[0]."</option>";
									}
								?>
							</select>
						</td>
					</tr>
					<tr>
						<td colspan="2" align="center" valign="top" >
							<input type="button" id="oboton" name="btReg" value="Buscar" onClick="Validar(get('idfrmCabezalCamion'))"/> <!--Boton para inciar la busqueda--><input type="button" id="oboton" name="btLimp" value="Limpiar"onClick="reset()"/><!--Boton para limpiar la caja de seleccion-->
						</td>
					</tr>
				</table>
			</form>
			<?php
				if(array_key_exists('sltCabezalCamion',$_POST))
				{
					$criterio=$_POST['sltCabezalCamion'];
					$consulta=$gestor->cargarPlacaCCWherePlaca($criterio);
					If(count($consulta)==0)
					{
						echo "<p><font color='red'>La consulta no obtuvo resultados</font></p>";
					}else{
							echo "<p><font color='red'>El transporte es: </font></p>";
							echo "<table border=1>";
							//fila1
							echo "<tr>";
							echo "<td>PlacaCC</td>";				
							echo "<td>VIN</td>";	
							echo "<td>Marca</td>";
							echo "<td>Modelo</td>";
							echo "<td>A&ntilde;o</td>";				
							echo "<td>Cilindraje</td>";	
							echo "<td>Combustible</td>";
							echo "<td>Transmision</td>";
							echo "<td>Kilometraje</td>";
							echo "<td>Equipamiento</td>";
							echo "<td>Largo</td>";
							echo "<td>Tipo</td>";
							echo "<td>Comentario</td>";
							echo "<td></td>";					
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
								echo "<td><a href=mCabezalCamion.php?id=".$fila[0].">Modificar</a></td>";
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
