$(document).ready(function () {
  

    $('#cadastro-veiculos').click(function(){
        $('.cadastro_veiculos').show();
        $('.consulta_veiculos').hide();
        $('#consultar-veiculos').removeClass('btn-color-primary');
        $(this).addClass('btn-color-primary');
        GETMotorista();
        GETVeiculo();
        GETGaragemEstacionamento();
    });
   
    $('#consultar-veiculos').click(function(){
        $('.cadastro_veiculos').hide();
        $('.consulta_veiculos').show();
        $('#cadastro-veiculos').removeClass('btn-color-primary');
        $(this).addClass('btn-color-primary')
        GETGaragemEstacionamentoConsulta()
        GETVeiculoConsulta()
    });

    
    $('#DataHoraConsulta').on('change',function (e) {
        var datahora = document.getElementById('DataHoraConsulta').value;
        var tipo = document.getElementById('TipoConsulta').value;
        var placa = document.getElementById('PlacaVeiculoConsulta').value;
        var cnpj = document.getElementById('CnpjGarEstConsulta').value;

        if(datahora != "" && tipo != "" && placa != "" && cnpj !=""){
            GET(placa,cnpj,tipo,datahora)
        }
    });

    $('#TipoConsulta').on('change',function (e) {
        var datahora = document.getElementById('DataHoraConsulta').value;
        var tipo = document.getElementById('TipoConsulta').value;
        var placa = document.getElementById('PlacaVeiculoConsulta').value;
        var cnpj = document.getElementById('CnpjGarEstConsulta').value;

        if(datahora != "" && tipo != "" && placa != "" && cnpj !=""){
            GET(placa,cnpj,tipo,datahora)
        }
    });

    $('#PlacaVeiculoConsulta').on('change',function (e) {
        var datahora = document.getElementById('DataHoraConsulta').value;
        var tipo = document.getElementById('TipoConsulta').value;
        var placa = document.getElementById('PlacaVeiculoConsulta').value;
        var cnpj = document.getElementById('CnpjGarEstConsulta').value;

        if(datahora != "" && tipo != "" && placa != "" && cnpj !=""){
            GET(placa,cnpj,tipo,datahora)
        }
    });

    $('#CnpjGarEstConsulta').on('change',function (e) {
        var datahora = document.getElementById('DataHoraConsulta').value;
        var tipo = document.getElementById('TipoConsulta').value;
        var placa = document.getElementById('PlacaVeiculoConsulta').value;
        var cnpj = document.getElementById('CnpjGarEstConsulta').value;

        if(datahora != "" && tipo != "" && placa != "" && cnpj !=""){
            GET(placa,cnpj,tipo,datahora)
        }
    });

    $('#consultar-veiculos').click();
});