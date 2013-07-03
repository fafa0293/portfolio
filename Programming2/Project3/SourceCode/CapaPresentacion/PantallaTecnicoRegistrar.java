package CapaPresentacion;
import java.awt.Component;

import java.awt.event.ActionEvent;
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
public class PantallaTecnicoRegistrar extends javax.swing.JFrame {
	private JLabel eIdTec;
	private JLabel e1ApellidoTec;
	private JTextField txtNombre;
	private JButton btnCancelar;
	private AbstractAction FnBtnCancelar;
	private AbstractAction FnBtnRegistrar;
	private JButton btnRegistrar;
	private JTextField txtEmail;
	private JTextField txt1Apellido;
	private JTextField txtId;
	private JLabel eEmailTec;
	private JLabel eNombreTec;
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
				PantallaTecnicoRegistrar inst = new PantallaTecnicoRegistrar();
				inst.setLocationRelativeTo(null);
				inst.setVisible(true);
			}
		});
	}
	
	public PantallaTecnicoRegistrar() {
		super();
		initGUI();
	}
	
	private void initGUI() {
		try {
			setDefaultCloseOperation(WindowConstants.DISPOSE_ON_CLOSE);
			GroupLayout thisLayout = new GroupLayout((JComponent)getContentPane());
			getContentPane().setLayout(thisLayout);
			this.setTitle("Registar Técnico - Software Seguro");
			{
				eIdTec = new JLabel();
				eIdTec.setText("Identificación: ");
			}
			{
				eNombreTec = new JLabel();
				eNombreTec.setText("Nombre: ");
			}
			{
				e1ApellidoTec = new JLabel();
				e1ApellidoTec.setText("Primer Apellido:");
			}
			{
				eEmailTec = new JLabel();
				eEmailTec.setText("E-Mail: ");
			}
			{
				txtId = new JTextField();
			}
			{
				txtNombre = new JTextField();
			}
			{
				txt1Apellido = new JTextField();
			}
			{
				txtEmail = new JTextField();
			}
			{
				btnRegistrar = new JButton();
				btnRegistrar.setText("Registrar");
				btnRegistrar.setAction(getFnBtnRegistrar());
			}
			{
				btnCancelar = new JButton();
				btnCancelar.setText("Cancelar");
				btnCancelar.setAction(getFnBtnCancelar());
			}
			thisLayout.setVerticalGroup(thisLayout.createSequentialGroup()
				.addContainerGap()
				.addGroup(thisLayout.createParallelGroup(GroupLayout.Alignment.BASELINE)
				    .addComponent(txtId, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE)
				    .addComponent(eIdTec, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE))
				.addPreferredGap(LayoutStyle.ComponentPlacement.UNRELATED)
				.addGroup(thisLayout.createParallelGroup(GroupLayout.Alignment.BASELINE)
				    .addComponent(txtNombre, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE)
				    .addComponent(eNombreTec, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE))
				.addPreferredGap(LayoutStyle.ComponentPlacement.UNRELATED)
				.addGroup(thisLayout.createParallelGroup(GroupLayout.Alignment.BASELINE)
				    .addComponent(txt1Apellido, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE)
				    .addComponent(e1ApellidoTec, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE))
				.addPreferredGap(LayoutStyle.ComponentPlacement.UNRELATED)
				.addGroup(thisLayout.createParallelGroup(GroupLayout.Alignment.BASELINE)
				    .addComponent(txtEmail, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE)
				    .addComponent(eEmailTec, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE))
				.addGap(27)
				.addGroup(thisLayout.createParallelGroup(GroupLayout.Alignment.BASELINE)
				    .addComponent(btnRegistrar, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE)
				    .addComponent(btnCancelar, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE))
				.addContainerGap());
			thisLayout.setHorizontalGroup(thisLayout.createSequentialGroup()
				.addContainerGap()
				.addGroup(thisLayout.createParallelGroup()
				    .addGroup(GroupLayout.Alignment.LEADING, thisLayout.createSequentialGroup()
				        .addComponent(eIdTec, GroupLayout.PREFERRED_SIZE, 98, GroupLayout.PREFERRED_SIZE)
				        .addGap(36))
				    .addGroup(GroupLayout.Alignment.LEADING, thisLayout.createSequentialGroup()
				        .addComponent(eNombreTec, GroupLayout.PREFERRED_SIZE, 98, GroupLayout.PREFERRED_SIZE)
				        .addGap(36))
				    .addGroup(GroupLayout.Alignment.LEADING, thisLayout.createSequentialGroup()
				        .addComponent(e1ApellidoTec, GroupLayout.PREFERRED_SIZE, 98, GroupLayout.PREFERRED_SIZE)
				        .addGap(36))
				    .addGroup(GroupLayout.Alignment.LEADING, thisLayout.createSequentialGroup()
				        .addComponent(eEmailTec, GroupLayout.PREFERRED_SIZE, 98, GroupLayout.PREFERRED_SIZE)
				        .addGap(36))
				    .addGroup(GroupLayout.Alignment.LEADING, thisLayout.createSequentialGroup()
				        .addGap(37)
				        .addComponent(btnRegistrar, GroupLayout.PREFERRED_SIZE, 97, GroupLayout.PREFERRED_SIZE)))
				.addGroup(thisLayout.createParallelGroup()
				    .addGroup(GroupLayout.Alignment.LEADING, thisLayout.createSequentialGroup()
				        .addComponent(txtId, GroupLayout.PREFERRED_SIZE, 144, GroupLayout.PREFERRED_SIZE)
				        .addGap(0, 38, Short.MAX_VALUE))
				    .addGroup(GroupLayout.Alignment.LEADING, thisLayout.createSequentialGroup()
				        .addComponent(txtNombre, GroupLayout.PREFERRED_SIZE, 144, GroupLayout.PREFERRED_SIZE)
				        .addGap(0, 38, Short.MAX_VALUE))
				    .addGroup(GroupLayout.Alignment.LEADING, thisLayout.createSequentialGroup()
				        .addComponent(txt1Apellido, GroupLayout.PREFERRED_SIZE, 144, GroupLayout.PREFERRED_SIZE)
				        .addGap(0, 38, Short.MAX_VALUE))
				    .addGroup(GroupLayout.Alignment.LEADING, thisLayout.createSequentialGroup()
				        .addComponent(txtEmail, GroupLayout.PREFERRED_SIZE, 144, GroupLayout.PREFERRED_SIZE)
				        .addGap(0, 38, Short.MAX_VALUE))
				    .addGroup(GroupLayout.Alignment.LEADING, thisLayout.createSequentialGroup()
				        .addGap(85)
				        .addComponent(btnCancelar, GroupLayout.PREFERRED_SIZE, 97, GroupLayout.PREFERRED_SIZE)
				        .addGap(0, 0, Short.MAX_VALUE)))
				.addContainerGap(58, 58));
			thisLayout.linkSize(SwingConstants.VERTICAL, new Component[] {txtId, txtNombre, txt1Apellido, txtEmail});
			thisLayout.linkSize(SwingConstants.VERTICAL, new Component[] {eEmailTec, eIdTec, eNombreTec, e1ApellidoTec});
			thisLayout.linkSize(SwingConstants.HORIZONTAL, new Component[] {btnCancelar, btnRegistrar});
			thisLayout.linkSize(SwingConstants.HORIZONTAL, new Component[] {txtId, txtNombre, txt1Apellido, txtEmail});
			thisLayout.linkSize(SwingConstants.HORIZONTAL, new Component[] {eEmailTec, eIdTec, eNombreTec, e1ApellidoTec});
			pack();
			this.setSize(404, 250);
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
							gestor.agregarTecnico(Integer.parseInt(txtId.getText()), txtNombre.getText(), txt1Apellido.getText(), txtEmail.getText());
							JOptionPane.showMessageDialog(null,"Tecnico Registrado Satisfactoriamente.","Registrar Técnico",JOptionPane.INFORMATION_MESSAGE);
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
	
	private boolean validacion(){
		if(txtId.getText().equals("")){
			JOptionPane.showMessageDialog(null,"Introduzca la identificación","Error",JOptionPane.ERROR_MESSAGE);
			return false;
		}else{
			if(txtNombre.getText().equals("")){
				JOptionPane.showMessageDialog(null,"Introduzca el nombre","Error",JOptionPane.ERROR_MESSAGE);
				return false;
			}else{
				if(txt1Apellido.getText().equals("")){
					JOptionPane.showMessageDialog(null,"Introduzca el primer apellido","Error",JOptionPane.ERROR_MESSAGE);
					return false;
				}else{
					if(txtEmail.getText().equals("")){
						JOptionPane.showMessageDialog(null,"Introduzca el E-mail","Error",JOptionPane.ERROR_MESSAGE);
						return false;
					}
				}
			}
		}
		return true;
	}
	
	

}
