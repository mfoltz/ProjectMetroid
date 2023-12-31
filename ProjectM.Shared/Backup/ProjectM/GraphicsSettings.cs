// Decompiled with JetBrains decompiler
// Type: ProjectM.GraphicsSettings
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  public class GraphicsSettings : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Resolution;
    private static readonly System.IntPtr NativeFieldInfoPtr_FPSLimitValue;
    private static readonly System.IntPtr NativeFieldInfoPtr_DynamicResolutionQuality;
    private static readonly System.IntPtr NativeFieldInfoPtr_ScreenShakeAmplitude;
    private static readonly System.IntPtr NativeFieldInfoPtr_Brightness;
    private static readonly System.IntPtr NativeFieldInfoPtr_FsrSharpness;
    private static readonly System.IntPtr NativeFieldInfoPtr_FsrQualityMode;
    private static readonly System.IntPtr NativeFieldInfoPtr_ClothUpdateRate;
    private static readonly System.IntPtr NativeFieldInfoPtr_ClothQuality;
    private static readonly System.IntPtr NativeFieldInfoPtr_AntiAliasing;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShadowQuality;
    private static readonly System.IntPtr NativeFieldInfoPtr_AmbientOcclusionQuality;
    private static readonly System.IntPtr NativeFieldInfoPtr_BloomQuality;
    private static readonly System.IntPtr NativeFieldInfoPtr_VolumetricsQuality;
    private static readonly System.IntPtr NativeFieldInfoPtr_TextureQuality;
    private static readonly System.IntPtr NativeFieldInfoPtr_TextureMipStreaming;
    private static readonly System.IntPtr NativeFieldInfoPtr_WindowMode;
    private static readonly System.IntPtr NativeFieldInfoPtr_CurrentPresetMode;
    private static readonly System.IntPtr NativeFieldInfoPtr_GameFPSCapMode;
    private static readonly System.IntPtr NativeFieldInfoPtr_MenuFPSCapMode;
    private static readonly System.IntPtr NativeFieldInfoPtr_MotionBlur;
    private static readonly System.IntPtr NativeFieldInfoPtr_DepthOfField;
    private static readonly System.IntPtr NativeFieldInfoPtr_HighQualityVegetation;
    private static readonly System.IntPtr NativeFieldInfoPtr_FluffDensity;
    private static readonly System.IntPtr NativeFieldInfoPtr_HighQualityAtmosphere;
    private static readonly System.IntPtr NativeFieldInfoPtr_BloodEffectsEnabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_PreWarmShaders;
    private static readonly System.IntPtr NativeFieldInfoPtr_UseHybridModelStreaming;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetFPSLimit_Public_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetFPSLimit_Private_Int32_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_GraphicsSettings_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 748966, RefRangeEnd = 748968, XrefRangeStart = 748960, XrefRangeEnd = 748966, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetFPSLimit(bool inGame)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &inGame;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GraphicsSettings.NativeMethodInfoPtr_SetFPSLimit_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe int GetFPSLimit(bool inGame)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &inGame;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GraphicsSettings.NativeMethodInfoPtr_GetFPSLimit_Private_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 748972, RefRangeEnd = 748976, XrefRangeStart = 748968, XrefRangeEnd = 748972, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(GraphicsSettings other)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GraphicsSettings.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_GraphicsSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 748976, XrefRangeEnd = 748985, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe bool Equals(Il2CppSystem.Object obj)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GraphicsSettings.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 748985, XrefRangeEnd = 749008, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe int GetHashCode()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GraphicsSettings.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 749009, RefRangeEnd = 749010, XrefRangeStart = 749008, XrefRangeEnd = 749009, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe GraphicsSettings()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GraphicsSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static GraphicsSettings()
    {
      Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (GraphicsSettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr);
      GraphicsSettings.NativeFieldInfoPtr_Resolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, nameof (Resolution));
      GraphicsSettings.NativeFieldInfoPtr_FPSLimitValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, nameof (FPSLimitValue));
      GraphicsSettings.NativeFieldInfoPtr_DynamicResolutionQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, nameof (DynamicResolutionQuality));
      GraphicsSettings.NativeFieldInfoPtr_ScreenShakeAmplitude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, nameof (ScreenShakeAmplitude));
      GraphicsSettings.NativeFieldInfoPtr_Brightness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, nameof (Brightness));
      GraphicsSettings.NativeFieldInfoPtr_FsrSharpness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, nameof (FsrSharpness));
      GraphicsSettings.NativeFieldInfoPtr_FsrQualityMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, nameof (FsrQualityMode));
      GraphicsSettings.NativeFieldInfoPtr_ClothUpdateRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, nameof (ClothUpdateRate));
      GraphicsSettings.NativeFieldInfoPtr_ClothQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, nameof (ClothQuality));
      GraphicsSettings.NativeFieldInfoPtr_AntiAliasing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, nameof (AntiAliasing));
      GraphicsSettings.NativeFieldInfoPtr_ShadowQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, nameof (ShadowQuality));
      GraphicsSettings.NativeFieldInfoPtr_AmbientOcclusionQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, nameof (AmbientOcclusionQuality));
      GraphicsSettings.NativeFieldInfoPtr_BloomQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, nameof (BloomQuality));
      GraphicsSettings.NativeFieldInfoPtr_VolumetricsQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, nameof (VolumetricsQuality));
      GraphicsSettings.NativeFieldInfoPtr_TextureQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, nameof (TextureQuality));
      GraphicsSettings.NativeFieldInfoPtr_TextureMipStreaming = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, nameof (TextureMipStreaming));
      GraphicsSettings.NativeFieldInfoPtr_WindowMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, nameof (WindowMode));
      GraphicsSettings.NativeFieldInfoPtr_CurrentPresetMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, nameof (CurrentPresetMode));
      GraphicsSettings.NativeFieldInfoPtr_GameFPSCapMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, nameof (GameFPSCapMode));
      GraphicsSettings.NativeFieldInfoPtr_MenuFPSCapMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, nameof (MenuFPSCapMode));
      GraphicsSettings.NativeFieldInfoPtr_MotionBlur = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, nameof (MotionBlur));
      GraphicsSettings.NativeFieldInfoPtr_DepthOfField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, nameof (DepthOfField));
      GraphicsSettings.NativeFieldInfoPtr_HighQualityVegetation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, nameof (HighQualityVegetation));
      GraphicsSettings.NativeFieldInfoPtr_FluffDensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, nameof (FluffDensity));
      GraphicsSettings.NativeFieldInfoPtr_HighQualityAtmosphere = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, nameof (HighQualityAtmosphere));
      GraphicsSettings.NativeFieldInfoPtr_BloodEffectsEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, nameof (BloodEffectsEnabled));
      GraphicsSettings.NativeFieldInfoPtr_PreWarmShaders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, nameof (PreWarmShaders));
      GraphicsSettings.NativeFieldInfoPtr_UseHybridModelStreaming = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, nameof (UseHybridModelStreaming));
      GraphicsSettings.NativeMethodInfoPtr_SetFPSLimit_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100665948);
      GraphicsSettings.NativeMethodInfoPtr_GetFPSLimit_Private_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100665949);
      GraphicsSettings.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_GraphicsSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100665950);
      GraphicsSettings.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100665951);
      GraphicsSettings.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100665952);
      GraphicsSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100665953);
    }

    public GraphicsSettings(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int2 Resolution
    {
      get
      {
        return *(int2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_Resolution));
      }
      [param: In] set
      {
        *(int2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_Resolution)) = value;
      }
    }

    public unsafe int FPSLimitValue
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_FPSLimitValue));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_FPSLimitValue)) = value;
      }
    }

    public unsafe float DynamicResolutionQuality
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_DynamicResolutionQuality));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_DynamicResolutionQuality)) = value;
      }
    }

    public unsafe float ScreenShakeAmplitude
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_ScreenShakeAmplitude));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_ScreenShakeAmplitude)) = value;
      }
    }

    public unsafe float Brightness
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_Brightness));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_Brightness)) = value;
      }
    }

    public unsafe float FsrSharpness
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_FsrSharpness));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_FsrSharpness)) = value;
      }
    }

    public unsafe byte FsrQualityMode
    {
      get
      {
        return *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_FsrQualityMode));
      }
      [param: In] set
      {
        *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_FsrQualityMode)) = value;
      }
    }

    public unsafe byte ClothUpdateRate
    {
      get
      {
        return *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_ClothUpdateRate));
      }
      [param: In] set
      {
        *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_ClothUpdateRate)) = value;
      }
    }

    public unsafe byte ClothQuality
    {
      get
      {
        return *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_ClothQuality));
      }
      [param: In] set
      {
        *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_ClothQuality)) = value;
      }
    }

    public unsafe byte AntiAliasing
    {
      get
      {
        return *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_AntiAliasing));
      }
      [param: In] set
      {
        *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_AntiAliasing)) = value;
      }
    }

    public unsafe byte ShadowQuality
    {
      get
      {
        return *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_ShadowQuality));
      }
      [param: In] set
      {
        *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_ShadowQuality)) = value;
      }
    }

    public unsafe byte AmbientOcclusionQuality
    {
      get
      {
        return *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_AmbientOcclusionQuality));
      }
      [param: In] set
      {
        *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_AmbientOcclusionQuality)) = value;
      }
    }

    public unsafe byte BloomQuality
    {
      get
      {
        return *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_BloomQuality));
      }
      [param: In] set
      {
        *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_BloomQuality)) = value;
      }
    }

    public unsafe byte VolumetricsQuality
    {
      get
      {
        return *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_VolumetricsQuality));
      }
      [param: In] set
      {
        *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_VolumetricsQuality)) = value;
      }
    }

    public unsafe byte TextureQuality
    {
      get
      {
        return *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_TextureQuality));
      }
      [param: In] set
      {
        *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_TextureQuality)) = value;
      }
    }

    public unsafe bool TextureMipStreaming
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_TextureMipStreaming));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_TextureMipStreaming)) = value;
      }
    }

    public unsafe byte WindowMode
    {
      get
      {
        return *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_WindowMode));
      }
      [param: In] set
      {
        *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_WindowMode)) = value;
      }
    }

    public unsafe byte CurrentPresetMode
    {
      get
      {
        return *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_CurrentPresetMode));
      }
      [param: In] set
      {
        *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_CurrentPresetMode)) = value;
      }
    }

    public unsafe byte GameFPSCapMode
    {
      get
      {
        return *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_GameFPSCapMode));
      }
      [param: In] set
      {
        *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_GameFPSCapMode)) = value;
      }
    }

    public unsafe byte MenuFPSCapMode
    {
      get
      {
        return *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_MenuFPSCapMode));
      }
      [param: In] set
      {
        *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_MenuFPSCapMode)) = value;
      }
    }

    public unsafe bool MotionBlur
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_MotionBlur));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_MotionBlur)) = value;
      }
    }

    public unsafe bool DepthOfField
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_DepthOfField));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_DepthOfField)) = value;
      }
    }

    public unsafe bool HighQualityVegetation
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_HighQualityVegetation));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_HighQualityVegetation)) = value;
      }
    }

    public unsafe float FluffDensity
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_FluffDensity));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_FluffDensity)) = value;
      }
    }

    public unsafe bool HighQualityAtmosphere
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_HighQualityAtmosphere));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_HighQualityAtmosphere)) = value;
      }
    }

    public unsafe bool BloodEffectsEnabled
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_BloodEffectsEnabled));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_BloodEffectsEnabled)) = value;
      }
    }

    public unsafe bool PreWarmShaders
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_PreWarmShaders));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_PreWarmShaders)) = value;
      }
    }

    public unsafe bool UseHybridModelStreaming
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_UseHybridModelStreaming));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_UseHybridModelStreaming)) = value;
      }
    }
  }
}
