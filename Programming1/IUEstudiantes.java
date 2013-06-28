



import java.io.*;


public class IUEstudiantes{

 public	static BufferedReader in = new BufferedReader(new InputStreamReader(System.in));
 public	static PrintStream out = System.out;	// variables objetos in y out para


	/******************************************************************
	* Modulo Principal que permite ejecutar la aplicaci�n
	*
	*******************************************************************/

	public static void main(String[] args)throws IOException{

		int opc;
		boolean noSalir = true;
		String[] listaMenu={"******Sistema de Control de Matr�cula******","",
							"1.  Agregar Estudiante",
							"2.  Agregar Profesor",
							"3.  Agregar grupo",
							"4.  Matricular estudiante",
						/*	"5.  Productores con al menos 1 entrega de 30 botellas",
							"6.  Pago para un productor",
							"7.  Mostrar listas",*/
							"8.  Probar Sistema",
							"9.  Reiniciar Sistema",
							"10. Salir"};

		do{
			mostrarMenu(listaMenu);
			opc = leerOpcion();
			noSalir = ejecutarAccion(opc);
		}while (noSalir);
	}

	/*****************************************************************
	 * Rutina: mostrarMenu
	 * Prop�sito: Presentar el men� de opciones
	 * Par�metros: plista
	 				La lista de opciones que debe tener el menu.
	 *
	 * Retorna:
	 *****************************************************************/

	static void mostrarMenu(String[] plista){

		out.println();

		for(int i=0;i<plista.length;i++){
			out.println(plista[i]);
		}
		out.println();
	}

	/*****************************************************************
	 * Rutina: leerOpcion
	 * Prop�sito: Obtener del usuario la opc��n escogida
	 * Par�metros:
	 *
	 * Retorna:
	 *****************************************************************/

	static int leerOpcion()throws java.io.IOException{

		int opcion;

		out.print("Seleccione su opcion: ");
		opcion = Integer.parseInt(in.readLine());
		out.println();

		return opcion;
	}

	/*****************************************************************
	 * Rutina: ejecutarAccion
	 * Prop�sito: Ejecutar la acci�n que corresponde a la opc��n escogida
	 * Par�metro: popcion
	 *
	 * Retorna: boolean
	 *			Un valor que indica si se desea continuar o salir del men�
	 *****************************************************************/

	static boolean ejecutarAccion(int popcion)throws java.io.IOException{


		boolean noSalir = true;
		int numProd=0;


		if (popcion >= 2 && popcion <= 7 && RutinasEstudiantes.obtenerTotalEstudiantes() == 0){
			out.println("No hay registrados ESTUDIANTES");
			return noSalir;
		}

		switch(popcion){


			case 1: //Opcion Agregar estudiante

				agregarEstudiante();
				imprimirDatosEstidiante();
				break;

			case 2:// Agregar Profesor

				 agregarPrefesor();

				break;

			case 3: //agregar un grupo al sistemas
			    agregarGrupo();
			    imprimirDatosGrup();
				break;


			case 4: //Matricular a un estudiante
				matricularEstudiante();

				break;

			case 5:
				break;

		   case 6:// obtener pago de un productor


			   break;

			case 7: //'Opcion Mostrar listas


				break;

			case 8: //Agrega datos para probar el sistema

				RutinasEstudiantes.probarSistema();
				out.println("Sistema listo para ser probado");

				break;

			case 9: //Reinicia el sistema borrando todos los datos

				RutinasEstudiantes.reiniciarSistema();
				out.println("Sistema reiniciado");

				break;

			case 10: //Salir de la aplicacion

				noSalir = false;
				break;

			default: //Cualquier otro valor dado por el usuario se considera inv�lido

				out.println("Opcion inv\u00a0lida");
				out.println();
				break;
		}
		return noSalir;
	}

	/*****************************************************************
	 * Rutina: agregarEstudiante
	 * Prop�sito: Obtener del usuario los datos del productor y registrarlos en
	 *			  el sistema.
	 * Par�metro:
	 *
	 * Retorna:
	 *****************************************************************/

	static void agregarEstudiante ()throws java.io.IOException{


		String numCarn�,nombreEst,apellidoEst;
		int i, indice;


		numCarn�=solicitarEstudiante();
		out.println();

		indice = RutinasEstudiantes.buscarEstudiante(numCarn�);

		if(indice == -1){     //Verificamos que no exista el estudiante

 			out.print("Deme el nombre del estudiante ");
			nombreEst =(in.readLine());
			out.println();

			out.print("Deme el apellido del estudiante ");
			apellidoEst =(in.readLine());
			out.println();

			RutinasEstudiantes.registrarEstudiante (numCarn�,nombreEst,apellidoEst);
			out.println("Estudiante  registrado satisfactoriamente");

		}else{

			out.println("Este estudiante ya a sido registrado");
		}

	}


