   M S B A M L   `   `   `  ����  Library Managment System&     Library_Managment_System.frmRack   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5          � Title$
  Rack��5   	   $��639.478��6   $��1057.552��6(    � WindowStartupLocation$ CenterScreen=�6P    � WindowState$ 	Maximized=�6u    � 
ResizeMode$ NoResize=�6�   .��5      � ��5   
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
�������$��Rack:��6(   $
��Left=�68   $��	36,10,0,0q�6S   $	��Top=�6f   $
��Bold"�6~   $��30(�6�   �� 5   
   -   5         ��Name$ btnClose��5      $
��Back��6#   $
��Left=�62   $��958,543,0,0q�6M   $	��Top=�6b   $��75��6z    J� RenderTransformOrigin$ 
1.413,0.45&�6�   $��52��6�   6�   �� 5   
   -   5        $ btnRackSearch��5   "   $��Search��6   $
��Left=�69   $��312,332,0,0q�6T   $	��Top=�6i   $��64��6�   $��52��6�   $ 
0.75,0.526&�6�   6�   �� 5   
   -   5        $ btnRackDelete��5   "   $��Delete��6   $
��Left=�69   $��932,462,0,0q�6T   $	��Top=�6i   $��75��6�   $��52��6�   6�   �� 5   
   -   5        $ btnSaveRack��5       $
��Save��6   $
��Left=�65   $��410,200,0,0q�6P   $	��Top=�6e   $��75��6}   $��52��6�   6�   �� 5   
   -   5        $ btnViewAllRackss��5   *   $��View All Racks��6   $
��Left=�6D   $��381,332,0,0q�6_   $	��Top=�6t   $	��113��6�   $��52��6�   6�   �� 5   
   $��Search By Id:��6   $
��Left=�6(   $��
36,355,0,0q�6C   $	��Top=�6W   �� 5   
   -   5        $��txtSearchRack��5      $
��Left=�6'   $��23��6B   $��118,358,0,0q�6N    �� TextWrapping$
 Wrap=�6c   $	��Top=�6w   $	��189��6�   �� 5   
   $��Enter Rack Number:��6   $
��Left=�6-   $��562,386,0,0q�6H   $	��Top=�6]   �� 5   
   -   5        $��txtGiveRackId��5      $
��Left=�6'   $��23��6B   $��562,417,0,0q�6N   $
 Wrap=�6c   $	��Top=�6�   $	��445��6�   ��6w   Z� 6�   &   System.Windows.Controls.DataGrid  5   
   -	   5          Name$ dgRack��5      	   AutoGenerateColumns	 .  $
��Left=�6?   $	��140��6Z   $��
38,389,0,0q�6g   $	��Top=�6{   $	��456��6�   
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Rack Number��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6:   �� *rackId+  5      $ 
Section Id��6%    69   �� *	sectionId+5      �� 5   
   $��Add new rack:��6   $
��Left=�6(   $��	56,81,0,0q�6C   $	��Top=�6V   $ -1.237,1&�6n   $	��205��6�   $
��Bold"�6�   $��16(�6�   �� 5   
   $��Search and view rack:��6   $
��Left=�60   $��
38,322,0,0q�6K   $	��Top=�6_   $ -1.237,1&�6w   $	��212��6�   $
��Bold"�6�   $��16(�6�   �� 5   
   $��Delete Rack:��6   $
��Left=�6'   $��562,331,0,0q�6B   $	��Top=�6W   $ -1.237,1&�6o   $	��231��6�   $
��Bold"�6�   $��16(�6�   �� 5    
   $��Section Name:��6   $
��Left=�6(   $��
56,130,0,0q�6C   $	��Top=�6W   $��98��6o   �� 5!   
   -
   5        $��cmbSectionId��5!      $
��Left=�6'   $��220,130,0,0q�6B   $	��Top=�6W   $	��265��6o   �� 5"   
   $
��Left=�6   $��-36,218,0,0q�6/   $
��Wrap=�6D   $��	TextBlock��6X   $	��Top=�6i   �� 5#   
   $��542,65,419,498q�6   $��1428857898.png��6(   $
��Fill=�6@   5%      5&      