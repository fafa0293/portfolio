package CapaPresentacion;
import java.awt.Component;
import java.awt.event.ActionEvent;
import java.sql.SQLException;
import java.util.Calendar;
import java.util.TreeMap;
import java.util.Vector;

import javax.swing.AbstractAction;
import javax.swing.ComboBoxModel;
import javax.swing.DefaultComboBoxModel;
import javax.swing.GroupLayout;
import javax.swing.JButton;
import javax.swing.JComboBox;
import javax.swing.JComponent;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JTextField;
import javax.swing.LayoutStyle;
import javax.swing.SwingConstants;

import javax.swing.WindowConstants;
import javax.swing.SwingUtilities;
import CapaLogica.*;
/**
* This code was edited or generated using CloudGarden's Jigloo
* SWT/Swing GUI Builder, which is free for non-commercial
* use. If Jigloo is being used commercially (ie, by a corporation,
* company or business for any purpose whatever) then you
* should purchase a license for each developer using Jigloo.
* Please visit www.cloudgarden.com for details.
* Use of Jigloo implies acceptance of these licensing terms.
* A COMMERCIAL LICENSE HAS NOT BEEN PURCHASED FOR
* THIS MACHINE, SO JIGLOO OR THIS CODE CANNOT BE USED
* LEGALLY FOR ANY CORPORATE OR COMMERCIAL PURPOSE.
*/
public class PantallaSolicitudRegistrar extends javax.swing.JFrame {
	private JLabel eTecEncargado;
	private JLabel eCodSolicutud;
	private JLabel eCliente;
	private JComboBox CbCompu;
	private AbstractAction FnCbTipoSer;
	private AbstractAction FnBtnCancelar;
	private AbstractAction FnBtnRegistrar;
	private AbstractAction FncbCliente;
	private JButton BtnCancelar;
	private JButton BtnAceptar;
	private JComboBox CbCondicion;
	private JTextField txtFechaE;
	private JTextField txtFechaR;
	private JComboBox CbTSer;
	private JComboBox CbSoftware;
	private JTextField txtCodSolicitud;
	private JComboBox CbCliente;
	private JComboBox CbTecnico;
	private JLabel eCondicion;
	private JLabel eFechaE;
	private JLabel eFechaEntrega;
	private JLabel eTipoServ;
	private JLabel eSoftware;
	private JLabel eComputadora;
	private java.util.Date hoy=new java.util.Date();
	private java.util.Date ent=new java.util.Date();
	private Calendar cal=Calendar.getInstance();
	private java.sql.Date hoysql=new java.sql.Date(hoy.getTime());
	private java.sql.Date entsql;
	private String tipoS="";
	private String clieS="";
	private Vector duennos;
	private Vector tecnicos;
	private Vector soft;
	private Vector pcs;
	private Gestor gestor=new Gestor();
	{
		//Set Look & Feel
		try {
			javax.swing.UIManager.setLookAndFeel(javax.swing.UIManager.getSystemLookAndFeelClassName());
		} catch(Exception e) {
			e.printStackTrace();
		}
	}


	/**
	* Auto-generated main method to display this JFrame
	*/
	public static void main(String[] args) {
		SwingUtilities.invokeLater(new Runnable() {
			public void run() {
				PantallaSolicitudRegistrar inst = new PantallaSolicitudRegistrar();
				inst.setLocationRelativeTo(null);
				inst.setVisible(true);
			}
		});
	}
	
	public PantallaSolicitudRegistrar() {
		super();
		initGUI();
	}
	
