﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



namespace UserControlApp
{
    public partial class App : global::Windows.UI.Xaml.Markup.IXamlMetadataProvider
    {
        private global::UserControlApp.UserControlApp_XamlTypeInfo.XamlTypeInfoProvider _provider;

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(global::System.Type type)
        {
            if(_provider == null)
            {
                _provider = new global::UserControlApp.UserControlApp_XamlTypeInfo.XamlTypeInfoProvider();
            }
            return _provider.GetXamlTypeByType(type);
        }

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(string fullName)
        {
            if(_provider == null)
            {
                _provider = new global::UserControlApp.UserControlApp_XamlTypeInfo.XamlTypeInfoProvider();
            }
            return _provider.GetXamlTypeByName(fullName);
        }

        public global::Windows.UI.Xaml.Markup.XmlnsDefinition[] GetXmlnsDefinitions()
        {
            return new global::Windows.UI.Xaml.Markup.XmlnsDefinition[0];
        }
    }
}

namespace UserControlApp.UserControlApp_XamlTypeInfo
{
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal partial class XamlTypeInfoProvider
    {
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByType(global::System.Type type)
        {
            global::Windows.UI.Xaml.Markup.IXamlType xamlType;
            if (_xamlTypeCacheByType.TryGetValue(type, out xamlType))
            {
                return xamlType;
            }
            int typeIndex = LookupTypeIndexByType(type);
            if(typeIndex != -1)
            {
                xamlType = CreateXamlType(typeIndex);
            }
            if (xamlType != null)
            {
                _xamlTypeCacheByName.Add(xamlType.FullName, xamlType);
                _xamlTypeCacheByType.Add(xamlType.UnderlyingType, xamlType);
            }
            return xamlType;
        }

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByName(string typeName)
        {
            if (string.IsNullOrEmpty(typeName))
            {
                return null;
            }
            global::Windows.UI.Xaml.Markup.IXamlType xamlType;
            if (_xamlTypeCacheByName.TryGetValue(typeName, out xamlType))
            {
                return xamlType;
            }
            int typeIndex = LookupTypeIndexByName(typeName);
            if(typeIndex != -1)
            {
                xamlType = CreateXamlType(typeIndex);
            }
            if (xamlType != null)
            {
                _xamlTypeCacheByName.Add(xamlType.FullName, xamlType);
                _xamlTypeCacheByType.Add(xamlType.UnderlyingType, xamlType);
            }
            return xamlType;
        }

        public global::Windows.UI.Xaml.Markup.IXamlMember GetMemberByLongName(string longMemberName)
        {
            if (string.IsNullOrEmpty(longMemberName))
            {
                return null;
            }
            global::Windows.UI.Xaml.Markup.IXamlMember xamlMember;
            if (_xamlMembers.TryGetValue(longMemberName, out xamlMember))
            {
                return xamlMember;
            }
            xamlMember = CreateXamlMember(longMemberName);
            if (xamlMember != null)
            {
                _xamlMembers.Add(longMemberName, xamlMember);
            }
            return xamlMember;
        }

        global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlType>
                _xamlTypeCacheByName = new global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlType>();

        global::System.Collections.Generic.Dictionary<global::System.Type, global::Windows.UI.Xaml.Markup.IXamlType>
                _xamlTypeCacheByType = new global::System.Collections.Generic.Dictionary<global::System.Type, global::Windows.UI.Xaml.Markup.IXamlType>();

        global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlMember>
                _xamlMembers = new global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlMember>();

        string[] _typeNameTable = null;
        global::System.Type[] _typeTable = null;

        private void InitTypeTables()
        {
            _typeNameTable = new string[9];
            _typeNameTable[0] = "UserControlApp.CustomSlider";
            _typeNameTable[1] = "Windows.UI.Xaml.Controls.UserControl";
            _typeNameTable[2] = "Int32";
            _typeNameTable[3] = "String";
            _typeNameTable[4] = "UserControlApp.MainPageViewModel";
            _typeNameTable[5] = "UserControlApp.BindableBase";
            _typeNameTable[6] = "Object";
            _typeNameTable[7] = "UserControlApp.MainPage";
            _typeNameTable[8] = "Windows.UI.Xaml.Controls.Page";

            _typeTable = new global::System.Type[9];
            _typeTable[0] = typeof(global::UserControlApp.CustomSlider);
            _typeTable[1] = typeof(global::Windows.UI.Xaml.Controls.UserControl);
            _typeTable[2] = typeof(global::System.Int32);
            _typeTable[3] = typeof(global::System.String);
            _typeTable[4] = typeof(global::UserControlApp.MainPageViewModel);
            _typeTable[5] = typeof(global::UserControlApp.BindableBase);
            _typeTable[6] = typeof(global::System.Object);
            _typeTable[7] = typeof(global::UserControlApp.MainPage);
            _typeTable[8] = typeof(global::Windows.UI.Xaml.Controls.Page);
        }

        private int LookupTypeIndexByName(string typeName)
        {
            if (_typeNameTable == null)
            {
                InitTypeTables();
            }
            for (int i=0; i<_typeNameTable.Length; i++)
            {
                if(0 == string.CompareOrdinal(_typeNameTable[i], typeName))
                {
                    return i;
                }
            }
            return -1;
        }

        private int LookupTypeIndexByType(global::System.Type type)
        {
            if (_typeTable == null)
            {
                InitTypeTables();
            }
            for(int i=0; i<_typeTable.Length; i++)
            {
                if(type == _typeTable[i])
                {
                    return i;
                }
            }
            return -1;
        }

        private object Activate_0_CustomSlider() { return new global::UserControlApp.CustomSlider(); }
        private object Activate_4_MainPageViewModel() { return new global::UserControlApp.MainPageViewModel(); }
        private object Activate_5_BindableBase() { return new global::UserControlApp.BindableBase(); }
        private object Activate_7_MainPage() { return new global::UserControlApp.MainPage(); }

        private global::Windows.UI.Xaml.Markup.IXamlType CreateXamlType(int typeIndex)
        {
            global::UserControlApp.UserControlApp_XamlTypeInfo.XamlSystemBaseType xamlType = null;
            global::UserControlApp.UserControlApp_XamlTypeInfo.XamlUserType userType;
            string typeName = _typeNameTable[typeIndex];
            global::System.Type type = _typeTable[typeIndex];

            switch (typeIndex)
            {

            case 0:   //  UserControlApp.CustomSlider
                userType = new global::UserControlApp.UserControlApp_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.UserControl"));
                userType.Activator = Activate_0_CustomSlider;
                userType.AddMemberName("Minimum");
                userType.AddMemberName("Maximum");
                userType.AddMemberName("Value");
                userType.AddMemberName("Header");
                userType.AddMemberName("ValueSuffix");
                xamlType = userType;
                break;

            case 1:   //  Windows.UI.Xaml.Controls.UserControl
                xamlType = new global::UserControlApp.UserControlApp_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 2:   //  Int32
                xamlType = new global::UserControlApp.UserControlApp_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 3:   //  String
                xamlType = new global::UserControlApp.UserControlApp_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 4:   //  UserControlApp.MainPageViewModel
                userType = new global::UserControlApp.UserControlApp_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("UserControlApp.BindableBase"));
                userType.Activator = Activate_4_MainPageViewModel;
                userType.AddMemberName("Toasted");
                userType.AddMemberName("Roasted");
                userType.AddMemberName("Posted");
                xamlType = userType;
                break;

            case 5:   //  UserControlApp.BindableBase
                userType = new global::UserControlApp.UserControlApp_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                userType.Activator = Activate_5_BindableBase;
                xamlType = userType;
                break;

            case 6:   //  Object
                xamlType = new global::UserControlApp.UserControlApp_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 7:   //  UserControlApp.MainPage
                userType = new global::UserControlApp.UserControlApp_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_7_MainPage;
                xamlType = userType;
                break;

            case 8:   //  Windows.UI.Xaml.Controls.Page
                xamlType = new global::UserControlApp.UserControlApp_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;
            }
            return xamlType;
        }


