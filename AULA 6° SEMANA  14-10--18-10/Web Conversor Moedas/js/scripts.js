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
                var url = "https://olinda.bcb.gov.br/olinda/servico/PTAX/versao/v1/odata/CotacaoDolarDia(dataCotacao=@dataCotacao)?@dataCotacao=%2710-16-2019%27&$top=100&$format=json";
          
                $.getJSON(url, function (data) {

                    var valormoeda = data.value[0].cotacaoVenda;
                    var valorreal = $('input[name="moedaent"]').maskMoney('unmasked')[0];
                    var valorconv = parseFloat(valorreal) / valormoeda;

                    var dolarrmask = new Number(valorconv).toLocaleString("eng", {
                        style: "currency",
                        currency: "USD"
                    });

                    var moedamask = new Number(valormoeda).toLocaleString("pt-BR", {
                        style: "currency",
                        currency: "BRL"

                    });
              
                    $('input[name="moedasaida"]').val(dolarrmask);
                    $('input[name="valormoeda"]').val(moedamask);

                });
            }
        );
    }
);