	private void initGUI() {
		try {
			GroupLayout thisLayout = new GroupLayout((JComponent)getContentPane());
			getContentPane().setLayout(thisLayout);
			setDefaultCloseOperation(WindowConstants.DISPOSE_ON_CLOSE);
			this.setTitle("Registrar Solicitud - Software Seguro");
			{
				eTecEncargado = new JLabel();
				eTecEncargado.setText("Técnico Encargado:");
			}
			{
				BtnAceptar = new JButton();
				BtnAceptar.setText("Registrar");
				BtnAceptar.setAction(getFnBtnRegistrar());
			}
			{
				BtnCancelar = new JButton();
				BtnCancelar.setText("Cancelar");
				BtnCancelar.setAction(getFnBtnCancelar());
			}
			{
				eCodSolicutud = new JLabel();
				eCodSolicutud.setText("Código Solicitud:");
			}
			{
				eCliente = new JLabel();
				eCliente.setText("Cliente: ");
			}
			{
				eComputadora = new JLabel();
				eComputadora.setText("Computadora: ");
			}
			{
				eSoftware = new JLabel();
				eSoftware.setText("Software a Instalar: ");
			}
			{
				eTipoServ = new JLabel();
				eTipoServ.setText("Tipo de Servicio: ");
			}
			{
				eFechaEntrega = new JLabel();
				eFechaEntrega.setText("Fecha de Recepción: ");
			}
			{
				eFechaE = new JLabel();
				eFechaE.setText("Fecha de Entrega:");
			}
			{
				eCondicion = new JLabel();
				eCondicion.setText("Condición: ");
			}
			{
				ComboBoxModel CbTecnicoModel = 
						new DefaultComboBoxModel(
								obtenerTecnicos());
				CbTecnico = new JComboBox();
				CbTecnico.setModel(CbTecnicoModel);
			}
			{
				ComboBoxModel CbClienteModel = 
						new DefaultComboBoxModel(
								obtenerDuennos());
				CbCliente = new JComboBox();
				CbCliente.setModel(CbClienteModel);
				CbCliente.setAction(getFncbCliente());
			}
			{
				txtCodSolicitud = new JTextField();
			}
			{
				ComboBoxModel CbCompuModel = 
						new DefaultComboBoxModel(
								new String[] { "---Seleccionar---"});
				CbCompu = new JComboBox();
				CbCompu.setModel(CbCompuModel);
			}
			{
				ComboBoxModel CbSoftwareModel = 
						new DefaultComboBoxModel(
								obtenerSoft());
				CbSoftware = new JComboBox();
				CbSoftware.setModel(CbSoftwareModel);
			}
			{
				ComboBoxModel CbTSerModel = 
						new DefaultComboBoxModel(
								new String[] { "---Seleccionar---","Normal", "Urgente" });
				CbTSer = new JComboBox();
				CbTSer.setModel(CbTSerModel);
				CbTSer.setAction(getFnCbTipoSer());
			}
			{
				txtFechaR = new JTextField();
				txtFechaR.setEnabled(false);
				txtFechaR.setText(""+hoysql);
			}
			{
				txtFechaE = new JTextField();
				txtFechaE.setEnabled(false);
			}
			{
				ComboBoxModel CbCondicionModel = 
						new DefaultComboBoxModel(
								new String[] { "Pendiente", "Finalizado" });
				CbCondicion = new JComboBox();
				CbCondicion.setModel(CbCondicionModel);
				CbCondicion.setEnabled(false);
			}
			thisLayout.setVerticalGroup(thisLayout.createSequentialGroup()
				.addContainerGap()
				.addGroup(thisLayout.createParallelGroup(GroupLayout.Alignment.BASELINE)
				    .addComponent(CbTecnico, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE)
				    .addComponent(eTecEncargado, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE))
				.addPreferredGap(LayoutStyle.ComponentPlacement.UNRELATED)
				.addGroup(thisLayout.createParallelGroup(GroupLayout.Alignment.BASELINE)
				    .addComponent(txtCodSolicitud, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE)
				    .addComponent(eCodSolicutud, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE))
				.addPreferredGap(LayoutStyle.ComponentPlacement.UNRELATED)
				.addGroup(thisLayout.createParallelGroup(GroupLayout.Alignment.BASELINE)
				    .addComponent(CbCliente, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE)
				    .addComponent(eCliente, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE))
				.addPreferredGap(LayoutStyle.ComponentPlacement.UNRELATED)
				.addGroup(thisLayout.createParallelGroup(GroupLayout.Alignment.BASELINE)
				    .addComponent(CbCompu, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE)
				    .addComponent(eComputadora, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE))
				.addPreferredGap(LayoutStyle.ComponentPlacement.UNRELATED)
				.addGroup(thisLayout.createParallelGroup(GroupLayout.Alignment.BASELINE)
				    .addComponent(CbSoftware, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE)
				    .addComponent(eSoftware, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE))
				.addPreferredGap(LayoutStyle.ComponentPlacement.UNRELATED)
				.addGroup(thisLayout.createParallelGroup(GroupLayout.Alignment.BASELINE)
				    .addComponent(CbTSer, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE)
				    .addComponent(eTipoServ, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE))
				.addPreferredGap(LayoutStyle.ComponentPlacement.UNRELATED)
				.addGroup(thisLayout.createParallelGroup(GroupLayout.Alignment.BASELINE)
				    .addComponent(txtFechaR, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE)
				    .addComponent(eFechaEntrega, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE))
				.addPreferredGap(LayoutStyle.ComponentPlacement.UNRELATED)
				.addGroup(thisLayout.createParallelGroup(GroupLayout.Alignment.BASELINE)
				    .addComponent(txtFechaE, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE)
				    .addComponent(eFechaE, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE))
				.addPreferredGap(LayoutStyle.ComponentPlacement.UNRELATED)
				.addGroup(thisLayout.createParallelGroup(GroupLayout.Alignment.BASELINE)
				    .addComponent(CbCondicion, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE)
				    .addComponent(eCondicion, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE))
				.addPreferredGap(LayoutStyle.ComponentPlacement.UNRELATED)
				.addGroup(thisLayout.createParallelGroup(GroupLayout.Alignment.BASELINE)
				    .addComponent(BtnAceptar, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE)
				    .addComponent(BtnCancelar, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE))
				.addContainerGap());
			thisLayout.setHorizontalGroup(thisLayout.createSequentialGroup()
				.addContainerGap()
				.addGroup(thisLayout.createParallelGroup()
				    .addComponent(eCondicion, GroupLayout.Alignment.LEADING, GroupLayout.PREFERRED_SIZE, 141, GroupLayout.PREFERRED_SIZE)
				    .addComponent(eFechaE, GroupLayout.Alignment.LEADING, GroupLayout.PREFERRED_SIZE, 141, GroupLayout.PREFERRED_SIZE)
				    .addComponent(eFechaEntrega, GroupLayout.Alignment.LEADING, GroupLayout.PREFERRED_SIZE, 141, GroupLayout.PREFERRED_SIZE)
				    .addComponent(eTipoServ, GroupLayout.Alignment.LEADING, GroupLayout.PREFERRED_SIZE, 141, GroupLayout.PREFERRED_SIZE)
				    .addComponent(eSoftware, GroupLayout.Alignment.LEADING, GroupLayout.PREFERRED_SIZE, 141, GroupLayout.PREFERRED_SIZE)
				    .addComponent(eComputadora, GroupLayout.Alignment.LEADING, GroupLayout.PREFERRED_SIZE, 141, GroupLayout.PREFERRED_SIZE)
				    .addComponent(eCliente, GroupLayout.Alignment.LEADING, GroupLayout.PREFERRED_SIZE, 141, GroupLayout.PREFERRED_SIZE)
				    .addComponent(eCodSolicutud, GroupLayout.Alignment.LEADING, GroupLayout.PREFERRED_SIZE, 141, GroupLayout.PREFERRED_SIZE)
				    .addComponent(eTecEncargado, GroupLayout.Alignment.LEADING, GroupLayout.PREFERRED_SIZE, 141, GroupLayout.PREFERRED_SIZE)
				    .addGroup(GroupLayout.Alignment.LEADING, thisLayout.createSequentialGroup()
				        .addGap(50)
				        .addComponent(BtnAceptar, GroupLayout.PREFERRED_SIZE, 88, GroupLayout.PREFERRED_SIZE)))
				.addGap(25)
				.addGroup(thisLayout.createParallelGroup()
				    .addGroup(GroupLayout.Alignment.LEADING, thisLayout.createSequentialGroup()
				        .addComponent(BtnCancelar, GroupLayout.PREFERRED_SIZE, 88, GroupLayout.PREFERRED_SIZE)
				        .addGap(0, 55, Short.MAX_VALUE))
				    .addGroup(thisLayout.createSequentialGroup()
				        .addPreferredGap(LayoutStyle.ComponentPlacement.RELATED)
				        .addGroup(thisLayout.createParallelGroup()
				            .addComponent(CbCondicion, GroupLayout.Alignment.LEADING, 0, 137, Short.MAX_VALUE)
				            .addGroup(thisLayout.createSequentialGroup()
				                .addComponent(txtFechaE, GroupLayout.PREFERRED_SIZE, 137, GroupLayout.PREFERRED_SIZE)
				                .addGap(0, 0, Short.MAX_VALUE))
				            .addGroup(thisLayout.createSequentialGroup()
				                .addComponent(txtFechaR, GroupLayout.PREFERRED_SIZE, 137, GroupLayout.PREFERRED_SIZE)
				                .addGap(0, 0, Short.MAX_VALUE))
				            .addGroup(thisLayout.createSequentialGroup()
				                .addComponent(CbTSer, GroupLayout.PREFERRED_SIZE, 137, GroupLayout.PREFERRED_SIZE)
				                .addGap(0, 0, Short.MAX_VALUE))
				            .addGroup(thisLayout.createSequentialGroup()
				                .addComponent(CbSoftware, GroupLayout.PREFERRED_SIZE, 137, GroupLayout.PREFERRED_SIZE)
				                .addGap(0, 0, Short.MAX_VALUE))
				            .addGroup(thisLayout.createSequentialGroup()
				                .addComponent(CbCompu, GroupLayout.PREFERRED_SIZE, 137, GroupLayout.PREFERRED_SIZE)
				                .addGap(0, 0, Short.MAX_VALUE))
				            .addGroup(thisLayout.createSequentialGroup()
				                .addComponent(CbCliente, GroupLayout.PREFERRED_SIZE, 137, GroupLayout.PREFERRED_SIZE)
				                .addGap(0, 0, Short.MAX_VALUE))
				            .addGroup(thisLayout.createSequentialGroup()
				                .addComponent(txtCodSolicitud, GroupLayout.PREFERRED_SIZE, 137, GroupLayout.PREFERRED_SIZE)
				                .addGap(0, 0, Short.MAX_VALUE))
				            .addGroup(thisLayout.createSequentialGroup()
				                .addComponent(CbTecnico, GroupLayout.PREFERRED_SIZE, 137, GroupLayout.PREFERRED_SIZE)
				                .addGap(0, 0, Short.MAX_VALUE)))))
				.addContainerGap());
			thisLayout.linkSize(SwingConstants.VERTICAL, new Component[] {CbTecnico, txtCodSolicitud, CbCliente, CbCompu, CbSoftware, CbTSer, txtFechaR, txtFechaE, CbCondicion});
			thisLayout.linkSize(SwingConstants.HORIZONTAL, new Component[] {BtnCancelar, BtnAceptar});
			thisLayout.linkSize(SwingConstants.HORIZONTAL, new Component[] {CbTecnico, txtCodSolicitud, CbCliente, CbCompu, CbSoftware, CbTSer, txtFechaR, txtFechaE, CbCondicion});
			thisLayout.linkSize(SwingConstants.HORIZONTAL, new Component[] {eFechaE, eCondicion, eFechaEntrega, eTipoServ, eSoftware, eComputadora, eCliente, eCodSolicutud, eTecEncargado});
			pack();
			this.setSize(348, 412);
		} catch (Exception e) {
		    //add your error handling code here
			e.printStackTrace();
		}
	}
	
