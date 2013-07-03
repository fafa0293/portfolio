package CapaLogica;

import java.util.Vector;

import CapaAccesoBD.AccesoBD;
import CapaAccesoBD.Conector;

public class MultiSistemaOperativo {

	public SistemaOperativo buscarPorID(int pid) throws java.sql.SQLException,Exception{
		SistemaOperativo SO = null;
		java.sql.ResultSet rs;
		String sql;
		sql =	"SELECT * " +
				"FROM TSistemaOperativo "+
				"WHERE ID = " + pid + ";";
		rs = Conector.getConector().ejecutarSQL(sql, true);
		if(rs.next()) {
			SO = new SistemaOperativo(
					rs.getInt("ID"),
					rs.getString("nombre"),
					rs.getString("version")
					);
		} else {
			throw new Exception ("El sistema operativo no esta registrado.");
		}
		rs.close();
		return SO;
	}
	
	public  Vector buscarTodos() throws 
			java.sql.SQLException,Exception{
		Vector so=null;
		java.sql.ResultSet rs;
		String sql;
		sql = "SELECT * "+
		"FROM TSistemaOperativo ";
		rs = Conector.getConector().ejecutarSQL(sql,true);
		so = new Vector<SistemaOperativo> ();
		if (rs.next()) {
			do {
				String[] soS=new String[3];
				soS[0] =""+rs.getInt("ID");
				soS[1] =rs.getString("nombre");
				soS[2] =rs.getString("version");
				so.add(soS);
			} while (rs.next());
		} else {
			throw new Exception ("No hay Sistemas Operativos registrados.");
		}
		rs.close();
		return so;
	}

	public SistemaOperativo crearSO(int pid, String pnombre, String pversion) {
		SistemaOperativo SO = null;
		String sql;
		
		sql =	"INSERT INTO TSistemaOperativo " +
				"VALUES (" + pid + ", '" + pnombre + "', '" + pversion + "');";
		System.out.println(sql);
		try {
			AccesoBD objABD = Conector.getConector();
			objABD.ejecutarSQL(sql);
			SO = new SistemaOperativo (pid, pnombre, pversion);
		} catch (Exception e) {}
		
		return SO;
	}

	
}