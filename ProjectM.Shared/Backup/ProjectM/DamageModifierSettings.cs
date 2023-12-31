// Decompiled with JetBrains decompiler
// Type: ProjectM.DamageModifierSettings
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
  public class DamageModifierSettings : ScriptableObject
  {
    private static readonly IntPtr NativeFieldInfoPtr_Modifiers;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DamageModifierSettings()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DamageModifierSettings>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DamageModifierSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DamageModifierSettings()
    {
      Il2CppClassPointerStore<DamageModifierSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (DamageModifierSettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DamageModifierSettings>.NativeClassPtr);
      DamageModifierSettings.NativeFieldInfoPtr_Modifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DamageModifierSettings>.NativeClassPtr, nameof (Modifiers));
      DamageModifierSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DamageModifierSettings>.NativeClassPtr, 100665926);
    }

    public DamageModifierSettings(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityTypeModifiers Modifiers
    {
      get
      {
        return *(EntityTypeModifiers*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DamageModifierSettings.NativeFieldInfoPtr_Modifiers));
      }
      [param: In] set
      {
        *(EntityTypeModifiers*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DamageModifierSettings.NativeFieldInfoPtr_Modifiers)) = value;
      }
    }
  }
}
