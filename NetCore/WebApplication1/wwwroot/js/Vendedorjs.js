

$(document).ready(function () {

	VerVendedores();

});

function VerVendedores() {
	$('#tblVendedor').DataTable().destroy();

	$.ajax({
		url: '/Vendedores/GetVendedores',
		type: 'post',
		success: function (result) {
			var tabla = "";

			$('#tblVendedor').find('tbody').empty();
			for (var i = 0; i < result.length; i++) {
				tabla += "<tr>";
				tabla += "<td>" + result[i].vendedores + "</td>";
				tabla += "<td>" + result[i].cargo + "</td>";		
				tabla += "<td>" + result[i].estado + "</td>";
				tabla += "<td style='width: 16rem;'>";
				tabla += "<button type='button' class='btn btn-success'  onclick='EditarVendedor(" + result[i].id + ")' >Editar</button>&nbsp;&nbsp;";
				tabla += "<button type='button' class='btn btn-danger' onclick='EliminarVendedor(" + result[i].id + ")' >Eliminar</button>";
				tabla += "</td>";
				tabla += "</tr>";
			}

			$('#tblVendedor').find('tbody').append(tabla);


		}

	})
}


function EliminarVendedor(id) {

	$.ajax({
		url: '/Vendedores/EliminarVendedor',
		data: {
			id: id
		},
		type: 'post',
		success: function () {
			VerVendedores();
		}
	});

}

function EditarVendedor(id) {
	$.ajax({
		url: '/Vendedores/GetVendedor',
		data: {
			id: id
		},
		type: 'post',
		success: function (data) {


			$('#editid').val(data.id);	
			$('#editNombres').val(data.vendedores);
			$('#editcargo').val(data.cargo);
		
			if (data.estado == "true" || data.estado == true) {
				$('#editestado').attr('checked', true);
			}


			$('#ModalEditVendedor').modal('show');
		}


	});
}

function GuardaVendedor() {

	if (ValidarCliente()) {
		var estado;
		if ($("#editestado").is(':checked')) {
			estado = true;
		} else {
			estado = false;
		}
		$.ajax({
			url: '/Vendedores/GuardarInfoVendedor',
			data: {
				id: $('#editid').val(),			
				nombre: $('#editNombres').val(),
				cargo: $('#editcargo').val(),			
				estado: estado
			},
			type: 'post',
			success: function (data) {
				VerVendedores();
				$('#ModalEditVendedor').modal('hide');
			}

		});
	}

}

function ValidarCliente() {

	$('#formVendedoreddit').validate({
		rules: {
		
			editNombres: {
				required: true,
				minlength: 3
			},
			editcargo: {
				required: true,
				minlength: 3
			}
		},
		messages: {
			editNombres: {
				required: "El campo es obligatorio",
				minlength: "El campo debe tener minimo 3 caracteres"
			},
			editcargo: {
				required: "El campo es obligatorio",
				minlength: "El campo debe tener minimo 3 caracteres"
			}
		}
	});

	return true;

}