	private AbstractAction getFnBtnRegistrar() {
		if(FnBtnRegistrar == null) {
			FnBtnRegistrar = new AbstractAction("Registrar", null) {
				public void actionPerformed(ActionEvent evt) {
					if(validacion()){
						try {
							TreeMap tec=(TreeMap)tecnicos.get(CbTecnico.getSelectedIndex()-1);
							TreeMap ds=(TreeMap)duennos.get(CbCliente.getSelectedIndex()-1);
							TreeMap pc=(TreeMap)pcs.get(CbCompu.getSelectedIndex()-1);
							TreeMap softs=(TreeMap)soft.get(CbSoftware.getSelectedIndex()-1);
							gestor.agregarSolicitud(Integer.parseInt(txtCodSolicitud.getText()),(String) CbTSer.getSelectedItem(), txtFechaR.getText(), txtFechaE.getText(), (String)CbCondicion.getSelectedItem(),Integer.parseInt(""+tec.get("id")), Integer.parseInt(""+ds.get("id")), Integer.parseInt(""+pc.get("serie")), Integer.parseInt(""+softs.get("id")), gestor.consultarParametros().getDiasDemoraNormal(), gestor.consultarParametros().getDiasDemoraUrgente());
							JOptionPane.showMessageDialog(null,"Solicitud Registrada Satisfactoriamente.","Registrar Solicitud",JOptionPane.INFORMATION_MESSAGE);
							dispose();
						} catch (Exception e) {
							JOptionPane.showMessageDialog(null,(String) e.getMessage(),"Error",JOptionPane.ERROR_MESSAGE);
						}
					}
				}
			};
		}
		return FnBtnRegistrar;
	}
	
