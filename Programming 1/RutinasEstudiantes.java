

public class RutinasEstudiantes{


	static int cantEstudiantes = 0;
	static int cantProfesores = 0;
    static int cantGrupos = 0;

    public static int[] cantGrados = {0,0,0};

	private static String [][]datosEstudiantes = new String[60][4];
	private static String [][] datosProfesores = new String [6][3];
    private static String [][]datosGrupos = new String[6][6];
	/*****************************************************************
	 * Rutina: registrarEstudiante
	 * Propósito: Registrar los datos del Estudiante en el sistema
	 * Parámetro: pnumCarné
	 *			  Número del Carné
	 * Parámetro: pnombre
	 *			  Nombre del estudiante
	 * Parámetro: papellido
	 *			  Apellido del estudiante.
	 *
	 * Retorna:
	 *****************************************************************/

	public static void registrarEstudiante(String pnumCarné,String pnombre,String papellido){


		datosEstudiantes[cantEstudiantes][0]=pnumCarné;
		datosEstudiantes[cantEstudiantes][1]=pnombre;
		datosEstudiantes[cantEstudiantes][2]=papellido;

		cantEstudiantes++;

	}

  /*****************************************************************
	 * Rutina: buscarEstudiante
	 * Propósito: Verificar que el estudiante no se encuentre registrado
	 * Parámetro:pnumEstudiante
	 *          numero de identificación de cada estudiante
	 *Retorna: indice
	 * 			Índice donde se encuentra registrado el estudiante.
	 *
	 *NOTA: si el estudiante no esta en el sistema el retornara -1.
	 *****************************************************************/


	public static int buscarEstudiante(String pnumCarné){

		boolean encontrado = false;
		int indice = -1;

		for(int i=0;i<cantEstudiantes&&!encontrado;i++){
            if(datosEstudiantes[i][0].equals(pnumCarné)){
					encontrado = true;
					indice = i;
			 }

           }



		return indice;
	}
	/*****************************************************************
	 * Rutina: registrarProfesores
	 * Propósito: Registrar los datos del Estudiante en el sistema
	 * Parámetro: pnumCarné
	 *			  Número del Carné
	 * Parámetro: pnombre
	 *			  Nombre del estudiante
	 * Parámetro: papellido
	 *			  Apellido del estudiante.
	 *
	 * Retorna:
	 *****************************************************************/

	 public static void registrarProfesor(String pcodigoProf,String pnombreProf,String papellidoProf){


		datosProfesores[cantProfesores][0]=pcodigoProf;
		datosProfesores[cantProfesores][1]=pnombreProf;
		datosProfesores[cantProfesores][2]=papellidoProf;


		cantProfesores++;

  	 }
	/*****************************************************************
	 * Rutina: buscarProfesor
	 * Propósito: Verificar que el profesor no se encuentre registrado
	 * Parámetro:pnumEstudiante
	 *          numero de identificación de cada estudiante
	 *Retorna: indice
	 * 			Índice donde se encuentra registrado el estudiante.
	 *
	 *NOTA: si el estudiante no esta en el sistema el retornara -1.
	 *****************************************************************/


    public static int buscarProfesor(String pcodigoProf){

		boolean encontrado = false;
		int indice = -1;

		for(int i=0;i<cantProfesores&&!encontrado;i++){
            if(datosProfesores[i][0].equals(pcodigoProf)){
				encontrado = true;
				indice = i;

			  }

           }

		return indice;
	}
	/*****************************************************************
	 * Rutina: registrarGrupo
	 * Propósito: Verificar que el gripo no se encuentre registrado
	 *en el sistema
	 *           Codigo del grupo.
	 * Parámetro:pcodigoGrup
	 *		   indeice donde se encuentre  registrado el grupo
	 *  Retorna: indice
	 ****************************************************************/
	 public static void  registrarGrupo(String pcodigoGrup,String pturno,String pnumAula,String pprofesor,String pcuposLibres, String pgrado){


	 	datosGrupos[cantGrupos][0]=pcodigoGrup;
	 	datosGrupos[cantGrupos][1]=pprofesor;
	 	datosGrupos[cantGrupos][2]=pturno;
        datosGrupos[cantGrupos][3]=pcuposLibres;
        datosGrupos[cantGrupos][4]=pnumAula;
        datosGrupos[cantGrupos][5]=pgrado;


	 	cantGrupos++;



	 }

	/*****************************************************************
	 * Rutina: buscarGrupo
	 * Propósito: Verificar que el gripo no se encuentre registrado
	 *en el sistema
	 *           Codigo del grupo.
	 * Parámetro:pcodigoGrup
	 *		   indeice donde se encuentre  registrado el grupo
	 *  Retorna: indice
	 ****************************************************************/
	    public static int buscarGrupo (String pcodigoGrup){

	   	boolean encontrado = false;
		int indice = -1;

		for(int i=0;i<cantGrupos&&!encontrado;i++){
            if(datosGrupos[i][0].equals( pcodigoGrup)){
				encontrado = true;
				indice = i;
			 }

           }

		return indice;
	}


