$(document).ready(function () {

    $('#get').click(function () {
        var informacoes = $('form[name="formenviar"]').serialize();

        var url = "http://localhost:64503/Api/IMC?" + informacoes;
        $.getJSON(url, function (data) {
            alert(data);
        });
    });

    $('#post').click(function () {
        var informacoes = $('form[name="formenviar"]').serializeArray();

        var url = "http://localhost:64503/Api/IMC";
        $.post(url, informacoes, function (data) {
            alert(data);
        });
    });


    $('#put').click(function () {
        var informacoes = $('form[name="formenviar"]').serializeArray();
        var res = 0;
        var url = "http://localhost:64503/Api/IMC";

        $.ajax({
            url: url,
            type: 'PUT',
            data: informacoes,
            success: function (data) {
                alert('Registro salvo com sucesso!');
                window.location.reload();
            }
        });

    });

    $('#atl').click(function () {

        var informacoes = $('form[name="formenviar"]').serializeArray();
        var url = "http://localhost:64503/Api/IMC";
        $.ajax({
            url: url,
            type: 'PATCH',
            data: informacoes,
            success: function (data) {
                if (data) {
                    alert('Operação realizada!');
                    window.location.reload();
                }

                else {
                    alert('Operação não realizada!');
                    window.location.reload();
                }

            }
        });
    });

    var url = "http://localhost:64503/Api/IMC/Get";
    $.getJSON(url, function (data) {
        $.each(data, function (key, value) {
            var templateContent = '<tr><td scope="row">';
            $.each(value, function (key, value2) {
                templateContent += value2 + "</td><td>";
            });
            templateContent += '</td>';

            $('#linha').append(
                templateContent);

        });
    });
});


