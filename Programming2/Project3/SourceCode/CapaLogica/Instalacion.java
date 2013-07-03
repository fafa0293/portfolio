package CapaLogica;

import java.sql.Date;

public class Instalacion {
	
	private String licencia;
	private Date fechaInstalacion;
	private Date fechaExp;
	
	public Instalacion(String plicencia, Date pfechaInstalacion, Date pfechaExp) {
		this.setLicencia(plicencia);
		this.setFechaInstalacion(pfechaInstalacion);
		this.setFechaExp(pfechaExp);
	}

	public String getLicencia() {
		return licencia;
	}

	public void setLicencia(String licencia) {
		this.licencia = licencia;
	}

	public Date getFechaInstalacion() {
		return fechaInstalacion;
	}

	public void setFechaInstalacion(Date fechaInstalacion) {
		this.fechaInstalacion = fechaInstalacion;
	}

	public Date getFechaExp() {
		return fechaExp;
	}

	public void setFechaExp(Date fechaExp) {
		this.fechaExp = fechaExp;
	}
	
	
}
