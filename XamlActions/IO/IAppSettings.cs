﻿namespace XamlActions.IO {
    public interface IAppSettings {
        object Get(string key);
        void Set(string key, object value);
    }
}
