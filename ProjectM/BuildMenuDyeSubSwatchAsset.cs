// Decompiled with JetBrains decompiler
// Type: BuildMenuDyeSubSwatchAsset
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using ProjectM;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
public class BuildMenuDyeSubSwatchAsset : ScriptableObject
{
  private static readonly System.IntPtr NativeFieldInfoPtr_Swatches;
  private static readonly System.IntPtr NativeFieldInfoPtr__Guid;
  private static readonly System.IntPtr NativeFieldInfoPtr_BaseColorProp;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_PrefabGuid_Public_get_PrefabGUID_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetSwatchIndexFromGuidHash_Public_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public unsafe PrefabGUID PrefabGuid
  {
    [CallerCount(9), CachedScanResults(RefRangeStart = 726435, RefRangeEnd = 726444, XrefRangeStart = 726435, XrefRangeEnd = 726444, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuildMenuDyeSubSwatchAsset.NativeMethodInfoPtr_get_PrefabGuid_Public_get_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 912187, RefRangeEnd = 912190, XrefRangeStart = 912166, XrefRangeEnd = 912187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int GetSwatchIndexFromGuidHash(int guidHash)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = (System.IntPtr) &guidHash;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuildMenuDyeSubSwatchAsset.NativeMethodInfoPtr_GetSwatchIndexFromGuidHash_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(int*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 912190, XrefRangeEnd = 912282, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Convert(
    EntityManager dstManager,
    GameObjectConversionSystem conversionSystem)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &dstManager;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BuildMenuDyeSubSwatchAsset.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(11)]
  [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BuildMenuDyeSubSwatchAsset()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildMenuDyeSubSwatchAsset>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BuildMenuDyeSubSwatchAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static BuildMenuDyeSubSwatchAsset()
  {
    Il2CppClassPointerStore<BuildMenuDyeSubSwatchAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "", nameof (BuildMenuDyeSubSwatchAsset));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildMenuDyeSubSwatchAsset>.NativeClassPtr);
    BuildMenuDyeSubSwatchAsset.NativeFieldInfoPtr_Swatches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuDyeSubSwatchAsset>.NativeClassPtr, nameof (Swatches));
    BuildMenuDyeSubSwatchAsset.NativeFieldInfoPtr__Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuDyeSubSwatchAsset>.NativeClassPtr, nameof (_Guid));
    BuildMenuDyeSubSwatchAsset.NativeFieldInfoPtr_BaseColorProp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuDyeSubSwatchAsset>.NativeClassPtr, nameof (BaseColorProp));
    BuildMenuDyeSubSwatchAsset.NativeMethodInfoPtr_get_PrefabGuid_Public_get_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuDyeSubSwatchAsset>.NativeClassPtr, 100663366);
    BuildMenuDyeSubSwatchAsset.NativeMethodInfoPtr_GetSwatchIndexFromGuidHash_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuDyeSubSwatchAsset>.NativeClassPtr, 100663367);
    BuildMenuDyeSubSwatchAsset.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuDyeSubSwatchAsset>.NativeClassPtr, 100663368);
    BuildMenuDyeSubSwatchAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuDyeSubSwatchAsset>.NativeClassPtr, 100663369);
  }

  public BuildMenuDyeSubSwatchAsset(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe List<Swatch> Swatches
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuDyeSubSwatchAsset.NativeFieldInfoPtr_Swatches));
      return pointer == System.IntPtr.Zero ? (List<Swatch>) null : new List<Swatch>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuDyeSubSwatchAsset.NativeFieldInfoPtr_Swatches), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe string _Guid
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuDyeSubSwatchAsset.NativeFieldInfoPtr__Guid)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuDyeSubSwatchAsset.NativeFieldInfoPtr__Guid), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe int BaseColorProp
  {
    get
    {
      int baseColorProp;
      IL2CPP.il2cpp_field_static_get_value(BuildMenuDyeSubSwatchAsset.NativeFieldInfoPtr_BaseColorProp, (void*) &baseColorProp);
      return baseColorProp;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(BuildMenuDyeSubSwatchAsset.NativeFieldInfoPtr_BaseColorProp, (void*) &value);
    }
  }

  [ObfuscatedName("BuildMenuDyeSubSwatchAsset/<>c__DisplayClass5_0")]
  public sealed class __c__DisplayClass5_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_guidHash;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GetSwatchIndexFromGuidHash_b__0_Internal_Boolean_Swatch_0;

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass5_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildMenuDyeSubSwatchAsset.__c__DisplayClass5_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildMenuDyeSubSwatchAsset.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe bool _GetSwatchIndexFromGuidHash_b__0(Swatch x)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) x);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuildMenuDyeSubSwatchAsset.__c__DisplayClass5_0.NativeMethodInfoPtr__GetSwatchIndexFromGuidHash_b__0_Internal_Boolean_Swatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass5_0()
    {
      Il2CppClassPointerStore<BuildMenuDyeSubSwatchAsset.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuildMenuDyeSubSwatchAsset>.NativeClassPtr, "<>c__DisplayClass5_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildMenuDyeSubSwatchAsset.__c__DisplayClass5_0>.NativeClassPtr);
      BuildMenuDyeSubSwatchAsset.__c__DisplayClass5_0.NativeFieldInfoPtr_guidHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuDyeSubSwatchAsset.__c__DisplayClass5_0>.NativeClassPtr, nameof (guidHash));
      BuildMenuDyeSubSwatchAsset.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuDyeSubSwatchAsset.__c__DisplayClass5_0>.NativeClassPtr, 100663371);
      BuildMenuDyeSubSwatchAsset.__c__DisplayClass5_0.NativeMethodInfoPtr__GetSwatchIndexFromGuidHash_b__0_Internal_Boolean_Swatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuDyeSubSwatchAsset.__c__DisplayClass5_0>.NativeClassPtr, 100663372);
    }

    public __c__DisplayClass5_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int guidHash
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuDyeSubSwatchAsset.__c__DisplayClass5_0.NativeFieldInfoPtr_guidHash));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuDyeSubSwatchAsset.__c__DisplayClass5_0.NativeFieldInfoPtr_guidHash)) = value;
      }
    }
  }
}
