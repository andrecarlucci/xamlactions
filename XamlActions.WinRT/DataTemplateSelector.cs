﻿using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace XamlActions {
    public abstract class DataTemplateSelector : ContentControl {

        public abstract DataTemplate SelectTemplate(object item, DependencyObject container);

        protected override void OnContentChanged(object oldContent, object newContent) {
            base.OnContentChanged(oldContent, newContent);
            ContentTemplate = SelectTemplate(newContent, this);
        }
    }
}
