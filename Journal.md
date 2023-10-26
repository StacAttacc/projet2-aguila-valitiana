# projet2-aguila-valitiana

10/16/2023
  -chercher des données venant de la db
  -design db basique
  -creation du database (InformationStorage)
  <
    creation de la solution sur Visual Studio,
    creation de WebAPI sur Visual Studio,
    creation du frontend en react
  >
10/18/2023
  <
    [https://www.youtube.com/watch?v=5nTlqgQLkIc]
    comment lier la base de données au visual studio
  >

10/23/2023
  -connection au database
  <
    [https://learn.microsoft.com/en-us/visualstudio/data-tools/add-new-connections?view=vs-2022]
    a plus aidé que la video d'avant 10/10
  >
  -installation de EF Core
  <
    [https://www.yogihosting.com/entity-framework-create-edmx-file/]
    un peu vieux come tutoriel, mais il marche
  >

10/25/2023
  -recherche sur le frontend avec react
  <
    [https://www.youtube.com/watch?v=4RKuyp_bOhY]
      ne corresponds pas exactement à ce qu'on fait, mais quand même utile pour commencer un projet
    [https://create-react-app.dev/docs/adding-typescript]
      pour ajouter typescript à react, très utile


      
    [https://www.bezkoder.com/react-crud-web-api/]

      
    [https://www.bezkoder.com/react-typescript-file-upload/]
      
    [https://stackoverflow.com/questions/48847885/module-not-found-cant-resolve-bootstrap-dist-css-bootstrap-theme-css-in-c]
  >

  -recommencement du backend à zero, mais avec EF Core
  <
    [https://www.yogihosting.com/category/ef-core/]
    connection string 1:
      Data Source=(localdb)\ProjectModels;Initial Catalog=InformationStorage;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False

    Pour storer les videos ou audios
    [https://stackoverflow.com/questions/14049622/which-datatype-can-be-used-to-store-videos-in-sql-server-2005]

    Pour générer un script sql avec des dessins
    [https://www.codingtricks.in/2022/11/how-to-add-edmx-file-to-your-net.html]

    la connection string que ça a généré:
      metadata=res://*/Model1.csdl|res://*/Model1.ssdl|res://*/Model1.msl;provider=System.Data.SqlClient;provider connection string="data source=DESKTOP-879N252;initial catalog=InformationStorage;persist security info=True;user id=sa;password=***********;MultipleActiveResultSets=True;App=EntityFramework"
      
  >
