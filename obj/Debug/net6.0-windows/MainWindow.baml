   M S B A M L   `   `   `  ����H  DServer-Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Server_ClientServer_Client  5   	       Server_Client.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:Server_Client     5   	     � Title$  Serever-Client App��5   	   $	��450��6$   $	��800��61   .��5	      � .+�5
   
   �� -   5        $��Button_SendServer��5
      $'��!Отправить серверу��6*   $
��Left=�6F   $��
52,370,0,0q�6a   $	��Top=�6u   $��47��6�   $	��232��6�   ${�False��6�    J� RenderTransformOrigin$ 0.504,0.018&�6�   �� 5   
   -   5        $��Button_Connect��5      $��Соединиться��6'   $
��Left=�6=   $��
52,304,0,0q�6X   $	��Top=�6l   $��99��6�   $��39��6�   �� 5   
   -   5        $��Button_Disconnect��5      $��Отключится��6*   $
��Left=�6?   $��192,304,0,0q�6Z   $	��Top=�6o   ${�False��6�   $��39��6�   $��92��6�   �� 5   
   $��IP-адрес��6   $
��Left=�6#   $��
33,275,0,0q�6>   $	��Top=�6R   $��56��6j   $��39��6u   �� 5   
   -   5        $��TextBox_Client��5      $
��Left=�6*   $��	336,0,0,0q�6E   $
��Wrap=�6X   $�� ��6l   $��Center=�6t   $	��362��6�   $	��221��6�   �� 5   
   -   5        $��TextBox_Server��5      $
��Left=�6*   $��	569,0,0,0q�6E   $
��Wrap=�6X   $�� ��6l   $��Center=�6t   $	��362��6�   $	��221��6�   �� 5   
   $��Клиент��6   $
��Left=�6!   $��
422,10,0,0q�6<   $	��Top=�6P   �� 5   
   $��Сервер��6   $
��Left=�6!   $��	654,5,0,0q�6<   $	��Top=�6O   �� 5   
   -   5        $��TextBox_ServerId��5      $
��Left=�6*   $��108,277,0,0q�6E    �� TextWrapping$
 Wrap=�6Z   $�� ��6n   $	��Top=�6v   $	��168��6�   �� 5   
   -   5        $��DirList��5      $��33,47,485,164q�6!   5      �� 5   
   -   5        $��
Device_Box��5      $
��Left=�6%   $��	34,15,0,0q�6@   $	��Top=�6S   $	��281��6k   $��21��6w   5      5      