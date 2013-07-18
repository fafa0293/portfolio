/*
 * Programa:			PrpPlanNombres
 * Fecha de creacion: 	4/Julio/2012
 * Autor(es):			Fabian Vega, Chris Esquivel
 * _ _  _  |` _ _|_ _  _
 *(_(/_| |~|~(_) | (/_(_
 *
 */

import java.io.*;
import java.util.ArrayList;
import java.util.Calendar;
import java.util.GregorianCalendar;

public class IU {

	static BufferedReader in = new BufferedReader(new InputStreamReader(System.in));
	static PrintStream out = System.out;

	private static Gestor gestor = new Gestor();
	private static int indPlan = 0;

	public static void main(String[] args)throws Exception {
		out.println("Bienvenido!");
		mostrarMenu1();
	}

	private static void mostrarMenu1() throws Exception {
		int opcion;
		boolean salir = false;
		String[] menu =
			{
				"1.  Crear Plan",
				"2.  Ver Planes",
				"3.  Seleccionar un Plan",
				"4.  Consultar Cantidad de Planes Registrados",
				"5.  Consultar Cantidad de Planes 'Efectivos' e 'Inefectivos'",
				"6.  Consultar el Indice de Prevision",
				"7.  Consultar la Sucursal con Mayor Indice de Previdion",
				"8.  Consultar la Sucursal con Mayor Cantidad de Planes 'Correctivos'",
				"9.  Consultar la Sucursal con Mayor Cantidad de Planes 'Preventivos'",
				"10. Consultar el Indicador de Eficiencia y Efectividad",
				"11. Consultar el Indicador de Eficiencia y Efectividad para una Sucursal",
				"12. Consultar el Indicador de Eficiencia para un Plan",
				"13. Salir"
			};

		do {
			mostrarMenu(menu);
			opcion	= leerOpcion();
			salir	= ejectuarAccionMenu1(opcion);
		} while (salir == true);

	}

	static void mostrarMenu(String[] plista) {
		out.println();
		for(int i = 0 ; i < plista.length ; i++){
			out.println(plista[i]);
		}
		out.println();
	}

	static int leerOpcion()throws Exception {
		int opcion = 0;
		out.print("Seleccione una opcion: ");
		try {
			opcion = Integer.parseInt(in.readLine());
		} catch (NumberFormatException e) {

		}
		out.println();
		return opcion;
	}

	static boolean ejectuarAccionMenu1(int popcion)throws Exception {
		boolean continuar = true;	

		switch (popcion) {
		case 1:
			crearPlan();
			break;
		case 2:
			verPlanes();
			break;
		case 3:
			seleccionarPlan();
			break;
		case 4:
			verCantidadDePlanesRegistrados();
			break;
		case 5: 
			verCantPlanesEfectivosEInefectivos();
			break;
		case 6:
			verIndicePrevision();
			break;
		case 7:
			verSucursalConMayorIndPrevision();
			break;
		case 8:
			verSucursalConMayorCantDePlanesCorrectivos();
			break;
		case 9:
			verSucursalConMayorCantDePlanesPreventivos();
			break;
		case 10: //10 a 11 no se puede si no hay planes llenos, y la 11 no se puede hacer si esa sucursal no tiene planes.
			consultarIndiceDeEmpresa();
			break;
		case 11:
			consultarIndicadorEficienciaEficaciaPorSucursal();
			break;
		case 12:
			consultarIndicadorEficienciaEficaciaDeUnPlan();
			break;
		case 13: //Salir
			continuar = false;
			break;
		default:
			out.println(" --Opcion Invalida-- ");
			break;
		}

		return continuar;
	}

	private static void consultarIndiceDeEmpresa() {
		try {
			out.println("El indice de la empresa es: " + gestor.indEficiEmpre());
		} catch (Exception e) {
			out.println("Todos los planes deben de estar con resolusion para realizar esta opcion.");
		}
	}

	private static void consultarIndicadorEficienciaEficaciaDeUnPlan() throws Exception {

		verPlanes();
		out.println();
		indPlan = leerOpcion() - 1;

		if(gestor.getPlanes().get(indPlan).getResolucionAuditor() == null) {
			out.println("No hay indicador para este plan. ");
		} else {
			out.println("El indicador de eficiencia es: " + gestor.indEficiPlan(indPlan));
		}

	}

