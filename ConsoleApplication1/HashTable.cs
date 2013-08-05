using System;

/*
 * While not all problems can be solved with hash tables, a shocking number of interview problems
can be. Before your interview, make sure to practice both using and implementing hash tables.
1 public HashMap<Integer, Student> buildMap(Student[] students) {
2 HashMap<Integer, Student> map = new HashMap<Integer, Student>();
3 for (Student s : students) map.put(s.getId(), s);
4 return map;
5 }
 * 
 * It's a fairly standard interview question that shows you understand the underlyig concepts being useful java datastructres like HashSets and HashMaps.

You would use an array of lists, these are normally referred to as buckets. You start your hashtable with a given capacity n meaning you have a array of 10 lists (all empty).

To add an object to your hastable you call the objects hashCode function which gives you an int (a number in a pretty big range). So you then have to modulo the hashCode wrt to n to give you the bucket it lives in. Add the object to the end of the list in that bucket.

To find an object you again use the hashCode and mod function to find the bucket and then need to iterate through the list using .equals() to find the correct object.

As the table gets fuller you will end up doing more and more linear searching so you will eventually need to re-hash. This means building an entirely new, larger table and putting the objects into it again.

Instead of using a List in each array position you can recalulate a different bucket position if the one you want is full, a common method is quadratic probing. This has the advantage of not needed any dynamic data structures like lists but is more complicated.
 */
namespace BasicDataStructure
{
    public class HashTable 
    {
        string[,] Table;
        int M;

        public HashTable(int m) {
            Table = new string[m,2];
            M = m;//get Hashtable Size;
        }

        //This function sums the ASCII values of the letters in a string.
        //http://research.cs.vt.edu/AVresearch/hashing/strings.php
        public int hashFunction(string key){
            char[] ch;
            ch = key.ToCharArray();

            int sum=0;
            for (int i = 0; i < key.Length; i++)
            {
                sum += ch[i];
            }

            return sum % M;

        }

        public void Add(string key, string value){
            int index=hashFunction(key);
            Table[index,0] = key;
            Table[index, 1] = value;
        }

        public string Get(string key){
            string sData = "";
            int index = hashFunction(key);
            sData=Table[index,1];

            return sData;
        }


        
    }

}
