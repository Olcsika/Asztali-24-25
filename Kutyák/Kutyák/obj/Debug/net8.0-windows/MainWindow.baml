   M S B A M L   `   `   `  ����B  >Kutyák, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:KutyákKutyák  5   	       Kutyák.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Kutyák     5   	     � Title$  Kutyák��5   	   $	��450��6   $	��800��6%   .��5	      � -   5        .+�5
   
   �� -   5         ��Name$ label��5
      $��Ennyi kutya név van:��6   $
��Left=�6>   $��
131,84,0,0q�6Y   $	��Top=�6m   �� 5   
   -   5        $ label1��5      $�� ��6    $
��Left=�6+   $��
262,84,0,0q�6F   $	��Top=�6Z   �� 5   
   -   5         ��Name$ button��5      $��	3.feladat��6!   $
��Left=�65   $��	45,74,0,0q�6P   $	��Top=�6c   $��46��6{   $��69��6�   6�   �� 5   
   -   5        $ 
label_Copy��5      $ ��A kutyák átlagéletkora:��6$   $
��Left=�6F   $��131,135,0,0q�6a   $	��Top=�6v   �� 5   
   -   5        $ label_Copy1��5      $�� ��6%   $
��Left=�60   $��282,135,0,0q�6K   $	��Top=�6`   �� 5   
   -   5        $ button1��5      $��
6. feladat��6"   $
��Left=�67   $��
56,135,0,0q�6R   $	��Top=�6f   6~   �� 5   
   -   5        $ button2��5      $��	7.feladat��6"   $
��Left=�66   $��
56,179,0,0q�6Q   $	��Top=�6e   6}   �� 5   
   -	   5        $ label_Copy2��5      $*��$A legidosebb kutya neve és fajtája��6%   $
��Left=�6R   $��131,176,0,0q�6m   $	��Top=�6�   �� 5   
   -
   5        $ label_Copy3��5      $�� ��6%   $
��Left=�60   $��400,179,0,0q�6K   $	��Top=�6`   �� 5   
   -   5        $ button3��5      $��	8.feladat��6"   $
��Left=�66   $��
55,217,0,0q�6Q   $	��Top=�6e   6}   �� 5   
   -   5        $ label_Copy4��5      $��Dátum��6%   $
��Left=�65   $��144,216,0,0q�6P   $	��Top=�6e    J� RenderTransformOrigin$ 
0.733,0.84&�6}   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ 
datePicker��5      $
��Left=�6)   $��236,217,0,0q�6D   $	��Top=�6Y      DisplayDate$ 
2018-01-10��6q      DisplayDateStart 
2018-01-106�      Text$ 
2018-01-10��6�   �� 5   
   -   5         ��Name$ listBox��5      $��400,182,152,107q�6N   5      5      