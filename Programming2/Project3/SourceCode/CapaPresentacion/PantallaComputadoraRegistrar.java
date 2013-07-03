package CapaPresentacion;
import java.awt.Component;
import java.awt.event.ActionEvent;
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
public class PantallaComputadoraRegistrar extends javax.swing.JFrame {

	{
		//Set Look & Feel
		try {
			javax.swing.UIManager.setLookAndFeel(javax.swing.UIManager.getSystemLookAndFeelClassName());
		} catch(Exception e) {
			e.printStackTrace();
		}
	}

	private JLabel eNúmerodeSerie;
	private JLabel eModelo;
	private JLabel eVelPc;
	private AbstractAction fnBtnCancelar;
	private AbstractAction FnBtnRegistrar;
	private JButton BtnCancelar;
	private JButton btnRegistrar;
	private JTextField txtEspaciHD;
	private JTextField txtMRam;
	private JTextField txtVP;
	private JComboBox JbSO;
	private JComboBox jbDuenno;
	private JTextField txtMarca;
	private JTextField txtModelo;
	private JTextField txtNumSerie;
	private JLabel eEspacio;
	private JLabel eMRam;
	private JLabel eSO;
	private JLabel eDueño;
	private JLabel eMarca;
	private Vector duennos;
	private Vector sOs;
	private Gestor gestor=new Gestor();

	/**
	* Auto-generated main method to display this JFrame
	*/
	public static void main(String[] args) {
		SwingUtilities.invokeLater(new Runnable() {
			public void run() {
				PantallaComputadoraRegistrar inst = new PantallaComputadoraRegistrar();
				inst.setLocationRelativeTo(null);
				inst.setVisible(true);
			}
		});
	}
	
	public PantallaComputadoraRegistrar() {
		super();
		initGUI();
	}
	
