using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    public class Harvest
    {
        // A represents a row of trees, each with a number of apples
        // K and L represent the number of consecutive trees from 
        // which an individual will harvest
        // The method should return the optimal number of apples
        // which could be collected from spans K and L
        public static int HarvestTwoSections(int[] A, int K, int L)
        {

            // check whether possible to collect from K+L trees
            // if not possible return A.Length - (K+L)
            int totalTrees = K + L;
            if (A.Length - totalTrees < 0)
            {
                return A.Length - totalTrees;
            }

            // set best possible amount to 0
            int totalApplesCollected = 0;

            // set best number to be collected for K and L
            int kScore = 0;
            int lScore = 0;

            //need to know where K starts, so we know where we can get L from
            int kStartIndex = 0;

            for (int i = 0; i < A.Length - K + 1; i++)
            {
                // this may need to be set to A[i]
                int tempKScore = A[i];
                // for length of K, add the next tree
                for (int j = 1; j < K; j++)
                {
                    tempKScore += A[i + j];                 
                }

                //compare to previous kScore and assign if better
                if (tempKScore > kScore)
                {
                    kScore = tempKScore;
                    kStartIndex = i;
                }
            }

            // get best number for L 
            // check array before the span of K
            if (L <= kStartIndex)
            {
                for (int i = 0; i < kStartIndex; i++)
                {
                    int tempLScore = A[i];
                    for (int j = 1; j < L; j++)
                    {
                        tempLScore += A[i + j];
                    }

                    if (tempLScore > lScore)
                    {
                        lScore = tempLScore;                     
                    }
                }
            }

            //check array after span of K
            int kLastIndex = kStartIndex + K - 1;
            if (kLastIndex < A.Length - L)
            {
                // start one place after the end of K span, stop before the end
                // simple, right?
                for (int i = kLastIndex + 1; i < A.Length - L + 1; i++)
                {
                    int tempLScore = A[i];
                    for (int j = 1; j < L; j++)
                    {
                        tempLScore += A[i + j];
                    }

                    if (tempLScore > lScore)
                    {
                        lScore = tempLScore;
                    }
                }
            }

            totalApplesCollected = kScore + lScore;
            // get highest consecutive L a selection for lScore excluding K
            return totalApplesCollected;
        }

        public static int HarvestK(int[] A, int K)
        {
            int kScore = 0;
            for (int i = 0; i < A.Length - K+1; i++)
            {
                // this may need to be set to A[i]
                int tempKScore = A[i];
                // for length of K, add the next tree
                for (int j = 1; j < K; j++)
                {
                    tempKScore += A[i + j];

                }

                //compare to previous kScore and assign if better
                if (tempKScore > kScore)
                {
                    kScore = tempKScore;
                }
            }

            return kScore;
        }
    }
}
