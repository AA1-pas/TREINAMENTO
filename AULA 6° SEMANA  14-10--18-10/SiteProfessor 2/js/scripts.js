$(document).ready(
    function () {
        $('input[name = "btnconverter"]').click(function () {
            var valordolar = 4.16;
            var valoreal = $('input[name=valoreal]').val();
            var convercao = valoreal / valordolar;
            $('input[name=valordolar]').val(convercao);
 
        });
    });


$(document).on('keypress', function (e) {
    if (e.which === 13) {
        $('input[name = "btnconverter"]').click();
    }
});