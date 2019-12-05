function GET(id,data,tipo){
  fetch('http://localhost:54035/api/Sinistro?id=' +id.trim() +'&data=' +data.trim() +'&tipo=' +tipo.trim())
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
  
    var table = document.getElementById('tabela-sinistros');
    var row = table.insertRow(1);
            row.innerHTML = "<td>"+ data["Id"]+"</td>"
                            +"<td>"+NomeiaTipo(data["ItemSegurado"])+"</td>"
                            +"<td>"+data["Seguro"].NumeroApolice+"</td>"
                            +"<td>"+data["Descricao"]+"</td>"
                            +"<td>"+data["DataHora"]+"</td>";
  }

function GETSeguro(tipo,item){
    fetch('http://localhost:54035/api/Sinistro?tipo='+tipo+'&item='+item.trim())
              .then(function(response){
                  if(response.ok){
                      response.json().then(function(data){
                          PopulaSeguros(data)
                        });
                  }
          
              })
              .catch(function(err){
                  console.error('Failed retrieving information', err);
                });
  }
          
function PopulaSeguros(data){
    var select = document.getElementById("Seguro");
    var contador = 1;
        data.forEach(element => {

            var elem = document.createElement('option');
            elem.value = element;
            elem.text  = element;
            select.add(elem, null);
            contador++;
        });
}

function GETItemSegurado(tipo){
    fetch('http://localhost:54035/api/Sinistro?tipo='+tipo)
              .then(function(response){
                  if(response.ok){
                      response.json().then(function(data){
                        PopulaItemSegurado(data)
                        });
                  }
          
              })
              .catch(function(err){
                  console.error('Failed retrieving information', err);
                });
  }

  function PopulaItemSegurado(data){
    var select = document.getElementById("ItemSegurado");
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

function NomeiaTipo(tipo){
    var tipos = ["Veículo", "Motorista"];
    return tipos[tipo];
  }
