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
        // largeNumberOfTrees and smallNumberOfTrees represent the number of consecutive trees from 
        // which an individual will harvest
        // The method should return the optimal number of apples
        // which could be collected from spans largeNumberOfTrees and smallNumberOfTrees
        public static int HarvestTwoSections(int[] A, int K, int L)
        {

            // check whether possible to collect from largeNumberOfTrees+smallNumberOfTrees trees
            // if not possible return A.smallNumberOfTreesength - (largeNumberOfTrees+smallNumberOfTrees)
            int totalTrees = K + L;
            if (A.Length - totalTrees < 0)
            {
                return A.Length - totalTrees;
            }

            // set best possible amount to 0
            int totalApplesCollected = 0;

            // figure out which selection is large as this span
            // should have precendence
            int largeNumberOfTrees;
            int smallNumberOfTrees;

            if (K > L){
                largeNumberOfTrees = K;
                smallNumberOfTrees = L;
            } else {
                largeNumberOfTrees = L;
                smallNumberOfTrees = K;
            }

            // set best number to be collected for largeNumberOfTrees and smallNumberOfTrees
            int largeScore = 0;
            int smallScore = 0;

            //need to know where largeNumberOfTrees starts, so we know where we can get smallNumberOfTrees from
            int largeNumberOfTreesStartIndex = 0;

            for (int i = 0; i < A.Length - largeNumberOfTrees + 1; i++)
            {
                // this may need to be set to A[i]
                int templargeNumberOfTreesScore = A[i];
                // for length of largeNumberOfTrees, add the next tree
                for (int j = 1; j < largeNumberOfTrees; j++)
                {
                    templargeNumberOfTreesScore += A[i + j];                 
                }

                //compare to previous largeScore and assign if better
                if (templargeNumberOfTreesScore > largeScore)
                {
                    largeScore = templargeNumberOfTreesScore;
                    largeNumberOfTreesStartIndex = i;
                }
            }

            // get best number for smallNumberOfTrees 
            // check array before the span of largeNumberOfTrees
            if (smallNumberOfTrees <= largeNumberOfTreesStartIndex)
            {
                for (int i = 0; i < largeNumberOfTreesStartIndex; i++)
                {
                    int tempsmallNumberOfTreesScore = A[i];
                    for (int j = 1; j < smallNumberOfTrees; j++)
                    {
                        tempsmallNumberOfTreesScore += A[i + j];
                    }

                    if (tempsmallNumberOfTreesScore > smallScore)
                    {
                        smallScore = tempsmallNumberOfTreesScore;                     
                    }
                }
            }

            //check array after span of largeNumberOfTrees
            int largeNumberOfTreessmallNumberOfTreesastIndex = largeNumberOfTreesStartIndex + largeNumberOfTrees - 1;
            if (largeNumberOfTreessmallNumberOfTreesastIndex < A.Length - smallNumberOfTrees)
            {
                // start one place after the end of largeNumberOfTrees span, stop before the end
                // simple, right?
                for (int i = largeNumberOfTreessmallNumberOfTreesastIndex + 1; i < A.Length - smallNumberOfTrees + 1; i++)
                {
                    int tempsmallNumberOfTreesScore = A[i];
                    for (int j = 1; j < smallNumberOfTrees; j++)
                    {
                        tempsmallNumberOfTreesScore += A[i + j];
                    }

                    if (tempsmallNumberOfTreesScore > smallScore)
                    {
                        smallScore = tempsmallNumberOfTreesScore;
                    }
                }
            }

            totalApplesCollected = largeScore + smallScore;
            // get highest consecutive smallNumberOfTrees a selection for smallScore excluding largeNumberOfTrees
            return totalApplesCollected;
        }

        public static int HarvestlargeNumberOfTrees(int[] A, int largeNumberOfTrees)
        {
            int largeScore = 0;
            for (int i = 0; i < A.Length - largeNumberOfTrees+1; i++)
            {
                // this may need to be set to A[i]
                int templargeNumberOfTreesScore = A[i];
                // for length of largeNumberOfTrees, add the next tree
                for (int j = 1; j < largeNumberOfTrees; j++)
                {
                    templargeNumberOfTreesScore += A[i + j];

                }

                //compare to previous largeScore and assign if better
                if (templargeNumberOfTreesScore > largeScore)
                {
                    largeScore = templargeNumberOfTreesScore;
                }
            }

            return largeScore;
        }
    }
}
