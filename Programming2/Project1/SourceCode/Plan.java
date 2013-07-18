/*
 * Programa:			PrpPlanNombres
 * Fecha de creacion: 	4/Julio/2012
 * Autor(es):			Fabian Vega, Chris Esquivel
 * _ _  _  |` _ _|_ _  _
 *(_(/_| |~|~(_) | (/_(_
 *
 */

import java.util.*;


public class Plan {
	
	private static int cantPlanes = 0;
	private String codigo;
	private GregorianCalendar fechaRegistro;
	private String nombreSucursal;
	private String codigoSucursal;
	private String direccionSucursal;
	private String tipoPlan;
	private String descripcionPlan;
	private String nombreOriginador;
	private String nombreAdministrador;
	private String nombreLider;
	private String nombreAuditor;
	private Empleado[] empleados = new Empleado[4];
	private GregorianCalendar fechaALider;
	private int cantActividades;
	private ArrayList<Actividad> actividades = new ArrayList<Actividad>(); 
	private GregorianCalendar fechaAnalisisLider;
	private GregorianCalendar fechaAuditoria;
	private String resolucionAuditor;
	
	//Constructores
	
	public Plan(GregorianCalendar pFechReg, String pNomSucur, String pCodigoSucur , String pDireccionSucur, String pTipoPlan, String pDescripPlan, Empleado pOrig, Empleado pAdmin){
		setCodigo("Pl-"+(cantPlanes+1));
		setFechaRegistro(pFechReg);
		setNombreSucursal(pNomSucur);
		setCodigoSucursal(pCodigoSucur);
		setDireccionSucursal(pDireccionSucur);
		setTipoPlan(pTipoPlan);
		setDescripcionPlan(pDescripPlan);
		setEmpleados(pOrig, 0);
		setEmpleados(pAdmin, 1);
		cantPlanes++;
	}
	
	//Sets y Gets
	
	public String getCodigo() {
		return codigo;
	}
	private void setCodigo(String codigo) {
		this.codigo = codigo;
	}
	public String getFechaRegistro() {
		GregorianCalendar cal=fechaRegistro;
		String resul=""+ cal.get(Calendar.DATE)+"/"+cal.get(Calendar.MONTH)+"/"+cal.get(Calendar.YEAR);
		return resul;
	}
	public void setFechaRegistro(GregorianCalendar fechaRegistro) {
		this.fechaRegistro = fechaRegistro;
	}
	public String getNombreSucursal() {
		return nombreSucursal;
	}
	public void setNombreSucursal(String nombreSucursal) {
		this.nombreSucursal = nombreSucursal;
	}
	public String getCodigoSucursal() {
		return codigoSucursal;
	}
	public void setCodigoSucursal(String codigoSucursal) {
		this.codigoSucursal = codigoSucursal;
	}
	public String getDireccionSucursal() {
		return direccionSucursal;
	}
	public void setDireccionSucursal(String direccionSucursal) {
		this.direccionSucursal = direccionSucursal;
	}
	public String getTipoPlan() {
		return tipoPlan;
	}
	public void setTipoPlan(String tipoPlan) {
		this.tipoPlan = tipoPlan;
	}
	public String getDescripcionPlan() {
		return descripcionPlan;
	}
	public void setDescripcionPlan(String descripcionPlan) {
		this.descripcionPlan = descripcionPlan;
	}
	public String getNombreOriginador() {
		return nombreOriginador;
	}
	private void setNombreOriginador() {
		this.nombreOriginador = empleados[0].getEmpNombre();
	}
	public String getNombreAdministrador() {
		return nombreAdministrador;
	}
	private void setNombreAdministrador() {
		this.nombreAdministrador = empleados[1].getEmpNombre();
	}
	public String getNombreLider() {
		return nombreLider;
	}
	private void setNombreLider() {
		this.nombreLider = empleados[2].getEmpNombre();
	}
	public String getNombreAuditor() {
		return nombreAuditor;
	}
	private void setNombreAuditor() {
		this.nombreAuditor = empleados[3].getEmpNombre();
	}
	public String getFechaALider() {
		GregorianCalendar cal=fechaALider;
		String resul;
		if(cal!=null){
			resul=""+ cal.get(Calendar.DATE)+"/"+cal.get(Calendar.MONTH)+"/"+cal.get(Calendar.YEAR);
		}else{
			resul="El lider no ha sido asignado";
		}
		return resul;
	}
	public void setFechaALider(GregorianCalendar fechaALider) {
		this.fechaALider = fechaALider;
	}
	public int getCantActividades() {
		return cantActividades;
	}
	public void setCantActividades(int cantActividades) {
		this.cantActividades = cantActividades;
	}
	public String getFechaAnalisisLider() {
		GregorianCalendar cal=fechaAnalisisLider;
		String resul;
		if(cal!=null){
			resul=""+ cal.get(Calendar.DATE)+"/"+cal.get(Calendar.MONTH)+"/"+cal.get(Calendar.YEAR);
		}else{
			resul="El Analisis del lider no se ha realizado";
		}

		return resul;
		
	}
	public void setFechaAnalisisLider(GregorianCalendar fechaAnalisisLider) {
		this.fechaAnalisisLider = fechaAnalisisLider;
	}
	public String getFechaAuditoria() {
		GregorianCalendar cal=fechaAuditoria;
		String resul;
		if(cal!=null){
			resul=""+ cal.get(Calendar.DATE)+"/"+cal.get(Calendar.MONTH)+"/"+cal.get(Calendar.YEAR);
		}else{
			resul="La auditoria no se ha realizado";
		}

		return resul;
	}
	public void setFechaAuditoria(GregorianCalendar fechaAuditoria) {
		this.fechaAuditoria = fechaAuditoria;
	}
	public String getResolucionAuditor() {
		return resolucionAuditor;
	}
	public void setResolucionAuditor(String resolucionAuditor) {
		this.resolucionAuditor = resolucionAuditor;
	}

