   M S B A M L   `   `   `  ����  Sportingstore)    #Sportingstore.view.RegistrationPage   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5        � Title$  Регистрация��5      $	��600��6   $	��359��6(   .��5      � 
�������.+�5
   
   �� $	��300��6   $	��325��6    $��Bottom=�6-   $��29,0,22,105q�6H    �� RadiusY$ 10��6]    �� RadiusX$ 10��6j   
������� J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 15Q�6#      	Direction$ 0Q�63      RenderingBias$ Quality=�6A      ShadowDepth$ 1Q�6Y      Color$ Green��6i   5      � 5   
   $��Bottom=�6   $��29 0 35 146q�6*   $	��284��6?   $��1��6L   $��2��6\   .+�5      �� -   5        	 ��Name$	 Registr��5      $��Comic Sans MS)�6%   $��Регистрация��6@   $��Center=�6V   $	��Top=�6s   $��0 5 0 0q�6�   
�������$��18(�6�   
 J� RenderTransformOrigin$
 0.528,-1.061&�6�   �� 5      $	��Top=�6   $��
15 40 15 0q�61   .+�5      �� $��Логин:��6   $��Comic Sans MS)�6)   �� 5      -   5         ��Name$ 
loginField��5      $��Comic Sans MS)�6.   $��18(�6I   $��3q�6W   
�������$��Center=�6{   ���#e9e9e9$��35��6�   �� 5       �� Orientation$ 
Horizontal=�6   .+�5      �� $��Пароль:��6   $��Comic Sans MS)�6/   5      G� 5      -   5         G�Name$ passwordField��5      $��Comic Sans MS)�65   $��18(�6P   $��3q�6^   
�������$��Center=�6�   ���#e9e9e9$��35��6�   �� 5      -   5        $	 SecretPhrase��5      $&�� Повторите пароль:��6.   G� 5      -   5        $ retryPasswordField��5      $��Comic Sans MS)�6:   $��18(�6U   $��3q�6c   
�������$��Center=�6�   ���#e9e9e9$��35��6�   �� 5      $��E-mail:��6   $��Comic Sans MS)�6+   �� 5      -   5        $ 
emailField��5      $��Comic Sans MS)�6.   $��18(�6I   $��3q�6W   
�������$��Center=�6{   ���#e9e9e9$��35��6�   5      5      �� 5   
   -   5         ��Name$ loginButton��5   �    � Cursor$
 Hand��6   $	��160��6   $��Center=�6+   $	��Top=�6H   $��98,474,101,0q�6`   $*��$Зарегистрироваться��6v   $��Comic Sans MS)�6�   
�������
�������$��7q�6�   6�   �� 5   
   -   5        $ authorButton��5   �   $
 Hand��6   $	��188��6   $��Center=�6+   $	��Top=�6H   $��86,536,85,0q�6`   $2��,Вернуться к авторизации��6u   $��Comic Sans MS)�6�   
�������
�������$��7q�6�   6  �� 5    
   -	   5        $ crossButton��5    m   $	��Top=�6   $��Right=�6)   $��0q�6E   $��
0,25,123,0q�6Y   $	��112��6�   $	��106��6�   ��5!      �� 5"       �� ImageSource$ /img/logo.png��6   5$      5%      5&      