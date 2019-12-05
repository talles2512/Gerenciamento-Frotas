function GET(placa,cnpj,tipo,datahora){
    fetch('http://localhost:54035/api/entradasaida?placa=' + placa +'&cnpj=' +cnpj +'&tipo=' +tipo +'&data='+datahora)
              .then(function(response){
                  if(response.ok){
                      response.json().then(function(data){
                          console.log(data);
                          PopulaTabela(data);
                        });
                  }
                  else if(response.status == 400){
                    alert("Entrada ou Saída não encontrada!");
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
    
      var table = document.getElementById('tabela-entradas-saidas');

      var row = table.insertRow(1);
              row.innerHTML = "<td>"+NomeiaTipo(data["Tipo"])+"</td>"
                              +"<td>"+data["Placa"]+"</td>"
                              +"<td>"+data["CPF"]+"</td>"
                              +"<td>"+data["CNPJ"]+"</td>"
                              +"<td>"+data["DataHora"]+"</td>";
    }
  
  function GETMotorista(){
      fetch('http://localhost:54035/api/entradasaida?cpfs=A')
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

  function GETGaragemEstacionamento(){
    fetch('http://localhost:54035/api/entradasaida?cnpjs=A')
              .then(function(response){
                  if(response.ok){
                      response.json().then(function(data){
                          PopulaGaragemEstacionamentos(data)
                        });
                  }
          
              })
              .catch(function(err){
                  console.error('Failed retrieving information', err);
                });
  }
          
function PopulaGaragemEstacionamentos(data){
    var select = document.getElementById("CnpjGarEst");
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
      fetch('http://localhost:54035/api/entradasaida?placas=A')
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

  function GETGaragemEstacionamentoConsulta(){
    let options = $("#CnpjGarEstConsulta option");
    if(options.length == 1){
        fetch('http://localhost:54035/api/entradasaida?cnpjs=A')
        .then(function(response){
            if(response.ok){
                response.json().then(function(data){
                    PopulaGaragemEstacionamentosConsulta(data)
                  });
            }
    
        })
        .catch(function(err){
            console.error('Failed retrieving information', err);
          });
    } 
  }
          
function PopulaGaragemEstacionamentosConsulta(data){
    var select = document.getElementById("CnpjGarEstConsulta");
    var contador = 1;
        data.forEach(element => {

            var elem = document.createElement('option');
            elem.value = CortarIdentificador(element);
            elem.text  = element;
            select.add(elem, null);
            contador++;
        });
}
  
  function GETVeiculoConsulta(){
    let options = $("#PlacaVeiculoConsulta option");
    if(options.length == 1){
        fetch('http://localhost:54035/api/entradasaida?placas=A')
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
    var tipos = ["Entrada", "Saida"];
    return tipos[tipo];
  }