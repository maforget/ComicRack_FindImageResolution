import clr
clr.AddReference('FindImageResolutionNET')
from FindImageResolutionNET import frmConfig, Plugin


#@Name	Find Image Resolution (.NET) Config
#@Enabled	true
#@Hook	Library
def Config(books):
    frm = frmConfig()
    frm.ShowDialog()


#@Name	Find Image Resolution (.NET)
#@Key	FindImageResolutionNET
#@Hook	Books
#@Enabled	true
#@Description	Find the resolution of the images inside a book
def Process(books):
    try:
        Plugin.Run(ComicRack.App, books)
    except Exception as e:
        print('Generic Exception: ', e)
        return