let form = document.querySelector(".cadastro_veiculos")
var inputs = document.querySelectorAll(".cadastro_veiculos form input, select")
   
form.addEventListener("submit",function(event){
    event.preventDefault();


        
    let dados = formToJson(inputs)
   const teste  = enviardados(dados);
   console.log(teste)

    var Motorista = CriaJSON(dados);
    console.log(Motorista)
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
     

    fetch(new Request('http://localhost:54035/api/Motorista/add', { method: 'POST',
         headers: new Headers(
             {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
             }
         ),
         body: JSON.stringify(Motorista) }))
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
    var name = dados["Nome"];
    var cpf = LimpaMascara(dados["Cpf"]);
    var rg = LimpaMascara(dados["Rg"]);
    var endereco = dados["Endereco"];
    var dataNascimento = dados["DataNascimento"];
    var telefone = LimpaMascara(dados["Telefone"]);
    var telefoneContato = LimpaMascara(dados["TelefoneContato"]);

    var numero = dados["CNH_Numero"];
    var categoria = dados["CNH_Categoria"];
    var orgaoEmissor = dados["CNH_OrgaoEmissor"];
    var dataEmissao = dados["CNH_DataEmissao"];
    var dataVencimento = dados["CNH_DataVencimento"];

   var Motorista = {
       Name : name,
       CPF : cpf,
       RG : rg,
       Endereco : endereco,
       DataNascimento : dataNascimento,
       Telefone : telefone,
       TelefoneContato : telefoneContato,
       CNH : {
           Numero : numero,
           Categoria : categoria,
           OrgaoEmissor : orgaoEmissor,
           DataEmissao : dataEmissao,
           DataVencimento : dataVencimento
       }
   }

   return Motorista
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