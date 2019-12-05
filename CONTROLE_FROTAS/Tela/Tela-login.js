function SenhaValida()
{
    if( document.verifica.tx_Acesso.value=="Henrique Oliveira")
    {
        document.verifica.tx_Acesso.focus();
        return true;
    } else
    {
        alert="Nome de Acesso Invalido!!";
    }

}