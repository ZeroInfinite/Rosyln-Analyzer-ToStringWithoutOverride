﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ToStringWithoutOverrideAnalyzer {
    using System;
    using System.Reflection;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ToStringWithoutOverrideAnalyzer.Resources", typeof(Resources).GetTypeInfo().Assembly);
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
        ///   Looks up a localized string similar to Prevents calling .ToString() on a type which does not provide an override.
        /// </summary>
        internal static string ExplicitToStringWithoutOverrideDescription {
            get {
                return ResourceManager.GetString("ExplicitToStringWithoutOverrideDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Calling ToString() on object of type &apos;{0}&apos; but it does not override ToString().
        /// </summary>
        internal static string ExplicitToStringWithoutOverrideMessageFormat {
            get {
                return ResourceManager.GetString("ExplicitToStringWithoutOverrideMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Suspicious conversion to string.
        /// </summary>
        internal static string ExplicitToStringWithoutOverrideTitle {
            get {
                return ResourceManager.GetString("ExplicitToStringWithoutOverrideTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Prevents calling .ToString() on a type which does not provide an override.
        /// </summary>
        internal static string InterpolatedStringImplicitToStringDescription {
            get {
                return ResourceManager.GetString("InterpolatedStringImplicitToStringDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expression of type &apos;{0}&apos; will be converted to a string, but does not override ToString().
        /// </summary>
        internal static string InterpolatedStringImplicitToStringMessageFormat {
            get {
                return ResourceManager.GetString("InterpolatedStringImplicitToStringMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Suspicious conversion to string.
        /// </summary>
        internal static string InterpolatedStringImplicitToStringTitle {
            get {
                return ResourceManager.GetString("InterpolatedStringImplicitToStringTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Prevents calling .ToString() on a type which does not provide an override.
        /// </summary>
        internal static string StringConcatenationWithImplicitConversionDescription {
            get {
                return ResourceManager.GetString("StringConcatenationWithImplicitConversionDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expression of type &apos;{0}&apos; will be implicitly converted to a string, but does not override ToString().
        /// </summary>
        internal static string StringConcatenationWithImplicitConversionMessageFormat {
            get {
                return ResourceManager.GetString("StringConcatenationWithImplicitConversionMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Suspicious implicit conversion to string.
        /// </summary>
        internal static string StringConcatenationWithImplicitConversionTitle {
            get {
                return ResourceManager.GetString("StringConcatenationWithImplicitConversionTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Prevents calling .ToString() on a type which does not provide an override.
        /// </summary>
        internal static string StringFormatArgumentImplicitToStringDescription {
            get {
                return ResourceManager.GetString("StringFormatArgumentImplicitToStringDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expression of type &apos;{0}&apos; will be converted to a string, but does not override ToString().
        /// </summary>
        internal static string StringFormatArgumentImplicitToStringMessageFormat {
            get {
                return ResourceManager.GetString("StringFormatArgumentImplicitToStringMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Suspicious conversion to string.
        /// </summary>
        internal static string StringFormatArgumentImplicitToStringTitle {
            get {
                return ResourceManager.GetString("StringFormatArgumentImplicitToStringTitle", resourceCulture);
            }
        }
    }
}
