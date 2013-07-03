package CapaPresentacion;
import java.awt.Component;
import java.awt.event.ActionEvent;
import java.sql.Date;
import java.text.SimpleDateFormat;
import java.util.Calendar;

import javax.swing.AbstractAction;
import javax.swing.GroupLayout;
import javax.swing.JButton;
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
public class PantallaIntalacionActualizacion extends javax.swing.JFrame {
	private JLabel eCodSoft;
	private AbstractAction fnBtnAceptar;
	private JLabel eLicencia;
	private JButton btnAceptar;
	private JButton btnCancelar;
	private JTextField txtFechaE;
	private JTextField txtFechaI;
	private JTextField txtLic;
	private JTextField txtCod;
	private AbstractAction fnBtnCancelar;
	private JLabel eFechaExpi;
	private JLabel eFechaInsta;
	private static int cod;
	private static int codSoli;
	private java.util.Date hoy=new java.util.Date();
	private java.sql.Date hoysql=new java.sql.Date(hoy.getTime());
	private Gestor gestor= new Gestor();

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
				PantallaIntalacionActualizacion inst = new PantallaIntalacionActualizacion(cod,codSoli);
				inst.setLocationRelativeTo(null);
				inst.setVisible(true);
			}
		});
	}
	
	public PantallaIntalacionActualizacion(int cod, int codS) {
		super();
		this.cod=cod;
		this.codSoli=codS;
		initGUI();
	}
	
	private void initGUI() {
		try {
			GroupLayout thisLayout = new GroupLayout((JComponent)getContentPane());
			getContentPane().setLayout(thisLayout);
			setDefaultCloseOperation(WindowConstants.DISPOSE_ON_CLOSE);
			{
				eCodSoft = new JLabel();
				eCodSoft.setText("Codigo del Software: ");
			}
			{
				eLicencia = new JLabel();
				eLicencia.setText("Licencia: ");
			}
			{
				eFechaInsta = new JLabel();
				eFechaInsta.setText("Fecha de Instalación: ");
			}
			{
				eFechaExpi = new JLabel();
				eFechaExpi.setText("Fecha de Expiración:");
			}
			{
				btnAceptar = new JButton();
				btnAceptar.setText("Aceptar");
				btnAceptar.setAction(getFnBtnAceptar());
			}
			{
				btnCancelar = new JButton();
				btnCancelar.setText("Cancelar");
				btnCancelar.setAction(getFnBtnCancelar());
			}
			thisLayout.setHorizontalGroup(thisLayout.createSequentialGroup()
				.addContainerGap()
				.addGroup(thisLayout.createParallelGroup()
				    .addGroup(GroupLayout.Alignment.LEADING, thisLayout.createSequentialGroup()
				        .addComponent(eCodSoft, GroupLayout.PREFERRED_SIZE, 143, GroupLayout.PREFERRED_SIZE)
				        .addGap(23))
				    .addGroup(GroupLayout.Alignment.LEADING, thisLayout.createSequentialGroup()
				        .addComponent(eLicencia, GroupLayout.PREFERRED_SIZE, 143, GroupLayout.PREFERRED_SIZE)
				        .addGap(23))
				    .addGroup(GroupLayout.Alignment.LEADING, thisLayout.createSequentialGroup()
				        .addComponent(eFechaInsta, GroupLayout.PREFERRED_SIZE, 143, GroupLayout.PREFERRED_SIZE)
				        .addGap(23))
				    .addGroup(GroupLayout.Alignment.LEADING, thisLayout.createSequentialGroup()
				        .addComponent(eFechaExpi, GroupLayout.PREFERRED_SIZE, 143, GroupLayout.PREFERRED_SIZE)
				        .addGap(23))
				    .addGroup(GroupLayout.Alignment.LEADING, thisLayout.createSequentialGroup()
				        .addGap(77)
				        .addComponent(btnAceptar, GroupLayout.PREFERRED_SIZE, 89, GroupLayout.PREFERRED_SIZE)))
				.addGap(20)
				.addGroup(thisLayout.createParallelGroup()
				    .addGroup(GroupLayout.Alignment.LEADING, thisLayout.createSequentialGroup()
				        .addComponent(btnCancelar, GroupLayout.PREFERRED_SIZE, 89, GroupLayout.PREFERRED_SIZE)
				        .addGap(0, 83, Short.MAX_VALUE))
				    .addComponent(getTxtCod(), GroupLayout.Alignment.LEADING, 0, 172, Short.MAX_VALUE)
				    .addGroup(GroupLayout.Alignment.LEADING, thisLayout.createSequentialGroup()
				        .addComponent(getTxtLic(), GroupLayout.PREFERRED_SIZE, 69, GroupLayout.PREFERRED_SIZE)
				        .addGap(0, 103, Short.MAX_VALUE))
				    .addGroup(GroupLayout.Alignment.LEADING, thisLayout.createSequentialGroup()
				        .addComponent(getTxtFechaI(), GroupLayout.PREFERRED_SIZE, 69, GroupLayout.PREFERRED_SIZE)
				        .addGap(0, 103, Short.MAX_VALUE))
				    .addGroup(GroupLayout.Alignment.LEADING, thisLayout.createSequentialGroup()
				        .addComponent(getTxtFechaE(), GroupLayout.PREFERRED_SIZE, 69, GroupLayout.PREFERRED_SIZE)
				        .addGap(0, 103, Short.MAX_VALUE)))
				.addContainerGap());
			thisLayout.setVerticalGroup(thisLayout.createSequentialGroup()
				.addContainerGap()
				.addGroup(thisLayout.createParallelGroup(GroupLayout.Alignment.BASELINE)
				    .addComponent(getTxtCod(), GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, 22, GroupLayout.PREFERRED_SIZE)
				    .addComponent(eCodSoft, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE))
				.addGap(19)
				.addGroup(thisLayout.createParallelGroup(GroupLayout.Alignment.BASELINE)
				    .addComponent(getTxtLic(), GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE)
				    .addComponent(eLicencia, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE))
				.addGap(20)
				.addGroup(thisLayout.createParallelGroup(GroupLayout.Alignment.BASELINE)
				    .addComponent(getTxtFechaI(), GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE)
				    .addComponent(eFechaInsta, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE))
				.addGap(0, 24, Short.MAX_VALUE)
				.addGroup(thisLayout.createParallelGroup(GroupLayout.Alignment.BASELINE)
				    .addComponent(getTxtFechaE(), GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE)
				    .addComponent(eFechaExpi, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE))
				.addPreferredGap(LayoutStyle.ComponentPlacement.UNRELATED, 1, GroupLayout.PREFERRED_SIZE)
				.addGroup(thisLayout.createParallelGroup(GroupLayout.Alignment.BASELINE)
				    .addComponent(btnAceptar, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE)
				    .addComponent(btnCancelar, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE))
				.addContainerGap());
			thisLayout.linkSize(SwingConstants.HORIZONTAL, new Component[] {getTxtCod(), getTxtLic(), getTxtFechaI(), getTxtFechaE()});
			thisLayout.linkSize(SwingConstants.HORIZONTAL, new Component[] {eFechaExpi, eCodSoft, eLicencia, eFechaInsta});
			thisLayout.linkSize(SwingConstants.HORIZONTAL, new Component[] {btnCancelar, btnAceptar});
			pack();
			this.setSize(400, 260);
		} catch (Exception e) {
		    //add your error handling code here
			e.printStackTrace();
		}
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
	
	private JTextField getTxtCod() {
		if(txtCod == null) {
			txtCod = new JTextField();
			txtCod.setEnabled(false);
			txtCod.setText(""+cod);
		}
		return txtCod;
	}
	
	private JTextField getTxtLic() {
		if(txtLic == null) {
			txtLic = new JTextField();
		}
		return txtLic;
	}
	
	private JTextField getTxtFechaI() {
		if(txtFechaI == null) {
			txtFechaI = new JTextField();
			txtFechaI.setText(""+hoysql);
			txtFechaI.setEnabled(false);
		}
		return txtFechaI;
	}
	
	private JTextField getTxtFechaE() {
		if(txtFechaE == null) {
			txtFechaE = new JTextField();
			txtFechaE.setText("yyyy-mm-dd");
		}
		return txtFechaE;
	}
	
	private AbstractAction getFnBtnAceptar() {
		if(fnBtnAceptar == null) {
			fnBtnAceptar = new AbstractAction("Aceptar", null) {
				public void actionPerformed(ActionEvent evt) {
					if(validacion()){
						try {
							Date expsql;
							if(!txtFechaE.getText().equals("")){
								java.util.Date exp;
								SimpleDateFormat f=new SimpleDateFormat("yyyy-mm-dd");
								exp= f.parse(txtFechaE.getText());
								expsql=new Date(Date.parse(exp.toGMTString()));
							}else{
								expsql=null;
							}
							
							int pcS=(new MultiSolicitudInstalacion()).buscar(codSoli).getSerie();
							gestor.agregarInstalacion(pcS,Integer.parseInt(txtCod.getText()), txtLic.getText(), hoysql, expsql);
							
							gestor.finalizarCondicionSolicitud(codSoli);
							JOptionPane.showMessageDialog(null,"El software ha sido instalado Satisfactoriamente.","Actualizar",JOptionPane.INFORMATION_MESSAGE);
							dispose();
						} catch (Exception e) {
							JOptionPane.showMessageDialog(null,(String) e.getMessage(),"Error",JOptionPane.ERROR_MESSAGE);
						}
					}
				}
			};
		}
		return fnBtnAceptar;
	}
	
	private boolean validacion(){
		if(txtLic.getText().equals("")){
			JOptionPane.showMessageDialog(null,"Introduzca la Licencia","Error",JOptionPane.ERROR_MESSAGE);
			return false;
		}
		return true;
	}

}
