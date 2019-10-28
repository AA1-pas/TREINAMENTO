
var objBicicleta;

function ConstrutorJSON() {
    this.nome = $('input[name="nomedog"]').val();
    this.idade = $('input[name="idadedog"]').val();
    this.raca = $('input[name="racadog"]').val();
    this.coloracao = $('input[name="coloracaodog"]').val();

}

ConstrutorJSON.prototype.Cachorro = function () {
    return "\nNome: " + this.nome + "\nRaça: " + this.raca + "\nIdade: "
        + this.idade.toString() + "\nColoração: " + this.coloracao;
}


function ExecucaoCriacaoObjeto() {
    objCachorros = new ConstrutorJSON();
}

function ExecutaTesteObtencaoDados() {
    if (objCachorros == null)
        ExecucaoCriacaoObjeto();

    alert(objCachorros.Cachorro());
}

function DisparaSalvar() {
    ExecucaoCriacaoObjeto();
    alert("Dados Criados: " +  objCachorros.Cachorro());
}

function DisparaMostrar() {
    alert("Dados obtidos das funções: " +
        objCachorros.Cachorro());
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

      

