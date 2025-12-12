class Quiz
{
    internal QuizVraag[] vragen;
    internal QuizVraagAntwoord[] ingevuldeAntwoorden;

internal Quiz()
    {
        vragen = new QuizVraag[10];
        ingevuldeAntwoorden = new QuizVraagAntwoord[10];
   
    }
        internal void VoegVraagToeOpIndex(int index, QuizVraag vraag)
    {
        vragen[index] = vraag;
    }
}