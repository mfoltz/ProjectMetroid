// Decompiled with JetBrains decompiler
// Type: ProjectM.OverrideInitialAgeAuthoring
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
  public class OverrideInitialAgeAuthoring : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_Value;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe OverrideInitialAgeAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OverrideInitialAgeAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OverrideInitialAgeAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static OverrideInitialAgeAuthoring()
    {
      Il2CppClassPointerStore<OverrideInitialAgeAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (OverrideInitialAgeAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OverrideInitialAgeAuthoring>.NativeClassPtr);
      OverrideInitialAgeAuthoring.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverrideInitialAgeAuthoring>.NativeClassPtr, nameof (Value));
      OverrideInitialAgeAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverrideInitialAgeAuthoring>.NativeClassPtr, 100664263);
    }

    public OverrideInitialAgeAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float Value
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OverrideInitialAgeAuthoring.NativeFieldInfoPtr_Value));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OverrideInitialAgeAuthoring.NativeFieldInfoPtr_Value)) = value;
      }
    }
  }
}
