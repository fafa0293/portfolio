package CapaLogica;

import java.sql.SQLException;
import java.util.ArrayList;

public class Computadora {

	private int serie;
	private String modelo;
	private String marca;
	private String cpuGHz;
	private String ram;
	private String hdd;
	
	private SistemaOperativo SO;
	private int idSO;
	
	private ArrayList<Software> programas;
	
	public Computadora(int pserie, String pmodelo, String pmarca, String pcpuGHz, String pram, String phdd, int pidSO) {
		this.setSerie(pserie);
		this.setModelo(pmodelo);
		this.setMarca(pmarca);
		this.setCpuGHz(pcpuGHz);
		this.setRam(pram);
		this.setHdd(phdd);
		this.setIdSO(pidSO);
		
		this.SO = null;
		this.programas = null;
	}
	
	//Sets & Gets
	public String getModelo() {
		return modelo;
	}

	public void setModelo(String modelo) {
		this.modelo = modelo;
	}

	public String getMarca() {
		return marca;
	}

	public void setMarca(String marca) {
		this.marca = marca;
	}

	public String getCpuGHz() {
		return cpuGHz;
	}

	public void setCpuGHz(String cpuGHz) {
		this.cpuGHz = cpuGHz;
	}

	public String getRam() {
		return ram;
	}

	public void setRam(String ram) {
		this.ram = ram;
	}

	public String getHdd() {
		return hdd;
	}

	public void setHdd(String hdd) {
		this.hdd = hdd;
	}

	public SistemaOperativo getSO() throws SQLException, Exception {
		if(this.SO == null) {
			this.setSO((new MultiSistemaOperativo()).buscarPorID(this.idSO));
		}
		return SO;
	}

	public void setSO(SistemaOperativo sO) {
		SO = sO;
	}

	public int getIdSO() {
		return idSO;
	}

	public void setIdSO(int idSO) {
		this.idSO = idSO;
	}

	public ArrayList<Software> getProgramas() {
		if(this.programas == null) {
			this.setProgramas((new MultiSoftware()).buscarPorIDComputadora(this.getSerie()));
		}
		return programas;
	}

	public void setProgramas(ArrayList<Software> programas) {
		this.programas = programas;
	}

	public int getSerie() {
		return serie;
	}

	public void setSerie(int serie) {
		this.serie = serie;
	}
	

	
}
