public class Solution {

    public string Encode(IList<string> strs) {
        string result = "";
        foreach(string i in strs){
            result += i.Length.ToString() + " " + i;
        }
        return result;
    }

    public List<string> Decode(string s) {
        List<string> result = [];
        int i = 0;
        string decodedStr = "";
        while(i < s.Length){
            int decodedStrLen = s[i] - '0';
            while(s[i+1] != ' '){
                i += 1;
                decodedStrLen *= 10;
                decodedStrLen += s[i] - '0';
            }
            i += 2;
            int lastStrIndex = i + decodedStrLen;
           while(i < lastStrIndex) {
                decodedStr += s[i];
                i+=1;
            }
            result.Add(decodedStr);
            decodedStr  = "";
        }
        return result;
   }
}
