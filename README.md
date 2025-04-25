# 🎟️ Ticket

## 📝 Description

Ce projet est une **application console en C#** permettant de gérer un système de tickets pour différentes opérations bancaires : **versement**, **retrait** et **informations**.  
Les utilisateurs peuvent obtenir un **numéro de ticket** et voir combien de personnes sont en attente avant eux.

---

## 🚀 Fonctionnalités

- Gestion de trois types d'opérations :
  - Versement (`V`)
  - Retrait (`R`)
  - Informations (`I`)
- Sauvegarde des informations des clients dans un fichier texte.
- Création automatique des fichiers nécessaires si absents.
- Prise en charge de plusieurs tickets par session.
- Option pour quitter proprement le programme.

---

## 🛠️ Prérequis

- [.NET SDK 8.0](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) ou version ultérieure.

---

## ⚙️ Installation

1. Clonez ce dépôt :
   ```bash
   git clone https://github.com/ImaneBacar/Ticket
   cd Ticket
   ```

2. Compilez et exécutez le programme :
   ```bash
   dotnet run
   ```

3. Suivez les instructions affichées dans la console pour interagir avec le programme.

---

## 🗂️ Structure du projet

- `Program.cs` : Contient le code principal de l'application.
- `Ticket.csproj` : Fichier de configuration du projet.
- `obj/` et `bin/` : Dossiers générés automatiquement lors de la compilation.

---

## 💻 Exemple d'exécution

```text
Bonjour !

Quel type d'opération êtes-vous venu faire ?

1: Versement  
2: Retrait  
3: Informations  
4: Quitter  

Veuillez saisir le type :
```

---

## 🤝 Contribution

Les contributions sont les bienvenues !  
N'hésitez pas à **ouvrir une issue** ou à **soumettre une pull request**.
