package CapaPresentacion;
import java.awt.Component;
import java.awt.GridLayout;
import java.awt.event.ActionEvent;
import java.sql.SQLException;
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
import javax.swing.JPanel;
import javax.swing.JScrollPane;
import javax.swing.JSeparator;
import javax.swing.JTabbedPane;
import javax.swing.JTable;
import javax.swing.JTextField;
import javax.swing.LayoutStyle;
import javax.swing.SwingConstants;

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
public class PantallaPrincipal extends javax.swing.JFrame {

	{
		//Set Look & Feel
		try {
			javax.swing.UIManager.setLookAndFeel(javax.swing.UIManager.getSystemLookAndFeelClassName());
		} catch(Exception e) {
			e.printStackTrace();
		}
	}

	private JLabel jLabel4;
	private JComboBox CbEstado;
	private JLabel eInst;
	private AbstractAction fnTabPc;
	private AbstractAction FnBtnActu;
	private JButton btnInstalacion;
	private JTextField txtValST;
	private JTextField txtValU;
	private JTextField txtValN;
	private JLabel eNValores;
	private JLabel eValorA;
	private AbstractAction FnBtnModificarP;
	private AbstractAction FnBtnSelecionarPC;
	private JLabel pCantMST;
	private JLabel pCantDU;
	private JLabel pCantDN;
	private JLabel eCantSoliciXTecnico;
	private JLabel eCantDiasUrgente;
	private JLabel eCantDiasNormal;
	private JLabel eParametros;
	private JPanel tabParametros;
	private AbstractAction FnBtnBuscarPc;
	private AbstractAction FnBtnSeleccionarTecnico;
	private AbstractAction FnBtnBuscarTecnicos;
	private AbstractAction FnBtnEliminarSolicitud;
	private AbstractAction FnBtnBuscarSolicitud;
	private JButton btnModificarP;
	private JButton btnSelecPC;
	private JScrollPane jScrollPane3;
	private JTable tResulPc;
	private JButton btnBuscarPC;
	private JComboBox jbIdCliente;
	private JLabel eCliente;
	private JButton btnSeleccionar;
	private JScrollPane jScrollPane2;
	private JTable tResulTecnicos;
	private JButton btnBuscarTodos;
	private JButton btnEliminarSoli;
	private JScrollPane jScrollPane1;
	private JTable tResulSolicitudes;
	private JButton btnBuscar;
	private JLabel eEstado;
	private JPanel tabTecnicos;
	private JPanel tabComputadoras;
	private JPanel tabSolicitudes;
	private AbstractAction fnBtnRegistarSolic;
	private AbstractAction fnBtnRegistarSoft;
	private AbstractAction fnBtnRegistarPC;
	private AbstractAction fnBtnRegistarClien;
	private AbstractAction fnBtnRegistarTec;
	private JTabbedPane jTabbedPane1;
	private JLabel EConsultas;
	private JSeparator jSeparator1;
	private JButton BtnRegistrarSolicitud;
	private JButton BtnRegSofteware;
	private JLabel Ereg;
	private JLabel jLabel1;
	private JLabel jLabel2;
	private JButton BtnRTecnico;
	private JButton BtnRegCliente;
	private JButton BtnRegComputadora;
	private JLabel jLabel3;
	private String[][] resulListSolicitudes;
	private String[][] resulListTecnicos;
	private String[][] resulListPc;
	private Vector duennos;
	private Gestor gestor=new Gestor();

	/**
	* Auto-generated main method to display this JFrame
	*/
	public static void main(String[] args) {
		SwingUtilities.invokeLater(new Runnable() {
			public void run() {
				PantallaPrincipal inst = new PantallaPrincipal();
				inst.setLocationRelativeTo(null);
				inst.setVisible(true);
			}
		});
	}
	
	public PantallaPrincipal() {
		super();
		initGUI();
		obtenerParametros();
	}
	
