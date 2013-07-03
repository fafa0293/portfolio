package CapaLogica;

import java.util.Vector;

import CapaAccesoBD.Conector;

public class MultiTecnico {

	public Tecnico crear(int pid, String pnombre, String papellido, String pmail)throws Exception {
		Tecnico tecnico = null;
		String sql;
		sql = 	"INSERT INTO TTecnico " +
				"VALUES (" + pid + ",'" + pnombre + "', '" + papellido + "', '" + pmail + "');";

		try {
			System.out.println(sql);
			Conector.getConector().ejecutarSQL(sql);
			tecnico = new Tecnico ( pid, pnombre, papellido,  pmail );
		}
		catch (Exception e) {
			throw new Exception ("El tecnico ya está en el sistema.");
		}
		return tecnico;
	}

	public Tecnico buscarPorID(int pid) throws java.sql.SQLException,Exception {
		Tecnico tecnico = null;
		java.sql.ResultSet rs;
		String sql;
		sql =	"SELECT ID , nombre, apellido, mail " +
				"FROM TTecnico " +
				"WHERE ID = " + pid + ";";
		rs = Conector.getConector().ejecutarSQL(sql,true);
		if (rs.next()) {
			tecnico = new Tecnico(
					rs.getInt("ID"),
					rs.getString("nombre"),
					rs.getString("apellido"),
					rs.getString("mail")
					);
		} else {
			throw new Exception ("No se encontro el duennio");
		}
		rs.close();

		return tecnico;
	}
	
	public  Vector buscarTodos() throws 
			java.sql.SQLException,Exception{
		Vector tecnicos=null;
		java.sql.ResultSet rs;
		String sql;
		sql = "SELECT * "+
		"FROM TTecnico ";
		rs = Conector.getConector().ejecutarSQL(sql,true);
		tecnicos = new Vector<Tecnico> ();
		if (rs.next()) {
			do {
				Tecnico tecnico=new Tecnico(
						rs.getInt("ID"),
						rs.getString("nombre"),
						rs.getString("apellido"),
						rs.getString("mail")
						);
				tecnicos.add(tecnico);
			} while (rs.next());
		} else {
			throw new Exception ("No hay Tecnicos registrados.");
		}
		rs.close();
		return tecnicos;
	}
	
	public  Vector buscarDisponibles(int cantMax) throws 
			java.sql.SQLException,Exception{
		Vector tecnicos=null;
		Vector tecnicosDisp=null;
		java.sql.ResultSet rs;
		String sql;
		sql = "SELECT * "+
		"FROM TTecnico ";
		rs = Conector.getConector().ejecutarSQL(sql,true);
		tecnicos = new Vector<Tecnico> ();
		if (rs.next()) {
			do {
				Tecnico tecnico=new Tecnico(
						rs.getInt("ID"),
						rs.getString("nombre"),
						rs.getString("apellido"),
						rs.getString("mail")
						);
				tecnicos.add(tecnico);

			} while (rs.next());
		} else {
			throw new Exception ("No hay Tecnicos registrados.");
		}
		rs.close();
		tecnicosDisp=new Vector();
		for(int i=0;i<tecnicos.size();i++){
			Tecnico tec=(Tecnico)tecnicos.get(i);
			Vector solicitudesPendientesDeUnTecnico = (new MultiSolicitudInstalacion()).buscarPorTecDisp(tec.getId(),"Pendiente");
			if(solicitudesPendientesDeUnTecnico==null){
				tecnicosDisp.add(tec);
			}else{	
				if(solicitudesPendientesDeUnTecnico.size() < cantMax) {
					tecnicosDisp.add(tec);
				}
			}

		}
		return tecnicosDisp;
	}
	
	
}
