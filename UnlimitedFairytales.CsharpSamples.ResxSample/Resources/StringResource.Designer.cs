﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.42000
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace UnlimitedFairytales.CsharpSamples.ResxSample.Resources {
    using System;
    
    
    /// <summary>
    ///   ローカライズされた文字列などを検索するための、厳密に型指定されたリソース クラスです。
    /// </summary>
    // このクラスは StronglyTypedResourceBuilder クラスが ResGen
    // または Visual Studio のようなツールを使用して自動生成されました。
    // メンバーを追加または削除するには、.ResX ファイルを編集して、/str オプションと共に
    // ResGen を実行し直すか、または VS プロジェクトをビルドし直します。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class StringResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal StringResource() {
        }
        
        /// <summary>
        ///   このクラスで使用されているキャッシュされた ResourceManager インスタンスを返します。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("UnlimitedFairytales.CsharpSamples.ResxSample.Resources.StringResource", typeof(StringResource).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   すべてについて、現在のスレッドの CurrentUICulture プロパティをオーバーライドします
        ///   現在のスレッドの CurrentUICulture プロパティをオーバーライドします。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   A database error has occurred. Contact your system administrator. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string ERR_DB {
            get {
                return ResourceManager.GetString("ERR_DB", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Could not begin a transaction. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string ERR_DB_BEGIN_TRANSACTION {
            get {
                return ResourceManager.GetString("ERR_DB_BEGIN_TRANSACTION", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Could not close database connection. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string ERR_DB_CLOSE {
            get {
                return ResourceManager.GetString("ERR_DB_CLOSE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Could not commit the transaction. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string ERR_DB_COMMIT {
            get {
                return ResourceManager.GetString("ERR_DB_COMMIT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Could not open a database connection. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string ERR_DB_OPEN {
            get {
                return ResourceManager.GetString("ERR_DB_OPEN", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Could not rollback the transaction. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string ERR_DB_ROLLBACK {
            get {
                return ResourceManager.GetString("ERR_DB_ROLLBACK", resourceCulture);
            }
        }
        
        /// <summary>
        ///   A SQL error occurred. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string ERR_DB_SQL {
            get {
                return ResourceManager.GetString("ERR_DB_SQL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   A network error has occurred. Contact your system administrator. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string ERR_NETWORK {
            get {
                return ResourceManager.GetString("ERR_NETWORK", resourceCulture);
            }
        }
        
        /// <summary>
        ///   A system error has occurred. Contact your system administrator. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string ERR_SYSTEM {
            get {
                return ResourceManager.GetString("ERR_SYSTEM", resourceCulture);
            }
        }
    }
}
