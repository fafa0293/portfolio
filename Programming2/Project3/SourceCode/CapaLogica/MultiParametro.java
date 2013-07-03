package CapaLogica;

import CapaAccesoBD.Conector;

public class MultiParametro {

	public Parametro consultar() throws java.sql.SQLException,Exception {
		Parametro param = null;
		java.sql.ResultSet rs;
		String sql;
		sql =	"SELECT * " +
				"FROM TParametro;";
		rs = Conector.getConector().ejecutarSQL(sql,true);
		if (rs.next()) {
			param = new Parametro(
					rs.getInt("diasDemoraNormal"),
					rs.getInt("diasDemoraUrgente"),
					rs.getInt("cantSolicitudesTecnicoPendiente")
					);
		} else {
			throw new Exception ("No se encontro el parametro");
		}
		rs.close();

		return param;
	}

	public void actualizar(Parametro pparam) throws java.sql.SQLException,Exception {
		String sql;
		sql = 	"UPDATE TParametro "+
				"SET diasDemoraNormal = " + pparam.getDiasDemoraNormal() + 
				", diasDemoraUrgente =  " + pparam.getDiasDemoraUrgente() +
				", cantSolicitudesTecnicoPendiente =  " + pparam.getCantSolicitudesTecnicoPendiente() +
				" WHERE ID = 1;";
		try {
			Conector.getConector().ejecutarSQL(sql);
		}
		catch (Exception e) {
			throw new Exception ("El parametro no está registrado.");
		}
	}


}
