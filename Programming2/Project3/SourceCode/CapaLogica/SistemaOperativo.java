package CapaLogica;

public class SistemaOperativo {
	private int id;
	private String nombre;
	private String version;
	
	public SistemaOperativo(int pid, String pnombre, String pversion) {
		this.setId(pid);
		this.setNombre(pnombre);
		this.setVersion(pversion);
	}

	//Sets & Gets
	public int getId() {
		return id;
	}

	public void setId(int id) {
		this.id = id;
	}

	public String getNombre() {
		return nombre;
	}

	public void setNombre(String nombre) {
		this.nombre = nombre;
	}

	public String getVersion() {
		return version;
	}

	public void setVersion(String version) {
		this.version = version;
	}
	
	
}