	private AbstractAction getFnBtnCancelar() {
		if(FnBtnCancelar == null) {
			FnBtnCancelar = new AbstractAction("Cancelar", null) {
				public void actionPerformed(ActionEvent evt) {
					dispose();
				}
			};
		}
		return FnBtnCancelar;
	}
	
	private AbstractAction getFnCbTipoSer() {
		if(FnCbTipoSer == null) {
			FnCbTipoSer = new AbstractAction("", null) {
				public void actionPerformed(ActionEvent evt) {
					JComboBox cb=(JComboBox)evt.getSource();
					String sel=(String)cb.getSelectedItem();
					tipoS=sel;
					try {
						Parametro p=gestor.consultarParametros();
						if(tipoS.equals("Normal")){
							setFechaE(p.getDiasDemoraNormal());
						}else{
							if(tipoS.equals("Urgente")){
								setFechaE(p.getDiasDemoraUrgente());
							}else{
								setFechaE(0);
							}
						}
					} catch (Exception e) {
						JOptionPane.showMessageDialog(null,(String) e.getMessage(),"Error",JOptionPane.ERROR_MESSAGE);
					}
					
				}
			};
		}
		return FnCbTipoSer;
	}
	private void setFechaE(int dias){
		if(dias!=0){
			cal.setTime(hoy);
			cal.add(Calendar.DATE, dias);
			ent=cal.getTime();
			entsql=new java.sql.Date(ent.getTime());
			txtFechaE.setText(""+entsql);
		}else{
			txtFechaE.setText("");
		}
	}
	
