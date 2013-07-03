package CapaLogica;

import java.util.Vector;

import CapaAccesoBD.AccesoBD;
import CapaAccesoBD.Conector;

public class MultiCliente {

	public Cliente crear(int pid, String pnombre, String papellido, String pmail, String ptelefono) throws Exception {
		Cliente cliente = null;
		String sql;
		
		sql =	"INSERT INTO TCliente " +
				"(ID,nombre, apellido, mail, telefono) "+
				"VALUES (" + pid + ",'" + pnombre + "', '" + papellido + "', '" + pmail + "', '" + ptelefono + "');";
		try {
			AccesoBD objABD = Conector.getConector();
			objABD.ejecutarSQL(sql);
			cliente = new Cliente (pid, pnombre, papellido, pmail, ptelefono);
		} catch (Exception e) {
			throw new Exception ("La identificacion ya esta en el sistema.");
		}
		
		return cliente;
	}

	public Cliente buscarPorID(int pid) throws java.sql.SQLException,Exception {
		Cliente cliente = null;
		java.sql.ResultSet rs;
		String sql;
		sql =	"SELECT ID , nombre, apellido, mail, telefono " +
				"FROM TCliente " +
				"WHERE ID = " + pid + ";";
		rs = Conector.getConector().ejecutarSQL(sql,true);
		if (rs.next()){
			cliente = new Cliente(
					rs.getInt("ID"),
					rs.getString("nombre"),
					rs.getString("apellido"),
					rs.getString("mail"),
					rs.getString("telefono")
					);
		} else {
			throw new Exception ("El cliente no esta registrado.");
		}
		rs.close();
		
		return cliente;
	}
	
	public  Vector buscarTodos() throws 
			java.sql.SQLException,Exception{
		Vector clientes=null;
		java.sql.ResultSet rs;
		String sql;
		sql = "SELECT * "+
		"FROM TCliente ";
		rs = Conector.getConector().ejecutarSQL(sql,true);
		clientes = new Vector<Cliente> ();
		if (rs.next()) {
			do {
				String[] cliente=new String[5];
				cliente[0] =""+rs.getInt("ID");
				cliente[1] =rs.getString("nombre");
				cliente[2] =rs.getString("apellido");
				cliente[3] =rs.getString("mail");
				cliente[4] =rs.getString("telefono");
				clientes.add(cliente);
			} while (rs.next());
		} else {
			throw new Exception ("No hay Clientes registrados.");
		}
		rs.close();
		return clientes;
	}
	
	public Computadora buscarComputadora(int pserieComputadora) throws java.sql.SQLException,Exception {
		Computadora computadora = null;
		java.sql.ResultSet rs;
		String sql;
		sql =	"SELECT * " +
				"FROM TComputadora " +
				"WHERE serie = " + pserieComputadora + ";";
		System.out.println(sql);
		rs = Conector.getConector().ejecutarSQL(sql, true);
		
		if (rs.next()){
			computadora = new Computadora(
					rs.getInt("serie"),
					rs.getString("modelo"),
					rs.getString("marca"),
					rs.getString("cpuGHz"),
					rs.getString("ram"),
					rs.getString("hdd"),
					rs.getInt("SO")
					);
		} else {
			throw new Exception ("Este numero de serie no pertenece a una computadora en el sistema");
		}
		rs.close();

		return computadora;
	}
	
	
	
}