	private static void consultarIndicadorEficienciaEficaciaPorSucursal() throws Exception {
		out.println("Lista de sucursales: ");
		for(int i = 0 ; i < gestor.traerSucursales().size() ; i++) {
			out.println((i+1) + ".  " + gestor.traerSucursales().get(i));
		}

		out.println();
		int opcSucursal = leerOpcion();
		
		try {
			out.println("El indicador de eficiencia para esta sucursal es: " + gestor.indEficiSucur(opcSucursal));
			out.println("El indicador de eficacia para esta sucursal es: " + gestor.indEfectiSucur(opcSucursal));
		} catch (Exception e) {
			out.println("La sucursal debe de terner almenos un plan con resolusion.");
		}
	}

	private static void verSucursalConMayorCantDePlanesPreventivos() {
		out.println("La sucursal con mayor cantidad de planes preventivos es: " + gestor.sucurMayTipo("Preventivo") + "\n");

	}

	private static void verSucursalConMayorCantDePlanesCorrectivos() {
		out.println("La sucursal con mayor cantidad de planes correctivos es: " + gestor.sucurMayTipo("Correctivo") + "\n");

	}

	private static void verSucursalConMayorIndPrevision() {
		out.println("La sucursal con mayor indice de prevision es " + gestor.mayIndSucur());
	}	

	private static void verIndicePrevision() {
		out.println("Indice de prevision: " + gestor.indPrevision());

	}

	private static void verCantPlanesEfectivosEInefectivos() { //***no funciona
		int[] cants=new int[2];
		cants=gestor.cantResoEfecInefec();
		out.println("Efectivos: " + cants[0]);
		out.println("Inefectivos: " + cants[1]);

	}

	private static void verCantidadDePlanesRegistrados() {
		out.println("Hay " + gestor.getCantPlanes() + " plan(es) registrado(s).");
	}

	private static void seleccionarPlan() throws Exception {
		verPlanes();
		out.println();
		indPlan = leerOpcion() - 1;
		out.println("Se seleccion— el plan con el c—digo " + gestor.getPlanes().get(indPlan).getCodigo());
		mostrarMenu2();
	}

	private static void mostrarMenu2() throws Exception {
		int opcion;
		boolean salir = false;
		String[] menu =
			{
				"1.  Ingresar Lider",
				"2.  Ingresar Auditor",
				"3.  Ingresar una Actividad",
				"4.  Realizar analisis de una actividad",
				"5.  Realizar Resolucion de Auditoria",
				"6.  Ver informaci—n del Plan",
				"7.  Ver Actividades",
				"8.  Salir"
			};

		do {
			mostrarMenu(menu);
			opcion	= leerOpcion();
			salir	= ejectuarAccionMenu2(opcion);
		} while (salir == true);

	}

	private static boolean ejectuarAccionMenu2(int popcion) throws Exception {
		boolean continuar = true;	

		switch (popcion) {
		case 1:
			ingresarLider();
			break;
		case 2:
			ingresarAuditor();
			break;
		case 3:
			ingresarActividad();
			break;
		case 4:
			realizarAnalisis();
			break;
		case 5:
			realizarResAuditoria();
			break;
		case 6: 
			verInfoPlan();
			break;
		case 7: 
			verActividades();
			break;
		case 8: //Salir
			continuar = false;
			break;
		default:
			out.println(" --Opcion Invalida-- ");
			break;
		}

		return continuar;
	}

	private static void verActividades() {
		ArrayList<Actividad> act = gestor.traerActividadesDelPlan(indPlan);

		if(act.size() <= 0) {
			out.println("No hay actividades");
		} else {
			for(int i=0 ; i < act.size() ; i++) {
				out.println((i+1) + ".\n" + act.get(i).toString());
				out.println("\n\n");
			}
		}
	}

	private static void realizarResAuditoria() throws Exception {

		if(gestor.getPlanes().get(indPlan).getNombreAuditor() == null) {
			out.println("Esta funcionalidad no puede realizarse. Se debe asignar un auditor para continuar...");
		} else {
			out.println("Seleccione su nombre... (solo el auditor puede llevar a cabo esta accion) \n");
			for(int i = 0 ; i < gestor.traerNombres().size() ; i++) { //Se imprimen los nombres de los empleados
				out.println((i+1) + ". " + gestor.traerNombres().get(i));
			}
			out.println();

			int opcRol = leerOpcion();
			String nombreSeleccionado = gestor.traerNombres().get(opcRol-1);

			if(gestor.getPlanes().get(indPlan).getNombreAuditor().equals(nombreSeleccionado)) {
				out.println("La resolucion de este plan es: \n1. Efectivo\n2. Inefectivo\n");
				int opc = leerOpcion();
				String res = null;

				GregorianCalendar cal = new GregorianCalendar();

				if(opc == 1) {
					res = "Efectivo"; 
				}
				if(opc == 2) {
					res = "Inefectivo"; 
				}
				if(opc > 2 || opc < 1){
					out.println("Opcion Invalida");
				} else {
					gestor.resPlan(res, indPlan, cal);	
					out.println("El plan ha sido " + res);
				}

			} else {
				out.println("Este empleado no tiene el permiso para llevar a cabo esta accion.");
			}
		}

	}

