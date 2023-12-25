// Decompiled with JetBrains decompiler
// Type: CachedStrings
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using System;
using System.Runtime.InteropServices;

#nullable disable
public static class CachedStrings : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr__CachedStringShield;
  private static readonly System.IntPtr NativeFieldInfoPtr__CachedStringPositive;
  private static readonly System.IntPtr NativeFieldInfoPtr__CachedStringNegative;
  private static readonly System.IntPtr NativeFieldInfoPtr__CachedStringStandard;
  private static readonly System.IntPtr NativeFieldInfoPtr__CachedStringStandardN0;
  private static readonly System.IntPtr NativeFieldInfoPtr__CachedStringStandardExclamation;
  private static readonly System.IntPtr NativeFieldInfoPtr__CachedStringNegativeExclamation;
  private static readonly System.IntPtr NativeFieldInfoPtr__CachedStringOneDecimal;
  private static readonly System.IntPtr NativeFieldInfoPtr__CachedStringPercent;
  private static readonly System.IntPtr NativeMethodInfoPtr_Shield_Public_Static_String_Int32_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Positive_Public_Static_String_Int32_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Negative_Public_Static_String_Int32_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Standard_Public_Static_String_Int32_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StandardN0_Public_Static_String_Int32_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StandardExclamation_Public_Static_String_Int32_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_NegativeExclamation_Public_Static_String_Int32_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Percent_Public_Static_String_Int32_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DecimalN1_Public_Static_String_Single_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetOrCache_Private_Static_String_T_Boolean_Dictionary_2_T_String_Func_2_T_String_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1207367, XrefRangeEnd = 1207393, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string Shield(int value, bool cacheIfMissing = false)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &value;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &cacheIfMissing;
    System.IntPtr exc;
    System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(CachedStrings.NativeMethodInfoPtr_Shield_Public_Static_String_Int32_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.Il2CppStringToManaged(il2CppString);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1207393, XrefRangeEnd = 1207419, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string Positive(int value, bool cacheIfMissing = false)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &value;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &cacheIfMissing;
    System.IntPtr exc;
    System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(CachedStrings.NativeMethodInfoPtr_Positive_Public_Static_String_Int32_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.Il2CppStringToManaged(il2CppString);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1207419, XrefRangeEnd = 1207445, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string Negative(int value, bool cacheIfMissing = false)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &value;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &cacheIfMissing;
    System.IntPtr exc;
    System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(CachedStrings.NativeMethodInfoPtr_Negative_Public_Static_String_Int32_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.Il2CppStringToManaged(il2CppString);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 1207471, RefRangeEnd = 1207477, XrefRangeStart = 1207445, XrefRangeEnd = 1207471, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string Standard(int value, bool cacheIfMissing = false)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &value;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &cacheIfMissing;
    System.IntPtr exc;
    System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(CachedStrings.NativeMethodInfoPtr_Standard_Public_Static_String_Int32_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.Il2CppStringToManaged(il2CppString);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 1207503, RefRangeEnd = 1207505, XrefRangeStart = 1207477, XrefRangeEnd = 1207503, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string StandardN0(int value, bool cacheIfMissing = false)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &value;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &cacheIfMissing;
    System.IntPtr exc;
    System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(CachedStrings.NativeMethodInfoPtr_StandardN0_Public_Static_String_Int32_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.Il2CppStringToManaged(il2CppString);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1207505, XrefRangeEnd = 1207531, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string StandardExclamation(int value, bool cacheIfMissing = false)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &value;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &cacheIfMissing;
    System.IntPtr exc;
    System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(CachedStrings.NativeMethodInfoPtr_StandardExclamation_Public_Static_String_Int32_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.Il2CppStringToManaged(il2CppString);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1207531, XrefRangeEnd = 1207557, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string NegativeExclamation(int value, bool cacheIfMissing = false)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &value;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &cacheIfMissing;
    System.IntPtr exc;
    System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(CachedStrings.NativeMethodInfoPtr_NegativeExclamation_Public_Static_String_Int32_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.Il2CppStringToManaged(il2CppString);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1207557, XrefRangeEnd = 1207583, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string Percent(int value, bool cacheIfMissing = false)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &value;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &cacheIfMissing;
    System.IntPtr exc;
    System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(CachedStrings.NativeMethodInfoPtr_Percent_Public_Static_String_Int32_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.Il2CppStringToManaged(il2CppString);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 1207610, RefRangeEnd = 1207612, XrefRangeStart = 1207583, XrefRangeEnd = 1207610, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string DecimalN1(float value, bool cacheIfMissing = false)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &value;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &cacheIfMissing;
    System.IntPtr exc;
    System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(CachedStrings.NativeMethodInfoPtr_DecimalN1_Public_Static_String_Single_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.Il2CppStringToManaged(il2CppString);
  }

  [CallerCount(10)]
  [CachedScanResults(RefRangeStart = 1207612, RefRangeEnd = 1207622, XrefRangeStart = 1207612, XrefRangeEnd = 1207612, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string GetOrCache<T>(
    T value,
    bool cacheIfMissing,
    Dictionary<T, string> cache,
    Il2CppSystem.Func<T, string> toString)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[4];
    System.IntPtr* numPtr2 = numPtr1;
    // ISSUE: variable of a reference type
    T& local1;
    if (!typeof (T).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<T> local2 = (object) value;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref value;
    *numPtr2 = (System.IntPtr) ref local1;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &cacheIfMissing;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cache);
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) toString);
    System.IntPtr exc;
    System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(CachedStrings.MethodInfoStoreGeneric_GetOrCache_Private_Static_String_T_Boolean_Dictionary_2_T_String_Func_2_T_String_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.Il2CppStringToManaged(il2CppString);
  }

  static CachedStrings()
  {
    Il2CppClassPointerStore<CachedStrings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "", nameof (CachedStrings));
    CachedStrings.NativeFieldInfoPtr__CachedStringShield = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedStrings>.NativeClassPtr, nameof (_CachedStringShield));
    CachedStrings.NativeFieldInfoPtr__CachedStringPositive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedStrings>.NativeClassPtr, nameof (_CachedStringPositive));
    CachedStrings.NativeFieldInfoPtr__CachedStringNegative = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedStrings>.NativeClassPtr, nameof (_CachedStringNegative));
    CachedStrings.NativeFieldInfoPtr__CachedStringStandard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedStrings>.NativeClassPtr, nameof (_CachedStringStandard));
    CachedStrings.NativeFieldInfoPtr__CachedStringStandardN0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedStrings>.NativeClassPtr, nameof (_CachedStringStandardN0));
    CachedStrings.NativeFieldInfoPtr__CachedStringStandardExclamation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedStrings>.NativeClassPtr, nameof (_CachedStringStandardExclamation));
    CachedStrings.NativeFieldInfoPtr__CachedStringNegativeExclamation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedStrings>.NativeClassPtr, nameof (_CachedStringNegativeExclamation));
    CachedStrings.NativeFieldInfoPtr__CachedStringOneDecimal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedStrings>.NativeClassPtr, nameof (_CachedStringOneDecimal));
    CachedStrings.NativeFieldInfoPtr__CachedStringPercent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedStrings>.NativeClassPtr, nameof (_CachedStringPercent));
    CachedStrings.NativeMethodInfoPtr_Shield_Public_Static_String_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CachedStrings>.NativeClassPtr, 100663468);
    CachedStrings.NativeMethodInfoPtr_Positive_Public_Static_String_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CachedStrings>.NativeClassPtr, 100663469);
    CachedStrings.NativeMethodInfoPtr_Negative_Public_Static_String_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CachedStrings>.NativeClassPtr, 100663470);
    CachedStrings.NativeMethodInfoPtr_Standard_Public_Static_String_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CachedStrings>.NativeClassPtr, 100663471);
    CachedStrings.NativeMethodInfoPtr_StandardN0_Public_Static_String_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CachedStrings>.NativeClassPtr, 100663472);
    CachedStrings.NativeMethodInfoPtr_StandardExclamation_Public_Static_String_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CachedStrings>.NativeClassPtr, 100663473);
    CachedStrings.NativeMethodInfoPtr_NegativeExclamation_Public_Static_String_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CachedStrings>.NativeClassPtr, 100663474);
    CachedStrings.NativeMethodInfoPtr_Percent_Public_Static_String_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CachedStrings>.NativeClassPtr, 100663475);
    CachedStrings.NativeMethodInfoPtr_DecimalN1_Public_Static_String_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CachedStrings>.NativeClassPtr, 100663476);
    CachedStrings.NativeMethodInfoPtr_GetOrCache_Private_Static_String_T_Boolean_Dictionary_2_T_String_Func_2_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CachedStrings>.NativeClassPtr, 100663477);
  }

  public CachedStrings(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe Dictionary<int, string> _CachedStringShield
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(CachedStrings.NativeFieldInfoPtr__CachedStringShield, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Dictionary<int, string>) null : new Dictionary<int, string>(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CachedStrings.NativeFieldInfoPtr__CachedStringShield, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Dictionary<int, string> _CachedStringPositive
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(CachedStrings.NativeFieldInfoPtr__CachedStringPositive, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Dictionary<int, string>) null : new Dictionary<int, string>(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CachedStrings.NativeFieldInfoPtr__CachedStringPositive, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Dictionary<int, string> _CachedStringNegative
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(CachedStrings.NativeFieldInfoPtr__CachedStringNegative, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Dictionary<int, string>) null : new Dictionary<int, string>(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CachedStrings.NativeFieldInfoPtr__CachedStringNegative, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Dictionary<int, string> _CachedStringStandard
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(CachedStrings.NativeFieldInfoPtr__CachedStringStandard, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Dictionary<int, string>) null : new Dictionary<int, string>(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CachedStrings.NativeFieldInfoPtr__CachedStringStandard, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Dictionary<int, string> _CachedStringStandardN0
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(CachedStrings.NativeFieldInfoPtr__CachedStringStandardN0, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Dictionary<int, string>) null : new Dictionary<int, string>(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CachedStrings.NativeFieldInfoPtr__CachedStringStandardN0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Dictionary<int, string> _CachedStringStandardExclamation
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(CachedStrings.NativeFieldInfoPtr__CachedStringStandardExclamation, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Dictionary<int, string>) null : new Dictionary<int, string>(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CachedStrings.NativeFieldInfoPtr__CachedStringStandardExclamation, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Dictionary<int, string> _CachedStringNegativeExclamation
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(CachedStrings.NativeFieldInfoPtr__CachedStringNegativeExclamation, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Dictionary<int, string>) null : new Dictionary<int, string>(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CachedStrings.NativeFieldInfoPtr__CachedStringNegativeExclamation, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Dictionary<int, string> _CachedStringOneDecimal
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(CachedStrings.NativeFieldInfoPtr__CachedStringOneDecimal, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Dictionary<int, string>) null : new Dictionary<int, string>(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CachedStrings.NativeFieldInfoPtr__CachedStringOneDecimal, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Dictionary<int, string> _CachedStringPercent
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(CachedStrings.NativeFieldInfoPtr__CachedStringPercent, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Dictionary<int, string>) null : new Dictionary<int, string>(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CachedStrings.NativeFieldInfoPtr__CachedStringPercent, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("CachedStrings/<>c")]
  [Serializable]
  public sealed class __c : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__10_0;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__11_0;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__12_0;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__13_0;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__14_0;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__15_0;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__16_0;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__17_0;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__18_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Shield_b__10_0_Internal_String_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Positive_b__11_0_Internal_String_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Negative_b__12_0_Internal_String_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Standard_b__13_0_Internal_String_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__StandardN0_b__14_0_Internal_String_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__StandardExclamation_b__15_0_Internal_String_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__NegativeExclamation_b__16_0_Internal_String_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Percent_b__17_0_Internal_String_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__DecimalN1_b__18_0_Internal_String_Int32_0;

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CachedStrings.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CachedStrings.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1207333, XrefRangeEnd = 1207339, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string _Shield_b__10_0(int x)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &x;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(CachedStrings.__c.NativeMethodInfoPtr__Shield_b__10_0_Internal_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1207339, XrefRangeEnd = 1207343, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string _Positive_b__11_0(int x)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &x;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(CachedStrings.__c.NativeMethodInfoPtr__Positive_b__11_0_Internal_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1207343, XrefRangeEnd = 1207347, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string _Negative_b__12_0(int x)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &x;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(CachedStrings.__c.NativeMethodInfoPtr__Negative_b__12_0_Internal_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string _Standard_b__13_0(int x)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &x;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(CachedStrings.__c.NativeMethodInfoPtr__Standard_b__13_0_Internal_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1207347, XrefRangeEnd = 1207350, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string _StandardN0_b__14_0(int x)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &x;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(CachedStrings.__c.NativeMethodInfoPtr__StandardN0_b__14_0_Internal_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1207350, XrefRangeEnd = 1207354, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string _StandardExclamation_b__15_0(int x)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &x;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(CachedStrings.__c.NativeMethodInfoPtr__StandardExclamation_b__15_0_Internal_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1207354, XrefRangeEnd = 1207360, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string _NegativeExclamation_b__16_0(int x)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &x;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(CachedStrings.__c.NativeMethodInfoPtr__NegativeExclamation_b__16_0_Internal_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1207360, XrefRangeEnd = 1207364, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string _Percent_b__17_0(int x)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &x;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(CachedStrings.__c.NativeMethodInfoPtr__Percent_b__17_0_Internal_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1207364, XrefRangeEnd = 1207367, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string _DecimalN1_b__18_0(int x)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &x;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(CachedStrings.__c.NativeMethodInfoPtr__DecimalN1_b__18_0_Internal_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static __c()
    {
      Il2CppClassPointerStore<CachedStrings.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CachedStrings>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CachedStrings.__c>.NativeClassPtr);
      CachedStrings.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedStrings.__c>.NativeClassPtr, "<>9");
      CachedStrings.__c.NativeFieldInfoPtr___9__10_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedStrings.__c>.NativeClassPtr, "<>9__10_0");
      CachedStrings.__c.NativeFieldInfoPtr___9__11_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedStrings.__c>.NativeClassPtr, "<>9__11_0");
      CachedStrings.__c.NativeFieldInfoPtr___9__12_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedStrings.__c>.NativeClassPtr, "<>9__12_0");
      CachedStrings.__c.NativeFieldInfoPtr___9__13_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedStrings.__c>.NativeClassPtr, "<>9__13_0");
      CachedStrings.__c.NativeFieldInfoPtr___9__14_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedStrings.__c>.NativeClassPtr, "<>9__14_0");
      CachedStrings.__c.NativeFieldInfoPtr___9__15_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedStrings.__c>.NativeClassPtr, "<>9__15_0");
      CachedStrings.__c.NativeFieldInfoPtr___9__16_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedStrings.__c>.NativeClassPtr, "<>9__16_0");
      CachedStrings.__c.NativeFieldInfoPtr___9__17_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedStrings.__c>.NativeClassPtr, "<>9__17_0");
      CachedStrings.__c.NativeFieldInfoPtr___9__18_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedStrings.__c>.NativeClassPtr, "<>9__18_0");
      CachedStrings.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CachedStrings.__c>.NativeClassPtr, 100663479);
      CachedStrings.__c.NativeMethodInfoPtr__Shield_b__10_0_Internal_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CachedStrings.__c>.NativeClassPtr, 100663480);
      CachedStrings.__c.NativeMethodInfoPtr__Positive_b__11_0_Internal_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CachedStrings.__c>.NativeClassPtr, 100663481);
      CachedStrings.__c.NativeMethodInfoPtr__Negative_b__12_0_Internal_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CachedStrings.__c>.NativeClassPtr, 100663482);
      CachedStrings.__c.NativeMethodInfoPtr__Standard_b__13_0_Internal_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CachedStrings.__c>.NativeClassPtr, 100663483);
      CachedStrings.__c.NativeMethodInfoPtr__StandardN0_b__14_0_Internal_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CachedStrings.__c>.NativeClassPtr, 100663484);
      CachedStrings.__c.NativeMethodInfoPtr__StandardExclamation_b__15_0_Internal_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CachedStrings.__c>.NativeClassPtr, 100663485);
      CachedStrings.__c.NativeMethodInfoPtr__NegativeExclamation_b__16_0_Internal_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CachedStrings.__c>.NativeClassPtr, 100663486);
      CachedStrings.__c.NativeMethodInfoPtr__Percent_b__17_0_Internal_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CachedStrings.__c>.NativeClassPtr, 100663487);
      CachedStrings.__c.NativeMethodInfoPtr__DecimalN1_b__18_0_Internal_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CachedStrings.__c>.NativeClassPtr, 100663488);
    }

    public __c(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe CachedStrings.__c __9
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(CachedStrings.__c.NativeFieldInfoPtr___9, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (CachedStrings.__c) null : new CachedStrings.__c(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CachedStrings.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<int, string> __9__10_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(CachedStrings.__c.NativeFieldInfoPtr___9__10_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<int, string>) null : new Il2CppSystem.Func<int, string>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CachedStrings.__c.NativeFieldInfoPtr___9__10_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<int, string> __9__11_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(CachedStrings.__c.NativeFieldInfoPtr___9__11_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<int, string>) null : new Il2CppSystem.Func<int, string>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CachedStrings.__c.NativeFieldInfoPtr___9__11_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<int, string> __9__12_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(CachedStrings.__c.NativeFieldInfoPtr___9__12_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<int, string>) null : new Il2CppSystem.Func<int, string>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CachedStrings.__c.NativeFieldInfoPtr___9__12_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<int, string> __9__13_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(CachedStrings.__c.NativeFieldInfoPtr___9__13_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<int, string>) null : new Il2CppSystem.Func<int, string>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CachedStrings.__c.NativeFieldInfoPtr___9__13_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<int, string> __9__14_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(CachedStrings.__c.NativeFieldInfoPtr___9__14_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<int, string>) null : new Il2CppSystem.Func<int, string>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CachedStrings.__c.NativeFieldInfoPtr___9__14_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<int, string> __9__15_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(CachedStrings.__c.NativeFieldInfoPtr___9__15_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<int, string>) null : new Il2CppSystem.Func<int, string>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CachedStrings.__c.NativeFieldInfoPtr___9__15_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<int, string> __9__16_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(CachedStrings.__c.NativeFieldInfoPtr___9__16_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<int, string>) null : new Il2CppSystem.Func<int, string>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CachedStrings.__c.NativeFieldInfoPtr___9__16_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<int, string> __9__17_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(CachedStrings.__c.NativeFieldInfoPtr___9__17_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<int, string>) null : new Il2CppSystem.Func<int, string>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CachedStrings.__c.NativeFieldInfoPtr___9__17_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<int, string> __9__18_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(CachedStrings.__c.NativeFieldInfoPtr___9__18_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<int, string>) null : new Il2CppSystem.Func<int, string>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CachedStrings.__c.NativeFieldInfoPtr___9__18_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  private sealed class MethodInfoStoreGeneric_GetOrCache_Private_Static_String_T_Boolean_Dictionary_2_T_String_Func_2_T_String_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(CachedStrings.NativeMethodInfoPtr_GetOrCache_Private_Static_String_T_Boolean_Dictionary_2_T_String_Func_2_T_String_0, Il2CppClassPointerStore<CachedStrings>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }
}
