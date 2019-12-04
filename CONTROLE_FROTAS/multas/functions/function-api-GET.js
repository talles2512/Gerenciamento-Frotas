function GET(placa,cpf,data){
  fetch('http://localhost:54035/api/multa?placa=' +placa.trim() +'&cpf=' +cpf.trim() +'&data=' +data.trim())
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
  
    var table = document.getElementById('tabela-multas');
    var row = table.insertRow(1);
            row.innerHTML = "<td>"+ data["Veiculo"].Placa+"</td>"
                            +"<td>"+data["Motorista"].CPF+"</td>"
                            +"<td>"+data["Local"]+"</td>"
                            +"<td>"+data["Descricao"]+"</td>"
                            +"<td>"+data["Valor"]+"</td>"
                            +"<td>"+NomeiaPagamento(data["Paga"])+"</td>";
  }

function GETMotorista(){
    fetch('http://localhost:54035/api/Multa?cpfs=A')
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
    fetch('http://localhost:54035/api/Multa?placas=A')
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
        fetch('http://localhost:54035/api/multa?placas=A')
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

  function GETMotoristaConsulta(){
    let options = $("#CpfMotoristaConsulta option");
    if(options.length == 1){
        fetch('http://localhost:54035/api/multa?cpfs=A')
                .then(function(response){
                    if(response.ok){
                        response.json().then(function(data){
                            PopulaMotoristasConsulta(data)
                          });
                    }
            
                })
                .catch(function(err){
                    console.error('Failed retrieving information', err);
                  });
    }
  }
  
    function PopulaMotoristasConsulta(data){
      var select = document.getElementById("CpfMotoristaConsulta");
      var contador = 1;
          data.forEach(element => {
  
              var elem = document.createElement('option');
              elem.value = CortarIdentificador(element);
              elem.text  = element;
              select.add(elem, null);
              contador++;
          });
  }

  function NomeiaPagamento(paga){
      var tipo;
        if(paga){
            tipo = 1;
        }
        else{
            tipo = 0;
        }
    var tipos = ["Não", "Sim"];
    return tipos[tipo];
  }
