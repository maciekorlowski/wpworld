﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



namespace Wp_World
{
    public partial class App : global::Windows.UI.Xaml.Markup.IXamlMetadataProvider
    {
    private global::Wp_World.Wp_World_XamlTypeInfo.XamlTypeInfoProvider _provider;

        /// <summary>
        /// GetXamlType(Type)
        /// </summary>
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(global::System.Type type)
        {
            if(_provider == null)
            {
                _provider = new global::Wp_World.Wp_World_XamlTypeInfo.XamlTypeInfoProvider();
            }
            return _provider.GetXamlTypeByType(type);
        }

        /// <summary>
        /// GetXamlType(String)
        /// </summary>
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(string fullName)
        {
            if(_provider == null)
            {
                _provider = new global::Wp_World.Wp_World_XamlTypeInfo.XamlTypeInfoProvider();
            }
            return _provider.GetXamlTypeByName(fullName);
        }

        /// <summary>
        /// GetXmlnsDefinitions()
        /// </summary>
        public global::Windows.UI.Xaml.Markup.XmlnsDefinition[] GetXmlnsDefinitions()
        {
            return new global::Windows.UI.Xaml.Markup.XmlnsDefinition[0];
        }
    }
}

namespace Wp_World.Wp_World_XamlTypeInfo
{
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
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
            _typeNameTable = new string[12];
            _typeNameTable[0] = "Wp_World.MainPage";
            _typeNameTable[1] = "Windows.UI.Xaml.Controls.Page";
            _typeNameTable[2] = "Windows.UI.Xaml.Controls.UserControl";
            _typeNameTable[3] = "System.Collections.ObjectModel.ObservableCollection`1<Wp_World.Models.Article>";
            _typeNameTable[4] = "System.Collections.ObjectModel.Collection`1<Wp_World.Models.Article>";
            _typeNameTable[5] = "Object";
            _typeNameTable[6] = "Wp_World.Models.Article";
            _typeNameTable[7] = "String";
            _typeNameTable[8] = "System.DateTime";
            _typeNameTable[9] = "System.ValueType";
            _typeNameTable[10] = "Int32";
            _typeNameTable[11] = "Windows.UI.Xaml.Media.Imaging.BitmapImage";

            _typeTable = new global::System.Type[12];
            _typeTable[0] = typeof(global::Wp_World.MainPage);
            _typeTable[1] = typeof(global::Windows.UI.Xaml.Controls.Page);
            _typeTable[2] = typeof(global::Windows.UI.Xaml.Controls.UserControl);
            _typeTable[3] = typeof(global::System.Collections.ObjectModel.ObservableCollection<global::Wp_World.Models.Article>);
            _typeTable[4] = typeof(global::System.Collections.ObjectModel.Collection<global::Wp_World.Models.Article>);
            _typeTable[5] = typeof(global::System.Object);
            _typeTable[6] = typeof(global::Wp_World.Models.Article);
            _typeTable[7] = typeof(global::System.String);
            _typeTable[8] = typeof(global::System.DateTime);
            _typeTable[9] = typeof(global::System.ValueType);
            _typeTable[10] = typeof(global::System.Int32);
            _typeTable[11] = typeof(global::Windows.UI.Xaml.Media.Imaging.BitmapImage);
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

        private object Activate_0_MainPage() { return new global::Wp_World.MainPage(); }
        private object Activate_3_ObservableCollection() { return new global::System.Collections.ObjectModel.ObservableCollection<global::Wp_World.Models.Article>(); }
        private object Activate_4_Collection() { return new global::System.Collections.ObjectModel.Collection<global::Wp_World.Models.Article>(); }
        private object Activate_6_Article() { return new global::Wp_World.Models.Article(); }
        private void VectorAdd_3_ObservableCollection(object instance, object item)
        {
            var collection = (global::System.Collections.Generic.ICollection<global::Wp_World.Models.Article>)instance;
            var newItem = (global::Wp_World.Models.Article)item;
            collection.Add(newItem);
        }
        private void VectorAdd_4_Collection(object instance, object item)
        {
            var collection = (global::System.Collections.Generic.ICollection<global::Wp_World.Models.Article>)instance;
            var newItem = (global::Wp_World.Models.Article)item;
            collection.Add(newItem);
        }