	private String[] obtenerTecnicos(){
		Vector v=null;
		String[] resul=null;
		TreeMap dato;
		try {
			v=gestor.tecnicoBuscarDisponible();
			tecnicos=v;
			resul=new String[v.size()+1];
			resul[0]="---Selccionar---";
			for(int i=0;i<v.size();i++){
				dato=(TreeMap) v.get(i);
				resul[i+1]=dato.get("id")+" - "+dato.get("nom")+" "+dato.get("apell");
			}
		} catch (Exception e) {
			JOptionPane.showMessageDialog(null,(String) e.getMessage(),"Error",JOptionPane.ERROR_MESSAGE);
		}
		return resul;
	}
	
	private String[] obtenerDuennos(){
		Vector v=null;
		String[] resul=null;
		TreeMap dato;
		try {
			v=gestor.clienteBuscarTodos();
			duennos=v;
			resul=new String[v.size()+1];
			resul[0]="---Selccionar---";
			for(int i=0;i<v.size();i++){
				dato=(TreeMap) v.get(i);
				resul[i+1]=dato.get("id")+" - "+dato.get("nom")+" "+dato.get("apell");
			}
		} catch (Exception e) {
			JOptionPane.showMessageDialog(null,(String) e.getMessage(),"Error",JOptionPane.ERROR_MESSAGE);
		}
		return resul;
	}
	
