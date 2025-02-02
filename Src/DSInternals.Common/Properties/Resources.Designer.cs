﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DSInternals.Common.Properties {
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
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DSInternals.Common.Properties.Resources", typeof(Resources).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Directory schema does not contain attribute &apos;{0}&apos;..
        /// </summary>
        public static string AttributeNotFoundMessageFormat {
            get {
                return ResourceManager.GetString("AttributeNotFoundMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error parsing distinguished name..
        /// </summary>
        public static string DNParsingErrorMessage {
            get {
                return ResourceManager.GetString("DNParsingErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The input is longer than the maximum length..
        /// </summary>
        public static string InputLongerThanMaxMessage {
            get {
                return ResourceManager.GetString("InputLongerThanMaxMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The input is shorter than the minimum length..
        /// </summary>
        public static string InputShorterThanMinMessage {
            get {
                return ResourceManager.GetString("InputShorterThanMinMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CRC check failed..
        /// </summary>
        public static string InvalidCRCMessage {
            get {
                return ResourceManager.GetString("InvalidCRCMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Parameter is not in the DN-Binary format..
        /// </summary>
        public static string NotDNWithBinaryMessage {
            get {
                return ResourceManager.GetString("NotDNWithBinaryMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Parameter is not a hexadecimal string..
        /// </summary>
        public static string NotHexStringMessage {
            get {
                return ResourceManager.GetString("NotHexStringMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Object is not an account..
        /// </summary>
        public static string ObjectNotAccountMessage {
            get {
                return ResourceManager.GetString("ObjectNotAccountMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not find the requested object..
        /// </summary>
        public static string ObjectNotFoundMessage {
            get {
                return ResourceManager.GetString("ObjectNotFoundMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Object is not a security principal..
        /// </summary>
        public static string ObjectNotSecurityPrincipalMessage {
            get {
                return ResourceManager.GetString("ObjectNotSecurityPrincipalMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Object with identity &apos;{0}&apos; has not been found..
        /// </summary>
        public static string ObjectWithIdentityNotFoundMessageFormat {
            get {
                return ResourceManager.GetString("ObjectWithIdentityNotFoundMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} (Object identity: &apos;{1}&apos;).
        /// </summary>
        public static string OperationExceptionMessageFormat {
            get {
                return ResourceManager.GetString("OperationExceptionMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Path not found..
        /// </summary>
        public static string PathNotFoundMessage {
            get {
                return ResourceManager.GetString("PathNotFoundMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The length of the input is unexpected..
        /// </summary>
        public static string UnexpectedLengthMessage {
            get {
                return ResourceManager.GetString("UnexpectedLengthMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unexpected length of the supplemental credentials structure..
        /// </summary>
        public static string UnexpectedSupplementalCredsLengthMessage {
            get {
                return ResourceManager.GetString("UnexpectedSupplementalCredsLengthMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Supplemental credentials do not have a valid signature..
        /// </summary>
        public static string UnexpectedSupplementalCredsSignatureMessage {
            get {
                return ResourceManager.GetString("UnexpectedSupplementalCredsSignatureMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unsupported secret encryption algorithm..
        /// </summary>
        public static string UnsupportedSecretEncryptionType {
            get {
                return ResourceManager.GetString("UnsupportedSecretEncryptionType", resourceCulture);
            }
        }
    }
}
