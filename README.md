# BlackBackup
O projeto BlackBackup é desenvolvida em C#, utilizando .Net 6.0

## Motivações do Projeto
Esta ideia surgiu quando os scripts que faziam os downloads dos backups da BackBlaze pararam de funcionar, nos levando a utilizar meios alternativos, como CyberDuck e Rclone, já que são ferramentas de terceiros e estamos tratando de dados sensíveis (backups, onde contém dados de clientes), decidimos desenvolver nossa própria ferramenta que faz a comunicação com a API da BackBlaze.

## Objetivo do Projeto
Este projeto tem como seu objetivo realizar a comunicação com a API ControleAtivosIaas, listando os clientes e iniciando o Job de backup, lista os backups que estão disponíveis na BackBlaze e faz o download dos mesmos, podendo ser evoluído para fazer os uploads dos backups na máquina de DB, futuramente.

## Tecnologias utilizadas
#### Api
**RestSharp** - Realiza as chamadas nas APIs da BackBlaze e ControleAtivosIaas.
#### Banco de Dados
**Microsoft.Data.SqlClient** - Realizar o backup manual e executar o job do Agent para subir o backup. <br>
**SQLite** - Guardar as informações das conexões da BackBlaze criptografadas.<br>
**Microsoft.EntityFrameworkCore.Sqlite** - Comunicação com o SQLite.<br>
**Microsoft.EntityFrameworkCore.InMemory** - Comunicação da janela de clientes, onde será salvo apenas em memória.<br>

#### Front
**MaterialSkin2** - Visualzinho bacana para o Form do Windows.<br>


# CI/CD
Esta sendo implementado o processo de integração continua para esse projeto. Atualmente existes os stages de build, test, release e image, onde respectivamente é gerada a build, testada, realizado o publish e a criação do conteiner para futuros deploys em qualquer ambiente.

## Variaveis do projeto

