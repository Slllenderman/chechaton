   M S B A M L   `   `   `  ????D  @chechaton, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:chechaton.templateschechaton.templates  5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5      Z VDevExpress.Mvvm.UI, Version=22.1.0.0, Culture=neutral, PublicKeyToken=382ad28f6ae31f30W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   CornerRadius  FiledCornerRaidus  FailedRectSize  HavePlansTitle  NoPlansTitle  ?? 
TargetType  
calendarBt ? 	Resources ?? MergedDictionaries ?? Source ??Name ?? CornerRadius ?? Color ?? RelativeSource ??Name	 ?? Triggers*    $chechaton.templates.ButtonProperties
 P? Property P? Value ?? 
TargetName ?? Property ?? Value ]? 
Conditions ?? Property ?? Value N? EnterActions ?? 
TargetName ?? TargetProperty	 W? By g? FillBehavior g? Duration W? EasingFunction-  'System.Windows.Media.Animation.SineEase7  1System.Windows.Media.Animation.EasingFunctionBase   
EasingMode	 ?? By
 ?? ScR
 ?? ScG
 ?? ScB ?? EasingFunction N? ExitActions?? 5      H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      :x,http://schemas.microsoft.com/winfx/2006/xaml     5      *temp!clr-namespace:chechaton.templates  5      .sys&clr-namespace:System;assembly=mscorlib  5      %?  &	        &	      &	 >     &	 X     &	 }     &	 ?     7   7  7  7  7  7  ??5      15??6,   ??5      0, 15, 0, 10??6;   X?5      30Q?6,   ??5	      Where's plans??67   ??5
      No plans today??66   ?? 5      "  ??6    5   
   ?? 5       5      ?? 5      $ ../assets/brushes.xaml??6)   5      .R?5   
   ?? $ BackRect??6   8   $??0q?5      ??5      ?? 5      BackRectColor?? 69   ?? *Background.Color+ ?? *TemplatedParent+._?5      ?? $??Inter)?6   ??5      ? 5      .+?5      ?? $ TodayTb??6$   $	??Top=?5   $   $
??Left=?6<   $??10, 5, 0, 0q?6W   $??Today??5   $   $
??Bold"?61   $y?	Collapsed=?6C   $??24(?6Z   ?? 5      $ 
FailedRect??6!   8?? 8?? $	??Top=?5!   !   $??Right=?69   ???#FFB26A$y?	Collapsed=?5"   6   8  5#   !   ?? 5$      $ 	MainTitle??6$   $??Center=?5%   $   $??Center=?6?   #??z??5&   $   #??z??6E   5'      5)      5*      	 5+   
   P? 5,      
 ?@  IsToday$
 True??6?   . ?5-      ?? $ 	MainTitle??6    ? ??$ 20(?6D   ?? 5.      $ 	MainTitle??6    ? ??$ Italic$?6E   ?? 5/      $ 	MainTitle??6    ? ??$ SemiBold"?6F   ?? 50      $ 	MainTitle??6    ?@??Padding$ 0, 10, 0, 0q?6C   ?? 51      $ 	MainTitle??6   8   ? ??6@   ?? 52      $ TodayTb??6    ? y?$ Visible=?6D   53      P? 54      
 ?@  IsFailed$
 True??6@   . ?55      ?? $ 
FailedRect??6    ? y?$ Visible=?6G   56      ]? 57       58      ?? 59       ?@  
IsHaveTask$
 True??6L   ?? 5:       ?@  IsToday$
 True??6I   /?5<      ?? 5=      $ 	MainTitle??6   8   ? ??6D   5?      P? 5@      
 ?@J?IsMouseOver$
 True??6-    5A      ?? 5B      .??5C      ?? .??5D      W? $ 	MainTitle??6.   $ FontSize?6P    25E   .   $ HoldEnd=?65   $ 0:0:0.3D?6L    5F   "     5G   &   $ EaseOut=?6/   5I      ?? 5J      $ BackRectColor??6-   $ Color?6S   $ HoldEnd=?5K   )   $ 0:0:0.3D?6@    5L   "   ?? 5M   &   $ -0.12??6,   $ -0.02??68   $ -0.58??6D    5O   "     5P   &   $ 	EaseInOut=?6/   5R      5S      5T       5V      ?? 5W      .??5X      ?? .??5Y      W? $ 	MainTitle??6.   $ FontSize?6P   $ HoldEnd=?5Z   *   $ 0:0:0.3D?6A    5[   "     5\   &   $ EaseOut=?6/   5^      ?? 5_      $ BackRectColor??6-   $ Color?6S   $ HoldEnd=?5`   *   $ 0:0:0.3D?6A    5a   "     5b   &   $ 	EaseInOut=?6/   5d      5e      5f      5h      P? 5i      
 ? ??$
 True??6+    5j      ?? 5k      .??5l      ?? .??5m      ?? $ BackRectColor??6-   $ Color?6S   $ HoldEnd=?5n   )   $ 0:0:0.1D?6@    5o   "   ?? 5p   &   $
 -0.3??6,   $
 -0.3??67   $
 -0.3??6B    5r   "     5s   &   $ 	EaseInOut=?6/   5u      5v      5w       5y      ?? 5z      .??5{      ?? .??5|      ?? $ BackRectColor??6-   $ Color?6S   $ HoldEnd=?5}   )   $ 0:0:0.1D?6@    5~   "     5   &   $ 	EaseInOut=?6/   5?      5?      5?      5?      5?      5?      