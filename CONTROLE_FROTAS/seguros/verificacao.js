

function enviardados(){  

    if(document.dados.tx_apolice.value=="" ||document.dados.tx_apolice.value.lenght <= 4)
    {
        alert("Preencha o NUMERO DA APOLICE corretamente!");
        document.dados.tx_apolice.focus();
        return false;
    }
    else{   
       
        alert("Dados cadastrado com sucesso");
      
        
        }


        if(document.dados.tx_cpf.value=="")
        {
            alert("Preencha os CPF corretamente!");
            
            return false;
        }
        else{   
            
            alert("Dados cadastrado com sucesso");
          
            
            }
    

        

        
    
};