        private object get_0_CustomSlider_Minimum(object instance)
        {
            var that = (global::UserControlApp.CustomSlider)instance;
            return that.Minimum;
        }
        private void set_0_CustomSlider_Minimum(object instance, object Value)
        {
            var that = (global::UserControlApp.CustomSlider)instance;
            that.Minimum = (global::System.Int32)Value;
        }
        private object get_1_CustomSlider_Maximum(object instance)
        {
            var that = (global::UserControlApp.CustomSlider)instance;
            return that.Maximum;
        }
        private void set_1_CustomSlider_Maximum(object instance, object Value)
        {
            var that = (global::UserControlApp.CustomSlider)instance;
            that.Maximum = (global::System.Int32)Value;
        }
        private object get_2_CustomSlider_Value(object instance)
        {
            var that = (global::UserControlApp.CustomSlider)instance;
            return that.Value;
        }
        private void set_2_CustomSlider_Value(object instance, object Value)
        {
            var that = (global::UserControlApp.CustomSlider)instance;
            that.Value = (global::System.Int32)Value;
        }
        private object get_3_CustomSlider_Header(object instance)
        {
            var that = (global::UserControlApp.CustomSlider)instance;
            return that.Header;
        }
        private void set_3_CustomSlider_Header(object instance, object Value)
        {
            var that = (global::UserControlApp.CustomSlider)instance;
            that.Header = (global::System.String)Value;
        }
        private object get_4_CustomSlider_ValueSuffix(object instance)
        {
            var that = (global::UserControlApp.CustomSlider)instance;
            return that.ValueSuffix;
        }
        private void set_4_CustomSlider_ValueSuffix(object instance, object Value)
        {
            var that = (global::UserControlApp.CustomSlider)instance;
            that.ValueSuffix = (global::System.String)Value;
        }
        private object get_5_MainPageViewModel_Toasted(object instance)
        {
            var that = (global::UserControlApp.MainPageViewModel)instance;
            return that.Toasted;
        }
        private void set_5_MainPageViewModel_Toasted(object instance, object Value)
        {
            var that = (global::UserControlApp.MainPageViewModel)instance;
            that.Toasted = (global::System.Int32)Value;
        }
        private object get_6_MainPageViewModel_Roasted(object instance)
        {
            var that = (global::UserControlApp.MainPageViewModel)instance;
            return that.Roasted;
        }
        private void set_6_MainPageViewModel_Roasted(object instance, object Value)
        {
            var that = (global::UserControlApp.MainPageViewModel)instance;
            that.Roasted = (global::System.Int32)Value;
        }
        private object get_7_MainPageViewModel_Posted(object instance)
        {
            var that = (global::UserControlApp.MainPageViewModel)instance;
            return that.Posted;
        }
        private void set_7_MainPageViewModel_Posted(object instance, object Value)
        {
            var that = (global::UserControlApp.MainPageViewModel)instance;
            that.Posted = (global::System.Int32)Value;
        }