	private void initGUI() {
		try {
			GroupLayout thisLayout = new GroupLayout((JComponent)getContentPane());
			getContentPane().setLayout(thisLayout);
			setDefaultCloseOperation(WindowConstants.DISPOSE_ON_CLOSE);
			this.setTitle("Software Seguro");
			{
				jLabel4 = new JLabel();
				jLabel4.setText("Solicitud de Instalción:");
			}
			{
				jLabel3 = new JLabel();
				jLabel3.setText("Software: ");
			}
			{
				BtnRegComputadora = new JButton();
				BtnRegComputadora.setText("Registrar");
				BtnRegComputadora.setAction(getFnBtnRegistarPC());
			}
			{
				BtnRegCliente = new JButton();
				BtnRegCliente.setText("Registrar");
				BtnRegCliente.setAction(getFnBtnRegistarClien());
			}
			{
				BtnRTecnico = new JButton();
				BtnRTecnico.setText("Registrar");
				BtnRTecnico.setAction(getFnBtnRegistarTec());
			}
			{
				jLabel2 = new JLabel();
				jLabel2.setText("Computadora: ");
			}
			{
				jLabel1 = new JLabel();
				jLabel1.setText("Cliente: ");
			}
			{
				Ereg = new JLabel();
				Ereg.setText("Técnico: ");
			}
			{
				BtnRegSofteware = new JButton();
				BtnRegSofteware.setText("Registrar");
				BtnRegSofteware.setAction(getFnBtnRegistarSoft());
			}
			{
				jSeparator1 = new JSeparator();
			}
			{
				EConsultas = new JLabel();
				EConsultas.setText("Consultas");
			}
			{
				jTabbedPane1 = new JTabbedPane();
				jTabbedPane1.addTab("Solicitudes", null, getTabSolicitudes(), null);
				jTabbedPane1.addTab("Técnicos", null, getTabTecnicos(), null);
				jTabbedPane1.addTab("Computadoras", null, getTabComputadoras(), null);
				jTabbedPane1.addTab("Parametros", null, getTabParametros(), null);
			}
			{
				BtnRegistrarSolicitud = new JButton();
				BtnRegistrarSolicitud.setText("Registrar");
				BtnRegistrarSolicitud.setAction(getFnBtnRegistarSolic());
			}
			thisLayout.setVerticalGroup(thisLayout.createSequentialGroup()
				.addGap(9)
				.addGroup(thisLayout.createParallelGroup(GroupLayout.Alignment.BASELINE)
				    .addComponent(BtnRegSofteware, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, 28, GroupLayout.PREFERRED_SIZE)
				    .addComponent(jLabel3, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE)
				    .addComponent(BtnRTecnico, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, 28, GroupLayout.PREFERRED_SIZE)
				    .addComponent(Ereg, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE))
				.addPreferredGap(LayoutStyle.ComponentPlacement.UNRELATED)
				.addGroup(thisLayout.createParallelGroup(GroupLayout.Alignment.BASELINE)
				    .addComponent(BtnRegistrarSolicitud, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, 28, GroupLayout.PREFERRED_SIZE)
				    .addComponent(jLabel4, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE)
				    .addComponent(BtnRegCliente, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, 28, GroupLayout.PREFERRED_SIZE)
				    .addComponent(jLabel1, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE))
				.addPreferredGap(LayoutStyle.ComponentPlacement.UNRELATED)
				.addGroup(thisLayout.createParallelGroup(GroupLayout.Alignment.BASELINE)
				    .addComponent(BtnRegComputadora, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, 28, GroupLayout.PREFERRED_SIZE)
				    .addComponent(jLabel2, GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE)
				    .addComponent(getBtnInstalacion(), GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE)
				    .addComponent(getEInst(), GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, 16, GroupLayout.PREFERRED_SIZE))
				.addPreferredGap(LayoutStyle.ComponentPlacement.UNRELATED)
				.addComponent(jSeparator1, GroupLayout.PREFERRED_SIZE, 6, GroupLayout.PREFERRED_SIZE)
				.addPreferredGap(LayoutStyle.ComponentPlacement.RELATED)
				.addComponent(EConsultas, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE)
				.addPreferredGap(LayoutStyle.ComponentPlacement.UNRELATED)
				.addComponent(jTabbedPane1, 0, 274, Short.MAX_VALUE)
				.addContainerGap());
			thisLayout.setHorizontalGroup(thisLayout.createSequentialGroup()
				.addContainerGap()
				.addGroup(thisLayout.createParallelGroup()
				    .addGroup(GroupLayout.Alignment.LEADING, thisLayout.createSequentialGroup()
				        .addGroup(thisLayout.createParallelGroup()
				            .addComponent(jLabel2, GroupLayout.Alignment.LEADING, GroupLayout.PREFERRED_SIZE, 98, GroupLayout.PREFERRED_SIZE)
				            .addComponent(jLabel1, GroupLayout.Alignment.LEADING, GroupLayout.PREFERRED_SIZE, 98, GroupLayout.PREFERRED_SIZE)
				            .addComponent(Ereg, GroupLayout.Alignment.LEADING, GroupLayout.PREFERRED_SIZE, 98, GroupLayout.PREFERRED_SIZE))
				        .addGap(18)
				        .addGroup(thisLayout.createParallelGroup()
				            .addComponent(BtnRegComputadora, GroupLayout.Alignment.LEADING, GroupLayout.PREFERRED_SIZE, 95, GroupLayout.PREFERRED_SIZE)
				            .addComponent(BtnRegCliente, GroupLayout.Alignment.LEADING, GroupLayout.PREFERRED_SIZE, 95, GroupLayout.PREFERRED_SIZE)
				            .addComponent(BtnRTecnico, GroupLayout.Alignment.LEADING, GroupLayout.PREFERRED_SIZE, 95, GroupLayout.PREFERRED_SIZE))
				        .addGap(45)
				        .addComponent(EConsultas, GroupLayout.PREFERRED_SIZE, 67, GroupLayout.PREFERRED_SIZE)
				        .addGroup(thisLayout.createParallelGroup()
				            .addComponent(jLabel4, GroupLayout.Alignment.LEADING, GroupLayout.PREFERRED_SIZE, 139, GroupLayout.PREFERRED_SIZE)
				            .addComponent(jLabel3, GroupLayout.Alignment.LEADING, GroupLayout.PREFERRED_SIZE, 139, GroupLayout.PREFERRED_SIZE)
				            .addComponent(getEInst(), GroupLayout.Alignment.LEADING, 0, 139, Short.MAX_VALUE))
				        .addPreferredGap(LayoutStyle.ComponentPlacement.UNRELATED)
				        .addGroup(thisLayout.createParallelGroup()
				            .addComponent(getBtnInstalacion(), GroupLayout.Alignment.LEADING, 0, 95, Short.MAX_VALUE)
				            .addGroup(thisLayout.createSequentialGroup()
				                .addGap(0, 0, Short.MAX_VALUE)
				                .addComponent(BtnRegistrarSolicitud, GroupLayout.PREFERRED_SIZE, 95, GroupLayout.PREFERRED_SIZE))
				            .addGroup(thisLayout.createSequentialGroup()
				                .addGap(0, 0, Short.MAX_VALUE)
				                .addComponent(BtnRegSofteware, GroupLayout.PREFERRED_SIZE, 95, GroupLayout.PREFERRED_SIZE)))
				        .addGap(60))
				    .addComponent(jSeparator1, GroupLayout.Alignment.LEADING, 0, 629, Short.MAX_VALUE)
				    .addComponent(jTabbedPane1, GroupLayout.Alignment.LEADING, 0, 629, Short.MAX_VALUE))
				.addContainerGap());
			thisLayout.linkSize(SwingConstants.VERTICAL, new Component[] {BtnRegistrarSolicitud, BtnRegSofteware, BtnRTecnico, BtnRegCliente, BtnRegComputadora});
			thisLayout.linkSize(SwingConstants.HORIZONTAL, new Component[] {BtnRegistrarSolicitud, BtnRegSofteware, BtnRTecnico, BtnRegCliente, BtnRegComputadora});
			pack();
			this.setSize(671, 506);
		} catch (Exception e) {
		    //add your error handling code here
			e.printStackTrace();
		}
	}
	
