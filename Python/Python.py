import clr
import sys
import System
clr.AddReference('System.Windows.Forms')
from System.Windows.Forms import *

clr.AddReference('System.Drawing')
from System.Drawing import *

clr.AddReference('FindImageResolution')
from FindImageResolution.Dialog import frmConfig
from FindImageResolution import Plugin

from cYo.Projects.ComicRack.Engine import *

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