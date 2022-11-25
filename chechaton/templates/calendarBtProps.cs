using System.Globalization;
using System;
using System.Windows;
using System.Windows.Media;

namespace chechaton.templates
{

    public class ButtonProperties : DependencyObject
    {
        public static readonly DependencyProperty IsFailedProperty = DependencyProperty.Register(
            "IsFailed",
            typeof(bool),
            typeof(ButtonProperties),
            new PropertyMetadata(false)
        );

        public static readonly DependencyProperty IsTodayProperty = DependencyProperty.Register(
            "IsToday",
            typeof(bool),
            typeof(ButtonProperties),
            new PropertyMetadata(false)
        );

        public static readonly DependencyProperty IsHaveTaskProperty = DependencyProperty.Register(
            "IsHaveTask",
            typeof(bool),
            typeof(ButtonProperties),
            new PropertyMetadata(false)
        );


        public static void SetIsFailed(DependencyObject target, bool value)
        {
            target.SetValue(IsFailedProperty, value);
        }

        public static bool GetIsFailed(DependencyObject target)
        {
            return (bool)target.GetValue(IsFailedProperty);
        }

        public static void SetIsToday(DependencyObject target, bool value)
        {
            target.SetValue(IsTodayProperty, value);
        }

        public static bool GetIsToday(DependencyObject target)
        {
            return (bool)target.GetValue(IsTodayProperty);
        }

        public static void SetIsHaveTask(DependencyObject target, bool value)
        {
            target.SetValue(IsHaveTaskProperty, value);
        }

        public static bool GetIsHaveTask(DependencyObject target)
        {
            return (bool)target.GetValue(IsHaveTaskProperty);
        }
    }


}
