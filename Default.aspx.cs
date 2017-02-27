using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TweetSharp;

public partial class _Default : System.Web.UI.Page
{
    public static string _consumerKey = "L7kiLj2qE7U8k7EQ8qLT55eWP"; // Your key
    public static string _consumerSecret = "JGl3xQnSwYVJSCawO0sHl2fr8k01n3QtnOf89NApe20piYHUw2"; // Your key  
    public static string _accessToken = "112651960-FupI4cFa16PqbkZwyl7Svl5h1zgM3rFeZQUD5XPD"; // Your key  
    public static string _accessTokenSecret = "it34yTYeCYHKgsHtQnprWDKwar8KpDqfpfulMDEHu4RID";
    public string str;
    public int cstr=0;
    public string search;
    public string disdik;
    public int cdik=0;
    public string dishub;
    public int chub=0;
    public string diskes;
    public int ckes=0;
    public string disbud;
    public int cbud=0;
    public string distam;
    public int ctam=0;
   
    protected void Page_Load(object sender, EventArgs e)
    {
        
        
    }


    protected void button_Search_ServerClick(object sender, EventArgs e)
    {

        string query = keyword.Text;
        string key_diskes = keydiskes.Text;
        string key_disdik = keydisdik.Text;
        string key_dishub = keydishub.Text;
        string key_disbud = keydisbud.Text;
        string key_distam = keydistam.Text;
        TwitterService twitterService = new TwitterService(_consumerKey, _consumerSecret);
        twitterService.AuthenticateWith(_accessToken, _accessTokenSecret);
        List<StringPattern> Keyword_Search = new List<StringPattern>();
        List<TwitterStatus> resultList = new List<TwitterStatus>();
        if (query != null)
        {
            ParseString(query, Keyword_Search, 0);
            foreach (var item in Keyword_Search)
            {
                var tweets_search = twitterService.Search(new SearchOptions { Q = item.Data, Resulttype = TwitterSearchResultType.Recent, Count = 100 });
                foreach (var tweet in tweets_search.Statuses)
                {
                    resultList.Add(tweet);
                }

            }
            //Resulttype can be TwitterSearchResultType.Popular or TwitterSearchResultType.Mixed or TwitterSearchResultType.Recent 
            List<StringPattern> Final = new List<StringPattern>();
            ParseString(key_diskes, Final, 1);
            ParseString(key_dishub, Final, 2);
            ParseString(key_disdik, Final, 3);
            ParseString(key_disbud, Final, 4);
            ParseString(key_distam, Final, 5);
            foreach(var tweet in resultList)
            {
                String locat = SearchLocat(tweet);
                if (button_kmp.Checked)
                {
                    int kategori = FindCategoryKMP(tweet, Final);
                    AddtoKategori(tweet, kategori,locat);
                }
                else
                if(button_bm.Checked)
                {
                    int kategori = FindCategoryBM(tweet, Final);
                    AddtoKategori(tweet, kategori,locat);
                }
            }

        }
    }

