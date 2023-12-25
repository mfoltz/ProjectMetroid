// Decompiled with JetBrains decompiler
// Type: ProjectM.TreeSettings
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
  public class TreeSettings : ScriptableObject
  {
    private static readonly IntPtr NativeFieldInfoPtr_RetryAutoTransitionCooldown;
    private static readonly IntPtr NativeFieldInfoPtr_HiddenToSaplingDuration;
    private static readonly IntPtr NativeFieldInfoPtr_SaplingGrowDuration;
    private static readonly IntPtr NativeFieldInfoPtr_TreeGrowDuration;
    private static readonly IntPtr NativeFieldInfoPtr_StumpRemovalDuration;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072071, XrefRangeEnd = 1072072, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TreeSettings()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TreeSettings>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TreeSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TreeSettings()
    {
      Il2CppClassPointerStore<TreeSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (TreeSettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TreeSettings>.NativeClassPtr);
      TreeSettings.NativeFieldInfoPtr_RetryAutoTransitionCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreeSettings>.NativeClassPtr, nameof (RetryAutoTransitionCooldown));
      TreeSettings.NativeFieldInfoPtr_HiddenToSaplingDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreeSettings>.NativeClassPtr, nameof (HiddenToSaplingDuration));
      TreeSettings.NativeFieldInfoPtr_SaplingGrowDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreeSettings>.NativeClassPtr, nameof (SaplingGrowDuration));
      TreeSettings.NativeFieldInfoPtr_TreeGrowDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreeSettings>.NativeClassPtr, nameof (TreeGrowDuration));
      TreeSettings.NativeFieldInfoPtr_StumpRemovalDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreeSettings>.NativeClassPtr, nameof (StumpRemovalDuration));
      TreeSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeSettings>.NativeClassPtr, 100684462);
    }

    public TreeSettings(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float RetryAutoTransitionCooldown
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TreeSettings.NativeFieldInfoPtr_RetryAutoTransitionCooldown));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TreeSettings.NativeFieldInfoPtr_RetryAutoTransitionCooldown)) = value;
      }
    }

    public unsafe float HiddenToSaplingDuration
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TreeSettings.NativeFieldInfoPtr_HiddenToSaplingDuration));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TreeSettings.NativeFieldInfoPtr_HiddenToSaplingDuration)) = value;
      }
    }

    public unsafe float SaplingGrowDuration
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TreeSettings.NativeFieldInfoPtr_SaplingGrowDuration));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TreeSettings.NativeFieldInfoPtr_SaplingGrowDuration)) = value;
      }
    }

    public unsafe float TreeGrowDuration
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TreeSettings.NativeFieldInfoPtr_TreeGrowDuration));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TreeSettings.NativeFieldInfoPtr_TreeGrowDuration)) = value;
      }
    }

    public unsafe float StumpRemovalDuration
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TreeSettings.NativeFieldInfoPtr_StumpRemovalDuration));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TreeSettings.NativeFieldInfoPtr_StumpRemovalDuration)) = value;
      }
    }
  }
}
