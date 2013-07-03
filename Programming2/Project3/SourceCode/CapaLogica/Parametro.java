package CapaLogica;

public class Parametro {
	
//	La cantidad de días que demora la prestación de un servicio normal es de 3 días. La cantidad de 
//	días que demora la prestación de un servicio urgente es de 2 días. La cantidad máxima de 
//	solicitudes pendientes que puede “manejar” un técnico será de 5. Cualquier modificación a cada 
//	uno de estos parámetros aplicará solamente para las solicitudes de servicio que sean registradas 
//	después de aplicar la modificación. 
	
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
