# projet2-aguila-valitiana

Semaine du 16 Octobre

    -téléchargement de l'environement de travail
        +[VISUAL STUDIO:  https://visualstudio.microsoft.com/free-developer-offers/]
        +[SQL SERVER MANAGEMENT STUDIO:  https://www.microsoft.com/en-ca/sql-server/sql-server-downloads]
        
    -creation de la base de donnée et setup pour des comptes pour la base de donnée
        +[https://trimech.com/blog/how-to-change-your-sql-sa-account-password]
        +[https://learn.microsoft.com/en-us/visualstudio/data-tools/add-new-connections?view=vs-2022]
        
    -creation de la solution sur Visual Studio
        +[https://learn.microsoft.com/en-us/visualstudio/get-started/tutorial-projects-solutions?view=vs-2022]
        
    -creation des sous-projets dans le backend
    
    -creation du frontend en react sur Visual Studio
    
    -lier la base de données au backend
        +[https://www.youtube.com/watch?v=5nTlqgQLkIc] 

Semaine du 23 octobre
  
    -installation de EF Core et d'autres packages avec NuGet
        +[https://learn.microsoft.com/en-us/nuget/consume-packages/install-use-packages-visual-studio]

    -recherche sur comment commencer une application avec react
        +[https://www.youtube.com/watch?v=Nip4k4JPa3w] un full stack avec react
        +[https://www.youtube.com/watch?v=4RKuyp_bOhY] un autre full stack avec react
            #ne correspondent pas exactement à ce qu'on fait, mais quand même utile pour commencer un projet
            
        +[https://www.bezkoder.com/react-crud-web-api/] une application react sans backend
            #pas ce qu'on cherche, mais utile pour d'autres projets, s'il n'ont pas besoin de backend
        
        +[https://create-react-app.dev/docs/adding-typescript] comment ajouter du typescript avec react
        
        +[https://www.bezkoder.com/react-typescript-file-upload/] comment upload un fichier avec react
        +[https://uploadcare.com/blog/how-to-upload-file-in-react/] comment upload un fichier avec react
            très utlies pour notre projet, cependant, on a pas réussi à connecter notre backend avec notre frontend
            
        +[https://stackoverflow.com/questions/48847885/module-not-found-cant-resolve-bootstrap-dist-css-bootstrap-theme-css-in-c]
            comment regler le problème de bootstrap qui e marche pas avec react
            #très utile
    
    -recommencement du backend à zero, il ne marchait pas
      -recherche
        +[https://www.yogihosting.com/category/ef-core/] comment utiliser ASP.NET avec EF Core
            #utile, mais vieux et ne marche pas comme il faut avec les nouvelles versions
            
        +[https://stackoverflow.com/questions/14049622/which-datatype-can-be-used-to-store-videos-in-sql-server-2005] comment storer des vidéos/audios dans le backend
            #il marche en théorie et offre une autre solution si le fichier est trop gros
            
        +[https://www.codingtricks.in/2022/11/how-to-add-edmx-file-to-your-net.html] comment générer un script sql avec des schémas, utilise ADO.NET
            #très utile pour générer des scripts sql

        +[https://learn.microsoft.com/en-us/ef/ef6/modeling/code-first/conventions/built-in] comment écrire les entités
        
        +[https://learn.microsoft.com/en-us/ef/core/dbcontext-configuration/] pour avoir accès aux données de la base de donnée
        
              <[https://www.connectionstrings.com/store-and-read-connection-string-in-appsettings-] connectionString pour se connecter à la base de données, lien brisé:(
              <json/#:~:text=To%20define%20the%20connection%20strings,section%20of%20the%20JSON%20structure.&text=Now%20we%20can%20read%20it,Extensions.

        +[https://stackoverflow.com/questions/68980778/config-connection-string-in-net-core-6] comment faire les connection strings correctement
        
        +[https://www.youtube.com/watch?v=h4KIngWVpfU] comment faire les repositories avec C# EFCore
        
        +[https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/walkthrough-writing-queries-linq] comment faire des queries avec Linq
        
        +[https://learn.microsoft.com/en-us/aspnet/mvc/overview/older-versions-1/controllers-and-routing/creating-a-controller-cs]
            comment faire des conntrollers avec Visual Studio
            
        +[https://www.c-sharpcorner.com/article/c-sharp-string-to-byte-array/] comment convertir des bytes[] en string et vice versa
        +[https://stackoverflow.com/questions/61565947/the-json-value-could-not-be-converted-to-system-byte] comment convertir des bytes[] en string et vice versa
            #utile, mais n'a pas marché ultimement (du moins sur le swagger)
            
        +[https://stackoverflow.com/questions/70668520/how-to-get-a-upload-button-in-swagger-for-iformfile-combined-with-other-properti] autre solution pour upload des fichiers
        +[https://medium.com/@niteshsinghal85/testing-file-upload-with-swagger-in-asp-net-core-90269bc24fe8] autre solution possible pour upload des fichiers
            #pas eu le temps de l'essayer

    -recherche sur les notifications
        +[https://www.c-sharpcorner.com/UploadFile/87b416/working-with-sql-notification/] comment créer des notification savec sql server et c#
            #pas eu le temps de l'essayer

    -création des tabes dans la bd

    -paufinage du journal
