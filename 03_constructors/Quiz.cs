class Quiz
{
    internal QuizVraag[] vragen;
    internal QuizVraagAntwoord[] ingevuldeAntwoorden;

internal Quiz()
    {
        vragen = new QuizVraag[10];

        Quiz quiz = new Quiz();

     quiz.vragen[0] = new QuizVraag("In July 2023, video game company EA announced that players will be able to explore Wakanda in an upcoming open-world video game based on the adventures of what Marvel superhero?", "Black Panther");
     quiz.vragen[1] = new QuizVraag("2021 will see the release of what sixth game in the Halo franchise, continuing the adventures of Master Chief? Its name sounds as if the game’s story will continue in perpetuity", "Halo Infinite");
     quiz.vragen[2] = new QuizVraag("Mendicant Bias and Offensive Bias are fictional AIs in what 'holy' video game franchise that shares its name with a Beyonce´ song?", "Halo");
     quiz.vragen[3] = new QuizVraag("What North Carolina-based video game company created the 2018 breakout hit 'Fortnite'?", "Epic Games");
     quiz.vragen[4] = new QuizVraag("The company that created Fortnite, EPIC, also created a game engine that is licenses to other game creators named what?", "Unreal");
     quiz.vragen[5] = new QuizVraag("Pocket, Light, Color, and Advance were all styles or variants of what video game hardware system?", "Game Boy");
     quiz.vragen[6] = new QuizVraag("In Super Mario Kart, the first game in Nintendo's racing franchise, which of the playable characters has the shortest names?", "Toad");
     quiz.vragen[7] = new QuizVraag("What 2009 game, developed by Mojang, is an open sandbox in which players often build structures and battle creepers, zombies, and other 'mobs'?", "Minecraft");
     quiz.vragen[8] = new QuizVraag("In 2015, the first 6 games were induced into the World Video Game Hall of Fame. Can you name at least one?", "Pong & Tetris & Pac-Man & Super Mario Bros & DOOM & World of Warcraft");
     quiz.vragen[9] = new QuizVraag("What card game related to the 'Warcraft' universe did Blizzard release in 2014?", "Hearthstone");
     quiz.ingevuldeAntwoorden = new QuizVraagAntwoord[10];
    }
    
}