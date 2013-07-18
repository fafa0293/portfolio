/*
 * Programa:			PrpPlanNombres
 * Fecha de creacion: 	4/Julio/2012
 * Autor(es):			Fabian Vega, Chris Esquivel
 * _ _  _  |` _ _|_ _  _
 *(_(/_| |~|~(_) | (/_(_
 *
 */

import java.util.*;


public class Gestor {
	private ArrayList<Plan> planes = new ArrayList<Plan>();
	private ArrayList<Empleado> empleados = new ArrayList<Empleado>();
	private ArrayList<Sucursal> sucursales = new ArrayList<Sucursal>();

	public Gestor() {
		empleados.add(new Empleado("Pedro Kane"));
		empleados.add(new Empleado("Chris Esquivel"));
		empleados.add(new Empleado("Fabian Vega"));
		empleados.add(new Empleado("Camilo Aguero"));
		empleados.add(new Empleado("Aramis Cubillo"));
		empleados.add(new Empleado("Karen Chacon"));
		sucursales.add(new Sucursal("Suc-1", "Montereal", 47));
		sucursales.add(new Sucursal("Suc-2", "Santa Monica CA", 13));
		sucursales.add(new Sucursal("Suc-3", "Burbank", 32));
		sucursales.add(new Sucursal("Suc-4", "Charlotte", 8));
		this.agregarPlan(new GregorianCalendar(2012,2,1), 2,  "Preventivo", "Plan de prueba", 1, 2);
	}

	public ArrayList<String> traerNombres(){
		ArrayList<String> nomEmp=new ArrayList<String>();
		for(int i=0;i<empleados.size();i++){
			nomEmp.add(empleados.get(i).getEmpNombre());
		}
		return nomEmp;
	}

	public ArrayList<String> traerSucursales() {
		ArrayList<String> nomSucursal = new ArrayList<String>();
		for(int i=0 ; i<sucursales.size() ; i++) {
			nomSucursal.add(sucursales.get(i).getSucurNombre());
		}
		return nomSucursal;
	}

	public void agregarPlan(GregorianCalendar pFechReg, int pSucur, String pTipoPlan, String pDescripPlan, int pOrig, int pAdmin){
		Empleado orig=obtenerEmpleado(pOrig);
		Empleado admin=obtenerEmpleado(pAdmin);
		Sucursal sucur=obtenerSucursal(pSucur);
		String pNomSucur=sucur.getSucurNombre();
		String pCodigoSucur=sucur.getCodSucur();
		String pDirec=sucur.getSucurDirec();
		planes.add(new Plan(pFechReg, pNomSucur, pCodigoSucur, pDirec, pTipoPlan, pDescripPlan, orig, admin));

	}

	private Empleado obtenerEmpleado(int pInd){
		int ind=0;
		boolean salir=false;
		int i=0;
		while(i<empleados.size()||salir==false){
			if(empleados.get(i).getCodEmpleado().equals("Emp-"+pInd)){
				ind= i;
				salir=true;
			}
			i++;
		}
		return empleados.get(ind);
	}

	public Sucursal obtenerSucursal (int pInd){
		int ind=0;
		boolean salir=false;
		int i=0;
		while(i<sucursales.size()||salir==false){
			if(sucursales.get(i).getCodSucur().equals("Suc-"+pInd)){
				ind= i;
				salir=true;
			}
			i++;
		}
		return sucursales.get(ind);
	}

	public ArrayList<Plan> getPlanes() {
		return planes;
	}

	public int getCantPlanes(){
		return Plan.getCantPlanes();
	}
	
	public int getCantPlanesSucur(int indSucur){
		int cant=0;
		for(int i=0;i<planes.size();i++){
			if(planes.get(i).getCodigoSucursal().equals("Suc-"+indSucur)){
				cant++;
			}
		}
		return cant;
	}

	public int[] cantResoEfecInefec(){
		int[] cants=new int[2];
		cants[0]=cantResolucion("Efectivo");
		cants[1]=cantResolucion("Inefectivo");
		return cants;
	}

	public int cantResolucion(String pEvalu){
		int cant=0;
		for(int i=0;i<planes.size();i++){
			if(planes.get(i).getResolucionAuditor()==null){
				
			}else{
				if(planes.get(i).getResolucionAuditor().equals(pEvalu)){
					cant++;
				}
			}
		}
		return cant;
	}

	public String indPrevision(){
		int[] cants=new int[2];
		String resul="Alto";
		cants[0]=cantTipo("Preventivo");
		cants[1]=cantTipo("Correctivo");
		if(cants[1]!=0){
			int num=cants[0]/cants[1];
			resul=indice(num);
		}
		return resul;
	}

	public String indice(int pNum){
		String res;
		if(pNum>0){
			res="Alto";
		}else{
			if(pNum==0){
				res="Medio";
			}else{
				res="Bajo";
			}
		}
		return res;
	}

	public int cantTipo(String pEvalu){
		int cant=0;
		for(int i=0;i<planes.size();i++){
			if(planes.get(i).getTipoPlan().equals(pEvalu)){
				cant++;
			}
		}
		return cant;
	}

