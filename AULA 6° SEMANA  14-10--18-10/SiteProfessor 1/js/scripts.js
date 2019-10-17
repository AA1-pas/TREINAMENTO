$(document).ready(
    function () {
        $('input[name = "btnboasvindas"]').click(function () {
            var nomeusuario = $('input[name = "nomeusuario"]').val();
            alert("Seja Bem Vindo " + nomeusuario + " ao nosso sistema!");
            alert(teste1);
        });
    });

$(document).on('keypress', function (e) {
    if (e.which === 13) {
        alert("Voce apertou Enter");
    }
});

$(document).on('keypress', function (e) {
    if (e.which === 13) {
        $('input[name = "btnboasvindas"]').click();
    }
});