	    /****************************************************************
	 * Rutina: obtenerCuposLibres
	 * Propósito:
	 * Parámetro:
	 *
	 * Retorna:
	 ****************************************************************/



	/****************************************************************
	 * Rutina: obtenerTotalEstudiantes
	 * Propósito:
	 * Parámetro:
	 *
	 * Retorna:
	 ****************************************************************/


	public static int  obtenerTotalEstudiantes(){

		return cantEstudiantes;

	}
	/****************************************************************
	 * Rutina: obtenerTotalEstudiantes
	 * Propósito:
	 * Parámetro:
	 *
	 * Retorna:
	 ****************************************************************/


	public static int  obtenerTotalGrup(){

		return cantGrupos;

	}


   	/****************************************************************
	 * Rutina: obtenerTotalEstudiantes
	 * Propósito:
	 * Parámetro:
	 *
	 * Retorna:
	 ****************************************************************/


	public static int  obtenerTotalProf(){

		return cantProfesores;

	}


	/*****************************************************************
	 * Rutina: obtenerDatosEstu
	 * Propósito:Saber la cantidad de cupos libres por grupo
	 * Parámetro:
	 *
	 * Retorna:
	 *****************************************************************/

	public static String[][] obtenerDatosEstu(){

		 return datosEstudiantes;

	}

	/*****************************************************************
	 * Rutina: obtenerDatosEstu
	 * Propósito:Saber la cantidad de cupos libres por grupo
	 * Parámetro:
	 *
	 * Retorna:
	 *****************************************************************/

	public static String[][] obtenerDatosPro(){

		 return datosProfesores;

	}

	/*****************************************************************
	 * Rutina: obtenerDatosEstu
	 * Propósito:Saber la cantidad de cupos libres por grupo
	 * Parámetro:
	 *
	 * Retorna:
	 *****************************************************************/


