function enviardados(){

    if (dados.inputDescricao == "" ||  document.dados.tx_Descricao.value.length <= 5 ) {
        alert("Preencha a Descrição corretamente!");
        document.dados.tx_Descricao.focus();
        return false;
    }
   
    else {
        console.log(inputs);
       document.dados.tx_Descricao.focus();
    };
}