	private AbstractAction getFnBtnRegistarTec() {
		if(fnBtnRegistarTec == null) {
			fnBtnRegistarTec = new AbstractAction("Registrar", null) {
				public void actionPerformed(ActionEvent evt) {
					PantallaTecnicoRegistrar l;
					l = new PantallaTecnicoRegistrar();
					l.setLocationRelativeTo(null);
					l.setVisible(true);
				}
			};
		}
		return fnBtnRegistarTec;
	}
	
	private AbstractAction getFnBtnRegistarClien() {
		if(fnBtnRegistarClien == null) {
			fnBtnRegistarClien = new AbstractAction("Registrar", null) {
				public void actionPerformed(ActionEvent evt) {
					PantallaClienteRegistrar l;
					l = new PantallaClienteRegistrar(PantallaPrincipal.this);
					l.setLocationRelativeTo(null);
					l.setVisible(true);
				}
			};
		}
		return fnBtnRegistarClien;
	}
	
	private AbstractAction getFnBtnRegistarPC() {
		if(fnBtnRegistarPC == null) {
			fnBtnRegistarPC = new AbstractAction("Registrar", null) {
				public void actionPerformed(ActionEvent evt) {
					PantallaComputadoraRegistrar l;
					l = new PantallaComputadoraRegistrar();
					l.setLocationRelativeTo(null);
					l.setVisible(true);
				}
			};
		}
		return fnBtnRegistarPC;
	}
	
	private AbstractAction getFnBtnRegistarSoft() {
		if(fnBtnRegistarSoft == null) {
			fnBtnRegistarSoft = new AbstractAction("Registrar", null) {
				public void actionPerformed(ActionEvent evt) {
					PantallaSoftwareRegistrar l;
					l = new PantallaSoftwareRegistrar();
					l.setLocationRelativeTo(null);
					l.setVisible(true);
				}
			};
		}
		return fnBtnRegistarSoft;
	}
	
	private AbstractAction getFnBtnRegistarSolic() {
		if(fnBtnRegistarSolic == null) {
			fnBtnRegistarSolic = new AbstractAction("Registrar", null) {
				public void actionPerformed(ActionEvent evt) {
					PantallaSolicitudRegistrar l;
					l = new PantallaSolicitudRegistrar();
					l.setLocationRelativeTo(null);
					l.setVisible(true);
				}
			};
		}
		return fnBtnRegistarSolic;
	}
	
	private JPanel getTabSolicitudes() {
		if(tabSolicitudes == null) {
			tabSolicitudes = new JPanel();
			GroupLayout tabSolicitudesLayout = new GroupLayout((JComponent)tabSolicitudes);
			tabSolicitudes.setLayout(tabSolicitudesLayout);
			tabSolicitudesLayout.setHorizontalGroup(tabSolicitudesLayout.createSequentialGroup()
				.addGap(7)
				.addGroup(tabSolicitudesLayout.createParallelGroup()
				    .addGroup(GroupLayout.Alignment.LEADING, tabSolicitudesLayout.createSequentialGroup()
				        .addComponent(getEEstado(), GroupLayout.PREFERRED_SIZE, 54, GroupLayout.PREFERRED_SIZE)
				        .addGap(17)
				        .addComponent(getCbEstado(), GroupLayout.PREFERRED_SIZE, 136, GroupLayout.PREFERRED_SIZE)
				        .addGap(319)
				        .addGroup(tabSolicitudesLayout.createParallelGroup()
				            .addGroup(GroupLayout.Alignment.LEADING, tabSolicitudesLayout.createSequentialGroup()
				                .addGap(0, 0, Short.MAX_VALUE)
				                .addComponent(getBtnEliminarSoli(), GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE))
				            .addGroup(tabSolicitudesLayout.createSequentialGroup()
				                .addComponent(getBtnBuscar(), GroupLayout.PREFERRED_SIZE, 79, GroupLayout.PREFERRED_SIZE)
				                .addGap(0, 0, Short.MAX_VALUE))))
				    .addComponent(getJScrollPane1(), GroupLayout.Alignment.LEADING, 0, 605, Short.MAX_VALUE))
				.addContainerGap());
			tabSolicitudesLayout.setVerticalGroup(tabSolicitudesLayout.createSequentialGroup()
				.addContainerGap()
				.addGroup(tabSolicitudesLayout.createParallelGroup(GroupLayout.Alignment.BASELINE)
				    .addComponent(getBtnBuscar(), GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE)
				    .addComponent(getEEstado(), GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, 24, GroupLayout.PREFERRED_SIZE)
				    .addComponent(getCbEstado(), GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE))
				.addPreferredGap(LayoutStyle.ComponentPlacement.RELATED)
				.addComponent(getJScrollPane1(), GroupLayout.PREFERRED_SIZE, 166, GroupLayout.PREFERRED_SIZE)
				.addPreferredGap(LayoutStyle.ComponentPlacement.RELATED, 0, GroupLayout.PREFERRED_SIZE)
				.addComponent(getBtnEliminarSoli(), GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE)
				.addPreferredGap(LayoutStyle.ComponentPlacement.RELATED, 0, Short.MAX_VALUE));
		}
		return tabSolicitudes;
	}

