using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace BlackJack
{
    //Для определения старшинства карт
    enum CardValue
    {
        Jack = 2,
        Lady,
        King,
        card6 = 6,
        card7,
        card8,
        card9,
        card10,
        Ace,
    }

    //Для масти карты
    enum CardSuit
    {
        Spades,
        Diamond,
        Clubs,
        Hearts,
    }

    //Карта
    struct Card
    {
        public CardValue Value;
        public CardSuit Suit;
    }



    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Black Jack";
            Console.WriteLine(Console.InputEncoding); 
            Random rand = new Random();
            //Колода карт
            Card[] Deck = new Card[36]
            {
                new Card
                {
                    Value = CardValue.card6,
                    Suit = CardSuit.Clubs
                },
                new Card
                {
                    Value = CardValue.card7,
                    Suit = CardSuit.Clubs
                },
                new Card
                {
                    Value = CardValue.card8,
                    Suit = CardSuit.Clubs
                },
                new Card
                {
                    Value = CardValue.card9,
                    Suit = CardSuit.Clubs
                },
                new Card
                {
                    Value = CardValue.card10,
                    Suit = CardSuit.Clubs
                },
                new Card
                {
                    Value = CardValue.Jack,
                    Suit = CardSuit.Clubs
                },
                new Card
                {
                    Value = CardValue.Lady,
                    Suit = CardSuit.Clubs
                },
                new Card
                {
                    Value = CardValue.King,
                    Suit = CardSuit.Clubs
                },
                new Card
                {
                    Value = CardValue.Ace,
                    Suit = CardSuit.Clubs
                },

                new Card
                {
                    Value = CardValue.card6,
                    Suit = CardSuit.Hearts
                },
                new Card
                {
                    Value = CardValue.card7,
                    Suit = CardSuit.Hearts
                },
                new Card
                {
                    Value = CardValue.card8,
                    Suit = CardSuit.Hearts
                },
                new Card
                {
                    Value = CardValue.card9,
                    Suit = CardSuit.Hearts
                },
                new Card
                {
                    Value = CardValue.card10,
                    Suit = CardSuit.Hearts
                },
                new Card
                {
                    Value = CardValue.Jack,
                    Suit = CardSuit.Hearts
                },
                new Card
                {
                    Value = CardValue.Lady,
                    Suit = CardSuit.Hearts
                },
                new Card
                {
                    Value = CardValue.King,
                    Suit = CardSuit.Hearts
                },
                new Card
                {
                    Value = CardValue.Ace,
                    Suit = CardSuit.Hearts
                },

                new Card
                {
                    Value = CardValue.card6,
                    Suit = CardSuit.Diamond
                },
                new Card
                {
                    Value = CardValue.card7,
                    Suit = CardSuit.Diamond
                },
                new Card
                {
                    Value = CardValue.card8,
                    Suit = CardSuit.Diamond
                },
                new Card
                {
                    Value = CardValue.card9,
                    Suit = CardSuit.Diamond
                },
                new Card
                {
                    Value = CardValue.card10,
                    Suit = CardSuit.Diamond
                },
                new Card
                {
                    Value = CardValue.Jack,
                    Suit = CardSuit.Diamond
                },
                new Card
                {
                    Value = CardValue.Lady,
                    Suit = CardSuit.Diamond
                },
                new Card
                {
                    Value = CardValue.King,
                    Suit = CardSuit.Diamond
                },

                new Card
                {
                    Value = CardValue.Ace,
                    Suit = CardSuit.Diamond
                },

                new Card
                {
                    Value = CardValue.card6,
                    Suit = CardSuit.Spades
                },
                new Card
                {
                    Value = CardValue.card7,
                    Suit = CardSuit.Spades
                },
                new Card
                {
                    Value = CardValue.card8,
                    Suit = CardSuit.Spades
                },
                new Card
                {
                    Value = CardValue.card9,
                    Suit = CardSuit.Spades
                },
                new Card
                {
                    Value = CardValue.card10,
                    Suit = CardSuit.Spades
                },
                new Card
                {
                    Value = CardValue.Jack,
                    Suit = CardSuit.Spades
                },
                new Card
                {
                    Value = CardValue.Lady,
                    Suit = CardSuit.Spades
                },
                new Card
                {
                    Value = CardValue.King,
                    Suit = CardSuit.Spades
                },

                new Card
                {
                    Value = CardValue.Ace,
                    Suit = CardSuit.Spades
                }
            };
            //Наборы карт для пользователя и компьтера
            Card[] UserCards = new Card[36];
            Card[] CompCards = new Card[36];

            int UserVictories = 0, CompVictories = 0;          //Счётчики побед пользователя и компьютера



            string GameChoice = "y";
            //Цикл в котором происходит игра
            do
            {
                Console.WriteLine();
                int CardCounter = 35;                  //Счётчик карт в колоде
                int UserCount = 0, CompCount = 0;      //Счётчикт карт пользователя и компьтера
                int UserPoints = 0, CompPoints = 0;    //Счётчики очков

                //if (GameChoice == "n")
                //{
                //    break;
                //}

                //Перемешиваем колоду
                for (int i = 0; i < Deck.Length; i++)
                {
                    int j = rand.Next(0, 35);
                    var temp = Deck[i];
                    Deck[i] = Deck[j];
                    Deck[j] = temp;
                }

                //Раздача по 2 карты
                Console.WriteLine("Game starts..");
                UserCards[0] = Deck[CardCounter--];
                UserPoints += (int)UserCards[0].Value;
                UserCount++;

                CompCards[0] = Deck[CardCounter--];
                CompPoints += (int)CompCards[0].Value;
                CompCount++;

                UserCards[1] = Deck[CardCounter--];
                UserPoints += (int)UserCards[1].Value;
                UserCount++;

                CompCards[1] = Deck[CardCounter--];
                CompPoints += (int)CompCards[1].Value;
                CompCount++;

                //Играем с пользователем
                int GameCounter = 0;     //Счётчик количества прохода цикла игры пользователя
                string Choise = null;
                do
                {
                    if (GameCounter != 0)
                    {
                        if (Choise != "y")
                        {
                            Console.WriteLine("I dont't understand you!!!");
                            Console.WriteLine("Take one more card? y/n");
                            Choise = Console.ReadLine();
                            Console.Beep(500, 200);
                            continue;
                        }
                        else
                        {

                            Console.Clear();
                            UserCards[UserCount] = Deck[CardCounter--];
                            UserPoints += (int)UserCards[UserCount].Value;
                            UserCount++;
                        }
                    }

                    Console.WriteLine("You have: ");
                    Console.WriteLine();
                    for (int i = 0; i < UserCount; i++)
                    {
                        Console.WriteLine(UserCards[i].Value + " " + UserCards[i].Suit);
                    }
                    Console.WriteLine();
                    Console.WriteLine("It's " + UserPoints + " points");
                    Console.WriteLine("Take one more card? y/n");
                    Console.WriteLine();

                    Choise = Console.ReadLine();
                    Console.Beep(500, 200);
                    GameCounter++;
                }
                while (Choise != "n"); //конец игры с пользователем

                //Компьютер принимает решение
                Console.WriteLine("Now my turn");
                bool CompTake = true;        //Флаг для решения компьютера брать ли ещё карту 
                int CompDesicionCounter = 0; //Счётчик количества циклов компьтера для принятия решения
                do
                {
                    int Decision = rand.Next(3, 8);
                    if ((CompPoints + Decision) > 21)
                    {
                        CompTake = false;
                    }
                    else 
                    {
                        Console.WriteLine("I take one more");
                        Thread.Sleep(500);
                        CompTake = true;
                        CompCards[CompCount] = Deck[CardCounter--];
                        CompPoints += (int)CompCards[CompCount].Value;
                        CompCount++;
                    }

                    CompDesicionCounter++;
                }
                while (CompTake);  //Компьтер принял решение

                Console.WriteLine();

                Thread.Sleep(500);
                //Вывод результатов компьютера
                Console.WriteLine("I have: ");
                Thread.Sleep(1000);
                Console.WriteLine();
                for (int i = 0; i < CompCount; i++)
                {
                    Console.WriteLine(CompCards[i].Value + " " + CompCards[i].Suit);
                }
                Console.WriteLine();
                Console.WriteLine("It's " + CompPoints + "points");
                Thread.Sleep(500);

                //Флаги переполнения
                bool UserOverflow = UserPoints > 21;
                bool CompOverflow = CompPoints > 21;
                //Флаги выигрыша
                bool UserWin = false;
                bool CompWin= false;

                //Сравниваем результаты и подводим итоги игры
                if (UserOverflow && !CompOverflow)
                {
                    CompWin = true;
                    UserWin = false;
                }
                else if(!UserOverflow && CompOverflow)
                {
                    CompWin = false;
                    UserWin = true;
                }
                else if(!UserOverflow && !CompOverflow)
                {
                    if (UserPoints > CompPoints)
                    {
                        UserWin = true;
                        CompWin = false;
                    }
                    else if (UserPoints < CompPoints)
                    {
                        CompWin = true;
                        UserWin = false;
                    }
                }
                else
                {
                    if (UserPoints < CompPoints)
                    {
                        UserWin = true;
                        CompWin = false;
                    }
                    else if(UserPoints > CompPoints)
                    {
                        CompWin = true;
                        UserWin = false;
                    }
                }

                if(CompWin)
                {
                    Console.WriteLine("I won");
                    CompVictories++;
                }
                else if(UserWin)
                {
                    Console.WriteLine("You won");
                    UserVictories++;
                }
                else
                {
                    Console.WriteLine("It's draw");
                }

                Console.WriteLine("Game over");
                Thread.Sleep(2000);
                Console.WriteLine("More game? y/n");
                GameChoice = Console.ReadLine();
                Console.Beep(500, 200);

                Console.Clear();
            }
            while (GameChoice != "n"); // конец игры

            Console.Clear();
            Console.WriteLine("Your victories: " + UserVictories);
            Console.WriteLine("Comp victories: " + CompVictories);
        }
    }
}
