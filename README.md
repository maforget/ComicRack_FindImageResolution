# Find Image Resolution for ComicRack

<p align="center">
    <b><u><span style='font-size:14.0pt'>👇 Download Links 👇</span></u></b>
</p>
<p align="center">
    <a href="https://github.com/maforget/ComicRack_FindImageResolution/releases/latest/download/FindImageResolutionNET.crplugin" alt="Latest Release">
      <img src="https://img.shields.io/github/v/release/maforget/ComicRack_FindImageResolution?label=latest%20release&logo=github" /></a>
    <a href="https://github.com/maforget/ComicRack_FindImageResolution/releases/download/nightly/FindImageResolutionNET.crplugin" alt="Pre-Release">
      <img src="https://img.shields.io/github/v/release/maforget/ComicRack_FindImageResolution?include_prereleases&label=pre-release&logo=github" /></a>
</p>
  
#### This plugin will check the resolution of the images inside a book and get the value for the one that occurs the most,

Configuration are in File => Automation => Find Image Resolution (.NET) Config.
It uses the Library Organizer Syntax, so anything between the `{` and `<` and `>` with `}` will be added as prefix & suffix. If the field is null or empty then no prefix & suffix will be used. You can use the GUI to easily set your commnds just like in the Library Organizer plugin. You can use any field, even custom fields.

![image](https://user-images.githubusercontent.com/11904426/229339516-f9531a33-2a6f-4ac1-917a-bcb77e7024a2.png)

Normal replacement. "X" and "px" before and after Height will only be inserted if it has a value.

![image](https://user-images.githubusercontent.com/11904426/229339517-87964dc2-4d8b-44de-8550-8b4ad51bf66f.png)

You can also add any text outside the "{" "}" and it will always be inserted.

![image](https://user-images.githubusercontent.com/11904426/229339508-c42896ee-fcc7-4ae6-9d30-4177d9adb633.png)

If you want to use Append Mode, add the field that you are targetting in the command. This will always be in the dropdown menu (Insert into Field).
In the present example, a space will be added only if the ScanInformation field already contains a value. And if you don't want a space, can change it anything or a dot, or anything.
So if ScanInformation contains "TONER" => "TONER 2598px" and if empty "2598px".

![image](https://user-images.githubusercontent.com/11904426/229339889-e217abe0-70a8-4131-865a-c2fbbc88caef.png)

To have a new line between existing text, after inserting in the textbox just add a new line.

![image](https://user-images.githubusercontent.com/11904426/229339512-d1d665e6-179b-4781-bb61-7bee343250ce.png)

You can use any field, even if they are not in the dropdown menu, if a field does not exist it will look in the Custom fields.
(Note: fields are case-sensitive)

P.S. When you click on Add, it will add the text to the last place where you placed your cursor.

----

Some pages are already cached by ComicRack (Fast pages) which means that the resolution is already loaded in memory. Some pages aren't, which mean that for the pages that weren't cached, we need to load them in memory one by one (Slow Inspection). There is a config that is named % of Slow Inpsection, that will check which percentage of the slow pages (not cached) we should individually check, one by one. A higher percentage will be more precise, but since usually all the pages are the same resolution, using a low percentage will give you a faster result. I personally use a 25% setting and find it adequate.

Usage is done via Right-Click => Automation => Find Image Resolution (.NET).


Normally ComicRack plugins uses IronPython (a mixture of Python & .NET Framework). This is now obsolete and very hard to develop & debug for, so this plugin is made from scratch completely with the .NET Framework. The only python code is to call the .NET Code (1 line).


----

##### Also for ComicRack:

- ###### [Data Manager](https://github.com/maforget/CRDataManager) let's you manipulate your data for ComicRack. Fix the various bugs in the latest v2 release.
- ###### [Keygen for ComicRack](https://github.com/maforget/ComicRackKeygen). A keygen to activate because of the now dead website. Also includes the Android Client, RAR5 Support Pack to enable RAR5 functionality and additional fixes.
- ###### [Bédéthèque Scrapper v2](https://github.com/maforget/Bedetheque-Scrapper-2) to scrap data from the French BD site Bédétheque.
- ###### [Amazon Scrapper for ComicRack](https://github.com/maforget/ComicRack_AmazonScrapper). A Scrapper for Amazon books (former Comixology library).
- ###### [fullscreen.py](https://gist.githubusercontent.com/maforget/186a99205140acd3f7d3328ad1466e62/raw/8c7c0ecab28fb9a6037adbe19ff553e3597cccd6/fullscreen.py). It will automatically fullscreen the application when either opening a book or starting the application depending on which you enable). Copy the file in either `%programfiles%\ComicRack\Scripts` or `%appdata%\cYo\ComicRack\Scripts`.
- ###### [comicrack-copy-move-field](https://github.com/maforget/comicrack-copy-move-field). Moves or copies info from one field to another. Can either replace or append to the destination field. Small update from the original to permit dates to be copied or moved.
