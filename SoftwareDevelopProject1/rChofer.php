<!DOCTYPE HTML>
<html>
	<head>
		<title>Registrar Chofer</title>
		
		<!--Enlace con la hoja de estilo -->
		<link type="text/css" href="hojaDeEstilo.css" rel="stylesheet" />  
			
	
		<!--Elaborado por: Fabian Vega -->
		<!--Fecha de creación: 28.03.2012 8:16 am-->
		<!--Ultima modificaciòn: 12.04.2012 6:00 pm-->

		<!--Se debe registrar chofer para mantener el control de cuales están 
		trabajando para la empresa, para lograr asignar satisfactoriamente 
		un chofer a una entrega, así como para mantener un registro de las 
		entregas con su respectiva información, entre ella, el chofer.-->
		
		<script Language="javascript">
		//Entrada:id
		//Salida:document.getElementById(id)
		//Funcionamiento: accion del document.getElementById 
		function get(id){ 
				return document.getElementById(id);
		}
		//Entrada:
		//Salida:
		//Funcionamiento: Colocar el cursor en la primera casilla
		function PoneCursor(){
                get('idNom').focus();
                return true;
        }
        //Entrada:control, lleno, chk
		//Salida:
		//Funcionamiento: habilitar o desabiltar y sus concecuencias las casillas extras de telefonos
        function habilitarlleno(control, lleno, chk){
        	if(chk.checked){
	        	if(get(lleno).value==""){
	        		alert("Para habilitar el este campo de Telefono debe de llenar el campo de Telefono anterior");
	        		get(lleno).focus();
	        		chk.checked=false;
	        		return false;
	        	}else{
	        		if(!validarTelForma(lleno)){
						chk.checked=false;
						return false;
					}
				}
	        	control.disabled=false;
	        	if(lleno="idTel1"){
	        		frmRegChof.chkhab3.disabled=false;
	        	}
				return false;
			}else{
				control.disabled=true;
				if(lleno=="idTel1"){
					frmRegChof.txtTel3.value="";
					frmRegChof.txtTel3.disabled=true;
					frmRegChof.chkhab3.disabled=true;
					frmRegChof.chkhab3.checked=false;
					frmRegChof.txtTel2.value="";
				}else{
					if(lleno=="idTel2"){
					frmRegChof.chkhab3.checked=false;
					frmRegChof.txtTel3.value="";
					}
				}
			}
        }
        //Entrada:formulario
		//Salida:
		//Funcionamiento: Validar todas las entradas del formulario
        function Validar(formulario){
        	if(get('idNom').value==""){
        		alert("Debe de ingresar el Nombre Completo");
        		get('idNom').focus();
        		return false;
        	}else{
        		var criterio=/^\D{1,70}$/
        		if(!criterio.test(get('idNom').value)){
        			alert("El formato del Nombre Completa es invalido\nDebe de contener como maximo 70 caracteres alfabeticos.");
        			get('idNom').select();
        			return false;
        		}else{
        			if(get('idCed').value==""){
        				alert("Debe de ingresar la C\u00E9dula");
		        		get('idCed').focus();
		        		return false;
        			}else{
        				var criterio=/^\d{1}\-{1}\d{3,4}\-{1}\d{3,4}$/
        				if(!criterio.test(get('idCed').value)){
        					alert("El formato de la C\u00E9dula es invalido\nDebe de introducirla con uno de los siguientes formatos:\n#-###-###\n#-####-####");
		        			get('idCed').select();
		        			return false;
        				}else{
        					if(get('idTel1').value==""){
        						alert("Debe de ingresar el numero de telefono 1");
				        		get('idTel1').focus();
				        		return false;
        					}else{
        						if(!validarTelForma('idTel1')){
        							return false;
        						}else{
        							if(frmRegChof.chkhab2.checked){
        								if(get('idTel2').value==""){
			        						alert("Debe de ingresar el numero de telefono 2");
							        		get('idTel2').focus();
							        		return false;
			        					}else{
			        						if(!validarTelForma('idTel2')){
			        							return false;
			        						}else{
			        							if(frmRegChof.chkhab3.checked){
			        								if(get('idTel3').value==""){
						        						alert("Debe de ingresar el numero de telefono 3");
										        		get('idTel3').focus();
										        		return false;
						        					}else{
						        						if(!validarTelForma('idTel3')){
						        							return false;    							
						        						}
						        					}
			        							}
			        						}
			        					}
        							}
    								if(get('idFechVen').value==""){
	        							alert("Debe de seleccionar la fecha de vencimiento de la licencia");
	        							get('idFechVen').focus();
	        							return false;
	        						}else{
	        							var criterio=/^[0-3]{1}[0-9]{1}\/{1}[0-1]{1}[0-9]{1}\/\d{4}$/
				        				if(!criterio.test(get('idFechVen').value)){
				        					alert("El formato de la Fecha es invalido\nDebe de ser:\ndd/mm/yyyy");
						        			get('idFechVen').select();
						        			return false;
						        		}else{
						        			if(confirm("\u00BFDesea registrar los datos\u003F")){
								        		frmRegChof.submit();
								        		return false;
								        	}
						        		}
	        						}
        						}
        					}
        				}
        			}
        		}
        	}
        	frmRegChof.submit();
        }
        //Entrada:id
		//Salida:
		//Funcionamiento: Validar el formato de los numeros de telefono
        function validarTelForma(id){
        	var criterio=/^\d{4}\-\d{2}\-\d{2}$/
				if(!criterio.test(get(id).value)){
					alert("El formato del N\u00FAmero de T\u00E9lefono es invalido\nDebe tener adem\u00E1s de los guiones solo caracteres num\u00E9ricos ordenados de la siguiente manera:\n####-##-##");
        			get(id).select();
        			return false;
        		}
        		return true;
        }
        //Entrada:
		//Salida:
		//Funcionamiento: Vaciar todas las casillas del formulario
        function reset(){
			get(idfrmRegChof).reset();
			return false;
		}
		</script>
		<script language='javascript' src="popcalendar.js"></script>
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
			<br>
			<h1>Registrar Chofer</h1>
			<p>Ingrese los datos necesarios para registrar el chofer.</p>
			<form name="frmRegChof" id="idfrmRegChof" method="post" action="rChofer.php">
				<table>
					<tr>
						<td>
							Nombre Completo:
						</td>
						<td>
							<input type="text" id="idNom" name="txtNom" value=""/><!--caja de nombre-->
						</td>
					</tr>
					<tr>
						<td>
							C&eacute;dula:
						</td>
						<td>
							<input type="text" id="idCed" name="txtCed" value=""/><!--Caja de cedula-->
						</td>
					</tr>
					<tr>
						<td valign="top">
							Tel&eacute;fonos:
						</td>
						<td>
							1<input type="text" id="idTel1" name="txtTel1" value="" size="19"/><br><!--Caja de telefono-->
							2<input type="text" id="idTel2" name="txtTel2" value="" disabled="true" size="19"/><input type="checkbox" id="idhab2" name="chkhab2" onClick="habilitarlleno(txtTel2, 'idTel1', chkhab2)"/><br><!--Caja de telefono-->
							3<input type="text" id="idTel3" name="txtTel3" value="" disabled="true" size="19"/><input type="checkbox" id="idhab3" name="chkhab3" onClick="habilitarlleno(txtTel3, 'idTel2', chkhab3)" disabled="true"/><!--Caja de telefono-->
						</td>
					</tr>
					<tr>
						<td>
							Fecha de vencimiento de la licencia:
						</td>
						<td>
							<input name="txtFecha" type="text" id="idFechVen" onClick="popUpCalendar(this, frmRegChof.idFechVen, 'dd/mm/yyyy');" size="10"><!--Caja de fecha de vencimiento-->
						</td>
					</tr>
					<tr>
						<td valign="top">
							Comentarios:
						</td>
						<td>
							<textarea id="idCom" name="txtCom" rows="6" cols="40"></textarea><!--Area de comentarios-->
						</td>
					</tr>
					<tr>
						<td colspan="2" align="center">
							<input type="button" id="oboton" name="btReg" value="Registrar" onClick="Validar(get('idfrmRegChof'))"/> <!--Boton ed registro--><input type="button" id="oboton" name="btLimp" value="Limpiar"onClick="reset();PoneCursor()"/><!--Boton para limpiar-->
						</td>
					</tr>
				</table>
			</form>
			<?php
			if(array_key_exists('txtNom',$_POST)){
				$nombre=$_POST['txtNom'];
				$cedula=$_POST['txtCed'];
				$telefono1=$_POST['txtTel1'];
				$telefono2=$_POST['txtTel2'];
				$telefono3=$_POST['txtTel3'];
				$fecha=$_POST['txtFecha'];
				$comentarios=$_POST['txtCom'];
				$gestor->agregarChofer($cedula,$nombre,$telefono1,$telefono2,$telefono3,$fecha,$comentarios);
				echo "<p><font color='red'>El Chofer fue registrado satisfactoriamente</font></p>";
			}
		?>
		</div>
		<div id="copyright">Copyright &copy; 2012<a href="mailto:matrixsolutionsint@gmail.com">Matrix Solutions</a></div>
	</body>
</html>
