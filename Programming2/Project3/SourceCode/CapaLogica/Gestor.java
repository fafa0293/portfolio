package CapaLogica;

import java.sql.*;
import java.util.ArrayList;
import java.util.TreeMap;
import java.util.Vector;

import javax.swing.JOptionPane;

public class Gestor {

	public void agregarSistemaOperativo(int pid, String pnombre, String pversion) {
		SistemaOperativo SO =
				(new MultiSistemaOperativo()).crearSO(pid, pnombre, pversion);
	}

	public void agregarTecnico(int pid, String pnombre, String papellido, String pmail) throws Exception {
		Tecnico tecnico =
				(new MultiTecnico()).crear(pid, pnombre, papellido, pmail);
	}

	public void agregarComputadora(int pserie, String pmodelo, String pmarca, String pcpuGHz, String pram, String phdd, int idDuenno ,int pidSO) throws Exception {
		Computadora computadora =
				(new MultiComputadora()).crear( pserie, pmodelo, pmarca, pcpuGHz, pram, phdd, idDuenno ,pidSO);
	}

	public void agregarCliente(int pid, String pnombre, String papellido, String pmail, String ptelefono) throws Exception {
		Cliente cliente = 
				(new MultiCliente()).crear(pid, pnombre, papellido, pmail, ptelefono);
	}

	public void agregarSoftware(int pid, String pnombre,String pdesc, String pramRequerida, String pminHDD, String pminCPU, int pcodSO) throws Exception {
		Software software =
				(new MultiSoftware()).crear(pid, pnombre, pdesc, pramRequerida, pminHDD, pminCPU, pcodSO);
	}
	
	public void agregarInstalacion(int codPac,int codSoft, String plicencia, Date pfechaInstalacion, Date pfechaExp) throws Exception {
				(new MultiInstalacion()).crear(codPac, codSoft,plicencia, pfechaInstalacion, pfechaExp);
	}

	public void agregarSolicitud(int pcod,String ptipo, String pfechaRecepcion, String pfechaEntrega, String pcondicion, int pcodTecnico,
			int pcodCliente, int pserie, int pidPrograma, int pdiasDemoraNormal, int pdiasDemoraUrgente) throws Exception {

		
		Software programa = (new MultiSoftware()).buscar(pidPrograma);
		int versionSistOperativoDelPrograma = programa.getCodSO();
		
		SistemaOperativo SO = (new MultiSistemaOperativo()).buscarPorID(versionSistOperativoDelPrograma);
		int versionDelSistemaOperativo = SO.getId();

		
			if(versionSistOperativoDelPrograma == versionDelSistemaOperativo) {
				SolicitudInstalacion solicitud = 
						(new MultiSolicitudInstalacion()).crear( pcod,ptipo, pfechaRecepcion, pfechaEntrega, pcondicion, pcodTecnico, pcodCliente
								, pserie, pidPrograma, pdiasDemoraNormal, pdiasDemoraUrgente);
			} else {
				throw new Exception("El programa no es compatible con el sistema operativo");
			}
	}

	public Vector clienteBuscarTodos() throws Exception {
		Vector clientes=null;
		Vector datosClientes=null;
		Cliente cliente;
		String[] clienteS;
		clientes = (new MultiCliente()).buscarTodos();
		datosClientes = new Vector();
		for (int i=0; i<clientes.size(); i++) {
			clienteS = ((String[]) clientes.get(i));
			cliente=new Cliente(Integer.parseInt(clienteS[0]),clienteS[1],clienteS[2],clienteS[3],clienteS[4]);
			TreeMap datosCliente = new TreeMap();
			datosCliente.put("id", cliente.getId());
			datosCliente.put("nom", cliente.getNombre());
			datosCliente.put("apell",cliente.getApellido());
			datosCliente.put("mail", cliente.getMail());
			datosCliente.put("tel", cliente.getTelefono());
			datosClientes.add(datosCliente);
		}
		return datosClientes;
	}

	public Vector tecnicoBuscarTodos() throws Exception {
		Vector tecnicos=null;
		Vector datosTecnicos=null;
		Tecnico tecnico;
		tecnicos = (new MultiTecnico()).buscarTodos();
		datosTecnicos = new Vector();
		for (int i=0; i<tecnicos.size(); i++) {
			tecnico =  (Tecnico)tecnicos.get(i);
			TreeMap datosTecnico = new TreeMap();
			datosTecnico.put("id", tecnico.getId());
			datosTecnico.put("nom", tecnico.getNombre());
			datosTecnico.put("apell",tecnico.getApellido());
			datosTecnico.put("mail", tecnico.getMail());
			datosTecnicos.add(datosTecnico);
		}
		return datosTecnicos;
	}

