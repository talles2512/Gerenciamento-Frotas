$(document).ready(function () {
  

    $('#cadastro-veiculos').click(function(){
        $('.cadastro_veiculos').show();
        $('.consulta_veiculos').hide();
        $('#consultar-veiculos').removeClass('btn-color-primary');
        $(this).addClass('btn-color-primary');    
    });
    
    $('#consultar-veiculos').click(function(){
        $('.cadastro_veiculos').hide();
        $('.consulta_veiculos').show();
        $('#cadastro-veiculos').removeClass('btn-color-primary');
        $(this).addClass('btn-color-primary')
    });

    $('#TipoConsulta').on('change',function (e) {
        var tipo = document.getElementById('TipoConsulta').value;
        var data = document.getElementById('DataConsulta').value;
        var id = document.getElementById('IDConsulta').value;
        console.log(data);
        if(id != "" && data != "" && tipo != ""){
            GET(id,data,tipo)
        }
    });

    $('#DataConsulta').on('change',function (e) {
        var tipo = document.getElementById('TipoConsulta').value;
        var data = document.getElementById('DataConsulta').value;
        var id = document.getElementById('IDConsulta').value;
        console.log(data);
        if(id != "" && data != "" && tipo != ""){
            GET(id,data,tipo)
        }
    });

    $('#IDConsulta').on('change',function (e) {
        var tipo = document.getElementById('TipoConsulta').value;
        var data = document.getElementById('DataConsulta').value;
        var id = document.getElementById('IDConsulta').value;
        console.log(data);
        if(id != "" && data != "" && tipo != ""){
            GET(id,data,tipo)
        }
    });

    $('#Tipo').on('change',function (e){
        $('#ItemSegurado option:not(:selected)').remove();
        var tipo = document.getElementById('Tipo').value;
        GETItemSegurado(tipo);
    })

    $('#ItemSegurado').on('change',function (e){
        console.log("Inglesson");
        $('#Seguro option:not(:selected)').remove();
        var tipo = document.getElementById('Tipo').value;
        var item = document.getElementById('ItemSegurado').value;
        GETSeguro(tipo,item);
    })

    $('#consultar-veiculos').click();

});
