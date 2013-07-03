package CapaLogica;

import java.util.ArrayList;
import java.util.Vector;

import CapaAccesoBD.AccesoBD;
import CapaAccesoBD.Conector;

public class MultiSoftware {

	public ArrayList<Software> buscarPorIDComputadora(int serie) {
		// TODO Auto-generated method stub
		return null;
	}

	public Software crear(int pid, String pnombre ,String pdesc, String pramRequerida, String pminHDD, String pminCPU, int pcodSO)throws Exception {
		Software programa = null;
		String sql;
		
		sql =	"INSERT INTO TSoftware ( ID, nombre, [desc], ramRequerida, minHDD, minCPU, SO ) " +
				"VALUES (" + pid + ", '" + pnombre + "', '" + pdesc + "', '" + pramRequerida + "' , '" + pminHDD + "', '" + pminCPU + "', " + pcodSO + ");";
		try {
			AccesoBD objABD = Conector.getConector();
			objABD.ejecutarSQL(sql);
			programa = new Software( pid, pnombre, pdesc, pramRequerida, pminHDD, pminCPU, pcodSO);
		} catch (Exception e) {
			throw new Exception ("El Código ya esta en el sistema.");
		}
		
		return programa;
	}

	public Software buscar(int pidPrograma) throws java.sql.SQLException,Exception{
		Software programa = null;
		java.sql.ResultSet rs;
		String sql;
		sql =	"SELECT * " +
				"FROM TSoftware "+
				"WHERE ID = " + pidPrograma + ";";
		rs = Conector.getConector().ejecutarSQL(sql, true);
		if(rs.next()) {
			programa = new Software(
					rs.getInt("ID"),
					rs.getString("nombre"),
					rs.getString("desc"),
					rs.getString("ramRequerida"),
					rs.getString("minHDD"),
					rs.getString("minCPU"),
					rs.getInt("SO")
					);
		} else {
			throw new Exception ("El software no esta registrado.");
		}
		rs.close();
		return programa;
	}

	
	public  Vector buscarTodosSinInstalar() throws 
			java.sql.SQLException,Exception{
		Vector softwares=null;
		java.sql.ResultSet rs;
		String sql;
		Software software;
		sql = "SELECT * "+
		"FROM TSoftware ;";
		rs = Conector.getConector().ejecutarSQL(sql,true);
		softwares = new Vector<Software> ();
		if (rs.next()) {
			do {
				software = new Software(
						rs.getInt("ID"),
						rs.getString("nombre"),
						rs.getString("desc"),
						rs.getString("ramRequerida"),
						rs.getString("minHDD"),
						rs.getString("minCPU"),
						rs.getInt("SO")
						);
				softwares.add(software);
			} while (rs.next());
		} else {
			softwares=null;
		}
		rs.close();
		return softwares;
	}

}
