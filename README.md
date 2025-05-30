
# Gerenciador de Tarefas Simples - Windows Forms (C#)

Este projeto é um Gerenciador de Tarefas simples, desenvolvido em C# com Windows Forms, como parte do curso de Desenvolvimento de Sistemas. Ele permite o gerenciamento de tarefas com informações como nome, responsável, setor e data limite.


## Funcionalidades

 O sistema possibilita adicionar tarefas preenchendo os campos de nome da tarefa, responsável e setor (selecionado em um ComboBox), além de definir uma data limite usando um DateTimePicker. As tarefas adicionadas aparecem organizadas em um DataGridView, que permite visualização clara e rápida. Para excluir uma tarefa, o usuário pode selecionar uma linha e clicar no ícone de apagar ou simplesmente dar duplo clique na linha desejada, que será solicitada uma confirmação antes da remoção.
## Validações

Para garantir a integridade dos dados, o sistema realiza algumas validações importantes. O nome da tarefa e do responsável não podem ficar em branco e devem conter pelo menos três caracteres. O setor precisa ser selecionado obrigatoriamente, e a data limite escolhida não pode ser anterior ao dia atual, evitando a criação de tarefas com prazos inválidos.

## Captura de Tela
Abaixo você pode conferir uma imagem da interface do sistema em funcionamento, mostrando como as tarefas ficam organizadas no DataGridView e as opções de cadastro e remoção disponíveis:


     ![Gerenciador de tarefas](GerenciadorDeTarefas/imagens/)
