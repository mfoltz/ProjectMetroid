// Decompiled with JetBrains decompiler
// Type: ProjectM.StoneSettings
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  [Serializable]
  public class StoneSettings : ScriptableObject
  {
    private static readonly IntPtr NativeFieldInfoPtr_RetryAutoTransitionCooldown;
    private static readonly IntPtr NativeFieldInfoPtr_HiddenToSmallStoneDuration;
    private static readonly IntPtr NativeFieldInfoPtr_StoneGrowDuration;
    private static readonly IntPtr NativeFieldInfoPtr_DestroyedRubbleRemovalDuration;
    private static readonly IntPtr NativeFieldInfoPtr_TimeoutDuration;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072070, XrefRangeEnd = 1072071, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe StoneSettings()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StoneSettings>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StoneSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static StoneSettings()
    {
      Il2CppClassPointerStore<StoneSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (StoneSettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StoneSettings>.NativeClassPtr);
      StoneSettings.NativeFieldInfoPtr_RetryAutoTransitionCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoneSettings>.NativeClassPtr, nameof (RetryAutoTransitionCooldown));
      StoneSettings.NativeFieldInfoPtr_HiddenToSmallStoneDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoneSettings>.NativeClassPtr, nameof (HiddenToSmallStoneDuration));
      StoneSettings.NativeFieldInfoPtr_StoneGrowDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoneSettings>.NativeClassPtr, nameof (StoneGrowDuration));
      StoneSettings.NativeFieldInfoPtr_DestroyedRubbleRemovalDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoneSettings>.NativeClassPtr, nameof (DestroyedRubbleRemovalDuration));
      StoneSettings.NativeFieldInfoPtr_TimeoutDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoneSettings>.NativeClassPtr, nameof (TimeoutDuration));
      StoneSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoneSettings>.NativeClassPtr, 100684461);
    }

    public StoneSettings(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float RetryAutoTransitionCooldown
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StoneSettings.NativeFieldInfoPtr_RetryAutoTransitionCooldown));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StoneSettings.NativeFieldInfoPtr_RetryAutoTransitionCooldown)) = value;
      }
    }

    public unsafe float HiddenToSmallStoneDuration
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StoneSettings.NativeFieldInfoPtr_HiddenToSmallStoneDuration));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StoneSettings.NativeFieldInfoPtr_HiddenToSmallStoneDuration)) = value;
      }
    }

    public unsafe float StoneGrowDuration
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StoneSettings.NativeFieldInfoPtr_StoneGrowDuration));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StoneSettings.NativeFieldInfoPtr_StoneGrowDuration)) = value;
      }
    }

    public unsafe float DestroyedRubbleRemovalDuration
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StoneSettings.NativeFieldInfoPtr_DestroyedRubbleRemovalDuration));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StoneSettings.NativeFieldInfoPtr_DestroyedRubbleRemovalDuration)) = value;
      }
    }

    public unsafe float TimeoutDuration
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StoneSettings.NativeFieldInfoPtr_TimeoutDuration));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StoneSettings.NativeFieldInfoPtr_TimeoutDuration)) = value;
      }
    }
  }
}
