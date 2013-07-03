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
public class PantallaSoftwareRegistrar extends javax.swing.JFrame {

	{
		//Set Look & Feel
		try {
			javax.swing.UIManager.setLookAndFeel(javax.swing.UIManager.getSystemLookAndFeelClassName());
		} catch(Exception e) {
			e.printStackTrace();
		}
	}

	private JLabel txtNombreProducto;
	private JLabel eDesc;
	private JComboBox jbSO;
	private JButton BtnReg;
	private JTextField txtVP;
	private JTextField txtHD;
	private JTextField txtRam;
	private JTextField txtDesc;
	private JTextField txtNombreP;
	private JLabel eSO;
	private JLabel eVeP;
	private JLabel eEspL;
	private JTextField txtCod;
	private JLabel eCodigo;
	private AbstractAction FnBtnRegistrar;
	private AbstractAction FnBtnCancelar;
	private JButton btnCancelar;
	private JLabel eMRamRequerida;
	private Vector sOs;
	private Gestor gestor=new Gestor();

	/**
	* Auto-generated main method to display this JFrame
	*/
	public static void main(String[] args) {
		SwingUtilities.invokeLater(new Runnable() {
			public void run() {
				PantallaSoftwareRegistrar inst = new PantallaSoftwareRegistrar();
				inst.setLocationRelativeTo(null);
				inst.setVisible(true);
			}
		});
	}
	
	public PantallaSoftwareRegistrar() {
		super();
		initGUI();
	}
	
