// Decompiled with JetBrains decompiler
// Type: ProjectM.ImpactEffectsMappingAsset
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Malee;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class ImpactEffectsMappingAsset : ScriptableObject
  {
    private static readonly IntPtr NativeFieldInfoPtr_ImpactMaterials;
    private static readonly IntPtr NativeFieldInfoPtr__Guid;
    private static readonly IntPtr NativeMethodInfoPtr_get_PrefabGUID_Public_get_PrefabGUID_0;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public unsafe PrefabGUID PrefabGUID
    {
      [CallerCount(9), CachedScanResults(RefRangeStart = 726435, RefRangeEnd = 726444, XrefRangeStart = 726435, XrefRangeEnd = 726444, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(ImpactEffectsMappingAsset.NativeMethodInfoPtr_get_PrefabGUID_Public_get_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067417, XrefRangeEnd = 1067455, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &dstManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ImpactEffectsMappingAsset.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ImpactEffectsMappingAsset()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ImpactEffectsMappingAsset>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ImpactEffectsMappingAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ImpactEffectsMappingAsset()
    {
      Il2CppClassPointerStore<ImpactEffectsMappingAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ImpactEffectsMappingAsset));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImpactEffectsMappingAsset>.NativeClassPtr);
      ImpactEffectsMappingAsset.NativeFieldInfoPtr_ImpactMaterials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImpactEffectsMappingAsset>.NativeClassPtr, nameof (ImpactMaterials));
      ImpactEffectsMappingAsset.NativeFieldInfoPtr__Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImpactEffectsMappingAsset>.NativeClassPtr, nameof (_Guid));
      ImpactEffectsMappingAsset.NativeMethodInfoPtr_get_PrefabGUID_Public_get_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImpactEffectsMappingAsset>.NativeClassPtr, 100683966);
      ImpactEffectsMappingAsset.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImpactEffectsMappingAsset>.NativeClassPtr, 100683967);
      ImpactEffectsMappingAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImpactEffectsMappingAsset>.NativeClassPtr, 100683968);
    }

    public ImpactEffectsMappingAsset(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe ImpactEffectsMappingAsset.ImpactMaterialDataArray ImpactMaterials
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ImpactEffectsMappingAsset.NativeFieldInfoPtr_ImpactMaterials));
        return pointer == IntPtr.Zero ? (ImpactEffectsMappingAsset.ImpactMaterialDataArray) null : new ImpactEffectsMappingAsset.ImpactMaterialDataArray(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ImpactEffectsMappingAsset.NativeFieldInfoPtr_ImpactMaterials), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe string _Guid
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ImpactEffectsMappingAsset.NativeFieldInfoPtr__Guid)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ImpactEffectsMappingAsset.NativeFieldInfoPtr__Guid), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    [Serializable]
    public class ImpactMaterialDataArray : ReorderableArray<ImpactMaterialEditorData>
    {
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067414, XrefRangeEnd = 1067417, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe ImpactMaterialDataArray()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ImpactEffectsMappingAsset.ImpactMaterialDataArray>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ImpactEffectsMappingAsset.ImpactMaterialDataArray.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static ImpactMaterialDataArray()
      {
        Il2CppClassPointerStore<ImpactEffectsMappingAsset.ImpactMaterialDataArray>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ImpactEffectsMappingAsset>.NativeClassPtr, nameof (ImpactMaterialDataArray));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImpactEffectsMappingAsset.ImpactMaterialDataArray>.NativeClassPtr);
        ImpactEffectsMappingAsset.ImpactMaterialDataArray.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImpactEffectsMappingAsset.ImpactMaterialDataArray>.NativeClassPtr, 100683969);
      }

      public ImpactMaterialDataArray(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
