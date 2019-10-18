$(document).ready(
    function () {
        $('input[name = "btnmostrar"]').click(function () {
            alert($('input[name="idadedog"]').val() + "\n" + $('input[name="nomedog"]').val() );


        });
    });