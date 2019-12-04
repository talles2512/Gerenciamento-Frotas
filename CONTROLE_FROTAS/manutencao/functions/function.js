$(document).ready(function () {
  

    $('#cadastro-veiculos').click(function(){
        $('.cadastro_veiculos').show();
        $('.consulta_veiculos').hide();
        $('#consultar-veiculos').removeClass('btn-color-primary');
        $(this).addClass('btn-color-primary');
        GETVeiculo();
        GETOficina();
    });
   
    $('#consultar-veiculos').click(function(){
        $('.cadastro_veiculos').hide();
        $('.consulta_veiculos').show();
        $('#cadastro-veiculos').removeClass('btn-color-primary');
        $(this).addClass('btn-color-primary')
        GETVeiculoConsulta()
    });

    
    $('#DataConsulta').on('change',function (e) {
        var data = document.getElementById('DataConsulta').value;
        var tipo = document.getElementById('TipoConsulta').value;
        var placa = document.getElementById('PlacaVeiculoConsulta').value;
        console.log(data);
        if(data != "" && tipo != "" && placa != ""){
            GET(placa,tipo,data)
        }
    });

    $('#TipoConsulta').on('change',function (e) {
        var data = document.getElementById('DataConsulta').value;
        var tipo = document.getElementById('TipoConsulta').value;
        var placa = document.getElementById('PlacaVeiculoConsulta').value;
        console.log(data);
        if(data != "" && tipo != "" && placa != ""){
            GET(placa,tipo,data)
        }
    });

    $('#PlacaVeiculoConsulta').on('change',function (e) {
        var data = document.getElementById('DataConsulta').value;
        var tipo = document.getElementById('TipoConsulta').value;
        var placa = document.getElementById('PlacaVeiculoConsulta').value;
        console.log(data);
        if(data != "" && tipo != "" && placa != ""){
            GET(placa,tipo,data)
        }
    });

    $('#Valor').mask('R$ 000000000');

    $('#consultar-veiculos').click();
});