	private void initGUI() {
		try {
			GroupLayout thisLayout = new GroupLayout((JComponent)getContentPane());
			getContentPane().setLayout(thisLayout);
			setDefaultCloseOperation(WindowConstants.DISPOSE_ON_CLOSE);
			this.setTitle("Registrar Computadora - Software Seguro");
			{
				eNúmerodeSerie = new JLabel();
				eNúmerodeSerie.setText("Número de Serie:");
			}
			{
				eModelo = new JLabel();
				eModelo.setText("Modelo: ");
			}
			{
				eMarca = new JLabel();
				eMarca.setText("Marca: ");
			}
			{
				eDueño = new JLabel();
				eDueño.setText("Dueño: ");
			}
			{
				eSO = new JLabel();
				eSO.setText("Sistema Operativo:");
			}
			{
				eVelPc = new JLabel();
				eVelPc.setText("Velocidad del Procesador:");
			}
			{
				eMRam = new JLabel();
				eMRam.setText("Memoria RAM: ");
			}
			{
				eEspacio = new JLabel();
				eEspacio.setText("Espacion Libre HD:");
			}
			{
				txtNumSerie = new JTextField();
			}
			{
				txtModelo = new JTextField();
			}
			{
				txtMarca = new JTextField();
			}
			{
				ComboBoxModel jbDuennoModel = 
						new DefaultComboBoxModel(
								obtenerDuennos()
								);
				jbDuenno = new JComboBox();
				jbDuenno.setModel(jbDuennoModel);
			}
			{
				ComboBoxModel JbSOModel = 
						new DefaultComboBoxModel(
								obtenerSOs());
				JbSO = new JComboBox();
				JbSO.setModel(JbSOModel);
			}
			{
				txtVP = new JTextField();
			}
			{
				txtMRam = new JTextField();
			}
			{
				txtEspaciHD = new JTextField();
			}
			{
				btnRegistrar = new JButton();
				btnRegistrar.setText("Registrar");
				btnRegistrar.setAction(getFnBtnRegistrar());
			}
			{
				BtnCancelar = new JButton();
				BtnCancelar.setText("Cancelar");
				BtnCancelar.setAction(getFnBtnCancelar());
			}
			thisLayout.setVerticalGroup(thisLayout.createSequentialGroup()
				.addContainerGap()
				.addGroup(thisLayout.createParallelGroup(GroupLayout.Alignment.BASELINE)
				    .addComponent(txtNumSerie, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE)
				    .addComponent(eNúmerodeSerie, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE))
				.addPreferredGap(LayoutStyle.ComponentPlacement.RELATED)
				.addGroup(thisLayout.createParallelGroup(GroupLayout.Alignment.BASELINE)
				    .addComponent(txtModelo, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE)
				    .addComponent(eModelo, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE))
				.addPreferredGap(LayoutStyle.ComponentPlacement.RELATED)
				.addGroup(thisLayout.createParallelGroup(GroupLayout.Alignment.BASELINE)
				    .addComponent(txtMarca, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE)
				    .addComponent(eMarca, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE))
				.addPreferredGap(LayoutStyle.ComponentPlacement.RELATED)
				.addGroup(thisLayout.createParallelGroup(GroupLayout.Alignment.BASELINE)
				    .addComponent(jbDuenno, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE)
				    .addComponent(eDueño, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE))
				.addPreferredGap(LayoutStyle.ComponentPlacement.RELATED)
				.addGroup(thisLayout.createParallelGroup(GroupLayout.Alignment.BASELINE)
				    .addComponent(JbSO, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE)
				    .addComponent(eSO, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE))
				.addPreferredGap(LayoutStyle.ComponentPlacement.UNRELATED)
				.addGroup(thisLayout.createParallelGroup(GroupLayout.Alignment.BASELINE)
				    .addComponent(txtVP, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE)
				    .addComponent(eVelPc, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, 21, GroupLayout.PREFERRED_SIZE))
				.addPreferredGap(LayoutStyle.ComponentPlacement.RELATED)
				.addGroup(thisLayout.createParallelGroup(GroupLayout.Alignment.BASELINE)
				    .addComponent(txtMRam, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE)
				    .addComponent(eMRam, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE))
				.addPreferredGap(LayoutStyle.ComponentPlacement.RELATED)
				.addGroup(thisLayout.createParallelGroup(GroupLayout.Alignment.BASELINE)
				    .addComponent(txtEspaciHD, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE)
				    .addComponent(eEspacio, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE))
				.addPreferredGap(LayoutStyle.ComponentPlacement.UNRELATED)
				.addGroup(thisLayout.createParallelGroup(GroupLayout.Alignment.BASELINE)
				    .addComponent(BtnCancelar, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE)
				    .addComponent(btnRegistrar, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE))
				.addContainerGap());
			thisLayout.setHorizontalGroup(thisLayout.createSequentialGroup()
				.addContainerGap()
				.addGroup(thisLayout.createParallelGroup()
				    .addComponent(eEspacio, GroupLayout.Alignment.LEADING, GroupLayout.PREFERRED_SIZE, 168, GroupLayout.PREFERRED_SIZE)
				    .addComponent(eMRam, GroupLayout.Alignment.LEADING, GroupLayout.PREFERRED_SIZE, 168, GroupLayout.PREFERRED_SIZE)
				    .addComponent(eVelPc, GroupLayout.Alignment.LEADING, GroupLayout.PREFERRED_SIZE, 168, GroupLayout.PREFERRED_SIZE)
				    .addComponent(eSO, GroupLayout.Alignment.LEADING, GroupLayout.PREFERRED_SIZE, 168, GroupLayout.PREFERRED_SIZE)
				    .addComponent(eDueño, GroupLayout.Alignment.LEADING, GroupLayout.PREFERRED_SIZE, 168, GroupLayout.PREFERRED_SIZE)
				    .addComponent(eMarca, GroupLayout.Alignment.LEADING, GroupLayout.PREFERRED_SIZE, 168, GroupLayout.PREFERRED_SIZE)
				    .addComponent(eModelo, GroupLayout.Alignment.LEADING, GroupLayout.PREFERRED_SIZE, 168, GroupLayout.PREFERRED_SIZE)
				    .addComponent(eNúmerodeSerie, GroupLayout.Alignment.LEADING, GroupLayout.PREFERRED_SIZE, 168, GroupLayout.PREFERRED_SIZE)
				    .addGroup(GroupLayout.Alignment.LEADING, thisLayout.createSequentialGroup()
				        .addGap(71)
				        .addComponent(btnRegistrar, GroupLayout.PREFERRED_SIZE, 91, GroupLayout.PREFERRED_SIZE)
				        .addGap(6)))
				.addGap(16)
				.addGroup(thisLayout.createParallelGroup()
				    .addGroup(GroupLayout.Alignment.LEADING, thisLayout.createSequentialGroup()
				        .addComponent(BtnCancelar, GroupLayout.PREFERRED_SIZE, 91, GroupLayout.PREFERRED_SIZE)
				        .addGap(0, 83, Short.MAX_VALUE))
				    .addGroup(thisLayout.createSequentialGroup()
				        .addGap(27)
				        .addGroup(thisLayout.createParallelGroup()
				            .addGroup(GroupLayout.Alignment.LEADING, thisLayout.createSequentialGroup()
				                .addComponent(txtEspaciHD, GroupLayout.PREFERRED_SIZE, 147, GroupLayout.PREFERRED_SIZE)
				                .addGap(0, 0, Short.MAX_VALUE))
				            .addGroup(thisLayout.createSequentialGroup()
				                .addComponent(txtMRam, GroupLayout.PREFERRED_SIZE, 147, GroupLayout.PREFERRED_SIZE)
				                .addGap(0, 0, Short.MAX_VALUE))
				            .addGroup(thisLayout.createSequentialGroup()
				                .addComponent(txtVP, GroupLayout.PREFERRED_SIZE, 147, GroupLayout.PREFERRED_SIZE)
				                .addGap(0, 0, Short.MAX_VALUE))
				            .addGroup(thisLayout.createSequentialGroup()
				                .addComponent(JbSO, GroupLayout.PREFERRED_SIZE, 147, GroupLayout.PREFERRED_SIZE)
				                .addGap(0, 0, Short.MAX_VALUE))
				            .addGroup(thisLayout.createSequentialGroup()
				                .addComponent(jbDuenno, GroupLayout.PREFERRED_SIZE, 147, GroupLayout.PREFERRED_SIZE)
				                .addGap(0, 0, Short.MAX_VALUE))
				            .addGroup(thisLayout.createSequentialGroup()
				                .addComponent(txtMarca, GroupLayout.PREFERRED_SIZE, 147, GroupLayout.PREFERRED_SIZE)
				                .addGap(0, 0, Short.MAX_VALUE))
				            .addGroup(thisLayout.createSequentialGroup()
				                .addComponent(txtModelo, GroupLayout.PREFERRED_SIZE, 147, GroupLayout.PREFERRED_SIZE)
				                .addGap(0, 0, Short.MAX_VALUE))
				            .addComponent(txtNumSerie, GroupLayout.Alignment.LEADING, 0, 147, Short.MAX_VALUE))))
				.addContainerGap());
			thisLayout.linkSize(SwingConstants.VERTICAL, new Component[] {txtNumSerie, txtModelo, txtMarca, jbDuenno, JbSO, txtVP, txtMRam, txtEspaciHD});
			thisLayout.linkSize(SwingConstants.VERTICAL, new Component[] {BtnCancelar, btnRegistrar});
			thisLayout.linkSize(SwingConstants.HORIZONTAL, new Component[] {eVelPc, eNúmerodeSerie, eModelo, eMarca, eDueño, eSO, eMRam, eEspacio});
			thisLayout.linkSize(SwingConstants.HORIZONTAL, new Component[] {txtNumSerie, txtModelo, txtMarca, jbDuenno, JbSO, txtVP, txtMRam, txtEspaciHD});
			thisLayout.linkSize(SwingConstants.HORIZONTAL, new Component[] {BtnCancelar, btnRegistrar});
			pack();
			this.setSize(400, 340);
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
							TreeMap d=(TreeMap)duennos.get(jbDuenno.getSelectedIndex()-1);
							TreeMap ds=(TreeMap)sOs.get(JbSO.getSelectedIndex()-1);
							gestor.agregarComputadora(Integer.parseInt(txtNumSerie.getText()), txtModelo.getText(), txtMarca.getText(), txtVP.getText(), txtMRam.getText(), txtEspaciHD.getText(),Integer.parseInt(""+d.get("id")),Integer.parseInt(""+ds.get("id")));
							JOptionPane.showMessageDialog(null,"Computadora Registrado Satisfactoriamente.","Registrar Computadora",JOptionPane.INFORMATION_MESSAGE);
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
		if(fnBtnCancelar == null) {
			fnBtnCancelar = new AbstractAction("Cancelar", null) {
				public void actionPerformed(ActionEvent evt) {
					dispose();
				}
			};
		}
		return fnBtnCancelar;
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
	
	private String[] obtenerSOs() throws Exception{
		Vector v=null;
		String[] resul=null;
		TreeMap dato;
		try {
			v=gestor.sOBuscarTodos();
			sOs=v;
			resul=new String[v.size()+1];
			resul[0]="---Selccionar---";
			for(int i=0;i<v.size();i++){
				dato=(TreeMap) v.get(i);
				resul[i+1]=dato.get("id")+" - "+dato.get("nom")+" - "+dato.get("vers");
			}
		} catch (Exception e) {
			JOptionPane.showMessageDialog(null,(String) e.getMessage(),"Error",JOptionPane.ERROR_MESSAGE);
		}
		return resul;
	}
	
	private boolean validacion(){
		if(txtNumSerie.getText().equals("")){
			JOptionPane.showMessageDialog(null,"Introduzca el Número de Serie","Error",JOptionPane.ERROR_MESSAGE);
			return false;
		}else{
			if(txtModelo.getText().equals("")){
				JOptionPane.showMessageDialog(null,"Introduzca el Modelo","Error",JOptionPane.ERROR_MESSAGE);
				return false;
			}else{
				if(txtMarca.getText().equals("")){
					JOptionPane.showMessageDialog(null,"Introduzca la Marca","Error",JOptionPane.ERROR_MESSAGE);
					return false;
				}else{
					if(jbDuenno.getSelectedItem().equals("---Selccionar---")){
						JOptionPane.showMessageDialog(null,"Seleccione un Dueño","Error",JOptionPane.ERROR_MESSAGE);
						return false;
					}else{
						if(JbSO.getSelectedItem().equals("---Selccionar---")){
							JOptionPane.showMessageDialog(null,"Seleccione un Sistema Operativo","Error",JOptionPane.ERROR_MESSAGE);
							return false;
						}else{
							if(txtVP.getText().equals("")){
								JOptionPane.showMessageDialog(null,"Introduzca la Velocidad del Procesador","Error",JOptionPane.ERROR_MESSAGE);
								return false;
							}else{
								if(txtMRam.getText().equals("")){
									JOptionPane.showMessageDialog(null,"Introduzca la Memoria RAM","Error",JOptionPane.ERROR_MESSAGE);
									return false;
								}else{
									if(txtEspaciHD.getText().equals("")){
										JOptionPane.showMessageDialog(null,"Introduzca el Espacio Libre del HD","Error",JOptionPane.ERROR_MESSAGE);
										return false;
									}
								}
							}
						}
					}
				}
			}
		}
		return true;
	}

}
