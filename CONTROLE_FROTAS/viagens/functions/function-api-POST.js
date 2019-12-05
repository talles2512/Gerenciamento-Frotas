let form = document.querySelector(".cadastro_veiculos")
let inputs = document.querySelectorAll(".cadastro_veiculos form input, select")
   
form.addEventListener("submit",function(event){
    event.preventDefault();


    let dados = formToJson(inputs)
   const teste  = enviardados(dados);
   console.log(teste)
    var Viagem = CriaJSON(dados);
    var Ocupantes = Viagem.Ocupantes.Ocupante;
    console.log(Viagem)
    if(teste == false){
        return false;
    }

    // console.log(JSON.stringify(dados))
    
     //fetch('http://localhost:44367/api/Veiculos', {
        //method: 'get',
        //mode: 'cors',
        
        // headers: {
        //     'Accept': 'application/json',
        //     'Content-Type': 'application/json',
        //     'Access-Control-Allow-Origin': '*',
        //     'Access-Control-Allow-Credentials': true
        // }
        // body: JSON.stringify({id:1})
    //})
     
    
    fetch(new Request('http://localhost:54035/api/Viagem/add', { method: 'POST',
         headers: new Headers(
             {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
             }
         ),
         body: JSON.stringify(Viagem) }))
        .then(response => {
            if (response.status === 200) {
                if(Viagem.Ocupante){
                    CadastraOcupantes(Ocupantes);
                }
                else{
                    alert('Dados cadastrados');
                    document.querySelector(".cadastro_veiculos form").reset();
                    LimparOcupantes();
                    MudaOcupantes();
                }
                return response.json();
            } else {
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


function CadastraOcupantes(ocupantes){
        var Ocupantes = [];

        for(var i = 0; i<ocupantes.length; i++){
            if(ocupantes[i] !== null){
                Ocupantes.push({
                    Nome : ocupantes[i].Nome,
                    CPF : ocupantes[i].CPF
                });
            }
        }
        fetch(new Request('http://localhost:54035/api/Viagem/add/Ocupantes', { method: 'POST',
         headers: new Headers(
             {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
             }
         ),
         body: JSON.stringify(Ocupantes) }))
        .then(response => {
            if (response.status === 200) {
                
                alert('Dados cadastrados')
                document.querySelector(".cadastro_veiculos form").reset()
                LimparOcupantes();
                MudaOcupantes();
                return response.json();
            } else {
                throw new Error('Ops! Houve um erro em nosso servidor.');
            }
        })
        .then(response => {
            console.debug(response);
            // ...
        }).catch(error => {
            console.error(error);
        });
}

function formToJson(inputs){
    let dados = {}
    inputs.forEach(input => {
        if(input.id == "lista-ocupantes"){
            var ocupantes = [];
            for(var i = 0; i<=input.length; i++){

                if(input[i] != null){
                    var nome = CortarNome(input[i].value);
                    var cpf = CortarIdentificador(input[i].value);
                    ocupantes.push(
                        Ocupante = {
                            Nome : nome,
                            CPF : cpf
                        }
                    );
                }
            }
            dados[input.id] = ocupantes;
        }
        else{
            dados[input.id] = input.value; 
        }
    });

    return dados
}


function CriaJSON(dados){
    var cpfmotorista = dados["CpfMotorista"];
    var placa = dados["PlacaVeiculo"];
    var destino = dados["Destino"];
    var datasaida = dados["DataSaida"];
    var ocupante;

    var options = document.getElementsByName("ocupantes");

    options.forEach(element => {
        if(element.checked){
            if(element.value == "true"){
                ocupante = true;
            }
            else{
                ocupante = false;
            }
        }
    });

    var Ocupantes = {
        Ocupante : []
    };

    for(var i = 0; i<=dados["lista-ocupantes"].length; i++){
        if(dados["lista-ocupantes"][i] != null){
            var nome = dados["lista-ocupantes"][i].Nome;
            var cpf = dados["lista-ocupantes"][i].CPF;
            Ocupante = {
                Nome : nome,
                CPF : cpf
            };
            Ocupantes.Ocupante.push(Ocupante);

        }  
    }

   var Viagem = {
       CPF : cpfmotorista,
       Placa : placa,
       Destino : destino,
       DataSaida : datasaida,
       Ocupante : ocupante,
       Ocupantes : Ocupantes
   }

   return Viagem;
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

function LimparOcupantes(){
    var elements = document.getElementById("lista-ocupantes").options;
    for(var i = 0; i<=elements.length; i++){
        if(elements[i] != null){
            elements[i].remove();
        }
    }
}