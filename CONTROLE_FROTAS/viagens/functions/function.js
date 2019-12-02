$(document).ready(function () {
  

    $('#cadastro-veiculos').click(function(){
        $('.cadastro_veiculos').show();
        $('.consulta_veiculos').hide();
        $('#consultar-veiculos').removeClass('btn-color-primary');
        $(this).addClass('btn-color-primary');    
        GETMotorista();
        GETVeiculo();
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

    $('#add-ocupante').click(function(){
        var nome = document.getElementById("NomeOcupante").value;
        var cpf = LimpaMascara(document.getElementById("CpfOcupante").value);

        if(nome != "" && cpf != ""){
            var listaOcupantes = document.getElementById("lista-ocupantes");
            var elemento = document.createElement('option');
            elemento.value = nome +"-" +cpf;
            elemento.text = nome +"-" +cpf;
            listaOcupantes.add(elemento, null);
            document.getElementById("NomeOcupante").value = "";
            document.getElementById("CpfOcupante").value = "";
        } 
    });

    $('#rem-ocupante').click(function(){
        var selected = document.getElementById("lista-ocupantes").selectedIndex;
        var elements = document.getElementById("lista-ocupantes").options;

        if(elements[selected] != null){
            elements[selected].remove();
        }
    });

    $('#CpfOcupante').mask('000.000.000-00');
});