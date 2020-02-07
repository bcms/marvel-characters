# Marvel Characters

Marvel Characters � uma api de catologo de personagens da Marvel.

## Design Patterns Utilizados

Foram utilizados alguns design patterns na contru��o deste projeto, a fim de simplicar o desenvolvimento e garantir boas pr�ticas de desenvolvimento.

| Design Pattern      | Justifica��o |
| --------- | -----|
| CQS (Command Query Separation) | Separar regras consultas das regras de manipula��o de dados. Simplifica as regras do sistema, � f�cil de utilizar e for�a trabalhar orientado a casos de usos. |
| Repository |Isola regras de comunica��o com base de dados das regras de neg�cio. Possibilita mudan�as de tecnologia de armazenamento de dados de grandes altera��es nas outras �reas da aplica��o. |
| Notifications |Utilizado para valida��es em geral e evita que exceptions tenham este fim. Garante uma melhor performance do sistema (Exceptions tendem � ser custosas falando de processamento).  |

Al�m dos design patterns tamb�m foram aplicados conceitos e praticas de clean code.