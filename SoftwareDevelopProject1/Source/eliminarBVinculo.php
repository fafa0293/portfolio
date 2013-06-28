<!DOCTYPE HTML>
<html>

	<head>
		<title>Eliminar Vinculo</title>

		<!-- Elaborado: Alejandro Juarez

		Fecha de creacion:30/03/2012 11:15 a.m.

		Ultima modificacion:10/04/2012 11:25a.m-->
		
		<!--Enlace con la hoja de estilo -->
		<link type="text/css" href="hojaDeEstilo.css" rel="stylesheet" />  
			
		<script language="javascript">
			
			function get(id){
				return document.getElementById(id);
			}
			
			//valida que nada esta sin seleccionar
			function validar(){
				if(!get("rbtCabezal").checked && !get("rbtEquipo").checked){
								alert("Seleccione el tipo de placa.");
								return false;
						}else if(get("sltEquipo").value=="selec" && get("rbtEquipo").checked){
										alert("Seleccione la placa del equipo.");
										return false;
								}else if(get("sltCabezal").value=="selec" && get("rbtCabezal").checked){
													alert("Seleccione la placa de cabezal.");
													return false;
										}
								get('frmEliminarBVinculo').submit();
			}
			//habilita la caja de seleccion
			function habilitar(control){
				control.disabled=false;
				return false;
			} //deshabilita la caja de seleccion
			function deshabilitar(control){
				control.disabled=true;
				if(control.value!="selec"){
					control.value="selec";
					}
				return false;
			}
		</script>
		.
	</head>

	<body>
	
		<?php
			include "Gestor.php";
			$gestor = new Gestor();
			$consultaUno = $gestor->cargarPlacaCabezal();
			$consultaDos = $gestor->cargarPlacaEquipo();
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
			<h1> Eliminar vínculo cabezal/equipo</h1>
			<p>Seleccione un v&iacute;nculo que desee eliminar.</p>
			<form method="post" action="eliminarBVinculo.php" name="frmEliminarBVinculo" id="frmEliminarBVinculo">

				<table id="tabla">

					<tr>

						<td><br></td>

						<td></td>
						<td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td><!-- unica manera de que se expanda la tabla sin modificar el css-->

					</tr>

	
					<tr>
						<td colspan="3">Seleccione cu&aacute;l desea buscar:
							
						</td>
					</tr>
					
					<tr>
						<td><br></td>
					</tr>
					<tr>
				
						<td colspan="2">
							<input type="radio"  id="rbtCabezal" name="rbtTipo" method="post" onClick="habilitar(sltCabezal);deshabilitar(sltEquipo)" /> Placa de cabezal:
						</td>
					
						<td>
							<select id="sltCabezal" name="sltCabezal" disabled="true">
								<option value="selec">--Seleccionar--</option>
								<?php
									foreach($consultaUno as $row)
									{
										echo "<option value=".$row[0].">".$row[0]."</option>";
									}
								?>	 <!-- estas opciones son las decabezal -->
							</select>
						</td>	
					</tr>
						
					<tr>
					<br>

						<td colspan="2">
							<input type="radio"  id="rbtEquipo" name="rbtTipo" onClick="habilitar(sltEquipo);deshabilitar(sltCabezal)" /> Placa de equipo:
						</td>
						
						<td>
							<select id="sltEquipo" name="sltEquipo" disabled="true">
								<option value="selec">--Seleccionar--</option>
								<?php
									foreach($consultaDos as $row)
									{
										echo "<option value=".$row[0].">".$row[0]."</option>";
									}
								?>    <!-- estas opciones son las de equipo-->

							</select>
						</td>

					<tr>

						<td><input type="button" id="oboton" value="Buscar" onClick="validar()"/></td>&nbsp;&nbsp;&nbsp;

						<td>&nbsp;&nbsp;<input type="reset" id="oboton" value="Limpiar" /></td>

					</tr>

				</table>

			</form>
		<?php
			if(array_key_exists('sltCabezal',$_POST)){
				$placaCabezal=$_POST['sltCabezal'];
				$consultaC=$gestor->cargarVinculoCC($placaCabezal);
				If(count($consultaC)==0){
					echo "<p><font color='red'>La consulta no obtuvo resultados</font></p>";
				}else{
					echo "<p><font color='red'> Las placas vinculadas son: </font></p>";
					echo "<table border=1>";
					//fila1
					echo "<tr>";
					echo "<td>Placa Equipo:</td>";
					echo "<td></td>";
					echo "</tr>";
					//fila 2
					$fila=array();
					foreach($consultaC as $fila)
					{
						echo "<tr>";
						echo "<td>".$fila[0]."</td>";
						echo "<td><a href=eliminarVinculo.php?idc=".$placaCabezal."&ide=".$fila[0].">Eliminar</a></td>";
						echo "</tr>";						
					}
					echo "</table>";
				}
			} else 
			if(array_key_exists('sltEquipo',$_POST)){
				$placaEquipo=$_POST['sltEquipo'];
				$consultaE=$gestor->cargarVinculoE($placaEquipo);
				If(count($consultaE)==0){
					echo "<p><font color='red'>La consulta no obtuvo resultados</font></p>";
				}else{
					echo "<p><font color='red'> Las placas vinculadas son: </font></p>";
					echo "<table border=1>";
					//fila1
					echo "<tr>";
					echo "<td>Placa Cabezal:</td>";
					echo "<td></td>";
					echo "</tr>";
					//fila 2
					$fila=array();
					foreach($consultaE as $fila)
					{
						echo "<tr>";
						echo "<td>".$fila[0]."</td>";
						echo "<td><a href=eliminarVinculo.php?idc=".$fila[0]."&ide=".$placaEquipo.">Eliminar</a></td>";
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