        private global::Windows.UI.Xaml.Markup.IXamlType CreateXamlType(int typeIndex)
        {
            global::Wp_World.Wp_World_XamlTypeInfo.XamlSystemBaseType xamlType = null;
            global::Wp_World.Wp_World_XamlTypeInfo.XamlUserType userType;
            string typeName = _typeNameTable[typeIndex];
            global::System.Type type = _typeTable[typeIndex];

            switch (typeIndex)
            {

            case 0:   //  Wp_World.MainPage
                userType = new global::Wp_World.Wp_World_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_0_MainPage;
                userType.AddMemberName("Articles");
                userType.AddMemberName("SelectedArticle");
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 1:   //  Windows.UI.Xaml.Controls.Page
                xamlType = new global::Wp_World.Wp_World_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 2:   //  Windows.UI.Xaml.Controls.UserControl
                xamlType = new global::Wp_World.Wp_World_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 3:   //  System.Collections.ObjectModel.ObservableCollection`1<Wp_World.Models.Article>
                userType = new global::Wp_World.Wp_World_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("System.Collections.ObjectModel.Collection`1<Wp_World.Models.Article>"));
                userType.CollectionAdd = VectorAdd_3_ObservableCollection;
                userType.SetIsReturnTypeStub();
                xamlType = userType;
                break;

            case 4:   //  System.Collections.ObjectModel.Collection`1<Wp_World.Models.Article>
                userType = new global::Wp_World.Wp_World_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                userType.Activator = Activate_4_Collection;
                userType.CollectionAdd = VectorAdd_4_Collection;
                xamlType = userType;
                break;

            case 5:   //  Object
                xamlType = new global::Wp_World.Wp_World_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 6:   //  Wp_World.Models.Article
                userType = new global::Wp_World.Wp_World_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                userType.Activator = Activate_6_Article;
                userType.AddMemberName("title");
                userType.AddMemberName("link");
                userType.AddMemberName("publishDate");
                userType.AddMemberName("ParsedDateTime");
                userType.AddMemberName("publishDateStr");
                userType.AddMemberName("author");
                userType.AddMemberName("description");
                userType.AddMemberName("commentCount");
                userType.AddMemberName("image");
                userType.AddMemberName("ID");
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 7:   //  String
                xamlType = new global::Wp_World.Wp_World_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 8:   //  System.DateTime
                userType = new global::Wp_World.Wp_World_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("System.ValueType"));
                userType.SetIsReturnTypeStub();
                xamlType = userType;
                break;

            case 9:   //  System.ValueType
                userType = new global::Wp_World.Wp_World_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                xamlType = userType;
                break;

