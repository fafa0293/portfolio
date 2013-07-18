<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPage.master" CodeBehind="Ayuda.aspx.vb" Inherits="AppWeb.ayuda" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="SidebarContent" runat="server">
    <ul id="lista-ayuda" class="well navbar-horizontal pull-left">
        <li><a href="#ayuda-1">Asignar Estudiante a un Grupo</a></li>
        <li><a href="#ayuda-2">Asignar Profesor a un Grupo</a></li>
        <li><a href="#ayuda-3">Buscar Grupo</a></li>    
        <li><a href="#ayuda-4">Eliminar Grupo</a></li>
        <li><a href="#ayuda-5">Listar Cursos</a></li>
        <li><a href="#ayuda-6">Listar Grupo</a></li>
        <li><a href="#ayuda-7">Modificar Tema</a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
<div id="contenedor-ayuda">
    <div id="placeholder">
        <p class="center">
            Para ver el contenido de la ayuda, seleccione una secci&oacute;n del men&uacute; de la izquierda.
        </p>
    </div>
    <div id="ayuda-1">
        <h1>Asignar Estudiante a un Grupo</h1>
        <p>¿D&oacute;nde encuentro la funcionalidad de Asignar Estudiante a un Grupo?</p>
            <a href="AsignarEstudianteAGrupo.aspx">Ir a Funcionalidad: Asignar Estudiante a un Grupo</a>
        <br/><br/>
        <p>¿Cu&aacute;ndo ingreso no hay estudiantes registrados?</p>
        <img src="img/imagenesAyuda/errorUsuario.png" />
        <p>
            <br />Paso 1: Ingrese a la funcionalidad: Registrar Usuario.
            <br />Nota: Esta funcionalidad se encuentra en la aplicaci&oacute;n local.
            <br />
            <br />Paso 2: Luego de haber registrado al usuario satistfactoriamente ingrese a la funcionalidad: Asignar Rol a Usuario
            <br />Paso 3: Asignele al usuario seleccionado el usuario de Estudiante.
            <br /><font color="#FF0000">*</font>Nota: Esta funcionalidad se encuentra en la aplicaci&oacute;n local.    
            <br />  
        </p>
    </div>
    <div id="ayuda-2">
        <h1>Asignar Profesor a un Grupo</h1>
        <p>¿D&oacute;nde encuentro la funcionalidad de Asignar Estudiante a un Grupo?</p>
            <a href="AsignarProfeAGrupo.aspx">Ir a Funcionalidad: Asignar Profesor a un Grupo</a>
        <br/><br/>
        <p>¿Cu&aacute;ndo ingreso no hay profesores registrados?</p>
        <img src="img/imagenesAyuda/errorProfesor.png" />
        <p>
            <br />Paso 1: Ingrese a la funcionalidad: Registrar Usuario.
            <br />Nota: Esta funcionalidad se encuentra en la aplicaci&oacute;n local.
            <br />
            <br />Paso 2: Luego de haber registrado al usuario satistfactoriamente ingrese a la funcionalidad: Asignar Rol a Usuario
            <br />Paso 3: Asignele al usuario seleccionado el Rol de Profesor.
            <br /><font color="#FF0000">*</font>Nota: Esta funcionalidad se encuentra en la aplicaci&oacute;n local.    
            <br />  
        </p>
    </div>

    <div id="ayuda-3">
        <h1>Buscar Grupo</h1>
        <p>¿D&oacute;nde encuentro la funcionalidad de Buscar Grupo?</p>
            <a href="ListarGrupo.aspx">Ir a Funcionalidad: Buscar Grupo</a>
        <br/><br/>
        <p>¿Cuando ingreso no hay grupos registrados?</p>
        <img src="img/imagenesAyuda/errorGrupo.png" />
        <p>
            <br />Paso 1: Ingrese a la funcionalidad: Registrar Grupos.<font color="#FF0000">*</font>
            
            <br />Paso 2: Luego de haber registrado al grupo satistfactoriamente ingrese a la funcionalidad: Asignar Grupo a un Curso<font color="#FF0000">*</font>        
            
            <br />Paso 3: De no existir un curso registrado, continue al paso 4 de no ser asi continue al Paso 9
            
            <br />Paso 4: Ingrese a la funcionalidad: Registrar Curso<font color="#FF0000">*</font>. E ingrese los datos solicitados
                       
            <br />Paso 5: Ingrese a la funcionalidad: Asignar Curso a Carrera.<font color="#FF0000">*</font>
            
            <br />Paso 6: Seleccione el curso que desea asignar al a la carrera
            
            <br />Paso 7: De no existir una carrera, continue al paso 8 de no ser asi continue al Paso 9

            <br />Paso 8: Ingrese a la funcionalidad: Registrar Carrera.<font color="#FF0000">*</font>.E ingrese los datos solicitados.

            <br />Paso 9: Realice nuevamente la b&uacute;squeda del grupo.
            
            <br /><font color="#FF0000">*</font>Esta funcionalidad se encuentra en la aplicaci&oacute;n local.<br />    
        </p>
    </div>

    <div id="ayuda-4">
        <h1>Eliminar Grupo</h1>
        <p>¿Donde encuentro la funcionalidad de Eliminar Grupo?</p>
            <a href="ListarGrupo.aspx">Ir a Funcionalidad: Eliminar Grupo</a>
        <br/><br/>
        
        <p>¿Cuando ingreso no hay grupos registrados?
            <br /><img src="img/imagenesAyuda/errorGrupo.png" /><br />
        
            <br />Paso 1: Ingrese a la funcionalidad: Registrar Grupos.<font color="#FF0000">*</font>
            
            <br />Paso 2: Luego de haber registrado al grupo satistfactoriamente ingrese a la funcionalidad: Asignar Grupo a un Curso<font color="#FF0000">*</font>        
            
            <br />Paso 3: De no existir un curso registrado, continue al paso 4 de no ser asi continue al Paso 9
            
            <br />Paso 4: Ingrese a la funcionalidad: Registrar Curso<font color="#FF0000">*</font>. E ingrese los datos solicitados
                       
            <br />Paso 5: Ingrese a la funcionalidad: Asignar Curso a Carrera.<font color="#FF0000">*</font>
            
            <br />Paso 6: Seleccione el curso que desea asignar al a la carrera.
            
            <br />Paso 7: De no existir una carrera, continue al paso 8 de no ser asi continue al Paso 9.

            <br />Paso 8: Ingrese a la funcionalidad: Registrar Carrera.<font color="#FF0000">*</font>.E ingrese los datos solicitados.

            <br />Paso 10: Realice nuevamente la b&uacute;squeda del grupo.
            
            <br /><font color="#FF0000">*</font>Esta funcionalidad se encuentra en la aplicaci&oacute;n local.<br />    
        </p>

        <p>¿C&oacute;mo realizar la eliminaci&oacute;n del grupo?
            <br />Paso 1: Realice la b&uacute;squeda del grupo que desea eliminar.
            <br />Paso 2: Seleccione el grupo que desea eliminar y presione el bot&oacute;n de eliminar.
            <br />Paso 3: Confirme la eliminaci&oacute;n del grupo que desea eliminar.
        </p>
    </div>

    <div id="ayuda-5">
        <h1>Listar Cursos</h1>
        <p>¿D&oacute;nde encuentro la funcionalidad de Listar Cursos?<br />
            <a href="ListarCurso.aspx">Ir a Funcionalidad: Listar Cursos</a>
        </p>
        <p>
            <br />¿Porqu&eacute; no me muestra ning&uacute;n curso?
            <br /><img src="img/imagenesAyuda/errorCurso.png" />          
            <br />El motivo se debe a que no se encuentra ning&uacute;n curso registrado en el sistema.
            <br />
            <br />Paso 1: Ingrese a la funcionalidad Registrar un curso.
            <br />Paso 2: Ingrese los datos requeridos en el formulario de registro.
            <br />Paso 3: Presione el bot&oacute;n de registrar.
            <br /><font color="#FF0000">*</font>Esta funcionalidad se encuentra en la aplicaci&oacute;n local.<br />    
    
        </p>
    </div>

    <div id="ayuda-6">
        <h1>Listar Grupo</h1>
        <p>¿D&oacute;nde encuentro la funcionalidad de Listar Grupo?<br />
            <a href="ListarGrupo.aspx">Ir a Funcionalidad: Listar Grupo</a>
            <br />
            <br />¿Porqu&eacute; no me muestra ning&uacute;n grupo?
            <br /><img src="img/imagenesAyuda/errorGrupo.png" />
            <br />
            <br />El motivo se debe a que no se encuentra ning&uacute;n grupo registrado en el sistema.
            <br />
            <br />Paso 1: Ingrese a la funcionalidad Registrar un grupo.
            <br />Paso 2: Ingrese los datos requeridos en el formulario de registro.
            <br />Paso 3: Presione el bot&oacute;n de registrar.
            <br /><font color="#FF0000">*</font>Esta funcionalidad se encuentra en la aplicaci&oacute;n local.<br />    
        </p>
    </div>

    <div id="ayuda-7">
        <h1>Moficar Tema</h1>
        <p>¿D&oacute;nde encuentro la funcionalidad de Modificar Tema?<br />
            <a href="ListarForo.aspx">Ir a Funcionalidad: Listar Foro</a>
            <br />
            <br />Paso 1: Ingrese a la funcionalidad Listar Foro.
            <br />Paso 2: Seleccione el Foro en el que se encuentra el tema del cual desea realizar la modificaci&oacute;n.
            <br />Paso 3: Seguidamente seleccione el tema del cual desea cambiar alg&uacute;n dato.
            <br />Paso 4: Luego deber&aacute; de presionar el bot&oacute;n de modificar y as&iacute; podr&aacute; acceder a la funcionalidad deseada.
        </p>
    </div>
</div>
</asp:Content>
