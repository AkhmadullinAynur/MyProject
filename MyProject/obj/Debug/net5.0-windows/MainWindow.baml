   M S B A M L   `   `   `  ����D  @MyProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:MyProject	MyProject  5   	       MyProject.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:MyProject     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � $��0,0,5,0q�6    � RowDefinitions 5
   
   �� 5      $
��Auto �6   6,   �� 5      6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   .+�5      o� $��0,0,0,0q�6   $	��800��6$   .@�5      �� -   5         ��Name$ btnHome��5      $��25��6*   $��50��66   $��0,0,0,0q�6A   $
��Home��6R   $
��Bold"�6a   6s   �� 5      -   5        $ btnProjectregistry��5      $��25��65   $	��130��6A   $��0,0,0,0q�6M   $#��Реестр проектов��6^   $
��Bold"�6x   6�   �� 5      -   5        $ btnOperationCard��5      $��25��63   $	��130��6?   $��0,0,0,0q�6K   $)��#Операционная карта��6\   $
��Bold"�6y   6�   �� 5      -   5        $ btnStaff��5      $��25��6+   $	��130��67   $��0,0,0,0q�6C   $��Персонал��6T   $
��Bold"�6g   6y   �� 5      -   5        $ btnComponents��5      $��25��60   $	��135��6<   $��0,0,0,0q�6H   $)��#Учет комплектующих��6Y   $
��Bold"�6v   6�   �� 5      -   5        $ btnTable��5      $��25��6+   $	��135��67   $��0,0,0,0q�6C   $��Табель��6T   $
��Bold"�6e   6w   5      5       � 5   
   -   5          �Name$ MyFrame��5      $��1��6!     � NavigationUIVisibility$ Hidden=�6.   6h   5      5      