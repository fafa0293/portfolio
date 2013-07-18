<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPage.master" CodeBehind="Ayuda.aspx.vb" Inherits="AppWeb.ayuda" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="SidebarContent" runat="server">
    <ul id="lista-ayuda" class="well navbar-horizontal pull-left">
        <li><a href="#ayuda-1">Asignar Estudiante a un Grupo</a></li>
        <li><a href="#ayuda-2">Asignar Profesor a un Grupo</a></li>
        <li><a href="#ayuda-3">Buscar Grupo</a></li>    
        <li><a href="#ayuda-4">Eliminar Grupo</a></li>
        <li><a href="#ayuda-5">Buscar Estudiante de un Grupo</a></li>
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
        <p>¿Donde encuentro la funcionalidad de Asignar Estudiante a un Grupo?</p>
            <a href="AsignarEstudianteAGrupo.aspx">Ir a Funcionalidad: Asignar Estudiante a un Grupo</a>
        <br/><br/>
        <p>¿Cuando ingreso no hay estudiantes registrados?</p>
        <img src="img/imagenesAyuda/errorUsuario.png" />
        <p>
            <br />Paso 1: Ingrese a la funcionalidad: Registrar Usuario.
            <br />Nota: Esta funcionalidad se encuentra en la aplicaci&oacute;n local.
            <br />
            <br />Paso 2: Luego de haber registrado al usuario satistfactoriamente ingrese a la funcionalidad: Asignar Rol a Usuario
            <br />Paso 3: Asignele al usuario seleccionado el usuario de Estudiante.
            <br />Nota: Esta funcionalidad se encuentra en la aplicaci&oacute;n local.    
            <br />  
        </p>
    </div>
    <div id="ayuda-2">
        <h1>Asignar Profesor a un Grupo</h1>
        <p>¿Donde encuentro la funcionalidad de Asignar Estudiante a un Grupo?</p>
            <a href="AsignarProfesorAGrupo.aspx">Ir a Funcionalidad: Asignar Profesor a un Grupo</a>
        <br/><br/>
        <p>¿Cuando ingreso no hay profesores registrados?</p>
        <img src="img/imagenesAyuda/errorUsuario.png" />
        <p>
            <br />Paso 1: Ingrese a la funcionalidad: Registrar Usuario.
            <br />Nota: Esta funcionalidad se encuentra en la aplicaci&oacute;n local.
            <br />
            <br />Paso 2: Luego de haber registrado al usuario satistfactoriamente ingrese a la funcionalidad: Asignar Rol a Usuario
            <br />Paso 3: Asignele al usuario seleccionado el Rol de Profesor.
            <br />Nota: Esta funcionalidad se encuentra en la aplicaci&oacute;n local.    
            <br />  
        </p>
    </div>

    <div id="ayuda-3">
        <h1>Buscar Grupo</h1>
        <p>¿Donde encuentro la funcionalidad de Buscar Grupo?</p>
            <a href="BuscarGrupo.aspx">Ir a Funcionalidad: Buscar Grupo</a>
        <br/><br/>
        <p>¿Cuando ingreso no hay grupos registrados?</p>
        <img src="img/imagenesAyuda/errorUsuario.png" />
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
            <a href="BuscarGrupo.aspx">Ir a Funcionalidad: Eliminar Grupo</a>
        <br/><br/>
        
        <p>¿Cuando ingreso no hay grupos registrados?
            <br /><img src="img/imagenesAyuda/errorUsuario.png" /><br />
        
            <br />Paso 1: Ingrese a la funcionalidad: Registrar Grupos.<font color="#FF0000">*</font>
            
            <br />Paso 2: Luego de haber registrado al grupo satistfactoriamente ingrese a la funcionalidad: Asignar Grupo a un Curso<font color="#FF0000">*</font>        
            
            <br />Paso 3: De no existir un curso registrado, continue al paso 4 de no ser asi continue al Paso 9
            
            <br />Paso 4: Ingrese a la funcionalidad: Registrar Curso<font color="#FF0000">*</font>. E ingrese los datos solicitados
                       
            <br />Paso 5: Ingrese a la funcionalidad: Asignar Curso a Carrera.<font color="#FF0000">*</font>
            
            <br />Paso 6: Seleccione el curso que desea asignar al a la carrera
            
            <br />Paso 7: De no existir una carrera, continue al paso 8 de no ser asi continue al Paso 9

            <br />Paso 8: Ingrese a la funcionalidad: Registrar Carrera.<font color="#FF0000">*</font>.E ingrese los datos solicitados.

            <br />Paso 10: Realice nuevamente la b&uacute;squeda del grupo.
            
            <br /><font color="#FF0000">*</font>Esta funcionalidad se encuentra en la aplicaci&oacute;n local.<br />    
        </p>

        <p>¿Como realizar la eliminaci&oacute;n del grupo?
            <br />Paso 1: Realice la b&uacute;squeda del grupo que desea eliminar.
            <br />Paso 2: Seleccione el grupo que desea eliminar y presione el bot&oacute;n de eliminar.
            <br />Paso 3: Confirme la eliminacion del grupo que desea eliminar.
        </p>
    </div>

    <div id="ayuda-5">
        <h1>Buscar Estudiante Asociado a un Grupo</h1>
        <p>¿Donde encuentro la funcionalidad de Buscar Estudiante asociado a un Grupo?</p>
            <a href="BuscarEstudianteGrupo.aspx">Ir a Funcionalidad: Buscar Estudiante Asociado a un Grupo</a>
        <br/><br/>
        <p>

        </p>
    </div>
</div>
</asp:Content>
