/*
Time Complexity : O(m+n)
Space Complexity: (m+n)

*/


public class LeetCode1813 {
    public static bool AreSentencesSimilar(string sentence1, string sentence2) {
        
        var sent1List = sentence1.Split(' ');
        var sent2List = sentence2.Split(' ');

        if(sent1List.Length < sent2List.Length)
        {
            (sent1List, sent2List) = (sent2List, sent1List);
        }

        int left =0;
        
        while(left < sent2List.Length
        && sent1List[left] == sent2List[left]){
            left++;
        }

        int right=0;
        while(right < sent2List.Length &&
        sent1List[sent1List.Length - 1-right]== sent2List[sent2List.Length - 1-right])
        {
            right++;
        }


        return left+right >= sent2List.Length;
    }
}