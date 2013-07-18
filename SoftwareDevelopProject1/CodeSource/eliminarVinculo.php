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
				if(get("txtCabezal").value==""){
						alert("Ingrese un número de cabezal.");
						return false;
				}else if(get("txtEquipo").value==""){
								alert("Ingrese un número de equipo.");
								return false;
					}				
					if(confirm("¿Est\u00E1 seguro que desea eliminar este v\u00EDnculo?")){
						get('frmEliminarVinculo').submit();
					}else{
						alert("Se ha cancelado la eliminaci\u00F3n.");
					}
			}
		</script>
	</head>
		<?php
		
			include "Gestor.php";
			$gestor= new Gestor();
			$refrescar=false;
			if(array_key_exists('idc',$_GET))
			{
				$vinculo=$gestor->cargarVinculoWhereIds($_GET['idc'], $_GET['ide']);
				$refrescar=true;
			}
			
			//si se trata de un postback se verifica si se presionó el botón de modificar********************
			if(array_key_exists('txtCod',$_POST)){
				$codigo=$_POST['txtCod'];
				$placaCC=$_POST['txtCabezal'];
				$placaE=$_POST['txtEquipo'];
				$gestor->eliminarVinculo($placaCC, $placaE, $codigo);
				echo "<script language='JavaScript'>";
				echo "alert('El vínculo fue eliminado con éxito');";
				echo "document.location = 'eliminarBVinculo.php';";
				echo "</script>";	


			}
		?>
	
	<body>

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
			<p>Elimine el v&iacute;nculo.</p>
			<form method="post" action="eliminarVinculo.php" name="frmEliminarVinculo" id="frmEliminarVinculo">

				<table id="tabla">

				
					<tr>
				
						<td colspan="2">
							 Placa de cabezal:<input type="text"  id="txtCabezal" name="txtCabezal" value="<?php if ($refrescar) {echo $vinculo[1];}?>" />
							 <input type="hidden" id="txtCod" name="txtCod" value="<?php if ($refrescar) {echo $vinculo[0];}?>" />
						</td>
					
						<td>
						</td>	
					</tr>
						
					<tr>
					<br>

						<td colspan="2">
							Placa de equipo: <input type="text"  id="txtEquipo" name="txtEquipo" value="<?php if ($refrescar) {echo $vinculo[2];}?>" /> 
						</td>
						
						<td>
						</td>
					</tr>
					<tr>

						<td><input type="button" id="oboton" value="Eliminar" onClick="validar()"/></td>&nbsp;&nbsp;&nbsp;
						
					</tr>

				</table>

			</form>

		</div>	
		<div id="copyright">Copyright &copy; 2012<a href="mailto:matrixsolutionsint@gmail.com">Matrix Solutions</a></div>
		
	</body>

</html>