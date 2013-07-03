package CapaLogica;

import java.sql.SQLException;
import java.util.ArrayList;

public class SolicitudInstalacion {

	private int cod;
	private String tipo; //Urgente o Normal
	private String fechaRecepcion;
	private String fechaEntrega;
	private String condicion;

	private Tecnico tecnico;
	private int codTecnico;

	private Cliente cliente;
	private int codCliente;
	
	private Computadora computadora;
	private int serie;
	
	private Software programa;
	private int idPrograma;
	
	private ArrayList<Instalacion> instalaciones;
	
	private int diasDemoraNormal;
	private int diasDemoraUrgente;

	public SolicitudInstalacion(int pcod,String ptipo, String pfechaRecepcion, String pfechaEntrega, String pcondicion, int pcodTecnico,
			int pcodCliente, int pserie, int pidPrograma, int pdiasDemoraNormal, int pdiasDemoraUrgente) {
		this.setCod(pcod);
		this.setTipo(ptipo);
		this.setFechaRecepcion(pfechaRecepcion);
		this.setFechaEntrega(pfechaEntrega);
		this.setCondicion(pcondicion);
		this.setCodTecnico(pcodTecnico);
		this.setCodCliente(pcodCliente);
		this.setSerie(pserie);
		this.setIdPrograma(pidPrograma);
		this.setDiasDemoraNormal(pdiasDemoraNormal);
		this.setDiasDemoraUrgente(pdiasDemoraUrgente);
		
		this.tecnico = null;
		this.cliente = null;
		this.computadora = null;
		this.programa = null;
	}

	public int getCod() {
		return cod;
	}

	public void setCod(int cod) {
		this.cod = cod;
	}

	public String getTipo() {
		return tipo;
	}

	public void setTipo(String tipo) {
		this.tipo = tipo;
	}

	public String getFechaRecepcion() {
		return fechaRecepcion;
	}

	public void setFechaRecepcion(String fechaRecepcion) {
		this.fechaRecepcion = fechaRecepcion;
	}

	public String getFechaEntrega() {
		return fechaEntrega;
	}

	public void setFechaEntrega(String fechaEntrega) {
		this.fechaEntrega = fechaEntrega;
	}

	public String getCondicion() {
		return condicion;
	}

	public void setCondicion(String condicion) {
		this.condicion = condicion;
	}

	public Tecnico getTecnico() throws SQLException, Exception {
		if(this.tecnico == null) {
			this.setTecnico((new MultiTecnico()).buscarPorID(this.getCodTecnico()));
		}
		return tecnico;
	}

	public void setTecnico(Tecnico tecnico) {
		this.tecnico = tecnico;
	}

	public int getCodTecnico() {
		return codTecnico;
	}

	public void setCodTecnico(int codTecnico) {
		this.codTecnico = codTecnico;
	}

	public Cliente getCliente() throws SQLException, Exception {
		if(this.cliente == null) {
			this.setCliente((new MultiCliente()).buscarPorID(this.getCodCliente()));
		}
		return cliente;
	}

	public void setCliente(Cliente cliente) {
		this.cliente = cliente;
	}

	public int getCodCliente() {
		return codCliente;
	}

	public void setCodCliente(int codCliente) {
		this.codCliente = codCliente;
	}

	public Computadora getComputadora() throws SQLException, Exception {
		if(this.computadora == null) {
			this.setComputadora((new MultiComputadora()).buscar(this.getSerie()));
		}
		return computadora;
	}

	public void setComputadora(Computadora computadora) {
		this.computadora = computadora;
	}

	public int getSerie() {
		return serie;
	}

	public void setSerie(int serie) {
		this.serie = serie;
	}

	public Software getPrograma() throws SQLException, Exception {
		this.setPrograma((new MultiSoftware()).buscar(this.getIdPrograma()));
		return programa;
	}

	public void setPrograma(Software programa) {
		this.programa = programa;
	}

	public int getIdPrograma() {
		return idPrograma;
	}

	public void setIdPrograma(int idPrograma) {
		this.idPrograma = idPrograma;
	}

	public int getDiasDemoraNormal() {
		return diasDemoraNormal;
	}

	public void setDiasDemoraNormal(int diasDemoraNormal) {
		this.diasDemoraNormal = diasDemoraNormal;
	}

	public int getDiasDemoraUrgente() {
		return diasDemoraUrgente;
	}

	public void setDiasDemoraUrgente(int diasDemoraUrgente) {
		this.diasDemoraUrgente = diasDemoraUrgente;
	}

	public ArrayList<Instalacion> getInstalaciones() throws SQLException, Exception {
		if(instalaciones==null){
			setInstalaciones((new MultiInstalacion()).buscarPorSolicitud(getCod()));
		}
		return instalaciones;
	}

	public void setInstalaciones(ArrayList<Instalacion> instalaciones) {
		this.instalaciones = instalaciones;
	}

}