	/*****************************************************************
	 * Rutina: solicitarEstudiante
	 * Prop�sito: Obtener del usuario el n�mero del  productor
	 * Par�metro:
	 *
	 * Retorna: int
	 *			El n�mero del productor
	 *****************************************************************/

	static String solicitarEstudiante()throws java.io.IOException{

		String numCarn�;

		out.println("Deme el numero de carne del estudiante  ");
		numCarn�=in.readLine();
		out.println();

		return numCarn�;
	}
		/*****************************************************************
	 * Rutina: agregarProfesor
	 * Prop�sito: Obtener del usuario los datos del productor y registrarlos en
	 *			  el sistema.
	 * Par�metro:
	 *
	 * Retorna:
	 *****************************************************************/

	static void agregarPrefesor()throws java.io.IOException{


		String  codigoProf,nombreProf,apellidoProf;
		int i, indice;


		 codigoProf= solicitarProfesor();
		 out.println();

		indice = RutinasEstudiantes.buscarProfesor( codigoProf);

		 if(indice==-1){     //Verificamos que no exista el estudiante

 			out.print("Deme el nombre del profesor ");
			nombreProf=(in.readLine());
			out.println();

			out.print("Deme el apellido del profesor ");
			apellidoProf =(in.readLine());
			out.println();

			RutinasEstudiantes.registrarProfesor (codigoProf,nombreProf,apellidoProf);
			out.println("Profesor  registrado satisfactoriamente");

		}else{
			out.println("Este profesor ya se encuentra registrado");
		}
	}

	 /*****************************************************************
	 * Rutina: solicitarProfesor
	 * Prop�sito: Obtener del usuario el n�mero del  productor
	 * Par�metro:
	 *
	 * Retorna: int
	 *			El n�mero del productor
	 *****************************************************************/

	static String solicitarProfesor()throws java.io.IOException{

		String codigoProf;

		out.println("Deme el codigo del profesor  ");
		codigoProf=(in.readLine());
		out.println();

		return  codigoProf;
	}
	/*****************************************************************
	 * Rutina: agregarGrupo
	 * Prop�sito: Obtener del usuario el n�mero del  productor
	 * Par�metro:
	 *
	 * Retorna: int
	 *			El n�mero del productor
	 *****************************************************************/

	static void agregarGrupo()throws java.io.IOException{

		String codigoGrupo,turno;
		String numAula;
		String cuposLibres;
		String profesor;
		String grado;
		int indiceGrupo;
        int indice;
        int intGrado;
        codigoGrupo= solicitarGrupo();

		indiceGrupo = RutinasEstudiantes.buscarGrupo (codigoGrupo);

		if(indiceGrupo==-1){     //Verificamos que no exista el estudiante


	        out.println("Deme el turno del grupo ");
			turno=(in.readLine());
			//out.println();

			out.println("Deme el numero de aula  ");
			numAula=(in.readLine());

			out.println("Deme el grado del grupo (1, 2, 3) ");
			grado=(in.readLine());
			intGrado=Integer.parseInt(grado);
			if(intGrado==3){
				RutinasEstudiantes.cantGrados[2]=RutinasEstudiantes.cantGrados[2]+1;
			}else{
				if(intGrado==2){
					RutinasEstudiantes.cantGrados[1]=RutinasEstudiantes.cantGrados[1]+1;
				}else{
					RutinasEstudiantes.cantGrados[0]=RutinasEstudiantes.cantGrados[0]+1;
				}
			}


            imprimirDatosProf();

	        do{
	        	profesor=solicitarProfesor();
                indice=RutinasEstudiantes.buscarProfesor(profesor);

	        }while(indice==-1);


			cuposLibres="10";

			RutinasEstudiantes.registrarGrupo(codigoGrupo,turno,numAula,profesor,cuposLibres,grado);

			out.println("Profesor  registrado satisfactoriamente");

		}else{
			out.println("Este grupo ya se encuentra registrado");
		}
	}
	/*
	 *****************************************************************
	 * Rutina: solicitarCodigoGrupo
	 * Prop�sito: Obtener del usuario el codigo del grupo
	 * Par�metro:
	 *
	 * Retorna: int
	 *			El n�mero del productor
	 *****************************************************************/

	 static String solicitarGrupo()throws java.io.IOException{
	 	String codigoGrup;

		out.println("Deme el codigo del grupo  ");
		codigoGrup=(in.readLine());
		out.println();

		return  codigoGrup;
	}


