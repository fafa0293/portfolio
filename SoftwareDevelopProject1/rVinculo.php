<!DOCTYPE HTML>
<html>

	<head>
		<title>Registrar Vinculo</title>
		<!--Enlace con la hoja de estilo -->
		<link type="text/css" href="hojaDeEstilo.css" rel="stylesheet" />  
			
		<!-- Elaborado: Alejandro Juarez

		Fecha de creacion:30/03/2012 11:45a.m

		Ultima modificacion:13/04/2012 11:51a.m-->
		
		<script language="javascript">
		
			//Reinicia el formulario.
			function resetear(){
				frmRegistrarVinculo.reset();
				return true;
			}
			
			function get(id){
				return document.getElementById(id);
			}
			
			//Valida que los campos no esten vacios.
			function validar(){
				if(get("sltCabezal").value=="selec"){
								alert("Seleccione un número de cabezal.");
								return false;
						}else if(get("sltEquipo").value=="selec"){
										alert("Seleccione un número de equipo.");
										return false;
						}
				validarPlaca();
				
			}

			//Valida que el formato de la placa de equipo y cabezal esten bien antes de registrarlas.
			function validarPlaca(){	
					if(confirm("¿Está seguro que desea registrar este vínculo?")){
									frmRegistrarVinculo.submit();
									return true;	
				}else{
					alert("No se registro ningún vínculo.");
				}
			}
		</script>

	</head>

	<body onLoad="resetear()">
		
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
		<div>
			<h1> Registrar Vínculo cabezal/equipo</h1>
			<p>Seleccione los datos necesarios para registrar el v&iacute;nculo.</p>
			<form method="post" action="rVinculo.php" name="frmRegistrarVinculo" id="frmRegistrarVinculo">

				<table id="tabla">

					<tr>

						<td><br></td>

						<td></td>

					</tr>

					<tr>
					
						<td>Placa de cabezal:</td>
						
						<td>
							<select id="sltCabezal" name="sltCabezal" > <!-- caja de seleccion con los diferentes cabezales -->
								<option value="selec">--Seleccionar--</option>
								<?php
									foreach($consultaUno as $row)
									{
										echo "<option value=".$row[0].">".$row[0]."</option>";
									}
								?>	 
							</select>
						</td>	
						
					</tr>
						
					<tr>

						<td>Placa de equipo:</td>
						
						<td>
							<select id="sltEquipo" name="sltEquipo" > <!-- caja de seleccion con los diferentes equipos -->
								<option value="selec">--Seleccionar--</option>
								<?php
									foreach($consultaDos as $row)
									{
										echo "<option value=".$row[0].">".$row[0]."</option>";
									}
								?>     
							</select>
						</td>
						
					</tr>
					<tr>

					</tr>

					<tr>

						<td><input type="button" id="oboton" value="Registrar" onClick="validar()"/></td>

						<td><input type="button" id="oboton" value="Limpiar" onClick="resetear()"/></td>

					</tr>

				</table>

			</form>
			
			<?php
			if(array_key_exists('sltCabezal',$_POST)){
				$placaCC=$_POST['sltCabezal'];
				$placaE=$_POST['sltEquipo'];
				$gestor->agregarVinculo($placaCC,$placaE);
				echo "<p><font color='red'>El vínculo fue registrado satisfactoriamente</font></p>";
			}
	?>

		</div>
		<div id="copyright">Copyright &copy; 2012<a href="mailto:matrixsolutionsint@gmail.com">Matrix Solutions</a></div>

	</body>

</html>