	public ArrayList<Actividad> getActividades() {
		return actividades;
	}

	public void setActividades(ArrayList<Actividad> actividades) {
		this.actividades = actividades;
	}

	public Empleado[] getEmpleados() {
		return empleados;
	}

	public void setEmpleados(Empleado pEmp, int pInd) {
		this.empleados[pInd] = pEmp;
		switch(pInd){
		case 0:
			setNombreOriginador();
		break;
		case 1:
			setNombreAdministrador();
		break;
		case 2:
			setNombreLider();
		break;
		case 3:
			setNombreAuditor();
		break;
		}
	}
	public static int getCantPlanes(){
		return cantPlanes;
	}
	
	public int indEficiencia(){
		int indEfici=0;
		GregorianCalendar date1=fechaRegistro;
		GregorianCalendar date2=fechaALider;
		GregorianCalendar date3=fechaAnalisisLider;
		if((-1* (date2.get(Calendar.DAY_OF_YEAR) - date1.get(Calendar.DAY_OF_YEAR)))<=3&&(-1* (date3.get(Calendar.DAY_OF_YEAR) - date2.get(Calendar.DAY_OF_YEAR)))<=15){
			indEfici=100;
		}else{
			if(((-1* (date2.get(Calendar.DAY_OF_YEAR) - date1.get(Calendar.DAY_OF_YEAR)))>3&&(-1* (date2.get(Calendar.DAY_OF_YEAR) - date1.get(Calendar.DAY_OF_YEAR)))<10)&&((-1* (date3.get(Calendar.DAY_OF_YEAR) - date2.get(Calendar.DAY_OF_YEAR)))>18&&(-1* (date3.get(Calendar.DAY_OF_YEAR) - date2.get(Calendar.DAY_OF_YEAR)))<23)){
				indEfici=70;
			}else{
				indEfici=50;
			}
		}
		
		return indEfici;
	}
	
	public String toString() {
		return "Codigo:   " + this.getCodigo() + "\n" +
			    "Fecha de registro:   " + this.getFechaRegistro() + "\n" +
			    "Sucursal:   " + this.getNombreSucursal() + "\n" + 
			    "Codigo de Sucursal:   " + this.getCodigoSucursal() + "\n" +
			    "Direccion de Sucursal:   " + this.getDireccionSucursal() + "\n" +
			    "Tipo de Plan:   " + this.getTipoPlan() + "\n" + 
			    "Descripcion del Plan:   " + this.getDescripcionPlan() + "\n" + 
			    "Nombre del Originador:   " + this.getNombreOriginador() + "\n" +
			    "Nombre del Administrador:   " + this.getNombreAdministrador() + "\n" +
			    "Nombre del Lider:   " + this.getNombreLider() + "\n" +
			    "Nombre del Auditor:   " + this.getNombreAuditor() + "\n" +
			    "Fecha de asignacion del Lider:   " + this.getFechaALider() + "\n" +
			    "Cantidad de Actividades:   "+ this.getCantActividades() + "\n" +
			    "Fecha de Analisis del Lider:   " + this.getFechaAnalisisLider() + "\n" +
			    "Fecha de Auditoria:   " + this.getFechaAuditoria() + "\n" +
			    "Resolucion del Auditor:   " + this.getResolucionAuditor();
	}

	public void crearActividad(String pactividad, String pfechaPreliminar) {
		actividades.add(new Actividad(pactividad, pfechaPreliminar));
		cantActividades++;
	}

	public void terminarActividad(int opcAct, String fecha) {
		actividades.get(opcAct).setFechaConclusion(fecha);
	}
}