	private static void realizarAnalisis() throws Exception {
		out.println("Seleccione su nombre... (solo el lider puede llevar a cabo esta accion) \n");
		for(int i = 0 ; i < gestor.traerNombres().size() ; i++) { //Se imprimen los nombres de los empleados
			out.println((i+1) + ". " + gestor.traerNombres().get(i));
		}

		out.println();

		int opcRol = leerOpcion();
		String nombreSeleccionado = gestor.traerNombres().get(opcRol-1);

		if(gestor.getPlanes().get(indPlan).getNombreLider().equals(nombreSeleccionado)) {


			ArrayList<Actividad> act = gestor.traerActividadesDelPlan(indPlan);

			if(act.size() <= 0) {
				out.println("No hay actividades");
			} else {
				out.println("Seleccione una actividad que va a ser concluir: ");
				for(int i=0 ; i < act.size() ; i++) {
					out.println((i+1) + ".\n" + act.get(i).toString());
					out.println("\n\n");
				}

				int opcAct = leerOpcion() - 1;

				out.println("Seguro que quiere realizar el analisis(concluir) esta actividad? \n\n1.Si\n2.No\n");

				int confirm = leerOpcion();
				GregorianCalendar cal = new GregorianCalendar();

				if(confirm == 1) {
					gestor.getPlanes().get(indPlan).setFechaAnalisisLider(cal);
					gestor.finalizarActividad(indPlan, opcAct, cal.get(Calendar.DATE)+"/"+cal.get(Calendar.MONTH)+"/"+cal.get(Calendar.YEAR));
					out.println("La actividad finalizo en la fecha " + cal.get(Calendar.DATE)+"/"+cal.get(Calendar.MONTH)+"/"+cal.get(Calendar.YEAR));

				} else {

					if(confirm == 2) {
						out.println("No se concluyo la actividad.");
					} else {
						out.println("Opcion Invalida");
					}
				}

			}


		} else {
			out.println("Este empleado no tiene el permiso para llevar a cabo esta accion.");
		}
	}

	private static void ingresarActividad() throws IOException {
		out.println("Ingrese la descripcion de la actividad: ");
		String actividad = in.readLine();

		out.println("Ingrese la fecha preliminar de conclusion de la actividad: (el formato es dia/mes/annio)");
		String fechap = in.readLine();

		gestor.agregarActividad(indPlan, actividad, fechap);
		out.println("Se ha creado la actividad.");
	}

	private static void ingresarAuditor() throws Exception {
		if(gestor.getPlanes().get(indPlan).getNombreAuditor() == null) {
			GregorianCalendar cal = new GregorianCalendar();


			out.println("Seleccione quien va a ser el Auditor del plan... \n");
			for(int i = 0 ; i < gestor.traerNombres().size() ; i++) {
				if(gestor.getPlanes().get(indPlan).getNombreAdministrador() != gestor.traerNombres().get(i) && gestor.getPlanes().get(indPlan).getNombreOriginador() != gestor.traerNombres().get(i) && gestor.getPlanes().get(indPlan).getNombreLider() != gestor.traerNombres().get(i)) { //esta evaluacion hace que no se imprima el admin ni el originador
					out.println((i+1) + ". " + gestor.traerNombres().get(i));
				}
			}
			out.println();

			int opcAuditor = leerOpcion();
			String revision = gestor.traerNombres().get(opcAuditor-1);

			if(revision.equals(gestor.getPlanes().get(indPlan).getNombreAdministrador()) || revision.equals(gestor.getPlanes().get(indPlan).getNombreOriginador()) || revision.equals(gestor.getPlanes().get(indPlan).getNombreLider())) {
				out.println("No se puede asignar a esa persona como Auditor porque esa persona ya tiene otra responsabilidad");
			} else {
				gestor.agregarEmpAUnPlan(opcAuditor, indPlan, cal, 3);
				out.println("Se asigno a " + gestor.traerNombres().get(opcAuditor-1) + " como Auditor del plan " + gestor.getPlanes().get(indPlan).getCodigo() );
			}
		} else {
			out.println("Ya hay un Auditor asignado");
		}

	}

