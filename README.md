# WEB API 02 - Projeto ASP .NET Core WebAPI - Documentação API
### OBS

Este arquivo precisa do appsettings.json para conexão com o banco de dados.
- {{Caminho}} = https://localhost:5001/Central/

## GET - Assinante/RetornarTodos/
- {{Caminho}}Assinante/RetornarTodos/

### REPONSE - 200 Status Code
``` json 
curl --location -g --request GET '{{Caminho}}Assinante/RetornarTodos/'
json
[
  {
    "id": 1,
    "nome": "Aaron",
    "senha": "SenhaTeste",
    "email": "aaron@",
    "dataInclusao": "2021-10-07T00:00:00",
    "dataCancelamento": null,
    "ativo": true
  },
  {
    "id": 2,
    "nome": "EU",
    "senha": "SENHATESTE",
    "email": "2222TESTE@",
    "dataInclusao": "2021-10-07T00:00:00",
    "dataCancelamento": null,
    "ativo": true
  },
  {
    "id": 3,
    "nome": "TESTELL",
    "senha": "SENHATESTE",
    "email": "44@",
    "dataInclusao": "2021-10-07T00:00:00",
    "dataCancelamento": null,
    "ativo": true
  },
  {
    "id": 4,
    "nome": "TESTEAA",
    "senha": "SENHATESTE",
    "email": "12565656@",
    "dataInclusao": "2021-10-07T00:00:00",
    "dataCancelamento": null,
    "ativo": true
  }
]
```


## GET - Assinante/RetornarPorId/{id}
- {{Caminho}}Assinante/RetornarPorId/

### REPONSE - 200 Status Code
``` json 
curl --location -g --request GET '{{Caminho}}Assinante/RetornarPorId/1'
json
{
  "id": 1,
  "nome": "Aaron",
  "senha": "SenhaTeste",
  "email": "aaron@",
  "dataInclusao": "2021-10-07T00:00:00",
  "dataCancelamento": null,
  "ativo": true
}
```

## POST - InserirAssinante
- {{Caminho}}Assinante/InserirAssinante/

### BODY
``` json 
json
{
  "id": 9,
  "nome": "USUARI9999",
  "senha": "SENHATESTE",
  "email": "999999@GAMNIL>COM",
  "dataCancelamento": null,
  "ativo": true
}
```
## DELETE - CancelarAssinante
- {{Caminho}}Assinante/CancelarAssinante

### REPONSE - 200 Status Code
``` json 
{
    "content": "Usuario Removido. Id: 9 Nome: USUARI9999  Email: 999999@GAMNIL>COM ",
    "contentType": null,
    "statusCode": 200
}
```

## Autor

- [@AaronCrvl](https://www.github.com/AaronCrvl)
