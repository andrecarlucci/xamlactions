﻿using System;

namespace XamlActions.Http {
    public class UriHelper {
        private UriBuilder _builder;
        private string _params = "";

        public UriHelper(string url) {
            _builder = new UriBuilder(url);
        }

        public void AddPath(string path) {
            if (!_builder.Path.EndsWith("/")) {
                _builder.Path += "/";
            }
            if (path.StartsWith("/")) {
                path = path.Substring(1);
            }
            _builder.Path += path;
        }

        public void AddParam(string key, object value) {
            if (_params != "") {
                _params += "&";
            }
            _params += key + "=" + value;
        }

        public Uri Build() {
            if (_params != "") {
                _builder.Query = _params;
            }
            return _builder.Uri;
        }
    }
}