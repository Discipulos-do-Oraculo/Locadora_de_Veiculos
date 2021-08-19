SELECT 
                    [ID],
                    [NOMECONDUTOR],        
                    [ENDERECO],            
                    [EMAIL],           
                    [CIDADE],     
                    [ESTADO],   
                    [TELEFONE],            
                    [CELULAR],         
                    [RG],          
                    [CPF],   
                    [CNH],          
                    [VALIDADECNH]
            FROM
                    [TBCONDUTOR]

            WHERE  [IDCLIENTECNPJ] IS NULL;

  SELECT * FROM TBCONDUTOR;