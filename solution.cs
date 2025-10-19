public class Solution {
    public bool CheckRecord(string s) {
        int a = 0;
        int l = 0;

        for(int i = 0; i < s.Length; i++){
            char c = s[i];

            if(c != 'L'){
                l = 0;
                if(c == 'A'){
                    a++;
                }
            }
            else{
                l++;
            }

            if(l == 3){
                return(false);
            }
        }

        return(a < 2);
    }
}