	public static String[][] obtenerDatosGrup(){

		 return datosGrupos;

	}
	 /****************************************************************
	 * Rutina: matricula
	 * Propósito: Relacionar un estudiante registrado con un grupo
	 * Parámetro:Indice del grupo
	 *				pindiceGrupo
	 *			 Indice del Estudiante
	 *				pindiceEstudiante
	 * Retorna:
	 ****************************************************************/
	public static void matricula(int pindiceGrupo, int pindiceEstudiante){
		datosEstudiantes[pindiceEstudiante][3]=datosGrupos[pindiceGrupo][0];
		cuposLibres(pindiceGrupo);
	}
	/****************************************************************
	 * Rutina: cuposLibres
	 * Propósito: Reduce los cupos libres del grupo en el que se
	 *				matriculo el estudiante
	 * Parámetro:Indice del grupo
	 *				pindiceGrupo
	 * Retorna:
	 ****************************************************************/
	public static void cuposLibres(int pindiceGrupo){
		int libre;

		libre=Integer.parseInt(datosGrupos[pindiceGrupo][3]);

		datosGrupos[pindiceGrupo][3]=Integer.toString(libre-1);

	}
	/****************************************************************
	 * Rutina: matriculaAutomatica
	 * Propósito: Escoge automaticamente el grupo al que se va a
	 *				matricular el estudiante
	 * Parámetro:Grado a matircular
	 *				pgrado
	 * Retorna: Indice del grupo escogido automaticamente
	 ****************************************************************/
	public static int matriculaAutomatica(String pgrado){
		int libre;
		int mayor;
		int indiceGrupo;
		int[] indicesGrupos;

		indicesGrupos=buscaGrupo(pgrado);

		if(indicesGrupos[0]>=0){
			mayor=Integer.parseInt(datosGrupos[indicesGrupos[0]][3]);
			indiceGrupo=indicesGrupos[0];
			if(indicesGrupos.length>1){
				libre=Integer.parseInt(datosGrupos[indicesGrupos[1]][3]);
				if(libre>mayor){
					mayor=libre;
					indiceGrupo=indicesGrupos[1];
				}
			}
		}else{
			indiceGrupo=-1;
		}
		return indiceGrupo;

	}
	/****************************************************************
	 * Rutina: listaGrupos
	 * Propósito: Genera una lista del codigo del grupo y el codigo
	 *				del profesor segun el grado escogido
	 * Parámetro:Grado escogido
	 *				pgrado
	 * Retorna:lista de grupos
	 *				menu
	 ****************************************************************/
	public static String listaGrupos(String pgrado){
		String menu="Codigo de Grupo / Nombre del Profesor\n";
		int libre;
		int[] indices;
		int intGrado;

		indices=buscaGrupo(pgrado);
		intGrado=Integer.parseInt(pgrado);

		if(indices[0]>=0){
			for(int i=0; i<cantGrados[intGrado-1]; i++){
				libre=Integer.parseInt(datosGrupos[indices[i]][3]);
				if(libre>0){
					menu=menu+datosGrupos[indices[i]][0]+" / "+datosGrupos[indices[i]][1]+"\n";
				}
			}
		}else{
			menu=""+"No hay cupos disponibles en el grado elgido\nPorfavor presione '?' para salir...";
		}
		return menu;
	}
	/****************************************************************
	 * Rutina: buscaGrupo
	 * Propósito: Retorna un arreglo con los indices de los grupos
	 *				del grado escogido y que aun tengan cupo libre
	 * Parámetro:Grado escogido
	 *				pgrado
	 * Retorna:Arreglo de indices
	 *				indices
	 ****************************************************************/
	public static int[] buscaGrupo(String pgrado){
		int intGrado=Integer.parseInt(pgrado);
		int j=0;
		int[] indices;


		if(cantGrados[intGrado-1]>0){
			indices=new int[cantGrados[intGrado-1]];
			for(int i=0;i<cantGrupos;i++){
				if(datosGrupos[i][5].equals(pgrado)){
					indices[j]=i;
					j++;
				}
			}
		}else{
			indices=new int[1];
			indices[0]=-1;
		}
		return indices;
	}
	/****************************************************************
	 * Rutina: probarSistema
	 * Propósito: Agrega datos a las matrices para que el sistema
	 *				pueda ser probado
	 * Parámetro:
	 * Retorna:
	 ****************************************************************/
	public static void probarSistema(){

		int relleCantEstudiantes = 12;
		int relleCantProfesores = 3;
	    int relleCantGrupos = 3;

		String [][]relleDatosEstudiantes = {{"123","Roberto","Aguero",""},{"234","Amanda","Rodriguez",""},{"345","Esteban","Ulloa",""},{"456","Fabricio","Ridchmond",""},{"567","Alejandra","Esquivel",""},{"678","Andrea","Cordero",""},{"789","Nicole","Amador",""},{"890","Andrea","Arguedas",""},{"901","Rodolfo","Jugo",""},{"012","Emanuel","Romero",""},{"025","Gloria","Vega",""},{"466","Karol","Montero",""},{"","","",""},{"","","",""},{"","","",""},{"","","",""},{"","","",""},{"","","",""},{"","","",""},{"","","",""},{"","","",""},{"","","",""},{"","","",""},{"","","",""},{"","","",""},{"","","",""},{"","","",""},{"","","",""},{"","","",""},{"","","",""},{"","","",""},{"","","",""},{"","","",""},{"","","",""},{"","","",""},{"","","",""},{"","","",""},{"","","",""},{"","","",""},{"","","",""},{"","","",""},{"","","",""},{"","","",""},{"","","",""},{"","","",""},{"","","",""},{"","","",""},{"","","",""},{"","","",""},{"","","",""},{"","","",""},{"","","",""},{"","","",""},{"","","",""},{"","","",""},{"","","",""},{"","","",""},{"","","",""},{"","","",""},{"","","",""}};
		String [][]relleDatosProfesores = {{"098","Camilo","Aguero"},{"987","Andrea","Rodriguez"},{"876","Esteban","Mora"},{"","",""},{"","",""},{"","",""}};
    	String [][]relleDatosGrupos = {{"poi","987","m","10","3","1"},{"oiu","876","v","10","1","2"},{"uyt","098","m","10","2","3"},{"","","","","",""},{"","","","","",""},{"","","","","",""}};

    	cantEstudiantes=relleCantEstudiantes;
    	cantProfesores=relleCantProfesores;
    	cantGrupos=relleCantGrupos;

    	datosEstudiantes=relleDatosEstudiantes;
    	datosProfesores=relleDatosProfesores;
    	datosGrupos=relleDatosGrupos;

    	cantGrados[0]=1;
    	cantGrados[1]=1;
    	cantGrados[2]=1;

	}
		/****************************************************************
	 * Rutina: reiniciarSistema
	 * Propósito: Limpia las matrices para que el sistema quede sin
	 *				informacion
	 * Parámetro:
	 * Retorna:
	 ****************************************************************/
	public static void reiniciarSistema(){
		String [][]nuevosDatosEstudiantes = new String[60][3];
		String [][]nuevosDatosProfesores = new String [6][3];
    	String [][]nuevosDatosGrupos = new String[6][6];

    	datosEstudiantes = nuevosDatosEstudiantes;
		datosProfesores = nuevosDatosProfesores;
   		datosGrupos = nuevosDatosGrupos;

   		cantEstudiantes = 0;
		cantProfesores = 0;
		cantGrupos = 0;

		cantGrados[0]=0;
    	cantGrados[1]=0;
    	cantGrados[2]=0;

	}

}




