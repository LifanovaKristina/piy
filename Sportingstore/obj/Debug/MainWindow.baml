   M S B A M L   `   `   `  ����H  DSportingstore, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:SportingstoreSportingstore  5   	       Sportingstore.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:Sportingstore     5   	     � Title$%  Окно авторизации��5   	   $	��450��6"   $	��350��6/   .��5	      �  � Cursor$  ��6   .+�5
   
   �� $	��280��6   $	��Top=�6!   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5 0&�67   .��5      �  � Color$ White��6#   5      5      �� 5   
   $	��280��6   $	��200��6    $��Bottom=�6-   $
��0 80q�6H    �� RadiusY$ 10��6V    �� RadiusX$ 10��6c   
������� J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 15Q�6#   	   	Direction$	 0Q�63   
   RenderingBias$
 Quality=�6A      ShadowDepth$ 1Q�6Y      Color$ Green��6i   5      � 5   
   $��Bottom=�6   $��35,80q�6*   $	��200��69   .+�5      �� -   5         ��Name$ name1��5      $��Comic Sans MS)�6$   $��Авторизация��6?   $��Center=�6U   $	��Top=�6r   $��5q�6�   
�������$��18(�6�   �� 5      $	��Top=�6   $��
15 40 15 0q�61   .+�5      �� $��Логин:��6   $��Comic Sans MS)�6*   �� 5      -   5         ��Name$ 
loginField��5   O   $��Comic Sans MS)�6   $��18(�65   $��3q�6C   
����������#e9e9e9$��35��6�   �� 5      $��Пароль:��6   $��Comic Sans MS)�6+   G� 5      -   5         G�Name$ passwordField��5      $��Comic Sans MS)�65   $��18(�6P   $��3q�6^   
�������$��Center=�6�   ���#e9e9e9$��35��6�   5      5      �� 5    
   -   5         ��Name$ enterButton��5       $��Comic Sans MS)�6&   $
 Hand��6A   $	��160��6O   $��Center=�6[   $��Bottom=�6x   $
��0,65q�6�   $��
Войти��6�   
�������
�������$��7q�6�   6�   �� 5!   
   $��/img/logo.png��6   $��79��6'   $	��Top=�63   $��
0,30,257,0q�6K    J� RenderTransformOrigin$ 0.552,1.091&�6_   �� 5"   
   $��Comic Sans MS)�6   $��Runner Store��6,   $
��Left=�6C   $��36(�6^   $��95,22,0,317q�6l   $	��241��6�   $��Center=�6�   6�   �� 5#   
   -   5        $ registerButton��5#      $��Comic Sans MS)�6)   $
 Hand��6D   $	��160��6R   $��Center=�6^   $��Bottom=�6{   $��
91,0,91,10q�6�   $*��$Зарегистрироваться��6�   
�������
�������$��7q�6�   6   5$      5%      