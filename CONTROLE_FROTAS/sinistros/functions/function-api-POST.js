let form = document.querySelector(".cadastro_veiculos")
let inputs = document.querySelectorAll(".cadastro_veiculos form input, select")
   
form.addEventListener("submit",function(event){
    event.preventDefault();


    let dados = formToJson(inputs)
    console.log(document.getElementById("Seguro").value);
   const teste  = enviardados(dados);
   console.log(teste)
    var Sinistro  = CriaJSON(dados);
    console.log(Sinistro)
    if(teste == false){
        return false;
    }

    fetch(new Request('http://localhost:54035/api/Sinistro/add', { method: 'POST',
         headers: new Headers(
             {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
             }
         ),
         body: JSON.stringify(Sinistro) }))
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
    var itemseg = dados["Tipo"];
    var item = dados["ItemSegurado"].trim();
    var descricao = dados["Descricao"];
    var data = dados["Data"];
    var seguro = dados["Seguro"].substring(12);
    
   var Sinistro = {
       ItemSegurado : itemseg,
       Item : item,
       Descricao : descricao,
       DataHora : data,
       Seguro :{
        NumeroApolice : seguro
       }
   }

   return Sinistro;
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