	private static void ingresarLider() throws Exception {

		if(gestor.getPlanes().get(indPlan).getNombreLider() == null) {
			GregorianCalendar cal = new GregorianCalendar();


			out.println("Seleccione quien va a ser el Lider del plan... \n");
			for(int i = 0 ; i < gestor.traerNombres().size() ; i++) {
				if(gestor.getPlanes().get(indPlan).getNombreAdministrador() != gestor.traerNombres().get(i) && gestor.getPlanes().get(indPlan).getNombreOriginador() != gestor.traerNombres().get(i)) { //esta evaluacion hace que no se imprima el admin ni el originador
					out.println((i+1) + ". " + gestor.traerNombres().get(i));
				}
			}
			out.println();

			int opcLider = leerOpcion();
			String revision = gestor.traerNombres().get(opcLider-1);

			if(revision.equals(gestor.getPlanes().get(indPlan).getNombreAdministrador()) || revision.equals(gestor.getPlanes().get(indPlan).getNombreOriginador())) {
				out.println("No se puede asignar a esa persona como lider porque esa persona ya tiene otra responsabilidad");
			} else {
				gestor.agregarEmpAUnPlan(opcLider, indPlan, cal, 2);
				out.println("Se asigno a " + gestor.traerNombres().get(opcLider-1) + " como lider del plan " + gestor.getPlanes().get(indPlan).getCodigo() + " en la fecha "+ cal.get(Calendar.DATE)+"/"+cal.get(Calendar.MONTH)+"/"+cal.get(Calendar.YEAR) );
			}
		} else {
			out.println("Ya hay un lider asignado");
		}

	}

	private static void verInfoPlan() {
		out.println("La informacion es...\n");
		out.println(gestor.getPlanes().get(indPlan).toString());
	}

	private static void verPlanes() {
		out.println("Los planes son...");
		for(int i=0 ; i < gestor.getCantPlanes() ; i++) {
			out.println((i+1) + ".  " + gestor.getPlanes().get(i).getCodigo() + "   " + gestor.getPlanes().get(i).getFechaRegistro());
		}

	}

	private static void crearPlan() throws Exception {

		String tipoPlan = "";
		GregorianCalendar cal = new GregorianCalendar();


		out.println("Seleccione quien va a ser el originador del plan... \n");
		for(int i = 0 ; i < gestor.traerNombres().size() ; i++) { //Se imprimen los nombres de los empleados
			out.println((i+1) + ". " + gestor.traerNombres().get(i));
		}
		out.println();

		int opcOriginador = leerOpcion();
		out.println("El originador es: " + gestor.traerNombres().get(opcOriginador-1) + "\n");

		boolean adminAceptado = false;
		int admin;

		do {
			out.println("Seleccione quien va a ser el Administrador del plan... \n");
			for(int i = 0 ; i < gestor.traerNombres().size() ; i++) {
				out.println((i+1) + ". " + gestor.traerNombres().get(i));
			}
			out.println();

			admin = leerOpcion();

			if(admin == opcOriginador) {
				out.println("El administrador no puede ser el originador del proyecto \n");
			} else {
				adminAceptado = true;
			}
		} while (adminAceptado != true);

		out.println("El Admin es: " + gestor.traerNombres().get(admin-1) + "\n");


		out.println("Fecha actual: " + cal.get(Calendar.DATE)+"/"+cal.get(Calendar.MONTH)+"/"+cal.get(Calendar.YEAR) + "\n");

		out.println("Lista de sucursales: ");
		for(int i = 0 ; i < gestor.traerSucursales().size() ; i++) {
			out.println((i+1) + ".  " + gestor.traerSucursales().get(i));
		}

		out.println();
		int opcSucursal = leerOpcion();

		out.println("Sucursal: " + gestor.traerSucursales().get(opcSucursal-1));

		out.println("Seleccione el tipo de plan: \n\n1.  Preventivo\n2.  Correctivo");
		int opc1 = leerOpcion();

		if(opc1 == 1) {
			tipoPlan = "Preventivo";
		} else {
			tipoPlan = "Correctivo";
		}

		out.print("Deme una descripcion del plan: ");
		String desc = in.readLine();


		gestor.agregarPlan(cal, opcSucursal, tipoPlan, desc, opcOriginador, admin);
		out.println("Se ha creado el plan\n");
	}

}