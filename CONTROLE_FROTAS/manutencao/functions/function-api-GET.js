function GET(placa,tipo,data){
  fetch('http://localhost:54035/api/manutencao?placa=' + placa +'&tipo=' +tipo +'&data='+data)
            .then(function(response){
                if(response.ok){
                    response.json().then(function(data){
                        console.log(data);
                        PopulaTabela(data);
                      });
                }
                else if(response.status == 400){
                  alert("Manutenção não encontrada");
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
  
    var table = document.getElementById('tabela-manuntecoes');

    var row = table.insertRow();
            row.innerHTML = "<td>"+NomeiaTipo(data["Tipo"])+"</td>"
                            +"<td>"+data["Placa"]+"</td>"
                            +"<td>"+data["CNPJ"]+"</td>"
                            +"<td>"+data["Descricao"]+"</td>"
                            +"<td>"+data["Valor"]+"</td>"
                            +"<td>"+data["Data"]+"</td>"                            
                            +"<td>"+NomeiaSituacao(data["Situacao"])+"</td>";
  }

function GETOficina(){
  fetch('http://localhost:54035/api/manutencao?cnpjs=A')
            .then(function(response){
                if(response.ok){
                    response.json().then(function(data){
                        PopulaOficinas(data)
                      });
                }
        
            })
            .catch(function(err){
                console.error('Failed retrieving information', err);
              });
}
        
function PopulaOficinas(data){
  var select = document.getElementById("CnpjOficina");
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
    fetch('http://localhost:54035/api/manutencao?placas=A')
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

function GETVeiculoConsulta(){
  let options = $("#PlacaVeiculoConsulta option");
  if(options.length == 1){
      fetch('http://localhost:54035/api/manutencao?placas=A')
              .then(function(response){
                  if(response.ok){
                      response.json().then(function(data){
                          PopulaVeiculosConsulta(data)
                        });
                  }
          
              })
              .catch(function(err){
                  console.error('Failed retrieving information', err);
                });
  }
}

  function PopulaVeiculosConsulta(data){
    var select = document.getElementById("PlacaVeiculoConsulta");
    var contador = 1;
        data.forEach(element => {

            var elem = document.createElement('option');
            elem.value = CortarIdentificador(element);
            elem.text  = element;
            select.add(elem, null);
            contador++;
        });
}


function NomeiaTipo(tipo){
  var tipos = ["Preventiva", "Corretiva"];
  return tipos[tipo];
}

function NomeiaSituacao(tipo){
  var tipos = ["Pendente", "Realizada"];
  return tipos[tipo];
}