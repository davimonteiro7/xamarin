## Teste Desenvolvedor Xamarin --.

 Este aplicativo implementa funções para importar, visualizar e gravar estados brasileiros, com o intuito de apresentar conhecimento
 técnico em desenvolvimento movel. Este app é formado por três paginas: 
  1) Exibição e busca de estados.
  2) Exibição de estados por região.
  3) Exibição e gravação de estados.
 
 A lista de estados foi importada da API(https://api.airtable.com/v0/app0RCW0xYP8RT3U9/Estados?api_key=keyhS9s7U3bGKSuml) utilizando 
 a classe HTTPCLIENT(https://docs.microsoft.com/pt-br/dotnet/api/system.net.http.httpclient?view=netframework-4.8), e foi mapeado com
 recursos do pacote Newtonsoft (https://www.newtonsoft.com/json).
 
 Para gravação dos estados na base local foi utiliazdo o Realm Database (https://realm.io/products/realm-database/).
 
 Para o desenvolvimento na arquitetura MVVM foi utilizado o framework MvvmCross 
 (https://www.mvvmcross.com/documentation/getting-started/getting-started.html).
