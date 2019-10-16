$(document).ready(
    function () {
        $('input[type="button"]').click(
            function () {
                var nome = $('input[name="nome"]').val();
                alert('Bem vindo '+ nome);
            }
        );
    }
);

$(document).ready(
    function () {
        $('button[type="button"]').click(
            function () {
                var nome = $('input[name="nome"]').val();
                $('span[name = "nomespan"]').text("Seja bem vindo " + nome);
            }
        );
    }
);

