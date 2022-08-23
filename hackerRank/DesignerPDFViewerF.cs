public static int designerPdfViewer(List<int> h, string word)
    {
        char[] alphabets = new char[26]
        {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p',           'q','r','s','t','u','v','w','x','y','z'}; 
        char[] x = word.ToCharArray();
        int temp = 0;
        for(int i = 0 ; i < x.Count() ; i++){
           for(int j = 0 ; j < h.Count; j++){
               if(x[i] == alphabets[j]){
                   if(temp < h[j])
                   {
                       temp = h[j];
                    }
               }
           }
        } 
        return (temp * (x.Count()));
    }}