	private AbstractAction getFncbCliente() {
		if(FncbCliente == null) {
			FncbCliente = new AbstractAction("", null) {
				public void actionPerformed(ActionEvent evt) {
					JComboBox cb=(JComboBox)evt.getSource();
					String sel=(String)cb.getSelectedItem();
					clieS=sel;
					TreeMap d=(TreeMap)duennos.get(CbCliente.getSelectedIndex()-1);
					CbCompu.setModel(new DefaultComboBoxModel(obtenerPcs(Integer.parseInt(""+d.get("id")))));
				}
			};
		}
		return FncbCliente;
	}
	
	private String[] obtenerPcs(int cod){
		Vector v=null;
		String[] resul=null;
		TreeMap dato;
		try {
			v=gestor.consultarPcClienteS(cod);
			pcs=v;
			resul=new String[v.size()+1];
			resul[0]="---Selccionar---";
			for(int i=0;i<v.size();i++){
				dato=(TreeMap) v.get(i);
				resul[i+1]=dato.get("serie")+" - "+dato.get("modelo")+" "+dato.get("marca");
			}
		} catch (Exception e) {
			JOptionPane.showMessageDialog(null,(String) e.getMessage(),"Error",JOptionPane.ERROR_MESSAGE);
		}
		return resul;
	}
	
	private String[] obtenerSoft(){
		Vector v=null;
		String[] resul=null;
		TreeMap dato;
		try {
			v=gestor.consultarSoftwareSinInst();
			soft=v;
			resul=new String[v.size()+1];
			resul[0]="---Selccionar---";
			for(int i=0;i<v.size();i++){
				dato=(TreeMap) v.get(i);
				resul[i+1]=""+dato.get("nom");
			}
		} catch (Exception e) {
			//JOptionPane.showMessageDialog(null,(String) e.getMessage(),"Error",JOptionPane.ERROR_MESSAGE);
			resul=new String[] { "---Seleccionar---"};
		}
		return resul;
	}
	
	private boolean validacion(){
		if(CbTecnico.getSelectedItem().equals("---Selccionar---")){
			JOptionPane.showMessageDialog(null,"Seleccione un Técnico","Error",JOptionPane.ERROR_MESSAGE);
			return false;
		}else{
			if(txtCodSolicitud.getText().equals("")){
				JOptionPane.showMessageDialog(null,"Introduzca un Código","Error",JOptionPane.ERROR_MESSAGE);
				return false;
			}else{
				if(CbCliente.getSelectedItem().equals("---Selccionar---")){
					JOptionPane.showMessageDialog(null,"Seleccione un Cliente","Error",JOptionPane.ERROR_MESSAGE);
					return false;
				}else{
					if(CbCompu.getSelectedItem().equals("---Selccionar---")){
						JOptionPane.showMessageDialog(null,"Seleccione una Computadora","Error",JOptionPane.ERROR_MESSAGE);
						return false;
					}else{
						if(CbSoftware.getSelectedItem().equals("---Selccionar---")){
							JOptionPane.showMessageDialog(null,"Seleccione un Software","Error",JOptionPane.ERROR_MESSAGE);
							return false;
						}else{
							if(CbTSer.getSelectedItem().equals("---Seleccionar---")){
								JOptionPane.showMessageDialog(null,"Seleccione un Tipo de Servicio","Error",JOptionPane.ERROR_MESSAGE);
								return false;
							}
						}
					}
				}
			}
		}
		return true;
	}
}
