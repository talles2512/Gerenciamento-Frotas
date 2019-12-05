function enviardados(){

    if (dados.inputDescricao == "" ||  document.dados.tx_Descricao.value.length <= 5 ) {
        alert("Preencha a Descrição corretamente!");
        document.dados.tx_Descricao.focus();
        return false;
    }

    if (dados.inputLocal == "" ||  document.dados.tx_Local.value.length <= 5 ) {
        alert("Preencha o Local corretamente!");
        document.dados.tx_Local.focus();
        return false;
    }

    if (dados.inputValor == "" ||  document.dados.tx_Valor.value.length <= 0 ) {
        alert("Preencha o Valor corretamente!");
        document.dados.tx_Valor.focus();
        return false;
    }
    
    else {
        console.log(inputs);
       document.dados.tx_Descricao.focus();
    };
}