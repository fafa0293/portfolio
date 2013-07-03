package CapaLogica;

import java.sql.Date;
import java.util.ArrayList;
import java.util.TreeMap;
import java.util.Vector;

import CapaAccesoBD.AccesoBD;
import CapaAccesoBD.Conector;

public class MultiInstalacion {

	public Instalacion crear(int codPac,int codSoft, String plicencia, Date pfechaInstalacion, Date pfechaExp) throws Exception {
		
		Instalacion instalacion = null;
		String sql;
		if(pfechaExp==null){
			sql =	"INSERT INTO TInstalacion (codPc,codSoftware,Licencia, FechaInstalacion, FechaExpiracion)" +
					"VALUES (" + codPac + "," + codSoft + ",'" + plicencia + "', '" + pfechaInstalacion + "', " + pfechaExp + ");";
		}else{
			sql =	"INSERT INTO TInstalacion (codPc,codSoftware,Licencia, FechaInstalacion, FechaExpiracion)" +
					"VALUES (" + codPac + "," + codSoft + ",'" + plicencia + "', '" + pfechaInstalacion + "', '" + pfechaExp + "');";
		}
		try {
			AccesoBD objABD = Conector.getConector();
			objABD.ejecutarSQL(sql);
			instalacion = new Instalacion( plicencia, pfechaInstalacion, pfechaExp);
		} catch (Exception e) { }
		
		return instalacion;
	}
	
	public  ArrayList<Instalacion> buscarPorSolicitud(int cod) throws 
			java.sql.SQLException,Exception{
		ArrayList<Instalacion> instalaciones=null;
		java.sql.ResultSet rs;
		String sql;
		Instalacion instalacion;
		sql = "SELECT TInstalaciones.* "+
		"FROM TInstalaciones, TSolicitud " +
		"WHERE TSolicitud.cod="+cod+" AND TInstalacion.codPc=TSolicitud.serieComputadora AND TInstalacion.codSoftware=TSolicitud.idPrograma;";
		rs = Conector.getConector().ejecutarSQL(sql,true);
		instalaciones =new ArrayList<Instalacion>();
		if (rs.next()) {
			do {
				instalacion = new Instalacion(
						rs.getString("Licencia"),
						rs.getDate("FechaInstalcion"),
						rs.getDate("FechaExpiracion")
						);
				instalaciones.add(instalacion);
			} while (rs.next());
		} else {
			throw new Exception ("No hay instalaciones registrados para esa solicitud" +
					".");
		}
		rs.close();
		return instalaciones;
	}
	
	public  Instalacion buscarPorPcYSoft(int codP, int codS) throws 
			java.sql.SQLException,Exception{
		java.sql.ResultSet rs;
		String sql;
		Instalacion instalacion;
		sql = "SELECT TInstalaciones.* "+
		"FROM TInstalaciones" +
		"WHERE TInstalacion.codPc="+codP+" AND TInstalacion.codSoftware="+codS+";";
		rs = Conector.getConector().ejecutarSQL(sql,true);
		if (rs.next()) {
				instalacion = new Instalacion(
						rs.getString("Licencia"),
						rs.getDate("FechaInstalcion"),
						rs.getDate("FechaExpiracion")
						);
		} else {
			throw new Exception ("No hay instalaciones registrados para esa PC" +
					".");
		}
		rs.close();
		return instalacion;
	}
	
	public  Vector buscarPorPC(int codP) throws 
			java.sql.SQLException,Exception{
		Vector instalaciones=null;
		java.sql.ResultSet rs;
		String sql;
		sql = "SELECT TInstalacion.* "+
				"FROM TInstalacion" +
				" WHERE TInstalacion.codPc="+codP+";";
		rs = Conector.getConector().ejecutarSQL(sql,true);
		instalaciones = new Vector ();
		if (rs.next()) {
			do {
				TreeMap instalacion=new TreeMap();
				instalacion.put("codPc", rs.getInt("codPc"));
				instalacion.put("codSoft", rs.getInt("codSoftware"));
				instalacion.put("lic", rs.getString("Licencia"));
				instalacion.put("fI", rs.getDate("FechaInstalacion"));
				instalacion.put("fE", rs.getDate("FechaExpiracion"));						
				instalaciones.add(instalacion);
			} while (rs.next());
		} else {
			throw new Exception ("No hay instalaciones registrados para esa computadora.");
		}
		rs.close();
		return instalaciones;
	}
}