	private void initGUI() {
		try {
			GroupLayout thisLayout = new GroupLayout((JComponent)getContentPane());
			getContentPane().setLayout(thisLayout);
			setDefaultCloseOperation(WindowConstants.DISPOSE_ON_CLOSE);
			this.setTitle("Registrar Software - Software Seguro");
			{
				txtNombreProducto = new JLabel();
				txtNombreProducto.setText("Nombre del Prooducto:");
			}
			{
				eDesc = new JLabel();
				eDesc.setText("Descripción:");
			}
			{
				eMRamRequerida = new JLabel();
				eMRamRequerida.setText("Memoria RAM Requerida: ");
			}
			{
				eEspL = new JLabel();
				eEspL.setText("Espacio Libre Requerido: ");
			}
			{
				eVeP = new JLabel();
				eVeP.setText("Velocidad de Procesador:");
			}
			{
				eSO = new JLabel();
				eSO.setText("Sistema Operativo:");
			}
			{
				txtNombreP = new JTextField();
			}
			{
				txtDesc = new JTextField();
			}
			{
				txtRam = new JTextField();
			}
			{
				txtHD = new JTextField();
			}
			{
				txtVP = new JTextField();
			}
			{
				ComboBoxModel jbSOModel = 
						new DefaultComboBoxModel(
								obtenerSOs()
								);				
				jbSO = new JComboBox();
				jbSO.setModel(jbSOModel);
			}
			{
				BtnReg = new JButton();
				BtnReg.setText("Registrar");
				BtnReg.setAction(getFnBtnRegistrar());
			}
			{
				btnCancelar = new JButton();
				btnCancelar.setText("Cancelar");
				btnCancelar.setAction(getFnBtnCancelar());
			}
			thisLayout.setVerticalGroup(thisLayout.createSequentialGroup()
				.addContainerGap()
				.addGroup(thisLayout.createParallelGroup(GroupLayout.Alignment.BASELINE)
				    .addComponent(getTxtCod(), GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE)
				    .addComponent(getECodigo(), GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE))
				.addPreferredGap(LayoutStyle.ComponentPlacement.RELATED, 0, GroupLayout.PREFERRED_SIZE)
				.addGroup(thisLayout.createParallelGroup(GroupLayout.Alignment.BASELINE)
				    .addComponent(txtNombreP, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE)
				    .addComponent(txtNombreProducto, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE))
				.addPreferredGap(LayoutStyle.ComponentPlacement.RELATED, 0, GroupLayout.PREFERRED_SIZE)
				.addGroup(thisLayout.createParallelGroup(GroupLayout.Alignment.BASELINE)
				    .addComponent(txtDesc, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE)
				    .addComponent(eDesc, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE))
				.addPreferredGap(LayoutStyle.ComponentPlacement.RELATED)
				.addGroup(thisLayout.createParallelGroup(GroupLayout.Alignment.BASELINE)
				    .addComponent(txtRam, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE)
				    .addComponent(eMRamRequerida, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE))
				.addPreferredGap(LayoutStyle.ComponentPlacement.RELATED)
				.addGroup(thisLayout.createParallelGroup(GroupLayout.Alignment.BASELINE)
				    .addComponent(txtHD, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE)
				    .addComponent(eEspL, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE))
				.addPreferredGap(LayoutStyle.ComponentPlacement.RELATED)
				.addGroup(thisLayout.createParallelGroup(GroupLayout.Alignment.BASELINE)
				    .addComponent(txtVP, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE)
				    .addComponent(eVeP, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE))
				.addPreferredGap(LayoutStyle.ComponentPlacement.RELATED)
				.addGroup(thisLayout.createParallelGroup(GroupLayout.Alignment.BASELINE)
				    .addComponent(jbSO, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE)
				    .addComponent(eSO, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE))
				.addGap(29)
				.addGroup(thisLayout.createParallelGroup(GroupLayout.Alignment.BASELINE)
				    .addComponent(btnCancelar, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE)
				    .addComponent(BtnReg, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE))
				.addContainerGap(20, 20));
			thisLayout.setHorizontalGroup(thisLayout.createSequentialGroup()
				.addContainerGap()
				.addGroup(thisLayout.createParallelGroup()
				    .addGroup(GroupLayout.Alignment.LEADING, thisLayout.createSequentialGroup()
				        .addComponent(getECodigo(), GroupLayout.PREFERRED_SIZE, 167, GroupLayout.PREFERRED_SIZE)
				        .addGap(19))
				    .addComponent(eSO, GroupLayout.Alignment.LEADING, GroupLayout.PREFERRED_SIZE, 185, GroupLayout.PREFERRED_SIZE)
				    .addComponent(eVeP, GroupLayout.Alignment.LEADING, GroupLayout.PREFERRED_SIZE, 185, GroupLayout.PREFERRED_SIZE)
				    .addComponent(eEspL, GroupLayout.Alignment.LEADING, GroupLayout.PREFERRED_SIZE, 185, GroupLayout.PREFERRED_SIZE)
				    .addComponent(eMRamRequerida, GroupLayout.Alignment.LEADING, GroupLayout.PREFERRED_SIZE, 185, GroupLayout.PREFERRED_SIZE)
				    .addComponent(eDesc, GroupLayout.Alignment.LEADING, GroupLayout.PREFERRED_SIZE, 185, GroupLayout.PREFERRED_SIZE)
				    .addComponent(txtNombreProducto, GroupLayout.Alignment.LEADING, GroupLayout.PREFERRED_SIZE, 185, GroupLayout.PREFERRED_SIZE)
				    .addGroup(GroupLayout.Alignment.LEADING, thisLayout.createSequentialGroup()
				        .addGap(80)
				        .addComponent(BtnReg, GroupLayout.PREFERRED_SIZE, 86, GroupLayout.PREFERRED_SIZE)
				        .addGap(19)))
				.addGap(20)
				.addGroup(thisLayout.createParallelGroup()
				    .addGroup(GroupLayout.Alignment.LEADING, thisLayout.createSequentialGroup()
				        .addComponent(btnCancelar, GroupLayout.PREFERRED_SIZE, 86, GroupLayout.PREFERRED_SIZE)
				        .addGap(0, 77, Short.MAX_VALUE))
				    .addGroup(thisLayout.createSequentialGroup()
				        .addPreferredGap(btnCancelar, getTxtCod(), LayoutStyle.ComponentPlacement.INDENT)
				        .addGroup(thisLayout.createParallelGroup()
				            .addGroup(thisLayout.createSequentialGroup()
				                .addComponent(getTxtCod(), GroupLayout.PREFERRED_SIZE, 152, GroupLayout.PREFERRED_SIZE)
				                .addGap(0, 0, Short.MAX_VALUE))
				            .addGroup(thisLayout.createSequentialGroup()
				                .addComponent(txtDesc, GroupLayout.PREFERRED_SIZE, 152, GroupLayout.PREFERRED_SIZE)
				                .addGap(0, 0, Short.MAX_VALUE))
				            .addGroup(thisLayout.createSequentialGroup()
				                .addComponent(txtRam, GroupLayout.PREFERRED_SIZE, 152, GroupLayout.PREFERRED_SIZE)
				                .addGap(0, 0, Short.MAX_VALUE))
				            .addGroup(thisLayout.createSequentialGroup()
				                .addComponent(txtHD, GroupLayout.PREFERRED_SIZE, 152, GroupLayout.PREFERRED_SIZE)
				                .addGap(0, 0, Short.MAX_VALUE))
				            .addGroup(thisLayout.createSequentialGroup()
				                .addComponent(txtVP, GroupLayout.PREFERRED_SIZE, 152, GroupLayout.PREFERRED_SIZE)
				                .addGap(0, 0, Short.MAX_VALUE))
				            .addGroup(GroupLayout.Alignment.LEADING, thisLayout.createSequentialGroup()
				                .addGap(0, 0, Short.MAX_VALUE)
				                .addComponent(jbSO, GroupLayout.PREFERRED_SIZE, 152, GroupLayout.PREFERRED_SIZE))
				            .addComponent(txtNombreP, GroupLayout.Alignment.LEADING, 0, 152, Short.MAX_VALUE))))
				.addContainerGap());
			thisLayout.linkSize(SwingConstants.VERTICAL, new Component[] {txtNombreProducto, eDesc, eMRamRequerida, eEspL, eVeP, eSO});
			thisLayout.linkSize(SwingConstants.HORIZONTAL, new Component[] {txtNombreProducto, eDesc, eMRamRequerida, eEspL, eVeP, eSO});
			thisLayout.linkSize(SwingConstants.HORIZONTAL, new Component[] {btnCancelar, BtnReg});
			thisLayout.linkSize(SwingConstants.HORIZONTAL, new Component[] {getTxtCod(), txtNombreP, txtDesc, txtRam, txtHD, txtVP});
			pack();
			this.setSize(411, 328);
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
							TreeMap ds=(TreeMap)sOs.get(jbSO.getSelectedIndex()-1);
							gestor.agregarSoftware(Integer.parseInt(txtCod.getText()), txtNombreP.getText(), txtDesc.getText(), txtRam.getText(), txtHD.getText(), txtVP.getText(), Integer.parseInt(""+ds.get("id")));
							JOptionPane.showMessageDialog(null,"Software Registrado Satisfactoriamente.","Registrar Software",JOptionPane.INFORMATION_MESSAGE);
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
		if(txtCod.getText().equals("")){
			JOptionPane.showMessageDialog(null,"Introduzca el Código","Error",JOptionPane.ERROR_MESSAGE);
			return false;
		}else{
			if(txtNombreP.getText().equals("")){
				JOptionPane.showMessageDialog(null,"Introduzca el Nombre","Error",JOptionPane.ERROR_MESSAGE);
				return false;
			}else{
				if(txtDesc.getText().equals("")){
					JOptionPane.showMessageDialog(null,"Introduzca la Descripción","Error",JOptionPane.ERROR_MESSAGE);
					return false;
				}else{
					if(txtRam.getText().equals("")){
						JOptionPane.showMessageDialog(null,"Introduzca la Memoria RAM Requirida","Error",JOptionPane.ERROR_MESSAGE);
						return false;
					}else{
						if(txtHD.getText().equals("")){
							JOptionPane.showMessageDialog(null,"Introduzca el Espacio Libre Requerido","Error",JOptionPane.ERROR_MESSAGE);
							return false;
						}else{
							if(txtVP.getText().equals("")){
								JOptionPane.showMessageDialog(null,"Introduzca la Velocidad del Procesador Requerido","Error",JOptionPane.ERROR_MESSAGE);
								return false;
							}else{
								if(jbSO.getSelectedItem().equals("---Selccionar---")){
									JOptionPane.showMessageDialog(null,"Seleccione el Sistema Operativo Requerido","Error",JOptionPane.ERROR_MESSAGE);
									return false;
								}
							}
						}
					}
				}
			}
		}
		return true;
	}
	
	private JLabel getECodigo() {
		if(eCodigo == null) {
			eCodigo = new JLabel();
			eCodigo.setText("Código: ");
		}
		return eCodigo;
	}
	
	private JTextField getTxtCod() {
		if(txtCod == null) {
			txtCod = new JTextField();
		}
		return txtCod;
	}

}
