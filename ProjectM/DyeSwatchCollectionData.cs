// Decompiled with JetBrains decompiler
// Type: DyeSwatchCollectionData
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using ProjectM;
using System.Runtime.InteropServices;

#nullable disable
public class DyeSwatchCollectionData : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_ColorSwatchData;
  private static readonly System.IntPtr NativeFieldInfoPtr_ID;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Colors_Public_Virtual_Final_New_get_IList_1_IColor_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public virtual unsafe IList<IColor> Colors
  {
    [CallerCount(8), CachedScanResults(RefRangeStart = 16442, RefRangeEnd = 16450, XrefRangeStart = 16442, XrefRangeEnd = 16450, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DyeSwatchCollectionData.NativeMethodInfoPtr_get_Colors_Public_Virtual_Final_New_get_IList_1_IColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (IList<IColor>) null : new IList<IColor>(pointer);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 912334, XrefRangeEnd = 912342, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe Il2CppSystem.Object System_ICloneable_Clone()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DyeSwatchCollectionData.NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
  }

  [CallerCount(3875)]
  [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe DyeSwatchCollectionData()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DyeSwatchCollectionData>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DyeSwatchCollectionData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static DyeSwatchCollectionData()
  {
    Il2CppClassPointerStore<DyeSwatchCollectionData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "", nameof (DyeSwatchCollectionData));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DyeSwatchCollectionData>.NativeClassPtr);
    DyeSwatchCollectionData.NativeFieldInfoPtr_ColorSwatchData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DyeSwatchCollectionData>.NativeClassPtr, nameof (ColorSwatchData));
    DyeSwatchCollectionData.NativeFieldInfoPtr_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DyeSwatchCollectionData>.NativeClassPtr, nameof (ID));
    DyeSwatchCollectionData.NativeMethodInfoPtr_get_Colors_Public_Virtual_Final_New_get_IList_1_IColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DyeSwatchCollectionData>.NativeClassPtr, 100663385);
    DyeSwatchCollectionData.NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DyeSwatchCollectionData>.NativeClassPtr, 100663386);
    DyeSwatchCollectionData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DyeSwatchCollectionData>.NativeClassPtr, 100663387);
  }

  public DyeSwatchCollectionData(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Il2CppReferenceArray<global::ColorSwatchData> ColorSwatchData
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DyeSwatchCollectionData.NativeFieldInfoPtr_ColorSwatchData));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<global::ColorSwatchData>) null : new Il2CppReferenceArray<global::ColorSwatchData>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DyeSwatchCollectionData.NativeFieldInfoPtr_ColorSwatchData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe PrefabGUID ID
  {
    get
    {
      return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DyeSwatchCollectionData.NativeFieldInfoPtr_ID));
    }
    [param: In] set
    {
      *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DyeSwatchCollectionData.NativeFieldInfoPtr_ID)) = value;
    }
  }
}