    public void AddtoKategori(TwitterStatus tweet,int Category,String locat)
    {
        String a = "https://www.google.co.id/maps/search/" +locat;
        
        if (Category == 1)
        {
            diskes += "<li>";
            diskes += "<a class='thumbnail' href=" + tweet.User.ProfileImageUrlHttps + "><img src=" + tweet.User.ProfileImageUrl + " alt='Team Member'></a>";
            diskes += "<div class='content'>";
            diskes += "<h3><a href=\"https://twitter.com/" + tweet.User.ScreenName + "\">" + tweet.User.ScreenName + "</a></h3>";
            diskes += "<span class='preview'>" + tweet.TextAsHtml + "</span>";
            diskes += "<span class='meta'>" + tweet.CreatedDate + "&middot;<a href = "+a+" > Location </a></span>";
            diskes += "</div>";
            diskes += "</li>";
            ckes++;
        }
        else
        if (Category == 2)
        {
            dishub += "<li>";
            dishub += "<a class='thumbnail' href=" + tweet.User.ProfileImageUrlHttps + "><img src=" + tweet.User.ProfileImageUrl + " alt='Team Member'></a>";
            dishub += "<div class='content'>";
            dishub += "<h3><a href=\"https://twitter.com/" + tweet.User.ScreenName + "\">" + tweet.User.ScreenName + "</a></h3>";
            dishub += "<span class='preview'>" + tweet.TextAsHtml + "</span>";
            dishub += "<span class='meta'>" + tweet.CreatedDate + "&middot;<a href = "+a+" > Location </a></span>";
            dishub += "</div>";
            dishub += "</li>";
            chub++;
        }
        else
        if (Category == 3)
        {
            disdik += "<li>";
            disdik += "<a class='thumbnail' href=" + tweet.User.ProfileImageUrlHttps + "><img src=" + tweet.User.ProfileImageUrl + " alt='Team Member'></a>";
            disdik += "<div class='content'>";
            disdik += "<h3><a href=\"https://twitter.com/" + tweet.User.ScreenName + "\">" + tweet.User.ScreenName + "</a></h3>";
            disdik += "<span class='preview'>" + tweet.TextAsHtml + "</span>";
            disdik += "<span class='meta'>" + tweet.CreatedDate + "&middot;<a href = "+a+" > Location </a></span>";
            disdik += "</div>";
            disdik += "</li>";
            cdik++;
        }
        else
        if (Category == 4)
        {
            disbud += "<li>";
            disbud += "<a class='thumbnail' href=" + tweet.User.ProfileImageUrlHttps + "><img src=" + tweet.User.ProfileImageUrl + " alt='Team Member'></a>";
            disbud += "<div class='content'>";
            disbud += "<h3><a href=\"https://twitter.com/" + tweet.User.ScreenName + "\">" + tweet.User.ScreenName + "</a></h3>";
            disbud += "<span class='preview'>" + tweet.TextAsHtml + "</span>";
            disbud += "<span class='meta'>" + tweet.CreatedDate + "&middot;<a href = "+a+" > Location </a></span>";
            disbud += "</div>";
            disbud += "</li>";
            cbud++;
        }
        else
        if (Category == 5)
        {
            distam += "<li>";
            distam += "<a class='thumbnail' href=" + tweet.User.ProfileImageUrlHttps + "><img src=" + tweet.User.ProfileImageUrl + " alt='Team Member'></a>";
            distam += "<div class='content'>";
            distam += "<h3><a href=\"https://twitter.com/" + tweet.User.ScreenName + "\">" + tweet.User.ScreenName + "</a></h3>";
            distam += "<span class='preview'>" + tweet.TextAsHtml + "</span>";
            distam += "<span class='meta'>" + tweet.CreatedDate + "&middot;<a href = "+a+" > Location </a></span>";
            distam += "</div>";
            distam += "</li>";
            ctam++;
        }
        else
        {
            str += "<li>";
            str += "<a class='thumbnail' href=" + tweet.User.ProfileImageUrlHttps + "><img src=" + tweet.User.ProfileImageUrl + " alt='Team Member'></a>";
            str += "<div class='content'>";
            str += "<h3><a href=\"https://twitter.com/" + tweet.User.ScreenName + "\">" + tweet.User.ScreenName + "</a></h3>";
            str += "<span class='preview'>" + tweet.TextAsHtml + "</span>";
            str += "<span class='meta'>" + tweet.CreatedDate + "&middot;<a href = "+a+" > Location </a></span>";
            str += "</div>";
            str += "</li>";
            cstr++;
        }
    }

