   M S B A M L   `   `   `  ����X  TXceed.Wpf.Toolkit, Version=1.9.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4P:clr-namespace:Xceed.Wpf.Toolkit;assembly=Xceed.Wpf.ToolkitXceed.Wpf.Toolkit  5   	   | xSystem.Windows.Controls.DataVisualization.Toolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35�{clr-namespace:System.Windows.Controls.DataVisualization.Charting;assembly=System.Windows.Controls.DataVisualization.Toolkit2System.Windows.Controls.DataVisualization.Charting 5	   	    ProjetoDeSoftware"   ProjetoDeSoftware.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Atoolkit-http://schemas.microsoft.com/wpf/2008/toolkit     5   	   NwpfTool:clr-namespace:Xceed.Wpf.Toolkit;assembly=Xceed.Wpf.Toolkit     5   	   �charting{clr-namespace:System.Windows.Controls.DataVisualization.Charting;assembly=System.Windows.Controls.DataVisualization.Toolkit     5	   	     � Title$7  1Sistema de Predição de Viabilidade de Negócios��5   	   $��511.5��6@   $
��1136��6O    � WindowStartupLocation$ CenterScreen=�6\    � 
ResizeMode$ NoResize=�6�   .��5      � $
��1129��6   $��0,0,0,2q�6   .+�5   
   �� -   5         ��Name$ groupBox��5      $��Filtros��6%   $
��Left=�66   $��72��6Q   $��
512,18,0,0q�6]   $	��Top=�6q   $	��149��6�   � 5   
   -   5         �Name$ grid_graficos��5   M   $	��284��6   $
��Left=�6   $��25,192,0,-41q�67   $	��Top=�6d   $
��1093��6|   .+�5      >  8System.Windows.Controls.DataVisualization.Charting.Chart  -   5          Name$ grafico_pop��5      $��30,13,727,21q�62      Series. 5      B  <System.Windows.Controls.DataVisualization.Charting.PieSeries  H  BSystem.Windows.Controls.DataVisualization.Charting.DataPointSeries   DependentValuePath$ Value��6=      IndependentValuePath$	 Key��6X   ?  9System.Windows.Controls.DataVisualization.Charting.Series	   Title$	 População total��6s   
   IsSelectionEnabled
 . $��
10,10,1,10q�6�      ItemsSource 6%   �� 6�   5        5      -   5        $ grafico_alf��5      $��392,13,394,17q�62   . 5        $ Value��6=   $	 Key��6X   $	 Número de alfabetizados��6s   
 .  6%   �� 6�   5        5      -   5        $ grafico_renda��5      $��727,12,79,18q�64   . 5        $ Value��6=   $	 Key��6X   $	 Renda média��6s   
 .  6%   �� 6�   5      �� 5      -   5         ��Name$ lb_grafico1��5   h   $��População total��6   $��33��6.   $
��Left=�6:   $��	31,13,0,0q�6U   $	��Top=�6}   $	��247��6�   $��14(�6�   �� 5      -   5        $ lb_grafico2��5      $��Número de alfabetizados��6   $��14(�66   $��33��6D   $
��Left=�6P   $��
394,10,0,0q�6k   $	��Top=�6�   $	��316��6�   �� 5      -   5        $ lb_grafico3��5   y   $��Renda média mensal��6   $��14(�61   $��33��6?   $
��Left=�6K   $��	727,8,0,0q�6f   $	��Top=�6�   $	��247��6�   5       �� 5!   
   -	   5         ��Name$ bt_pesquisar��5!      $��	Pesquisar��6'   $
��Left=�6;   $��22��6V   $��463,132,0,0q�6b   $	��Top=�6w   $	��164��6�   6�   �� 5"   
   -
   5        $ label4��5"   \   $��Bairro��6   $��24��6!   $
��Left=�6-   $��
350,18,0,0q�6H   $	��Top=�6l   $��62��6�   	� 5#   
   -   5         	�Name$ rd_alf��5#   i   $��Alfabetizados��6   $��16��6.   $
��Left=�6:   $��
523,63,0,0q�6U   $	��Top=�6y   $	��104��6�   6�   	� 5$   
   -   5        $ rd_sexo��5$   `   $
��Sexo��6   $��16��6%   $
��Left=�61   $��
523,44,0,0q�6L   $	��Top=�6q   $	��104��6�   6�   �� 5%   
   -   5         ��Name$ 
cb_bairros��5%      $
��Left=�6'   $��25��6B   $��
354,39,0,0q�6N   $	��Top=�6b   $	��132��6z   5&      5'      