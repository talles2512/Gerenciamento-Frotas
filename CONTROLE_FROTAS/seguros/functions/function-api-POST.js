let form = document.querySelector(".cadastro_veiculos")
var inputs = document.querySelectorAll(".cadastro_veiculos form input, select")
   
form.addEventListener("submit",function(event){
    event.preventDefault();


        
    let dados = formToJson(inputs)
    console.log(dados)
    var teste  = enviardados(dados);
    var Seguro = CriaJSON(dados);
    console.log(Seguro)

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
     
    
    fetch(new Request('http://localhost:54035/api/Seguro/add', { method: 'POST',
         headers: new Headers(
             {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
             }
         ),
         body: JSON.stringify(Seguro) }))
        .then(response => {
            if (response.status === 200) {
                
                alert('Dados cadastrados')
                document.querySelector(".cadastro_veiculos form").reset()

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

function formToJson(inputs){
    let dados = {}
    inputs.forEach(input => {
       
        dados[input.id] = input.value 
    });

   
    return dados
}

function CriaJSON(dados){
    var numeroApolice = dados["Apolice"];
    var cnpj = dados["CnpjSeguradora"];
    var tipo = dados["Tipo"];
    var itemSegurado = dados["ItemSegurado"];
    var valor = LimpaReal(dados["Valor"]);
    var datainicio = dados["DataInicio"];
    var fimvigencia = dados["DataVencimento"];
    var franquia;
    var valorfranquia;

    if(tipo == "0"){
        franquia = dados["Franquia"];
        valorfranquia = LimpaReal(dados["ValorFranquia"]);
    }

   var Seguro = {
       CNPJ : cnpj,
       DataInicio : datainicio,
       FimVigencia : fimvigencia,
       Franquia : franquia,
       ItemSegurado: itemSegurado,
       NumeroApolice : numeroApolice,
       Tipo : tipo,
       Valor : valor,
       ValorFranquia : valorfranquia
       }

   return Seguro;
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

function LimpaReal(input){
    var strings = [".", "R", "$", " "];
    
    for(var i = 0; i<=strings.length; i++){
        input = input.replace(strings[i],"");
    }

    for(var i = 0; i<=strings.length; i++){
        input = input.replace(strings[i],"");
    }

    return input;
}