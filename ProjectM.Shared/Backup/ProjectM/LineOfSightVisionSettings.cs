// Decompiled with JetBrains decompiler
// Type: ProjectM.LineOfSightVisionSettings
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class LineOfSightVisionSettings : ScriptableObject
  {
    private static readonly IntPtr NativeFieldInfoPtr_SETTING_PATH;
    private static readonly IntPtr NativeFieldInfoPtr_EYE_HEIGHT;
    private static readonly IntPtr NativeFieldInfoPtr_NORMAL_BLOCKER_HEIGHT;
    private static readonly IntPtr NativeFieldInfoPtr_DepthTestFix;
    private static readonly IntPtr NativeFieldInfoPtr_HistoryFadeSpeed;
    private static readonly IntPtr NativeFieldInfoPtr_SeeNewVisionSpeed;
    private static readonly IntPtr NativeFieldInfoPtr_CharacterFadeSpeed;
    private static readonly IntPtr NativeFieldInfoPtr_Texture;
    private static readonly IntPtr NativeFieldInfoPtr_PointSamplingRawTexture;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 749152, XrefRangeEnd = 749153, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe LineOfSightVisionSettings()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LineOfSightVisionSettings>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LineOfSightVisionSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static LineOfSightVisionSettings()
    {
      Il2CppClassPointerStore<LineOfSightVisionSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (LineOfSightVisionSettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LineOfSightVisionSettings>.NativeClassPtr);
      LineOfSightVisionSettings.NativeFieldInfoPtr_SETTING_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineOfSightVisionSettings>.NativeClassPtr, nameof (SETTING_PATH));
      LineOfSightVisionSettings.NativeFieldInfoPtr_EYE_HEIGHT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineOfSightVisionSettings>.NativeClassPtr, nameof (EYE_HEIGHT));
      LineOfSightVisionSettings.NativeFieldInfoPtr_NORMAL_BLOCKER_HEIGHT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineOfSightVisionSettings>.NativeClassPtr, nameof (NORMAL_BLOCKER_HEIGHT));
      LineOfSightVisionSettings.NativeFieldInfoPtr_DepthTestFix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineOfSightVisionSettings>.NativeClassPtr, nameof (DepthTestFix));
      LineOfSightVisionSettings.NativeFieldInfoPtr_HistoryFadeSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineOfSightVisionSettings>.NativeClassPtr, nameof (HistoryFadeSpeed));
      LineOfSightVisionSettings.NativeFieldInfoPtr_SeeNewVisionSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineOfSightVisionSettings>.NativeClassPtr, nameof (SeeNewVisionSpeed));
      LineOfSightVisionSettings.NativeFieldInfoPtr_CharacterFadeSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineOfSightVisionSettings>.NativeClassPtr, nameof (CharacterFadeSpeed));
      LineOfSightVisionSettings.NativeFieldInfoPtr_Texture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineOfSightVisionSettings>.NativeClassPtr, nameof (Texture));
      LineOfSightVisionSettings.NativeFieldInfoPtr_PointSamplingRawTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineOfSightVisionSettings>.NativeClassPtr, nameof (PointSamplingRawTexture));
      LineOfSightVisionSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineOfSightVisionSettings>.NativeClassPtr, 100665968);
    }

    public LineOfSightVisionSettings(IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe string SETTING_PATH
    {
      get
      {
        IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(LineOfSightVisionSettings.NativeFieldInfoPtr_SETTING_PATH, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LineOfSightVisionSettings.NativeFieldInfoPtr_SETTING_PATH, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe float EYE_HEIGHT
    {
      get
      {
        float eyeHeight;
        IL2CPP.il2cpp_field_static_get_value(LineOfSightVisionSettings.NativeFieldInfoPtr_EYE_HEIGHT, (void*) &eyeHeight);
        return eyeHeight;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LineOfSightVisionSettings.NativeFieldInfoPtr_EYE_HEIGHT, (void*) &value);
      }
    }

    public static unsafe float NORMAL_BLOCKER_HEIGHT
    {
      get
      {
        float normalBlockerHeight;
        IL2CPP.il2cpp_field_static_get_value(LineOfSightVisionSettings.NativeFieldInfoPtr_NORMAL_BLOCKER_HEIGHT, (void*) &normalBlockerHeight);
        return normalBlockerHeight;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LineOfSightVisionSettings.NativeFieldInfoPtr_NORMAL_BLOCKER_HEIGHT, (void*) &value);
      }
    }

    public unsafe bool DepthTestFix
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LineOfSightVisionSettings.NativeFieldInfoPtr_DepthTestFix));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LineOfSightVisionSettings.NativeFieldInfoPtr_DepthTestFix)) = value;
      }
    }

    public unsafe float HistoryFadeSpeed
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LineOfSightVisionSettings.NativeFieldInfoPtr_HistoryFadeSpeed));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LineOfSightVisionSettings.NativeFieldInfoPtr_HistoryFadeSpeed)) = value;
      }
    }

    public unsafe float SeeNewVisionSpeed
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LineOfSightVisionSettings.NativeFieldInfoPtr_SeeNewVisionSpeed));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LineOfSightVisionSettings.NativeFieldInfoPtr_SeeNewVisionSpeed)) = value;
      }
    }

    public unsafe float CharacterFadeSpeed
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LineOfSightVisionSettings.NativeFieldInfoPtr_CharacterFadeSpeed));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LineOfSightVisionSettings.NativeFieldInfoPtr_CharacterFadeSpeed)) = value;
      }
    }

    public unsafe LineOfSightVisionSettings.LineOfSightVisionTextureEnum Texture
    {
      get
      {
        return *(LineOfSightVisionSettings.LineOfSightVisionTextureEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LineOfSightVisionSettings.NativeFieldInfoPtr_Texture));
      }
      [param: In] set
      {
        *(LineOfSightVisionSettings.LineOfSightVisionTextureEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LineOfSightVisionSettings.NativeFieldInfoPtr_Texture)) = value;
      }
    }

    public unsafe bool PointSamplingRawTexture
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LineOfSightVisionSettings.NativeFieldInfoPtr_PointSamplingRawTexture));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LineOfSightVisionSettings.NativeFieldInfoPtr_PointSamplingRawTexture)) = value;
      }
    }

    public enum LineOfSightVisionTextureEnum
    {
      Raw,
      Blurred,
      BlurredUpscaled,
    }
  }
}
