// Decompiled with JetBrains decompiler
// Type: SubSwatchData
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using ProjectM;
using System;
using System.Runtime.InteropServices;

#nullable disable
public class SubSwatchData : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_ColorSwatchData;
  private static readonly System.IntPtr NativeFieldInfoPtr_ID;
  private static readonly System.IntPtr NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 912294, XrefRangeEnd = 912333, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe Il2CppSystem.Object System_ICloneable_Clone()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SubSwatchData.NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
  }

  [CallerCount(3875)]
  [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SubSwatchData()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SubSwatchData>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SubSwatchData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static SubSwatchData()
  {
    Il2CppClassPointerStore<SubSwatchData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "", nameof (SubSwatchData));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubSwatchData>.NativeClassPtr);
    SubSwatchData.NativeFieldInfoPtr_ColorSwatchData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubSwatchData>.NativeClassPtr, nameof (ColorSwatchData));
    SubSwatchData.NativeFieldInfoPtr_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubSwatchData>.NativeClassPtr, nameof (ID));
    SubSwatchData.NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubSwatchData>.NativeClassPtr, 100663377);
    SubSwatchData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubSwatchData>.NativeClassPtr, 100663378);
  }

  public SubSwatchData(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Dictionary<int, SwatchData> ColorSwatchData
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SubSwatchData.NativeFieldInfoPtr_ColorSwatchData));
      return pointer == System.IntPtr.Zero ? (Dictionary<int, SwatchData>) null : new Dictionary<int, SwatchData>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SubSwatchData.NativeFieldInfoPtr_ColorSwatchData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe PrefabGUID ID
  {
    get
    {
      return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SubSwatchData.NativeFieldInfoPtr_ID));
    }
    [param: In] set
    {
      *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SubSwatchData.NativeFieldInfoPtr_ID)) = value;
    }
  }

  [ObfuscatedName("SubSwatchData/<>c")]
  [Serializable]
  public sealed class __c : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__2_0;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__2_1;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__System_ICloneable_Clone_b__2_0_Internal_Int32_KeyValuePair_2_Int32_SwatchData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__System_ICloneable_Clone_b__2_1_Internal_SwatchData_KeyValuePair_2_Int32_SwatchData_0;

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SubSwatchData.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SubSwatchData.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 912292, XrefRangeEnd = 912293, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int _System_ICloneable_Clone_b__2_0(KeyValuePair<int, SwatchData> entry)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) entry));
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SubSwatchData.__c.NativeMethodInfoPtr__System_ICloneable_Clone_b__2_0_Internal_Int32_KeyValuePair_2_Int32_SwatchData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 912293, XrefRangeEnd = 912294, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SwatchData _System_ICloneable_Clone_b__2_1(KeyValuePair<int, SwatchData> entry)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) entry));
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SubSwatchData.__c.NativeMethodInfoPtr__System_ICloneable_Clone_b__2_1_Internal_SwatchData_KeyValuePair_2_Int32_SwatchData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (SwatchData) null : new SwatchData(pointer);
    }

    static __c()
    {
      Il2CppClassPointerStore<SubSwatchData.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SubSwatchData>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubSwatchData.__c>.NativeClassPtr);
      SubSwatchData.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubSwatchData.__c>.NativeClassPtr, "<>9");
      SubSwatchData.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubSwatchData.__c>.NativeClassPtr, "<>9__2_0");
      SubSwatchData.__c.NativeFieldInfoPtr___9__2_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubSwatchData.__c>.NativeClassPtr, "<>9__2_1");
      SubSwatchData.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubSwatchData.__c>.NativeClassPtr, 100663380);
      SubSwatchData.__c.NativeMethodInfoPtr__System_ICloneable_Clone_b__2_0_Internal_Int32_KeyValuePair_2_Int32_SwatchData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubSwatchData.__c>.NativeClassPtr, 100663381);
      SubSwatchData.__c.NativeMethodInfoPtr__System_ICloneable_Clone_b__2_1_Internal_SwatchData_KeyValuePair_2_Int32_SwatchData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubSwatchData.__c>.NativeClassPtr, 100663382);
    }

    public __c(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe SubSwatchData.__c __9
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(SubSwatchData.__c.NativeFieldInfoPtr___9, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (SubSwatchData.__c) null : new SubSwatchData.__c(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SubSwatchData.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<KeyValuePair<int, SwatchData>, int> __9__2_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(SubSwatchData.__c.NativeFieldInfoPtr___9__2_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<KeyValuePair<int, SwatchData>, int>) null : new Il2CppSystem.Func<KeyValuePair<int, SwatchData>, int>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SubSwatchData.__c.NativeFieldInfoPtr___9__2_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<KeyValuePair<int, SwatchData>, SwatchData> __9__2_1
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(SubSwatchData.__c.NativeFieldInfoPtr___9__2_1, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<KeyValuePair<int, SwatchData>, SwatchData>) null : new Il2CppSystem.Func<KeyValuePair<int, SwatchData>, SwatchData>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SubSwatchData.__c.NativeFieldInfoPtr___9__2_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
