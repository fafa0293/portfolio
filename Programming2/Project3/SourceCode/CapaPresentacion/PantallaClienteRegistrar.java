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
public class PantallaClienteRegistrar extends javax.swing.JFrame {

	{
		//Set Look & Feel
		try {
			javax.swing.UIManager.setLookAndFeel(javax.swing.UIManager.getSystemLookAndFeelClassName());
		} catch(Exception e) {
			e.printStackTrace();
		}
	}

	private JTextField txtEmail;
	private JTextField txt1Apellido;
	private JTextField txtNombre;
	private AbstractAction FnBtnRegistrar;
	private AbstractAction abstractAction1;
	private JButton BtnCancelar;
	private JButton Registrar;
	private JTextField txtTelefono;
	private JLabel eTelefono;
	private JLabel eIdTec;
	private JLabel eNombreTec;
	private JLabel e1ApellidoTec;
	private JLabel eEmailTec;
	private JTextField txtId;
	private static PantallaPrincipal p;
	private Gestor gestor=new Gestor();
	/**
	* Auto-generated main method to display this JFrame
	*/
	public static void main(String[] args) {
		SwingUtilities.invokeLater(new Runnable() {
			public void run() {
				PantallaClienteRegistrar inst = new PantallaClienteRegistrar(p);
				inst.setLocationRelativeTo(null);
				inst.setVisible(true);
			}
		});
	}
	
	public PantallaClienteRegistrar(PantallaPrincipal pP) {
		super();
		initGUI();
		p=pP;
	}
	
