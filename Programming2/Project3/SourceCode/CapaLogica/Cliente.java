package CapaLogica;

import java.sql.SQLException;

public class Cliente {
	private int id;
	private String nombre;
	private String apellido;
	private String mail;
	private String telefono;
	
	private Computadora computadora;
	private int serieComp;
	
	public Cliente(int pid, String pnombre, String papellido, String pmail, String ptelefono) {
		this.setId(pid);
		this.setNombre(pnombre);
		this.setApellido(papellido);
		this.setMail(pmail);
		this.setTelefono(ptelefono);
		this.computadora = null;
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
	public String getTelefono() {
		return telefono;
	}
	public void setTelefono(String telefono) {
		this.telefono = telefono;
	}

	public int getSerieComp() {
		return serieComp;
	}

	public void setSerieComp(int serieComp) {
		this.serieComp = serieComp;
	}

	public Computadora getComputadora() throws SQLException, Exception {
		if(this.computadora == null) {
			this.setComputadora(new MultiCliente().buscarComputadora(this.getId()));
		}
		return computadora;
	}

	public void setComputadora(Computadora computadora) {
		this.computadora = computadora;
	}
	
	
}