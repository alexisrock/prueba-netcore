$(document).ready(function () {

	VerProductos();


});

function VerProductos() {

	$('#tblproductos').DataTable().destroy();

	$.ajax({
		url: '/Productos/GetProductos',
		type: 'post',
		success: function (result) {
			var tabla = "";

			$('#tblproductos').find('tbody').empty();
			for (var i = 0; i < result.length; i++) {
				tabla += "<tr>";
				tabla += "<td>" + result[i].codigo + "</td>";
				tabla += "<td>" + result[i].descripcion + "</td>";			
				tabla += "<td>" + result[i].estado + "</td>";
				tabla += "<td style='width: 16rem;'>";
				tabla += "<button type='button' class='btn btn-success'  onclick='EditarProducto(\"" + result[i].codigo + "\")' >Editar</button>&nbsp;&nbsp;";
				tabla += "<button type='button' class='btn btn-danger' onclick='EliminarProducto(\"" + result[i].codigo + "\")' >Eliminar</button>";
				tabla += "</td>";


				tabla += "</tr>";
			}

			$('#tblproductos').find('tbody').append(tabla);


		}

	})

}

function EliminarProducto(codigo) {
	$.ajax({
		url: '/Productos/EliminarProducto',
		data: {
			codigo: codigo
		},
		type: 'post',
		success: function () {
			VerProductos();
		}
	});

}

function EditarProducto(codigo) {
	$.ajax({
		url: '/Productos/GetProducto',
		data: {
			codigo: codigo
		},
		type: 'post',
		success: function (data) {
			$('#ModalEdiProducto').modal('show');
			$('#Codigo').val(data.codigo);
			$('#Descripcion').val(data.descripcion);

			if (data.estado == "true" || data.estado == true) {
				$('#editestado').attr('checked', true);
			}

		}
	});

}

function GuardarProducto() {

	if (ValidarFormProducto()) {
		$('#btnedit').trigger('click');
	}
}

function ValidarFormProducto() {
	$('#formeditproducto').validate({
		rules: {
			Codigo: {
				required: true,
				minlength: 3
			},
			Descripcion: {
				required: true,
				minlength: 3
			}
		},
		messages: {
			Codigo: {
				required: "El campo es obligatorio",
				minlength: "El campo debe tener minimo 3 caracteres"
			},
			Descripcion: {
				required: "El campo es obligatorio",
				minlength: "El campo debe tener minimo 3 caracteres"
			}
		}

	})
	return true;

}


