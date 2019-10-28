$(document).ready(
    function () {
        $('input[name="cep"]').mask('00.000-000');
        $('input[type="button"]').click(
            function () {

                var cep = $('input[name="cep"]').val().replace(".", "");
                var ncep = cep.length;
                if (cep == "" || ncep != 9) {
                    alert("CEP inválido!");
                    $('input[type="text"]').val('');
                    return false;
                }
                $.get("https://viacep.com.br/ws/" + cep + "/json/", function (data, status) {
                    if (data.erro) {
                        alert("CEP inválido!");
                        $('input[type="text"]').val('');
                        return false;
                    }
                        /*$('input[name="cep"]').val(data.cep);*/
                        $('input[name="bairro"]').val(data.bairro);
                        $('input[name="logradouro"]').val(data.logradouro);
                        $('input[name="complemento"]').val(data.complemento);
                        $('input[name="localidade"]').val(data.localidade);
                        $('input[name="uf"]').val(data.uf);
                        $('input[name="unidade"]').val(data.unidade);
                        $('input[name="ibge"]').val(data.ibge);
                });
            }
        );
    }
);