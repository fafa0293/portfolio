package CapaPresentacion;
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
import javax.swing.JSeparator;
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
public class PantallaTecnicoSolicitudes extends javax.swing.JFrame {
	private JLabel ePendientes;
	private JTable tResulSolicitudes;
	private JScrollPane jScrollPane1;
	private JScrollPane jScrollPane2;
	private AbstractAction FnBtnCerrar;
	private JButton BtnCerrar;
	private JSeparator jSeparator1;
	private JTable jTable1;
	private JLabel eFinalizadas;
	private static int cod;
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
				PantallaTecnicoSolicitudes inst = new PantallaTecnicoSolicitudes(cod);
				inst.setLocationRelativeTo(null);
				inst.setVisible(true);
			}
		});
	}
	
	public PantallaTecnicoSolicitudes(int cod) {
		super();
		this.cod=cod;
		initGUI();
		obtenerResultadosSolicitudes("Pendiente");
		obtenerResultadosSolicitudes("Finalizado");
		
	}
	
	private void initGUI() {
		try {
			GroupLayout thisLayout = new GroupLayout((JComponent)getContentPane());
			getContentPane().setLayout(thisLayout);
			setDefaultCloseOperation(WindowConstants.DISPOSE_ON_CLOSE);
			this.setTitle("Solicitudes de Técnicos - Sotware Seguro");
			{
				ePendientes = new JLabel();
				ePendientes.setText("Pendientes");
			}
			{
				jScrollPane1 = new JScrollPane();
				{
					TableModel tResulSolicitudesModel = 
							new DefaultTableModel(
									new String[][] { },
									new String[] { "Código","Tipo" ,"Fecha Recepción","Fecha Entrega", "Condición","Pc","Software","Técnico","Cliente" });
					tResulSolicitudes = new JTable();
					jScrollPane1.setViewportView(tResulSolicitudes);
					tResulSolicitudes.setModel(tResulSolicitudesModel);
				}
			}
			{
				eFinalizadas = new JLabel();
				eFinalizadas.setText("Finalizadas");
			}
			{
				jScrollPane2 = new JScrollPane();
				{
					TableModel jTable1Model = 
							new DefaultTableModel(
									new String[][] { },
									new String[] { "Código","Tipo" ,"Fecha Recepción","Fecha Entrega", "Condición","Pc","Software","Técnico","Cliente" });
					jTable1 = new JTable();
					jScrollPane2.setViewportView(jTable1);
					jTable1.setModel(jTable1Model);
				}
			}
			{
				BtnCerrar = new JButton();
				BtnCerrar.setText("Cerrar");
				BtnCerrar.setAction(getFnBtnCerrar());
			}
			{
				jSeparator1 = new JSeparator();
			}
			thisLayout.setVerticalGroup(thisLayout.createSequentialGroup()
				.addContainerGap()
				.addComponent(ePendientes, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE)
				.addGap(26)
				.addComponent(jScrollPane1, GroupLayout.PREFERRED_SIZE, 103, GroupLayout.PREFERRED_SIZE)
				.addGap(0, 27, GroupLayout.PREFERRED_SIZE)
				.addComponent(jSeparator1, GroupLayout.PREFERRED_SIZE, 5, GroupLayout.PREFERRED_SIZE)
				.addPreferredGap(LayoutStyle.ComponentPlacement.UNRELATED)
				.addComponent(eFinalizadas, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE)
				.addGap(23)
				.addComponent(jScrollPane2, GroupLayout.PREFERRED_SIZE, 103, GroupLayout.PREFERRED_SIZE)
				.addGap(0, 29, Short.MAX_VALUE)
				.addComponent(BtnCerrar, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE)
				.addContainerGap());
			thisLayout.setHorizontalGroup(thisLayout.createSequentialGroup()
				.addContainerGap()
				.addGroup(thisLayout.createParallelGroup()
				    .addComponent(jScrollPane1, GroupLayout.Alignment.LEADING, 0, 755, Short.MAX_VALUE)
				    .addComponent(jSeparator1, GroupLayout.Alignment.LEADING, 0, 755, Short.MAX_VALUE)
				    .addGroup(thisLayout.createSequentialGroup()
				        .addComponent(jScrollPane2, GroupLayout.PREFERRED_SIZE, 755, GroupLayout.PREFERRED_SIZE)
				        .addGap(0, 0, Short.MAX_VALUE))
				    .addGroup(GroupLayout.Alignment.LEADING, thisLayout.createSequentialGroup()
				        .addGap(337)
				        .addGroup(thisLayout.createParallelGroup()
				            .addGroup(GroupLayout.Alignment.LEADING, thisLayout.createSequentialGroup()
				                .addComponent(ePendientes, GroupLayout.PREFERRED_SIZE, 98, GroupLayout.PREFERRED_SIZE)
				                .addPreferredGap(LayoutStyle.ComponentPlacement.RELATED, 0, GroupLayout.PREFERRED_SIZE))
				            .addComponent(eFinalizadas, GroupLayout.Alignment.LEADING, GroupLayout.PREFERRED_SIZE, 103, GroupLayout.PREFERRED_SIZE))
				        .addGap(0, 236, Short.MAX_VALUE)
				        .addComponent(BtnCerrar, GroupLayout.PREFERRED_SIZE, 79, GroupLayout.PREFERRED_SIZE)))
				.addContainerGap());
			pack();
			this.setSize(797, 457);
		} catch (Exception e) {
		    //add your error handling code here
			e.printStackTrace();
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
	
	private void obtenerResultadosSolicitudes(String cond){
		Vector datos=null;
		String[][] resul=null;
		TreeMap dato=null;
		try {
			datos=gestor.consultarSolicitudesPorTec(cod, cond);
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
			if(cond.equals("Pendiente")){
				tResulSolicitudes.setModel(new DefaultTableModel(resul,new String[] { "Código","Tipo" ,"Fecha Recepción","Fecha Entrega", "Condición","Pc","Software","Técnico","Cliente" }));
			}else{
				jTable1.setModel(new DefaultTableModel(resul,new String[] { "Código","Tipo" ,"Fecha Recepción","Fecha Entrega", "Condición","Pc","Software","Técnico","Cliente" }));
			}
		}
		catch (Exception ex) {
			JOptionPane.showMessageDialog(this,(String) ex.getMessage(),"!",JOptionPane.INFORMATION_MESSAGE);	
			if(cond.equals("Pendiente")){
				tResulSolicitudes.setModel(new DefaultTableModel(new String[][] { },new String[] { "Código","Tipo" ,"Fecha Recepción","Fecha Entrega", "Condición","Pc","Software","Técnico","Cliente" }));
			}else{
				jTable1.setModel(new DefaultTableModel(resul,new String[] { "Código","Tipo" ,"Fecha Recepción","Fecha Entrega", "Condición","Pc","Software","Técnico","Cliente" }));
			}
			
		}
	}

}
