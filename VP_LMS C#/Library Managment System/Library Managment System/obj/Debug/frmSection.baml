   M S B A M L   `   `   `  ����  Library Managment System)    #Library_Managment_System.frmSection   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  
frmSection��5   	    � WindowStartupLocation$ CenterScreen=�6�    � WindowState$ 	Maximized=�6�    � 
ResizeMode$ NoResize=�6�   ��6   �� *&$SystemParameters.PrimaryScreenHeight+��6U   �� *%#SystemParameters.PrimaryScreenWidth+.��5      � ��5   
   �� 5       �� ImageSource$K EMedia/Dark-background-simple-black-and-white-liniar-background-hd.jpg��6   .+�5	   
   �� ���	#FFF4F4F5$
��Left=�6%   $	��216��6@   $��	23,65,0,0q�6M   
���   �$	��Top=�6o   $	��491��6�   �� 5
   
   ���	#FFF4F4F5$
��Left=�6%   $	��225��6@   $��
23,313,0,0q�6M   
���   �$	��Top=�6p   $	��491��6�   �� 5   
   ���	#FFF4F4F5$
��Left=�6%   $	��225��6@   $��542,313,0,0q�6M   
���   �$	��Top=�6q   $	��491��6�   �� 5   
   
���   �$��1q�6%   $
��Left=�69   $��85��6T   $��567,432,0,0q�6`   $	��Top=�6u   $	��450��6�   �� 5   
   $��Section Name:��6   $
��Left=�6(   $��
56,126,0,0q�6C   $	��Top=�6W   �� 5   
   -   5         ��Name$ 
txtSecName��5      $
��Left=�6&   $��23��6A   $��
56,157,0,0q�6M    �� TextWrapping$
 Wrap=�6a   $	��Top=�6u   $	��429��6�   �� 5   
   $��Section:��6   $
��Left=�6#   $��	36,10,0,0q�6>   $	��Top=�6Q   $
��Bold"�6i   $��30(�6{   �� 5   
   -   5         ��Name$ btnClose��5      $
��Back��6#   $
��Left=�62   $��958,543,0,0q�6M   $	��Top=�6b   $��75��6z    J� RenderTransformOrigin$ 
1.413,0.45&�6�   $��52��6�   6�   �� 5   
   -   5        $ btnSectionUpdate��5   "   $��Update��6   $
��Left=�6<   $��922,454,0,0q�6W   $	��Top=�6l   $��75��6�   $��52��6�   6�   �� 5   
   -   5        $ btnSectionSearch��5   "   $��Search��6   $
��Left=�6<   $��312,332,0,0q�6W   $	��Top=�6l   $��64��6�   $��52��6�   $ 
0.75,0.526&�6�   �� 5   
   -   5        $ btnSecDelete��5   "   $��Delete��6   $
��Left=�68   $��922,366,0,0q�6S   $	��Top=�6h   $��75��6�   $��52��6�   6�   �� 5   
   -   5        $ btnSaveSection��5       $
��Save��6   $
��Left=�68   $��410,208,0,0q�6S   $	��Top=�6h   $��75��6�   $��52��6�   6�   �� 5   
   -   5        $ btnViewAllSections��5   -   $��View All Sections��6   $
��Left=�6I   $��381,332,0,0q�6d   $	��Top=�6y   $	��113��6�   $��52��6�   6�   �� 5   
   $��Search By Id:��6   $
��Left=�6(   $��
36,355,0,0q�6C   $	��Top=�6W   �� 5   
   -   5        $��txtSearchSection��5      $
��Left=�6*   $��23��6E   $��118,358,0,0q�6Q   $
 Wrap=�6f   $	��Top=�6z   $	��189��6�   �� 5   
   $��	Enter Id:��6   $
��Left=�6$   $��562,386,0,0q�6?   $	��Top=�6T   �� 5   
   $��Enter Name:��6   $
��Left=�6&   $��590,480,0,0q�6A   $	��Top=�6V   �� 5   
   -	   5        $��txtGiveSecId��5      $
��Left=�6&   $��23��6A   $��621,389,0,0q�6M   $
 Wrap=�6b   $	��Top=�6�   $	��263��6�   ��6v   Z� 6�   �� 5   
   -
   5        $��txtGiveSecName��5      $
��Left=�6(   $��23��6C   $��670,483,0,0q�6O   $
 Wrap=�6d   $	��Top=�6�   $	��238��6�   $ 0.367,0.609&�6�   ��6x   Z� 6�   &   System.Windows.Controls.DataGrid  5   
   -   5        	  Name$	 	dgSection��5      
   AutoGenerateColumns
 .  $
��Left=�6B   $	��140��6]   $��
38,389,0,0q�6j   $	��Top=�6~   $	��456��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Section Id��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 69   �� *	sectionId+  5       $ Section Name��6%    6;   �� *sectionName+5"      �� 5#   
   $��Add new section:��6   $
��Left=�6+   $��	56,81,0,0q�6F   $	��Top=�6Y   $ -1.237,1&�6q   $	��205��6�   $
��Bold"�6�   $��16(�6�   �� 5$   
   $��Search and view section:��6   $
��Left=�63   $��
38,322,0,0q�6N   $	��Top=�6b   $ -1.237,1&�6z   $	��212��6�   $
��Bold"�6�   $��16(�6�   �� 5%   
   $ ��Update and delete section:��6   $
��Left=�65   $��562,331,0,0q�6P   $	��Top=�6e   $ -1.237,1&�6}   $	��231��6�   $
��Bold"�6�   $��16(�6�   �� 5&   
   $��Update:��6   $
��Left=�6"   $��590,432,0,0q�6=   $	��Top=�6R   $ -1.237,1&�6j   $	��231��6�   $
��Bold"�6�   $��16(�6�   �� 5'   
   $��542,65,16,326q�6   $��section.jpg��6'   $
��Fill=�6<   5)      5*      