	private void initGUI() {
		try {
			GroupLayout thisLayout = new GroupLayout((JComponent)getContentPane());
			getContentPane().setLayout(thisLayout);
			setDefaultCloseOperation(WindowConstants.DISPOSE_ON_CLOSE);
			this.setTitle("Registrar Cliente - Software Seguro");
			{
				txtEmail = new JTextField();
			}
			{
				txt1Apellido = new JTextField();
			}
			{
				txtNombre = new JTextField();
			}
			{
				txtId = new JTextField();
			}
			{
				eEmailTec = new JLabel();
				eEmailTec.setText("E-Mail: ");
			}
			{
				e1ApellidoTec = new JLabel();
				e1ApellidoTec.setText("Primer Apellido:");
			}
			{
				eNombreTec = new JLabel();
				eNombreTec.setText("Nombre: ");
			}
			{
				eIdTec = new JLabel();
				eIdTec.setText("Identificación: ");
			}
			{
				eTelefono = new JLabel();
				eTelefono.setText("Teléfono: ");
			}
			{
				txtTelefono = new JTextField();
			}
			{
				Registrar = new JButton();
				Registrar.setText("Registrar");
				Registrar.setAction(getFnBtnRegistrar());
			}
			{
				BtnCancelar = new JButton();
				BtnCancelar.setText("Cancelar");
				BtnCancelar.setAction(getAbstractAction1());
			}
			thisLayout.setVerticalGroup(thisLayout.createSequentialGroup()
				.addContainerGap()
				.addGroup(thisLayout.createParallelGroup(GroupLayout.Alignment.BASELINE)
				    .addComponent(txtId, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, 28, GroupLayout.PREFERRED_SIZE)
				    .addComponent(eIdTec, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, 21, GroupLayout.PREFERRED_SIZE))
				.addPreferredGap(LayoutStyle.ComponentPlacement.UNRELATED)
				.addGroup(thisLayout.createParallelGroup(GroupLayout.Alignment.BASELINE)
				    .addComponent(txtNombre, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, 28, GroupLayout.PREFERRED_SIZE)
				    .addComponent(eNombreTec, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, 21, GroupLayout.PREFERRED_SIZE))
				.addPreferredGap(LayoutStyle.ComponentPlacement.UNRELATED)
				.addGroup(thisLayout.createParallelGroup(GroupLayout.Alignment.BASELINE)
				    .addComponent(txt1Apellido, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, 28, GroupLayout.PREFERRED_SIZE)
				    .addComponent(e1ApellidoTec, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, 21, GroupLayout.PREFERRED_SIZE))
				.addPreferredGap(LayoutStyle.ComponentPlacement.UNRELATED)
				.addGroup(thisLayout.createParallelGroup(GroupLayout.Alignment.BASELINE)
				    .addComponent(txtEmail, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, 28, GroupLayout.PREFERRED_SIZE)
				    .addComponent(eEmailTec, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, 21, GroupLayout.PREFERRED_SIZE))
				.addGap(18)
				.addGroup(thisLayout.createParallelGroup(GroupLayout.Alignment.BASELINE)
				    .addComponent(txtTelefono, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, 28, GroupLayout.PREFERRED_SIZE)
				    .addComponent(eTelefono, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, 21, GroupLayout.PREFERRED_SIZE))
				.addGap(25)
				.addGroup(thisLayout.createParallelGroup(GroupLayout.Alignment.BASELINE)
				    .addComponent(Registrar, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE)
				    .addComponent(BtnCancelar, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE))
				.addContainerGap());
			thisLayout.setHorizontalGroup(thisLayout.createSequentialGroup()
				.addContainerGap()
				.addGroup(thisLayout.createParallelGroup()
				    .addGroup(thisLayout.createSequentialGroup()
				        .addGroup(thisLayout.createParallelGroup()
				            .addComponent(eEmailTec, GroupLayout.Alignment.LEADING, GroupLayout.PREFERRED_SIZE, 98, GroupLayout.PREFERRED_SIZE)
				            .addComponent(e1ApellidoTec, GroupLayout.Alignment.LEADING, GroupLayout.PREFERRED_SIZE, 98, GroupLayout.PREFERRED_SIZE)
				            .addComponent(eNombreTec, GroupLayout.Alignment.LEADING, GroupLayout.PREFERRED_SIZE, 98, GroupLayout.PREFERRED_SIZE)
				            .addComponent(eIdTec, GroupLayout.Alignment.LEADING, GroupLayout.PREFERRED_SIZE, 98, GroupLayout.PREFERRED_SIZE)
				            .addComponent(eTelefono, GroupLayout.Alignment.LEADING, GroupLayout.PREFERRED_SIZE, 98, GroupLayout.PREFERRED_SIZE))
				        .addGap(48)
				        .addGroup(thisLayout.createParallelGroup()
				            .addGroup(thisLayout.createSequentialGroup()
				                .addComponent(txtEmail, GroupLayout.PREFERRED_SIZE, 144, GroupLayout.PREFERRED_SIZE))
				            .addGroup(thisLayout.createSequentialGroup()
				                .addComponent(txt1Apellido, GroupLayout.PREFERRED_SIZE, 144, GroupLayout.PREFERRED_SIZE))
				            .addGroup(thisLayout.createSequentialGroup()
				                .addComponent(txtNombre, GroupLayout.PREFERRED_SIZE, 144, GroupLayout.PREFERRED_SIZE))
				            .addGroup(thisLayout.createSequentialGroup()
				                .addComponent(txtId, GroupLayout.PREFERRED_SIZE, 144, GroupLayout.PREFERRED_SIZE))
				            .addGroup(thisLayout.createSequentialGroup()
				                .addComponent(txtTelefono, GroupLayout.PREFERRED_SIZE, 144, GroupLayout.PREFERRED_SIZE)))
				        .addPreferredGap(LayoutStyle.ComponentPlacement.RELATED, 0, Short.MAX_VALUE))
				    .addGroup(GroupLayout.Alignment.LEADING, thisLayout.createSequentialGroup()
				        .addGap(78)
				        .addComponent(Registrar, GroupLayout.PREFERRED_SIZE, 95, GroupLayout.PREFERRED_SIZE)
				        .addGap(27)
				        .addComponent(BtnCancelar, GroupLayout.PREFERRED_SIZE, 95, GroupLayout.PREFERRED_SIZE)
				        .addGap(0, 0, Short.MAX_VALUE)))
				.addContainerGap(84, 84));
			thisLayout.linkSize(SwingConstants.VERTICAL, new Component[] {txtTelefono, txtEmail});
			thisLayout.linkSize(SwingConstants.VERTICAL, new Component[] {eTelefono, eEmailTec});
			thisLayout.linkSize(SwingConstants.HORIZONTAL, new Component[] {BtnCancelar, Registrar});
			thisLayout.linkSize(SwingConstants.HORIZONTAL, new Component[] {txtTelefono, txtEmail});
			thisLayout.linkSize(SwingConstants.HORIZONTAL, new Component[] {eTelefono, eEmailTec});
			pack();
			this.setSize(409, 318);
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
							gestor.agregarCliente(Integer.parseInt(txtId.getText()), txtNombre.getText(), txt1Apellido.getText(), txtEmail.getText(), txtTelefono.getText());
							JOptionPane.showMessageDialog(null,"Cliente Registrado Satisfactoriamente.","Registrar Cliente",JOptionPane.INFORMATION_MESSAGE);
							p.obtenerDuennos();
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
	
	private AbstractAction getAbstractAction1() {
		if(abstractAction1 == null) {
			abstractAction1 = new AbstractAction("Cancelar", null) {
				public void actionPerformed(ActionEvent evt) {
					dispose();
				}
			};
		}
		return abstractAction1;
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
					}else{
						if(txtTelefono.getText().equals("")){
							JOptionPane.showMessageDialog(null,"Introduzca el Telefono","Error",JOptionPane.ERROR_MESSAGE);
							return false;
						}
					}
				}
			}
		}
		return true;
	}

}
