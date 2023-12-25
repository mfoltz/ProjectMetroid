// Decompiled with JetBrains decompiler
// Type: BuildMenuDyeSwatchCollectionAsset
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using ProjectM;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
public class BuildMenuDyeSwatchCollectionAsset : ScriptableObject
{
  private static readonly IntPtr NativeFieldInfoPtr_ColorChoices;
  private static readonly IntPtr NativeFieldInfoPtr__Guid;
  private static readonly IntPtr NativeMethodInfoPtr_get_PrefabGuid_Public_get_PrefabGUID_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_Colors_Public_Virtual_Final_New_get_IList_1_IColor_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetIndexByNameHash_Public_Int32_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public unsafe PrefabGUID PrefabGuid
  {
    [CallerCount(9), CachedScanResults(RefRangeStart = 726435, RefRangeEnd = 726444, XrefRangeStart = 726435, XrefRangeEnd = 726444, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuildMenuDyeSwatchCollectionAsset.NativeMethodInfoPtr_get_PrefabGuid_Public_get_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  public virtual unsafe IList<IColor> Colors
  {
    [CallerCount(9), CachedScanResults(RefRangeStart = 16432, RefRangeEnd = 16441, XrefRangeStart = 16432, XrefRangeEnd = 16441, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuildMenuDyeSwatchCollectionAsset.NativeMethodInfoPtr_get_Colors_Public_Virtual_Final_New_get_IList_1_IColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (IList<IColor>) null : new IList<IColor>(pointer);
    }
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 912348, RefRangeEnd = 912352, XrefRangeStart = 912346, XrefRangeEnd = 912348, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int GetIndexByNameHash(int nameHash)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1];
    numPtr[0] = (IntPtr) &nameHash;
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuildMenuDyeSwatchCollectionAsset.NativeMethodInfoPtr_GetIndexByNameHash_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(int*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 912352, XrefRangeEnd = 912419, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Convert(
    EntityManager dstManager,
    GameObjectConversionSystem conversionSystem)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &dstManager;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BuildMenuDyeSwatchCollectionAsset.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(11)]
  [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BuildMenuDyeSwatchCollectionAsset()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildMenuDyeSwatchCollectionAsset>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BuildMenuDyeSwatchCollectionAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static BuildMenuDyeSwatchCollectionAsset()
  {
    Il2CppClassPointerStore<BuildMenuDyeSwatchCollectionAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "", nameof (BuildMenuDyeSwatchCollectionAsset));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildMenuDyeSwatchCollectionAsset>.NativeClassPtr);
    BuildMenuDyeSwatchCollectionAsset.NativeFieldInfoPtr_ColorChoices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuDyeSwatchCollectionAsset>.NativeClassPtr, nameof (ColorChoices));
    BuildMenuDyeSwatchCollectionAsset.NativeFieldInfoPtr__Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuDyeSwatchCollectionAsset>.NativeClassPtr, nameof (_Guid));
    BuildMenuDyeSwatchCollectionAsset.NativeMethodInfoPtr_get_PrefabGuid_Public_get_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuDyeSwatchCollectionAsset>.NativeClassPtr, 100663393);
    BuildMenuDyeSwatchCollectionAsset.NativeMethodInfoPtr_get_Colors_Public_Virtual_Final_New_get_IList_1_IColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuDyeSwatchCollectionAsset>.NativeClassPtr, 100663394);
    BuildMenuDyeSwatchCollectionAsset.NativeMethodInfoPtr_GetIndexByNameHash_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuDyeSwatchCollectionAsset>.NativeClassPtr, 100663395);
    BuildMenuDyeSwatchCollectionAsset.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuDyeSwatchCollectionAsset>.NativeClassPtr, 100663396);
    BuildMenuDyeSwatchCollectionAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuDyeSwatchCollectionAsset>.NativeClassPtr, 100663397);
  }

  public BuildMenuDyeSwatchCollectionAsset(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Il2CppReferenceArray<ColorSwatchCollection> ColorChoices
  {
    get
    {
      IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuDyeSwatchCollectionAsset.NativeFieldInfoPtr_ColorChoices));
      return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<ColorSwatchCollection>) null : new Il2CppReferenceArray<ColorSwatchCollection>(nativeObject);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuDyeSwatchCollectionAsset.NativeFieldInfoPtr_ColorChoices), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe string _Guid
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuDyeSwatchCollectionAsset.NativeFieldInfoPtr__Guid)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuDyeSwatchCollectionAsset.NativeFieldInfoPtr__Guid), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }
}
