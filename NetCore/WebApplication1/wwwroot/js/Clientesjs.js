

$(document).ready(function () {

	VerClilentes();


});

function VerClilentes() {
	$.ajax({
		url: '/Home/GetClientes',
		type: 'post',
		success: function (result) {
			var tabla = "";

			for (var i = 0; i < result.length; i++) {
				tabla += "<tr>";
				tabla += "<td>" + result[i].documento + "</td>";
				tabla += "<td>" + result[i].cliente + "</td>";
				tabla += "<td>" + result[i].telefono + "</td>";
				tabla += "<td>" + result[i].direccion + "</td>";
				tabla += "<td>" + result[i].estado + "</td>";
				tabla += "<td>";
				tabla += "<button type='button' class='btn btn-success'  onclick='EditarCliente(" + result[i].id + ")' >Editar</button>";
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

			$('#editDocumento').val(data.Id);
			$('#editNombre').val(data.Nombre);
			$('#editApellidos').val(data.Apellidos);
			$('#editTelefono').val(data.Telefono);
			$('#Direccion').val(data.Direccion);
			//$('#editNombre').val(data.Estado);

			$('#ModalEditCliente').modal('show');
		}


	});

}
	
