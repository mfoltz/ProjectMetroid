// Decompiled with JetBrains decompiler
// Type: UIAssetsSubScene_ContentAuthoring
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
public class UIAssetsSubScene_ContentAuthoring : MonoBehaviour
{
  private static readonly System.IntPtr NativeFieldInfoPtr_Assets;
  private static readonly System.IntPtr NativeFieldInfoPtr_AssetGroups;
  private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(10560)]
  [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Convert(
    Entity entity,
    EntityManager dstManager,
    GameObjectConversionSystem conversionSystem)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &entity;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &dstManager;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(UIAssetsSubScene_ContentAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(520)]
  [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UIAssetsSubScene_ContentAuthoring()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIAssetsSubScene_ContentAuthoring>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(UIAssetsSubScene_ContentAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static UIAssetsSubScene_ContentAuthoring()
  {
    Il2CppClassPointerStore<UIAssetsSubScene_ContentAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "", nameof (UIAssetsSubScene_ContentAuthoring));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIAssetsSubScene_ContentAuthoring>.NativeClassPtr);
    UIAssetsSubScene_ContentAuthoring.NativeFieldInfoPtr_Assets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIAssetsSubScene_ContentAuthoring>.NativeClassPtr, nameof (Assets));
    UIAssetsSubScene_ContentAuthoring.NativeFieldInfoPtr_AssetGroups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIAssetsSubScene_ContentAuthoring>.NativeClassPtr, nameof (AssetGroups));
    UIAssetsSubScene_ContentAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIAssetsSubScene_ContentAuthoring>.NativeClassPtr, 100663327);
    UIAssetsSubScene_ContentAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIAssetsSubScene_ContentAuthoring>.NativeClassPtr, 100663328);
  }

  public UIAssetsSubScene_ContentAuthoring(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe List<UnityEngine.Object> Assets
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIAssetsSubScene_ContentAuthoring.NativeFieldInfoPtr_Assets));
      return pointer == System.IntPtr.Zero ? (List<UnityEngine.Object>) null : new List<UnityEngine.Object>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIAssetsSubScene_ContentAuthoring.NativeFieldInfoPtr_Assets), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<UIAssetsSubScene_ContentAuthoring.AssetGroup> AssetGroups
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIAssetsSubScene_ContentAuthoring.NativeFieldInfoPtr_AssetGroups));
      return pointer == System.IntPtr.Zero ? (List<UIAssetsSubScene_ContentAuthoring.AssetGroup>) null : new List<UIAssetsSubScene_ContentAuthoring.AssetGroup>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIAssetsSubScene_ContentAuthoring.NativeFieldInfoPtr_AssetGroups), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  public sealed class AssetGroup : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Name;
    private static readonly System.IntPtr NativeFieldInfoPtr_Assets;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsAutogenerated;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AssetGroup_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 912063, XrefRangeEnd = 912075, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(UIAssetsSubScene_ContentAuthoring.AssetGroup other)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other));
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UIAssetsSubScene_ContentAuthoring.AssetGroup.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AssetGroup_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 912075, XrefRangeEnd = 912076, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe int GetHashCode()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UIAssetsSubScene_ContentAuthoring.AssetGroup.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    static AssetGroup()
    {
      Il2CppClassPointerStore<UIAssetsSubScene_ContentAuthoring.AssetGroup>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIAssetsSubScene_ContentAuthoring>.NativeClassPtr, nameof (AssetGroup));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIAssetsSubScene_ContentAuthoring.AssetGroup>.NativeClassPtr);
      UIAssetsSubScene_ContentAuthoring.AssetGroup.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIAssetsSubScene_ContentAuthoring.AssetGroup>.NativeClassPtr, nameof (Name));
      UIAssetsSubScene_ContentAuthoring.AssetGroup.NativeFieldInfoPtr_Assets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIAssetsSubScene_ContentAuthoring.AssetGroup>.NativeClassPtr, nameof (Assets));
      UIAssetsSubScene_ContentAuthoring.AssetGroup.NativeFieldInfoPtr_IsAutogenerated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIAssetsSubScene_ContentAuthoring.AssetGroup>.NativeClassPtr, nameof (IsAutogenerated));
      UIAssetsSubScene_ContentAuthoring.AssetGroup.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AssetGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIAssetsSubScene_ContentAuthoring.AssetGroup>.NativeClassPtr, 100663329);
      UIAssetsSubScene_ContentAuthoring.AssetGroup.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIAssetsSubScene_ContentAuthoring.AssetGroup>.NativeClassPtr, 100663330);
    }

    public AssetGroup(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public AssetGroup()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UIAssetsSubScene_ContentAuthoring.AssetGroup>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UIAssetsSubScene_ContentAuthoring.AssetGroup>.NativeClassPtr, data));
    }

    public unsafe string Name
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIAssetsSubScene_ContentAuthoring.AssetGroup.NativeFieldInfoPtr_Name)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIAssetsSubScene_ContentAuthoring.AssetGroup.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe List<UnityEngine.Object> Assets
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIAssetsSubScene_ContentAuthoring.AssetGroup.NativeFieldInfoPtr_Assets));
        return pointer == System.IntPtr.Zero ? (List<UnityEngine.Object>) null : new List<UnityEngine.Object>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIAssetsSubScene_ContentAuthoring.AssetGroup.NativeFieldInfoPtr_Assets), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool IsAutogenerated
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIAssetsSubScene_ContentAuthoring.AssetGroup.NativeFieldInfoPtr_IsAutogenerated));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIAssetsSubScene_ContentAuthoring.AssetGroup.NativeFieldInfoPtr_IsAutogenerated)) = value;
      }
    }
  }
}
