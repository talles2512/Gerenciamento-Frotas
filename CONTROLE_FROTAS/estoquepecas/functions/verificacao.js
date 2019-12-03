function enviardados(dados)
{       
   
    if (dados.inputDescricao == "" ||  document.dados.tx_Descricao.value.length <= 2 ) {
        alert("Preencha a Descrição corretamente!");
        document.dados.tx_Descricao.focus();
        return false;
    }
   

    if (dados.inputValor == "" || document.dados.tx_Valor.value.length <= 0) {
        alert("Preencha o Valor corretamente!");
        document.dados.tx_Valor.focus();
        return false;
    }

    if (document.dados.tx_Quantidade.value == "" || document.dados.tx_Quantidade.value.length <= 0) {
        alert("Preencha a Quantidade corretamente!");
        document.dados.tx_Quantidade.focus();
        return false;
    }

    else {
        console.log(inputs);
       document.dados.tx_Descricao.focus();
    };}