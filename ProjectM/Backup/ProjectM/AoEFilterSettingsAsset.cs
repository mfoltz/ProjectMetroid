// Decompiled with JetBrains decompiler
// Type: ProjectM.AoEFilterSettingsAsset
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
  public class AoEFilterSettingsAsset : ScriptableObject
  {
    private static readonly IntPtr NativeFieldInfoPtr_Near_Origin_Factor;
    private static readonly IntPtr NativeFieldInfoPtr_Near_Origin_Distance;
    private static readonly IntPtr NativeFieldInfoPtr_Target_Priority_Factor;
    private static readonly IntPtr NativeFieldInfoPtr_UseMeleeCone;
    private static readonly IntPtr NativeFieldInfoPtr_Melee_Cone_Angle;
    private static readonly IntPtr NativeMethodInfoPtr_ToFilterSettings_Public_AoEFilterSettings_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1067308, RefRangeEnd = 1067309, XrefRangeStart = 1067308, XrefRangeEnd = 1067308, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AoEFilterSettings ToFilterSettings()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(AoEFilterSettingsAsset.NativeMethodInfoPtr_ToFilterSettings_Public_AoEFilterSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(AoEFilterSettings*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067309, XrefRangeEnd = 1067310, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AoEFilterSettingsAsset()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AoEFilterSettingsAsset>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AoEFilterSettingsAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AoEFilterSettingsAsset()
    {
      Il2CppClassPointerStore<AoEFilterSettingsAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (AoEFilterSettingsAsset));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AoEFilterSettingsAsset>.NativeClassPtr);
      AoEFilterSettingsAsset.NativeFieldInfoPtr_Near_Origin_Factor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AoEFilterSettingsAsset>.NativeClassPtr, nameof (Near_Origin_Factor));
      AoEFilterSettingsAsset.NativeFieldInfoPtr_Near_Origin_Distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AoEFilterSettingsAsset>.NativeClassPtr, nameof (Near_Origin_Distance));
      AoEFilterSettingsAsset.NativeFieldInfoPtr_Target_Priority_Factor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AoEFilterSettingsAsset>.NativeClassPtr, nameof (Target_Priority_Factor));
      AoEFilterSettingsAsset.NativeFieldInfoPtr_UseMeleeCone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AoEFilterSettingsAsset>.NativeClassPtr, nameof (UseMeleeCone));
      AoEFilterSettingsAsset.NativeFieldInfoPtr_Melee_Cone_Angle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AoEFilterSettingsAsset>.NativeClassPtr, nameof (Melee_Cone_Angle));
      AoEFilterSettingsAsset.NativeMethodInfoPtr_ToFilterSettings_Public_AoEFilterSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AoEFilterSettingsAsset>.NativeClassPtr, 100683956);
      AoEFilterSettingsAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AoEFilterSettingsAsset>.NativeClassPtr, 100683957);
    }

    public AoEFilterSettingsAsset(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float Near_Origin_Factor
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AoEFilterSettingsAsset.NativeFieldInfoPtr_Near_Origin_Factor));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AoEFilterSettingsAsset.NativeFieldInfoPtr_Near_Origin_Factor)) = value;
      }
    }

    public unsafe float Near_Origin_Distance
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AoEFilterSettingsAsset.NativeFieldInfoPtr_Near_Origin_Distance));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AoEFilterSettingsAsset.NativeFieldInfoPtr_Near_Origin_Distance)) = value;
      }
    }

    public unsafe float Target_Priority_Factor
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AoEFilterSettingsAsset.NativeFieldInfoPtr_Target_Priority_Factor));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AoEFilterSettingsAsset.NativeFieldInfoPtr_Target_Priority_Factor)) = value;
      }
    }

    public unsafe bool UseMeleeCone
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AoEFilterSettingsAsset.NativeFieldInfoPtr_UseMeleeCone));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AoEFilterSettingsAsset.NativeFieldInfoPtr_UseMeleeCone)) = value;
      }
    }

    public unsafe float Melee_Cone_Angle
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AoEFilterSettingsAsset.NativeFieldInfoPtr_Melee_Cone_Angle));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AoEFilterSettingsAsset.NativeFieldInfoPtr_Melee_Cone_Angle)) = value;
      }
    }
  }
}
