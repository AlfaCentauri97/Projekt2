   M S B A M L   `   `   `  ����  projekt_programowanie"    projekt_programowanie.MyBase   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� Title$  MyBase��5      .��5      � -   5         �Name$ GridMain��5	   	   $
��1080��5
   	   $	��460��5   	   
�����F�.+�5   
   � $��150,0,150,0q�6   
�������.+�5      &   System.Windows.Controls.DataGrid  -   5        $
��Data��5      $��	0,0,0,140q�5         AutoGenerateColumns . ���	#FF7B98B15      � 5      $��0,320,641,0q�6   
�������.+�5      '  !MaterialDesignThemes.Wpf.PopupBox  $��Stretch=�5      ���#f6047b   PlacementMode$ BottomAndAlignRightEdges=�5         	StaysOpen .     ToggleContent 5      '  !MaterialDesignThemes.Wpf.PackIcon  5      $	��140��5      $	��130��5      ���#f6047b   Kind$ PlayCircleFilled=�5         PopupContent. 5       �� $	��150��6!   .+�5!      �� -   5        $
��Load��5!   A   �� 5"      -   5        $��Update��5"   =   �� 5#      -   5        $	��Add��5#   :   �� 5$      -   5        $��Delete��5$   =   �� 5%      5&      5'      5(      � 5)      $��144,320,0,0q�6   .+�5+      �� $��35��5,      $��
28,0,52,84q�5-      $��Bottom=�5.      
������� �� RadiusX$ 10��50      	 �� RadiusY$	 10��51      
 J� Effect
 52      3  -System.Windows.Media.Effects.DropShadowEffect  53         
BlurRadius$ 15Q�54         	Direction$ 0Q�55         RenderingBias$ Quality=�56         ShadowDepth$ 1Q�57         Color$ 	#FFBBBBBB��58      5:      �� 5;      -   5        $��txtName��5<      $��
36,0,72,90q�5=      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 
Movie name��5>      $��Champagne & Limousines)�5?      $��18(�5@       J� RenderTransformOrigin$ 0.518,0.075&�5A       %  !MaterialDesignFloatingHintTextBox#��[  5B      �� 5D      $��35��5E      $��224,0,255,26q�5F      $��Bottom=�5G      
�������$ 10��5I      $	 10��5J      
 5K        5L      $ 15Q�5M      $ 0Q�5N      $ Quality=�5O      $ 1Q�5P      $ 	#FFBBBBBB��5Q      5S      �� 5T      -   5        $��txtTime��5U      $��230,56,265,34q�5V      $
 Time��5W      $��Champagne & Limousines)�5X      $��18(�5Y      $ 0.518,0.075&�5Z      #��[  5[      �� 5]      $��35��5^      $��28,0,459,26q�5_      $��Bottom=�5`      
�������$ 10��5b      $	 10��5c      
 5d        5e      $ 15Q�5f      $ 0Q�5g      $ Quality=�5h      $ 1Q�5i      $ 	#FFBBBBBB��5j      5l      �� 5m      -	   5        $��txtID��5n      $��36,55,471,35q�5o      $ ID��5p      $��Champagne & Limousines)�5q      $��18(�5r      $ 0.518,0.075&�5s      #��[  5t      �� 5v      $��35��5w      $��429,0,52,26q�5x      $��Bottom=�5y      
�������$ 10��5{      $	 10��5|      
 5}        5~      $ 15Q�5      $ 0Q�5�      $ Quality=�5�      $ 1Q�5�      $ 	#FFBBBBBB��5�      5�      �� 5�      -
   5        $��txtScore��5�      $��438,55,62,35q�5�      $ Score��5�      $��Champagne & Limousines)�5�      $��18(�5�      $ 0.518,0.075&�5�      #��[  5�      5�      5�      5�      5�      