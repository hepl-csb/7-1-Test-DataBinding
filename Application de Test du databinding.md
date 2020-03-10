# Application de Test du databinding

Dans le fichier App.xaml, remplacer successivement le nom de la boîte de dialogue de démarrage.

## MainWindow.xaml

Application de base --> Il ne faut vraiment pas programmer comme cela.

## VieillirWindow Auto.xaml

Création d'une fenêtre et d'un objet Personne "automatique" qui sert de DataContext (défini dans le code xaml). La partie du code "INotify PropertyChanged" est en commentaire dans la classe Personne.

Montrer d'abord que l'age est modifié en background mais que il n'est pas modifié dans l'interface utilisateur

Montrer ensuite ce qu'apporte INotifyPropertyChanged

## VieillirWindow.xaml

Idem, mais gestion de la personne courante dans le code behind. 

## MainWindows2.xaml

Exemple de Databinding entre propriétés de 2 composants du GUI