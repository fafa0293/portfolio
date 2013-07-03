package CapaLogica;

import java.util.Vector;

import CapaAccesoBD.AccesoBD;
import CapaAccesoBD.Conector;

public class MultiComputadora {

	public Computadora crear(int pserie, String pmodelo, String pmarca, String pcpuGHz, String pram, String phdd, int idDuenno ,int pidSO)throws Exception {
		Computadora computadora = null;
		String sql;

		sql =	"INSERT INTO TComputadora(serie,modelo,marca,cpuGHz,ram,hdd,SO,Duenno) " +
				"VALUES (" + pserie + ", '" + pmodelo + "', '" + pmarca + "', '" + pcpuGHz + "', '" + pram + "', '" + phdd + "', " + pidSO + ", " + idDuenno + ");";
		try {
			AccesoBD objABD = Conector.getConector();
			objABD.ejecutarSQL(sql);
			computadora = new Computadora( pserie, pmodelo, pmarca, pcpuGHz, pram, phdd, pidSO);
		} catch (Exception e) {
			throw new Exception ("Esta computadora ya esta en el Sistema");
		}

		return computadora;
	}

	public Computadora buscar(int pid) throws java.sql.SQLException,Exception {
		Computadora computadora = null;
		java.sql.ResultSet rs;
		String sql;
		sql =	"SELECT * " +
				"FROM TComputadora " +
				"WHERE serie = " + pid + ";";
		rs = Conector.getConector().ejecutarSQL(sql,true);
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
			throw new Exception ("Esta computadora no se encontro en el sistema");
		}
		rs.close();

		return computadora;
	}
	
	public  Vector buscarCliente(int codCliente) throws 
			java.sql.SQLException,Exception{
		Vector computadoras=null;
		java.sql.ResultSet rs;
		Computadora computadora;
		String sql;
		sql =	"SELECT *" +
				"FROM TComputadora " +
				"WHERE Duenno="+codCliente+ ";";
		rs = Conector.getConector().ejecutarSQL(sql,true);
		computadoras = new Vector();
		if (rs.next()) {
			do {
				computadora = new Computadora(
						rs.getInt("serie"),
						rs.getString("modelo"),
						rs.getString("marca"),
						rs.getString("cpuGHz"),
						rs.getString("ram"),
						rs.getString("hdd"),
						rs.getInt("SO")
						);
				computadoras.add(computadora);
			} while (rs.next());
		} else {
			throw new Exception ("El cliente no tiene Computadoras a las que se le haya instalado algún software.");
		}
		rs.close();
		return computadoras;
	}
	public  Vector buscarClienteS(int codCliente) throws 
			java.sql.SQLException,Exception{
		Vector computadoras=null;
		java.sql.ResultSet rs;
		Computadora computadora;
		String sql;
		sql =	"SELECT TComputadora.* " +
				"FROM TComputadora " +
				"WHERE Duenno="+codCliente +" ;";
		rs = Conector.getConector().ejecutarSQL(sql,true);
		computadoras = new Vector();
		if (rs.next()) {
			do {
				computadora = new Computadora(
						rs.getInt("serie"),
						rs.getString("modelo"),
						rs.getString("marca"),
						rs.getString("cpuGHz"),
						rs.getString("ram"),
						rs.getString("hdd"),
						rs.getInt("SO")
						);
				computadoras.add(computadora);
			} while (rs.next());
		} else {
			throw new Exception ("El cliente no tiene Computadoras.");
		}
		rs.close();
		return computadoras;
		}

	public void borrar(Computadora pcomp) throws java.sql.SQLException,Exception{
		String sql;
		sql = 	"DELETE FROM TComputadora " +
				"WHERE serie = " + pcomp.getSerie() + ";";
		System.out.println(sql);
		try {
			Conector.getConector().ejecutarSQL(sql);
		}
		catch (Exception e) {
			throw new Exception ("La computadora no existe.");
		}
	}
}
