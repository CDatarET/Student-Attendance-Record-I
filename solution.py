class Solution:
    def checkRecord(self, s):
        a = 0
        l = 0

        for i in range(len(s)):
            c = s[i]

            if c != "L":
                l = 0
                if c == "A":
                    a += 1
            else:
                l += 1
            
            if l == 3:
                return False
        
        return a < 2
