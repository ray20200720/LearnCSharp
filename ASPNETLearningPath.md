前前後後有很多詢問ASP.NET的學習順序問題，在此就向打算系統學習ASP.NET技術的初學者談談我的建議。

如果你已經有較多的面向對象開發經驗，跳過以下這兩步：

第一步　掌握一門.NET物件導向語言，C#

我強烈反對在沒系統學過一門面向對象(OO)語言的前提下去學ASP.NET。

ASP.NET是一個全面向對象的技術，不懂OO，那絕對學不下去!

第二步　對.NET Framework類庫有一定的瞭解

可以通過開發Windows Form應用程序來學習.NET Framework。ASP.NET是建構在.NET

Framework之上的技術，你對.NET Framework瞭解得越深，學習ASP.NET就越快。

舉個例子：下面簡單列出幾個對掌握ASP.NET非常重要的概念：

物件的內存模型，委託，事件，多線程，程序集和應用程序域，安全模型

.NET Framework當然還有許多其它的東西，但不理解與把握清楚上述這些東西，是很難真正把握ASP.NET的。

出於急迫的心情與現實的考慮，不少人沒有紮實的面向對象基礎就想直接學習ASP.NET，其結果只能是欲速則不達。

在具備了OO基礎之後，以下是具體的學習ASP.NET技術步驟。

第一步：學習HTML與CSS

這並不需要去學一大堆的諸如Dreamweaver，Firework之類的各種網頁設計工具，關鍵是理解HTML網頁嵌套的block結構與CSS的box模型。許多ASP.NET控件最後都必須轉化爲HTML。而且，div+CSS是當前主流的網頁佈局模型。

學習這部分時，關鍵在於理解概念，而不需要將精力花在美化頁面的許多技巧上，那是網站美工的工作，不是程序員的工作。

第二步：學習JavaScript

JavaScript不是Java，它主要運行於瀏覽器端。可以完成許多工作，功能也很強大：比如它將客戶端網頁中的HTML元素看成一棵樹，可以編寫代碼訪問並修改樹節點，動態生成新的HTML代碼，從而達到動態修改網頁顯示特性的目的。

JavaScript在目前的網站開發中用得很多，非常重要。

另外，它也是目前非常流行的AJAX技術的基礎。

第三步：學習計算機網絡原理

找一本大學<計算機網絡>教材，重點看看它的有關互聯網的部分，瞭解一些域名解析和HTTP協議等知識。這是進行互聯網開發的理論基礎。

第四步：學習ASP.NET表示層技術，會設計Web頁面

需要結合先前打好的面向對象技術的基礎，至少掌握以下內容：

(1) 各種Web控件的使用方法，

(2) 理解信息在網頁中的傳送方式，比如Cookie，ViewState，Session等的使用。

(3) ASP.NET應用程序與網頁的生命週期，以及相關對象(比如httpcontext，response，request)的用途。

(4) ASP.NET實現事件驅動的內幕

(5) 自定義用戶控件

再次強調一下，沒有OO基礎，很難掌握上述技術，就只能被這些東東牽着鼻子走了，會很被動。

第五步　掌握數據庫技術

具體地說，要學習以下內容：

(1) 學會使用SQL　Server 2005：不要求精通它的各種工具與管理配置技術，但至少知道如何連接，如何建表，如何創建存儲過程

(2) 學習ADO.NET，掌握使用代碼人工訪問數據庫(別用VS2005的嚮導)的方法

(3) 學習數據綁定控件的使用

第六步　理解多層架構

這時，先前在OO學習階段涉及到的程序集與應用程序域等就派上用場了，現在，網站架構大多采用多層架構：表示層、業務邏輯層、數據存取層以及數據庫本身。

可以先上網找一此多層架構的資料看，再找一個現成的比較複雜的開源ASP.NET項目分析一下其架構就差不多了。基本上都是一個套路，到處應用。

有的朋友問：學習架構是不是必須學習設計模式。

我的看法是：不必!當然，你如果學習過設計模式，那當然更好。但在實際開發中，如果只想着機械地套用某種模式，反而起不到好的結果。我的觀點：在學習設計模式時要多思多悟，其思想就會漸漸地融入你的大腦，在真實的設計實踐中，忘掉所有的寫在書上的模式，一切從實際出發，相信你的直覺，只要達到設計要求的方案就是可行的方案，事實上，你這樣做了之後，回過頭來再看，會發現你的設計往往暗合設計模式的理論。

第七步　學習XML與Web Service

先了解XML的基礎知識，找本講XML的書看一下就差不多了，然後，再學習Web Service。Web Service其實可類比爲遠程方法調用(以XML格式表達的調用信息)。

學 到了這裏，如果你還有興趣，不妨再去看看SOA，不過SOA的資料都是理論與概念，看起來比較鬱悶，而且離實際開發可能比較遠。所以，這是可選項。

第八步　學習AJAX

學習AJAX的主要目的是創建具有更豐富特性的Web表示層，而經過前面七步的學習，到此再學習AJAX已水到渠成，所有的基礎都已具備，不會有太大的問題了。

在基礎未具備的前提下直接學AJAX，就象“浮沙之上築高臺”，所以，將AJAX的學習次序安排在這裏。

第九步　學習RIA技術

RIA：Rich internet application，可看成是將C/S與B/S優點合二爲一的嘗試。就具體技術來說，主要指微軟的Silverlight(WPF_E)，畢竟前頭一路行來都是微軟路線。

不過目前學習它主要是爲了技術儲備。估計此技術的普及需要2到3年的時間，因爲預裝Vista的機器今年纔開始大賣。 