            case 10:   //  Int32
                xamlType = new global::Wp_World.Wp_World_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 11:   //  Windows.UI.Xaml.Media.Imaging.BitmapImage
                xamlType = new global::Wp_World.Wp_World_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;
            }
            return xamlType;
        }


        private object get_0_MainPage_Articles(object instance)
        {
            var that = (global::Wp_World.MainPage)instance;
            return that.Articles;
        }
        private void set_0_MainPage_Articles(object instance, object Value)
        {
            var that = (global::Wp_World.MainPage)instance;
            that.Articles = (global::System.Collections.ObjectModel.ObservableCollection<global::Wp_World.Models.Article>)Value;
        }
        private object get_1_Article_title(object instance)
        {
            var that = (global::Wp_World.Models.Article)instance;
            return that.title;
        }
        private void set_1_Article_title(object instance, object Value)
        {
            var that = (global::Wp_World.Models.Article)instance;
            that.title = (global::System.String)Value;
        }
        private object get_2_Article_link(object instance)
        {
            var that = (global::Wp_World.Models.Article)instance;
            return that.link;
        }
        private void set_2_Article_link(object instance, object Value)
        {
            var that = (global::Wp_World.Models.Article)instance;
            that.link = (global::System.String)Value;
        }
        private object get_3_Article_publishDate(object instance)
        {
            var that = (global::Wp_World.Models.Article)instance;
            return that.publishDate;
        }
        private void set_3_Article_publishDate(object instance, object Value)
        {
            var that = (global::Wp_World.Models.Article)instance;
            that.publishDate = (global::System.DateTime)Value;
        }
        private object get_4_Article_ParsedDateTime(object instance)
        {
            var that = (global::Wp_World.Models.Article)instance;
            return that.ParsedDateTime;
        }
        private void set_4_Article_ParsedDateTime(object instance, object Value)
        {
            var that = (global::Wp_World.Models.Article)instance;
            that.ParsedDateTime = (global::System.String)Value;
        }
        private object get_5_Article_publishDateStr(object instance)
        {
            var that = (global::Wp_World.Models.Article)instance;
            return that.publishDateStr;
        }
        private void set_5_Article_publishDateStr(object instance, object Value)
        {
            var that = (global::Wp_World.Models.Article)instance;
            that.publishDateStr = (global::System.String)Value;
        }
        private object get_6_Article_author(object instance)
        {
            var that = (global::Wp_World.Models.Article)instance;
            return that.author;
        }
        private void set_6_Article_author(object instance, object Value)
        {
            var that = (global::Wp_World.Models.Article)instance;
            that.author = (global::System.String)Value;
        }
        private object get_7_Article_description(object instance)
        {
            var that = (global::Wp_World.Models.Article)instance;
            return that.description;
        }
        private void set_7_Article_description(object instance, object Value)
        {
            var that = (global::Wp_World.Models.Article)instance;
            that.description = (global::System.String)Value;
        }
        private object get_8_Article_commentCount(object instance)
        {
            var that = (global::Wp_World.Models.Article)instance;
            return that.commentCount;
        }
        private void set_8_Article_commentCount(object instance, object Value)
        {
            var that = (global::Wp_World.Models.Article)instance;
            that.commentCount = (global::System.Int32)Value;
        }
        private object get_9_Article_image(object instance)
        {
            var that = (global::Wp_World.Models.Article)instance;
            return that.image;
        }
        private void set_9_Article_image(object instance, object Value)
        {
            var that = (global::Wp_World.Models.Article)instance;
            that.image = (global::Windows.UI.Xaml.Media.Imaging.BitmapImage)Value;
        }
        private object get_10_Article_ID(object instance)
        {
            var that = (global::Wp_World.Models.Article)instance;
            return that.ID;
        }
        private void set_10_Article_ID(object instance, object Value)
        {
            var that = (global::Wp_World.Models.Article)instance;
            that.ID = (global::System.String)Value;
        }
        private object get_11_MainPage_SelectedArticle(object instance)
        {
            var that = (global::Wp_World.MainPage)instance;
            return that.SelectedArticle;
        }
        private void set_11_MainPage_SelectedArticle(object instance, object Value)
        {
            var that = (global::Wp_World.MainPage)instance;
            that.SelectedArticle = (global::Wp_World.Models.Article)Value;
        }

        private global::Windows.UI.Xaml.Markup.IXamlMember CreateXamlMember(string longMemberName)
        {
            global::Wp_World.Wp_World_XamlTypeInfo.XamlMember xamlMember = null;
            global::Wp_World.Wp_World_XamlTypeInfo.XamlUserType userType;

            switch (longMemberName)
            {
            case "Wp_World.MainPage.Articles":
                userType = (global::Wp_World.Wp_World_XamlTypeInfo.XamlUserType)GetXamlTypeByName("Wp_World.MainPage");
                xamlMember = new global::Wp_World.Wp_World_XamlTypeInfo.XamlMember(this, "Articles", "System.Collections.ObjectModel.ObservableCollection`1<Wp_World.Models.Article>");
                xamlMember.Getter = get_0_MainPage_Articles;
                xamlMember.Setter = set_0_MainPage_Articles;
                break;
            case "Wp_World.Models.Article.title":
                userType = (global::Wp_World.Wp_World_XamlTypeInfo.XamlUserType)GetXamlTypeByName("Wp_World.Models.Article");
                xamlMember = new global::Wp_World.Wp_World_XamlTypeInfo.XamlMember(this, "title", "String");
                xamlMember.Getter = get_1_Article_title;
                xamlMember.Setter = set_1_Article_title;
                break;
            case "Wp_World.Models.Article.link":
                userType = (global::Wp_World.Wp_World_XamlTypeInfo.XamlUserType)GetXamlTypeByName("Wp_World.Models.Article");
                xamlMember = new global::Wp_World.Wp_World_XamlTypeInfo.XamlMember(this, "link", "String");
                xamlMember.Getter = get_2_Article_link;
                xamlMember.Setter = set_2_Article_link;
                break;
            case "Wp_World.Models.Article.publishDate":
                userType = (global::Wp_World.Wp_World_XamlTypeInfo.XamlUserType)GetXamlTypeByName("Wp_World.Models.Article");
                xamlMember = new global::Wp_World.Wp_World_XamlTypeInfo.XamlMember(this, "publishDate", "System.DateTime");
                xamlMember.Getter = get_3_Article_publishDate;
                xamlMember.Setter = set_3_Article_publishDate;
                break;
            case "Wp_World.Models.Article.ParsedDateTime":
                userType = (global::Wp_World.Wp_World_XamlTypeInfo.XamlUserType)GetXamlTypeByName("Wp_World.Models.Article");
                xamlMember = new global::Wp_World.Wp_World_XamlTypeInfo.XamlMember(this, "ParsedDateTime", "String");
                xamlMember.Getter = get_4_Article_ParsedDateTime;
                xamlMember.Setter = set_4_Article_ParsedDateTime;
                break;
            case "Wp_World.Models.Article.publishDateStr":
                userType = (global::Wp_World.Wp_World_XamlTypeInfo.XamlUserType)GetXamlTypeByName("Wp_World.Models.Article");
                xamlMember = new global::Wp_World.Wp_World_XamlTypeInfo.XamlMember(this, "publishDateStr", "String");
                xamlMember.Getter = get_5_Article_publishDateStr;
                xamlMember.Setter = set_5_Article_publishDateStr;
                break;
            case "Wp_World.Models.Article.author":
                userType = (global::Wp_World.Wp_World_XamlTypeInfo.XamlUserType)GetXamlTypeByName("Wp_World.Models.Article");
                xamlMember = new global::Wp_World.Wp_World_XamlTypeInfo.XamlMember(this, "author", "String");
                xamlMember.Getter = get_6_Article_author;
                xamlMember.Setter = set_6_Article_author;
                break;
            case "Wp_World.Models.Article.description":
                userType = (global::Wp_World.Wp_World_XamlTypeInfo.XamlUserType)GetXamlTypeByName("Wp_World.Models.Article");
                xamlMember = new global::Wp_World.Wp_World_XamlTypeInfo.XamlMember(this, "description", "String");
                xamlMember.Getter = get_7_Article_description;
                xamlMember.Setter = set_7_Article_description;
                break;
            case "Wp_World.Models.Article.commentCount":
                userType = (global::Wp_World.Wp_World_XamlTypeInfo.XamlUserType)GetXamlTypeByName("Wp_World.Models.Article");
                xamlMember = new global::Wp_World.Wp_World_XamlTypeInfo.XamlMember(this, "commentCount", "Int32");
                xamlMember.Getter = get_8_Article_commentCount;
                xamlMember.Setter = set_8_Article_commentCount;
                break;
            case "Wp_World.Models.Article.image":
                userType = (global::Wp_World.Wp_World_XamlTypeInfo.XamlUserType)GetXamlTypeByName("Wp_World.Models.Article");
                xamlMember = new global::Wp_World.Wp_World_XamlTypeInfo.XamlMember(this, "image", "Windows.UI.Xaml.Media.Imaging.BitmapImage");
                xamlMember.Getter = get_9_Article_image;
                xamlMember.Setter = set_9_Article_image;
                break;
            case "Wp_World.Models.Article.ID":
                userType = (global::Wp_World.Wp_World_XamlTypeInfo.XamlUserType)GetXamlTypeByName("Wp_World.Models.Article");
                xamlMember = new global::Wp_World.Wp_World_XamlTypeInfo.XamlMember(this, "ID", "String");
                xamlMember.Getter = get_10_Article_ID;
                xamlMember.Setter = set_10_Article_ID;
                break;
            case "Wp_World.MainPage.SelectedArticle":
                userType = (global::Wp_World.Wp_World_XamlTypeInfo.XamlUserType)GetXamlTypeByName("Wp_World.MainPage");
                xamlMember = new global::Wp_World.Wp_World_XamlTypeInfo.XamlMember(this, "SelectedArticle", "Wp_World.Models.Article");
                xamlMember.Getter = get_11_MainPage_SelectedArticle;
                xamlMember.Setter = set_11_MainPage_SelectedArticle;
                break;
            }
            return xamlMember;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
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
        virtual public bool IsLocalType { get { throw new global::System.NotImplementedException(); } }
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

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlUserType : global::Wp_World.Wp_World_XamlTypeInfo.XamlSystemBaseType
    {
        global::Wp_World.Wp_World_XamlTypeInfo.XamlTypeInfoProvider _provider;
        global::Windows.UI.Xaml.Markup.IXamlType _baseType;
        bool _isArray;
        bool _isMarkupExtension;
        bool _isBindable;
        bool _isReturnTypeStub;
        bool _isLocalType;

        string _contentPropertyName;
        string _itemTypeName;
        string _keyTypeName;
        global::System.Collections.Generic.Dictionary<string, string> _memberNames;
        global::System.Collections.Generic.Dictionary<string, object> _enumValues;

        public XamlUserType(global::Wp_World.Wp_World_XamlTypeInfo.XamlTypeInfoProvider provider, string fullName, global::System.Type fullType, global::Windows.UI.Xaml.Markup.IXamlType baseType)
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
        override public bool IsLocalType { get { return _isLocalType; } }

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

        public void SetIsLocalType()
        {
            _isLocalType = true;
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

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlMember : global::Windows.UI.Xaml.Markup.IXamlMember
    {
        global::Wp_World.Wp_World_XamlTypeInfo.XamlTypeInfoProvider _provider;
        string _name;
        bool _isAttachable;
        bool _isDependencyProperty;
        bool _isReadOnly;

        string _typeName;
        string _targetTypeName;

        public XamlMember(global::Wp_World.Wp_World_XamlTypeInfo.XamlTypeInfoProvider provider, string name, string typeName)
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

