﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MCUtils {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MCUtils.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ID,Properties,Numeric ID,Pre-flattening ID,Added in Version,Fallback
        ///air,,0,air,,
        ///stone,,1,stone,,
        ///granite,,1:1,stone,1.8,stone
        ///polished_granite,,1:2,stone,1.8,stone
        ///diorite,,1:3,stone,1.8,stone
        ///polished_diorite,,1:4,stone,1.8,stone
        ///andesite,,1:5,stone,1.8,stone
        ///polished_andesite,,1:6,stone,1.8,stone
        ///grass_block,,2,grass,,
        ///dirt,,3,dirt,,
        ///coarse_dirt,,3:1,dirt,1.8,dirt
        ///podzol,,3:2,dirt,1.7,dirt
        ///cobblestone,,4,cobblestone,,
        ///oak_planks,,5,planks,,
        ///spruce_planks,,5:1,planks,1.2.4,oak_planks
        ///birc [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string blocks {
            get {
                return ResourceManager.GetString("blocks", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        internal static byte[] colormap {
            get {
                object obj = ResourceManager.GetObject("colormap", resourceCulture);
                return ((byte[])(obj));
            }
        }
    }
}