    public void ParseString(String S, List<StringPattern> Final, int kategori)
    {
        if (S != null)
        {
            List<String> TS = new List<String>();//Ganti List
            String temp = "";
            //MISAHIN COMA atau TITIK COMA
            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] == ',' || S[i]==';')
                {
                    TS.Add(temp);

                    temp = "";
                }
                else
                {
                    temp = temp + S[i];
                }
            }
            TS.Add(temp);

            //MISAHIN SPASI

            //GantiList
            for (int i = 0; i < TS.Count; i++)
            {
                List<String> tempTs = new List<String>();
                if (TS.ElementAt(i) != null)
                {
                    String temp1 = "";
                    for (int l = 0; l < TS.ElementAt(i).Length; l++)
                    {

                        if (TS.ElementAt(i)[l] != ' ')
                        {
                            temp1 = temp1 + TS.ElementAt(i)[l];

                        }
                        else
                        {
                            if (temp1 != "")
                            {
                                tempTs.Add(temp1);
                                temp1 = "";
                            }
                        }
                    }
                    tempTs.Add(temp1);
                    for (int l = 0; l < tempTs.Count; l++)
                    {
                        //Console.WriteLine(tempTs.ElementAt(l));
                    }
                    StringPattern TP = new StringPattern();
                    TP.Data = tempTs[0];
                    TP.Kategori = kategori;
                    for (int l = 1; l < tempTs.Count; l++)
                    {
                        if (tempTs.ElementAt(l) != null && tempTs.ElementAt(l) != "")
                        {
                            StringPattern temp2 = new StringPattern();
                            temp2.Data = tempTs.ElementAt(l);
                            temp2.Kategori = kategori;
                            TP.AddEl(temp2);
                        }
                    }
                    Final.Add(TP);
                }

            }
        }
    }

    public int FindCategoryKMP(TwitterStatus tweet,List<StringPattern> Final)
    {
        int kategori =0;
        String TField = tweet.Text.ToLower();
        List<StringPattern> Find = new List<StringPattern>();
        foreach (var item in Final)
        {
            if (item.Next == null)
            {
                KMP kmp = new KMP(item.Data.ToLower());
                if (kmp.Search(TField) != -1)
                {
                    Find.Add(item);
                }
            }
            else
            {
                StringPattern P = new StringPattern();
                P = item;
                bool valid = true;
                while (P != null)
                {
                    KMP kmp = new KMP(P.Data.ToLower());
                    if (kmp.Search(TField) == -1)
                    {
                        valid = false;
                        break;
                    }
                    P = P.Next;
                }
                if (valid == true)
                {
                    Find.Add(item);
                }
            }
        }
        int min = 999;
        foreach (var item in Find)
        {
            KMP kmp = new KMP(item.Data.ToLower());
            if (kmp.Search(TField) < min)
            {
                min = kmp.Search(TField);
            }

        }
        foreach (var item in Find)
        {
            KMP kmp = new KMP(item.Data.ToLower());
            if (kmp.Search(TField) == min)
            {
                kategori = item.Kategori;
            }

        }
        return kategori;
    }

    public int FindCategoryBM(TwitterStatus tweet, List<StringPattern> Final)
    {
        int kategori = 0;
        String TField = tweet.Text.ToLower();
        List<StringPattern> Find = new List<StringPattern>();
        foreach (var item in Final)
        {
            if (item.Next == null)
            {
                BoyerMoore bm = new BoyerMoore(item.Data.ToLower());
                if (bm.Search(TField) != -1)
                {
                    Find.Add(item);
                }
            }
            else
            {
                StringPattern P = new StringPattern();
                P = item;
                bool valid = true;
                while (P != null)
                {
                    BoyerMoore bm = new BoyerMoore(P.Data.ToLower());
                    if (bm.Search(TField) == -1)
                    {
                        valid = false;
                        break;
                    }
                    P = P.Next;
                }
                if (valid == true)
                {
                    Find.Add(item);
                }
            }
        }
        int min = 999;
        foreach (var item in Find)
        {
            BoyerMoore bm = new BoyerMoore(item.Data.ToLower());
            if (bm.Search(TField) < min)
            {
                min = bm.Search(TField);
            }

        }
        foreach (var item in Find)
        {
            BoyerMoore bm = new BoyerMoore(item.Data.ToLower());
            if (bm.Search(TField) == min)
            {
                kategori = item.Kategori;
            }

        }
        return kategori;
    }

    public String SearchLocat(TwitterStatus tweet)
    {
        String locat="";
        String s = "di ";
        String TField = tweet.Text.ToLower();
        KMP kmp = new KMP(s);
        if (kmp.Search(TField) != -1)
        {
            int begin = kmp.Search(TField) + s.Length;
            String temp = "";
            for (int i = begin; i < TField.Length; i++)
            {
                if (TField[i] != ' ')
                {
                    temp = temp + TField[i];
                }
                else
                {
                    if (temp != "")
                    {
                        if (MatchLocat(temp))
                        {
                            locat = locat + temp ;
                            temp = "";
                        }
                        else
                        {
                            locat = locat + temp;
                            return locat;
                        }
                    }
                }
            }
        }
        return locat;
        
       
    }

    public bool MatchLocat(String place)
    {
        List<String> Dictionary = new List<String>();
        Dictionary.Add("gedung");Dictionary.Add("jalan"); Dictionary.Add("jl"); Dictionary.Add("jln"); Dictionary.Add("rumah");Dictionary.Add("terminal");Dictionary.Add("kampus");Dictionary.Add("jl.");Dictionary.Add("bukit");Dictionary.Add("daerah");Dictionary.Add("kota"); Dictionary.Add("desa");Dictionary.Add("taman");Dictionary.Add("sekolah"); Dictionary.Add("gereja");Dictionary.Add("masjid");Dictionary.Add("mall");Dictionary.Add("institut");Dictionary.Add("teknologi");Dictionary.Add("Asia"); Dictionary.Add("pasar"); Dictionary.Add("cafe");Dictionary.Add("salon");Dictionary.Add("hotel");Dictionary.Add("apotek"); Dictionary.Add("dokter");Dictionary.Add("sakit"); Dictionary.Add("buah");Dictionary.Add("sakit");Dictionary.Add("teknik");Dictionary.Add("travel");Dictionary.Add("harapan");Dictionary.Add("kfc");Dictionary.Add("macd"); Dictionary.Add("universitas");Dictionary.Add("bank");Dictionary.Add("sd"); Dictionary.Add("smp");Dictionary.Add("sma");Dictionary.Add("smk");Dictionary.Add("negeri");Dictionary.Add("1"); Dictionary.Add("2");Dictionary.Add("3");Dictionary.Add("4"); Dictionary.Add("5"); Dictionary.Add("6"); Dictionary.Add("7"); Dictionary.Add("8"); Dictionary.Add("9"); Dictionary.Add("0");Dictionary.Add("toko"); Dictionary.Add("buku");Dictionary.Add("obat"); Dictionary.Add("pos");Dictionary.Add("polisi");Dictionary.Add("kantor");Dictionary.Add("pusat");Dictionary.Add("pt"); Dictionary.Add("dinas");Dictionary.Add("lapangan");Dictionary.Add("gelanggang");Dictionary.Add("kolam"); Dictionary.Add("renang");
        Dictionary.Add("spa"); Dictionary.Add("gelap");
        foreach (var tempat in Dictionary)
        {
            if (place.ToLower() == tempat)
            {
                return true;
            }
        }
        return false;

    }
}