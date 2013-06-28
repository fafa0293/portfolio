<!DOCTYPE html>
<html>
    <head>
        <title>Buscar por tipo de transporte</title>
		<!--Elaborado por: Roberto Barrett-->
		<!--Fecha de creación: 11.04.2012 10:pm-->
		<!--Ultima modificaciòn: 12.04.2012 12:00 am-->
        <link rel="stylesheet" type="text/css" href="hojaDeEstilo.css">
        <meta http-equiv="content-type" content="text/html; charset=utf-8">
        <script language="javascript">
            function get(id){ 
                    return document.getElementById(id);
                }
                function PoneCursor(){
			    get("sltTipoTrans").focus();
                return true;
            }
			<!--Expresiones regulares y formatos-->
			var formatPlaca = /(^[C]{1})+([1-9]{6}$)/;
			<!--Mensaje de error-->
			var errorMessage = "siga el formato del ejemplo";
            <!--Funcion para validar el búsqueda-->
			function validarBusqueda(frmBusqueda){
                    <!--Validación del tipo de transporte -->	
		if (get("sltTipoTrans").value=="seleccionar"){
					alert("Debe selecccionar un tipo de transporte");
					get("sltTipoTrans").focus();
					return false;
			} else
				if (!get("sltTipoTrans").value=="seleccionar"){
					return true;
			} 
					get('frmBusqueda').submit();
					
			}
        </script>
    </head>
    <body onLoad="PoneCursor()">
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
        <div>	
        		<h1>Buscar por tipo de transporte</h1>
				<p>Ingrese el tipo de transporte para realizar la b&uacute;squeda.</p>
            <form id="frmBusqueda" name="frmBusqueda" method="post" action="bTipoTransporte.php">
                <table id="table2">
                    <th>Realice una búsqueda</th>
                    <tr>
						<td>
						Tipo de transporte:
						</td>
						<td>
                        <select name="sltTipoTrans" id="sltTipoTrans">
                            <option value="seleccionar">-Seleccione uno-</option>
                            <option value="Cabezal" id="Cabezal">Cabezal</option>				
                            <option value="Camion" id="Camion">Cami&oacute;n</option>
                        </select>
                        </td>
					</tr>
                    <tr>
                    	<td><input id="oboton" type="button" value="Buscar" onClick= "validarBusqueda(document.frmBusqueda)" /></td>
                    </tr><br>	
            	</table>
            </form>
            <?php
		if(array_key_exists("sltTipoTrans",$_POST)){
			$criterio=$_POST["sltTipoTrans"];
			$consulta=$gestor->buscartTipoTransporteWhere($criterio);
			If(count($consulta)==0){
				echo "<p><font color='red'>La búsqueda no obtuvo resultados</font></p>";
			}else{
					echo "<p><font color='red'>El resultado de búsqueda es: </font></p>";
					echo "<table border=1>";
					//Registro 1
					echo "<tr>";				
					echo "<td>PlacaCC</td>";	
					echo "<td>VIN</td>";				
					echo "<td>Marca</td>";	
					echo "<td>Modelo</td>";					
					echo "<td>Anno</td>";
					echo "<td>Cilindraje</td>";
					echo "<td>Combustible</td>";
					echo "<td>Transmision</td>";
					echo "<td>kilometraje</td>";
					echo "<td>Equipamiento</td>";
					echo "<td>Largo</td>";
					echo "<td>Tipo</td>";
					echo "<td>Comentario </td>";
					echo "</tr>";										
					$fila=array();
					foreach($consulta as $fila){
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
    </body>
</html>

