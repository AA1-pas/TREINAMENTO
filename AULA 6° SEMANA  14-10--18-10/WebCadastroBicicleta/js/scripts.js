

function ConstrutorJSON() {
    this.marca = $('input[name="marcabic"]').val();
    this.peso = $('input[name="pesobic"]').val();
    this.valor = $('input[name="valorbic"]').val();
}

ConstrutorJSON.prototype.Bicicleta = function () {
    return "\nMarca: " + this.marca + "\nValor: R$ " + this.valor.toLocaleString('pt-BR', { minimumFractionDigits: 3, maximumFractionDigits: 3 }) + "\nPeso: "
        + this.peso.toString() ;
}


function ExecucaoCriacaoObjeto() {
    objBicicletas = new ConstrutorJSON();
}


function DisparaSalvar() {
    ExecucaoCriacaoObjeto();
    alert("Dados Criados: " + objBicicletas.Bicicleta());
}

function DisparaMostrar() {
    alert("Dados obtidos das funções: "
        + objBicicletas.Bicicleta());
}

$('input[name = "btnsalvar"]').click(function () {
    DisparaSalvar();
    LimparTela();
});
$('input[name = "btnmostrar"]').click(function () {
    DisparaMostrar();
});

function LimparTela() {
    var meusInputs = $('input[type="text"],input[type="number"]');
    meusInputs.val("");
}
      

