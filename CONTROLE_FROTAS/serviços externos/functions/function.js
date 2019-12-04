$(document).ready(function () {
  

    $('#cadastro-veiculos').click(function(){
        $('.cadastro_veiculos').show();
        $('.consulta_veiculos').hide();
        $('#consultar-veiculos').removeClass('btn-color-primary');
        $(this).addClass('btn-color-primary');
        MudaConveniado()
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

    $('#Cnpj').mask('00.000.000/0000-00');
    $('#Telefone').mask('(00) 0000-0000');
    $('#Valor').mask('R$ 000000000');

});

function MudaConveniado(){
    var conveniados = document.getElementsByName("conveniado");
    console.log(conveniados[i]);

    for(var i = 0; i<conveniados.length; i++){
        if(conveniados[i].checked){
            if(conveniados[i].value == true){

            }
        }
    }
    conveniados.forEach(element => {
        if(element.checked){
            if(element.value == "true"){
                console.log("Ingleson");
                document.getElementById("lbl-valor").style.display = "block";
                document.getElementById("Valor").style.display = "block";
                document.getElementById("lbl-data-inicio").style.display = "block";
                document.getElementById("DataInicio").style.display = "block";
                document.getElementById("lbl-data-vencimento").style.display = "block";
                document.getElementById("DataVencimento").style.display = "block";
                
            }
            else{
                document.getElementById("lbl-valor").style.display = "none";
                document.getElementById("Valor").style.display = "none";
                document.getElementById("lbl-data-inicio").style.display = "none";
                document.getElementById("DataInicio").style.display = "none";
                document.getElementById("lbl-data-vencimento").style.display = "none";
                document.getElementById("DataVencimento").style.display = "none";
            }
        }
    });
}