	public Vector sOBuscarTodos() throws Exception {
		Vector sOs=null;
		Vector datosSOs=null;
		SistemaOperativo sO;
		String[] sOS;
		sOs = (new MultiSistemaOperativo()).buscarTodos();
		datosSOs = new Vector();
		for (int i=0; i<sOs.size(); i++) {
			sOS = ((String[]) sOs.get(i));
			sO=new SistemaOperativo(Integer.parseInt(sOS[0]),sOS[1],sOS[2]);
			TreeMap datosSO = new TreeMap();
			datosSO.put("id", sO.getId());
			datosSO.put("nom", sO.getNombre());
			datosSO.put("vers",sO.getVersion());
			datosSOs.add(datosSO);
		}
		return datosSOs;
	}

	public Vector consultarSolicitudesCondicionEs(String pcondicion) throws SQLException, Exception {
		Vector solicitudes = null;
		Vector datosSolicitudes = null;
		SolicitudInstalacion solicitud;
		solicitudes = (new MultiSolicitudInstalacion()).buscarDondeCondicionEs(pcondicion);
		datosSolicitudes = new Vector();

		for (int i=0 ; i<solicitudes.size() ; i++) {
			solicitud = ((SolicitudInstalacion) solicitudes.get(i));
			TreeMap datosSolicitud = new TreeMap();
			datosSolicitud.put("cod", solicitud.getCod());
			datosSolicitud.put("tipo", solicitud.getTipo());
			datosSolicitud.put("fechaRecepcion", solicitud.getFechaRecepcion());
			datosSolicitud.put("fechaEntrega", solicitud.getFechaEntrega());
			datosSolicitud.put("pc", solicitud.getComputadora());
			datosSolicitud.put("soft", solicitud.getPrograma());
			datosSolicitud.put("condicion", solicitud.getCondicion());
			datosSolicitud.put("tecnico", solicitud.getTecnico());
			datosSolicitud.put("cliente", solicitud.getCliente());
			datosSolicitudes.add(datosSolicitud);
		}
		return datosSolicitudes;

	}

	public Vector consultarSolicitudesPorTec(int codTec,String pcondicion) throws SQLException, Exception {
		Vector solicitudes = null;
		Vector datosSolicitudes = null;
		SolicitudInstalacion solicitud;
		solicitudes = (new MultiSolicitudInstalacion()).buscarPorCondyTec(codTec, pcondicion);
		datosSolicitudes = new Vector();
		
		for (int i=0 ; i<solicitudes.size() ; i++) {
			solicitud = ((SolicitudInstalacion) solicitudes.get(i));
			TreeMap datosSolicitud = new TreeMap();
			datosSolicitud.put("cod", solicitud.getCod());
			datosSolicitud.put("tipo", solicitud.getTipo());
			datosSolicitud.put("fechaRecepcion", solicitud.getFechaRecepcion());
			datosSolicitud.put("fechaEntrega", solicitud.getFechaEntrega());
			datosSolicitud.put("condicion", solicitud.getCondicion());
			datosSolicitud.put("soft", solicitud.getPrograma());
			datosSolicitud.put("pc", solicitud.getComputadora());
			datosSolicitud.put("tecnico", solicitud.getTecnico());
			datosSolicitud.put("cliente", solicitud.getCliente());
			datosSolicitudes.add(datosSolicitud);
		}
		return datosSolicitudes;

	}

	public Vector consultarPcCliente(int codCliente) throws SQLException, Exception {
		Vector computadoras = null;
		Vector datosComputadoras = null;
		Computadora computadora;
		computadoras = (new MultiComputadora()).buscarCliente(codCliente);
		datosComputadoras = new Vector();

		for (int i=0 ; i<computadoras.size() ; i++) {
			computadora = (Computadora)computadoras.get(i);
			TreeMap datosComputadora = new TreeMap();
			datosComputadora.put("serie", computadora.getSerie());
			datosComputadora.put("modelo", computadora.getModelo());
			datosComputadora.put("marca", computadora.getMarca());
			datosComputadora.put("cpu", computadora.getCpuGHz());
			datosComputadora.put("ram", computadora.getRam());
			datosComputadora.put("hd", computadora.getHdd());
			datosComputadora.put("so", computadora.getSO());
			datosComputadoras.add(datosComputadora);
		}
		return datosComputadoras;

	}
	
