// Decompiled with JetBrains decompiler
// Type: ProjectM.KnockbackPowerAsset
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class KnockbackPowerAsset : ScriptableObject
  {
    private static readonly IntPtr NativeFieldInfoPtr_Importance;
    private static readonly IntPtr NativeFieldInfoPtr_Knockbacks;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_KnockbackPower_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 749141, RefRangeEnd = 749144, XrefRangeStart = 749125, XrefRangeEnd = 749141, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe KnockbackPower Convert()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(KnockbackPowerAsset.NativeMethodInfoPtr_Convert_Public_KnockbackPower_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(KnockbackPower*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 749144, XrefRangeEnd = 749152, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe KnockbackPowerAsset()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KnockbackPowerAsset>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(KnockbackPowerAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static KnockbackPowerAsset()
    {
      Il2CppClassPointerStore<KnockbackPowerAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (KnockbackPowerAsset));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KnockbackPowerAsset>.NativeClassPtr);
      KnockbackPowerAsset.NativeFieldInfoPtr_Importance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnockbackPowerAsset>.NativeClassPtr, nameof (Importance));
      KnockbackPowerAsset.NativeFieldInfoPtr_Knockbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnockbackPowerAsset>.NativeClassPtr, nameof (Knockbacks));
      KnockbackPowerAsset.NativeMethodInfoPtr_Convert_Public_KnockbackPower_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KnockbackPowerAsset>.NativeClassPtr, 100665966);
      KnockbackPowerAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KnockbackPowerAsset>.NativeClassPtr, 100665967);
    }

    public KnockbackPowerAsset(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int Importance
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KnockbackPowerAsset.NativeFieldInfoPtr_Importance));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KnockbackPowerAsset.NativeFieldInfoPtr_Importance)) = value;
      }
    }

    public unsafe List<KnockbackPowerEditorData> Knockbacks
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KnockbackPowerAsset.NativeFieldInfoPtr_Knockbacks));
        return pointer == IntPtr.Zero ? (List<KnockbackPowerEditorData>) null : new List<KnockbackPowerEditorData>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(KnockbackPowerAsset.NativeFieldInfoPtr_Knockbacks), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
