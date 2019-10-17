$(document).ready(
    function () {
        $(function () {
            $('input[name="moedaent"]').maskMoney({
                prefix: 'R$ ',
                thousands: '.',
                decimal: ','
            });
        })
        $(function () {
            $('input[name="valormoeda"]').maskMoney({
                prefix: 'R$ ',
                thousands: '.',
                decimal: ','
            });
        })     
      
        /*$('input[name="moedaent"]').mask("R$ 000,00");*/
    }
);




$(document).ready(
    function () {
        $('input[type="button"]').click(
            function () {
                var variavel = $('input[name="moedaent"]').val().replace("R$ ", "").replace(".", "");
                var tvalormoeda = $('input[name="valormoeda"]').val().replace("R$ ", "").replace(".", "");
                var valor = parseFloat(variavel) / parseFloat(tvalormoeda); 
                CurrencyFormat(valor);
            }
        );
    }
);

function CurrencyFormat(value) {
    var teste = new Number(value).toLocaleString("eng", {
        style: "currency",
        currency: "USD"
    });
    return $('input[name="moedasaida"]').val(teste);
}