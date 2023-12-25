// Decompiled with JetBrains decompiler
// Type: ProjectM.GraphicsSettingsManager
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Rendering;

#nullable disable
namespace ProjectM
{
  public static class GraphicsSettingsManager : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__PostProcessVolumeProfile;
    private static readonly System.IntPtr NativeMethodInfoPtr_InitializeGlobalSettings_Public_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InitializeGameSettings_Public_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryApplyGameSettings_Public_Static_Void_GraphicsSettings_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetTextureQuality_Public_Static_Void_QualitySetting_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetTextureMipStreaming_Public_Static_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetBrightness_Private_Static_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetFluffDensity_Private_Static_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetHighQualityVegetation_Private_Static_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetHighQualityAtmosphere_Private_Static_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetFullscreenMode_Public_Static_Void_FullScreenMode_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetResolution_Public_Static_Void_int2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetResolution_Public_Static_Void_int2_FullScreenMode_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetResolution_Public_Static_Void_Int32_Int32_FullScreenMode_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetClothQuality_Private_Static_Void_QualitySetting_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetClothUpdateRate_Private_Static_Void_ClothUpdateSpeed_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetDynamicResolutionScale_Private_Static_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__TryGetVolumeProfile_Private_Static_Boolean_byref_VolumeProfile_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetAntiAliasingMode_Public_Static_Void_AntiAliasingMode_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetAmbientOcclusionQuality_Public_Static_Void_QualitySetting_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetShadowQuality_Public_Static_Void_QualitySetting_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetVolumetricFogQuality_Public_Static_Void_QualitySetting_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetVolumetricsState_Public_Static_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetBloomQuality_Public_Static_Void_QualitySetting_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetVerticalSync_Public_Static_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetMotionBlur_Public_Static_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetDepthOfField_Public_Static_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryApplyGraphicsSettingsToCamera_Public_Static_Void_byref_Camera_byref_Volume_GraphicsSettings_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetAntiAliasingModeForCamera_Private_Static_Void_byref_Camera_AntiAliasingMode_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetAmbientOcclusionQuality_Public_Static_Void_byref_Volume_QualitySetting_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetBloomQuality_Public_Static_Void_byref_Volume_QualitySetting_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ActiveTAA_Public_Static_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetDynResForQualityMode_Private_Static_Single_FSRQualityMode_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TurnOffFSR_Public_Static_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TurnOnFSR_Private_Static_Void_FSRQualityMode_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetFSRQuality_Public_Static_Void_FSRQualityMode_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1044470, RefRangeEnd = 1044471, XrefRangeStart = 1044464, XrefRangeEnd = 1044470, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void InitializeGlobalSettings()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GraphicsSettingsManager.NativeMethodInfoPtr_InitializeGlobalSettings_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1044498, RefRangeEnd = 1044502, XrefRangeStart = 1044471, XrefRangeEnd = 1044498, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void InitializeGameSettings()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GraphicsSettingsManager.NativeMethodInfoPtr_InitializeGameSettings_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1044643, RefRangeEnd = 1044647, XrefRangeStart = 1044502, XrefRangeEnd = 1044643, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TryApplyGameSettings(
      GraphicsSettings settings,
      bool reinstantiateHybridModels = false)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) settings);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &reinstantiateHybridModels;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GraphicsSettingsManager.NativeMethodInfoPtr_TryApplyGameSettings_Public_Static_Void_GraphicsSettings_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1044647, XrefRangeEnd = 1044649, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetTextureQuality(QualitySetting newQuality)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &newQuality;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GraphicsSettingsManager.NativeMethodInfoPtr_SetTextureQuality_Public_Static_Void_QualitySetting_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1044649, XrefRangeEnd = 1044655, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetTextureMipStreaming(bool enabled)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &enabled;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GraphicsSettingsManager.NativeMethodInfoPtr_SetTextureMipStreaming_Public_Static_Void_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1044655, XrefRangeEnd = 1044659, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetBrightness(float newValue)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &newValue;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GraphicsSettingsManager.NativeMethodInfoPtr_SetBrightness_Private_Static_Void_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1044659, XrefRangeEnd = 1044665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetFluffDensity(float newValue)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &newValue;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GraphicsSettingsManager.NativeMethodInfoPtr_SetFluffDensity_Private_Static_Void_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1044665, XrefRangeEnd = 1044674, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetHighQualityVegetation(bool newValue)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &newValue;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GraphicsSettingsManager.NativeMethodInfoPtr_SetHighQualityVegetation_Private_Static_Void_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1044674, XrefRangeEnd = 1044682, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetHighQualityAtmosphere(bool newValue)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &newValue;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GraphicsSettingsManager.NativeMethodInfoPtr_SetHighQualityAtmosphere_Private_Static_Void_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1044687, RefRangeEnd = 1044688, XrefRangeStart = 1044682, XrefRangeEnd = 1044687, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetFullscreenMode(FullScreenMode fullScreenMode)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &fullScreenMode;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GraphicsSettingsManager.NativeMethodInfoPtr_SetFullscreenMode_Public_Static_Void_FullScreenMode_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1044690, RefRangeEnd = 1044691, XrefRangeStart = 1044688, XrefRangeEnd = 1044690, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetResolution(int2 resolution)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &resolution;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GraphicsSettingsManager.NativeMethodInfoPtr_SetResolution_Public_Static_Void_int2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1044691, XrefRangeEnd = 1044692, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetResolution(int2 resolution, FullScreenMode fullScreenMode)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &resolution;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &fullScreenMode;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GraphicsSettingsManager.NativeMethodInfoPtr_SetResolution_Public_Static_Void_int2_FullScreenMode_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1044698, RefRangeEnd = 1044702, XrefRangeStart = 1044692, XrefRangeEnd = 1044698, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetResolution(int width, int height, FullScreenMode fullScreenMode)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &width;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &height;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &fullScreenMode;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GraphicsSettingsManager.NativeMethodInfoPtr_SetResolution_Public_Static_Void_Int32_Int32_FullScreenMode_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1044702, XrefRangeEnd = 1044719, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetClothQuality(QualitySetting newQuality, bool respawnHybridModels)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &newQuality;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &respawnHybridModels;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GraphicsSettingsManager.NativeMethodInfoPtr_SetClothQuality_Private_Static_Void_QualitySetting_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1044719, XrefRangeEnd = 1044724, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetClothUpdateRate(ClothUpdateSpeed clothUpdateRate)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &clothUpdateRate;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GraphicsSettingsManager.NativeMethodInfoPtr_SetClothUpdateRate_Private_Static_Void_ClothUpdateSpeed_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1044724, XrefRangeEnd = 1044725, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float GetDynamicResolutionScale()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GraphicsSettingsManager.NativeMethodInfoPtr_GetDynamicResolutionScale_Private_Static_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1044737, RefRangeEnd = 1044741, XrefRangeStart = 1044725, XrefRangeEnd = 1044737, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool _TryGetVolumeProfile(out VolumeProfile volumeProfile)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr3 = &zero;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GraphicsSettingsManager.NativeMethodInfoPtr__TryGetVolumeProfile_Private_Static_Boolean_byref_VolumeProfile_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref VolumeProfile local = ref volumeProfile;
      System.IntPtr pointer = zero;
      VolumeProfile volumeProfile1 = pointer == System.IntPtr.Zero ? (VolumeProfile) null : new VolumeProfile(pointer);
      local = volumeProfile1;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1044741, XrefRangeEnd = 1044754, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetAntiAliasingMode(AntiAliasingMode newMode)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &newMode;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GraphicsSettingsManager.NativeMethodInfoPtr_SetAntiAliasingMode_Public_Static_Void_AntiAliasingMode_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1044754, XrefRangeEnd = 1044761, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetAmbientOcclusionQuality(QualitySetting newQuality)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &newQuality;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GraphicsSettingsManager.NativeMethodInfoPtr_SetAmbientOcclusionQuality_Public_Static_Void_QualitySetting_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1044761, XrefRangeEnd = 1044768, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetShadowQuality(QualitySetting newQuality)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &newQuality;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GraphicsSettingsManager.NativeMethodInfoPtr_SetShadowQuality_Public_Static_Void_QualitySetting_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1044768, XrefRangeEnd = 1044782, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetVolumetricFogQuality(QualitySetting newQuality)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &newQuality;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GraphicsSettingsManager.NativeMethodInfoPtr_SetVolumetricFogQuality_Public_Static_Void_QualitySetting_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1044782, XrefRangeEnd = 1044783, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool GetVolumetricsState()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GraphicsSettingsManager.NativeMethodInfoPtr_GetVolumetricsState_Public_Static_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1044783, XrefRangeEnd = 1044790, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetBloomQuality(QualitySetting newQuality)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &newQuality;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GraphicsSettingsManager.NativeMethodInfoPtr_SetBloomQuality_Public_Static_Void_QualitySetting_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1044790, XrefRangeEnd = 1044791, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetVerticalSync(bool newValue)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &newValue;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GraphicsSettingsManager.NativeMethodInfoPtr_SetVerticalSync_Public_Static_Void_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1044791, XrefRangeEnd = 1044795, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetMotionBlur(bool newValue)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &newValue;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GraphicsSettingsManager.NativeMethodInfoPtr_SetMotionBlur_Public_Static_Void_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1044795, XrefRangeEnd = 1044799, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetDepthOfField(bool newValue)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &newValue;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GraphicsSettingsManager.NativeMethodInfoPtr_SetDepthOfField_Public_Static_Void_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1044829, RefRangeEnd = 1044830, XrefRangeStart = 1044799, XrefRangeEnd = 1044829, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TryApplyGraphicsSettingsToCamera(
      ref Camera camera,
      ref Volume volume,
      GraphicsSettings settings)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr ptr1 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) camera);
      System.IntPtr* numPtr3 = &ptr1;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr num = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr ptr2 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) volume);
      System.IntPtr* numPtr4 = &ptr2;
      *(System.IntPtr*) num = (System.IntPtr) numPtr4;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) settings);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GraphicsSettingsManager.NativeMethodInfoPtr_TryApplyGraphicsSettingsToCamera_Public_Static_Void_byref_Camera_byref_Volume_GraphicsSettings_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Camera local1 = ref camera;
      System.IntPtr pointer1 = ptr1;
      Camera camera1 = pointer1 == System.IntPtr.Zero ? (Camera) null : new Camera(pointer1);
      local1 = camera1;
      ref Volume local2 = ref volume;
      System.IntPtr pointer2 = ptr2;
      Volume volume1 = pointer2 == System.IntPtr.Zero ? (Volume) null : new Volume(pointer2);
      local2 = volume1;
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1044830, XrefRangeEnd = 1044841, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetAntiAliasingModeForCamera(
      ref Camera camera,
      AntiAliasingMode newMode)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) camera);
      System.IntPtr* numPtr3 = &ptr;
      *numPtr2 = (System.IntPtr) numPtr3;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &newMode;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GraphicsSettingsManager.NativeMethodInfoPtr_SetAntiAliasingModeForCamera_Private_Static_Void_byref_Camera_AntiAliasingMode_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Camera local = ref camera;
      System.IntPtr pointer = ptr;
      Camera camera1 = pointer == System.IntPtr.Zero ? (Camera) null : new Camera(pointer);
      local = camera1;
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1044841, XrefRangeEnd = 1044848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetAmbientOcclusionQuality(
      ref Volume volume,
      QualitySetting newQuality)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) volume);
      System.IntPtr* numPtr3 = &ptr;
      *numPtr2 = (System.IntPtr) numPtr3;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &newQuality;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GraphicsSettingsManager.NativeMethodInfoPtr_SetAmbientOcclusionQuality_Public_Static_Void_byref_Volume_QualitySetting_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Volume local = ref volume;
      System.IntPtr pointer = ptr;
      Volume volume1 = pointer == System.IntPtr.Zero ? (Volume) null : new Volume(pointer);
      local = volume1;
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1044848, XrefRangeEnd = 1044855, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetBloomQuality(ref Volume volume, QualitySetting newQuality)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) volume);
      System.IntPtr* numPtr3 = &ptr;
      *numPtr2 = (System.IntPtr) numPtr3;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &newQuality;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GraphicsSettingsManager.NativeMethodInfoPtr_SetBloomQuality_Public_Static_Void_byref_Volume_QualitySetting_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Volume local = ref volume;
      System.IntPtr pointer = ptr;
      Volume volume1 = pointer == System.IntPtr.Zero ? (Volume) null : new Volume(pointer);
      local = volume1;
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1044856, RefRangeEnd = 1044858, XrefRangeStart = 1044855, XrefRangeEnd = 1044856, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool ActiveTAA()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GraphicsSettingsManager.NativeMethodInfoPtr_ActiveTAA_Public_Static_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe float GetDynResForQualityMode(FSRQualityMode mode)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &mode;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GraphicsSettingsManager.NativeMethodInfoPtr_GetDynResForQualityMode_Private_Static_Single_FSRQualityMode_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1044868, RefRangeEnd = 1044870, XrefRangeStart = 1044858, XrefRangeEnd = 1044868, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TurnOffFSR(float sharpness)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &sharpness;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GraphicsSettingsManager.NativeMethodInfoPtr_TurnOffFSR_Public_Static_Void_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1044870, XrefRangeEnd = 1044883, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TurnOnFSR(FSRQualityMode mode, float sharpness)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &mode;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &sharpness;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GraphicsSettingsManager.NativeMethodInfoPtr_TurnOnFSR_Private_Static_Void_FSRQualityMode_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1044898, RefRangeEnd = 1044901, XrefRangeStart = 1044883, XrefRangeEnd = 1044898, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetFSRQuality(FSRQualityMode mode)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &mode;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GraphicsSettingsManager.NativeMethodInfoPtr_SetFSRQuality_Public_Static_Void_FSRQualityMode_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static GraphicsSettingsManager()
    {
      Il2CppClassPointerStore<GraphicsSettingsManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (GraphicsSettingsManager));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraphicsSettingsManager>.NativeClassPtr);
      GraphicsSettingsManager.NativeFieldInfoPtr__PostProcessVolumeProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicsSettingsManager>.NativeClassPtr, nameof (_PostProcessVolumeProfile));
      GraphicsSettingsManager.NativeMethodInfoPtr_InitializeGlobalSettings_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettingsManager>.NativeClassPtr, 100681837);
      GraphicsSettingsManager.NativeMethodInfoPtr_InitializeGameSettings_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettingsManager>.NativeClassPtr, 100681838);
      GraphicsSettingsManager.NativeMethodInfoPtr_TryApplyGameSettings_Public_Static_Void_GraphicsSettings_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettingsManager>.NativeClassPtr, 100681839);
      GraphicsSettingsManager.NativeMethodInfoPtr_SetTextureQuality_Public_Static_Void_QualitySetting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettingsManager>.NativeClassPtr, 100681840);
      GraphicsSettingsManager.NativeMethodInfoPtr_SetTextureMipStreaming_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettingsManager>.NativeClassPtr, 100681841);
      GraphicsSettingsManager.NativeMethodInfoPtr_SetBrightness_Private_Static_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettingsManager>.NativeClassPtr, 100681842);
      GraphicsSettingsManager.NativeMethodInfoPtr_SetFluffDensity_Private_Static_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettingsManager>.NativeClassPtr, 100681843);
      GraphicsSettingsManager.NativeMethodInfoPtr_SetHighQualityVegetation_Private_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettingsManager>.NativeClassPtr, 100681844);
      GraphicsSettingsManager.NativeMethodInfoPtr_SetHighQualityAtmosphere_Private_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettingsManager>.NativeClassPtr, 100681845);
      GraphicsSettingsManager.NativeMethodInfoPtr_SetFullscreenMode_Public_Static_Void_FullScreenMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettingsManager>.NativeClassPtr, 100681846);
      GraphicsSettingsManager.NativeMethodInfoPtr_SetResolution_Public_Static_Void_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettingsManager>.NativeClassPtr, 100681847);
      GraphicsSettingsManager.NativeMethodInfoPtr_SetResolution_Public_Static_Void_int2_FullScreenMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettingsManager>.NativeClassPtr, 100681848);
      GraphicsSettingsManager.NativeMethodInfoPtr_SetResolution_Public_Static_Void_Int32_Int32_FullScreenMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettingsManager>.NativeClassPtr, 100681849);
      GraphicsSettingsManager.NativeMethodInfoPtr_SetClothQuality_Private_Static_Void_QualitySetting_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettingsManager>.NativeClassPtr, 100681850);
      GraphicsSettingsManager.NativeMethodInfoPtr_SetClothUpdateRate_Private_Static_Void_ClothUpdateSpeed_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettingsManager>.NativeClassPtr, 100681851);
      GraphicsSettingsManager.NativeMethodInfoPtr_GetDynamicResolutionScale_Private_Static_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettingsManager>.NativeClassPtr, 100681852);
      GraphicsSettingsManager.NativeMethodInfoPtr__TryGetVolumeProfile_Private_Static_Boolean_byref_VolumeProfile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettingsManager>.NativeClassPtr, 100681853);
      GraphicsSettingsManager.NativeMethodInfoPtr_SetAntiAliasingMode_Public_Static_Void_AntiAliasingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettingsManager>.NativeClassPtr, 100681854);
      GraphicsSettingsManager.NativeMethodInfoPtr_SetAmbientOcclusionQuality_Public_Static_Void_QualitySetting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettingsManager>.NativeClassPtr, 100681855);
      GraphicsSettingsManager.NativeMethodInfoPtr_SetShadowQuality_Public_Static_Void_QualitySetting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettingsManager>.NativeClassPtr, 100681856);
      GraphicsSettingsManager.NativeMethodInfoPtr_SetVolumetricFogQuality_Public_Static_Void_QualitySetting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettingsManager>.NativeClassPtr, 100681857);
      GraphicsSettingsManager.NativeMethodInfoPtr_GetVolumetricsState_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettingsManager>.NativeClassPtr, 100681858);
      GraphicsSettingsManager.NativeMethodInfoPtr_SetBloomQuality_Public_Static_Void_QualitySetting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettingsManager>.NativeClassPtr, 100681859);
      GraphicsSettingsManager.NativeMethodInfoPtr_SetVerticalSync_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettingsManager>.NativeClassPtr, 100681860);
      GraphicsSettingsManager.NativeMethodInfoPtr_SetMotionBlur_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettingsManager>.NativeClassPtr, 100681861);
      GraphicsSettingsManager.NativeMethodInfoPtr_SetDepthOfField_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettingsManager>.NativeClassPtr, 100681862);
      GraphicsSettingsManager.NativeMethodInfoPtr_TryApplyGraphicsSettingsToCamera_Public_Static_Void_byref_Camera_byref_Volume_GraphicsSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettingsManager>.NativeClassPtr, 100681863);
      GraphicsSettingsManager.NativeMethodInfoPtr_SetAntiAliasingModeForCamera_Private_Static_Void_byref_Camera_AntiAliasingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettingsManager>.NativeClassPtr, 100681864);
      GraphicsSettingsManager.NativeMethodInfoPtr_SetAmbientOcclusionQuality_Public_Static_Void_byref_Volume_QualitySetting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettingsManager>.NativeClassPtr, 100681865);
      GraphicsSettingsManager.NativeMethodInfoPtr_SetBloomQuality_Public_Static_Void_byref_Volume_QualitySetting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettingsManager>.NativeClassPtr, 100681866);
      GraphicsSettingsManager.NativeMethodInfoPtr_ActiveTAA_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettingsManager>.NativeClassPtr, 100681867);
      GraphicsSettingsManager.NativeMethodInfoPtr_GetDynResForQualityMode_Private_Static_Single_FSRQualityMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettingsManager>.NativeClassPtr, 100681868);
      GraphicsSettingsManager.NativeMethodInfoPtr_TurnOffFSR_Public_Static_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettingsManager>.NativeClassPtr, 100681869);
      GraphicsSettingsManager.NativeMethodInfoPtr_TurnOnFSR_Private_Static_Void_FSRQualityMode_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettingsManager>.NativeClassPtr, 100681870);
      GraphicsSettingsManager.NativeMethodInfoPtr_SetFSRQuality_Public_Static_Void_FSRQualityMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettingsManager>.NativeClassPtr, 100681871);
    }

    public GraphicsSettingsManager(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe VolumeProfile _PostProcessVolumeProfile
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(GraphicsSettingsManager.NativeFieldInfoPtr__PostProcessVolumeProfile, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (VolumeProfile) null : new VolumeProfile(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GraphicsSettingsManager.NativeFieldInfoPtr__PostProcessVolumeProfile, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
