   M S B A M L   `   `   `  ����E  AWCFInstant, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:WCFInstant
WCFInstant  5	   	   K*clr-namespace:WCFInstant.ServiceReference1WCFInstant.ServiceReference1  5
   	   G CCRUDBehavior, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=.clr-namespace:WCFInstant;assembly=CRUDBehavior
WCFInstant 5   	       WCFInstant.ItemsView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v17.2, Version=17.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aW SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   f bDevExpress.Xpf.Grid.v17.2.Core, Version=17.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aa ]DevExpress.Xpf.Grid.v17.2, Version=17.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a>dxg2http://schemas.devexpress.com/winfx/2008/xaml/grid   5   0   ;dx2http://schemas.devexpress.com/winfx/2008/xaml/core  6o   ?dxe5http://schemas.devexpress.com/winfx/2008/xaml/editors  5   	   <dxc2http://schemas.devexpress.com/winfx/2008/xaml/core  5   	   c	 _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity 	 5   	   <dxb2http://schemas.devexpress.com/winfx/2008/xaml/bars  5   	   $localclr-namespace:WCFInstant  5	   	   3sr*clr-namespace:WCFInstant.ServiceReference1  5
   	   9crud.clr-namespace:WCFInstant;assembly=CRUDBehavior  5   	     � Title$  Items��5   	   $	��350��6   $	��525��6$    � 	Resources 5         EditRecordTemplate � ColumnDefinitions � RowDefinitions%  DevExpress.Xpf.Editors.TextEdit  Name%  DevExpress.Xpf.Editors.BaseEdit   	EditValue �� Path �� Mode��%q  &	        �� 5   
   .R�5      �� $��8q�6   $	��200��6$   .+�5      �  5      �� 5      �� 5       5      �� 5      �� 5      .+�5      �� $	��ID:��6    $��Center=�6+   $��0��6F   $��0��6S   $��0,0,6,4q�6c     5      $ txtID��6#   $��0��62   $��1��6?   $��0,0,0,4q�6z    6O   �� $ Id�$ TwoWay=�6z   �� 5      $��Name:��6    $��Center=�6-   $��1��6H   $��0��6U   $��0,0,6,4q�6e     5      $ 
txtCompany��6#   $��1��67   $��1��6D   $��0,0,0,4q�6�    6T   �� $
 Name�$ TwoWay=�6�   5      5      5      5      .��5       �  5!   
   �� 5"      �� 5#      $
��Auto �6   .+�5%   
   %  DevExpress.Xpf.Grid.GridControl  -   5        $
��grid��5%   '   $��0��6   )  #DevExpress.Xpf.Grid.DataControlBase   SelectionMode$	 Row=�63   . 	 (System.Windows.Interactivity.Interaction	   	Behaviors	 5&      +  %WCFInstant.WCFInstantModeCRUDBehavior  5'      -   5        
helper��#  CRUDBehavior.CRUDBehaviorBase
   EntityObjectType'   !WCFInstant.ServiceReference1.Item"
  5(   3      
NewRowForm# [  5*   3      EditRowForm# [  5+   3      AllowKeyDownActions .    
PrimaryKey$ Id��5-   3      
DataSource 5)   3   ��  �� ElementName$ wcfInstantSource��   DataServiceContext 5.   3   �� *DataSource.DataServiceContext+ �� RelativeSource �� *Self+   Columns 50      $	  DevExpress.Xpf.Grid.GridColumn	  51      $
  DevExpress.Xpf.Grid.ColumnBase 
  	FieldName$ Id��6!    
  EditSettings 52      6  0DevExpress.Xpf.Editors.Settings.TextEditSettings  53      6  0DevExpress.Xpf.Editors.Settings.BaseEditSettings   AllowNullInput .  6/   55      	  56      $
 Name��6!    57        58       .  6/   5:         View 5<      #  DevExpress.Xpf.Grid.TableView  5=      -   5        $
��view��5=          	AutoWidth . &   DevExpress.Xpf.Grid.DataViewBase   NavigationStyle$	 Row=�6=   5?      �� 5@   
   $��1��6    �� Orientation$ 
Horizontal=�6"   $��Center=�6;   .+�5A      �� $��22��6   $��60��6!   ��6,   �� $ NewRowCommand�$ helper��.��6g   Add6l   �� 5B      $��22��6   $��60��6!   $��6,0,6,0q�6j   ��6,   �� $ RemoveRowCommand�$ helper��.��6{   Remove6�   �� 5C      $��22��6   $��60��6!   ��6,   �� $ EditRowCommand�$ helper��.��6h   Edit6n   5D      A  ;DevExpress.Xpf.Core.ServerMode.WcfInstantFeedbackDataSource  5E   
   -   5        $��wcfInstantSource��5E   +      KeyExpression$ Id��6C      DataServiceContext 6V   �� *
Entities+   Query 6~   �� *Entities.Items+5F      5G      