// Decompiled with JetBrains decompiler
// Type: RagdollSettings
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
public class RagdollSettings : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_RootJoint;
  private static readonly IntPtr NativeMethodInfoPtr_GetCurrentMass_Public_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 921655, XrefRangeEnd = 921661, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float GetCurrentMass()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(RagdollSettings.NativeMethodInfoPtr_GetCurrentMass_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(520)]
  [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RagdollSettings()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RagdollSettings>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(RagdollSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static RagdollSettings()
  {
    Il2CppClassPointerStore<RagdollSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "", nameof (RagdollSettings));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RagdollSettings>.NativeClassPtr);
    RagdollSettings.NativeFieldInfoPtr_RootJoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollSettings>.NativeClassPtr, nameof (RootJoint));
    RagdollSettings.NativeMethodInfoPtr_GetCurrentMass_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollSettings>.NativeClassPtr, 100663697);
    RagdollSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollSettings>.NativeClassPtr, 100663698);
  }

  public RagdollSettings(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Transform RootJoint
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RagdollSettings.NativeFieldInfoPtr_RootJoint));
      return pointer == IntPtr.Zero ? (Transform) null : new Transform(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RagdollSettings.NativeFieldInfoPtr_RootJoint), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
