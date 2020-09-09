﻿
function EnviarCliente() {

	$('#mensaje').html('&nbsp;');
	if (ValidarFormCliente()) {
		$('#btnenviarclient').trigger('click');
	}
	else {
		var mensaje = "";
		mensaje += '<div class="alert alert-danger" role="alert">';
		mensaje += 'Faltan datos por llenar';
		mensaje += '<button type="button" class="close" data-dismiss="alert" aria-label="Close">';
		mensaje += '<span aria-hidden="true">&times;</span>';
		mensaje += '</button >';
		mensaje += '</div >';

		$('#mensaje').html(mensaje);
	}

}

function ValidarFormCliente() {
	$('#formcliente').validate({
		rules: {
			Documento: {
				required: true,
				minlength: 3
			},
			Nombre: {
				required: true,
				minlength: 3
			},
			Apellidos: {
				required: true,
				minlength: 3
			},
			Telefono: {
				required: true,
				minlength: 3,
				number: true,
			},
			Direccion: {
				required: true,
				minlength: 3				
			},
		},
		messages: {
			Documento: {
				required: "El campo es obligatorio",
				minlength: "El campo debe tener minimo 3 caracteres"
			},
			Nombre: {
				required: "El campo es obligatorio",
				minlength: "El campo debe tener minimo 3 caracteres"
			},
			Apellidos: {
				required: "El campo es obligatorio",
				minlength: "El campo debe tener minimo 3 caracteres"
			},
			Telefono: {
				required: "El campo es obligatorio",
				minlength: "El campo debe tener minimo 3 caracteres",
				number: "Debe colocar un dato numerico"
			},
			Direccion: {
				required: "El campo es obligatorio",
				minlength: "El campo debe tener minimo 3 caracteres"
			},
		}



	});



	return true;

}

