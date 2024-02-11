Agenda de Contatos
#
Este é um aplicativo simples de agenda de contatos desenvolvido em C# com Windows Forms e SQL Server. O aplicativo permite adicionar, editar, excluir contatos e exibir uma lista de contatos em uma grade.
#
Requisitos
Visual Studio (ou outra IDE compatível com C#)
SQL Server (ou outro banco de dados compatível)
Configuração do Banco de Dados
Certifique-se de configurar a conexão com o banco de dados no código. A string de conexão está localizada na classe Form1 no construtor, onde é criada a instância da conexão SQL.
#

SqlConnection connection = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=master;Trusted_Connection=True;");
Substitua a string de conexão com as informações do seu banco de dados.
#
Como Utilizar o App
Exibir Contatos: Ao iniciar o aplicativo, ele exibe uma lista de contatos em uma grade (DataGridView).

Adicionar Contato: Preencha as informações nos campos fornecidos e clique no botão "Adicionar". O contato será salvo no banco de dados.

Editar Contato: Selecione um contato na grade, faça as alterações necessárias nos campos e clique no botão "Editar". As alterações serão salvas no banco de dados.

Excluir Contato: Selecione um contato na grade, clique no botão "Excluir" e confirme a exclusão. O contato será removido do banco de dados.

Sair: Encerre o aplicativo clicando no botão "Sair".
#
Observações
O aplicativo utiliza um banco de dados SQL Server. Certifique-se de ter um servidor SQL em execução e modifique a string de conexão conforme necessário.

Ao clicar em um contato na grade, as informações desse contato são exibidas nos campos para edição ou exclusão.

Caso ocorram erros durante as operações no banco de dados, mensagens de erro serão exibidas para informar o usuário.
#
Autor
Kauã Fragozo



