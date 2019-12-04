let form = document.querySelector(".cadastro_veiculos")
let inputs = document.querySelectorAll(".cadastro_veiculos form input, select")
   
form.addEventListener("submit",function(event){
    event.preventDefault();


    let dados = formToJson(inputs)
   const teste  = enviardados(dados);
   console.log(teste)
    var Multa  = CriaJSON(dados);
    console.log(Multa)
    if(teste == false){
        return false;
    }

    fetch(new Request('http://localhost:54035/api/Multa/add', { method: 'POST',
         headers: new Headers(
             {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
             }
         ),
         body: JSON.stringify(Multa) }))
        .then(response => {
            if (response.status === 200) {
                alert('Dados cadastrados');
                    document.querySelector(".cadastro_veiculos form").reset();
                    return response.json();                  
            }               
            else {
                throw new Error('Ops! Houve um erro em nosso servidor.');
            }
        })
        .then(response => {
            console.debug(response);
            // ...
        }).catch(error => {
            console.error(error);
        });
        
        
})

function formToJson(inputs){
    let dados = {}
    inputs.forEach(input => {
       
        dados[input.id] = input.value 
    });

   
    return dados
}


function CriaJSON(dados){
    var cpfmotorista = dados["CpfMotorista"];
    var placa = dados["PlacaVeiculo"];
    var descricao = dados["Descricao"];
    var local = dados["Local"];
    var valor = dados["Valor"];
    var data = dados["Data"];
    var situacao;
    var datapaga;

    var options = document.getElementsByName("paga");

    options.forEach(element => {
        if(element.checked){
            if(element.value == "true"){
                situacao = true;
                datapaga = dados["DataPaga"];
            }
            else{
                situacao = false;
                datapaga = null;
            }
        }
    });

   var Multa = {
       Descricao : descricao,
       Local : local,
       DataOcorrencia : data,
       Valor : valor,
       Paga  : situacao,
       MultasPagas : datapaga,
       Veiculo :{
           Placa : placa.trim()
       },
       Motorista:{
           CPF : cpfmotorista.trim()
       }
   }

   return Multa;
}

function LimpaMascara(input){
    var strings = [".", "/", "-", ",", "(", ")", " "];
    
    for(var i = 0; i<=strings.length; i++){
        input = input.replace(strings[i],"");
    }

    for(var i = 0; i<=strings.length; i++){
        input = input.replace(strings[i],"");
    }

    return input;
}

function CortarIdentificador(element){
    for(var i = 0; i<=element.length; i++){
        if(element[i] == "-"){
            var cpf = element.substring(++i,element.length);
            return cpf;
        }
    }
}

function CortarNome(element){
    for(var i = 0; i<=element.length; i++){
        if(element[i] == "-"){
            var nome = element.substring(0,i--);
            return nome;
        }
    }
}