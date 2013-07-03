package CapaPresentacion;
import java.awt.BorderLayout;
import java.awt.event.ActionEvent;
import java.util.TreeMap;
import java.util.Vector;
import javax.swing.AbstractAction;

import javax.swing.GroupLayout;
import javax.swing.JButton;
import javax.swing.JComponent;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JScrollPane;
import javax.swing.JTable;
import javax.swing.LayoutStyle;

import javax.swing.WindowConstants;
import javax.swing.table.DefaultTableModel;
import javax.swing.table.TableModel;
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
public class PantallaInstalacion extends javax.swing.JFrame {
	private JTable TSolicitudes;
	private JScrollPane jScrollPane1;
	private AbstractAction FnBtnSelec;
	private AbstractAction FnBtnCerrar;
	private JButton BtnCancelar;
	private JButton BtnSelec;
	private JLabel eSelec;
	private Gestor gestor=new Gestor();
	private String[][] resulListSolicitudes;
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
				PantallaInstalacion inst = new PantallaInstalacion();
				inst.setLocationRelativeTo(null);
				inst.setVisible(true);
			}
		});
	}
	
	public PantallaInstalacion() {
		super();
		initGUI();
		obtenerResultadosSolicitudes();
	}
	
	private void initGUI() {
		try {
			GroupLayout thisLayout = new GroupLayout((JComponent)getContentPane());
			getContentPane().setLayout(thisLayout);
			setDefaultCloseOperation(WindowConstants.DISPOSE_ON_CLOSE);
			this.setTitle("Intalación - Software Seguro");
			{
				jScrollPane1 = new JScrollPane();
				{
					TableModel TSolicitudesModel = 
							new DefaultTableModel(
									new String[][] { },
									new String[] { "Código","Tipo" ,"Fecha Recepción","Fecha Entrega", "Condición","Pc","Software","Técnico","Cliente" });
					TSolicitudes = new JTable();
					jScrollPane1.setViewportView(TSolicitudes);
					TSolicitudes.setModel(TSolicitudesModel);
				}
			}
			{
				BtnSelec = new JButton();
				BtnSelec.setText("Seleccionar");
				BtnSelec.setAction(getFnBtnSelec());
			}
			{
				BtnCancelar = new JButton();
				BtnCancelar.setText("Cancelar");
				BtnCancelar.setAction(getFnBtnCerrar());
			}
			{
				eSelec = new JLabel();
				eSelec.setText("Seleccione la solicitud a la que desea actulizar el software:");
			}
			thisLayout.setVerticalGroup(thisLayout.createSequentialGroup()
				.addContainerGap()
				.addComponent(eSelec, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE)
				.addPreferredGap(LayoutStyle.ComponentPlacement.UNRELATED)
				.addComponent(jScrollPane1, 0, 142, Short.MAX_VALUE)
				.addPreferredGap(LayoutStyle.ComponentPlacement.UNRELATED, 1, GroupLayout.PREFERRED_SIZE)
				.addGroup(thisLayout.createParallelGroup(GroupLayout.Alignment.BASELINE)
				    .addComponent(BtnSelec, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE)
				    .addComponent(BtnCancelar, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE))
				.addContainerGap());
			thisLayout.setHorizontalGroup(thisLayout.createSequentialGroup()
				.addContainerGap()
				.addGroup(thisLayout.createParallelGroup()
				    .addComponent(jScrollPane1, GroupLayout.Alignment.LEADING, 0, 653, Short.MAX_VALUE)
				    .addGroup(GroupLayout.Alignment.LEADING, thisLayout.createSequentialGroup()
				        .addGroup(thisLayout.createParallelGroup()
				            .addGroup(GroupLayout.Alignment.LEADING, thisLayout.createSequentialGroup()
				                .addGap(423)
				                .addComponent(BtnSelec, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE))
				            .addGroup(GroupLayout.Alignment.LEADING, thisLayout.createSequentialGroup()
				                .addComponent(eSelec, GroupLayout.PREFERRED_SIZE, 438, GroupLayout.PREFERRED_SIZE)
				                .addGap(84)))
				        .addGap(0, 32, Short.MAX_VALUE)
				        .addComponent(BtnCancelar, GroupLayout.PREFERRED_SIZE, 99, GroupLayout.PREFERRED_SIZE)))
				.addContainerGap());
			pack();
			this.setSize(695, 280);
		} catch (Exception e) {
		    //add your error handling code here
			e.printStackTrace();
		}
	}
	
	private void obtenerResultadosSolicitudes(){
		Vector datos=null;
		String[][] resul=null;
		TreeMap dato=null;
		try {
			datos=gestor.consultarSolicitudesCondicionEs("Pendiente");
			resul=new String[datos.size()][9];
			for(int i=0;i<datos.size();i++){
				dato=(TreeMap) datos.get(i);
				Tecnico tecnico=(Tecnico)dato.get("tecnico");
				Cliente cliente=(Cliente)dato.get("cliente");
				Computadora pc=(Computadora)dato.get("pc");
				Software soft=(Software)dato.get("soft");
				resul[i][0]=""+dato.get("cod");
				resul[i][1]=(String)dato.get("tipo");
				resul[i][2]=(String)dato.get("fechaRecepcion");
				resul[i][3]=(String)dato.get("fechaEntrega");
				resul[i][4]=(String)dato.get("condicion");
				resul[i][5]=""+pc.getSerie();
				resul[i][6]=""+soft.getId();
				resul[i][7]=tecnico.getNombre()+" "+tecnico.getApellido();
				resul[i][8]=cliente.getNombre()+" "+cliente.getApellido();
			}
			resulListSolicitudes=resul;
			TSolicitudes.setModel(new DefaultTableModel(resul,new String[] { "Código","Tipo" ,"Fecha Recepción","Fecha Entrega", "Condición","Pc","Software","Técnico","Cliente" }));
		}
		catch (Exception ex) {
			JOptionPane.showMessageDialog(this,(String) ex.getMessage(),"Error",JOptionPane.ERROR_MESSAGE);	
			TSolicitudes.setModel(new DefaultTableModel(new String[][] { }, new String[] { "Código","Tipo" ,"Fecha Recepción","Fecha Entrega", "Condición","Pc","Software","Técnico","Cliente" }));
			resulListSolicitudes=null;
		}
		
	}
	
	private AbstractAction getFnBtnCerrar() {
		if(FnBtnCerrar == null) {
			FnBtnCerrar = new AbstractAction("Cerrar", null) {
				public void actionPerformed(ActionEvent evt) {
					dispose();
				}
			};
		}
		return FnBtnCerrar;
	}
	
	private AbstractAction getFnBtnSelec() {
		if(FnBtnSelec == null) {
			FnBtnSelec = new AbstractAction("Seleccionar", null) {
				public void actionPerformed(ActionEvent evt) {
					if(resulListSolicitudes!=null){
						try{
							int cod=Integer.parseInt(resulListSolicitudes[TSolicitudes.getSelectedRow()][6] );
							int codSoli=Integer.parseInt(resulListSolicitudes[TSolicitudes.getSelectedRow()][0] );
							PantallaIntalacionActualizacion inst = new PantallaIntalacionActualizacion(cod, codSoli);
							inst.setLocationRelativeTo(null);
							inst.setVisible(true);
							dispose();
						}
						catch (Exception ex){
							JOptionPane.showMessageDialog(null,(String) ex.getMessage(),"No se ha seleccionado una solicitud",JOptionPane.ERROR_MESSAGE);
						}
					}else{
						JOptionPane.showMessageDialog(null,"Deben de haber solicitudes Pendientes","Error", JOptionPane.ERROR_MESSAGE);
					}
				}
			};
		}
		return FnBtnSelec;
	}

}
