/*
 * Programa:			PrpPlanNombres
 * Fecha de creacion: 	4/Julio/2012
 * Autor(es):			Fabian Vega, Chris Esquivel
 * _ _  _  |` _ _|_ _  _
 *(_(/_| |~|~(_) | (/_(_
 *
 */

public class Sucursal {
	private static int cantSucur=0;
	private String codSucur;
	private String SucurNombre;
	private String SucurDirec;
	private int peso;
	
	//Constructores
	
	public Sucursal(String pNom, String pDirec, int pPeso){
		setCodSucur("Suc-"+(cantSucur+1));
		setSucurNombre(pNom);
		setSucurDirec(pDirec);
		setPeso(pPeso);
		cantSucur++;
	}
	
	//Sets y Gets
	
	public String getCodSucur() {
		return codSucur;
	}
	private void setCodSucur(String codSucur) {
		this.codSucur = codSucur;
	}
	public String getSucurNombre() {
		return SucurNombre;
	}
	public void setSucurNombre(String SucurNombre) {
		this.SucurNombre = SucurNombre;
	}
	public String getSucurDirec() {
		return SucurDirec;
	}

	public void setSucurDirec(String sucurDirec) {
		SucurDirec = sucurDirec;
	}
	
	public int getPeso() {
		return peso;
	}

	public void setPeso(int peso) {
		this.peso = peso;
	}
	
	public String toString(){
		String resul="Codigo de la Sucursal: "+getCodSucur();
		resul+="\nNombre de la Sucursal: "+getSucurNombre();
		resul+="\nDireccion de la Sucursal: "+getSucurDirec();
		return resul;
	}




}
