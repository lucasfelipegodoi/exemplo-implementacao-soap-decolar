# exemplo-implementacao-soap-decolar
Exemplo de implementação SOAP para sistema de compra de passagens. Utilizando para demonstrar conceitos de webservice SOAP, bem como para exemplificar
uma implementação RPC.

Entre outras utilizações, SOAP foi desenhado para encapsular e transportar chamadas de RPC, e para isto utiliza-se dos recursos e flexibilidade do XML, sob HTTP.  RPCs ou chamadas remotas de procedimento, são chamadas locais a métodos de objetos (ou serviços) remotos. Portanto, podemos acessar os serviços de um objeto localizado em um outro ponto da rede, através de uma chamada local a este objeto. Cada chamada ou requisição exige uma resposta. Processo de uma chamada RPC: Antes de serem enviadas pela rede, as chamadas de RPC (emitidas pela aplicação cliente) são encapsuladas (ou serializadas) segundo o padrão SOAP. O serviço remoto, ao receber a mensagem faz o processo contrário, desencapsulando-a e extraindo as chamadas de método. A aplicação servidora então processa esta chamada, e envia uma resposta ao cliente. O processo então se repete: a resposta é também serializada e enviada pela rede. Na máquina cliente, esta resposta é desencapsulada e é repassada para a aplicação cliente.


