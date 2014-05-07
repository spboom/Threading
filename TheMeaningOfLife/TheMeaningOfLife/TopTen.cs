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
        private static int MAXSIZE = 10;
        public Ranking()
            :base()
        {
        }

        public static void add(SearchedFile file)
        {
            LinkedListNode<SearchedFile> node = ranking.First;

            while (node !=null)
            {
                if(node.Value.AmountFound < file.AmountFound)
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

        public static string showRanking()
        {
            String responce = "";
            LinkedListNode<SearchedFile> node = ranking.First;
            int i = 1;
            while (node!=null)
            {
                responce += "#" + i + ": " + node.Value.FileName + " " + node.Value.AmountFound + "\n";
                
                node = node.Next;
            }

            return responce;
        }

        public static void clearRanking()
        {
            ranking = new LinkedList<SearchedFile>();
        }

        public static bool canAdd(SearchedFile file)
        {
            if (ranking.Count < MAXSIZE)
            {
                return true;
            }
            return ranking.Last.Value.AmountFound < file.AmountFound;
        }
    }
}