	private JPanel getTabComputadoras() {
		if(tabComputadoras == null) {
			tabComputadoras = new JPanel();
			GroupLayout tabComputadorasLayout = new GroupLayout((JComponent)tabComputadoras);
			tabComputadoras.setLayout(tabComputadorasLayout);
			tabComputadorasLayout.setHorizontalGroup(tabComputadorasLayout.createSequentialGroup()
				.addContainerGap()
				.addGroup(tabComputadorasLayout.createParallelGroup()
				    .addGroup(GroupLayout.Alignment.LEADING, tabComputadorasLayout.createSequentialGroup()
				        .addComponent(getECliente(), GroupLayout.PREFERRED_SIZE, 71, GroupLayout.PREFERRED_SIZE)
				        .addPreferredGap(LayoutStyle.ComponentPlacement.RELATED)
				        .addComponent(getJbIdCliente(), GroupLayout.PREFERRED_SIZE, 163, GroupLayout.PREFERRED_SIZE)
				        .addGap(233))
				    .addComponent(getJScrollPane3(), GroupLayout.Alignment.LEADING, GroupLayout.PREFERRED_SIZE, 472, GroupLayout.PREFERRED_SIZE))
				.addGap(18)
				.addGroup(tabComputadorasLayout.createParallelGroup()
				    .addGroup(tabComputadorasLayout.createSequentialGroup()
				        .addGap(0, 0, Short.MAX_VALUE)
				        .addComponent(getBtnBuscarPC(), GroupLayout.PREFERRED_SIZE, 110, GroupLayout.PREFERRED_SIZE))
				    .addComponent(getBtnSelecPC(), GroupLayout.Alignment.LEADING, 0, 110, Short.MAX_VALUE))
				.addContainerGap());
			tabComputadorasLayout.linkSize(SwingConstants.HORIZONTAL, new Component[] {getBtnSelecPC(), getBtnBuscarPC()});
			tabComputadorasLayout.setVerticalGroup(tabComputadorasLayout.createSequentialGroup()
				.addContainerGap()
				.addGroup(tabComputadorasLayout.createParallelGroup(GroupLayout.Alignment.BASELINE)
				    .addComponent(getBtnBuscarPC(), GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE)
				    .addComponent(getECliente(), GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE)
				    .addComponent(getJbIdCliente(), GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE))
				.addGap(37)
				.addGroup(tabComputadorasLayout.createParallelGroup()
				    .addComponent(getJScrollPane3(), GroupLayout.Alignment.LEADING, 0, 156, Short.MAX_VALUE)
				    .addGroup(GroupLayout.Alignment.LEADING, tabComputadorasLayout.createSequentialGroup()
				        .addGap(0, 131, Short.MAX_VALUE)
				        .addComponent(getBtnSelecPC(), GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE)))
				.addContainerGap());
		}
		return tabComputadoras;
	}
	
	private JPanel getTabTecnicos() {
		if(tabTecnicos == null) {
			tabTecnicos = new JPanel();
			GroupLayout tabTecnicosLayout = new GroupLayout((JComponent)tabTecnicos);
			tabTecnicos.setLayout(tabTecnicosLayout);
			tabTecnicosLayout.setHorizontalGroup(tabTecnicosLayout.createSequentialGroup()
				.addGap(7)
				.addGroup(tabTecnicosLayout.createParallelGroup()
				    .addComponent(getJScrollPane2(), GroupLayout.Alignment.LEADING, 0, 559, Short.MAX_VALUE)
				    .addGroup(GroupLayout.Alignment.LEADING, tabTecnicosLayout.createSequentialGroup()
				        .addGap(0, 310, Short.MAX_VALUE)
				        .addComponent(getBtnSeleccionar(), GroupLayout.PREFERRED_SIZE, 115, GroupLayout.PREFERRED_SIZE)
				        .addPreferredGap(LayoutStyle.ComponentPlacement.UNRELATED, 1, GroupLayout.PREFERRED_SIZE)
				        .addComponent(getBtnBuscarTodos(), GroupLayout.PREFERRED_SIZE, 122, GroupLayout.PREFERRED_SIZE)))
				.addContainerGap());
			tabTecnicosLayout.setVerticalGroup(tabTecnicosLayout.createSequentialGroup()
				.addContainerGap()
				.addComponent(getJScrollPane2(), GroupLayout.PREFERRED_SIZE, 174, GroupLayout.PREFERRED_SIZE)
				.addPreferredGap(LayoutStyle.ComponentPlacement.UNRELATED)
				.addGroup(tabTecnicosLayout.createParallelGroup(GroupLayout.Alignment.BASELINE)
				    .addComponent(getBtnBuscarTodos(), GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE)
				    .addComponent(getBtnSeleccionar(), GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, 25, GroupLayout.PREFERRED_SIZE))
				.addContainerGap(19, 19));
		}
		return tabTecnicos;
	}
	
	private JLabel getEEstado() {
		if(eEstado == null) {
			eEstado = new JLabel();
			eEstado.setText("Estado: ");
		}
		return eEstado;
	}
	
	private JComboBox getCbEstado() {
		if(CbEstado == null) {
			ComboBoxModel CbEstadoModel = 
					new DefaultComboBoxModel(
							new String[] {"----Seleccionar----", "Pendiente", "Finalizado" });
			CbEstado = new JComboBox();
			CbEstado.setModel(CbEstadoModel);
		}
		return CbEstado;
	}
	
	private JButton getBtnBuscar() {
		if(btnBuscar == null) {
			btnBuscar = new JButton();
			btnBuscar.setText("Buscar");
			btnBuscar.setAction(getFnBtnBuscarSolicitud());
		}
		return btnBuscar;
	}
	
	private JTable getTResulSolicitudes() {
		if(tResulSolicitudes == null) {
			TableModel tResulSolicitudesModel = 
					new DefaultTableModel(
							new String[][] { },
							new String[] { "Código","Tipo" ,"Fecha Recepción","Fecha Entrega", "Condición","Pc","Software","Técnico","Cliente" });
			tResulSolicitudes = new JTable();
			tResulSolicitudes.setModel(tResulSolicitudesModel);
		}
		return tResulSolicitudes;
	}
	
	private JScrollPane getJScrollPane1() {
		if(jScrollPane1 == null) {
			jScrollPane1 = new JScrollPane();
			jScrollPane1.setViewportView(getTResulSolicitudes());
		}
		return jScrollPane1;
	}
	
	private JButton getBtnEliminarSoli() {
		if(btnEliminarSoli == null) {
			btnEliminarSoli = new JButton();
			btnEliminarSoli.setText("Eliminar");
			btnEliminarSoli.setAction(getFnBtnEliminarSolicitud());
		}
		return btnEliminarSoli;
	}
	
