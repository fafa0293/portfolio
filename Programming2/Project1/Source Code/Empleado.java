/*
 * Programa:			PrpPlanNombres
 * Fecha de creacion: 	4/Julio/2012
 * Autor(es):			Fabian Vega, Chris Esquivel
 * _ _  _  |` _ _|_ _  _
 *(_(/_| |~|~(_) | (/_(_
 *
 */

public class Empleado {
	private static int cantEmp=0;
	private String codEmpleado;
	private String empNombre;
	
	//Constructores
	
	public Empleado(String pNom){
		setCodEmpleado("Emp-"+(cantEmp+1));
		setEmpNombre(pNom);
		cantEmp++;
	}
	
	//Sets y Gets
	
	public String getCodEmpleado() {
		return codEmpleado;
	}
	private void setCodEmpleado(String codEmpleado) {
		this.codEmpleado = codEmpleado;
	}
	public String getEmpNombre() {
		return empNombre;
	}
	public void setEmpNombre(String empNombre) {
		this.empNombre = empNombre;
	}
}
