function enviardados(){

   

    if(document.dados.tx_viagens.value=!"")
    {
        alert("Dados cadastrado com sucesso");
        document.dados.tx_nome.focus();
        return true;

    }
}