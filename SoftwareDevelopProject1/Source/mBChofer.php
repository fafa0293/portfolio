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
        	if(get('idsltChofer').value=="SELEC"){
				alert("Seleccione el nombre que desea buscar");
				return false;
			}else{
				buscar();
			}
        }
        //Entrada:
		//Salida:
		//Funcionamiento: hace el enlace con la pagina con los resultados
        function buscar(){
        	frmMChofer.submit();
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
			$consulta=$gestor->cargarChoferes();
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
			<h1>Modificar Chofer</h1>
			<p>Busque el chofer al que desea modificar.</p>
			<form name="frmMChofer" id="idfrmMChofer" action="mBChofer.php" method="post"><!--Inicio del formulario-->
				<table>
					<tr>
						<td valign="top">
							Nombre:
						</td>
						<td >
							<select name="sltChofer" id="idsltChofer"><!--Caja de seleccion para la busqueda del chofer-->
								<option value="SELEC">--Seleccionar---</option>
								<?php
									foreach($consulta as $row){
										echo "<option value=".$row[0].">".$row[0]." - ".$row[1]."</option>";
									}
								?>
							</select>
						</td>
					</tr>
					<tr>
						<td colspan="2" align="center" valign="top" >
							<input type="button" id="oboton" name="btReg" value="Buscar" onClick="Validar(get('idfrmMChofer'))"/> <!--Boton para inciar la busqueda--><input type="button" id="oboton" name="btLimp" value="Limpiar"onClick="reset();PoneCursor()"/><!--Boton para limpiar la caja de seleccion-->
						</td>
					</tr>
				</table>
			</form>
			<?php
				if(array_key_exists('sltChofer',$_POST))
				{
					$criterio=$_POST['sltChofer'];
					$consulta=$gestor->cargarChoferesWhereId($criterio);
					If(count($consulta)==0)
					{
						echo "<p><font color='red'>La consulta no obtuvo resultados</font></p>";
					}else{
							echo "<p><font color='red'> Los choferes son: </font></p>";
							echo "<table border=1>";
							//fila1
							echo "<tr>";
							echo "<td>Cedula</td>";				
							echo "<td>Nombre</td>";	
							echo "<td>Telefono1</td>";
							echo "<td>Telefono2</td>";
							echo "<td>Telefono3</td>";				
							echo "<td>Fecha de Vencimiento de la Lic.</td>";	
							echo "<td>Comentarios</td>";
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
								echo "<td><a href=mChofer.php?id=".$fila[0].">Modificar</a></td>";
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
