package CapaLogica;

public class Parametro {
	
//	La cantidad de d�as que demora la prestaci�n de un servicio normal es de 3 d�as. La cantidad de 
//	d�as que demora la prestaci�n de un servicio urgente es de 2 d�as. La cantidad m�xima de 
//	solicitudes pendientes que puede �manejar� un t�cnico ser� de 5. Cualquier modificaci�n a cada 
//	uno de estos par�metros aplicar� solamente para las solicitudes de servicio que sean registradas 
//	despu�s de aplicar la modificaci�n. 
	
	private  int diasDemoraNormal;
	private  int diasDemoraUrgente;
	private  int cantSolicitudesTecnicoPendiente;
	
	public Parametro(int pdiasDemoraNormal, int pdiasDemoraUrgente, int pcantSolicitudesTecnicoPendiente) {
		this.setDiasDemoraNormal(pdiasDemoraNormal);
		this.setDiasDemoraUrgente(pdiasDemoraUrgente);
		this.setCantSolicitudesTecnicoPendiente(pcantSolicitudesTecnicoPendiente);
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
	public int getCantSolicitudesTecnicoPendiente() {
		return cantSolicitudesTecnicoPendiente;
	}
	public void setCantSolicitudesTecnicoPendiente(int cantSolicitudesTecnicoPendiente) {
		this.cantSolicitudesTecnicoPendiente = cantSolicitudesTecnicoPendiente;
	}
	
	
	
}