	private JButton getBtnBuscarTodos() {
		if(btnBuscarTodos == null) {
			btnBuscarTodos = new JButton();
			btnBuscarTodos.setText("Buscar Todos");
			btnBuscarTodos.setAction(getFnBtnBuscarTecnicos());
		}
		return btnBuscarTodos;
	}
	
	private JTable getTResulTecnicos() {
		if(tResulTecnicos == null) {
			TableModel tResulTecnicosModel = 
					new DefaultTableModel(
							new String[][] {  },
							new String[] { "Identificación", "Nombre", "Apellido", "E-Mail" });
			tResulTecnicos = new JTable();
			tResulTecnicos.setModel(tResulTecnicosModel);
		}
		return tResulTecnicos;
	}
	
	private JScrollPane getJScrollPane2() {
		if(jScrollPane2 == null) {
			jScrollPane2 = new JScrollPane();
			jScrollPane2.setViewportView(getTResulTecnicos());
		}
		return jScrollPane2;
	}
	
	private JButton getBtnSeleccionar() {
		if(btnSeleccionar == null) {
			btnSeleccionar = new JButton();
			btnSeleccionar.setText("Seleccionar");
			btnSeleccionar.setAction(getFnBtnSeleccionarTecnico());
		}
		return btnSeleccionar;
	}
	
	private JLabel getECliente() {
		if(eCliente == null) {
			eCliente = new JLabel();
			eCliente.setText("Cliente:");
		}
		return eCliente;
	}
	
	private JComboBox getJbIdCliente() {
		if(jbIdCliente == null) {
			jbIdCliente = new JComboBox();
			obtenerDuennos();
		}
		return jbIdCliente;
	}
	
	private JButton getBtnBuscarPC() {
		if(btnBuscarPC == null) {
			btnBuscarPC = new JButton();
			btnBuscarPC.setText("Buscar");
			btnBuscarPC.setAction(getFnBtnBuscarPc());
		}
		return btnBuscarPC;
	}
	
	private JTable getTResulPc() {
		if(tResulPc == null) {
			TableModel tResulPcModel = 
					new DefaultTableModel(
							new String[][] { },
							new String[] { "Número de Serie", "Modelo", "Marca"});
			tResulPc = new JTable();
			tResulPc.setModel(tResulPcModel);
		}
		return tResulPc;
	}
	
	private JScrollPane getJScrollPane3() {
		if(jScrollPane3 == null) {
			jScrollPane3 = new JScrollPane();
			jScrollPane3.setViewportView(getTResulPc());
		}
		return jScrollPane3;
	}
	
	private JButton getBtnSelecPC() {
		if(btnSelecPC == null) {
			btnSelecPC = new JButton();
			btnSelecPC.setText("Seleccionar");
			btnSelecPC.setAction(getFnBtnSelecionarPC());
		}
		return btnSelecPC;
	}
	
	private JButton getBtnModificarP() {
		if(btnModificarP == null) {
			btnModificarP = new JButton();
			btnModificarP.setText("Modificar Parametros");
			btnModificarP.setAction(getFnBtnModificarP());
		}
		return btnModificarP;
	}
	
	private void obtenerResultadosSolicitudes(){
		Vector datos=null;
		String[][] resul=null;
		TreeMap dato=null;
		if(!CbEstado.getSelectedItem().equals("----Seleccionar----")){
			try {
				datos=gestor.consultarSolicitudesCondicionEs((String)CbEstado.getSelectedItem());
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
				tResulSolicitudes.setModel(new DefaultTableModel(resul,	new String[] { "Código","Tipo" ,"Fecha Recepción","Fecha Entrega", "Condición","Pc","Software","Técnico","Cliente" }));

			}
			catch (Exception ex) {
				JOptionPane.showMessageDialog(this,(String) ex.getMessage(),"Error",JOptionPane.ERROR_MESSAGE);	
				tResulSolicitudes.setModel(new DefaultTableModel(new String[][] { }, new String[] { "Código","Tipo" ,"Fecha Recepción","Fecha Entrega", "Condición","Pc","Software","Técnico","Cliente" }));
				resulListSolicitudes=null;
			}
		}else{
			JOptionPane.showMessageDialog(null,"Debe seleccionar un estado.","Error", JOptionPane.ERROR_MESSAGE);
		}
		
	}
	
	private AbstractAction getFnBtnBuscarSolicitud() {
		if(FnBtnBuscarSolicitud == null) {
			FnBtnBuscarSolicitud = new AbstractAction("Buscar", null) {
				public void actionPerformed(ActionEvent evt) {
						obtenerResultadosSolicitudes();
				}
			};
		}
		return FnBtnBuscarSolicitud;
	}
	
	private AbstractAction getFnBtnEliminarSolicitud() {
		if(FnBtnEliminarSolicitud == null) {
			FnBtnEliminarSolicitud = new AbstractAction("Eliminar", null) {
				public void actionPerformed(ActionEvent evt) {
					if(resulListSolicitudes!=null){
						try{
							int cod=Integer.parseInt(resulListSolicitudes[tResulSolicitudes.getSelectedRow()][0]);
							String[][] resul=new String[resulListSolicitudes.length-1][resulListSolicitudes[0].length];
							int y=0;
							for(int i=0;i<resulListSolicitudes.length;i++){
								if(i!=tResulSolicitudes.getSelectedRow()){
									for(int t=0;t<resulListSolicitudes[0].length;t++){	
										resul[y][t]=resulListSolicitudes[i][t];
									}
									y++;
								}
							}
							resulListSolicitudes=resul;
							gestor.borrarSolicitud(cod);
							tResulSolicitudes.setModel(new DefaultTableModel(resul,new String[] { "Código","Tipo" ,"Fecha Recepción","Fecha Entrega", "Condición","Técnico","Cliente" })) ;
							JOptionPane.showMessageDialog(null,"Solicitud borrada Satisfactoriamente.","Borrar Solicitud",JOptionPane.INFORMATION_MESSAGE);						
						}
						catch (Exception ex){
							JOptionPane.showMessageDialog(null,(String) ex.getMessage(),"No se ha seleccionado un resultado",JOptionPane.ERROR_MESSAGE);
						}
					}else{
						JOptionPane.showMessageDialog(null,"Debe de hacer una busqueda para eliminar una Solicitud.","Error", JOptionPane.ERROR_MESSAGE);
					}
				}
			};
		}
		return FnBtnEliminarSolicitud;
	}
	
