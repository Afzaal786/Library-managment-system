   M S B A M L   `   `   `  ����  Library Managment System&     Library_Managment_System.frmUser   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$
  User��5   	   $��630.839��6   $��1076.955��6(    � WindowStartupLocation$ CenterScreen=�6:    � WindowState$ 	Maximized=�6_    � 
ResizeMode$ NoResize=�6w   .��5      � ��5   
   �� 5       �� ImageSource$K EMedia/Dark-background-simple-black-and-white-liniar-background-hd.jpg��6    � ColumnDefinitions 5	   
   �� 5
      $
��164* �6   �� 5      $
��327* �6   .+�5   
   �� $��2��6   ���	#FFF4F4F5$
��Left=�69   $	��200��6T   $��	33,68,0,0q�6a   
���   �$	��Top=�6�   $	��491��6�   �� 5   
   ���	#FFF4F4F5$
��Left=�6%   $	��227��6@   $��
36,308,0,0q�6M   
���   �$	��Top=�6p   $	��488��6�   $��2��6�   �� 5   
   $��1��6   ���	#FFF4F4F5$
��Left=�65   $	��227��6P   $��204,308,0,0q�6]   
���   �$	��Top=�6�   $	��479��6�   �� 5   
   
�������$��Users:��6(   $
��Left=�69   $��34,5,0,0q�6T   $	��Top=�6f   $��34(�6~   $
��Bold"�6�   �� 5   
   -   5         ��Name$ txtUserName��5      $
��Left=�6'   $��23��6B   $��159,116,0,0q�6N    �� TextWrapping$
 Wrap=�6c   $	��Top=�6w   $	��129��6�   �� 5   
   -   5         ��Name$ btnSaveUser��5      $
��Save��6&   $
��Left=�65   $��332,187,0,0q�6P   $	��Top=�6e   $��92��6}   	 J� RenderTransformOrigin$	 1.16,0.8&�6�   $��41��6�   $��2��6�   �� 5   
   -   5        $ btnClose��5      $
��Back��6#   $��1��62   $
��Left=�6B   $��601,553,0,0q�6]   $	��Top=�6r   $��82��6�   $	 
1.413,0.45&�6�   $��42��6�   6�   �� 5   
   -   5        $ btnUserUpdate��5   "   $��Update��6   $
��Left=�69   $��577,460,0,0q�6T   $	��Top=�6i   $��76��6�   $��43��6�   $��1��6�   �� 5   
   $��	User Name��6   $
��Left=�6$   $��
46,117,0,0q�6?   $	��Top=�6S   �� 5   
   -   5        $ btnUserSearch��5   "   $��Search��6   $
��Left=�69   $��254,332,0,0q�6T   $	��Top=�6i   $��76��6�   $��40��6�   6�   �� 5   
   -   5        $ btnUserDelete��5   "   $��Delete��6   $
��Left=�69   $��578,345,0,0q�6T   $	��Top=�6i   $��75��6�   $��41��6�   $��1��6�   &   System.Windows.Controls.DataGrid  5   
   -   5        
  Name$
 dgUser��5      $��2��6#      AutoGenerateColumns .  $
��Left=�6S   $	��140��6n   $��
50,379,0,0q�6{   $	��Top=�6�   $	��465��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ User Id��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 66   �� *userId+  5      $ 	User Name��6%    68   �� *
userName+5      �� 5   
   -   5        $ btnViewAllUsers��5   *   $��View All Users��6   $
��Left=�6C   $��339,332,0,0q�6^   $	��Top=�6s   $��85��6�   $��41��6�   $��2��6�   �� 5    
   -	   5        $ txtSearchUser��5       $
��Left=�6)   $��24��6D   $��149,346,0,0q�6P   $
 Wrap=�6e   $�� ��6y   $	��Top=�6�   $��68��6�   �� 5!   
   $��Search By Id:��6   $
��Left=�6(   $��
45,344,0,0q�6C   $	��Top=�6W   �� 5"   
   -
   5        $ 	txtGiveId��5"      $
��Left=�6%   $��23��6@   $��301,361,0,0q�6L   $
 Wrap=�6a   $	��Top=�6�   $	��120��6�   $��1��6�   ��6u   Z� 6�   G� 5#   
   -   5         G�Name$ txtGivePassword��5#       G� PasswordChar$ *��6/   $
��Left=�6@   $��23��6[   $��339,449,0,0q�6g   $	��Top=�6|   $	��212��6�   $��1��6�   �� 5$   
   -   5        $ txtGiveName��5$      $
��Left=�6'   $��23��6B   $��339,413,0,0q�6N   $
 Wrap=�6c   $	��Top=�6�   $	��212��6�   $��1��6�   ��6w   Z� 6�   �� 5%   
   $��Enter new password:��6   $
��Left=�6.   $��217,446,0,0q�6I   $	��Top=�6^   $��1��6v   �� 5&   
   $��Enter name:��6   $
��Left=�6&   $��219,413,0,0q�6A   $	��Top=�6V   $��1��6n   �� 5'   
   $��	Enter Id:��6   $
��Left=�6$   $��220,358,0,0q�6?   $	��Top=�6T   $	 0.461,0.846&�6l   $��1��6�   �� 5(   
   $��Add new User:��6   $
��Left=�6(   $��	44,66,0,0q�6C   $	��Top=�6V   $	 -1.237,1&�6n   $	��150��6�   $
��Bold"�6�   $��16(�6�   �� 5)   
   $��Search and View Users:��6   $
��Left=�61   $��
38,308,0,0q�6L   $	��Top=�6`   $	 -1.237,1&�6x   $	��216��6�   $
��Bold"�6�   $��16(�6�   �� 5*   
   $%��Update and delete User Records:��6   $
��Left=�6:   $��220,308,0,0q�6U   $	��Top=�6j   $	 -1.237,1&�6�   $	��311��6�   $
��Bold"�6�   $��16(�6�   $��1��6�   �� 5+   
   
���   �$��1q�6%   $��1��69   $
��Left=�6I   $	��112��6d   $��217,407,0,0q�6q   $	��Top=�6�   $	��450��6�   �� 5,   
   $��Password��6   $
��Left=�6#   $��
46,158,0,0q�6>   $	��Top=�6R   �� 5-   
   $��Confirm Password��6   $
��Left=�6+   $��
46,202,0,0q�6F   $	��Top=�6Z   �� 5.   
   $��Confirm Password��6   $��1��6+   $
��Left=�6;   $��218,477,0,0q�6V   $	��Top=�6k   G� 5/   
   -   5        $ txtGiveConfirmPassword��5/      $ *��66   $
��Left=�6G   $��23��6b   $��339,482,0,0q�6n   $	��Top=�6�   $	��212��6�   $��1��6�   G� 50   
   -   5        $ txtUserPassword��50      $
��Left=�6/   $��23��6J   $��159,158,0,0q�6V   $ *��6k   $	��Top=�6}   $	��129��6�   G� 51   
   -   5        $ txtConfirmPassword��51      $
��Left=�62   $��23��6M   $��159,205,0,0q�6Y   $ *��6n   $	��Top=�6�   $	��129��6�   �� 52   
   $��1��6   $��185,36,458,467q�6    $��add_user.png��68   $
��Fill=�6N   53      54      