        private global::Windows.UI.Xaml.Markup.IXamlMember CreateXamlMember(string longMemberName)
        {
            global::UserControlApp.UserControlApp_XamlTypeInfo.XamlMember xamlMember = null;
            global::UserControlApp.UserControlApp_XamlTypeInfo.XamlUserType userType;

            switch (longMemberName)
            {
            case "UserControlApp.CustomSlider.Minimum":
                userType = (global::UserControlApp.UserControlApp_XamlTypeInfo.XamlUserType)GetXamlTypeByName("UserControlApp.CustomSlider");
                xamlMember = new global::UserControlApp.UserControlApp_XamlTypeInfo.XamlMember(this, "Minimum", "Int32");
                xamlMember.SetIsDependencyProperty();
                xamlMember.Getter = get_0_CustomSlider_Minimum;
                xamlMember.Setter = set_0_CustomSlider_Minimum;
                break;
            case "UserControlApp.CustomSlider.Maximum":
                userType = (global::UserControlApp.UserControlApp_XamlTypeInfo.XamlUserType)GetXamlTypeByName("UserControlApp.CustomSlider");
                xamlMember = new global::UserControlApp.UserControlApp_XamlTypeInfo.XamlMember(this, "Maximum", "Int32");
                xamlMember.SetIsDependencyProperty();
                xamlMember.Getter = get_1_CustomSlider_Maximum;
                xamlMember.Setter = set_1_CustomSlider_Maximum;
                break;
            case "UserControlApp.CustomSlider.Value":
                userType = (global::UserControlApp.UserControlApp_XamlTypeInfo.XamlUserType)GetXamlTypeByName("UserControlApp.CustomSlider");
                xamlMember = new global::UserControlApp.UserControlApp_XamlTypeInfo.XamlMember(this, "Value", "Int32");
                xamlMember.SetIsDependencyProperty();
                xamlMember.Getter = get_2_CustomSlider_Value;
                xamlMember.Setter = set_2_CustomSlider_Value;
                break;
            case "UserControlApp.CustomSlider.Header":
                userType = (global::UserControlApp.UserControlApp_XamlTypeInfo.XamlUserType)GetXamlTypeByName("UserControlApp.CustomSlider");
                xamlMember = new global::UserControlApp.UserControlApp_XamlTypeInfo.XamlMember(this, "Header", "String");
                xamlMember.SetIsDependencyProperty();
                xamlMember.Getter = get_3_CustomSlider_Header;
                xamlMember.Setter = set_3_CustomSlider_Header;
                break;
            case "UserControlApp.CustomSlider.ValueSuffix":
                userType = (global::UserControlApp.UserControlApp_XamlTypeInfo.XamlUserType)GetXamlTypeByName("UserControlApp.CustomSlider");
                xamlMember = new global::UserControlApp.UserControlApp_XamlTypeInfo.XamlMember(this, "ValueSuffix", "String");
                xamlMember.SetIsDependencyProperty();
                xamlMember.Getter = get_4_CustomSlider_ValueSuffix;
                xamlMember.Setter = set_4_CustomSlider_ValueSuffix;
                break;
            case "UserControlApp.MainPageViewModel.Toasted":
                userType = (global::UserControlApp.UserControlApp_XamlTypeInfo.XamlUserType)GetXamlTypeByName("UserControlApp.MainPageViewModel");
                xamlMember = new global::UserControlApp.UserControlApp_XamlTypeInfo.XamlMember(this, "Toasted", "Int32");
                xamlMember.Getter = get_5_MainPageViewModel_Toasted;
                xamlMember.Setter = set_5_MainPageViewModel_Toasted;
                break;
            case "UserControlApp.MainPageViewModel.Roasted":
                userType = (global::UserControlApp.UserControlApp_XamlTypeInfo.XamlUserType)GetXamlTypeByName("UserControlApp.MainPageViewModel");
                xamlMember = new global::UserControlApp.UserControlApp_XamlTypeInfo.XamlMember(this, "Roasted", "Int32");
                xamlMember.Getter = get_6_MainPageViewModel_Roasted;
                xamlMember.Setter = set_6_MainPageViewModel_Roasted;
                break;
            case "UserControlApp.MainPageViewModel.Posted":
                userType = (global::UserControlApp.UserControlApp_XamlTypeInfo.XamlUserType)GetXamlTypeByName("UserControlApp.MainPageViewModel");
                xamlMember = new global::UserControlApp.UserControlApp_XamlTypeInfo.XamlMember(this, "Posted", "Int32");
                xamlMember.Getter = get_7_MainPageViewModel_Posted;
                xamlMember.Setter = set_7_MainPageViewModel_Posted;
                break;
            }
            return xamlMember;
        }
    }

    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlSystemBaseType : global::Windows.UI.Xaml.Markup.IXamlType
    {
        string _fullName;
        global::System.Type _underlyingType;

        public XamlSystemBaseType(string fullName, global::System.Type underlyingType)
        {
            _fullName = fullName;
            _underlyingType = underlyingType;
        }

        public string FullName { get { return _fullName; } }

        public global::System.Type UnderlyingType
        {
            get
            {
                return _underlyingType;
            }
        }

        virtual public global::Windows.UI.Xaml.Markup.IXamlType BaseType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlMember ContentProperty { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlMember GetMember(string name) { throw new global::System.NotImplementedException(); }
        virtual public bool IsArray { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsCollection { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsConstructible { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsDictionary { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsMarkupExtension { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsBindable { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsReturnTypeStub { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlType ItemType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlType KeyType { get { throw new global::System.NotImplementedException(); } }
        virtual public object ActivateInstance() { throw new global::System.NotImplementedException(); }
        virtual public void AddToMap(object instance, object key, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void AddToVector(object instance, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void RunInitializer()   { throw new global::System.NotImplementedException(); }
        virtual public object CreateFromString(string input)   { throw new global::System.NotImplementedException(); }
    }
    
    internal delegate object Activator();
    internal delegate void AddToCollection(object instance, object item);
    internal delegate void AddToDictionary(object instance, object key, object item);

    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlUserType : global::UserControlApp.UserControlApp_XamlTypeInfo.XamlSystemBaseType
    {
        global::UserControlApp.UserControlApp_XamlTypeInfo.XamlTypeInfoProvider _provider;
        global::Windows.UI.Xaml.Markup.IXamlType _baseType;
        bool _isArray;
        bool _isMarkupExtension;
        bool _isBindable;
        bool _isReturnTypeStub;

        string _contentPropertyName;
        string _itemTypeName;
        string _keyTypeName;
        global::System.Collections.Generic.Dictionary<string, string> _memberNames;
        global::System.Collections.Generic.Dictionary<string, object> _enumValues;

        public XamlUserType(global::UserControlApp.UserControlApp_XamlTypeInfo.XamlTypeInfoProvider provider, string fullName, global::System.Type fullType, global::Windows.UI.Xaml.Markup.IXamlType baseType)
            :base(fullName, fullType)
        {
            _provider = provider;
            _baseType = baseType;
        }

        // --- Interface methods ----

        override public global::Windows.UI.Xaml.Markup.IXamlType BaseType { get { return _baseType; } }
        override public bool IsArray { get { return _isArray; } }
        override public bool IsCollection { get { return (CollectionAdd != null); } }
        override public bool IsConstructible { get { return (Activator != null); } }
        override public bool IsDictionary { get { return (DictionaryAdd != null); } }
        override public bool IsMarkupExtension { get { return _isMarkupExtension; } }
        override public bool IsBindable { get { return _isBindable; } }
        override public bool IsReturnTypeStub { get { return _isReturnTypeStub; } }

        override public global::Windows.UI.Xaml.Markup.IXamlMember ContentProperty
        {
            get { return _provider.GetMemberByLongName(_contentPropertyName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlType ItemType
        {
            get { return _provider.GetXamlTypeByName(_itemTypeName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlType KeyType
        {
            get { return _provider.GetXamlTypeByName(_keyTypeName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlMember GetMember(string name)
        {
            if (_memberNames == null)
            {
                return null;
            }
            string longName;
            if (_memberNames.TryGetValue(name, out longName))
            {
                return _provider.GetMemberByLongName(longName);
            }
            return null;
        }

        override public object ActivateInstance()
        {
            return Activator(); 
        }

        override public void AddToMap(object instance, object key, object item) 
        {
            DictionaryAdd(instance, key, item);
        }

        override public void AddToVector(object instance, object item)
        {
            CollectionAdd(instance, item);
        }

        override public void RunInitializer() 
        {
            System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(UnderlyingType.TypeHandle);
        }

        override public object CreateFromString(string input)
        {
            if (_enumValues != null)
            {
                int value = 0;

                string[] valueParts = input.Split(',');

                foreach (string valuePart in valueParts) 
                {
                    object partValue;
                    int enumFieldValue = 0;
                    try
                    {
                        if (_enumValues.TryGetValue(valuePart.Trim(), out partValue))
                        {
                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                        }
                        else
                        {
                            try
                            {
                                enumFieldValue = global::System.Convert.ToInt32(valuePart.Trim());
                            }
                            catch( global::System.FormatException )
                            {
                                foreach( string key in _enumValues.Keys )
                                {
                                    if( string.Compare(valuePart.Trim(), key, global::System.StringComparison.OrdinalIgnoreCase) == 0 )
                                    {
                                        if( _enumValues.TryGetValue(key.Trim(), out partValue) )
                                        {
                                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                        value |= enumFieldValue; 
                    }
                    catch( global::System.FormatException )
                    {
                        throw new global::System.ArgumentException(input, FullName);
                    }
                }

                return value; 
            }
            throw new global::System.ArgumentException(input, FullName);
        }

        // --- End of Interface methods

        public Activator Activator { get; set; }
        public AddToCollection CollectionAdd { get; set; }
        public AddToDictionary DictionaryAdd { get; set; }

        public void SetContentPropertyName(string contentPropertyName)
        {
            _contentPropertyName = contentPropertyName;
        }

        public void SetIsArray()
        {
            _isArray = true; 
        }

        public void SetIsMarkupExtension()
        {
            _isMarkupExtension = true;
        }

        public void SetIsBindable()
        {
            _isBindable = true;
        }

        public void SetIsReturnTypeStub()
        {
            _isReturnTypeStub = true;
        }

        public void SetItemTypeName(string itemTypeName)
        {
            _itemTypeName = itemTypeName;
        }

        public void SetKeyTypeName(string keyTypeName)
        {
            _keyTypeName = keyTypeName;
        }

        public void AddMemberName(string shortName)
        {
            if(_memberNames == null)
            {
                _memberNames =  new global::System.Collections.Generic.Dictionary<string,string>();
            }
            _memberNames.Add(shortName, FullName + "." + shortName);
        }

        public void AddEnumValue(string name, object value)
        {
            if (_enumValues == null)
            {
                _enumValues = new global::System.Collections.Generic.Dictionary<string, object>();
            }
            _enumValues.Add(name, value);
        }
    }

    internal delegate object Getter(object instance);
    internal delegate void Setter(object instance, object value);

    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlMember : global::Windows.UI.Xaml.Markup.IXamlMember
    {
        global::UserControlApp.UserControlApp_XamlTypeInfo.XamlTypeInfoProvider _provider;
        string _name;
        bool _isAttachable;
        bool _isDependencyProperty;
        bool _isReadOnly;

        string _typeName;
        string _targetTypeName;

        public XamlMember(global::UserControlApp.UserControlApp_XamlTypeInfo.XamlTypeInfoProvider provider, string name, string typeName)
        {
            _name = name;
            _typeName = typeName;
            _provider = provider;
        }

        public string Name { get { return _name; } }

        public global::Windows.UI.Xaml.Markup.IXamlType Type
        {
            get { return _provider.GetXamlTypeByName(_typeName); }
        }

        public void SetTargetTypeName(string targetTypeName)
        {
            _targetTypeName = targetTypeName;
        }
        public global::Windows.UI.Xaml.Markup.IXamlType TargetType
        {
            get { return _provider.GetXamlTypeByName(_targetTypeName); }
        }

        public void SetIsAttachable() { _isAttachable = true; }
        public bool IsAttachable { get { return _isAttachable; } }

        public void SetIsDependencyProperty() { _isDependencyProperty = true; }
        public bool IsDependencyProperty { get { return _isDependencyProperty; } }

        public void SetIsReadOnly() { _isReadOnly = true; }
        public bool IsReadOnly { get { return _isReadOnly; } }

        public Getter Getter { get; set; }
        public object GetValue(object instance)
        {
            if (Getter != null)
                return Getter(instance);
            else
                throw new global::System.InvalidOperationException("GetValue");
        }

        public Setter Setter { get; set; }
        public void SetValue(object instance, object value)
        {
            if (Setter != null)
                Setter(instance, value);
            else
                throw new global::System.InvalidOperationException("SetValue");
        }
    }
}


