<!DOCTYPE html>
<html>
    <head>
			<!--Elaborado por: Roberto Barrett-->
			<!--Fecha de creación: 11.04.2012 10:pm-->
			<!--Ultima modificaciòn: 12.04.2012 12:00 am-->
        <title>Registrar cabezal camión</title>
        <link rel="stylesheet" type="text/css" href="hojaDeEstilo.css">
		<meta http-equiv="content-type" content="text/html; charset=utf-8">
        <Script language="javascript">
        	function get(id){ 
				return document.getElementById(id);
			}
			function PoneCursor(){
			    get("sltTipoTrans").focus();
                return true;
            }	
	//		<!--Expresiones regulares y formatos-->
			var errorMessage = "siga el formato del ejemplo";	
			var formatPlaca = /(^[C]{1})([1-9]{6}$)/;
			var formatVin = /(^[0-9]{17}$)/;
			var formatMarca = /^(\w{1,20})$/;
			var formatModelo = /(\w)/;   
			var formatFecha = /(^\d{4})$/;
			var formatCilin = /(^[^A-Za-z-0])(\d*$)/;
			var formatEquipamiento = /^(\w{1,20})$/;
			var formatKilo = /(^[^A-Za-z])(\d{1,5})$/;
			var formatLargo = /(^[^A-Za-z-0])(\d{1,3})$/;
			<!--Funcion para validar el formulario-->
			function validarFormulario(frmRegCabezal){
				
	//		<!--Validación del tipo de transporte -->	
		if (get("sltTipoTrans").value=="seleccionar"){
					alert("Debe selecccionar un tipo de transporte");
					get("sltTipoTrans").focus();
					return false;
			} else
				if (!get("sltTipoTrans").value=="seleccionar"){
					return true;
			}
	//		<!--Validación de la placa-->
			if (get("txtPlaca").value==""){
				alert("Introduzca un número de placa");
				get("txtPlaca").focus();
				return false;
			}
				if ((!get("txtPlaca").value.match(formatPlaca))){
					alert("A ingresado un número de placa inadecuado, " + errorMessage);
        			get("txtPlaca").select();
					return false;
				} else 
					if ((get("txtPlaca").value.match(formatPlaca))){
					
					}
	//		<!--Validación del número VIN-->
			if (get("txtVin").value==""){
				alert("Introduzca un número VIN");
				get("txtVin").focus();
				return false;
			}
				if ((!get("txtVin").value.match(formatVin))){
					alert("A ingresado un número VIN inadecuado, " + errorMessage);
        			get("txtVin").select();
					return false;
				} else 
					if ((get("txtVin").value.match(formatVin))){
					} 
	//		<!--Validación de marca-->	
			if (get("txtMarca").value==""){
				alert("Introduzca una marca de camión");
				get("txtMarca").focus();
				return false;
			}
				if ((!get("txtMarca").value.match(formatMarca))){
					alert("A ingresado un caracter inadecuado, " + errorMessage);
        			get("txtMarca").select();
					return false;
				} else 
					if ((get("txtMarca").value.match(formatMarca))){
					} 
	//		<!--Validación del modelo-->
			if (get("txtModelo").value==""){
				alert("Introduzca el modelo");
				get("txtModelo").focus();
				return false;
			}
				if ((!get("txtModelo").value.match(formatModelo))){
					alert("A ingresado un caracter inadecuado, " + errorMessage);
        			get("txtModelo").select();
					return false;
				} else 
					if ((get("txtModelo").value.match(formatModelo))){
					}
	//		<!--Validación del año-->
			if (get("txtFecha").value == ""){
				alert("Introduzca el Año");
				get("txtFecha").focus();
				return false;
			} 
				if ((!get("txtFecha").value.match(formatFecha))){
					alert("A ingresado un formato de año inadecuado, " + errorMessage);
        			get("txtFecha").select();
					return false;
					} else 
						if ((get("txtFecha").value.match(formatFecha))){
						}
	//		<!--Validación del cilindrada-->
			if (get("txtCilin").value == ""){
				alert("Introduzca un valor de cilindraje");
				get("txtCilin").focus();
				return false;
			} 
				if ((!get("txtCilin").value.match(formatCilin))){
					alert("A ingresado un número de cilindraje inadecuado, " + errorMessage);
        			get("txtCilin").select();
					return false;
					} else 
						if ((get("txtCilin").value.match(formatCilin))){
						}
	//		<!--Validación del equipamiento-->	
			if (get("txtEquipamiento").value == ""){
				alert("Introduzca el dato del equipamiento");
				get("txtEquipamiento").focus();
				return false;
			} 
				if ((!get("txtEquipamiento").value.match(formatEquipamiento))){
					alert("A ingresado un caracter inadecuado, " + errorMessage);
        			get("txtEquipamiento").select();
					return false;
					} else 
						if ((get("txtEquipamiento").value.match(formatEquipamiento))){
						}
	//		<!--Validación el kilometraje-->	
			if (get("txtKilometraje").value == ""){
				alert("Introduzca el kilometraje");
				get("txtKilometraje").focus();
				return false;
			} 
				if ((!get("txtKilometraje").value.match(formatKilo))){
					alert("A ingresado un dato de kilometraje inadecuado, " + errorMessage);
        			get("txtKilometraje").select();
					return false;
					} else 
						if ((get("txtKilometraje").value.match(formatKilo))){
						}
	//Validación del largo-->
			if (get("txtLargo").value == ""){
				alert("Introduzca la longitud de la unidad");
				get("txtLargo").focus();
				return false;
			} 
				if ((!get("txtLargo").value.match(formatLargo))){
					alert("A ingresado una longitud inadecuado, " + errorMessage);
        			get("txtLargo").select();
					return false;
					} else 
						if ((get("txtLargo").value.match(formatLargo))){
						}
				// Validación de la transmisión
				if ((get("rdbDiesel").checked == false || get("rdbGasolina").checked == false) && (get("rdbManual").checked == true && get("rdbAutomatica").checked == false && get("rdbHibrida").checked == false)){
					get("txtaComentario").focus(); <!--Transmisión manual-->
				} else
				if ((get("rdbDiesel").checked == false || get("rdbGasolina").checked == false) && (get("rdbManual").checked == false 					
					&& get("rdbAutomatica").checked == true && get("rdbHibrida").checked == false)){
					get("txtaComentario").focus();	<!--Transmisión automática-->
				} else
				if ((get("rdbDiesel").checked == false || get("rdbGasolina").checked == false) && (get("rdbManual").checked == false 	
					&& get("rdbAutomatica").checked == false && get("rdbHibrida").checked == true)){
					get("txtaComentario").focus();	<!--Transmisión hibrida-->		
				} 
	//			<!--Validación del combustible-->
				if (get("rdbDiesel").checked == false && get("rdbGasolina").checked == false){
					alert("Seleccione un tipo de combustible");
				return false;	
				} else
				if ((get("rdbManual").checked ==false && get("rdbAutomatica").checked ==false && get("rdbHibrida").checked ==false)){
					alert("Seleccione una transmisión");
				} 
				
				if (get("rdbDiesel").checked == true && get("rdbGasolina").checked == false){
	//				<!--Combustible Diesel-->
				} else
				if (get("rdbDiesel").checked == false && get("rdbGasolina").checked == true){
	//				<!--Combustible Gasolina-->
				}
				if ((get("rdbManual").checked == true 	
					|| get("rdbAutomatica").checked == true || get("rdbHibrida").checked == true) && get("txtaComentario").focus)
				if (confirm("¿Confirme si desea continuar con la modificaci\u00F3n?")) {
						// Respuesta afirmativa...
						frmRegCabezal.submit();
					}
		}
         </script>
         </head>
    <body onLoad="PoneCursor()">
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
       	<?php
		
			include "Gestor.php";
			$gestor= new Gestor();
			$empleado= array();
			$refrescar=false;
			$chkDis=false;
			$chkGas=false;
			$chkMan=false;
			$chkAuto=false;
			$chkHib=false;
			$chkCab=false;
			$chkCam=false;
			// para cargar los datos en los controles********************
			//echo "Ingreso al get 2";
			//$empleado=$gestor->consultarEmpleado($_GET['codigo']);
			//echo $empleado[0];echo $empleado[1];echo $empleado[2];echo $empleado[3];
			//$refrescar=true;
			//echo "refrescar".$refrescar;
			
					// para cargar los datos en los controles
			if(array_key_exists('id',$_GET))
			{
				$cabcami=$gestor->consultarCabezalCamion($_GET['id']);
				$refrescar=true;
				if($cabcami[6]=="Diesel"){
					echo"hola";
					$chkDis=true;
				}
				if($cabcami[6]=="Gasolina"){
					$chkGas=true;
				}
				if($cabcami[7]=="Manual"){
					$chkMan=true;
				}
				if($cabcami[7]=="Automatica"){
					$chkAuto=true;
				}
				if($cabcami[7]=="Hibrida"){
					$chkHib=true;
				}
				if($cabcami[11]=="Cabezal"){
					$chkCab=true;
				}
				if($cabcami[11]=="Camion"){
					$chkCam=true;
				}
			}
			
			//si se trata de un postback se verifica si se presionó el botón de modificar********************
			if(array_key_exists('txtPlaca1',$_POST)){
				$placa=$_POST['txtPlaca1'];
				$numVin=$_POST['txtVin1'];
				$marca=$_POST['txtMarca1'];
				$modelo=$_POST['txtModelo1'];
		        $fecha=$_POST['txtFecha1'];
		        $cilindrada=$_POST['txtCilin1'];
		        $equipamiento=$_POST['txtEquipamiento1'];
		        $kilometraje=$_POST['txtKilometraje1'];
		        $largo=$_POST['txtLargo1'];
		        $combustible=$_POST['rdbCombus'];
		        $transmision=$_POST['rbtTransmision'];
		        $comentario=$_POST['txtaComentario1'];
		        $tipoTrans=$_POST['sltTipoTrans1'];	
				$gestor->modificarCabezalCamion($placa, $numVin, $marca, $modelo, $fecha, $cilindrada, $combustible, $transmision, $kilometraje, $equipamiento, $largo, $tipoTrans, $comentario);
				echo "<script language='JavaScript'>";
				echo "alert('El Cami\u00F3n/Cabezal fue modificado con éxito');";
				echo "document.location = 'mBCabezalCamion.php';";
				echo "</script>";	


			}
		?>
                <h1>Modificar cabezal/camión</h1>
				<p>Ingrese los datos que desea cambiar.</p>
            <form id="frmRegCabezal" method="post" name="frmRegCabezal" action="mCabezalCamion.php">
                <table id="table1" >
                    <tr>
						<td>
						Tipo de transporte:
						</td>
						<td>
                        <select name="sltTipoTrans1" id="sltTipoTrans">
                            <option value="seleccionar">-Seleccione uno-</option>
                            <option id="Cabezal" value="Cabezal" <?php if($chkCab && $refrescar) {echo "selected='true'";}else{echo "";}?>>Cabezal</option>				
                            <option id="Camion" value="Camion" <?php if($chkCam  && $refrescar) {echo "selected='true'";}else{echo "";}?>>Cami&oacute;n</option>
                        </select>
                        </td>
					</tr>
                    <tr>
						<td>Placa:</td><td><input type="text" id="txtPlaca" name="txtPlaca1" readOnly="true" value="<?php if ($refrescar) {echo $cabcami[0];}?>" />Ej: C######</td>
					</tr>
                    <tr>
						<td>N&uacute;mero de VIN:</td><td><input type="text" id="txtVin" name="txtVin1" value="<?php if ($refrescar) {echo $cabcami[1];}?>" />Ej: 17 dígitos</td>
					</tr>
                    <tr>
						<td>Marca:</td><td><input type="text" id="txtMarca" name="txtMarca1" value="<?php if ($refrescar) {echo $cabcami[2];}?>" /></td>
					</tr>
                    <tr>
						<td>Modelo:</td><td><input type="text" id="txtModelo" name="txtModelo1" value="<?php if ($refrescar) {echo $cabcami[3];}?>" /></td>
					</tr>
                    <tr>
						<td>A&ntilde;o:</td><td><input type="text" id="txtFecha" name="txtFecha1" value="<?php if ($refrescar) {echo $cabcami[4];}?>" />Ej: ####</td>
					</tr>
                    <tr>
						<td>Cilindraje:</td><td><input type="text" id="txtCilin" name="txtCilin1" value="<?php if ($refrescar) {echo $cabcami[5];}?>" />c.c Ej: ####</td>
					</tr>
                    <tr>
						<td>Equipamiento:</td><td><input type="text" id="txtEquipamiento" name="txtEquipamiento1" value="<?php if ($refrescar) {echo $cabcami[9];}?>" /></td>
					</tr>
                    <tr>
						<td>Kilometraje:</td><td><input type="text" id="txtKilometraje" name="txtKilometraje1" value="<?php if ($refrescar) {echo $cabcami[8];}?>" />km Ej: 2/5 dígitos</td>
					</tr>
                    <tr>
						<td>Largo:</td><td><input type="text" id="txtLargo" name="txtLargo1" value="<?php if ($refrescar) {echo $cabcami[10];}?>" />Ft Ej: 2/3 dígitos</td>
					</tr>
                    <tr allign="left">
						<td>
							Tipo de conbustible:
						</td>
						<td>
							<input type="radio" value="Diesel" name="rdbCombus" id="rdbDiesel" <?php if ($chkDis && $refrescar) {echo "checked='true'";}else{echo "";}?>/>Diesel
							<input type="radio" value="Gasolina" name="rdbCombus" id="rdbGasolina" <?php if ($chkGas  && $refrescar) {echo "checked='true'";}else{echo "";}?>/>Gasolina
						</td>
					</tr><br><br>
                    <tr allign="left">
						<td>
							Transmisi&oacute;n:
						</td>
						<td>
                    		<input type="radio" name="rbtTransmision" id="rdbManual" value="Manual" <?php if ($chkMan  && $refrescar) {echo "checked='true'";}else{echo "";}?>/>Manual
                    		<input type="radio" name="rbtTransmision"   id="rdbAutomatica" value="Automatica" <?php if ($chkAuto  && $refrescar) {echo "checked='true'";}else{echo "";}?>/>Autom&aacute;tica
                    		<input type="radio" name="rbtTransmision" id="rdbHibrida" value="Hibrida" <?php if ($chkHib  && $refrescar) {echo "checked='true'";}else{echo "";}?>/>Hibrida
						</td><br>
					</tr>
                    <tr>
                        <td>Comentario:</td>
						<td>
							<textarea id="txtaComentario" name="txtaComentario1" value ="" rows="4" cols="40"><?php if ($refrescar) {echo $cabcami[12];}?></textarea>
                        </td>
                    </tr>
                    <tr>
					<td><input type="Button" id="oboton" value="Modificar" onClick="validarFormulario(document.frmRegCabezal)" ></td>
                    </tr>
                </table>
                </form>
            </div>
    </body>
</html>

