package CapaLogica;

import java.util.Vector;

import CapaAccesoBD.AccesoBD;
import CapaAccesoBD.Conector;

public class MultiSolicitudInstalacion {

	public SolicitudInstalacion crear(int pcod,String ptipo, String pfechaRecepcion, String pfechaEntrega, String pcondicion, int pcodTecnico,
			int pcodCliente, int pserie, int pidPrograma, int pdiasDemoraNormal, int pdiasDemoraUrgente) throws Exception {
		SolicitudInstalacion solicitud = null;
		String sql;

		sql =	"INSERT INTO TSolicitud " +
				"VALUES (" + pcod +" , '" + ptipo + "', '" + pfechaRecepcion + "', '" + pfechaEntrega + "', '" + pcondicion + "', " + pcodTecnico + ", " + pcodCliente + ", " + pserie + ", " + pidPrograma + ", " + pdiasDemoraNormal + ", " + pdiasDemoraUrgente + ");";
		try {
			AccesoBD objABD = Conector.getConector();
			objABD.ejecutarSQL(sql);
			solicitud = new SolicitudInstalacion( pcod,	ptipo, pfechaRecepcion, pfechaEntrega, pcondicion, pcodTecnico, pcodCliente
					, pserie, pidPrograma, pdiasDemoraNormal, pdiasDemoraUrgente);
		} catch (Exception e) {}

		return solicitud;
	}

	public Vector buscarDondeCondicionEs(String pcondicion) throws 
	java.sql.SQLException,Exception {
		Vector solicitudes=null;
		java.sql.ResultSet rs;
		SolicitudInstalacion solicitud;
		String sql;
		sql =	"SELECT * from TSolicitud " +
				"WHERE condicion = '" + pcondicion + "';";;
				rs = Conector.getConector().ejecutarSQL(sql,true);
				solicitudes = new Vector();
				if (rs.next()) {
					do {
						solicitud = new SolicitudInstalacion(
								rs.getInt("cod"),
								rs.getString("tipo"),
								rs.getString("fechaRecepcion"),
								rs.getString("fechaEntrega"),
								rs.getString("condicion"),
								rs.getInt("tecnico"),
								rs.getInt("cliente"),
								rs.getInt("serieComputadora"),
								rs.getInt("idPrograma"),
								rs.getInt("diasDemoraNormal"),
								rs.getInt("diasDemoraUrgente")
								);
						solicitudes.add(solicitud);
					} while (rs.next());
				} else {
					throw new Exception ("No hay solicitudes con condicion "+pcondicion+".");
				}
				rs.close();
				return solicitudes;
	}

	public  Vector buscarPorCondyTec(int codTec, String pcondicion) throws 
	java.sql.SQLException,Exception{
		Vector solicitudes=null;
		java.sql.ResultSet rs;
		SolicitudInstalacion solicitud;
		String sql;
		sql =	"SELECT * from TSolicitud " +
				"WHERE condicion = '" + pcondicion + "' AND tecnico="+codTec+";";
		rs = Conector.getConector().ejecutarSQL(sql,true);
		solicitudes = new Vector();
		if (rs.next()) {
			do {
				solicitud = new SolicitudInstalacion(
						rs.getInt("cod"),
						rs.getString("tipo"),
						rs.getString("fechaRecepcion"),
						rs.getString("fechaEntrega"),
						rs.getString("condicion"),
						rs.getInt("tecnico"),
						rs.getInt("cliente"),
						rs.getInt("serieComputadora"),
						rs.getInt("idPrograma"),
						rs.getInt("diasDemoraNormal"),
						rs.getInt("diasDemoraUrgente")
						);
				solicitudes.add(solicitud);
			} while (rs.next());
		} else {
			throw new Exception ("Este técnico no tiene solicitudes con condición "+pcondicion+".");
		}
		rs.close();
		return solicitudes;
	}
	public  Vector buscarPorTecDisp(int codTec, String pcondicion) throws 
	java.sql.SQLException,Exception{
		Vector solicitudes=null;
		java.sql.ResultSet rs;
		SolicitudInstalacion solicitud;
		String sql;
		sql =	"SELECT * from TSolicitud " +
				"WHERE condicion = '" + pcondicion + "' AND tecnico="+codTec+";";
		rs = Conector.getConector().ejecutarSQL(sql,true);
		solicitudes = new Vector();
		if (rs.next()) {
			do {
				solicitud = new SolicitudInstalacion(
						rs.getInt("cod"),
						rs.getString("tipo"),
						rs.getString("fechaRecepcion"),
						rs.getString("fechaEntrega"),
						rs.getString("condicion"),
						rs.getInt("tecnico"),
						rs.getInt("cliente"),
						rs.getInt("serieComputadora"),
						rs.getInt("idPrograma"),
						rs.getInt("diasDemoraNormal"),
						rs.getInt("diasDemoraUrgente")
						);
				solicitudes.add(solicitud);
			} while (rs.next());
		} else {
			solicitudes=null;
		}
		rs.close();
		return solicitudes;
	}

	public SolicitudInstalacion buscar(int pcod) throws java.sql.SQLException,Exception {
		SolicitudInstalacion solicitud = null;
		java.sql.ResultSet rs;
		String sql;
		sql =	"SELECT * " +
				"FROM TSolicitud " +
				"WHERE cod = " + pcod + ";";
		rs = Conector.getConector().ejecutarSQL(sql,true);
		if (rs.next()){
			solicitud = new SolicitudInstalacion(
					rs.getInt("cod"),
					rs.getString("tipo"),
					rs.getString("fechaRecepcion"),
					rs.getString("fechaEntrega"),
					rs.getString("condicion"),
					rs.getInt("tecnico"),
					rs.getInt("cliente"),
					rs.getInt("serieComputadora"),
					rs.getInt("idPrograma"),
					rs.getInt("diasDemoraNormal"),
					rs.getInt("diasDemoraUrgente")
					);
		} else {
			throw new Exception ("La solicitud no se encontro");
		}
		rs.close();

		return solicitud;
	}

	public void borrar(SolicitudInstalacion psolicitud) throws java.sql.SQLException,Exception {
		String sql;
		sql = 	"DELETE FROM TSolicitud " +
				"WHERE cod = " + psolicitud.getCod() + ";";
		try {
			Conector.getConector().ejecutarSQL(sql);
		}
		catch (Exception e) {
			throw new Exception ("No se borro la solicitud.");
		}

	}

	public void finalizarCondicion(int pcodSolicitud)  throws java.sql.SQLException,Exception {
		String sql;
		sql = 	"UPDATE TSolicitud " +
				"SET condicion = 'Finalizado'" +
				" WHERE cod = " + pcodSolicitud + ";";
		try {
			Conector.getConector().ejecutarSQL(sql);
		}
		catch (Exception e) {
			throw new Exception ("La solicitud no se encontro.");
		}
	}


}