	private void obtenerResultadosTecnicos(){
		Vector datos=null;
		String[][] resul=null;
		TreeMap dato=null;
		try {
			datos=gestor.tecnicoBuscarTodos();
			resul=new String[datos.size()][4];
			for(int i=0;i<datos.size();i++){
				dato=(TreeMap) datos.get(i);
				resul[i][0]=""+dato.get("id");
				resul[i][1]=(String)dato.get("nom");
				resul[i][2]=(String)dato.get("apell");
				resul[i][3]=(String)dato.get("mail");
			}
			resulListTecnicos=resul;
			tResulTecnicos.setModel(new DefaultTableModel(resul,new String[] { "Identificación", "Nombre", "Apellido", "E-Mail" }));
		}
		catch (Exception ex) {
			JOptionPane.showMessageDialog(this,(String) ex.getMessage(),"Error",JOptionPane.ERROR_MESSAGE);	
			tResulTecnicos.setModel(new DefaultTableModel(new String[][] {  },new String[] { "Identificación", "Nombre", "Apellido", "E-Mail" }));
			resulListTecnicos=null;
		}
		
	}
	
	private AbstractAction getFnBtnBuscarTecnicos() {
		if(FnBtnBuscarTecnicos == null) {
			FnBtnBuscarTecnicos = new AbstractAction("Buscar Todos", null) {
				public void actionPerformed(ActionEvent evt) {
					obtenerResultadosTecnicos();
				}
			};
		}
		return FnBtnBuscarTecnicos;
	}
	
	private AbstractAction getFnBtnSeleccionarTecnico() {
		if(FnBtnSeleccionarTecnico == null) {
			FnBtnSeleccionarTecnico = new AbstractAction("Seleccionar", null) {
				public void actionPerformed(ActionEvent evt) {
					if(resulListTecnicos!=null){	
						try{
							int cod=Integer.parseInt(resulListTecnicos[tResulTecnicos.getSelectedRow()][0]);
							PantallaTecnicoSolicitudes m;
							m=new PantallaTecnicoSolicitudes(cod);
							m.setLocationRelativeTo(null);
							m.setVisible(true);
							
						}
						catch (Exception ex){
							JOptionPane.showMessageDialog(null,(String) ex.getMessage(),"No se ha seleccionado un Técnico",JOptionPane.ERROR_MESSAGE);
						}
					}else{
						JOptionPane.showMessageDialog(null,"Debe de hacer una busqueda para seleccionar un Técnico.","Error", JOptionPane.ERROR_MESSAGE);
					}
				}
			};
		}
		return FnBtnSeleccionarTecnico;
	}
	