	public Vector consultarPcClienteS(int codCliente) throws SQLException, Exception {
		Vector computadoras = null;
		Vector datosComputadoras = null;
		Computadora computadora;
		computadoras = (new MultiComputadora()).buscarClienteS(codCliente);
		datosComputadoras = new Vector();

		for (int i=0 ; i<computadoras.size() ; i++) {
			computadora = (Computadora)computadoras.get(i);
			TreeMap datosComputadora = new TreeMap();
			datosComputadora.put("serie", computadora.getSerie());
			datosComputadora.put("modelo", computadora.getModelo());
			datosComputadora.put("marca", computadora.getMarca());
			datosComputadora.put("cpu", computadora.getCpuGHz());
			datosComputadora.put("ram", computadora.getRam());
			datosComputadora.put("hd", computadora.getHdd());
			datosComputadora.put("so", computadora.getSO());
			datosComputadoras.add(datosComputadora);
		}
		return datosComputadoras;

	}

	public Vector consultarSoftwarePc(int serie) throws SQLException, Exception {
		Vector datosSoftwares = null;
		Software software;
		Vector instalaciones = null;
		TreeMap instalacion;
		instalaciones=(new MultiInstalacion()).buscarPorPC(serie);
		datosSoftwares = new Vector();

		for (int i=0 ; i<instalaciones.size() ; i++) {
			instalacion=(TreeMap)instalaciones.get(i);
			software = (new MultiSoftware()).buscar(Integer.parseInt(""+instalacion.get("codSoft")));
			TreeMap datosSoftware = new TreeMap();
			datosSoftware.put("nom", software.getNombre());
			datosSoftware.put("lic", instalacion.get("lic"));
			datosSoftware.put("fechaI", instalacion.get("fI"));
			datosSoftware.put("fechaE", instalacion.get("fE"));
			datosSoftwares.add(datosSoftware);
		}
		return datosSoftwares;

	}
	public Vector consultarSoftwareSinInst() throws SQLException, Exception {
		Vector softwares = null;
		Vector datosSoftwares = null;
		Software software;
		softwares = (new MultiSoftware()).buscarTodosSinInstalar();
		datosSoftwares = new Vector();

		for (int i=0 ; i<softwares.size() ; i++) {
			software = (Software)softwares.get(i);
			TreeMap datosSoftware = new TreeMap();
			datosSoftware.put("id", software.getId());
			datosSoftware.put("nom", software.getNombre());
			datosSoftwares.add(datosSoftware);
		}
		return datosSoftwares;

	}

	public void borrarComputadora(int pid) throws Exception {
		(new MultiComputadora()).borrar((new MultiComputadora()).buscar(pid));
	}

	public Parametro consultarParametros() throws SQLException, Exception {
		Parametro param = (new MultiParametro()).consultar();
		return param;
	}

	public void parametroModificar(int pdiasNormal, int pdiasUrgente, int pdiasMax) throws Exception {
		Parametro param;
		param = (new MultiParametro()).consultar();
		param.setDiasDemoraNormal(pdiasNormal);
		param.setDiasDemoraUrgente(pdiasUrgente);
		param.setCantSolicitudesTecnicoPendiente(pdiasMax);
		(new MultiParametro()).actualizar(param);
	}


	public void borrarSolicitud(int pcod) throws Exception {
		SolicitudInstalacion solicitud;
		solicitud = (new MultiSolicitudInstalacion()).buscar(pcod);
		(new MultiSolicitudInstalacion()).borrar(solicitud);
	}
	
	public Vector tecnicoBuscarDisponible() throws Exception {
		Vector tecnicos=null;
		Vector datosTecnicos=null;
		Tecnico tecnico;
		int cantMax=consultarParametros().getCantSolicitudesTecnicoPendiente();
		tecnicos = (new MultiTecnico()).buscarDisponibles(cantMax);
		datosTecnicos = new Vector();
		for (int i=0; i<tecnicos.size(); i++) {
			tecnico =  (Tecnico)tecnicos.get(i);
			TreeMap datosTecnico = new TreeMap();
			datosTecnico.put("id", tecnico.getId());
			datosTecnico.put("nom", tecnico.getNombre());
			datosTecnico.put("apell",tecnico.getApellido());
			datosTecnico.put("mail", tecnico.getMail());
			datosTecnicos.add(datosTecnico);
		}
		return datosTecnicos;
	}
	
	public void finalizarCondicionSolicitud(int pcodSolicitud) throws SQLException, Exception {
		SolicitudInstalacion solicitud;
		solicitud = (new MultiSolicitudInstalacion()).buscar(pcodSolicitud);
		solicitud.setCondicion("Finalizada");
		(new MultiSolicitudInstalacion()).finalizarCondicion(pcodSolicitud);
	}

}
