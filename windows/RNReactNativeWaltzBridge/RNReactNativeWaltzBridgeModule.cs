using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace React.Native.Waltz.Bridge.RNReactNativeWaltzBridge
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNReactNativeWaltzBridgeModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNReactNativeWaltzBridgeModule"/>.
        /// </summary>
        internal RNReactNativeWaltzBridgeModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNReactNativeWaltzBridge";
            }
        }
    }
}