	public void obtenerDuennos(){
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
			jbIdCliente.setModel(new DefaultComboBoxModel(resul));
		} catch (Exception e) {
			resul=new String[1];
			resul[0]="---Selccionar---";
			jbIdCliente.setModel(new DefaultComboBoxModel(resul));
			JOptionPane.showMessageDialog(null,(String) e.getMessage(),"Error",JOptionPane.ERROR_MESSAGE);
		}
	}
	
	private void obtenerResultadosPc(){
		Vector datos=null;
		String[][] resul=null;
		TreeMap dato=null;
		if(!jbIdCliente.getSelectedItem().equals("---Selccionar---")){
			try {
				TreeMap d=(TreeMap)duennos.get(jbIdCliente.getSelectedIndex()-1);
				datos=gestor.consultarPcCliente(Integer.parseInt(""+d.get("id")));
				resul=new String[datos.size()][3];
				for(int i=0;i<datos.size();i++){
					dato=(TreeMap) datos.get(i);
					resul[i][0]=""+dato.get("serie");
					resul[i][1]=(String)dato.get("modelo");
					resul[i][2]=(String)dato.get("marca");
				}
				resulListPc=resul;
				tResulPc.setModel(new DefaultTableModel(resul,new String[] { "Número de Serie", "Modelo", "Marca"}));
			}
			catch (Exception ex) {
				JOptionPane.showMessageDialog(this,(String) ex.getMessage(),"Error",JOptionPane.ERROR_MESSAGE);	
				tResulPc.setModel(new DefaultTableModel(new String[][] {  },new String[] { "Número de Serie", "Modelo", "Marca"}));
				resulListPc=null;
			}
		}else{
			JOptionPane.showMessageDialog(null,"Debe seleccionar un Cliente","Error",JOptionPane.ERROR_MESSAGE);	

		}
		
	}
	
	private AbstractAction getFnBtnBuscarPc() {
		if(FnBtnBuscarPc == null) {
			FnBtnBuscarPc = new AbstractAction("Buscar", null) {
				public void actionPerformed(ActionEvent evt) {
					obtenerResultadosPc();
				}
			};
		}
		return FnBtnBuscarPc;
	}
	
	private JPanel getTabParametros() {
		if(tabParametros == null) {
			tabParametros = new JPanel();
			GroupLayout tabParametrosLayout = new GroupLayout((JComponent)tabParametros);
			tabParametros.setLayout(tabParametrosLayout);
			tabParametrosLayout.setHorizontalGroup(tabParametrosLayout.createSequentialGroup()
				.addContainerGap()
				.addGroup(tabParametrosLayout.createParallelGroup()
				    .addGroup(tabParametrosLayout.createSequentialGroup()
				        .addGroup(tabParametrosLayout.createParallelGroup()
				            .addComponent(getECantSoliciXTecnico(), GroupLayout.Alignment.LEADING, GroupLayout.PREFERRED_SIZE, 310, GroupLayout.PREFERRED_SIZE)
				            .addComponent(getECantDiasUrgente(), GroupLayout.Alignment.LEADING, GroupLayout.PREFERRED_SIZE, 310, GroupLayout.PREFERRED_SIZE)
				            .addComponent(getECantDiasNormal(), GroupLayout.Alignment.LEADING, GroupLayout.PREFERRED_SIZE, 310, GroupLayout.PREFERRED_SIZE))
				        .addGap(22)
				        .addGroup(tabParametrosLayout.createParallelGroup()
				            .addGroup(GroupLayout.Alignment.LEADING, tabParametrosLayout.createSequentialGroup()
				                .addComponent(getEValorA(), GroupLayout.PREFERRED_SIZE, 105, GroupLayout.PREFERRED_SIZE)
				                .addGap(57)
				                .addGroup(tabParametrosLayout.createParallelGroup()
				                    .addGroup(tabParametrosLayout.createSequentialGroup()
				                        .addComponent(getENValores(), GroupLayout.PREFERRED_SIZE, 99, GroupLayout.PREFERRED_SIZE)
				                        .addGap(0, 0, Short.MAX_VALUE))
				                    .addGroup(tabParametrosLayout.createSequentialGroup()
				                        .addGap(24)
				                        .addGroup(tabParametrosLayout.createParallelGroup()
				                            .addGroup(tabParametrosLayout.createSequentialGroup()
				                                .addComponent(getTxtValST(), GroupLayout.PREFERRED_SIZE, 42, GroupLayout.PREFERRED_SIZE))
				                            .addGroup(tabParametrosLayout.createSequentialGroup()
				                                .addComponent(getTxtValU(), GroupLayout.PREFERRED_SIZE, 42, GroupLayout.PREFERRED_SIZE))
				                            .addGroup(tabParametrosLayout.createSequentialGroup()
				                                .addComponent(getTxtValN(), GroupLayout.PREFERRED_SIZE, 42, GroupLayout.PREFERRED_SIZE)))
				                        .addGap(0, 33, Short.MAX_VALUE)))
				                .addGap(7))
				            .addGroup(GroupLayout.Alignment.LEADING, tabParametrosLayout.createSequentialGroup()
				                .addGap(24)
				                .addGroup(tabParametrosLayout.createParallelGroup()
				                    .addComponent(getPCantMST(), GroupLayout.Alignment.LEADING, GroupLayout.PREFERRED_SIZE, 42, GroupLayout.PREFERRED_SIZE)
				                    .addComponent(getPCantDU(), GroupLayout.Alignment.LEADING, GroupLayout.PREFERRED_SIZE, 42, GroupLayout.PREFERRED_SIZE)
				                    .addComponent(getPCantDN(), GroupLayout.Alignment.LEADING, GroupLayout.PREFERRED_SIZE, 42, GroupLayout.PREFERRED_SIZE))
				                .addGap(0, 27, Short.MAX_VALUE)
				                .addComponent(getBtnModificarP(), GroupLayout.PREFERRED_SIZE, 175, GroupLayout.PREFERRED_SIZE))))
				    .addGroup(GroupLayout.Alignment.LEADING, tabParametrosLayout.createSequentialGroup()
				        .addGap(227)
				        .addComponent(getEParametros(), GroupLayout.PREFERRED_SIZE, 171, GroupLayout.PREFERRED_SIZE)
				        .addGap(0, 202, Short.MAX_VALUE)))
				.addContainerGap());
			tabParametrosLayout.linkSize(SwingConstants.HORIZONTAL, new Component[] {getTxtValST(), getPCantMST(), getPCantDU(), getPCantDN(), getTxtValU(), getTxtValN()});
			tabParametrosLayout.setVerticalGroup(tabParametrosLayout.createSequentialGroup()
				.addContainerGap()
				.addComponent(getEParametros(), GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE)
				.addGap(7)
				.addGroup(tabParametrosLayout.createParallelGroup(GroupLayout.Alignment.BASELINE)
				    .addComponent(getENValores(), GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE)
				    .addComponent(getEValorA(), GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE))
				.addPreferredGap(LayoutStyle.ComponentPlacement.UNRELATED)
				.addGroup(tabParametrosLayout.createParallelGroup()
				    .addGroup(GroupLayout.Alignment.LEADING, tabParametrosLayout.createParallelGroup(GroupLayout.Alignment.BASELINE)
				        .addComponent(getTxtValN(), GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE)
				        .addComponent(getECantDiasNormal(), GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE))
				    .addGroup(GroupLayout.Alignment.LEADING, tabParametrosLayout.createSequentialGroup()
				        .addComponent(getPCantDN(), GroupLayout.PREFERRED_SIZE, 16, GroupLayout.PREFERRED_SIZE)
				        .addGap(6)))
				.addGap(28)
				.addGroup(tabParametrosLayout.createParallelGroup()
				    .addGroup(GroupLayout.Alignment.LEADING, tabParametrosLayout.createParallelGroup(GroupLayout.Alignment.BASELINE)
				        .addComponent(getTxtValU(), GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE)
				        .addComponent(getECantDiasUrgente(), GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE))
				    .addGroup(GroupLayout.Alignment.LEADING, tabParametrosLayout.createSequentialGroup()
				        .addComponent(getPCantDU(), GroupLayout.PREFERRED_SIZE, 16, GroupLayout.PREFERRED_SIZE)
				        .addGap(6)))
				.addGap(27)
				.addGroup(tabParametrosLayout.createParallelGroup()
				    .addGroup(GroupLayout.Alignment.LEADING, tabParametrosLayout.createParallelGroup(GroupLayout.Alignment.BASELINE)
				        .addComponent(getTxtValST(), GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE)
				        .addComponent(getECantSoliciXTecnico(), GroupLayout.Alignment.BASELINE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE))
				    .addGroup(GroupLayout.Alignment.LEADING, tabParametrosLayout.createSequentialGroup()
				        .addComponent(getPCantMST(), GroupLayout.PREFERRED_SIZE, 16, GroupLayout.PREFERRED_SIZE)
				        .addGap(6)))
				.addGap(0, 20, Short.MAX_VALUE)
				.addComponent(getBtnModificarP(), GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE, GroupLayout.PREFERRED_SIZE)
				.addContainerGap());
		}
		return tabParametros;
	}
	
	private JLabel getEParametros() {
		if(eParametros == null) {
			eParametros = new JLabel();
			eParametros.setText("Parametros del Sistema");
		}
		return eParametros;
	}
	
	private JLabel getECantDiasNormal() {
		if(eCantDiasNormal == null) {
			eCantDiasNormal = new JLabel();
			eCantDiasNormal.setText("Cantidad de Días para Solicitudes de Tipo Normal: ");
		}
		return eCantDiasNormal;
	}
	
	private JLabel getECantDiasUrgente() {
		if(eCantDiasUrgente == null) {
			eCantDiasUrgente = new JLabel();
			eCantDiasUrgente.setText("Cantidad de Días para Solicitudes de Tipo Urgente: ");
		}
		return eCantDiasUrgente;
	}
	
	private JLabel getECantSoliciXTecnico() {
		if(eCantSoliciXTecnico == null) {
			eCantSoliciXTecnico = new JLabel();
			eCantSoliciXTecnico.setText("Cantidad Maxima de Solicitudes por Técnico: ");
		}
		return eCantSoliciXTecnico;
	}
	
	private JLabel getPCantDN() {
		if(pCantDN == null) {
			pCantDN = new JLabel();
		}
		return pCantDN;
	}
	
	private JLabel getPCantDU() {
		if(pCantDU == null) {
			pCantDU = new JLabel();
		}
		return pCantDU;
	}
	
	private JLabel getPCantMST() {
		if(pCantMST == null) {
			pCantMST = new JLabel();
		}
		return pCantMST;
	}
	
	private AbstractAction getFnBtnSelecionarPC() {
		if(FnBtnSelecionarPC == null) {
			FnBtnSelecionarPC = new AbstractAction("Seleccionar", null) {
				public void actionPerformed(ActionEvent evt) {
					if(tResulPc!=null){	
						try{
							int cod=Integer.parseInt(resulListPc[tResulPc.getSelectedRow()][0]);
							PantallaComputadoraSoftware m;
							m=new PantallaComputadoraSoftware(cod);
							m.setLocationRelativeTo(null);
							m.setVisible(true);
							
						}
						catch (Exception ex){
							JOptionPane.showMessageDialog(null,(String) ex.getMessage(),"No se ha seleccionado una Computadora",JOptionPane.ERROR_MESSAGE);
						}
					}else{
						JOptionPane.showMessageDialog(null,"Debe de hacer una busqueda para seleccionar una Computadora.","Error", JOptionPane.ERROR_MESSAGE);
					}
				}
			};
		}
		return FnBtnSelecionarPC;
	}
	
	public void obtenerParametros(){
		try {
			Parametro p= gestor.consultarParametros();
			pCantDN.setText(""+p.getDiasDemoraNormal());
			txtValN.setText(""+p.getDiasDemoraNormal());
			pCantDU.setText(""+p.getDiasDemoraUrgente());
			txtValU.setText(""+p.getDiasDemoraUrgente());
			pCantMST.setText(""+p.getCantSolicitudesTecnicoPendiente());
			txtValST.setText(""+p.getCantSolicitudesTecnicoPendiente());
		} catch (Exception e) {
			JOptionPane.showMessageDialog(null,(String) e.getMessage(),"Error",JOptionPane.ERROR_MESSAGE);
		}
	}
	
	private AbstractAction getFnBtnModificarP() {
		if(FnBtnModificarP == null) {
			FnBtnModificarP = new AbstractAction("Modificar Parametros", null) {
				public void actionPerformed(ActionEvent evt) {
					try {
						gestor.parametroModificar(Integer.parseInt(txtValN.getText()), Integer.parseInt(txtValU.getText()), Integer.parseInt(txtValST.getText()));
						obtenerParametros();
						JOptionPane.showMessageDialog(null,"Parametros modificados Correctamente","Modificar Parametros",JOptionPane.INFORMATION_MESSAGE);

					} catch (Exception e) {
						JOptionPane.showMessageDialog(null,(String) e.getMessage(),"Error",JOptionPane.ERROR_MESSAGE);
					}
				}
			};
		}
		return FnBtnModificarP;
	}
	
	private JLabel getEValorA() {
		if(eValorA == null) {
			eValorA = new JLabel();
			eValorA.setText("Valores Actuales");
		}
		return eValorA;
	}
	
	private JLabel getENValores() {
		if(eNValores == null) {
			eNValores = new JLabel();
			eNValores.setText("Nuevos Valores");
		}
		return eNValores;
	}
	
	private JTextField getTxtValN() {
		if(txtValN == null) {
			txtValN = new JTextField();
		}
		return txtValN;
	}
	
	private JTextField getTxtValU() {
		if(txtValU == null) {
			txtValU = new JTextField();
		}
		return txtValU;
	}
	
	private JTextField getTxtValST() {
		if(txtValST == null) {
			txtValST = new JTextField();
		}
		return txtValST;
	}
	
	private JButton getBtnInstalacion() {
		if(btnInstalacion == null) {
			btnInstalacion = new JButton();
			btnInstalacion.setText("Registrar");
			btnInstalacion.setAction(getFnBtnActu());
		}
		return btnInstalacion;
	}
	
	private AbstractAction getFnBtnActu() {
		if(FnBtnActu == null) {
			FnBtnActu = new AbstractAction("Registrar", null) {
				public void actionPerformed(ActionEvent evt) {
					PantallaInstalacion inst = new PantallaInstalacion();
					inst.setLocationRelativeTo(null);
					inst.setVisible(true);
				}
			};
		}
		return FnBtnActu;
	}
	
	private JLabel getEInst() {
		if(eInst == null) {
			eInst = new JLabel();
			eInst.setText("Instalación:");
		}
		return eInst;
	}

}
