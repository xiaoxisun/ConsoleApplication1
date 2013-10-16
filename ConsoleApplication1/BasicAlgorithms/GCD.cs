using System;

/*Euclid's algorithm or method of successive division
 *  Gcd can be found by repeatedly applying the division algorithm: a=bq+r; 
    Divide larger number a by the smaller number b, get quoation q and the remaider r. 
 *  if r is not 0, keep using the smaller number b divide the remaider r get another quoation and remaider. 
 *  
 * If x and y are positive integers with x  y, then gcd(x; y) = gcd(x mod y; y).
 * 
 * gcd(x; y) = gcd(x 􀀀 y; y)
 * 
 * Any integer that divides both x and y must also divide x - y,
 * 
 * Therefore, we may search instead for gcd{b,r}.
Since |r|<|b| and b∈Z, we will reach r=0 after finitely many steps.
At this point, gcd{r,0}=r from GCD with Zero.
 * 
 * http://www.proofwiki.org/wiki/Euclidean_Algorithm
 *  Complexity: O(n^3)
 *  Lemma If a  b, then a mod b < a=2.
Proof. Witness that either b  a=2 or b > a=2. These two cases are shown in the following
gure. If b  a=2, then we have a mod b < b  a=2; and if b > a=2, then a mod b = a 􀀀 b < a=2.
􀀀􀀀􀀀 
a a=2 b a
a mod b
b
a mod b
a=2
This means that after any two consecutive rounds, both arguments, a and b, are at the very
least halved in valuethe length of each decreases by at least one bit. If they are initially
n-bit integers, then the base case will be reached within 2n recursive calls. And since each
call involves a quadratic-time division, the total time is O(n3).
 *   
 * */
namespace BasicAlgorithms
{
    public class GCD 
    {

        public int GetGCD(int A, int B)
        {
            if (B == 0) return A;
            
            int r;
            r = A % B;

            if (r == 0) return B;
            else return GetGCD(B, r);
        }

        
    }

}
