function enviardados(){

   

    if(document.dados.tx_financeiro.value=!"")
    {
        alert("Dados cadastrado com sucesso");
        document.dados.tx_nome.focus();
        return true;

    }
}