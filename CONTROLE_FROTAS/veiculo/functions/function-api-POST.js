let form = document.querySelector(".cadastro_veiculos")
var inputs = document.querySelectorAll(".cadastro_veiculos form input")

form.addEventListener("submit", function (event) {
    event.preventDefault();



    let dados = formToJson(inputs)
    const teste = enviardados(dados);
    console.log(teste)


    if (teste == false) {
        return false;
    }

    // console.log(JSON.stringify(dados))

    //  fetch('http://localhost:54035/api/veiculos/add', {
    //     method: 'POST',
    //     headers: new Headers(
    //         {
    //             'Accept': 'application/json',
    //             'Content-Type': 'application/json',
    //             'Access-Control-Allow-Origin': '*',
    //             'Access-Control-Allow-Credentials': true
    //         }),
    //     body: JSON.stringify(dados)
    // })

    fetch(new Request('http://localhost:54035/api/Veiculo/add', { method: 'POST',
         headers: new Headers(
             {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
             }
         ),
         body: JSON.stringify(dados) }))
        .then(response => {
            if (response.status === 200) {
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

function formToJson(inputs) {
    let dados = {}
    inputs.forEach(input => {
        console.log(input.value)
        dados[input.id] = input.value
    });


    return dados
}