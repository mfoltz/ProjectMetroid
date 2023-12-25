// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.AbilityTypeLocalizationKeys
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using Stunlock.Localization;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.UI
{
  [Serializable]
  public sealed class AbilityTypeLocalizationKeys : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Values;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetKey_Public_LocalizationKey_AbilityTypeEnum_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1160661, XrefRangeEnd = 1160677, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe LocalizationKey GetKey(AbilityTypeEnum abilityTypeEnum)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &abilityTypeEnum;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityTypeLocalizationKeys.NativeMethodInfoPtr_GetKey_Public_LocalizationKey_AbilityTypeEnum_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(LocalizationKey*) IL2CPP.il2cpp_object_unbox(num);
    }

    static AbilityTypeLocalizationKeys()
    {
      Il2CppClassPointerStore<AbilityTypeLocalizationKeys>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.UI", nameof (AbilityTypeLocalizationKeys));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityTypeLocalizationKeys>.NativeClassPtr);
      AbilityTypeLocalizationKeys.NativeFieldInfoPtr_Values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityTypeLocalizationKeys>.NativeClassPtr, nameof (Values));
      AbilityTypeLocalizationKeys.NativeMethodInfoPtr_GetKey_Public_LocalizationKey_AbilityTypeEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityTypeLocalizationKeys>.NativeClassPtr, 100692283);
    }

    public AbilityTypeLocalizationKeys(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public AbilityTypeLocalizationKeys()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AbilityTypeLocalizationKeys>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityTypeLocalizationKeys>.NativeClassPtr, data));
    }

    public unsafe List<AbilityTypeLocalizationKeys.KeyVal> Values
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityTypeLocalizationKeys.NativeFieldInfoPtr_Values));
        return pointer == System.IntPtr.Zero ? (List<AbilityTypeLocalizationKeys.KeyVal>) null : new List<AbilityTypeLocalizationKeys.KeyVal>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AbilityTypeLocalizationKeys.NativeFieldInfoPtr_Values), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [Serializable]
    [StructLayout(LayoutKind.Explicit)]
    public struct KeyVal
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_AbilityType;
      private static readonly System.IntPtr NativeFieldInfoPtr_Key;
      [FieldOffset(0)]
      public AbilityTypeEnum AbilityType;
      [FieldOffset(4)]
      public LocalizationKey Key;

      static KeyVal()
      {
        Il2CppClassPointerStore<AbilityTypeLocalizationKeys.KeyVal>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityTypeLocalizationKeys>.NativeClassPtr, nameof (KeyVal));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityTypeLocalizationKeys.KeyVal>.NativeClassPtr);
        AbilityTypeLocalizationKeys.KeyVal.NativeFieldInfoPtr_AbilityType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityTypeLocalizationKeys.KeyVal>.NativeClassPtr, nameof (AbilityType));
        AbilityTypeLocalizationKeys.KeyVal.NativeFieldInfoPtr_Key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityTypeLocalizationKeys.KeyVal>.NativeClassPtr, nameof (Key));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityTypeLocalizationKeys.KeyVal>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
