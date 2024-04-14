

$(document).ready(function () {

	VerClilentes();


});

function VerClilentes() {
	$('#tblCliente').DataTable().destroy();

	$.ajax({
		url: '/Home/GetClientes',
		type: 'post',
		success: function (result) {
			var tabla = "";

			$('#tblCliente').find('tbody').empty();
			for (var i = 0; i < result.length; i++) {
				tabla += "<tr>";
				tabla += "<td>" + result[i].documento + "</td>";
				tabla += "<td>" + result[i].cliente + "</td>";
				tabla += "<td>" + result[i].telefono + "</td>";
				tabla += "<td>" + result[i].direccion + "</td>";
				tabla += "<td>" + result[i].estado + "</td>";
				tabla += "<td style='width: 16rem;'>";
				tabla += "<button type='button' class='btn btn-success'  onclick='EditarCliente(" + result[i].id + ")' >Editar</button>&nbsp;&nbsp;";
				tabla += "<button type='button' class='btn btn-danger' onclick='EliminarCliente(" + result[i].id + ")' >Eliminar</button>";
				tabla += "</td>";


				tabla += "</tr>";
			}

			$('#tblCliente').find('tbody').append(tabla);


		}

	})
}


function EliminarCliente(id) {

	$.ajax({
		url: '/home/EliminarCliente',
		data: {
			id: id
		},
		type: 'post',
		success: function () {
			VerClilentes();
		}
	});

}

function EditarCliente(id) {
	$.ajax({
		url: '/Home/Getcliente',
		data: {
			id: id
		},
		type: 'post',
		success: function (data) {
		
			
			$('#editid').val(data.id);
			$('#editDocumento').val(data.documento);
			$('#editNombre').val(data.nombre);
			$('#editApellidos').val(data.apellidos);
			$('#editTelefono').val(data.telefono);
			$('#editDirecion').val(data.direccion);
	
			if (data.estado == "true" || data.estado == true) {
				$('#editestado').attr('checked', true);
			}


			$('#ModalEditCliente').modal('show');
		}


	});
}



function GuardarCliente() {

	if (ValidarCliente()) {
		var estado;
		if ($("#editestado").is(':checked')) {
			estado = true;
		} else {
			estado = false;
		}
		$.ajax({
			url: '/Home/GuardarInfoCliente',
			data: {
				id: $('#editid').val(),
				documento: $('#editDocumento').val(),
				nombre: $('#editNombre').val(),
				apellidos: $('#editApellidos').val(),
				telefono: $('#editTelefono').val(),
				direccion: $('#editDirecion').val(),
				estado: estado
			},
			type: 'post',
			success: function (data) {
				VerClilentes()

			}

		});
	}

}

function ValidarCliente() {

	$('#formclienteedit').validate({
		rules: {
			editDocumento: {
				required: true,
				minlength: 3
			},
			editNombre: {
				required: true,
				minlength: 3
			},
			editApellidos: {
				required: true,
				minlength: 3
			},
			editTelefono: {
				required: true,
				minlength: 3,
				number: true,
			},
			editDirecion: {
				required: true,
				minlength: 3
			},
		},
		messages: {
			editDocumento: {
				required: "El campo es obligatorio",
				minlength: "El campo debe tener minimo 3 caracteres"
			},
			editNombre: {
				required: "El campo es obligatorio",
				minlength: "El campo debe tener minimo 3 caracteres"
			},
			editApellidos: {
				required: "El campo es obligatorio",
				minlength: "El campo debe tener minimo 3 caracteres"
			},
			editTelefono: {
				required: "El campo es obligatorio",
				minlength: "El campo debe tener minimo 3 caracteres",
				number: "Debe colocar un dato numerico"
			},
			editDirecion: {
				required: "El campo es obligatorio",
				minlength: "El campo debe tener minimo 3 caracteres"
			},
		}
	});

	return true;

}
	
