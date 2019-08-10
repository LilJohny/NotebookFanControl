﻿using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace NbfcClient.Views
{
    public class ComboBoxItemTemplateSelector : DataTemplateSelector
    {
        public DataTemplate SelectedTemplate { get; set; }
        public DataTemplate DropDownTemplate { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            ComboBoxItem comboBoxItem = GetVisualParent<ComboBoxItem>(container);

            return (comboBoxItem == null)
                ? SelectedTemplate
                : DropDownTemplate;
        }

        static T GetVisualParent<T>(DependencyObject child) where T : Visual
        {
            Visual visual = (Visual)VisualTreeHelper.GetParent(child);

            if (visual == null)
            {
                return null;
            }

            var parent = visual as T;

            if (parent == null)
            {
                parent = GetVisualParent<T>(visual);
            }

            return parent;
        }
    }
}
