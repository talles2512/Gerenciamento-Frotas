function GET(pesquisa){
  fetch('http://localhost:54035/api/viagem?pesquisa='+pesquisa)
            .then(function(response){
                if(response.ok){
                    response.json().then(function(data){
                        console.log(data);
                        PopulaTabela(data);
                      });
                }
        
            })
            .catch(function(err){
                console.error('Failed retrieving information', err);
              });
}

function PopulaTabela(data){
    var cabecalho = document.getElementById("cabecalho");
    var rows = document.querySelectorAll("table tr");
  
    rows.forEach(element => {
        if(element != cabecalho){
            element.remove();
        }
    });
  
    var table = document.getElementById('tabela-viagens');
  
        data.forEach(element => {
            var row = table.insertRow(1);
            row.innerHTML = "<td>"+ element["Requisicao"]+"</td>"
                            +"<td>"+element["Placa"]+"</td>"
                            +"<td>"+element["CPF"]+"</td>"
                            +"<td>"+element["Destino"]+"</td>"
                            +"<td>"+element["DataSaida"]+"</td>";
        });
  }

function GETMotorista(){
    fetch('http://localhost:54035/api/viagem?cpfs=A')
              .then(function(response){
                  if(response.ok){
                      response.json().then(function(data){
                          PopulaMotoristas(data)
                        });
                  }
          
              })
              .catch(function(err){
                  console.error('Failed retrieving information', err);
                });
  }
          
function PopulaMotoristas(data){
    var select = document.getElementById("CpfMotorista");
    var contador = 1;
        data.forEach(element => {

            var elem = document.createElement('option');
            elem.value = CortarIdentificador(element);
            elem.text  = element;
            select.add(elem, null);
            contador++;
        });
}

function GETVeiculo(){
    fetch('http://localhost:54035/api/viagem?placas=A')
              .then(function(response){
                  if(response.ok){
                      response.json().then(function(data){
                          PopulaVeiculos(data)
                        });
                  }
          
              })
              .catch(function(err){
                  console.error('Failed retrieving information', err);
                });
  }

  function PopulaVeiculos(data){
    var select = document.getElementById("PlacaVeiculo");
    var contador = 1;
        data.forEach(element => {

            var elem = document.createElement('option');
            elem.value = CortarIdentificador(element);
            elem.text  = element;
            select.add(elem, null);
            contador++;
        });
}

function CortarIdentificador(element){
    for(var i = 0; i<=element.length; i++){
        if(element[i] == "-"){
            var cpf = element.substring(++i,element.length);
            return cpf;
        }
    }
}

