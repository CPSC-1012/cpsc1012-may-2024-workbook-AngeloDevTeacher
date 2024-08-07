using OOPLists;

const int MaxPlayers = 4;
const int MaxHandSize = 5;
List<Card> deck = new List<Card>();

List<Card>[] players = new List<Card>[MaxPlayers];

for (int i = 0; i < MaxHandSize; i++)
{
    DealCards(deck, players);
}


static void DealCards(List<Card> deck, List<Card>[] players)
{
    foreach (List<Card> player in players)
    {
        Card currentCard = deck[0];
        deck.RemoveAt(0);
        player.Add(currentCard);
    }
}