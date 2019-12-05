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
        GETVeiculoConsulta();
        GETMotoristaConsulta();
    });

    $('#DataConsulta').on('change',function (e) {
        var data = document.getElementById('DataConsulta').value;
        var cpf = document.getElementById('CpfMotoristaConsulta').value;
        var placa = document.getElementById('PlacaVeiculoConsulta').value;
        console.log(data);
        if(data != "" && cpf != "" && placa != ""){
            GET(placa,cpf,data)
        }
    });

    $('#CpfMotoristaConsulta').on('change',function (e) {
        var data = document.getElementById('DataConsulta').value;
        var cpf = document.getElementById('CpfMotoristaConsulta').value;
        var placa = document.getElementById('PlacaVeiculoConsulta').value;
        console.log(data);
        if(data != "" && cpf != "" && placa != ""){
            GET(placa,cpf,data)
        }
    });

    $('#PlacaVeiculoConsulta').on('change',function (e) {
        var data = document.getElementById('DataConsulta').value;
        var cpf = document.getElementById('CpfMotoristaConsulta').value;
        var placa = document.getElementById('PlacaVeiculoConsulta').value;
        console.log(data);
        if(data != "" && cpf != "" && placa != ""){
            GET(placa,cpf,data)
        }
    });

    $('#CpfOcupante').mask('000.000.000-00');

    $('#consultar-veiculos').click();

});

function PagaMulta(){
    var ocupantes = document.getElementsByName("paga");
    ocupantes.forEach(element => {
        if(element.checked){
            if(element.value == "true"){
                document.getElementById("DataPaga").style.display = "block";  
                document.getElementById("lbl-DataPaga").style.display = "block";             
            }
            else{
                document.getElementById("DataPaga").style.display = "none";
                document.getElementById("lbl-DataPaga").style.display = "none"; 
            }
        }
    });
}