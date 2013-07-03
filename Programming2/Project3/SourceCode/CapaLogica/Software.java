package CapaLogica;

import java.sql.*;

public class Software {
	private int id;
	private String nombre;
	private String desc;
	private String ramRequerida;
	private String minHDD;
	private String minCPU;
	
	private SistemaOperativo SO;
	private int codSO;
	
	public Software(int pid, String pnombre, String pdesc, String pramRequerida, String pminHDD, String pminCPU, int pcodSO) {
		this.setId(pid);
		this.setNombre(pnombre);
		this.setDesc(pdesc);
		this.setRamRequerida(pramRequerida);
		this.setMinHDD(pminHDD);
		this.setMinCPU(pminCPU);
		this.setCodSO(pcodSO);
		this.SO = null;
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

	public String getDesc() {
		return desc;
	}

	public void setDesc(String desc) {
		this.desc = desc;
	}

	public String getRamRequerida() {
		return ramRequerida;
	}

	public void setRamRequerida(String ramRequerida) {
		this.ramRequerida = ramRequerida;
	}

	public String getMinHDD() {
		return minHDD;
	}

	public void setMinHDD(String minHDD) {
		this.minHDD = minHDD;
	}

	public String getMinCPU() {
		return minCPU;
	}

	public void setMinCPU(String minCPU) {
		this.minCPU = minCPU;
	}

	public SistemaOperativo getSO() throws SQLException, Exception {
		if(this.SO == null) {
			this.setSO((new MultiSistemaOperativo()).buscarPorID(this.getId()));
		}
		return SO;
	}

	public void setSO(SistemaOperativo sO) {
		SO = sO;
	}

	public int getCodSO() {
		return codSO;
	}

	public void setCodSO(int codSO) {
		this.codSO = codSO;
	}

	
	
}
