   M S B A M L   `   `   `  ����F  BAudioPlayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:AudioPlayerAudioPlayer  5   	       AudioPlayer.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:AudioPlayer     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   r� -   5         r�Name$ media��5       r� LoadedBehavior$ Manual=�6&   $
��Left=�6^   $��18��6y   $��	45,92,0,0q�6�   $	��Top=�6�   $	��318��6�   $��2��6�   �� 5   
   -   5         ��Name$ audioSlider��5      $��Center=�6N   $��10,0,0,0q�6k   $��Center=�6}   $	��780��6�   $��29��6�   $��2��6�   $��2��6�   6�   �� 5   
   -   5         ��Name$
 Play��5      $
��Play��6   $��Center=�6.   $��	10,75,0,0q�6K   $��1��6^   $��0��6k   $��Center=�6{   $��61��6�   $��40��6�   �� 5   
   -   5        $
 Stop��5      $
��Stop��6   $��Center=�6.   $��
163,75,0,0q�6K   $��1��6_   $��Center=�6l    J� RenderTransformOrigin$ 0.593,-0.082&�6�   $��40��6�   $��54��6�   $��0��6�   �� 5   
   -   5        $ Repeat��5      $��Repeat��6!   $��Center=�62   $��
101,90,0,0q�6O   $��1��6c   $��Center=�6p   $��40��6�   $��60��6�   $��1��6�   �� 5   
   -   5        $
 Open��5      $��	Open File��6   $��Center=�63   $��
178,72,0,0q�6P   $	��Top=�6d   $��0��6�   $��0��6�   �� 5   
   -   5         ��Name$ 	ListMusic��5      $��1��6%   $
��Left=�65   $	��100��6P   $��	21,25,0,0q�6]   $	��Top=�6p   $	��354��6�   6�   �� 5   
   -   5        $��1��5      $��Button��6!   $
��Left=�62   $��128,107,0,0q�6M   $��1��6b   $	��Top=�6o   6�   �� 5   
   -	   5        $ previousMusic��5      $��<<��6(   $
��Left=�6;   $��1��6V   $��1��6c   $��
127,52,0,0q�6s   $	��Top=�6�   6�   �� 5   
   -
   5        $ 	nextMusic��5      $��>>��6$   $��Right=�67   $��	0,52,55,0q�6S   $��1��6f   $��1��6s   $	��Top=�6�   6�   5      5      