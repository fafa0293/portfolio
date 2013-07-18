function validarNuevoAporte() {
    if ($("#txtAporte").val() == "") {
        alert("Por favor ingrese el contenido de su aporte.");
    } else {
        return true;
    }

    return false;
}
$(function () {
    /* inicializa el menú de usuario */
    SCS.userMenu.init();

    /* inicializa la ayuda */
    SCS.help.init("#lista-ayuda", "#contenedor-ayuda", "#placeholder");

    $("#logos").remove().insertAfter("#sidebar-menu");
    /* esconde la seccion a la izq si esta vacia */
    if ($("#sidebar-menu").html().trim() === "") {
        $("#sidebar-menu").css("visibility", "hidden");
    }

    /* esconde el form de registrar nuevo tema */
    $("#registrar-nuevo-tema").hide();
    $("#linkMostrarRegTema").on('click', function (e) {
        $("#registrar-nuevo-tema").slideToggle();
        $("#registrar-nuevo-tema").parent().find("hr").slideUp();
        $("div.alert").slideUp();
    });

    /* esconde el form de agregar comentario */
    $("#form-agregar-comentario").hide();
    /* hace que aparezca cuando se hace click en el link de agregar comentario */
    $("#agregar-comentario").on('click', function (e) {
        e.preventDefault();
        $("#form-agregar-comentario").slideToggle();
    });

    /* esconde el form de agregar comentario */
    $(".form-agregar-comentario-aporte").hide();

    /* hace que aparezca cuando se hace click en el link de agregar comentario */
    $(".agregar-comentario-aporte").on('click', function (e) {
        var p = $(this).parent().parent(),
            idTema = $(this).attr("data-id-tema"),
            id = $(this).attr("data-id"),
            idUsuarioLog = $("#hIdUsuarioLog").val();

        e.preventDefault();

        if (p.find(".form-agregar-comentario-aporte").is(":visible")) {
            p.find(".form-agregar-comentario-aporte").slideUp();
            return;
        }

        // esconder todos los comentarios
        $(".form-agregar-comentario-aporte").slideUp();

        // cargar los comentarios de un aporte
        p.find(".lista-comentarios").load("ComentariosAporte.aspx?IDTema=" + idTema + "&ID=" + id + " #lista-comentarios", function () {
            // mostrarlos cuando esten cargados
            p.find(".form-agregar-comentario-aporte").slideDown();

            p.find(".eliminar-comentario-aporte").each(function () {
                if (idUsuarioLog != $(this).attr("data-id-usuario")) {
                    $(this).hide();
                }
            });
        });
    });

    /* esconde el form de agregar comentario */
    $("#form-agregar-entrada").hide();
    /* hace que aparezca cuando se hace click en el link de agregar comentario */
    $(".agregar-entrada").on('click', function (e) {
        e.preventDefault();
        $("div.alert").slideUp();
        $("#form-agregar-entrada").slideToggle();
    });

    /* muestra un datepicker para todos los campos con clase "date" */
    $("input.date").datepicker({ dateFormat: "dd/mm/yy" });

    /* valida todos los forms */
    $("form").validate();

    /* cambio en el validador de fechas */
    $.validator.addMethod(
        "date",
        function (value, element) {
            return value.match(/^\d\d?\/\d\d?\/\d\d\d\d$/);
        },
        "Ingrese una fecha en este formato: dd/mm/yyyy."
    );

    /* boton de bloquear usuario de un tema */
    $(".opciones-estudiante-tema input[type=submit]").on('click', function (e) {
        e.preventDefault();

        var idTema = $("#iIdTema").val(),
            idUsuario = $(this).parent().attr("data-id-usuario"),
            justificacion = window.prompt("Ingrese una justificaci\xF3n por bloquear al estudiante de este tema", "");

        window.location.href = "EstudiantesTema.aspx?ID=" + idTema + "&Bloquear=" + idUsuario + "&Justificacion=" + justificacion;
    });

    /* muestra el comentario despues de comentar */
    $(".agregar-comentario-aporte[data-id='" + $("#hIdAporteComentado").val() + "']").click();
    $("#txtAporte").on('focus', function () {
        $(".form-agregar-comentario-aporte").slideUp();
    });

    $("span[id*=ReportViewer]").find("div[id*='ReportViewer']").width("100%");

    $(".btn-eliminar").each(function () {
        var idUsuarioCom = $(this).attr("data-id-usuario");
        var idUsuarioLog = $("#idUsuarioLog").val();
        var idUsuarioBlog = $("#idUsuarioBlog").val();
        
        if (!(idUsuarioLog == idUsuarioBlog || idUsuarioLog == idUsuarioCom)) {
            $(this).hide().css("visibility", "hidden");
            
        }
    });
});