	public int cantTipoSucur(String pEvalu, int indSucur){
		int cant=0;
		for(int i=0;i<planes.size();i++){
			if(planes.get(i).getCodigoSucursal().equals("Suc-"+indSucur)){
				if(planes.get(i).getTipoPlan().equals(pEvalu)){
					cant++;
				}
			}
		}
		return cant;
	}
	
	public int cantResolucionSucur(String pEvalu, int indSucur){
		int cant=0;
		for(int i=0;i<planes.size();i++){
			if(planes.get(i).getCodigoSucursal().equals("Suc-"+indSucur)){
				if(planes.get(i).getResolucionAuditor().equals(pEvalu)){
					cant++;
				}
			}
		}
		return cant;
	}

	public String mayIndSucur(){
		String resul;
		int indSucur=0;
		int indPMayor;
		int[] cants=new int[2];
		cants[0]=cantTipoSucur("Preventivo", 0);
		cants[1]=cantTipoSucur("Correctivo", 0);
		if(cants[1]!=0){
			indPMayor=cants[0]/cants[1];
		}else{
			indPMayor=cants[0];
		}
		for(int i=1;i<sucursales.size();i++){
			cants[0]=cantTipoSucur("Preventivo", i);
			cants[1]=cantTipoSucur("Correctivo", i);
			int indPr;
			if(cants[1]!=0){
				indPr=cants[0]/cants[1];
			}else{
				indPr=cants[0];
			}
			if(indPr>indPMayor){
				indSucur=i;
				indPMayor=indPr;
			}
		}
	
		resul= sucursales.get(indSucur).toString()+"\nEl indice de Previcion es: "+indice(indPMayor)+"\nCon un valor de: "+indPMayor;
			
		return resul;
	}

	public String sucurMayTipo(String pTipo){
		String resul;
		int indSucur=0;
		int tipoMayor=cantTipoSucur(pTipo,0);
		for(int i=1;i<sucursales.size();i++){
			int cant=cantTipoSucur(pTipo, i);
			if(cant>tipoMayor){
				indSucur=i;
				tipoMayor=cant;
			}
		}
		resul=sucursales.get(indSucur).toString();
		return resul;
	}

	public void agregarEmpAUnPlan(int opcSlt, int indPlan, GregorianCalendar pfecha, int ptipo) {
		Empleado emp = this.obtenerEmpleado(opcSlt);
		planes.get(indPlan).setEmpleados(emp, ptipo);

		if(ptipo == 2) {
			planes.get(indPlan).setFechaALider(pfecha);
		} 

	}

	public void agregarActividad(int pindPlan, String pactividad, String pfechaPreliminar) {
		planes.get(pindPlan).crearActividad(pactividad, pfechaPreliminar);
	}	
	
	public double indEfecti(){
		double ind;
		int[] cants=new int[2];
		cants[0]=cantResolucion("Eficiente");
		cants[1]=getCantPlanes();
		ind=cants[0]/cants[1];
		
		return ind;
	}
	
	public double indEfectiSucur(int indSucur){
		double ind;
		int[] cants=new int[2];
		cants[0]=cantResolucionSucur("Eficiente", indSucur);
		cants[1]=getCantPlanesSucur(indSucur);
		ind=cants[0]/cants[1];
		
		return ind;
	}
	
	public double indEficiSucur(int indSucur){
		double ind;
		int indEP=0;
		for(int i=0;i<planes.size();i++){
			if(planes.get(i).getCodigoSucursal().equals("Suc-"+indSucur)){
				indEP+=indEficiPlan(i);
			}
		}
		ind=indEP/getCantPlanesSucur(indSucur);
		return ind;
	}
	
	public int indEficiPlan(int indPlan){
		int ind;
		
		ind=planes.get(indPlan).indEficiencia();
		
		return ind;
	}
	
	public double indEficiEmpre(){
		double ind=0;
		double[] indSucurs=new double[4];
		int[] pesoSucur=new int[4];
		double[] resuls=new double[4];
		
		for(int i=0;i<sucursales.size();i++){
			indSucurs[i]=indEficiSucur(i+1);
		}
		for(int i=0;i<sucursales.size();i++){
			pesoSucur[i]=sucursales.get(i).getPeso();
		}
		for(int i=0;i<sucursales.size();i++){
			resuls[i]=indSucurs[i]*pesoSucur[i];
		}
		for(int i=0;i<sucursales.size();i++){
			ind+=resuls[i];
		}
				
		return ind;
	}
	
	public ArrayList<Actividad> traerActividadesDelPlan(int pInd) {
		ArrayList<Actividad> act = planes.get(pInd).getActividades();
		return act;
	}
	
	public void resPlan(String res, int pind, GregorianCalendar cal) {
		planes.get(pind).setResolucionAuditor(res);
		planes.get(pind).setFechaAuditoria(cal);
	}

	public void finalizarActividad(int indPlan, int opcAct, String fecha) {
		planes.get(indPlan).terminarActividad(opcAct, fecha);
	}
	
}
