using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMeaningOfLife
{
    class Ranking
    {
        private static LinkedList<SearchedFile> ranking = new LinkedList<SearchedFile>();

        private static LinkedList<SearchedFile> RankingProp
        {
            get { return Ranking.ranking; }
            set { Ranking.ranking = value; }
        }
        private static int MAXSIZE = 10;
        public Ranking()
            : base()
        {
        }

        public static void add(SearchedFile file)
        {
            lock (RankingProp)
            {
                LinkedListNode<SearchedFile> node = ranking.First;
                if (ranking.Count == 0)
                {
                    ranking.AddFirst(file);
                }
                else
                {
                    while (node != null)
                    {
                        if (node.Value.AmountFound < file.AmountFound)
                        {
                            ranking.AddBefore(node, file);

                            if (ranking.Count > MAXSIZE)
                            {
                                ranking.RemoveLast();
                            }
                            break;
                        }
                    }
                }
                showRanking();
            }
        }

        public static void showRanking()
        {
            lock (RankingProp)
            {
                LinkedListNode<SearchedFile> node = ranking.First;
                int i = 1;
                while (node != null)
                {
                    Console.WriteLine("#" + i + ": " + node.Value.FileName + " " + node.Value.AmountFound);
                    i++;

                    node = node.Next;
                }
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine();
                }

            }
        }

        public static void clearRanking()
        {
            lock (RankingProp)
            {
                ranking = new LinkedList<SearchedFile>();
            }
        }

        public static bool canAdd(SearchedFile file)
        {
            lock (RankingProp)
            {
                if (ranking.Count < MAXSIZE)
                {
                    return true;
                }
                return ranking.Last.Value.AmountFound < file.AmountFound;
            }
        }
    }
}
