function enviardados(dados)
{       
   
    if (dados.inputNome == "" ||  document.dados.tx_Nome.value.length <= 2 ) {
        alert("Preencha o Nome corretamente!");
        document.dados.tx_nome.focus();
        return false;
    }
   

    if (dados.inputLogin == "" || document.dados.tx_Login.value.length <= 3) {
        alert("Preencha o Login corretamente!");
        document.dados.tx_Login.focus();
        return false;
    }

    if (document.dados.tx_Senha.value == "" || document.dados.tx_Senha.value.length <= 3) {
        alert("Preencha a Senha corretamente!");
        document.dados.tx_Senha.focus();
        return false;
    }
   
    else {
        console.log(inputs);
       document.dados.tx_Nome.focus();
    };}