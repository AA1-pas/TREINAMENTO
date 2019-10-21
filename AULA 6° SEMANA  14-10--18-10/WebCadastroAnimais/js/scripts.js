$(document).ready(
    function () {
       
       
        $('input[name = "btnsalvar"]').click(function () {
            Salvar();
        });
        $('input[name = "btnmostrar"]').click(function () {
            Exibir(vnome, vidade, vraca, vcoloracao);
        });
        
       
    });


function Salvar() {
    return   (vnome = $('input[name="nomedog"]').val(),
     vidade = $('input[name="idadedog"]').val(),
     vraca = $('input[name="racadog"]').val(),
     vcoloracao = $('input[name="coloracaodog"]').val());
        };


function Exibir(vnome, vidade, vraca, vcoloracao) {
    
        alert("Nome: " + vnome + "\n" + "Idade: " + vidade + "\n"
            + "Raça: " + vraca + "\n" + "Coloração: " + vcoloracao);
    };

 
      

