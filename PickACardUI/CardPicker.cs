using System;

namespace PickRandomCards
{
    public class CardPicker
    {
        static Random random = new Random();
        public static string[] PickSomeCards(int numberOfCards)
        {
            string[] pickedCards = new string[numberOfCards];
            for (int i = 0; i < numberOfCards; i++)
            {
                pickedCards[i] = RandomSuit()+RandomValue();
            }
            return pickedCards;
        }

        private static string RandomValue()
        {
            /// 取得一個從 1 到 13 的隨機數
            int value = random.Next(1, 14);

            /// 如果它是 1，回傳 Ace
            if (value == 1) return "A";

            /// 如果它是 1，回傳 Jack
            if (value == 11) return "J";

            /// 如果它是 1，回傳 Queen
            if (value == 12) return "Q";

            /// 如果它是 1，回傳 King
            if (value == 13) return "K";

            /// 如果還沒有回傳，回傳 value
            return value.ToString();
        }

        private static string RandomSuit()
        {
            /// 取得一個從 1 到 4 的隨機數
            int value = random.Next(1, 5);

            /// 如果它是 1，回傳 Spades
            if (value == 1) return "♠️";

            /// 如果它是 2，回傳 Hearts
            if (value == 2) return "♥️";

            /// 如果它是 3，回傳 Clubs
            if (value == 3) return "♣️";

            /// 如果還沒有回傳，回傳字串 Diamons
            return "♦️";
        }
    }
}
