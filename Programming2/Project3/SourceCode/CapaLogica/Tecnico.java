package CapaLogica;

public class Tecnico {
	
	private int id;
	private String nombre;
	private String apellido;
	private String mail;
	
	public Tecnico(int pid, String pnombre, String papellido, String pmail) {
		this.setId(pid);
		this.setNombre(pnombre);
		this.setApellido(papellido);
		this.setMail(pmail);
		
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

	public String getApellido() {
		return apellido;
	}

	public void setApellido(String apellido) {
		this.apellido = apellido;
	}

	public String getMail() {
		return mail;
	}

	public void setMail(String mail) {
		this.mail = mail;
	}
	
}
