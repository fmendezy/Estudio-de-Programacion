/* ARCHIVO JAVASCRIPT PARA EXAMEN */
document.addEventListener('DOMContentLoaded', function () {
    const form = document.getElementById('contactForm');
    form.addEventListener('submit', function (event) {
        event.preventDefault();
        
        const nombre = document.getElementById('nombre').value.trim();
        const correo = document.getElementById('correo').value.trim();
        const mensaje = document.getElementById('mensaje').value.trim();

        if (nombre && correo && mensaje && mensaje.length <= 300) {
            alert(`Formulario enviado:\n\nNombre: ${nombre}\nEmail: ${correo}\nMensaje: ${mensaje}`);
            form.reset();
        } else {
            alert('Por favor, completa todos los campos y asegurate de que el mensaje no exceda los 300 caracteres.');
        }
    });
});