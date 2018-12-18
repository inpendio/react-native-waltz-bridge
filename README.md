
# react-native-react-native-waltz-bridge

## Getting started

`$ npm install react-native-react-native-waltz-bridge --save`

### Mostly automatic installation

`$ react-native link react-native-react-native-waltz-bridge`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-react-native-waltz-bridge` and add `RNReactNativeWaltzBridge.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNReactNativeWaltzBridge.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNReactNativeWaltzBridgePackage;` to the imports at the top of the file
  - Add `new RNReactNativeWaltzBridgePackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-react-native-waltz-bridge'
  	project(':react-native-react-native-waltz-bridge').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-react-native-waltz-bridge/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-react-native-waltz-bridge')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNReactNativeWaltzBridge.sln` in `node_modules/react-native-react-native-waltz-bridge/windows/RNReactNativeWaltzBridge.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using React.Native.Waltz.Bridge.RNReactNativeWaltzBridge;` to the usings at the top of the file
  - Add `new RNReactNativeWaltzBridgePackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNReactNativeWaltzBridge from 'react-native-react-native-waltz-bridge';

// TODO: What to do with the module?
RNReactNativeWaltzBridge;
```
  