   M S B A M L   `   `   `  ���� R  NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   RepeatButtonTransparent  �� 
TargetType �� Property �� Value �� 
TargetType ! SliderThumb.Static.Background �� Color  SliderThumb.Static.Border ! SliderThumb.Static.Foreground $  SliderThumb.MouseOver.Background   SliderThumb.MouseOver.Border " SliderThumb.Pressed.Background  SliderThumb.Pressed.Border # SliderThumb.Disabled.Background 	 SliderThumb.Disabled.Border  
 SliderThumb.Track.Background  SliderThumb.Track.Border   SliderThumbHorizontalDefault � UseLayoutRounding A�Name �� Opacity  SliderThumbHorizontalTop F�Name	 J� SnapsToDevicePixels
 �� Stretch �� Triggers P� Property P� Value �� 
TargetName  SliderThumbHorizontalBottom  SliderHorizontal ��Name � RowDefinitions m�Name m� Fill m� 	Placement �� CornerRadius ]�Name ]� DecreaseRepeatButton �� DecreaseLarge ]� IncreaseRepeatButton �� IncreaseLarge ]� Thumb n�Name � OverridesDefaultStyle  SliderStyle1�� D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml      %�  &	        &	 �     &	 �     &	 �     &	 �     &	     &	     &	 -    &	 B    &		 W    &	
 l    &	 �    &	 �    &	     7  7  7  7  7  7  7  7 	 &	 6    7  7  7  7  7  7  7  7 	 &	 E    7   7   7  7  7  &	 !    7  7  �� "  ��.���  �@�OverridesDefaultStyle . ��  � ��
 ���� ��  � |� .  ��  � �� .  ��  � �� �� " ��.R��� #��z��#��z��#��z���� $ 	#FFF0F0F0���� $ 	#FFACACAC���� $ 	#FFE5E5E5���� $ 	#FFDCECFC���� $ 	#FF7Eb4EA���� $ 	#FFDAECFC���� $ 	#FF569DE5���� $ 	#FFF0F0F0���� $ 	#FFD9D9D9���� $ 	#FFE7EAEA���� $ 	#FFD6D6D6���� " n�.R�� $��Center=� . $��Center=�.+�A� $
 grid��$��30��$��30��$��10��
����������� $	 Red��$	 0.5Q��� " n�.R�� $��Center=� . $��Center=�.+�F� $
 grip�������    ��[ �    ��[ `�S `�S �`�S     �ا ��[ �ا ��[ ��ا ��[ �ا ���ا ����ا �������    ����[ ��[ 	8��  8�� 	 . $

 Fill=�$��1�� . $��Center=� P�  �@J�IsMouseOver . . ��� $
 grip��8   � ���� $
 grip��8   � ��P�  �@n�
IsDragging . . ��� $
 grip��8   � ���� $
 grip��8   � ��P�  � {� .  . ��� $
 grip��8   � ���� $
 grip��8   � ���� " n�.R�� $��Center=� . $��Center=�.+�F� $
 grip�������     � �     � `�S ��`�S ���`�S ���ا  � �ا  � ��ا  � �ا �ا ��ا     �         �  � 	8��  8�� 	 . $

 Fill=�$��1�� . $��Center=� P�  �@J�IsMouseOver . . ��� $
 grip��8   � ���� $
 grip��8   � ��P�  �@n�
IsDragging . . ��� $
 grip��8   � ���� $
 grip��8   � ��P�  � {� .  . ��� $
 grip��8   � ���� $
 grip��8   � ���� " ��.R��� $ border��#��z��#��z��#��z��	 . ._��  �� $
��Auto ��� $
��Auto �#��z���� $
��Auto �.+�m� $ TopTick��# z��$��4��$��0,0,0,2q�$	 Top=�$��0��$y�	Collapsed=�m� $ 
BottomTick��# z��$��4��$��0,2,0,0q�$ Bottom=�$��2��$y�	Collapsed=��� $ TrackBackground��
�������$	 2.5��$��0q�$��4��$
��15,0q�$��1��$��center=�._��� $ PART_SelectionRange��
���  ��$ 1��$
��Left=�]� $ 
PART_Track��$��1�� �� #��Z 8��   �� #��Z 8��  n� $ Thumb��|�.  $��30�� . 8�� $��Center=�$��30�� P�  �@��TickPlacement$ TopLeft=�. ��� $ TopTick�� � y�$ Visible=��� $ Thumb��8   � ���� $ TrackBackground�� � ��$ 5,2,5,0q�P�  �@��TickPlacement$ BottomRight=�. ��� $ 
BottomTick�� � y�$ Visible=��� $ Thumb��8   � ���� $ TrackBackground�� � ��$ 5,0,5,2q�P�  �@��TickPlacement$
 Both=�. ��� $ TopTick�� � y�$ Visible=��� $ 
BottomTick�� � y�$ Visible=�P�  �@��IsSelectionRangeEnabled . . ��� $ PART_SelectionRange�� � y�$ Visible=�P�  �@J�IsKeyboardFocused . . ��� $ Thumb�� � ��
 ��  ��� "  ��.���  �@��IsPressAndHoldEnabled .  ��  � ��
 ���� ��  � ��
 ���� ��  � ��8   ��  � ��8  ��  �@�FocusVisualStyle Z� 