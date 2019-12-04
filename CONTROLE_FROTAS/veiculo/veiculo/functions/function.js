$(document).ready(function () {
  

    $('#cadastro-veiculos').click(function(){
        $('.cadastro_veiculos').show();
        $('.consulta_veiculos').hide();
        $('#consultar-veiculos').removeClass('btn-color-primary');
        $(this).addClass('btn-color-primary');    
        MudaAluguel();
    });
    
    $('#consultar-veiculos').click(function(){
        $('.cadastro_veiculos').hide();
        $('.consulta_veiculos').show();
        $('#cadastro-veiculos').removeClass('btn-color-primary');
        $(this).addClass('btn-color-primary')
    });

    $('#search-input').on('input',function (e) {
        var pesquisa = document.getElementById('search-input').value;

        if(pesquisa != ""){
            GET(pesquisa);
        }
    });


    $('#Chassi').mask('AAAAAAAAAAAAAAAAA');
    $('#Placa').mask('AAA-0000');

});

function MudaAluguel(){
    var alugados = document.getElementsByName("alugados");
    alugados.forEach(element => {
        if(element.checked){
            if(element.value == "true"){
                document.getElementById("Valor").style.display = "block";
                document.getElementById("lbl-valor").style.display = "block";
                document.getElementById("DtInicio").style.display = "block";
                document.getElementById("lbl-dtinicio").style.display = "block";
                document.getElementById("DtFim").style.display = "block";
                document.getElementById("lbl-dtfim").style.display = "block";
                
            }
            else{
                document.getElementById("Valor").style.display = "none";
                document.getElementById("lbl-valor").style.display = "none";
                document.getElementById("DtInicio").style.display = "none";
                document.getElementById("lbl-dtinicio").style.display = "none";
                document.getElementById("DtFim").style.display = "none";
                document.getElementById("lbl-dtfim").style.display = "none";
            }
        }
    });
}