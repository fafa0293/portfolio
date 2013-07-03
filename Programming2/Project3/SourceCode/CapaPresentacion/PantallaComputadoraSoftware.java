package CapaPresentacion;
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
import java.awt.event.ActionEvent;
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
public class PantallaComputadoraSoftware extends javax.swing.JFrame {
	private JTable Tsoft;
	private JScrollPane jScrollPane1;
	private JButton BtnCerrar;
	private JLabel eSoft;
	private static int serie;
	private AbstractAction fnBtnCerrar;
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
				PantallaComputadoraSoftware inst = new PantallaComputadoraSoftware(serie);
				inst.setLocationRelativeTo(null);
				inst.setVisible(true);
			}
		});
	}
	
	public PantallaComputadoraSoftware(int serie) {
		super();
		this.serie=serie;
		initGUI();
		obtenerResultadosSoftware();
		
	}
	
	private void initGUI() {
		try {
			GroupLayout thisLayout = new GroupLayout((JComponent)getContentPane());
			getContentPane().setLayout(thisLayout);
			setDefaultCloseOperation(WindowConstants.DISPOSE_ON_CLOSE);
			{
				jScrollPane1 = new JScrollPane();
				{
					TableModel TsoftModel = 
							new DefaultTableModel(
									new String[][] { { "One", "Two" }, { "Three", "Four" } },
									new String[] { "Column 1", "Column 2" });
					Tsoft = new JTable();
					jScrollPane1.setViewportView(Tsoft);
					Tsoft.setModel(TsoftModel);
				}
			}
			{
				eSoft = new JLabel();
				eSoft.setText("Software Instalado");
			}
			{
				BtnCerrar = new JButton();
				BtnCerrar.setText("Cerrar");
				BtnCerrar.setAction(getFnBtnCerrar());
			}
			thisLayout.setVerticalGroup(thisLayout.createSequentialGroup()
				.addContainerGap()
				.addComponent(eSoft, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE)
				.addPreferredGap(LayoutStyle.ComponentPlacement.UNRELATED)
				.addComponent(jScrollPane1, GroupLayout.PREFERRED_SIZE, 126, GroupLayout.PREFERRED_SIZE)
				.addPreferredGap(LayoutStyle.ComponentPlacement.RELATED)
				.addComponent(BtnCerrar, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE)
				.addGap(0, 6, Short.MAX_VALUE));
			thisLayout.setHorizontalGroup(thisLayout.createSequentialGroup()
				.addContainerGap()
				.addGroup(thisLayout.createParallelGroup()
				    .addComponent(jScrollPane1, GroupLayout.Alignment.LEADING, 0, 568, Short.MAX_VALUE)
				    .addGroup(GroupLayout.Alignment.LEADING, thisLayout.createSequentialGroup()
				        .addGap(224)
				        .addComponent(eSoft, GroupLayout.PREFERRED_SIZE, 116, GroupLayout.PREFERRED_SIZE)
				        .addGap(0, 149, Short.MAX_VALUE)
				        .addComponent(BtnCerrar, GroupLayout.PREFERRED_SIZE, 79, GroupLayout.PREFERRED_SIZE)))
				.addContainerGap());
			pack();
			this.setSize(610, 251);
		} catch (Exception e) {
		    //add your error handling code here
			e.printStackTrace();
		}
	}
	private void obtenerResultadosSoftware(){
		Vector datos=null;
		String[][] resul=null;
		TreeMap dato=null;
		try {
			datos=gestor.consultarSoftwarePc(serie);
			resul=new String[datos.size()][4];
			for(int i=0;i<datos.size();i++){
				dato=(TreeMap) datos.get(i);
				resul[i][0]=(String)dato.get("nom");
				resul[i][1]=(String)dato.get("lic");
				resul[i][2]=""+dato.get("fechaI");
				resul[i][3]=""+dato.get("fechaE");
			}
			Tsoft.setModel(new DefaultTableModel(resul,new String[] { "Nombre","Licencia","Fecha de Instalacion", "Fecha de Expiracion"})) ;
		}
		catch (Exception ex) {
			JOptionPane.showMessageDialog(this,(String) ex.getMessage(),"!",JOptionPane.INFORMATION_MESSAGE);	
			Tsoft.setModel(new DefaultTableModel(new String[][] { }, new String[] { "Nombre","Licencia","Fecha de Instalacion", "Fecha de Expiracion"})) ;

		}
	}
	
	private AbstractAction getFnBtnCerrar() {
		if(fnBtnCerrar == null) {
			fnBtnCerrar = new AbstractAction("Cerrar", null) {
				public void actionPerformed(ActionEvent evt) {
					dispose();
				}
			};
		}
		return fnBtnCerrar;
	}

}
