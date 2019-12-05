$(document).ready(function () {
  

    $('#cadastro-veiculos').click(function(){
        $('.cadastro_veiculos').show();
        $('.consulta_veiculos').hide();
        $('#consultar-veiculos').removeClass('btn-color-primary');
        $(this).addClass('btn-color-primary');
        GETSeguradora();
        
        
        document.getElementById("lbl-franquia").style.display = "none";
        document.getElementById("Franquia").style.display = "none";
        document.getElementById("lbl-valorfranquia").style.display = "none";
        document.getElementById("ValorFranquia").style.display = "none";
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

    $('#Apolice').mask('0000000000000000');
    $('#Valor').mask('R$ 000000000');
    $('#ValorFranquia').mask('R$ 0000000000');

});

function PopulaItemSegurado(){
    var options = $("#ItemSegurado option");
        $('#ItemSegurado option:not(:selected)').remove();
            var tipo = document.getElementById('Tipo').value;
            if(tipo == "0"){
                console.log(tipo);
                GETVeiculo();

                document.getElementById("lbl-franquia").style.display = "block";
                document.getElementById("Franquia").style.display = "block";
                document.getElementById("lbl-valorfranquia").style.display = "block";
                document.getElementById("ValorFranquia").style.display = "block";
            }

            else if(tipo == "1"){
                console.log(tipo);
                GETMotorista();

                document.getElementById("lbl-franquia").style.display = "none";
                document.getElementById("Franquia").style.display = "none";
                document.getElementById("lbl-valorfranquia").style.display = "none";
                document.getElementById("ValorFranquia").style.display = "none";
            }   
}