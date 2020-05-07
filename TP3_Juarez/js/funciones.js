function validarDatos()
{
    var nombre = document.getElementById("txtNombre").value;
    var mail = document.getElementById("txtMail").value;
    var mensaje = document.getElementById("txtMensaje").value;
    if(nombre == "" || mail == "" || mensaje == "")
    {
        alert("Debe completar todos los campos");
    }
    else
    {
        alert("Mensaje enviado correctamente");
    }
}