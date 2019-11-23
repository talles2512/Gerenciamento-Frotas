let form = document.querySelector(".cadastro_veiculos")
let inputs = document.querySelectorAll(".cadastro_veiculos form input")
   
form.addEventListener("submit",function(event){
    event.preventDefault();

    let dados = formToJson(inputs)
    console.log(JSON.stringify(dados))
    
     fetch('http://localhost:44367/api/Veiculos', {
        method: 'get',
        mode: 'cors',
        
        // headers: {
        //     'Accept': 'application/json',
        //     'Content-Type': 'application/json',
        //     'Access-Control-Allow-Origin': '*',
        //     'Access-Control-Allow-Credentials': true
        // }
        // body: JSON.stringify({id:1})
    })
   

    .then(function(response){
        return response.text()
    })
    .then(function(response){
        console.log(response)
    })
})

function formToJson(inputs){
    let dados = {}
    inputs.forEach(input => {
       
        dados[input.id] = input.value 
    });

   
    return dados
}