	/****************************************************************
	 * Rutina: imprimirDatosEstidiante
	 * Prop�sito: Obtener del usuario el n�mero del  productor
	 * Par�metro:
	 *
	 * Retorna: int
	 *			El n�mero del productor
	 *****************************************************************/
	 static void imprimirDatosEstidiante()throws java.io.IOException{
	 	int contEstudiantes;

	 	String[][]datos;

	 	datos=RutinasEstudiantes.obtenerDatosEstu();

	 	contEstudiantes=RutinasEstudiantes.obtenerTotalEstudiantes();

	 	out.print("datos del estudiante");

	 	 for (int i=0; i <contEstudiantes; i++){
		 for(int j=0;j<datos[i].length;j++){
		 	out.println();
		 	out.print( datos[i][j]+" / ");
		 	out.println();
		 }
	  }
   }
		/****************************************************************
	 * Rutina: imprimirDatosProf
	 * Prop�sito: Obtener del usuario el n�mero del  productor
	 * Par�metro:
	 *
	 * Retorna: int
	 *			El n�mero del productor
	 *****************************************************************/
	 static void imprimirDatosProf()throws java.io.IOException{

	 	int contProfesores;

	 	String[][]datosProf;

	 	datosProf=RutinasEstudiantes.obtenerDatosPro();

	 	contProfesores=RutinasEstudiantes.obtenerTotalProf();
	 	out.print("datos del profesores");
	 	out.println();
	 	out.println("Codigo / Nombre / Apellido");
	 	for (int i=0; i <contProfesores; i++){
	 		out.println();
		  	for(int j=0;j<datosProf[i].length;j++){
		 		out.print( datosProf[i][j]+" / ");

		 	}
		 out.println();
	   }
	  }
		 /****************************************************************
	 * Rutina: imprimirDatosGrup
	 * Prop�sito: Obtener del usuario el n�mero del  productor
	 * Par�metro:
	 *
	 * Retorna: int
	 *			El n�mero del productor
	 *****************************************************************/
	 static void imprimirDatosGrup()throws java.io.IOException{

	 	int contGrupos;

	 	String[][]datosGrup;

	 	datosGrup=RutinasEstudiantes.obtenerDatosGrup();

	 	contGrupos=RutinasEstudiantes.obtenerTotalGrup();
	 	out.print("datos de los Grupos");
	 	out.println();

	 	for (int i=0; i <contGrupos; i++){
		  for(int j=0;j<datosGrup[i].length;j++){
		 	 out.println();
		 	 out.print( datosGrup[i][j] +"/");
	         out.println();
		  }
	   }
	 }
	 /****************************************************************
	 * Rutina: matriculaEstudiante
	 * Prop�sito: matricular los estudiantes indicados en el grupo
	 *				indicado
	 * Par�metro:
	 * Retorna:
	 ****************************************************************/
	 static void matricularEstudiante()throws java.io.IOException{
	 	String numCarn�;
		String codigoGrupo;
		String sn;
		String menu;
		int indiceGrupo=-1;
		int indiceEst;
		String grado;

		numCarn� = solicitarEstudiante();

		indiceEst = RutinasEstudiantes.buscarEstudiante(numCarn�);

		if(indiceEst>-1){
		 	do{
		 		out.println("Introdusca el grado al que desea matricular:");
		 		grado=in.readLine();
		 	}while((!grado.equals("1"))&&(!grado.equals("2"))&&(!grado.equals("3")));
			do{
				out.println("El sistema matricula automaticamente al estudiante.\nDesea hacerlo manualmente?\ns. Si\nn. No");
				sn=in.readLine();
			}while((!sn.equals("s"))&&(!sn.equals("n")));
			if(sn.equals("s")){
				do{
					menu=RutinasEstudiantes.listaGrupos(grado);
					out.println(menu);
					out.println("Introdusca el codigo del grupo en que desea\nmatricular al estudiante");
					codigoGrupo=in.readLine();
					indiceGrupo=RutinasEstudiantes.buscarGrupo(codigoGrupo);
				}while((indiceGrupo==-1)&&(!codigoGrupo.equals("?")));
				if(!codigoGrupo.equals("?")){
					RutinasEstudiantes.matricula(indiceGrupo, indiceEst);
				}
			}else{
				indiceGrupo=RutinasEstudiantes.matriculaAutomatica(grado);
				if(indiceGrupo==-1){
					out.println("No hay cupos disponibles en el grado elegido");
				}else{
					RutinasEstudiantes.matricula(indiceGrupo, indiceEst);
				}
			}
			out.println("Matricula terminada satisfactoriamente");
		}else{
			out.println("Estudiante no registrado\nImposible Matricular");
		}

	 }
 }


