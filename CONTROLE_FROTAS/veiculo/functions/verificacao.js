function enviardados(dados)
{     

    if (dados.Chassi == "") {
        alert("Preencha o Chassi corretamente!");
        document.dados.tx_Chassi.focus();
        return false;
    }
   

    if ( document.dados.tx_Placa.value.length <= 6) {
        alert("Preencha a Placa corretamente!");
        document.dados.tx_Placa.focus();
        return false;
    }

    if (document.dados.tx_Modelo.value == "") {
        alert("Preencha o Modelo corretamente!");
        document.dados.tx_Modelo.focus();
        return false;
    }

    if (document.dados.tx_Marca.value == "") {
        alert("Preencha a Marca corretamente!");
        document.dados.tx_Marca.focus();
        return false;
    }

    if (document.dados.tx_Ano.value == "") {
        alert("Preencha o Ano corretamente!");
        document.dados.tx_Ano.focus();
        return false;
    }

    else if(document.dados.alugados[0].checked){
        if (document.dados.tx_Valor.value == "") {
            alert("Preencha o Valor corretamente!");
            document.dados.tx_Valor.focus();
            return false;
        }
    }
}