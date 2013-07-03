/*
 * Programa:			PrpPlanNombres
 * Fecha de creacion: 	4/Julio/2012
 * Autor(es):			Fabian Vega, Chris Esquivel
 * _ _  _  |` _ _|_ _  _
 *(_(/_| |~|~(_) | (/_(_
 *
 */

public class Actividad {
	public static int cantActividades = 0;
	private String descripcion;
	private String fechaPConclusion;
	private String fechaConclusion;
	
	//Constructores
	
	public Actividad(String pdesc, String pfechaP) {
		this.setDescripcion(pdesc);
		this.setFechaPConclusion(pfechaP);
		this.setFechaConclusion("No ha concluido");
		cantActividades++;
	}
	
	//Sets y Gets
	
	public String getFechaConclusion() {
		return fechaConclusion;
	}
	public void setFechaConclusion(String fechaConclusion) {
		this.fechaConclusion = fechaConclusion;
	}
	public String getFechaPConclusion() {
		return fechaPConclusion;
	}
	public void setFechaPConclusion(String fechaPConclusion) {
		this.fechaPConclusion = fechaPConclusion;
	}
	public String getDescripcion() {
		return descripcion;
	}
	public void setDescripcion(String descripcion) {
		this.descripcion = descripcion;
	}
	
	public String toString() {
		String inf = "Descripcion: " + this.getDescripcion() + "\n";
		inf += "Fecha Preliminar de conclusion: " + this.getFechaPConclusion() + "\n";
		inf += "Fecha Conclusion: " + this.getFechaConclusion();
		return inf;
	}
}
