function enviardados(dados)
{     

    if (dados.inputchassi == "") {
        alert("Preencha o CHASSI corretamente!");
        document.dados.tx_chassi.focus();
        return false;
    }
   

    if (dados.inputPlaca.value == "" || document.dados.tx_placa.value.length <= 6) {
        alert("Preencha a PLACA corretamente!");
        document.dados.tx_placa.focus();
        return false;
    }

    if (document.dados.tx_modelo.value == "") {
        alert("Preencha os MODELO corretamente!");
        document.dados.tx_modelo.focus();
        return false;
    }

    if (document.dados.tx_marca.value == "") {
        alert("Preencha os MARCA corretamente!");
        document.dados.tx_marca.focus();
        return false;
    }

    if (document.dados.tx_cor.value == "") {
        alert("Preencha COR corretamente!");
        document.dados.tx_cor.focus();
        return false;
    }

    if (document.dados.tx_ano.value == "") {
        alert("Preencha ano corretamente!");
        document.dados.tx_ano.focus();
        return false;
    }

   

      
   


    else {
        alert('Dados cadastrados')
        
       console.log(inputs)

       document.querySelector(".cadastro_veiculos form").reset()
       document.dados.tx_chassi.focus();
    };}